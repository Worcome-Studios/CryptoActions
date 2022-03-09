Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class StringAndFiles
    Dim des As New TripleDESCryptoServiceProvider
    Dim hashmd5 As New MD5CryptoServiceProvider
    Dim ModeCryptStrings As New CipherMode
    Dim ModeCryptFiles As New CipherMode

    Private Sub FileEncryptor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
    End Sub

    Private Sub FileEncryptor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region "Crypto"
    Function CreateRandomString(ByVal StartingText As String)
        Dim obj As New Random()
        Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim longitud As Integer = posibles.Length
        Dim letra As Char
        Dim longitudnuevacadena As Integer = StartingText.Length
        Dim nuevacadena As String = Nothing
        For i As Integer = 0 To longitudnuevacadena - 1
            letra = posibles(obj.[Next](longitud))
            nuevacadena += letra.ToString()
        Next
        Return nuevacadena
    End Function

    Function Encriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(TextBox1.Text))
            des.Mode = ModeCryptStrings
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function
    Function Descencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Descencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(TextBox1.Text))
            des.Mode = ModeCryptStrings
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Descencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Descencriptar
    End Function

    Sub CallEncrypt(ByVal FileIN As String, ByVal FileOUT As String)
        Try
            Dim buffer As Byte()
            Using fs As New FileStream(FileIN, FileMode.Open, FileAccess.Read)
                Using ms As New MemoryStream()
                    Encrypt(fs, ms, TextBox4.Text)
                    buffer = ms.ToArray()
                End Using
            End Using
            Using fs As New FileStream(FileOUT, FileMode.CreateNew, FileAccess.Write)
                fs.Write(buffer, 0, buffer.Length)
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Sub CallDecrypt(ByVal FileIN As String, ByVal FileOUT As String)
        Try
            Dim buffer As Byte() = Nothing
            Using fs As New FileStream(FileIN, FileMode.Open, FileAccess.Read)
                Using ms As New MemoryStream()
                    Decrypt(fs, ms, TextBox4.Text)
                    buffer = ms.ToArray()
                End Using
            End Using
            Using fs As New FileStream(FileOUT, FileMode.CreateNew, FileAccess.Write)
                fs.Write(buffer, 0, buffer.Length)
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Sub Decrypt(inStream As Stream, outStream As Stream, pwd As String)
        Try
            Dim aes As New AesCryptoServiceProvider()
            aes.Mode = ModeCryptFiles
            aes.Key() = GetDeriveBytes(pwd, 32)
            aes.IV = GetDeriveBytes(pwd, 16)
            Dim stream As New CryptoStream(inStream, aes.CreateDecryptor(), CryptoStreamMode.Read)
            Dim length As Integer = 2048
            Dim buffer As Byte() = New Byte(length - 1) {}
            Try
                Dim i As Integer = stream.Read(buffer, 0, length)
                Do While (i > 0)
                    outStream.Write(buffer, 0, i)
                    i = stream.Read(buffer, 0, length)
                Loop
            Finally
                aes.Dispose()
                buffer = Nothing
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Sub Encrypt(inStream As Stream, outStream As Stream, pwd As String)
        Try
            Dim aes As New AesCryptoServiceProvider()
            aes.Mode = ModeCryptFiles
            aes.Key() = GetDeriveBytes(pwd, 32)
            aes.IV = GetDeriveBytes(pwd, 16)
            Dim stream As New CryptoStream(outStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
            Dim length As Integer = 2048
            Dim buffer As Byte() = New Byte(length - 1) {}
            Try
                Dim i As Integer = inStream.Read(buffer, 0, length)
                Do While (i > 0)
                    stream.Write(buffer, 0, i)
                    i = inStream.Read(buffer, 0, length)
                Loop
            Finally
                stream.FlushFinalBlock()
                aes.Dispose()
                buffer = Nothing
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Function GetDeriveBytes(password As String, size As Integer) As Byte()
        If ((String.IsNullOrWhiteSpace(password)) OrElse (password.Length < 8)) Then
            MsgBox("Error en el Modulo 'GetDeriveBytes'" & vbCrLf & "La llave criptografica debe tener mas de 8 caracteres", MsgBoxStyle.Critical, "SystemTrail Modules")
        End If
        If ((size < 1) OrElse (size > 128)) Then
            MsgBox("Error en el Modulo 'GetDeriveBytes'" & vbCrLf & "El tamaño tiene que estar comprendido entre 1 y 128.", MsgBoxStyle.Critical, "SystemTrail Modules")
        End If
        Dim pwd As Byte() = UTF8Encoding.UTF8.GetBytes(password)
        Dim salt As Byte() = UTF8Encoding.UTF8.GetBytes(Convert.ToBase64String(pwd))
        Using bytes As New Rfc2898DeriveBytes(pwd, salt, 1000)
            Return bytes.GetBytes(size)
        End Using
    End Function
#End Region

#Region "Strings"
    Private Sub btnCifrar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            RichTextBox2.Text = EncodeBase64(RichTextBox1.Text)
        Else
            RichTextBox2.Text = Encriptar(RichTextBox1.Text)
        End If
    End Sub

    Private Sub btnDesicfrar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            RichTextBox1.Text = DecodeBase64(RichTextBox2.Text)
        Else
            RichTextBox1.Text = Descencriptar(RichTextBox2.Text)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "CBC" Then
            ModeCryptStrings = CipherMode.CBC
        ElseIf ComboBox1.Text = "CFB" Then
            ModeCryptStrings = CipherMode.CFB
        ElseIf ComboBox1.Text = "CTS" Then
            ModeCryptStrings = CipherMode.CTS
        ElseIf ComboBox1.Text = "ECB" Then
            ModeCryptStrings = CipherMode.ECB
        ElseIf ComboBox1.Text = "OFB" Then
            ModeCryptStrings = CipherMode.OFB
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Text = CreateRandomString("CryptographKey")
    End Sub
#End Region

#Region "Files"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CallEncrypt(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CallDecrypt(TextBox3.Text, TextBox2.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "CBC" Then
            ModeCryptFiles = CipherMode.CBC
        ElseIf ComboBox2.Text = "CFB" Then
            ModeCryptFiles = CipherMode.CFB
        ElseIf ComboBox2.Text = "CTS" Then
            ModeCryptFiles = CipherMode.CTS
        ElseIf ComboBox2.Text = "ECB" Then
            ModeCryptFiles = CipherMode.ECB
        ElseIf ComboBox2.Text = "OFB" Then
            ModeCryptFiles = CipherMode.OFB
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Todos los archivos|*.*"
        OpenFile.CheckFileExists = False
        OpenFile.CheckPathExists = False
        OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OpenFile.Title = "Abrir archivo..."
        If OpenFile.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Todos los archivos|*.*"
        OpenFile.CheckFileExists = False
        OpenFile.CheckPathExists = False
        OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OpenFile.Title = "Abrir archivo..."
        If OpenFile.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        TextBox4.Text = CreateRandomString("CryptographKey")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            TextBox1.Visible = False
            ComboBox1.Visible = False
        Else
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
            ComboBox1.Visible = True
        End If
    End Sub
#End Region
End Class