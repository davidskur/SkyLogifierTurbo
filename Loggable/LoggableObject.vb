Public MustInherit Class LoggableObject
    Implements ILoggable

    Protected _type As String
    Public ReadOnly Property ObjectType As String Implements ILoggable.ObjectType
        Get
            Return _type
        End Get
    End Property

    Protected _name As String
    Public ReadOnly Property Name As String Implements ILoggable.Name
        Get
            Return _name
        End Get
    End Property

    Protected _notes As String
    Public ReadOnly Property Notes As String Implements ILoggable.Notes
        Get
            Return _notes
        End Get
    End Property

    Protected _timeStamp As String
    Public ReadOnly Property Timestamp As String Implements ILoggable.Timestamp
        Get
            Return _timeStamp
        End Get
    End Property

End Class
