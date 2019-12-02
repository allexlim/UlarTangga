Public Class FormPlay
    Dim X(10, 10) As Button
    Dim Y(1) As Integer
    Dim Z(3) As Button
    Dim P(5, 1) As Integer
    Dim A As Integer
    Dim B As Integer = 0
    Dim C, R, T As Integer
    Dim D As Integer = 1
    Dim Rndm As New Random
    Dim F As Integer = 0
    Dim G(5) As Integer
    Dim H As Integer = 0
    Dim Q(5) As Integer
    Dim S(3) As Integer
    Dim angka As Integer = 30
    Dim simpan As Integer
    Dim hello As Integer = 0
    Private Sub FormPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Main_Menu.RB_P2.Checked = True Then
            R = 2
        ElseIf Main_Menu.RB_P3.Checked = True Then
            R = 3
        ElseIf Main_Menu.RB_P4.Checked = True Then
            R = 4
        End If
        If Main_Menu.RB_Easy.Checked = True Or Main_Menu.RB_Med.Checked = True Then
            T = 8
        ElseIf Main_Menu.RB_Har.Checked = True Then
            T = 9
        ElseIf Main_Menu.RB_Ext.Checked = True Or Main_Menu.RB_Idi.Checked = True Then
            T = 10
        End If
        For i = 0 To 5
            P(i, 0) = Rndm.Next(20, T * T - 1)
            For j = 0 To i - 1
                While P(i, 0) = P(j, 0)
                    P(i, 0) = Rndm.Next(20, T * T - 1)
                End While
            Next
            P(i, 1) = Rndm.Next(2, T * T - 1)
            While P(i, 1) >= P(i, 0) - 10
                P(i, 1) = Rndm.Next(2, T * T - 1)
            End While
            ListBox1.Items.Add(P(i, 0))
            ListBox2.Items.Add(P(i, 1))
        Next
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
                If B = P(0, 0) Or B = P(1, 0) Or B = P(2, 0) Or B = P(3, 0) Or B = P(4, 0) Or B = P(5, 0) Then
                    X(i, j).BackColor = Color.Red
                ElseIf B = P(0, 1) Or B = P(1, 1) Or B = P(2, 1) Or B = P(3, 1) Or B = P(4, 1) Or B = P(5, 1) Then
                    X(i, j).BackColor = Color.Blue
                End If
                Me.Controls.Add(X(i, j))
            Next
        Next
        For i = 0 To 5
            For j = 0 To T - 1
                For k = 0 To T - 1
                    If X(j, k).Text = P(i, 1) Then
                        G(i) = X(j, k).Left
                        Q(i) = X(j, k).Top
                    End If
                Next
            Next
        Next
        For i = 0 To R - 1
            S(i) = 1
        Next
    End Sub

    Private Sub BtnDadu_Click(sender As Object, e As EventArgs) Handles BtnDadu.Click
        F = CInt(Label2.Text)
        Tmrandom1.Enabled = True
        Tmrandom2.Enabled = True
        LbDadu.Font = New Font(LbDadu.Font, FontStyle.Strikeout)
        C = 0
        BtnDadu.Enabled = False
        If F = 0 Then
            H = 0
            F = 1
        ElseIf F = 1 Then
            H = 1
            F = 2
        ElseIf F = 2 Then
            H = 2
            F = 3
        ElseIf F = 3 Then
            H = 3
            F = 0
        End If
        If F = R Then
            H = 0
        End If
        If A = 6 Then
            F = H
        End If
        Label1.Text = H
        Label2.Text = F
        AddHandler Tm1.Tick, AddressOf Main
    End Sub

    Private Sub Tmrandom1_Tick(sender As Object, e As EventArgs) Handles Tmrandom1.Tick
        Randomize()
        If angka > 0 Then
            A = Rnd() * 5 + 1
            LbDadu.Text = A
            angka -= 1
        Else
            Tmrandom1.Enabled = False
            hello = 1
        End If
    End Sub

    Private Sub Tmrandom2_Tick(sender As Object, e As EventArgs) Handles Tmrandom2.Tick
        Randomize()
        If hello = 1 Then
            Tmrandom2.Enabled = False
            A = Rnd() * 5 + 1
            LbDadu.Text = A
            LbDadu.Font = New Font(LbDadu.Font, FontStyle.Underline)
            angka = 30
            hello = 0
            Tm1.Enabled = True
        End If
    End Sub

    Sub Main(ByVal sender As Object, ByVal e As EventArgs)
        H = CInt(Label1.Text)
        If C < A Then
            If S(H) Mod T = 0 Then
                Z(H).Top = Z(H).Top - 40
            ElseIf S(H) > T And S(H) < T * 2 Or S(H) > T * 3 And S(H) < T * 4 Or S(H) > T * 5 And S(H) < T * 6 Or S(H) > T * 7 And S(H) < T * 8 Or S(H) > T * 9 And S(H) < T * 10 Then
                Z(H).Left = Z(H).Left - 40
            Else
                Z(H).Left = Z(H).Left + 40
            End If
            S(H) = S(H) + 1
            C = C + 1
            'MsgBox(Z(1).Left.ToString)
        Else
            For i = 0 To 5
                If D = P(i, 0) Then
                    Z(H).Location = New Point(G(i) + 20, Q(i))
                    D = P(i, 1)
                End If
            Next
            Tm1.Enabled = False
            BtnDadu.Enabled = True
        End If
    End Sub
    Private Sub BtnCheat_Click(sender As Object, e As EventArgs) Handles BtnCheat.Click
        Tm1.Enabled = True
        A = TbCheat.Text
        C = 0
        If F = 0 Then
            H = 0
            F = 1
        ElseIf F = 1 Then
            H = 1
            F = 2
        ElseIf F = 2 Then
            H = 2
            F = 3
        ElseIf F = 3 Then
            H = 3
            F = 0
        End If
        If F = R Then
            H = 0
        End If
        If A = 6 Then
            F = H
        End If
        Label1.Text = H
        AddHandler Tm1.Tick, AddressOf Main
    End Sub
End Class