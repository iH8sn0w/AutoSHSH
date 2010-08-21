<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Win32_UsbDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.console = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.save = New System.Windows.Forms.SaveFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.quote = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(470, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Grab my SHSH Blobs Automatically"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'console
        '
        Me.console.Location = New System.Drawing.Point(64, 143)
        Me.console.Name = "console"
        Me.console.Size = New System.Drawing.Size(24, 25)
        Me.console.TabIndex = 1
        Me.console.Text = ""
        Me.console.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ensure that your iDevice is connected in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recovery Mode and have iTunes installed" & _
            "!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(175, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(299, 138)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "How do I " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter Recovery Mode?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(193, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 74)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hold Power + Home continuously" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " until the Device displays the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " connect to iTune" & _
            "s logo or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shows your custom Recovery Logo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(269, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Hide Instructions"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(368, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "http://ih8sn0w.com"
        '
        'save
        '
        Me.save.Filter = "SHSH Blobs|.shsh"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutoSHSH.My.Resources.Resources.iPhoneRecovery
        Me.PictureBox1.Location = New System.Drawing.Point(9, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'quote
        '
        Me.quote.AutoSize = True
        Me.quote.Location = New System.Drawing.Point(207, 274)
        Me.quote.Name = "quote"
        Me.quote.Size = New System.Drawing.Size(12, 13)
        Me.quote.TabIndex = 8
        Me.quote.Text = """"
        Me.quote.Visible = False
        '
        'Win32_UsbDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 288)
        Me.Controls.Add(Me.quote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.console)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Win32_UsbDevice"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iPhone/iPod/iPad Auto-SHSH Grabber for 3.1.3/3.2 -- RC2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents console As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents quote As System.Windows.Forms.Label

End Class
