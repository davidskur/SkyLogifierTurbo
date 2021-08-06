Imports System.Timers

Public Class MainForm

#Region "Instance Variables"

    Private _resetText As String
    Private ReadOnly _DbProxy As DbProxy
    Private ReadOnly _WebProxy As WebProxy
    Private WithEvents _currentTime As New Timer With {.Interval = 1000, .Enabled = True}

#End Region

#Region "Properties"

    Private _currentUser As User
    Public Property CurrentUser As User
        Get
            Return _currentUser
        End Get
        Set(value As User)
            _currentUser = value
        End Set
    End Property

#End Region

#Region "Form Events"

    'Constructor
    Public Sub New()
        InitializeComponent()

        'Utilize proxy/singleton patterns, subscribe events
        _WebProxy = WebProxy.Instance
        _DbProxy = DbProxy.Instance
        AddHandler _DbProxy.ConnectionStatusChanged, AddressOf UpdateDbConnectionStatus

        'set default user
        CurrentUser = New User()
        AddHandler _currentUser.PropertyChanged, AddressOf OnUserUpdated
        stsCurrentUser.Text += " " + CurrentUser.Username

        'Configure message timer
        _currentTime.AutoReset = True
        AddHandler _currentTime.Elapsed, AddressOf CurrentTime_Tick
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddTimedMessage("Welcome to Sky Log-ifier Turbo!", 1500, Success)
        stsConnectionStatus.Text = If(_DbProxy.IsConnected, "~Db: Connected", "~Db: Disconnected")
        'look up recent entries for default user?
    End Sub

    'override closing event
    Private Sub OnFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim response = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Not response = DialogResult.Yes Then e.Cancel = True
    End Sub

    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Me.Close()
    End Sub

    Private Sub miLogin_Click(sender As Object, e As EventArgs) Handles miLogin.Click
        Dim loginDialog = New LoginDialog()
        AddHandler loginDialog.LoginRequested, AddressOf OnLoginRequested
        loginDialog.ShowDialog()
    End Sub

    'show about form
    Private Sub AboutApp_Click(sender As Object, e As EventArgs) Handles miAbout.Click
        Using aboutDialog As New AboutApp
            aboutDialog.ShowDialog()
        End Using
    End Sub

    'TODO: Implement date ranges
    Private Sub DateRangeChanged(sender As Object, e As EventArgs) Handles cbDateRanges.SelectedIndexChanged
        lbRecords.Items.Clear()
        Dim loggedItems As List(Of ILoggable)
        loggedItems = _DbProxy.GetLoggedItems(CurrentUser.Username)
        For Each item In loggedItems
            lbRecords.Items.Add($"Object: {item.ObjectType} - {item.Name} was seen {item.Timestamp}: '{item.Notes}'")
        Next
    End Sub

    'create a bird entry
    Private Sub btnRecordBird_Click(sender As Object, e As EventArgs) Handles btnRecordBird.Click
        Dim species, notes, timestamp As String
        species = cbSpecies.Text
        If String.IsNullOrWhiteSpace(species) Then
            lblSpecies.Text += " (Field can't be empty!)"
            Exit Sub
        Else
            notes = tbBirdNotes.Text
            timestamp = Now
            If _DbProxy.LogItem(New Bird(species, notes, timestamp), CurrentUser.Username) Then
                AddTimedMessage("New bird sighting added!", 2000, Success)
                cbSpecies.SelectedIndex = -1
                tbBirdNotes.Clear()
            Else
                AddTimedMessage("Error adding record!", 2000, Err)
            End If
        End If
    End Sub

    'create a plane entry
    Private Sub btnRecordPlane_Click(sender As Object, e As EventArgs) Handles btnRecordPlane.Click
        Dim plane, notes, timestamp As String
        plane = cbPlaneModel.Text
        If String.IsNullOrWhiteSpace(plane) Then
            lblPlaneModel.Text += " (Field can't be empty!)"
            Exit Sub
        Else
            notes = tbPlaneNotes.Text
            timestamp = Now
            If _DbProxy.LogItem(New Plane(plane, notes, timestamp), CurrentUser.Username) Then
                AddTimedMessage("New plane sighting added!", 2000, Success)
                cbPlaneModel.SelectedIndex = -1
                tbPlaneNotes.Clear()
            Else
                AddTimedMessage("Error adding record!", 2000, Err)
            End If
        End If
    End Sub

    'create a space entry
    Private Sub btnRecordSpaceObject_Click(sender As Object, e As EventArgs) Handles btnRecordSpaceObject.Click
        Dim spaceObj, notes, timestamp As String
        spaceObj = tbSpaceObjectName.Text
        If String.IsNullOrWhiteSpace(spaceObj) Then
            lblSpaceObjectName.Text += " (Field can't be empty!)"
            Exit Sub
        Else
            notes = tbSpaceNotes.Text
            timestamp = Now
            If _DbProxy.LogItem(New SpaceObject(spaceObj, notes, timestamp), CurrentUser.Username) Then
                AddTimedMessage("New space object sighting added!", 2000, Success)
                tbSpaceObjectName.Clear()
                tbSpaceNotes.Clear()
            Else
                AddTimedMessage("Error adding record!", 2000, Err)
            End If
        End If
    End Sub

    'Invoke _WebProxy object to sent GET requests to eBird API.
    Private Sub btnGetRecentBirdSightings_Click(sender As Object, e As EventArgs) Handles btnGetRecentSightings.Click
        Dim key = InputBox("Enter a valid API key", "API Credentials")
        If Not String.IsNullOrWhiteSpace(key) Then
            'WinForms doesn't like the .result operator without having everything up the stack be async.
            'Just discarding the results and letting my proxy object open a new form. Not optimal, but it works fine for the assignment.
            Dim result = _WebProxy.GetRecentBirdSightingsAsync(key)
        End If
    End Sub

    'Invoke _WebProxy object to sent GET requests to ISS API
    Private Sub btnGetIssPos_Click(sender As Object, e As EventArgs) Handles btnGetIssPos.Click
        'no API key needed, requests are rate-limited
        Dim result = _WebProxy.GetIssPositionAsync()
    End Sub

    'Methods to open the default web browser at a specified address
    Private Sub btnFieldGuide_Click(sender As Object, e As EventArgs) Handles btnBirdFieldGuide.Click
        Dim address As String = "https://www.audubon.org/bird-guide"
        StartWebProcess(address)
    End Sub

    Private Sub btnPlaneRef_Click(sender As Object, e As EventArgs) Handles btnPlaneRef.Click
        Dim address As String = "https://www.airpartner.com/en/aircraft-guide/"
        StartWebProcess(address)
    End Sub

    Private Sub btnSpaceRef_Click(sender As Object, e As EventArgs) Handles btnSpaceRef.Click
        If rbManMade.Checked Then

        ElseIf rbNaturalObject.Checked Then
            Dim address As String = "http://astrotx.com/Deep%20Space%20Object%20Catalogs.pdf"
            StartWebProcess(address)
        End If
    End Sub

    Private Sub btnSpaceOverhead_Click(sender As Object, e As EventArgs) Handles btnSpaceOverhead.Click
        Dim address As String
        If rbManMade.Checked Then
            address = "https://celestrak.com/"
        Else
            address = "https://www.timeanddate.com/astronomy/night/"
        End If
        StartWebProcess(address)
    End Sub

    Private Sub btnLivePlanes_Click(sender As Object, e As EventArgs) Handles btnLivePlanes.Click
        Dim address As String = "https://www.flightradar24.com/43.07,-85.68/7" 'midwest coordinates
        StartWebProcess(address)
    End Sub

