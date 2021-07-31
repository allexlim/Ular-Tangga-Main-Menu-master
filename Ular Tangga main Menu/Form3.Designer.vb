<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmenang
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
        Me.LLwin = New System.Windows.Forms.Label()
        Me.LLcongrats = New System.Windows.Forms.Label()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.LLyangmenang = New System.Windows.Forms.Label()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLwin
        '
        Me.LLwin.AutoSize = True
        Me.LLwin.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLwin.Location = New System.Drawing.Point(451, 9)
        Me.LLwin.Name = "LLwin"
        Me.LLwin.Size = New System.Drawing.Size(208, 78)
        Me.LLwin.TabIndex = 0
        Me.LLwin.Text = "WIN!!!"
        '
        'LLcongrats
        '
        Me.LLcongrats.AutoSize = True
        Me.LLcongrats.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLcongrats.Location = New System.Drawing.Point(2, 103)
        Me.LLcongrats.Name = "LLcongrats"
        Me.LLcongrats.Size = New System.Drawing.Size(890, 26)
        Me.LLcongrats.TabIndex = 1
        Me.LLcongrats.Text = "CONGRATULATION YOU HAVE WON, HERE ARE SOME REWARD FOR YOU. MERRRY CHRISTMASSS!!!"
        '
        'PB1
        '
        Me.PB1.Image = Global.Ular_Tangga_main_Menu.My.Resources.Resources.FarMatureEsok_max_1mb
        Me.PB1.Location = New System.Drawing.Point(27, 153)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(852, 285)
        Me.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB1.TabIndex = 2
        Me.PB1.TabStop = False
        '
        'LLyangmenang
        '
        Me.LLyangmenang.AutoSize = True
        Me.LLyangmenang.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LLyangmenang.Location = New System.Drawing.Point(297, 9)
        Me.LLyangmenang.Name = "LLyangmenang"
        Me.LLyangmenang.Size = New System.Drawing.Size(108, 78)
        Me.LLyangmenang.TabIndex = 3
        Me.LLyangmenang.Text = "___"
        '
        'Formmenang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 450)
        Me.Controls.Add(Me.LLyangmenang)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.LLcongrats)
        Me.Controls.Add(Me.LLwin)
        Me.Name = "Formmenang"
        Me.Text = "Form3"
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LLwin As Label
    Friend WithEvents LLcongrats As Label
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents LLyangmenang As Label
End Class
