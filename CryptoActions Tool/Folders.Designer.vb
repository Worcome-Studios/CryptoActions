<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Folders
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Folders))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBoxORIGEN = New System.Windows.Forms.TextBox()
        Me.ButtonENCRIPTAR = New System.Windows.Forms.Button()
        Me.TextBoxDESTINO = New System.Windows.Forms.TextBox()
        Me.TextBoxCLAVE = New System.Windows.Forms.TextBox()
        Me.ButtonDESENCRIPTAR = New System.Windows.Forms.Button()
        Me.ButtonELIMINAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxORIGEN
        '
        Me.TextBoxORIGEN.BackColor = System.Drawing.Color.White
        Me.TextBoxORIGEN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxORIGEN.Location = New System.Drawing.Point(103, 82)
        Me.TextBoxORIGEN.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxORIGEN.Name = "TextBoxORIGEN"
        Me.TextBoxORIGEN.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxORIGEN.TabIndex = 0
        '
        'ButtonENCRIPTAR
        '
        Me.ButtonENCRIPTAR.BackColor = System.Drawing.Color.Transparent
        Me.ButtonENCRIPTAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonENCRIPTAR.Location = New System.Drawing.Point(120, 284)
        Me.ButtonENCRIPTAR.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonENCRIPTAR.Name = "ButtonENCRIPTAR"
        Me.ButtonENCRIPTAR.Size = New System.Drawing.Size(99, 36)
        Me.ButtonENCRIPTAR.TabIndex = 2
        Me.ButtonENCRIPTAR.Text = "Encriptar"
        Me.ButtonENCRIPTAR.UseVisualStyleBackColor = False
        '
        'TextBoxDESTINO
        '
        Me.TextBoxDESTINO.BackColor = System.Drawing.Color.White
        Me.TextBoxDESTINO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxDESTINO.Location = New System.Drawing.Point(103, 142)
        Me.TextBoxDESTINO.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDESTINO.Name = "TextBoxDESTINO"
        Me.TextBoxDESTINO.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxDESTINO.TabIndex = 3
        '
        'TextBoxCLAVE
        '
        Me.TextBoxCLAVE.BackColor = System.Drawing.Color.White
        Me.TextBoxCLAVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxCLAVE.Location = New System.Drawing.Point(162, 212)
        Me.TextBoxCLAVE.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCLAVE.Name = "TextBoxCLAVE"
        Me.TextBoxCLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBoxCLAVE.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxCLAVE.TabIndex = 5
        Me.TextBoxCLAVE.Text = "12345"
        Me.TextBoxCLAVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonDESENCRIPTAR
        '
        Me.ButtonDESENCRIPTAR.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDESENCRIPTAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonDESENCRIPTAR.Location = New System.Drawing.Point(326, 284)
        Me.ButtonDESENCRIPTAR.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDESENCRIPTAR.Name = "ButtonDESENCRIPTAR"
        Me.ButtonDESENCRIPTAR.Size = New System.Drawing.Size(99, 36)
        Me.ButtonDESENCRIPTAR.TabIndex = 6
        Me.ButtonDESENCRIPTAR.Text = "Desencriptar"
        Me.ButtonDESENCRIPTAR.UseVisualStyleBackColor = False
        '
        'ButtonELIMINAR
        '
        Me.ButtonELIMINAR.BackColor = System.Drawing.Color.Transparent
        Me.ButtonELIMINAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonELIMINAR.Location = New System.Drawing.Point(223, 284)
        Me.ButtonELIMINAR.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonELIMINAR.Name = "ButtonELIMINAR"
        Me.ButtonELIMINAR.Size = New System.Drawing.Size(99, 36)
        Me.ButtonELIMINAR.TabIndex = 7
        Me.ButtonELIMINAR.Text = "Eliminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Origen"
        Me.ButtonELIMINAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "(?) Directorio Original:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "(?) Directorio Destino:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Llave de Cifrado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mostrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ver >"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ver >"
        '
        'FolderEncryptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(544, 385)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonELIMINAR)
        Me.Controls.Add(Me.ButtonDESENCRIPTAR)
        Me.Controls.Add(Me.TextBoxCLAVE)
        Me.Controls.Add(Me.TextBoxDESTINO)
        Me.Controls.Add(Me.ButtonENCRIPTAR)
        Me.Controls.Add(Me.TextBoxORIGEN)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FolderEncryptor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folders | CryptoActions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBoxORIGEN As System.Windows.Forms.TextBox
    Friend WithEvents ButtonENCRIPTAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxDESTINO As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCLAVE As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDESENCRIPTAR As System.Windows.Forms.Button
    Friend WithEvents ButtonELIMINAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
