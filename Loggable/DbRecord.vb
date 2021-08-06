Public Class DbRecord
    Inherits LoggableObject
    Implements ILoggable

    ''' <summary>
    ''' Similar to other objects that implement ILoggable, but this allows a type to be passed in at creation.
    ''' Used to query data from the database.
    ''' </summary>
    ''' <param name="type"></param>
    ''' <param name="name"></param>
    ''' <param name="notes"></param>
    ''' <param name="time"></param>
    Public Sub New(type As String, name As String, notes As String, time As String)
        _type = type
        _name = name
        _notes = notes
        _timeStamp = time
    End Sub

End Class
