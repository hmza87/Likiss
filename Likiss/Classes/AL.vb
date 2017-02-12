Imports System.Text.RegularExpressions

Public Class AL
    Private startURL As String = "http://home.autolike.world/"
    Private likesURL As String = "http://home.autolike.world/?type=status"
    Private w As WebBrowser
    Public LOGGED_IN As Boolean = False, NEEDS_POST_ID As Boolean = False
    Public CURRENT_STEP As STEPS
    Public CAPTCHA_IMG As Bitmap
    Public WAIT_TIME As String()

    Public Enum STEPS
        INIT = 0
        TOKEN
        LOGIN
        POST
        LIKING
        WAITING
    End Enum
    Public Sub New()
        w = New WebBrowser()
        AddHandler w.DocumentCompleted, AddressOf _DocumentCompleted
        w.ScriptErrorsSuppressed = True
        w.Navigate(startURL)
        CURRENT_STEP = STEPS.TOKEN
    End Sub

    Private Sub _DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Select Case CURRENT_STEP
            Case STEPS.TOKEN
                Dim t, d As HtmlElement
                t = w.Document.GetElementById("token")
                d = w.Document.GetElementById("composer_form")
                If Not d Is Nothing And Not t Is Nothing Then
                    w.Document.GetElementById("token").SetAttribute("value", Tokens(0))
                    d.InvokeMember("submit")
                    CURRENT_STEP = STEPS.LOGIN

                End If
            Case STEPS.LOGIN
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
                            CAPTCHA_IMG = vario.renderCAPTCHA(bmp)


                        End If
                    End If
                Next
                For Each h As HtmlElement In w.Document.GetElementsByTagName("h3")
                    If h.InnerText = "Select Our Service" Then
                        LOGGED_IN = True
                        w.Navigate(likesURL)
                        CURRENT_STEP = STEPS.POST
                    End If
                Next
            Case STEPS.POST
                For Each i As HtmlElement In w.Document.GetElementsByTagName("h3")
                    If i.InnerText = "Select Your Status" Then
                        Dim oo As String = w.Document.GetElementById("countdown").InnerText
                        If oo = "READY !!!" Then
                            NEEDS_POST_ID = True
                        ElseIf Not oo.Contains("!!!") Then
                            CURRENT_STEP = STEPS.WAITING
                        End If

                    End If
                Next
               


            Case STEPS.WAITING
                For Each i As HtmlElement In w.Document.GetElementsByTagName("h3")
                    If i.InnerText = "Select Your Status" Then
                        Dim oo As String = w.Document.GetElementById("countdown").InnerText
                        If oo = "READY !!!" Then
                            CURRENT_STEP = STEPS.POST
                        ElseIf Not oo.Contains("!!!") Then
                            CURRENT_STEP = STEPS.WAITING
                            If w.Document.GetElementById("countdown").InnerText = "" Then

                            Else

                                Dim x As String = w.Document.GetElementById("countdown").InnerText
                                Dim reg As New Regex("[a-zA-Z]")
                                x = reg.Replace(w.Document.GetElementById("countdown").InnerText, "")
                                WAIT_TIME = x.Split(":")
                            End If

                        End If

                    End If
                Next


        End Select







    End Sub
    Public Sub Login(captcha_text As String)
        For Each c As HtmlElement In w.Document.GetElementsByTagName("input")
            If c.Name = "captcha" Then
                c.SetAttribute("value", captcha_text)
                w.Document.GetElementsByTagName("form")(0).InvokeMember("submit")
                CURRENT_STEP = STEPS.POST
            End If
        Next
    End Sub


End Class
