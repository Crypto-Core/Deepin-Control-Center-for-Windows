Public Class start
    Private hide_ As Boolean = False

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.shutdown_hover
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.shutdown_normal
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.Image = My.Resources.account_press
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.account_hover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources.account_normal
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        Button1.Image = My.Resources.account_hover
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Button2.Image = My.Resources.display_press
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.display_hover
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources.display_normal
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
        Button2.Image = My.Resources.display_normal
    End Sub

    Private Sub Button3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        Button3.Image = My.Resources.default_applications_press
    End Sub


    Private Sub slide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slide.Tick
        If hide_ = False Then
            Panel3.Location = New Point(Panel3.Location.X, Panel3.Location.Y - 15)
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y + 15)
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
            Button14.Visible = False
            Button15.Visible = False
            If Panel3.Location.Y + Panel3.Size.Height < 0 Then
                slide.Enabled = False
                Form1.Controls.Clear()
                Form1.Controls.Add(menu_.Panel1)
                menu_.Panel1.Show()
                hide_ = True
            End If
        Else
            Panel3.Location = New Point(Panel3.Location.X, Panel3.Location.Y + 15)
            Panel2.Location = New Point(Panel2.Location.X, Panel2.Location.Y - 15)
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            Button13.Visible = True
            Button14.Visible = True
            Button15.Visible = True
            If Panel3.Location.Y > 0 Then
                Panel3.Location = New Point(Panel3.Location.X, 0)
                Panel2.Location = New Point(Panel2.Location.X, Panel1.Size.Height - Panel2.Size.Height)
                slide.Enabled = False
                hide_ = False

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Add(personal.Panel1)
        personal.Panel1.Show()
        menu_.Button2.Image = My.Resources.account_press
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class