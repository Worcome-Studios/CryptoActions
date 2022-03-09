Public Class SignIn

    Private Sub SignIn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub SignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Rellene con la Informacion Solicitada", MsgBoxStyle.Critical, "Worcome Security")
        Else
            If TextBox1.Text = My.Settings.UserName And TextBox2.Text = My.Settings.Password Then
                Selector.Show()
                Me.Hide()
            Else
                MsgBox("Los Datos no Coinciden con el Registro", MsgBoxStyle.Critical, "Worcome Security")
            End If
        End If
    End Sub
End Class