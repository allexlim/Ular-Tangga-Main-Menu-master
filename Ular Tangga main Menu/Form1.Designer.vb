<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_Difficult = New System.Windows.Forms.Button()
        Me.BT_Players = New System.Windows.Forms.Button()
        Me.LB2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LB3 = New System.Windows.Forms.Label()
        Me.LB4 = New System.Windows.Forms.Label()
        Me.LB_Diff = New System.Windows.Forms.Label()
        Me.LB_Player = New System.Windows.Forms.Label()
        Me.GB_Diff = New System.Windows.Forms.GroupBox()
        Me.RB_Idi = New System.Windows.Forms.RadioButton()
        Me.RB_Ext = New System.Windows.Forms.RadioButton()
        Me.RB_Har = New System.Windows.Forms.RadioButton()
        Me.RB_Med = New System.Windows.Forms.RadioButton()
        Me.RB_Easy = New System.Windows.Forms.RadioButton()
        Me.GB_Play = New System.Windows.Forms.GroupBox()
        Me.RB_P4 = New System.Windows.Forms.RadioButton()
        Me.RB_P3 = New System.Windows.Forms.RadioButton()
        Me.RB_P2 = New System.Windows.Forms.RadioButton()
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.LB5 = New System.Windows.Forms.Label()
        Me.LB_Ukuran = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GB_Diff.SuspendLayout()
        Me.GB_Play.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(228, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ULAR DAN TANGGA"
        '
        'BT_Difficult
        '
        Me.BT_Difficult.Location = New System.Drawing.Point(312, 132)
        Me.BT_Difficult.Name = "BT_Difficult"
        Me.BT_Difficult.Size = New System.Drawing.Size(88, 50)
        Me.BT_Difficult.TabIndex = 1
        Me.BT_Difficult.Text = "Difficult"
        Me.BT_Difficult.UseVisualStyleBackColor = True
        '
        'BT_Players
        '
        Me.BT_Players.Location = New System.Drawing.Point(312, 201)
        Me.BT_Players.Name = "BT_Players"
        Me.BT_Players.Size = New System.Drawing.Size(88, 50)
        Me.BT_Players.TabIndex = 5
        Me.BT_Players.Text = "Players"
        Me.BT_Players.UseVisualStyleBackColor = True
        '
        'LB2
        '
        Me.LB2.AutoSize = True
        Me.LB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB2.ForeColor = System.Drawing.Color.Black
        Me.LB2.Location = New System.Drawing.Point(52, 156)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(711, 73)
        Me.LB2.TabIndex = 9
        Me.LB2.Text = "Press ""Any Key"" to Play"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LB3
        '
        Me.LB3.AutoSize = True
        Me.LB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB3.Location = New System.Drawing.Point(25, 239)
        Me.LB3.Name = "LB3"
        Me.LB3.Size = New System.Drawing.Size(89, 25)
        Me.LB3.TabIndex = 10
        Me.LB3.Text = "Difficult:"
        '
        'LB4
        '
        Me.LB4.AutoSize = True
        Me.LB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB4.Location = New System.Drawing.Point(25, 264)
        Me.LB4.Name = "LB4"
        Me.LB4.Size = New System.Drawing.Size(90, 25)
        Me.LB4.TabIndex = 11
        Me.LB4.Text = "Players:"
        '
        'LB_Diff
        '
        Me.LB_Diff.AutoSize = True
        Me.LB_Diff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Diff.Location = New System.Drawing.Point(121, 239)
        Me.LB_Diff.Name = "LB_Diff"
        Me.LB_Diff.Size = New System.Drawing.Size(94, 25)
        Me.LB_Diff.TabIndex = 12
        Me.LB_Diff.Text = "{difficult}"
        '
        'LB_Player
        '
        Me.LB_Player.AutoSize = True
        Me.LB_Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Player.Location = New System.Drawing.Point(121, 264)
        Me.LB_Player.Name = "LB_Player"
        Me.LB_Player.Size = New System.Drawing.Size(98, 25)
        Me.LB_Player.TabIndex = 13
        Me.LB_Player.Text = "{Players}"
        '
        'GB_Diff
        '
        Me.GB_Diff.Controls.Add(Me.RB_Idi)
        Me.GB_Diff.Controls.Add(Me.RB_Ext)
        Me.GB_Diff.Controls.Add(Me.RB_Har)
        Me.GB_Diff.Controls.Add(Me.RB_Med)
        Me.GB_Diff.Controls.Add(Me.RB_Easy)
        Me.GB_Diff.Location = New System.Drawing.Point(441, 105)
        Me.GB_Diff.Name = "GB_Diff"
        Me.GB_Diff.Size = New System.Drawing.Size(124, 139)
        Me.GB_Diff.TabIndex = 14
        Me.GB_Diff.TabStop = False
        Me.GB_Diff.Text = "Difficult"
        '
        'RB_Idi
        '
        Me.RB_Idi.AutoSize = True
        Me.RB_Idi.Location = New System.Drawing.Point(6, 113)
        Me.RB_Idi.Name = "RB_Idi"
        Me.RB_Idi.Size = New System.Drawing.Size(45, 17)
        Me.RB_Idi.TabIndex = 4
        Me.RB_Idi.Text = "Idiot"
        Me.RB_Idi.UseVisualStyleBackColor = True
        '
        'RB_Ext
        '
        Me.RB_Ext.AutoSize = True
        Me.RB_Ext.Location = New System.Drawing.Point(6, 90)
        Me.RB_Ext.Name = "RB_Ext"
        Me.RB_Ext.Size = New System.Drawing.Size(63, 17)
        Me.RB_Ext.TabIndex = 3
        Me.RB_Ext.Text = "Extreme"
        Me.RB_Ext.UseVisualStyleBackColor = True
        '
        'RB_Har
        '
        Me.RB_Har.AutoSize = True
        Me.RB_Har.Location = New System.Drawing.Point(6, 67)
        Me.RB_Har.Name = "RB_Har"
        Me.RB_Har.Size = New System.Drawing.Size(48, 17)
        Me.RB_Har.TabIndex = 2
        Me.RB_Har.Text = "Hard"
        Me.RB_Har.UseVisualStyleBackColor = True
        '
        'RB_Med
        '
        Me.RB_Med.AutoSize = True
        Me.RB_Med.Checked = True
        Me.RB_Med.Location = New System.Drawing.Point(6, 44)
        Me.RB_Med.Name = "RB_Med"
        Me.RB_Med.Size = New System.Drawing.Size(62, 17)
        Me.RB_Med.TabIndex = 1
        Me.RB_Med.TabStop = True
        Me.RB_Med.Text = "Medium"
        Me.RB_Med.UseVisualStyleBackColor = True
        '
        'RB_Easy
        '
        Me.RB_Easy.AutoSize = True
        Me.RB_Easy.Location = New System.Drawing.Point(6, 22)
        Me.RB_Easy.Name = "RB_Easy"
        Me.RB_Easy.Size = New System.Drawing.Size(48, 17)
        Me.RB_Easy.TabIndex = 0
        Me.RB_Easy.Text = "Easy"
        Me.RB_Easy.UseVisualStyleBackColor = True
        '
        'GB_Play
        '
        Me.GB_Play.Controls.Add(Me.RB_P4)
        Me.GB_Play.Controls.Add(Me.RB_P3)
        Me.GB_Play.Controls.Add(Me.RB_P2)
        Me.GB_Play.Location = New System.Drawing.Point(441, 205)
        Me.GB_Play.Name = "GB_Play"
        Me.GB_Play.Size = New System.Drawing.Size(227, 39)
        Me.GB_Play.TabIndex = 15
        Me.GB_Play.TabStop = False
        Me.GB_Play.Text = "Select Players"
        '
        'RB_P4
        '
        Me.RB_P4.AutoSize = True
        Me.RB_P4.Location = New System.Drawing.Point(159, 16)
        Me.RB_P4.Name = "RB_P4"
        Me.RB_P4.Size = New System.Drawing.Size(68, 17)
        Me.RB_P4.TabIndex = 2
        Me.RB_P4.Text = "4 Players"
        Me.RB_P4.UseVisualStyleBackColor = True
        '
        'RB_P3
        '
        Me.RB_P3.AutoSize = True
        Me.RB_P3.Location = New System.Drawing.Point(80, 16)
        Me.RB_P3.Name = "RB_P3"
        Me.RB_P3.Size = New System.Drawing.Size(68, 17)
        Me.RB_P3.TabIndex = 1
        Me.RB_P3.Text = "3 Players"
        Me.RB_P3.UseVisualStyleBackColor = True
        '
        'RB_P2
        '
        Me.RB_P2.AutoSize = True
        Me.RB_P2.Checked = True
        Me.RB_P2.Location = New System.Drawing.Point(6, 16)
        Me.RB_P2.Name = "RB_P2"
        Me.RB_P2.Size = New System.Drawing.Size(68, 17)
        Me.RB_P2.TabIndex = 0
        Me.RB_P2.TabStop = True
        Me.RB_P2.Text = "2 Players"
        Me.RB_P2.UseVisualStyleBackColor = True
        '
        'BT_Start
        '
        Me.BT_Start.Location = New System.Drawing.Point(312, 264)
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.Size = New System.Drawing.Size(88, 50)
        Me.BT_Start.TabIndex = 16
        Me.BT_Start.Text = "Start Game"
        Me.BT_Start.UseVisualStyleBackColor = True
        '
        'LB5
        '
        Me.LB5.AutoSize = True
        Me.LB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB5.Location = New System.Drawing.Point(25, 289)
        Me.LB5.Name = "LB5"
        Me.LB5.Size = New System.Drawing.Size(87, 25)
        Me.LB5.TabIndex = 19
        Me.LB5.Text = "Ukuran:"
        '
        'LB_Ukuran
        '
        Me.LB_Ukuran.AutoSize = True
        Me.LB_Ukuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Ukuran.Location = New System.Drawing.Point(121, 289)
        Me.LB_Ukuran.Name = "LB_Ukuran"
        Me.LB_Ukuran.Size = New System.Drawing.Size(95, 25)
        Me.LB_Ukuran.TabIndex = 20
        Me.LB_Ukuran.Text = "{Ukuran}"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ular_Tangga_main_Menu.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(600, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ular_Tangga_main_Menu.My.Resources.Resources.cobra_snake_slithering
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_Ukuran)
        Me.Controls.Add(Me.LB5)
        Me.Controls.Add(Me.BT_Start)
        Me.Controls.Add(Me.GB_Play)
        Me.Controls.Add(Me.GB_Diff)
        Me.Controls.Add(Me.LB_Player)
        Me.Controls.Add(Me.LB_Diff)
        Me.Controls.Add(Me.LB4)
        Me.Controls.Add(Me.LB3)
        Me.Controls.Add(Me.BT_Players)
        Me.Controls.Add(Me.BT_Difficult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB2)
        Me.Name = "Main_Menu"
        Me.Text = "ULAR DAN TANGGA"
        Me.GB_Diff.ResumeLayout(False)
        Me.GB_Diff.PerformLayout()
        Me.GB_Play.ResumeLayout(False)
        Me.GB_Play.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BT_Difficult As Button
    Friend WithEvents BT_Players As Button
    Friend WithEvents LB2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LB3 As Label
    Friend WithEvents LB4 As Label
    Friend WithEvents LB_Diff As Label
    Friend WithEvents LB_Player As Label
    Friend WithEvents GB_Diff As GroupBox
    Friend WithEvents RB_Idi As RadioButton
    Friend WithEvents RB_Ext As RadioButton
    Friend WithEvents RB_Har As RadioButton
    Friend WithEvents RB_Med As RadioButton
    Friend WithEvents RB_Easy As RadioButton
    Friend WithEvents GB_Play As GroupBox
    Friend WithEvents RB_P4 As RadioButton
    Friend WithEvents RB_P3 As RadioButton
    Friend WithEvents RB_P2 As RadioButton
    Friend WithEvents BT_Start As Button
    Friend WithEvents LB5 As Label
    Friend WithEvents LB_Ukuran As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
