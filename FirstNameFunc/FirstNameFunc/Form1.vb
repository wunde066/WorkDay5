Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text

        Dim result As String
        result = FirstName(name)
        txtFirstName.Text = result
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim idx As Integer
        idx = name.IndexOf(" ")

        Dim fname As String
        fname = name.Substring(0, idx)

        Return fname
    End Function

End Class
