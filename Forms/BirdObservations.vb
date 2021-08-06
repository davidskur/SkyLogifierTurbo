Public Class BirdObservations

    Private _birds As JsonBird()

    Public Sub New(birds As JsonBird())
        InitializeComponent()
        _birds = birds
    End Sub

    Private Sub BirdObservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each bird In _birds
            Dim formattedString = $"{bird.howMany} {bird.comName}(s) seen on {bird.obsDt} near {bird.locName}."
            lbObservedBirds.Items.Add(formattedString)
        Next
    End Sub

End Class