Public Class SignUp

    Private Sub SignUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub SignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Rellene con la Informacion Solicitada", MsgBoxStyle.Critical, "Worcome Security")
        Else
            My.Settings.UserName = TextBox1.Text
            My.Settings.Password = TextBox2.Text
            My.Settings.IsRegistered = True
            My.Settings.Save()
            My.Settings.Reload()
            SignIn.Show()
            Me.Hide()
        End If
    End Sub
End Class