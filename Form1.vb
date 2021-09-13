Public Class Form1

    Dim firstNumber As Decimal
    Dim secondNumber As Decimal
    Dim operations As Integer
    Dim operatorSelect As Boolean = False

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If TextBox1.Text.Length = 0 Then
            Buttonclr.Enabled = False
        Else
            Buttonclr.Enabled = True
        End If

        TextBox1.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
            TextBox2.Text += "1"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "1"
            TextBox2.Text = "1"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
            TextBox2.Text += "2"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "2"
            TextBox2.Text = "2"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
            TextBox2.Text += "3"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "3"
            TextBox2.Text = "3"
            Buttonclr.Enabled = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
            TextBox2.Text += "4"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "4"
            TextBox2.Text = "4"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
            TextBox2.Text += "5"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "5"
            TextBox2.Text = "5"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
            TextBox2.Text += "6"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "6"
            TextBox2.Text = "6"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
            TextBox2.Text += "7"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "7"
            TextBox2.Text = "7"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
            TextBox2.Text += "8"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "8"
            TextBox2.Text = "8"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
            TextBox2.Text += "9"
            Buttonclr.Enabled = True
        Else
            TextBox1.Text = "9"
            TextBox2.Text += "9"
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
            TextBox2.Text += "0"
            Buttonclr.Enabled = True

        End If
    End Sub

    Private Sub Buttonclr_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Buttondec_Click(sender As Object, e As EventArgs) Handles Buttondec.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
            TextBox2.Text += "."
            Buttonclr.Enabled = True
        End If
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TextBox1.Text = "0"
        TextBox2.Text = ""
        Buttonclr.Enabled = False
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        firstNumber = TextBox1.Text
        TextBox1.Text = ""
        TextBox2.Text += "+"
        operations = 1
        operatorSelect = True

    End Sub

    Private Sub Buttonminus_Click(sender As Object, e As EventArgs) Handles Buttonminus.Click
        firstNumber = TextBox1.Text
        TextBox1.Text = ""
        TextBox2.Text += "-"
        operations = 2
        operatorSelect = True
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        firstNumber = TextBox1.Text
        TextBox1.Text = ""
        TextBox2.Text += "x"
        operations = 3
        operatorSelect = True
    End Sub

    Private Sub Buttondiv_Click(sender As Object, e As EventArgs) Handles Buttondiv.Click
        firstNumber = TextBox1.Text
        TextBox1.Text = ""
        TextBox2.Text += "/"
        operations = 4
        operatorSelect = True
    End Sub

    Private Sub Buttonper_Click(sender As Object, e As EventArgs) Handles Buttonper.Click
        firstNumber = TextBox1.Text
        TextBox1.Text = firstNumber / 100

    End Sub

    Private Sub Buttoneqaul_Click(sender As Object, e As EventArgs) Handles Buttoneqaul.Click
        If operatorSelect = True Then
            If operations = 1 Then
                secondNumber = TextBox1.Text
                TextBox1.Text = firstNumber + secondNumber
                TextBox2.Text += "="
                TextBox2.Text += TextBox1.Text
            ElseIf operations = 2 Then
                secondNumber = TextBox1.Text
                TextBox1.Text = firstNumber - secondNumber
                TextBox2.Text += "="
                TextBox2.Text += TextBox1.Text
            ElseIf operations = 3 Then
                secondNumber = TextBox1.Text
                TextBox1.Text = firstNumber * secondNumber
                TextBox2.Text += "="
                TextBox2.Text += TextBox1.Text
            ElseIf operations = 4 Then
                secondNumber = TextBox1.Text
                If secondNumber = 0 Then
                    TextBox1.Text = "Error..!"
                Else
                    TextBox1.Text = firstNumber / secondNumber
                    TextBox2.Text += "="
                    TextBox2.Text += TextBox1.Text
                End If
            End If
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "-"
            TextBox2.Text = "-"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text * (-1)
            TextBox2.Text = ""
            TextBox2.Text = TextBox1.Text
        End If

    End Sub

    Private Sub Buttonclr_Click_1(sender As Object, e As EventArgs) Handles Buttonclr.Click

        If TextBox1.Text.Length = 1 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1)
            Buttonclr.Enabled = False
        Else
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1)

        End If



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim result As DialogResult = MessageBox.Show("Standard Calculator
This application is designed and created by Shubham, at A.M College - BCA Department")

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If e.KeyChar = "1" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "1"
                TextBox2.Text += "1"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "1"
                TextBox2.Text = "1"
                Buttonclr.Enabled = True
            End If
        ElseIf e.KeyChar = "2" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "2"
                TextBox2.Text += "2"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "2"
                TextBox2.Text = "2"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "3" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "3"
                TextBox2.Text += "3"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "3"
                TextBox2.Text = "3"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "4" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "4"
                TextBox2.Text += "4"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "4"
                TextBox2.Text = "4"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "5" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "5"
                TextBox2.Text += "5"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "5"
                TextBox2.Text = "5"
                Buttonclr.Enabled = True
            End If


        ElseIf e.KeyChar = "6" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "6"
                TextBox2.Text += "6"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "6"
                TextBox2.Text = "6"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "7" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "7"
                TextBox2.Text += "7"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "7"
                TextBox2.Text = "7"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "8" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "8"
                TextBox2.Text += "8"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "8"
                TextBox2.Text = "8"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "9" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "9"
                TextBox2.Text += "9"
                Buttonclr.Enabled = True
            Else
                TextBox1.Text = "9"
                TextBox2.Text += "9"
                Buttonclr.Enabled = True
            End If

        ElseIf e.KeyChar = "0" Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "0"
                TextBox2.Text += "0"
                Buttonclr.Enabled = True

            End If

        ElseIf e.KeyChar = "+" Then
            firstNumber = TextBox1.Text
            TextBox1.Text = ""
            TextBox2.Text += "+"
            operations = 1
            operatorSelect = True

        ElseIf e.KeyChar = "-" Then
            firstNumber = TextBox1.Text
            TextBox1.Text = ""
            TextBox2.Text += "-"
            operations = 2
            operatorSelect = True

        ElseIf e.KeyChar = "*" Then
            firstNumber = TextBox1.Text
            TextBox1.Text = ""
            TextBox2.Text += "x"
            operations = 3
            operatorSelect = True


        ElseIf e.KeyChar = "/" Then
            firstNumber = TextBox1.Text
            TextBox1.Text = ""
            TextBox2.Text += "/"
            operations = 4
            operatorSelect = True

        ElseIf e.KeyChar = "%" Then
            firstNumber = TextBox1.Text
            TextBox1.Text = firstNumber / 100

        ElseIf Asc(e.KeyChar) = 8 Then
            If TextBox1.Text.Length = 1 Then
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1)
                Buttonclr.Enabled = False
            Else
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
                TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1)

            End If

        ElseIf e.KeyChar = "=" Then
            If operatorSelect = True Then
                If operations = 1 Then
                    secondNumber = TextBox1.Text
                    TextBox1.Text = firstNumber + secondNumber
                    TextBox2.Text += "="
                    TextBox2.Text += TextBox1.Text
                ElseIf operations = 2 Then
                    secondNumber = TextBox1.Text
                    TextBox1.Text = firstNumber - secondNumber
                    TextBox2.Text += "="
                    TextBox2.Text += TextBox1.Text
                ElseIf operations = 3 Then
                    secondNumber = TextBox1.Text
                    TextBox1.Text = firstNumber * secondNumber
                    TextBox2.Text += "="
                    TextBox2.Text += TextBox1.Text
                ElseIf operations = 4 Then
                    secondNumber = TextBox1.Text
                    If secondNumber = 0 Then
                        TextBox1.Text = "Error..!"
                    Else
                        TextBox1.Text = firstNumber / secondNumber
                        TextBox2.Text += "="
                        TextBox2.Text += TextBox1.Text
                    End If
                End If
            End If

        End If

    End Sub
End Class
