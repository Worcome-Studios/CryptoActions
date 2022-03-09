Public Class Debugger

    Private Sub Debugger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckRegisterData()
    End Sub

    Sub CheckRegisterData()
        If My.Settings.IsRegistered = False Then
            SignUp.Show()
            SignIn.Close()
        ElseIf My.Settings.IsRegistered = True Then
            SignIn.Show()
            SignUp.Close()
        End If
    End Sub
End Class