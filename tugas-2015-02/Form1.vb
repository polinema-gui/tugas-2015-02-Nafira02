Public Class Kalkulator
    Dim angka1 As Integer
    Dim angka2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.TextBox1.Text = "0") Then
                Me.TextBox1.Text = Convert.ToString(angka)
            Else
                Dim TextBox1 As TextBox = Me.TextBox1
                TextBox1.Text = (TextBox1.Text & Convert.ToString(angka))
            End If
        Else
            Me.TextBox1.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub

    Private Sub inputOprator(ByVal oprator As String)
        If (Me.TextBox1.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.angka1 = Convert.ToInt32(Me.TextBox1.Text)
                Me.TextBox1.Text = Me.angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub

    Private Sub hitung()
        Me.angka2 = Convert.ToInt32(Me.TextBox1.Text)
        Select Case Me.operasi
            Case "+"
                Me.angka1 = (Me.angka1 + Me.angka2)
                Exit Select
            Case "-"
                Me.angka1 = (Me.angka1 - Me.angka2)
                Exit Select
        End Select
        Me.TextBox1.Text = Me.angka1.ToString
        Me.status = False
    End Sub

    Private Sub Button_0_Click(sender As Object, e As EventArgs) Handles Button_0.Click
        If (Me.status AndAlso (Me.TextBox1.Text <> "0")) Then
            Dim TextBox1 As TextBox = Me.TextBox1
            TextBox1.Text = (TextBox1.Text & "0")
        End If
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        Me.input("1")
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        Me.input("2")
    End Sub

    Private Sub Button_3_Click(sender As Object, e As EventArgs) Handles Button_3.Click
        Me.input("3")
    End Sub

    Private Sub Button_4_Click(sender As Object, e As EventArgs) Handles Button_4.Click
        Me.input("4")
    End Sub

    Private Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button_5.Click
        Me.input("5")
    End Sub

    Private Sub Button_6_Click(sender As Object, e As EventArgs) Handles Button_6.Click
        Me.input("6")
    End Sub

    Private Sub Button_7_Click(sender As Object, e As EventArgs) Handles Button_7.Click
        Me.input("7")
    End Sub

    Private Sub Button_8_Click(sender As Object, e As EventArgs) Handles Button_8.Click
        Me.input("8")
    End Sub

    Private Sub Button_9_Click(sender As Object, e As EventArgs) Handles Button_9.Click
        Me.input("9")
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        Me.TextBox1.Text = "0"
        Me.angka1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub Button_pengurangan_Click(sender As Object, e As EventArgs) Handles Button_pengurangan.Click
        Me.inputOprator("-")
    End Sub


    Private Sub Button_penjumlahan_Click(sender As Object, e As EventArgs) Handles Button_penjumlahan.Click
        Me.inputOprator("+")
    End Sub

    Private Sub Button_equalse_Click(sender As Object, e As EventArgs) Handles Button_equalse.Click
        If ((Me.TextBox1.Text <> "0") And (Me.angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If

    End Sub
End Class
