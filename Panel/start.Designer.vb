<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.username_lb = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.slide = New System.Windows.Forms.Timer(Me.components)
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 618)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel3.Controls.Add(Me.username_lb)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 146)
        Me.Panel3.TabIndex = 48
        Me.Panel3.TabStop = True
        '
        'username_lb
        '
        Me.username_lb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_lb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.username_lb.Location = New System.Drawing.Point(134, 110)
        Me.username_lb.Name = "username_lb"
        Me.username_lb.Size = New System.Drawing.Size(92, 21)
        Me.username_lb.TabIndex = 1
        Me.username_lb.Text = "USERNAME"
        Me.username_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(360, 146)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OvalShape1.BorderWidth = 2
        Me.OvalShape1.Location = New System.Drawing.Point(139, 20)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.OvalShape1.Size = New System.Drawing.Size(80, 80)
        '
        'slide
        '
        Me.slide.Interval = 1
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button15.Image = Global.Panel.My.Resources.Resources.system_info_normal
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button15.Location = New System.Drawing.Point(233, 461)
        Me.Button15.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(93, 64)
        Me.Button15.TabIndex = 47
        Me.Button15.Text = "Information"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button15.UseCompatibleTextRendering = True
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Image = Global.Panel.My.Resources.Resources.grub_normal
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button14.Location = New System.Drawing.Point(134, 461)
        Me.Button14.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(93, 64)
        Me.Button14.TabIndex = 46
        Me.Button14.Text = "Boot"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button14.UseCompatibleTextRendering = True
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.Image = Global.Panel.My.Resources.Resources.remoting_normal
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(35, 461)
        Me.Button13.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 64)
        Me.Button13.TabIndex = 45
        Me.Button13.Text = "Remoting"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button13.UseCompatibleTextRendering = True
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.Image = Global.Panel.My.Resources.Resources.shortcuts_normal
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button12.Location = New System.Drawing.Point(233, 385)
        Me.Button12.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 64)
        Me.Button12.TabIndex = 44
        Me.Button12.Text = "Shortcuts"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseCompatibleTextRendering = True
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.Image = Global.Panel.My.Resources.Resources.keyboard_normal
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button11.Location = New System.Drawing.Point(134, 385)
        Me.Button11.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(93, 64)
        Me.Button11.TabIndex = 43
        Me.Button11.Text = "Keyboard"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button11.UseCompatibleTextRendering = True
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Image = Global.Panel.My.Resources.Resources.mouse_touchpad_normal
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button10.Location = New System.Drawing.Point(35, 385)
        Me.Button10.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(93, 64)
        Me.Button10.TabIndex = 42
        Me.Button10.Text = "Mouse"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button10.UseCompatibleTextRendering = True
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.Image = Global.Panel.My.Resources.Resources.power_normal
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(233, 309)
        Me.Button9.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 64)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = "Battery"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseCompatibleTextRendering = True
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Image = Global.Panel.My.Resources.Resources.date_time_normal
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(134, 309)
        Me.Button8.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 64)
        Me.Button8.TabIndex = 40
        Me.Button8.Text = "Time"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseCompatibleTextRendering = True
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Image = Global.Panel.My.Resources.Resources.sound_normal
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(35, 309)
        Me.Button7.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 64)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Audio"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseCompatibleTextRendering = True
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Image = Global.Panel.My.Resources.Resources.bluetooth_normal
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(233, 233)
        Me.Button6.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 64)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Bluetooth"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Image = Global.Panel.My.Resources.Resources.network_normal
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(134, 233)
        Me.Button5.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 64)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Network"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Image = Global.Panel.My.Resources.Resources.personalization_normal
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(35, 233)
        Me.Button4.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 64)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Personalization"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Image = Global.Panel.My.Resources.Resources.default_applications_normal
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(233, 157)
        Me.Button3.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 64)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Application"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = Global.Panel.My.Resources.Resources.display_normal
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(134, 157)
        Me.Button2.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 64)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Display"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.Panel.My.Resources.Resources.account_normal
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(35, 157)
        Me.Button1.MaximumSize = New System.Drawing.Size(93, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 64)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Account"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.Panel.My.Resources.Resources.shutdown_bg
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 532)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 86)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Panel.My.Resources.Resources.shutdown_normal
        Me.PictureBox2.Location = New System.Drawing.Point(156, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 618)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "start"
        Me.Text = "start"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents username_lb As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents slide As System.Windows.Forms.Timer
End Class
