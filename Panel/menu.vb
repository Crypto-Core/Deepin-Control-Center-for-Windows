Public Class menu_

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Controls.Clear()
        Form1.Controls.Add(start.Panel1)
        start.Panel1.Show()
        start.slide.Enabled = True
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.Image = My.Resources.home_press
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Image = My.Resources.home_hover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Image = My.Resources.home_normal
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        Button1.Image = My.Resources.home_hover
    End Sub

    Private Sub Button2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Button2.Image = My.Resources.account_press
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Image = My.Resources.account_hover1
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Image = My.Resources.account_normal1
    End Sub
End Class