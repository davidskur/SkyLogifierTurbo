Public Class Plane
    Inherits LoggableObject

    Public Sub New(name As String, notes As String, timestamp As String)
        _type = "Plane"
        _name = name
        _notes = notes
        _timeStamp = timestamp
    End Sub

End Class
