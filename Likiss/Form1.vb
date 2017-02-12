Imports System.Text.RegularExpressions

Public Class Form1


    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Button1.Enabled = True
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Controls.Add(w)
        'w.BringToFront()
        'w.Dock = DockStyle.Left
        ' w.Top = 500

        etap1()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For Each c As HtmlElement In w.Document.GetElementsByTagName("input")
            If c.Name = "captcha" Then
                c.SetAttribute("value", captchatxt.Text)
                w.Document.GetElementsByTagName("form")(0).InvokeMember("submit")
                Plogin.Visible = False
                Exit Sub
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As HtmlElement = w.Document.GetElementsByTagName("form")(0)
        For Each i As HtmlElement In f.GetElementsByTagName("input")
            If i.Name = "id" Then
                i.SetAttribute("value", postID.Text)
                f.InvokeMember("submit")
                pPost.Visible = False
                rfrch = True
            End If
        Next
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub


    Private Sub pcp_Click(sender As Object, e As EventArgs) Handles pcp.Click

    End Sub

    Private Sub pcp_Paint(sender As Object, e As PaintEventArgs) Handles pcp.Paint


    End Sub

    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick
        If Not wait_for Is Nothing Then
            If wait_for(0) < 1 And wait_for(1) < 1 Then

            Else
                waittxt.Text = String.Format(waittxt.Tag, wait_for(0) & ":" & wait_for(1))
                If wait_for(1) < 0 Then wait_for(1) = 60 : wait_for(0) -= 1
                If wait_for(0) = 0 And wait_for(1) = 0 Then
                    vario.notif()
                    Exit Sub

                End If
                wait_for(1) -= 1

            End If
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If w.Document.GetElementById("countdown").InnerText <> "" Then
            Dim x As String
            Dim reg As New Regex("[a-zA-Z]")
            x = reg.Replace(w.Document.GetElementById("countdown").InnerText, "")
            wait_for = x.Split(":")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim oo As String = w.Document.GetElementById("countdown").InnerText
        If oo = "READY !!!" Then
            pPost.Visible = True
            waittxt.Visible = False
        ElseIf Not oo.Contains("!!!") Then
            If w.Document.GetElementById("countdown").InnerText = "" Then
                waittxt.Text = String.Format(waittxt.Tag, "[unkown_time]")
                Timer1.Enabled = True
            Else
                waittxt.Text = String.Format(waittxt.Tag, w.Document.GetElementById("countdown").InnerText)
                Dim x As String
                Dim reg As New Regex("[a-zA-Z]")
                x = reg.Replace(w.Document.GetElementById("countdown").InnerText, "")
                wait_for = x.Split(":")
            End If
            waittxt.Visible = True
        End If


        Timer2.Enabled = False
    End Sub

    Private Sub waittxt_Click(sender As Object, e As EventArgs) Handles waittxt.Click

    End Sub
End Class
