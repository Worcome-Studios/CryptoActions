<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnLockDirectory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnLockDirectory))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTODOS = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUNO = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Location = New System.Drawing.Point(11, 24)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(279, 146)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(294, 96)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "RESTRINGIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(294, 135)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "LIBERAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Seleccione un Directorio"
        Me.FolderBrowserDialog1.SelectedPath = "C:\"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonTODOS)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUNO)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(297, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(96, 68)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'RadioButtonTODOS
        '
        Me.RadioButtonTODOS.AutoSize = True
        Me.RadioButtonTODOS.Checked = True
        Me.RadioButtonTODOS.Location = New System.Drawing.Point(4, 47)
        Me.RadioButtonTODOS.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonTODOS.Name = "RadioButtonTODOS"
        Me.RadioButtonTODOS.Size = New System.Drawing.Size(88, 17)
        Me.RadioButtonTODOS.TabIndex = 1
        Me.RadioButtonTODOS.TabStop = True
        Me.RadioButtonTODOS.Text = "Para TODOS"
        Me.RadioButtonTODOS.UseVisualStyleBackColor = True
        '
        'RadioButtonUNO
        '
        Me.RadioButtonUNO.AutoSize = True
        Me.RadioButtonUNO.Location = New System.Drawing.Point(4, 26)
        Me.RadioButtonUNO.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonUNO.Name = "RadioButtonUNO"
        Me.RadioButtonUNO.Size = New System.Drawing.Size(73, 17)
        Me.RadioButtonUNO.TabIndex = 0
        Me.RadioButtonUNO.Text = "Solo UNO"
        Me.RadioButtonUNO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Directorios Agregados"
        '
        'FolderLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(394, 181)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 220)
        Me.MinimumSize = New System.Drawing.Size(410, 220)
        Me.Name = "FolderLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory | CryptoActions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonTODOS As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUNO As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
