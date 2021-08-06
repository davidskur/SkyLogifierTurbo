Imports System.ComponentModel

Public Class User
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private _username As String
    Public ReadOnly Property Username As String
        Get
            Return _username
        End Get
    End Property

    'NEVER implement passwords like this in anything non-trivial :-D
    Private _password As String
    Public ReadOnly Property Password As String
        Get
            Return _password
        End Get
    End Property

    Public Sub New()
        _username = "default"
        _password = "default"
    End Sub

    Public Sub New(username As String, password As String)
        _username = username
        _password = password
    End Sub

    Private Sub OnUsernameChanged(Optional source As String = Nothing)
        Try
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(source))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
