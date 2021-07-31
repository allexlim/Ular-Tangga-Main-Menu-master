Public Class Main_Menu
    Dim time As Integer = 1
    Public penentu As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_Diff.Text = "Medium"
        LB_Player.Text = "2 Players"
        LB_Ukuran.Text = "8 X 8"
        GB_Diff.Visible = False
        GB_Play.Visible = False
        LB2.Visible = True
        BT_Difficult.Visible = False
        BT_Players.Visible = False
        LB3.Visible = False
        LB4.Visible = False
        LB_Diff.Visible = False
        LB_Player.Visible = False
        BT_Start.Visible = False
        LB5.Visible = False
        LB_Ukuran.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        If time = 2 Then
            If LB2.ForeColor = Color.Black Then
                BackColor = Color.Black
                LB2.ForeColor = Color.White
            ElseIf LB2.ForeColor = Color.White Then
                BackColor = Color.White
                LB2.ForeColor = Color.Black
            End If
        End If
        time = 1
    End Sub
    Private Sub BT_Difficult_Click(sender As Object, e As EventArgs) Handles BT_Difficult.Click
        If BT_Difficult.Text = "Difficult" Then
            GB_Diff.Visible = True
            BT_Players.Enabled = False
            BT_Start.Enabled = False
            BT_Difficult.Text = "Back"
        ElseIf BT_Difficult.Text = "Back" Then
            GB_Diff.Visible = False
            BT_Start.Enabled = True
            BT_Players.Enabled = True
            BT_Difficult.Text = "Difficult"
            If RB_Easy.Checked = True Then
                LB_Diff.Text = RB_Easy.Text
                LB_Ukuran.Text = "8 X 8"
                penentu = False
            ElseIf RB_Med.Checked = True Then
                LB_Diff.Text = RB_Med.Text
                LB_Ukuran.Text = "9 X 9"
                penentu = False
            ElseIf RB_Har.Checked = True Then
                LB_Diff.Text = RB_Har.Text
                LB_Ukuran.Text = "9 X 9"
                penentu = False
            ElseIf RB_Ext.Checked = True Then
                LB_Diff.Text = RB_Ext.Text
                LB_Ukuran.Text = "10 X 10"
                penentu = False
            ElseIf RB_Idi.Checked = True Then
                LB_Diff.Text = RB_Idi.Text
                LB_Ukuran.Text = "10 X 10"
                penentu = True
            End If
        End If
    End Sub

    Private Sub BT_Players_Click(sender As Object, e As EventArgs) Handles BT_Players.Click
        If BT_Players.Text = "Players" Then
            BT_Players.Text = "Back"
            BT_Difficult.Enabled = False
            BT_Start.Enabled = False
            GB_Play.Visible = True
        ElseIf BT_Players.Text = "Back" Then
            BT_Players.Text = "Players"
            BT_Start.Enabled = True
            BT_Difficult.Enabled = True
            GB_Play.Visible = False
            If RB_P2.Checked = True Then
                LB_Player.Text = RB_P2.Text
            ElseIf RB_P3.Checked = True Then
                LB_Player.Text = RB_P3.Text
            ElseIf RB_P4.Checked = True Then
                LB_Player.Text = RB_P4.Text
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        LB2.Visible = False
        BT_Difficult.Visible = True
        BT_Players.Visible = True
        LB3.Visible = True
        LB4.Visible = True
        LB_Diff.Visible = True
        LB_Player.Visible = True
        BT_Start.Visible = True
        LB5.Visible = True
        LB_Ukuran.Visible = True
        Timer1.Enabled = False
        BackColor = Color.White
    End Sub

    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        PN_Menu.Show()
    End Sub

End Class
