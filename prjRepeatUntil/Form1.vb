Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim Number As Integer = 0

        '
        Randomize()
        Number = Rnd() * 100 \ 10
        MsgBox(Number)
        Do
            i = InputBox("Guess a number")
            If i <> Number Then
                MsgBox("Incorrect")
            End If

        Loop Until i = Number

    End Sub
End Class
