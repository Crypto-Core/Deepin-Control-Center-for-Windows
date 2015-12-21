Imports System.Security.Principal
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
                main_frm.Controls.Clear()
                main_frm.Controls.Add(menu_.Panel1)
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
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(personal.Panel1)
        personal.Panel1.Show()
        menu_.Button2.Image = My.Resources.account_press



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(display.Panel1)
        display.Panel1.Show()
        menu_.Button3.Image = My.Resources.display_press
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Image = My.Resources.default_applications_hover
    End Sub

    Private Sub Button3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseUp
        Button3.Image = My.Resources.default_applications_normal
    End Sub

    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        Button4.Image = My.Resources.personalization_press
    End Sub

    Private Sub Button4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.Image = My.Resources.personalization_hover
    End Sub

    Private Sub Button4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseUp
        Button4.Image = My.Resources.personalization_normal
    End Sub

    Private Sub Button5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseDown
        Button5.Image = My.Resources.network_press
    End Sub

    Private Sub Button5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Button5.Image = My.Resources.network_hover
    End Sub

    Private Sub Button5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseUp
        Button5.Image = My.Resources.network_normal
    End Sub

    Private Sub Button6_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseDown
        Button6.Image = My.Resources.bluetooth_press
    End Sub

    Private Sub Button6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseHover
        Button6.Image = My.Resources.bluetooth_hover
    End Sub

    Private Sub Button6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseUp
        Button6.Image = My.Resources.bluetooth_normal
    End Sub

    Private Sub Button7_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseDown
        Button7.Image = My.Resources.sound_press
    End Sub

    Private Sub Button7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseHover
        Button7.Image = My.Resources.sound_hover
    End Sub

    Private Sub Button7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseUp
        Button7.Image = My.Resources.sound_normal
    End Sub

    Private Sub Button8_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseDown
        Button8.Image = My.Resources.date_time_press
    End Sub

    Private Sub Button8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseHover
        Button8.Image = My.Resources.date_time_hover
    End Sub

    Private Sub Button8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseUp
        Button8.Image = My.Resources.date_time_normal
    End Sub

    Private Sub Button9_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseDown
        Button9.Image = My.Resources.power_press
    End Sub

    Private Sub Button9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseHover
        Button9.Image = My.Resources.power_hover
    End Sub

    Private Sub Button9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseUp
        Button9.Image = My.Resources.power_normal
    End Sub

    Private Sub Button10_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseDown
        Button10.Image = My.Resources.mouse_touchpad_press
    End Sub

    Private Sub Button10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseHover
        Button10.Image = My.Resources.mouse_touchpad_hover
    End Sub

    Private Sub Button10_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseUp
        Button10.Image = My.Resources.mouse_touchpad_normal
    End Sub

    Private Sub Button11_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseDown
        Button11.Image = My.Resources.keyboard_press
    End Sub

    Private Sub Button11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseHover
        Button11.Image = My.Resources.keyboard_hover
    End Sub

    Private Sub Button11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseUp
        Button11.Image = My.Resources.keyboard_normal
    End Sub

    Private Sub Button12_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseDown
        Button12.Image = My.Resources.keyboard_press
    End Sub

    Private Sub Button12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseHover
        Button12.Image = My.Resources.keyboard_hover
    End Sub

    Private Sub Button12_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseUp
        Button12.Image = My.Resources.keyboard_normal
    End Sub

    Private Sub Button13_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseDown
        Button13.Image = My.Resources.remoting_press
    End Sub

    Private Sub Button13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseHover
        Button13.Image = My.Resources.remoting_hover
    End Sub

    Private Sub Button13_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseUp
        Button13.Image = My.Resources.remoting_normal
    End Sub

    Private Sub Button14_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseDown
        Button14.Image = My.Resources.grub_press
    End Sub

    Private Sub Button14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseHover
        Button14.Image = My.Resources.grub_hover
    End Sub

    Private Sub Button14_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseUp
        Button14.Image = My.Resources.grub_normal
    End Sub

    Private Sub Button15_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button15.MouseDown
        Button15.Image = My.Resources.system_info_press
    End Sub

    Private Sub Button15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseHover
        Button15.Image = My.Resources.system_info_hover
    End Sub

    Private Sub Button15_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button15.MouseUp
        Button15.Image = My.Resources.system_info_normal
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(application.Panel1)
        application.Panel1.Show()
        menu_.Button4.Image = My.Resources.default_applications_press
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(personalization.Panel1)
        personalization.Panel1.Show()
        menu_.Button5.Image = My.Resources.personalization_press
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(network.Panel1)
        network.Panel1.Show()
        menu_.Button6.Image = My.Resources.network_press
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(bluetooth.Panel1)
        bluetooth.Panel1.Show()
        'menu_.Button7.Image = My.Resources.bluetooth_press
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        slide.Enabled = True
        menu_.Panel3.Controls.Clear()
        menu_.Panel3.Controls.Add(sound.Panel1)
        sound.Panel1.Show()
        menu_.Button7.Image = My.Resources.sound_press
    End Sub
End Class