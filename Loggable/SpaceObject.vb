Public Class SpaceObject
    Inherits LoggableObject

    Public Sub New(name As String, notes As String, timestamp As String)
        _type = "Space Object"
        _name = name
        _notes = notes
        _timeStamp = timestamp
    End Sub

End Class