#End Region

#Region "UI Methods"

    Private Sub StartWebProcess(url As String)
        Try
            Process.Start(url)
        Catch ex As Exception
            AddTimedMessage("Error starting web process!", 1500, Err)
        End Try
    End Sub

    ''' <summary>
    ''' Looks up a user from the supplied credentials sent from the LoginDialog event. 
    ''' Tries to create the account if credentials don't match. 
    ''' </summary>
    ''' <param name="user"></param>
    Private Sub OnLoginRequested(user As User)
        If user IsNot Nothing Then
            If _DbProxy.ValidateUser(user) Then
                CheckUser(user)
            Else
                Dim response = MessageBox.Show($"Invalid credentials.{Environment.NewLine}Try to create the account?", "Create User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = DialogResult.Yes Then
                    Dim message As String = _DbProxy.CreateUser(user)
                    If message = "success" Then
                        CheckUser(user)
                    ElseIf message = "exists" Then
                        AddTimedMessage($"User already exists!", 1500, Warning)
                    Else
                        AddTimedMessage($"An error occurred while creating the account.", 1500, Err)
                    End If
                End If
            End If
        End If
        lblCurrentUser.Text = $"{CurrentUser.Username}'s Log"
        stsCurrentUser.Text = $"Current User: {CurrentUser.Username}"
    End Sub

    'Duplicate code in OnLoginRequested.
    Private Sub CheckUser(user As User)
        If _DbProxy.ValidateUser(user) Then
            CurrentUser = user
            miLogin.Text = "Logout"
            AddTimedMessage($"{_currentUser.Username} has logged in.", 1500, Success)
        End If
    End Sub

    Private Sub OnUserUpdated()
        'TODO: Handle property changed event
    End Sub

    'Subscribed handler to test db connection status, update status strip
    Private Sub UpdateDbConnectionStatus(sender As Object, e As EventArgs)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() UpdateDbConnectionStatus(sender, e))
        Else
            stsConnectionStatus.Text = If(_DbProxy.IsConnected, "DB Connected", "DB Disconnected")
        End If
    End Sub

    'Permanently sets the messageviewer text and color
    Private Sub SetMessage(newText As String, Optional color As Color = Nothing)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() SetMessage(newText))
        Else
            MessageViewer.Text = newText
            MessageViewer.BackColor = If(color <> Nothing, color, Color.LightSteelBlue)
        End If
    End Sub

    'Adds a timed message to the main form header label
    Private Sub AddTimedMessage(newText As String, duration As UShort, Optional color As Color = Nothing)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() AddTimedMessage(newText, duration))
        Else
            'Update message
            _resetText = MessageViewer.Text
            MessageViewer.Text = newText
            MessageViewer.BackColor = If(color <> Nothing, color, Information)

            'Start timer
            Dim messageTimer As New Timer(duration)
            AddHandler messageTimer.Elapsed, New ElapsedEventHandler(AddressOf OnShowMessage_TimerElapsed)
            messageTimer.AutoReset = False
            messageTimer.Start()
        End If
    End Sub

    Private Sub OnShowMessage_TimerElapsed(sender As Object, e As ElapsedEventArgs)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() OnShowMessage_TimerElapsed(sender, e))
        Else
            MessageViewer.Text = _resetText
            MessageViewer.BackColor = Information
            Dim obj = TryCast(sender, Timer)
            If obj IsNot Nothing Then obj.Dispose()
        End If
    End Sub

    Private Sub CurrentTime_Tick(sender As Object, e As EventArgs)
        stsTime.Text = TimeOfDay.ToString("HH:mm:ss tt")
    End Sub

#End Region

End Class
