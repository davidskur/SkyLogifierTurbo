Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json

''' <summary>
''' Similar approach to the DbProxy class: Thread-safe singleton.
''' </summary>
Public Class WebProxy

    Private Shared ReadOnly httpClient As HttpClient = New HttpClient() 'From the Docs: Client is intended to be instantiated once per application.
    Private Shared _proxyInstance As New Lazy(Of WebProxy)(Function() New WebProxy(), Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    'return instance
    Public Shared ReadOnly Property Instance As WebProxy
        Get
            Return _proxyInstance.Value
        End Get
    End Property

    Public Property RecentBirds As List(Of JsonBird)

    'enforce singleton pattern
    Private Sub New()
        httpClient.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    'Hit the eBird API for recent bird sightings using the older webclient. I've marked it as obsolete to alert callers.
    <Obsolete>
    Public Function GetRecentBirdSightings(apiKey As String) As Boolean
        Using client As New WebClient()
            client.Headers.Add("X-eBirdApiToken", apiKey)
            Try
                Dim result = client.DownloadString("https://api.ebird.org/v2/data/obs/geo/recent?lat=42.96546&lng=-85.67017") 'lat/lon for Grand Rapids
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return False
        End Using
    End Function

    ''' <summary>
    ''' Hit the eBird API for recent bird sightings using the newer HTTP client. 
    ''' I originally hard-coded my API key, but I didn't want to ship with that in place,
    ''' so I sent it to you in an email. I trust you to not get me banned from the service! :D -Dave
    ''' </summary>
    ''' <param name="apiKey"></param>
    ''' <returns></returns>
    Public Async Function GetRecentBirdSightingsAsync(apiKey As String) As Task(Of Boolean)
        Dim request As New HttpRequestMessage With
        {
            .RequestUri = New Uri($"https://api.ebird.org/v2/data/obs/geo/recent?key={apiKey}&back=7&lat=42.96546&lng=-85.67017&maxResults=50"),
            .Method = HttpMethod.Get
        }
        Try
            Dim response = Await httpClient.SendAsync(request)
            If response.IsSuccessStatusCode Then
                Using content As HttpContent = response.Content
                    Dim result As String = Await content.ReadAsStringAsync()
                    If result IsNot Nothing Then
                        Dim observedBirds = JsonConvert.DeserializeObject(Of JsonBird())(result)
                        Dim newForm As New BirdObservations(observedBirds)
                        newForm.ShowDialog()
                    End If
                End Using
            End If
        Catch ex As HttpRequestException
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Get current ISS data from API
    ''' </summary>
    ''' <returns></returns>
    Public Async Function GetIssPositionAsync() As Task(Of Boolean)
        Dim request As New HttpRequestMessage With
        {
            .RequestUri = New Uri("https://api.wheretheiss.at/v1/satellites/25544"),
            .Method = HttpMethod.Get
        }
        Dim response = Await httpClient.SendAsync(request)
        If response.IsSuccessStatusCode Then
            Using content As HttpContent = response.Content
                Dim result As String = Await content.ReadAsStringAsync()
                If result IsNot Nothing Then
                    Dim stationDeets = JsonConvert.DeserializeObject(Of JsonStation)(result)
                    Dim formattedString As String = $"The Space Station is at {stationDeets.latitude}, {stationDeets.longitude}.{Environment.NewLine}"
                    formattedString += $"{Environment.NewLine}Current Visibility: {stationDeets.visibility}{Environment.NewLine}"
                    formattedString += $"Current Velocity: {String.Format("{0:0.00}", stationDeets.velocity)} kph.{Environment.NewLine}"
                    formattedString += $"Current Altitude: {String.Format("{0:0.00}", stationDeets.altitude)} km"

                    MessageBox.Show(formattedString, "ISS Position", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End If
        Return False
    End Function

End Class
