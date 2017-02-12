Public Class vario
    Public Shared Function randColor() As Color
        Dim MyAlpha As Integer
        Dim MyRed As Integer
        Dim MyGreen As Integer
        Dim MyBlue As Integer
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyAlpha = CInt(Int((254 * Rnd()) + 0))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyRed = CInt(Int((254 * Rnd()) + 0))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyGreen = CInt(Int((254 * Rnd()) + 0))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyBlue = CInt(Int((254 * Rnd()) + 0))

        Return Color.FromArgb(MyAlpha, MyRed, MyGreen, MyBlue)
    End Function
    Public Shared Function renderCAPTCHA(img As Bitmap) As Bitmap
        Dim re As New Bitmap(500, 500)
        If Not img Is Nothing Then
            Dim penn As New Pen(Brushes.White, 1)
            Dim b = img
            Dim g As Graphics = Graphics.FromImage(re)
            g.Clear(Color.Black)
            For w As Integer = 1 To b.Width - 1
                For h As Integer = 1 To b.Height - 1
                    If b.GetPixel(w, h) = Color.FromArgb(255, 255, 0, 0) Then
                        g.DrawRectangle(penn, w, h, 1, 1)
                    End If
                Next
            Next


        End If
        Return re
    End Function
    Public Shared Function notif()
        My.Computer.Audio.Play("C:\Windows\Media\Alarm02.wav")
        My.Computer.Audio.Play("C:\Windows\Media\Alarm02.wav")
    End Function
End Class
