﻿Public Class Form1
    Dim num, contador, suma, promedio As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox1.Text
        If num <> 0 Then
            contador += 1
            suma += num
            promedio = suma / contador
            TextBox2.Text = promedio
            TextBox1.Clear()
        Else
        End If
        Button1.Enabled = False
    End Sub
End Class
