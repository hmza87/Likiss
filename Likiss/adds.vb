Imports System.Text.RegularExpressions

Module adds
    Public w As New WebBrowser()
    Public stat As String
    Public LOGGED_IN As Boolean = False, rfrch As Boolean = False
    Public wait_for As String()
    Public Tokens() As String = { _
        "EAAC2lsALPUwBAMf0apBN0th3iG1ZC9SvduUcAdaqE9cYhzkA5ydWEonmTgIzsXSPKgWj71xMV95l91rjnvMImZB6rEuzgx5qzT7aZBGOQAZABWgjhzokcaDqZCCWzv3SmMgma9DFN6t20mAP1dNriGCErrCeUGakZD" _
    , ""}



    Public Sub etap1()
        AddHandler w.DocumentCompleted, AddressOf _DocumentCompleted

        w.ScriptErrorsSuppressed = True
        w.Navigate("http://home.autolike.world/")
    End Sub
    Private Sub _DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        e1()
        e2()
        e3()
        For Each h As HtmlElement In w.Document.GetElementsByTagName("h3")
            If h.InnerText = "Select Our Service" Then
                LOGGED_IN = True
                w.Navigate("http://home.autolike.world/?type=status")
            End If
        Next
        Form1.Text = "done"
        Form1.Button1.Enabled = True
        If rfrch Then etap1()
    End Sub
    Private Sub _Navigating()
        Form1.Text = "Loading.."
        Form1.Button1.Enabled = False
    End Sub
    Sub e1()
        Try
            Dim t, d As HtmlElement
            t = w.Document.GetElementById("token")
            d = w.Document.GetElementById("composer_form")
            If Not d Is Nothing And Not t Is Nothing Then
                w.Document.GetElementById("token").SetAttribute("value", Tokens(0))
                d.InvokeMember("submit")

            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub e2()
        Try
            For Each i As HtmlElement In w.Document.GetElementsByTagName("h3")

                If i.InnerText = "Insert Security Code To Continue" Then
                    Dim t, d As HtmlElement
                    t = w.Document.GetElementById("captch")
                    d = w.Document.GetElementsByTagName("form")(0)
                    If Not d Is Nothing Then
                        Dim cap As HtmlElement = d.GetElementsByTagName("img")(0)
                        cap.ScrollIntoView(True)
                        Dim bmp As New Bitmap(500, 500)
                        Dim g As Graphics = w.CreateGraphics
                        w.DrawToBitmap(bmp, cap.ClientRectangle)
                        Form1.pcp.Image = vario.renderCAPTCHA(bmp)
                        Form1.Plogin.Visible = True

                    End If
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Sub e3()
        Try
            For Each i As HtmlElement In w.Document.GetElementsByTagName("h3")
                If i.InnerText = "Select Your Status" Then
                    Dim oo As String = w.Document.GetElementById("countdown").InnerText
                    If oo = "READY !!!" Then
                        Form1.pPost.Visible = True
                        Form1.waittxt.Visible = False
                    ElseIf Not oo.Contains("!!!") Then
                        If w.Document.GetElementById("countdown").InnerText = "" Then
                            Form1.waittxt.Text = String.Format(Form1.waittxt.Tag, "[unkown_time]")
                            Form1.Timer1.Enabled = True
                        Else
                            Form1.waittxt.Text = String.Format(Form1.waittxt.Tag, w.Document.GetElementById("countdown").InnerText)
                            Dim x As String
                            Dim reg As New Regex("[a-zA-Z]")
                            x = reg.Replace(w.Document.GetElementById("countdown").InnerText, "")
                            wait_for = x.Split(":")
                        End If
                        Form1.waittxt.Visible = True
                    End If

                End If
            Next
        Catch ex As Exception
            Form1.Timer2.Enabled = True
        End Try
    End Sub
End Module
