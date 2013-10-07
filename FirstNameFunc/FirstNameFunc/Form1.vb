Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        ' not uncrashable: thinking that we have nicest possible user
        Dim name As String

        name = txtFullName.Text

        'used for step through process
        Dim result As String
        result = FirstName(name)
        txtFirstName.Text = FirstName(name)

    End Sub

    Function FirstName(ByVal name As String) As String
        'find the first  space
        Dim firstspace As Integer
        firstspace = name.IndexOf(" ")

        'extract the first name
        Dim Fname As String
        Fname = name.Substring(0, firstspace)

        Return Fname

    End Function

End Class
