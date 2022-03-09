Imports System.Security.AccessControl
Imports System.IO
Imports System.Security.Principal
Public Class UnLockDirectory

    Private Sub LockDir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
    End Sub

    Private Sub LockDir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            Try
                Dim ACCESO As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
                If RadioButtonUNO.Checked Then
                    Dim USUARIO As String = InputBox("Escribe el Nombre de Usuario para Bloquear", "Worcome Security", Environment.UserName)
                    ACCESO.AddAccessRule(New FileSystemAccessRule(USUARIO, FileSystemRights.FullControl, AccessControlType.Deny))
                ElseIf RadioButtonTODOS.Checked Then
                    Dim USUARIOS As New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing)
                    ACCESO.AddAccessRule(New FileSystemAccessRule(USUARIOS, FileSystemRights.FullControl, AccessControlType.Deny))
                End If
                File.SetAccessControl(TextBox1.Text, ACCESO)
                MsgBox("Directorio Bloqueado", MsgBoxStyle.Information, "Worcome Security")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Worcome Security")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FolderBrowserDialog1.ShowDialog Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            Try
                Dim ACCESO As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
                If RadioButtonUNO.Checked Then
                    Dim USUARIO As String = InputBox("Escribe el Nombre de Usuario para Bloquear", "Worcome Security", Environment.UserName)
                    ACCESO.RemoveAccessRule(New FileSystemAccessRule(USUARIO, FileSystemRights.FullControl, AccessControlType.Deny))
                ElseIf RadioButtonTODOS.Checked Then
                    Dim USUARIOS As New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing)
                    ACCESO.RemoveAccessRule(New FileSystemAccessRule(USUARIOS, FileSystemRights.FullControl, AccessControlType.Deny))
                End If
                File.SetAccessControl(TextBox1.Text, ACCESO)
                MsgBox("Directorio Liberado", MsgBoxStyle.Information, "Worcome Security")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Worcome Security")
            End Try
        End If
    End Sub
End Class
