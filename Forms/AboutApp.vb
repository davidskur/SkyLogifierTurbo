Public NotInheritable Class AboutApp

    Private Sub AboutApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName

        Dim msg As String = "Welcome to Sky Log-ifier Turbo!" + Environment.NewLine
        msg += $"{Environment.NewLine}It's a bird! It's a plane! It's... the ISS? See something cool in the sky? Select the type of object it is and record it! Log in to record your observations and look back over what you've seen.{Environment.NewLine}"
        msg += $"{Environment.NewLine}There are a variety of tools included to help you determine what you've seen, ranging from public API access to links that take you to outside sources."
        Me.TextBoxDescription.Text = msg
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
