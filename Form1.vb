Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> "" And Microsoft.VisualBasic.Left(TextBox1.Text, 1) <> "-" And Microsoft.VisualBasic.Right(TextBox1.Text, 1) <> "-" Then
            Try
                TextBox2.Text = ""
                Dim n1 As Long = TextBox1.Text '不能超过9223372036854775807
                Dim n16 = Convert.ToString(n1, 16)

                For i = 1 To Len(n16)

                    Dim f5da2 = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(n16, i), 1) '提取每一个字符

                    If f5da2 = "a" Then
                        f5da2 = 10
                    ElseIf f5da2 = "b" Then
                        f5da2 = 11
                    ElseIf f5da2 = "c" Then
                        f5da2 = 12
                    ElseIf f5da2 = "d" Then
                        f5da2 = 13
                    ElseIf f5da2 = "e" Then
                        f5da2 = 14
                    ElseIf f5da2 = "f" Then
                        f5da2 = 15
                    End If

                    TextBox2.Text = TextBox2.Text & f5da2 & " * 16 ^ " & (Len(n16) - i) & " + "

                Next

                TextBox2.Text = Microsoft.VisualBasic.Left(TextBox2.Text, Len(TextBox2.Text) - 3)

                TextBox2.Text = n1 & " = " & TextBox2.Text

            Catch ex As Exception
                TextBox2.Text = ""
            End Try
        Else
            TextBox2.Text = ""
        End If

    End Sub

End Class