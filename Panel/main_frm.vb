Public Class main_frm
    Dim cnt As Integer = 1
    Dim sliding As Boolean = False
    Dim active As Boolean = False
    Private Sub Form1_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        start.PictureBox2.Focus()
        counter.Enabled = True
        mousepos.Enabled = True

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Size.Width, 0)
        Me.Size = New Size(Size.Width, My.Computer.Screen.WorkingArea.Height)
        start.username_lb.Text = Environment.UserName
        Dim img As Image
        Dim t As New Drawing.Bitmap("C:\ProgramData\Microsoft\User Account Pictures\user.png")
        img = t
        start.OvalShape1.BackgroundImage = img
        Controls.Add(start.Panel1)
        start.Panel1.Show()


    End Sub

    Private Sub LogInButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(ColorTranslator.FromHtml("#F7c65c").ToString)

    End Sub
    Private Sub counter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles counter.Tick
        cnt -= 1
        If cnt = 0 Then
            slide.Enabled = True
            counter.Enabled = False
            cnt = 1
        End If
    End Sub

    Private Sub slide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slide.Tick
        If active = False Then
            If sliding = False Then
                Location = New Point(Location.X + 15, 0)
                If Location.X > My.Computer.Screen.WorkingArea.Width Then
                    slide.Enabled = False
                    sliding = True
                    active = True
                End If

            Else
                Location = New Point(Location.X - 30, 0)
                If Location.X < My.Computer.Screen.WorkingArea.Width - Size.Width Then
                    Activate()
                    Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Size.Width, 0)
                    slide.Enabled = False
                    sliding = False
                    mousepos.Enabled = False
                End If
            End If
        Else

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mousepos.Tick
        If MousePosition.Y > My.Computer.Screen.Bounds.Height - 5 Then
            If MousePosition.X > My.Computer.Screen.Bounds.Width - 5 Then
                TopMost = True
                slide.Enabled = True
                active = False
            Else

            End If
        End If
    End Sub
End Class
