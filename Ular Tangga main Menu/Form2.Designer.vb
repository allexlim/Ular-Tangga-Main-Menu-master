<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnDadu = New System.Windows.Forms.Button()
        Me.LbDadu = New System.Windows.Forms.Label()
        Me.BtnCheat = New System.Windows.Forms.Button()
        Me.TbCheat = New System.Windows.Forms.TextBox()
        Me.Tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.LibKepala = New System.Windows.Forms.ListBox()
        Me.LibEkor = New System.Windows.Forms.ListBox()
        Me.Tmrandom1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrandom2 = New System.Windows.Forms.Timer(Me.components)
        Me.LibAwal = New System.Windows.Forms.ListBox()
        Me.LibAkhir = New System.Windows.Forms.ListBox()
        Me.LLkepala = New System.Windows.Forms.Label()
        Me.LLekor = New System.Windows.Forms.Label()
        Me.LLawal = New System.Windows.Forms.Label()
        Me.LLakhir = New System.Windows.Forms.Label()
        Me.LLangka = New System.Windows.Forms.Label()
        Me.LLgiliranpemain = New System.Windows.Forms.Label()
        Me.BTmute = New System.Windows.Forms.Button()
        Me.TBenter = New System.Windows.Forms.TextBox()
        Me.BTenter = New System.Windows.Forms.Button()
        Me.LLhint = New System.Windows.Forms.Label()
        Me.LLhint2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDadu
        '
        Me.BtnDadu.Location = New System.Drawing.Point(709, 53)
        Me.BtnDadu.Name = "BtnDadu"
        Me.BtnDadu.Size = New System.Drawing.Size(75, 23)
        Me.BtnDadu.TabIndex = 0
        Me.BtnDadu.Text = "Dadu"
        Me.BtnDadu.UseVisualStyleBackColor = True
        '
        'LbDadu
        '
        Me.LbDadu.AutoSize = True
        Me.LbDadu.Font = New System.Drawing.Font("Niagara Engraved", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDadu.Location = New System.Drawing.Point(604, 13)
        Me.LbDadu.Name = "LbDadu"
        Me.LbDadu.Size = New System.Drawing.Size(46, 68)
        Me.LbDadu.TabIndex = 1
        Me.LbDadu.Text = "_"
        '
        'BtnCheat
        '
        Me.BtnCheat.Location = New System.Drawing.Point(774, 119)
        Me.BtnCheat.Name = "BtnCheat"
        Me.BtnCheat.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheat.TabIndex = 2
        Me.BtnCheat.Text = "Cheat"
        Me.BtnCheat.UseVisualStyleBackColor = True
        Me.BtnCheat.Visible = False
        '
        'TbCheat
        '
        Me.TbCheat.Location = New System.Drawing.Point(668, 119)
        Me.TbCheat.Name = "TbCheat"
        Me.TbCheat.Size = New System.Drawing.Size(100, 20)
        Me.TbCheat.TabIndex = 3
        Me.TbCheat.Visible = False
        '
        'Tm1
        '
        Me.Tm1.Interval = 500
        '
        'LibKepala
        '
        Me.LibKepala.FormattingEnabled = True
        Me.LibKepala.Location = New System.Drawing.Point(530, 194)
        Me.LibKepala.Name = "LibKepala"
        Me.LibKepala.Size = New System.Drawing.Size(120, 95)
        Me.LibKepala.TabIndex = 4
        '
        'LibEkor
        '
        Me.LibEkor.FormattingEnabled = True
        Me.LibEkor.Location = New System.Drawing.Point(677, 194)
        Me.LibEkor.Name = "LibEkor"
        Me.LibEkor.Size = New System.Drawing.Size(120, 95)
        Me.LibEkor.TabIndex = 5
        '
        'Tmrandom1
        '
        Me.Tmrandom1.Interval = 50
        '
        'Tmrandom2
        '
        Me.Tmrandom2.Enabled = True
        Me.Tmrandom2.Interval = 50
        '
        'LibAwal
        '
        Me.LibAwal.FormattingEnabled = True
        Me.LibAwal.Location = New System.Drawing.Point(530, 330)
        Me.LibAwal.Name = "LibAwal"
        Me.LibAwal.Size = New System.Drawing.Size(120, 95)
        Me.LibAwal.TabIndex = 6
        '
        'LibAkhir
        '
        Me.LibAkhir.FormattingEnabled = True
        Me.LibAkhir.Location = New System.Drawing.Point(677, 330)
        Me.LibAkhir.Name = "LibAkhir"
        Me.LibAkhir.Size = New System.Drawing.Size(120, 95)
        Me.LibAkhir.TabIndex = 7
        '
        'LLkepala
        '
        Me.LLkepala.AutoSize = True
        Me.LLkepala.ForeColor = System.Drawing.Color.Red
        Me.LLkepala.Location = New System.Drawing.Point(527, 169)
        Me.LLkepala.Name = "LLkepala"
        Me.LLkepala.Size = New System.Drawing.Size(60, 13)
        Me.LLkepala.TabIndex = 9
        Me.LLkepala.Text = "Kepala ular"
        '
        'LLekor
        '
        Me.LLekor.AutoSize = True
        Me.LLekor.ForeColor = System.Drawing.Color.Blue
        Me.LLekor.Location = New System.Drawing.Point(674, 169)
        Me.LLekor.Name = "LLekor"
        Me.LLekor.Size = New System.Drawing.Size(49, 13)
        Me.LLekor.TabIndex = 10
        Me.LLekor.Text = "Ekor ular"
        '
        'LLawal
        '
        Me.LLawal.AutoSize = True
        Me.LLawal.ForeColor = System.Drawing.Color.Fuchsia
        Me.LLawal.Location = New System.Drawing.Point(527, 305)
        Me.LLawal.Name = "LLawal"
        Me.LLawal.Size = New System.Drawing.Size(70, 13)
        Me.LLawal.TabIndex = 11
        Me.LLawal.Text = "Awal Tangga"
        '
        'LLakhir
        '
        Me.LLakhir.AutoSize = True
        Me.LLakhir.ForeColor = System.Drawing.Color.Green
        Me.LLakhir.Location = New System.Drawing.Point(674, 305)
        Me.LLakhir.Name = "LLakhir"
        Me.LLakhir.Size = New System.Drawing.Size(71, 13)
        Me.LLakhir.TabIndex = 12
        Me.LLakhir.Text = "Akhir Tangga"
        '
        'LLangka
        '
        Me.LLangka.AutoSize = True
        Me.LLangka.Location = New System.Drawing.Point(522, 119)
        Me.LLangka.Name = "LLangka"
        Me.LLangka.Size = New System.Drawing.Size(13, 13)
        Me.LLangka.TabIndex = 13
        Me.LLangka.Text = "_"
        '
        'LLgiliranpemain
        '
        Me.LLgiliranpemain.AutoSize = True
        Me.LLgiliranpemain.Location = New System.Drawing.Point(440, 119)
        Me.LLgiliranpemain.Name = "LLgiliranpemain"
        Me.LLgiliranpemain.Size = New System.Drawing.Size(76, 13)
        Me.LLgiliranpemain.TabIndex = 14
        Me.LLgiliranpemain.Text = "Giliran pemain:"
        '
        'BTmute
        '
        Me.BTmute.Location = New System.Drawing.Point(459, 16)
        Me.BTmute.Name = "BTmute"
        Me.BTmute.Size = New System.Drawing.Size(75, 23)
        Me.BTmute.TabIndex = 15
        Me.BTmute.Text = "Mute"
        Me.BTmute.UseVisualStyleBackColor = True
        Me.BTmute.Visible = False
        '
        'TBenter
        '
        Me.TBenter.Location = New System.Drawing.Point(663, 91)
        Me.TBenter.Name = "TBenter"
        Me.TBenter.Size = New System.Drawing.Size(100, 20)
        Me.TBenter.TabIndex = 16
        '
        'BTenter
        '
        Me.BTenter.Location = New System.Drawing.Point(774, 89)
        Me.BTenter.Name = "BTenter"
        Me.BTenter.Size = New System.Drawing.Size(75, 23)
        Me.BTenter.TabIndex = 17
        Me.BTenter.Text = "Enter"
        Me.BTenter.UseVisualStyleBackColor = True
        '
        'LLhint
        '
        Me.LLhint.AutoSize = True
        Me.LLhint.Location = New System.Drawing.Point(440, 91)
        Me.LLhint.Name = "LLhint"
        Me.LLhint.Size = New System.Drawing.Size(210, 13)
        Me.LLhint.TabIndex = 18
        Me.LLhint.Text = "Enter the password to enabled cheat box!!!"
        '
        'LLhint2
        '
        Me.LLhint2.AutoSize = True
        Me.LLhint2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLhint2.Location = New System.Drawing.Point(540, 9)
        Me.LLhint2.Name = "LLhint2"
        Me.LLhint2.Size = New System.Drawing.Size(310, 13)
        Me.LLhint2.TabIndex = 19
        Me.LLhint2.Text = "Hint: the password is in one of the music in this game"
        '
        'FormPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 450)
        Me.Controls.Add(Me.LLhint2)
        Me.Controls.Add(Me.LLhint)
        Me.Controls.Add(Me.BTenter)
        Me.Controls.Add(Me.TBenter)
        Me.Controls.Add(Me.BTmute)
        Me.Controls.Add(Me.LLgiliranpemain)
        Me.Controls.Add(Me.LLangka)
        Me.Controls.Add(Me.LLakhir)
        Me.Controls.Add(Me.LLawal)
        Me.Controls.Add(Me.LLekor)
        Me.Controls.Add(Me.LLkepala)
        Me.Controls.Add(Me.LibAkhir)
        Me.Controls.Add(Me.LibAwal)
        Me.Controls.Add(Me.LibEkor)
        Me.Controls.Add(Me.LibKepala)
        Me.Controls.Add(Me.TbCheat)
        Me.Controls.Add(Me.BtnCheat)
        Me.Controls.Add(Me.LbDadu)
        Me.Controls.Add(Me.BtnDadu)
        Me.Name = "FormPlay"
        Me.Text = "ULAR DAN TANGGA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDadu As Button
    Friend WithEvents LbDadu As Label
    Friend WithEvents BtnCheat As Button
    Friend WithEvents TbCheat As TextBox
    Friend WithEvents Tm1 As Timer
    Friend WithEvents LibKepala As ListBox
    Friend WithEvents LibEkor As ListBox
    Friend WithEvents Tmrandom1 As Timer
    Friend WithEvents Tmrandom2 As Timer
    Friend WithEvents LibAwal As ListBox
    Friend WithEvents LibAkhir As ListBox
    Friend WithEvents LLkepala As Label
    Friend WithEvents LLekor As Label
    Friend WithEvents LLawal As Label
    Friend WithEvents LLakhir As Label
    Friend WithEvents LLangka As Label
    Friend WithEvents LLgiliranpemain As Label
    Friend WithEvents BTmute As Button
    Friend WithEvents TBenter As TextBox
    Friend WithEvents BTenter As Button
    Friend WithEvents LLhint As Label
    Friend WithEvents LLhint2 As Label
End Class
