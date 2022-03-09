Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Folders

    Private Sub ButtonENCRIPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonENCRIPTAR.Click
        Try
            For Each MIARCHIVO In My.Computer.FileSystem.GetFiles(TextBoxORIGEN.Text, FileIO.SearchOption.SearchAllSubDirectories)

                'PARA MANTENER EN DESTINO LA ESTRUCTURA DE SUBCARPETAS IGUAL A ORIGEN
                Dim SUBCARPETA As String = MIARCHIVO.Replace(TextBoxORIGEN.Text, TextBoxDESTINO.Text)
                SUBCARPETA = SUBCARPETA.Substring(0, SUBCARPETA.LastIndexOf("\") + 1)
                If My.Computer.FileSystem.DirectoryExists(SUBCARPETA) = False Then
                    My.Computer.FileSystem.CreateDirectory(SUBCARPETA)
                End If

                Dim NOMBRE As String = MIARCHIVO.Remove(0, MIARCHIVO.LastIndexOf("\") + 1) 'CONSERVA EL NOMBRE DEL ARCHIVO
                'ENCRIPTADO
                Try
                    'PONE EL ARCHIVO A CONVERTIR EN BYTES
                    Dim ARCHIVO As Byte() = File.ReadAllBytes(MIARCHIVO)
                    Dim TAMAÑO As Long = ARCHIVO.Length

                    'PREPARA LA CLAVE PARA LA ENCRIPTACION
                    Dim MD5 As New MD5CryptoServiceProvider 'PREPARA LA CLAVE PARA LA ENCRIPTACION
                    Dim CLAVE As Byte() = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(TextBoxCLAVE.Text))
                    MD5.Clear()

                    'DEFINE EL TIPO DE ENCRIPTADO
                    Dim TDC As New TripleDESCryptoServiceProvider
                    TDC.Key = CLAVE
                    TDC.Mode = CipherMode.ECB

                    'CREA E INICIALIZA EL STREAM PARA EL DESTINO
                    Dim DESTINO As New FileStream(SUBCARPETA & NOMBRE, FileMode.OpenOrCreate, FileAccess.Write)

                    'CREA E INICIALIZA EL STREAM PARA LA ENCRIPTACION
                    Dim ENCRIPTADO As New CryptoStream(DESTINO, TDC.CreateEncryptor, CryptoStreamMode.Write)

                    'ENCRIPTA
                    ENCRIPTADO.Write(ARCHIVO, 0, TAMAÑO)

                    DESTINO.Close() 'CIERRA EL STREAM DESTINO

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            MsgBox("Encriptado Correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonDESENCRIPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDESENCRIPTAR.Click
        Try
            For Each MIARCHIVO In My.Computer.FileSystem.GetFiles(TextBoxORIGEN.Text, FileIO.SearchOption.SearchAllSubDirectories)

                'PARA MANTENER EN DESTINO LA ESTRUCTURA DE SUBCARPETAS IGUAL A ORIGEN
                Dim SUBCARPETA As String = MIARCHIVO.Replace(TextBoxORIGEN.Text, TextBoxDESTINO.Text)
                SUBCARPETA = SUBCARPETA.Substring(0, SUBCARPETA.LastIndexOf("\") + 1)
                If My.Computer.FileSystem.DirectoryExists(SUBCARPETA) = False Then
                    My.Computer.FileSystem.CreateDirectory(SUBCARPETA)
                End If

                Dim NOMBRE As String = MIARCHIVO.Remove(0, MIARCHIVO.LastIndexOf("\") + 1) 'CONSERVA EL NOMBRE DEL ARCHIVO
                'ENCRIPTADO
                Try
                    'PONE EL ARCHIVO A CONVERTIR EN BYTES
                    Dim ARCHIVO As Byte() = File.ReadAllBytes(MIARCHIVO)
                    Dim TAMAÑO As Long = ARCHIVO.Length

                    'PREPARA LA CLAVE PARA LA ENCRIPTACION
                    Dim MD5 As New MD5CryptoServiceProvider 'PREPARA LA CLAVE PARA LA ENCRIPTACION
                    Dim CLAVE As Byte() = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(TextBoxCLAVE.Text))
                    MD5.Clear()

                    'DEFINE EL TIPO DE ENCRIPTADO
                    Dim TDC As New TripleDESCryptoServiceProvider
                    TDC.Key = CLAVE
                    TDC.Mode = CipherMode.ECB

                    'CREA E INICIALIZA EL STREAM PARA EL DESTINO
                    Dim DESTINO As New FileStream(SUBCARPETA & NOMBRE, FileMode.OpenOrCreate, FileAccess.Write)

                    'CREA E INICIALIZA EL STREAM PARA LA ENCRIPTACION
                    Dim ENCRIPTADO As New CryptoStream(DESTINO, TDC.CreateDecryptor, CryptoStreamMode.Write)

                    'ENCRIPTA
                    ENCRIPTADO.Write(ARCHIVO, 0, TAMAÑO)

                    DESTINO.Close() 'CIERRA EL STREAM DESTINO

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            MsgBox("Desencriptado Correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'ELIMINA LA CARPETA ORIGEN
    Private Sub ButtonELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonELIMINAR.Click
        Dim DIALOGO As DialogResult = MessageBox.Show("Esto eliminara la Carpeta de Origen ¿Seguro que quieres Hacerlo?", "Worcome Security", MessageBoxButtons.OKCancel)
        If DIALOGO = MsgBoxResult.Ok Then
            My.Computer.FileSystem.DeleteDirectory(TextBoxORIGEN.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label4.Text = "Mostrar" Then
            TextBoxCLAVE.PasswordChar = Nothing
            Label4.Text = "Ocultar"
        ElseIf Label4.Text = "Ocultar" Then
            TextBoxCLAVE.PasswordChar = "●"
            Label4.Text = "Mostrar"
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        MsgBox("El Directorio de Origen es la Ruta de la Carpeta que sera Encriptada", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MsgBox("El Directorio de Destino es la Carpeta de Origen que ya esta Encriptada" & vbCrLf & "Crea una Carpeta con los Archivos ya Encriptados, Si elige la Misma ruta que en Directorio de Origen, Se sobreescribira el Contenido", MsgBoxStyle.Information, "Worcome Security")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If FolderBrowserDialog1.ShowDialog Then 'ELIGE ORIGEN
            TextBoxORIGEN.Text = FolderBrowserDialog1.SelectedPath
            If TextBoxDESTINO.Text = TextBoxORIGEN.Text Then 'SI LA CARPETA DESTINO ES LA MISMA QUE LA ORIGEN MOSTRARA UN MENSAJE
                MsgBox("ESTO SOBREESCRIBIRA TODO EL CONTENIDO DE LA CARPETA ORIGEN", MsgBoxStyle.Exclamation, "Worcome Security")
            End If
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If FolderBrowserDialog1.ShowDialog Then 'ELIGE DESTINO
            TextBoxDESTINO.Text = FolderBrowserDialog1.SelectedPath
            If TextBoxDESTINO.Text = TextBoxORIGEN.Text Then 'SI LA CARPETA DESTINO ES LA MISMA QUE LA ORIGEN MOSTRARA UN MENSAJE
                MsgBox("ESTO SOBREESCRIBIRA TODO EL CONTENIDO DE LA CARPETA ORIGEN", MsgBoxStyle.Exclamation, "Worcome Security")
            End If
        End If
    End Sub

    Private Sub FolderEncryptor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
    End Sub

    Private Sub Encrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
