Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a + b
        MsgBox("Hasil Penjumlahan " + c, MsgBoxStyle.Information, "Hasil")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a - b
        MsgBox("Hasil Pengurangan " + c, MsgBoxStyle.Information, "Hasil")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a * b
        MsgBox("Hasil Perkalian " + c, MsgBoxStyle.Information, "Hasil")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b As Integer
        Dim c As String
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a / b
        MsgBox("Hasil Pembagian " + c, MsgBoxStyle.Information, "Hasil")

    End Sub
End Class
