Public Class ui
    Private S1 As AL
    Public loading As Boolean = False
    Private Sub ui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        S1 = New AL()
        loading = True
    End Sub

    Private Sub tiks_Tick(sender As Object, e As EventArgs) Handles tiks.Tick
        If Not IsNothing(S1) Then

            Select Case S1.CURRENT_STEP
                Case AL.STEPS.LOGIN
                    If Not IsNothing(S1.CAPTCHA_IMG) Then
                        loading = True
                        PLogin.Visible = True
                        pcaptcha.Image = S1.CAPTCHA_IMG
                    End If
            End Select
        End If


        If loading Then
            Me.Text = "Loading.."
        Else
            Me.Text = "DONE"

        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If PLogin.Visible Then
            S1.Login(tcaptcha.Text)
            PLogin.Visible = True
        End If
    End Sub
End Class