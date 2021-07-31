Public Class FormPlay
    Dim X(10, 10) As Button
    Dim Z(3) As Button  'player
    Dim P(10, 3) As Integer 'posisi ular sama posisi tangga
    Dim A As Integer 'angka dadu
    Dim B As Integer = 0 'angka papan
    Dim C, R, T, U, V, D, W As Integer 'c=jalan brp kali , R = jumlah player, T = besar papan, U = jml tangga, V = jml ular, D = IDIOT, W = 6 atau bukan dadunnya
    Dim Rndm As New Random
    Dim F As Integer = 0 'player yang main
    Dim G(10, 1) As Integer ' koordinat ular
    Dim H As Integer = 0 ' jumlah mundur
    Dim Q(10, 1) As Integer 'koordinat tangga
    Dim S(3) As Integer 'posisi player
    Dim angka As Integer = 30 'countdownnnya
    Dim hello As Integer = 0 'pindah ke tick2
    Dim Y As Integer = 91 'ular untuk idiot
    Dim AA(100) As Integer 'kotak udah disi ulat/tangga
    Dim angkarandom As Integer 'untuk animasi random kaya variable A
    Dim time As Integer = 1

    Private Sub BTmute_Click(sender As Object, e As EventArgs) Handles BTmute.Click
        MessageBox.Show("Sorry the music is too good to be muted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Dim result1 = MessageBox.Show("The music is good right", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        While result1 = DialogResult.No
            MessageBox.Show("The system can't accept that", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            result1 = MessageBox.Show("The music is good right", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End While
        If result1 = DialogResult.Yes Then
            MessageBox.Show("Yes the system agree with you!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BTenter_Click(sender As Object, e As EventArgs) Handles BTenter.Click
        If TBenter.Text = "coconut" Then
            BtnCheat.Visible = True
            TbCheat.Visible = True
            TBenter.Visible = False
            BTenter.Visible = False
            LLhint.Visible = False
            LLhint2.Visible = False
            MsgBox("cheat unlocked")
        End If
    End Sub

    Private Sub FormPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Tm1.Tick, AddressOf Main
        If Main_Menu.RB_P2.Checked = True Then
            R = 2
        ElseIf Main_Menu.RB_P3.Checked = True Then
            R = 3
        ElseIf Main_Menu.RB_P4.Checked = True Then
            R = 4
        End If
        If Main_Menu.RB_Easy.Checked = True Then
            T = 8
            U = 5
            V = 2
            My.Computer.Audio.Play(My.Resources.megalovania, AudioPlayMode.BackgroundLoop)
        ElseIf Main_Menu.RB_Med.Checked = True Then
            T = 9
            U = 4
            V = 4
            My.Computer.Audio.Play(My.Resources.megalovania, AudioPlayMode.BackgroundLoop)
        ElseIf Main_Menu.RB_Har.Checked = True Then
            T = 9
            U = 3
            V = 5
            My.Computer.Audio.Play(My.Resources.megalovania, AudioPlayMode.BackgroundLoop)
        ElseIf Main_Menu.RB_Ext.Checked = True Then
            T = 10
            U = 3
            V = 7
            My.Computer.Audio.Play(My.Resources.megalovania, AudioPlayMode.BackgroundLoop)
        ElseIf Main_Menu.RB_Idi.Checked = True Then
            D = 1
            T = 10
            V = 7
            U = 0
            My.Computer.Audio.Play(My.Resources.coconut, AudioPlayMode.BackgroundLoop)
        End If
        If D = 0 Then
            For i = 0 To V - 1
                P(i, 0) = Rndm.Next(20, T * T - 1)
                If AA(P(i, 0)) = 0 Then
                    AA(P(i, 0)) = 1
                Else
                    While AA(P(i, 0)) = 1
                        P(i, 0) = Rndm.Next(20, T * T - 1)
                    End While
                End If
                P(i, 1) = Rndm.Next(2, P(i, 0) - 10)
                If AA(P(i, 1)) = 0 Then
                    AA(P(i, 1)) = 1
                Else
                    While AA(P(i, 1)) = 1
                        P(i, 1) = Rndm.Next(2, P(1, 0) - 10)
                    End While
                End If
                LibKepala.Items.Add(P(i, 0))
                LibEkor.Items.Add(P(i, 1))
            Next
            For i = 0 To U - 1
                P(i, 2) = Rndm.Next(2, T * (T - 1) - 2)
                If AA(P(i, 2)) = 0 Then
                    AA(P(i, 2)) = 1
                Else
                    While AA(P(i, 2)) = 1
                        P(i, 2) = Rndm.Next(2, T * (T - 1) - 2)
                    End While
                End If
                P(i, 3) = Rndm.Next(P(i, 2) + 10, T * T - 1)
                If AA(P(i, 3)) = 0 Then
                    AA(P(i, 3)) = 1
                Else
                    While AA(P(i, 3)) = 1
                        P(i, 3) = Rndm.Next(P(i, 2) + 10, T * T - 1)
                    End While
                End If
                LibAwal.Items.Add(P(i, 2))
                LibAkhir.Items.Add(P(i, 3))
            Next
        ElseIf D = 1 Then
            For i = 0 To 6
                P(i, 0) = Y
                Y += 1
                If Y = 94 Or Y = 97 Then
                    Y += 1
                End If
                P(i, 1) = 10
                LibKepala.Items.Add(P(i, 0))
                LibEkor.Items.Add(P(i, 1))
            Next
        End If
        For i = 0 To R - 1
            Z(i) = New Button
            Z(i).Height = 20
            Z(i).Width = 20
            If i = 0 Then
                Z(i).BackColor = Color.Red
                Z(i).Left = 0
                Z(i).Top = 40 * (T - 1)
            ElseIf i = 1 Then
                Z(i).BackColor = Color.Blue
                Z(i).Left = 20
                Z(i).Top = 40 * (T - 1)
            ElseIf i = 2 Then
                Z(i).BackColor = Color.Black
                Z(i).Left = 0
                Z(i).Top = 40 * (T - 0.5)
            ElseIf i = 3 Then
                Z(i).BackColor = Color.Brown
                Z(i).Left = 20
                Z(i).Top = 40 * (T - 0.5)
            End If
            Me.Controls.Add(Z(i))
        Next
        For i = 0 To T - 1
            For j = 0 To T - 1
                X(i, j) = New Button
                X(i, j).Height = 40
                X(i, j).Width = 40
                X(i, j).Top = 40 * T - (i + 1) * 40
                If i Mod 2 = 0 Then
                    X(i, j).Left = 40 * j
                Else
                    X(i, j).Left = 40 * T - (j + 1) * 40
                End If
                B = B + 1
                X(i, j).Text = B
                X(i, j).Name = "X(" & B & ")"
                If B = P(0, 0) Or B = P(1, 0) Or B = P(2, 0) Or B = P(3, 0) Or B = P(4, 0) Or B = P(5, 0) Or B = P(6, 0) Then
                    X(i, j).BackColor = Color.Red
                ElseIf B = P(0, 1) Or B = P(1, 1) Or B = P(2, 1) Or B = P(3, 1) Or B = P(4, 1) Or B = P(5, 1) Or B = P(6, 1) Then
                    X(i, j).BackColor = Color.Blue
                ElseIf B = P(0, 2) Or B = P(1, 2) Or B = P(2, 2) Or B = P(3, 2) Or B = P(4, 2) Or B = P(5, 2) Or B = P(6, 2) Then
                    X(i, j).BackColor = Color.Violet
                ElseIf B = P(0, 3) Or B = P(1, 3) Or B = P(2, 3) Or B = P(3, 3) Or B = P(4, 3) Or B = P(5, 3) Or B = P(6, 3) Then
                    X(i, j).BackColor = Color.Green
                End If
                Me.Controls.Add(X(i, j))
            Next
        Next
        For i = 0 To V - 1
            For j = 0 To T - 1
                For k = 0 To T - 1
                    If X(j, k).Text = P(i, 1) Then
                        G(i, 0) = X(j, k).Left
                        G(i, 1) = X(j, k).Top
                    End If
                Next
            Next
        Next
        For i = 0 To U - 1
            For j = 0 To T - 1
                For k = 0 To T - 1
                    If X(j, k).Text = P(i, 3) Then
                        Q(i, 0) = X(j, k).Left
                        Q(i, 1) = X(j, k).Top
                    End If
                Next
            Next
        Next
        For i = 0 To R - 1
            S(i) = 1
        Next
        Call disnama()
    End Sub

    Private Sub BtnDadu_Click(sender As Object, e As EventArgs) Handles BtnDadu.Click
        Tmrandom1.Enabled = True
        LbDadu.Font = New Font(LbDadu.Font, FontStyle.Strikeout)
        C = 0
        BtnDadu.Enabled = False
        A = Rndm.Next(1, 7)
        If A <> 6 Then
            If W = 1 Then
                W = 0
            Else
                If F = R - 1 Then
                    F = 0
                Else
                    F += 1
                End If
            End If
        ElseIf A = 6 Then
            If W = 0 Then
                If F = R - 1 Then
                    F = 0
                Else
                    F += 1
                End If
                W = 1
            End If
        End If
        Call Tmrandom1_Tick(sender, e)
    End Sub

    Private Sub Tmrandom1_Tick(sender As Object, e As EventArgs) Handles Tmrandom1.Tick
        Randomize()
        If angka > 0 Then
            angkarandom = Rndm.Next(1, 7)
            LbDadu.Text = angkarandom
            angka -= 1
        Else
            Tmrandom1.Enabled = False
            Tm1.Enabled = True
            angka = 30
            LbDadu.Text = A
            LbDadu.Font = New Font(LbDadu.Font, FontStyle.Underline)
        End If
    End Sub

    Sub Main(ByVal sender As Object, ByVal e As EventArgs)
        If C < A Then
            If S(F) >= T * T Then
                If T = 9 Then
                    Z(F).Left = Z(F).Left - 40
                Else
                    Z(F).Left = Z(F).Left + 40
                End If
                H = H + 1
            ElseIf S(F) > T And S(F) < T * 2 Or S(F) > T * 3 And S(F) < T * 4 Or S(F) > T * 5 And S(F) < T * 6 Or S(F) > T * 7 And S(F) < T * 8 Or S(F) > T * 9 And S(F) < T * 10 Then
                Z(F).Left = Z(F).Left - 40
            ElseIf S(F) Mod T = 0 Then
                Z(F).Top = Z(F).Top - 40
            Else
                Z(F).Left = Z(F).Left + 40
            End If
            S(F) = S(F) + 1
            C = C + 1
        Else
            If S(F) > T * T Then
                S(F) = T * T - H
                H = 0
            End If
            For i = 0 To V - 1
                If S(F) = P(i, 0) Then
                    If F = 1 Then
                        Z(F).Location = New Point(G(i, 0) + 20, G(i, 1))
                    ElseIf F = 2 Then
                        Z(F).Location = New Point(G(i, 0), G(i, 1) + 20)
                    ElseIf F = 3 Then
                        Z(F).Location = New Point(G(i, 0) + 20, G(i, 1) + 20)
                    ElseIf F = 0 Then
                        Z(F).Location = New Point(G(i, 0), G(i, 1))
                    End If
                    S(F) = P(i, 1)
                End If
            Next
            For i = 0 To U - 1
                If S(F) = P(i, 2) Then
                    If F = 1 Then
                        Z(F).Location = New Point(Q(i, 0) + 20, Q(i, 1))
                    ElseIf F = 2 Then
                        Z(F).Location = New Point(Q(i, 0), Q(i, 1) + 20)
                    ElseIf F = 3 Then
                        Z(F).Location = New Point(Q(i, 0) + 20, Q(i, 1) + 20)
                    ElseIf F = 0 Then
                        Z(F).Location = New Point(Q(i, 0), Q(i, 1))
                    End If
                    S(F) = P(i, 3)
                End If
            Next
            Tm1.Enabled = False
            BtnDadu.Enabled = True
            If S(F) = T * T Then
                Formmenang.ShowDialog()
                Me.Close()
                PN_Menu.Close()
                Main_Menu.Close()
            End If
            If A <> 6 Then
                Call disnama()
            End If
        End If
    End Sub
    Private Sub BtnCheat_Click(sender As Object, e As EventArgs) Handles BtnCheat.Click
        Tm1.Enabled = True
        A = TbCheat.Text
        C = 0
        If A <> 6 Then
            If W = 1 Then
                W = 0
            Else
                If F = R - 1 Then
                    F = 0
                Else
                    F += 1
                End If
            End If
        Else
            If W = 0 Then
                F += 1
            End If
            W = 1
        End If
        Call Tmrandom1_Tick(sender, e)
    End Sub
    Function disnama()
        If R = 4 Then
            If F = 0 Then
                LLangka.Text = PN_Menu.PN_1.Text
                LLangka.ForeColor = Color.Blue
            ElseIf F = 1 Then
                LLangka.Text = PN_Menu.PN_3.Text
                LLangka.ForeColor = Color.Black
            ElseIf F = 2 Then
                LLangka.Text = PN_Menu.PN_4.Text
                LLangka.ForeColor = Color.Brown
            ElseIf F = 3 Then
                LLangka.Text = PN_Menu.PN_2.Text
                LLangka.ForeColor = Color.Red
            End If
        ElseIf R = 3 Then
            If F = 0 Then
                LLangka.Text = PN_Menu.PN_1.Text
                LLangka.ForeColor = Color.Blue
            ElseIf F = 1 Then
                LLangka.Text = PN_Menu.PN_3.Text
                LLangka.ForeColor = Color.Black
            ElseIf F = 2 Then
                LLangka.Text = PN_Menu.PN_2.Text
                LLangka.ForeColor = Color.Red
            End If
        ElseIf R = 2 Then
            If F = 0 Then
                LLangka.Text = PN_Menu.PN_1.Text
                LLangka.ForeColor = Color.Blue
            ElseIf F = 1 Then
                LLangka.Text = PN_Menu.PN_2.Text
                LLangka.ForeColor = Color.Red
            End If
        End If
        Return LLangka
    End Function
End Class