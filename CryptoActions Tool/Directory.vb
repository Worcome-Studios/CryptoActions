Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Directory

    Private Sub Directory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Directory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Selector.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For Each text As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories)
                Dim Destino As String = text.Replace(TextBox1.Text, TextBox2.Text)
                Destino = Destino.Substring(0, Destino.LastIndexOf("\") + 1)
                If Not My.Computer.FileSystem.DirectoryExists(Destino) Then
                    My.Computer.FileSystem.CreateDirectory(Destino)
                End If
                Dim str As String = text.Remove(0, text.LastIndexOf("\") + 1)
                Try
                    Dim array As Byte() = File.ReadAllBytes(text)
                    Dim num As Long = CLng(array.Length)
                    Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                    Dim key As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(TextBox3.Text))
                    md5CryptoServiceProvider.Clear()
                    Dim tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                    tripleDESCryptoServiceProvider.Key = key
                    tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
                    Dim fileStream As FileStream = New FileStream(Destino + str, FileMode.OpenOrCreate, FileAccess.Write)
                    Dim cryptoStream As CryptoStream = New CryptoStream(fileStream, tripleDESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write)
                    cryptoStream.Write(array, 0, CInt(num))
                    fileStream.Close()
                Catch ex As Exception
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, Nothing)
                End Try
            Next
            MsgBox("Cifrado correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Nothing)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each text As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories)
                Dim Destino As String = text.Replace(TextBox1.Text, TextBox2.Text)
                Destino = Destino.Substring(0, Destino.LastIndexOf("\") + 1)
                If Not My.Computer.FileSystem.DirectoryExists(Destino) Then
                    My.Computer.FileSystem.CreateDirectory(Destino)
                End If
                Dim str As String = text.Remove(0, text.LastIndexOf("\") + 1)
                Try
                    Dim array As Byte() = File.ReadAllBytes(text)
                    Dim num As Long = CLng(array.Length)
                    Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
                    Dim key As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(TextBox3.Text))
                    md5CryptoServiceProvider.Clear()
                    Dim tripleDESCryptoServiceProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
                    tripleDESCryptoServiceProvider.Key = key
                    tripleDESCryptoServiceProvider.Mode = CipherMode.ECB
                    Dim fileStream As FileStream = New FileStream(Destino + str, FileMode.OpenOrCreate, FileAccess.Write)
                    Dim cryptoStream As CryptoStream = New CryptoStream(fileStream, tripleDESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write)
                    cryptoStream.Write(array, 0, CInt(num))
                    fileStream.Close()
                Catch ex As Exception
                    Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, Nothing)
                End Try
            Next
            MsgBox("Descifrado correctamente", MsgBoxStyle.Information, "Worcome Security")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Nothing)
        End Try
    End Sub
End Class