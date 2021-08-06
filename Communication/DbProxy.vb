Imports System.Data.SQLite

''' <summary>
''' Thread-safe proxy object to handle SQLite database interactions.
''' </summary>
Public Class DbProxy

    Public Event ConnectionStatusChanged As EventHandler
    Private Const _connectionString As String = "Data Source=SkyObjectDB.db" 'local dir

    'Static instance variable
    Private Shared _proxyInstance As New Lazy(Of DbProxy)(Function() New DbProxy(), Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    'return instance
    Public Shared ReadOnly Property Instance As DbProxy
        Get
            Return _proxyInstance.Value
        End Get
    End Property

    Private _connected As Boolean
    Public ReadOnly Property IsConnected As Boolean
        Get
            Return _connected
        End Get
    End Property

    'raise connection changed event
    Private Sub OnConnectionChanged(e As EventArgs)
        RaiseEvent ConnectionStatusChanged(Me, e)
    End Sub

    'Hidden constructor to enforce Singleton pattern
    Private Sub New()
        'run a test connection, raise event to alert main form
        Try
            Using connection As New SQLiteConnection(_connectionString)
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    _connected = True
                Else
                    _connected = False
                End If
            End Using
        Catch ex As Exception
            _connected = False
        End Try
        OnConnectionChanged(EventArgs.Empty)
    End Sub

    ''' <summary>
    ''' Checks the db for the existence of a supplied user. 
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns>Returns true if username and password match. Definitely more secure ways of doing this.</returns>
    Public Function ValidateUser(user As User) As Boolean
        Dim name As String = user.Username
        Dim password As String = user.Password
        If Not String.IsNullOrWhiteSpace(name) AndAlso Not String.IsNullOrWhiteSpace(password) Then
            Try
                Using connection As New SQLiteConnection(_connectionString),
                        cmd As New SQLiteCommand("SELECT * FROM Users WHERE Username = '" & name & "' LIMIT 1;", connection)
                    connection.Open()
                    Using reader As SQLiteDataReader = cmd.ExecuteReader
                        While (reader.Read())
                            If reader.GetValue(1) = name AndAlso reader.GetValue(2) = password Then
                                Return True
                            End If
                        End While
                    End Using
                End Using
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    ''' <summary>
    ''' Creates a user record if the unique username constraint is satisfied.
    ''' </summary>
    ''' <param name="newUser"></param>
    ''' <returns>Returns a message indicating success/failure.</returns>
    Public Function CreateUser(newUser As User) As String
        Dim name As String = newUser.Username
        Dim password As String = newUser.Password
        If Not String.IsNullOrWhiteSpace(name) AndAlso Not String.IsNullOrWhiteSpace(password) Then
            Try
                Using connection As New SQLiteConnection(_connectionString),
                    cmd As New SQLiteCommand("INSERT INTO Users (Username, Password) VALUES (@username, @password)", connection)
                    cmd.Parameters.AddWithValue("@username", name)
                    cmd.Parameters.AddWithValue("@password", password)
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    Return "success"
                End Using
            Catch ex As SQLiteException When ex.ErrorCode = 19 'username constraint
                Return "exists"
            Catch ex As Exception
                Return "error"
            End Try
        Else
            Return "invalid"
        End If
    End Function

    ''' <summary>
    ''' Inserts a new ILoggable record into the Objects table. Associates record with a user.
    ''' </summary>
    ''' <param name="loggableObject"></param>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function LogItem(loggableObject As ILoggable, user As String) As Boolean
        Dim success As Boolean
        Try
            Using connection As New SQLiteConnection(_connectionString),
                    cmd As New SQLiteCommand("INSERT INTO Objects (Type, Name, Notes, Timestamp, User) VALUES (@type, @name, @notes, @timestamp, @user)", connection)
                cmd.Parameters.AddWithValue("@type", loggableObject.ObjectType)
                cmd.Parameters.AddWithValue("@name", loggableObject.Name)
                cmd.Parameters.AddWithValue("@notes", loggableObject.Notes)
                cmd.Parameters.AddWithValue("@timestamp", loggableObject.Timestamp)
                cmd.Parameters.AddWithValue("@user", user)
                connection.Open()
                cmd.ExecuteNonQuery()
                success = True
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            success = False
        End Try
        Return success
    End Function

    'TODO: Implement actual timestamps
    Public Function GetLoggedItems(user As String, Optional timestamp As Date = Nothing) As List(Of ILoggable)
        Dim loggedItems As New List(Of ILoggable)
        Try
            Using connection As New SQLiteConnection(_connectionString),
                cmd As New SQLiteCommand("SELECT * FROM Objects WHERE User = '" & user & "'", connection)
                connection.Open()
                Using reader As SQLiteDataReader = cmd.ExecuteReader
                    While (reader.Read())
                        loggedItems.Add(New DbRecord(reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4)))
                    End While
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return loggedItems
    End Function

End Class
