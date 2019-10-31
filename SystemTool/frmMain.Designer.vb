<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.OneClick = New System.Windows.Forms.CheckBox()
        Me.AlertViewer = New System.Windows.Forms.Label()
        Me.sysTOff = New System.Windows.Forms.PictureBox()
        Me.sysRStart = New System.Windows.Forms.PictureBox()
        Me.sysHibernate = New System.Windows.Forms.PictureBox()
        Me.sysSchedule = New System.Windows.Forms.PictureBox()
        Me.sysSleep = New System.Windows.Forms.PictureBox()
        Me.sysLOff = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ActSchedule = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTips = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AboutSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.sysTOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sysRStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sysHibernate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sysSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sysSleep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sysLOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OneClick
        '
        Me.OneClick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OneClick.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneClick.ForeColor = System.Drawing.Color.DimGray
        Me.OneClick.Location = New System.Drawing.Point(391, 159)
        Me.OneClick.Name = "OneClick"
        Me.OneClick.Size = New System.Drawing.Size(112, 15)
        Me.OneClick.TabIndex = 8
        Me.OneClick.TabStop = False
        Me.OneClick.Text = "One Click Disabled"
        Me.OneClick.UseCompatibleTextRendering = True
        Me.OneClick.UseVisualStyleBackColor = True
        '
        'AlertViewer
        '
        Me.AlertViewer.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertViewer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.AlertViewer.Location = New System.Drawing.Point(1, 96)
        Me.AlertViewer.Name = "AlertViewer"
        Me.AlertViewer.Size = New System.Drawing.Size(497, 20)
        Me.AlertViewer.TabIndex = 9
        Me.AlertViewer.Text = "Alerts Viewer"
        Me.AlertViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AlertViewer.Visible = False
        '
        'sysTOff
        '
        Me.sysTOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysTOff.Image = CType(resources.GetObject("sysTOff.Image"), System.Drawing.Image)
        Me.sysTOff.Location = New System.Drawing.Point(87, 34)
        Me.sysTOff.Name = "sysTOff"
        Me.sysTOff.Size = New System.Drawing.Size(48, 48)
        Me.sysTOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysTOff.TabIndex = 0
        Me.sysTOff.TabStop = False
        '
        'sysRStart
        '
        Me.sysRStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysRStart.Image = CType(resources.GetObject("sysRStart.Image"), System.Drawing.Image)
        Me.sysRStart.Location = New System.Drawing.Point(141, 34)
        Me.sysRStart.Name = "sysRStart"
        Me.sysRStart.Size = New System.Drawing.Size(48, 48)
        Me.sysRStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysRStart.TabIndex = 1
        Me.sysRStart.TabStop = False
        '
        'sysHibernate
        '
        Me.sysHibernate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysHibernate.Image = CType(resources.GetObject("sysHibernate.Image"), System.Drawing.Image)
        Me.sysHibernate.Location = New System.Drawing.Point(303, 34)
        Me.sysHibernate.Name = "sysHibernate"
        Me.sysHibernate.Size = New System.Drawing.Size(48, 48)
        Me.sysHibernate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysHibernate.TabIndex = 3
        Me.sysHibernate.TabStop = False
        '
        'sysSchedule
        '
        Me.sysSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysSchedule.Image = CType(resources.GetObject("sysSchedule.Image"), System.Drawing.Image)
        Me.sysSchedule.Location = New System.Drawing.Point(357, 34)
        Me.sysSchedule.Name = "sysSchedule"
        Me.sysSchedule.Size = New System.Drawing.Size(48, 48)
        Me.sysSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysSchedule.TabIndex = 4
        Me.sysSchedule.TabStop = False
        '
        'sysSleep
        '
        Me.sysSleep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysSleep.Image = CType(resources.GetObject("sysSleep.Image"), System.Drawing.Image)
        Me.sysSleep.Location = New System.Drawing.Point(195, 34)
        Me.sysSleep.Name = "sysSleep"
        Me.sysSleep.Size = New System.Drawing.Size(48, 48)
        Me.sysSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysSleep.TabIndex = 6
        Me.sysSleep.TabStop = False
        '
        'sysLOff
        '
        Me.sysLOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sysLOff.Image = CType(resources.GetObject("sysLOff.Image"), System.Drawing.Image)
        Me.sysLOff.Location = New System.Drawing.Point(249, 34)
        Me.sysLOff.Name = "sysLOff"
        Me.sysLOff.Size = New System.Drawing.Size(48, 48)
        Me.sysLOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sysLOff.TabIndex = 7
        Me.sysLOff.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ActSchedule)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(54, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 145)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("HP Simplified", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(147, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Olive
        Me.Label2.Location = New System.Drawing.Point(147, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "seconds"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(139, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "00 Minutes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(156, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 25)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 25)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Reschedule"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "System will be shutdown in"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("HP Simplified", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(362, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "X"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("HP Simplified", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(73, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Minimize"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'ActSchedule
        '
        Me.ActSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActSchedule.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActSchedule.ForeColor = System.Drawing.Color.SteelBlue
        Me.ActSchedule.Location = New System.Drawing.Point(247, 17)
        Me.ActSchedule.Name = "ActSchedule"
        Me.ActSchedule.Size = New System.Drawing.Size(106, 34)
        Me.ActSchedule.TabIndex = 3
        Me.ActSchedule.Text = "Schedule"
        Me.ActSchedule.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("HP Simplified", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Teal
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox1.Items.AddRange(New Object() {"5 Min.(300 Sec.)", "10 Min.(600 Sec.)", "30 Min.(1800 Sec.)", "1 Hour(3600 Sec.)", "2 Hours(7200 Sec.)", "3 Hours(10800 Sec.)", "5 Hours(18000 Sec.)"})
        Me.ComboBox1.Location = New System.Drawing.Point(28, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 31)
        Me.ComboBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(26, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Select time below to schedule shutdown"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Countdown
        '
        Me.Countdown.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "System Utility Minimized" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here to more about developer and support option"
        Me.NotifyIcon1.BalloonTipTitle = "System Utility"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "System Utility"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizeToolStripMenuItem, Me.SupportToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(155, 70)
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SupportToolStripMenuItem.Text = "About/Support"
        Me.SupportToolStripMenuItem.ToolTipText = "Find help and support here"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'BtnTips
        '
        Me.BtnTips.Font = New System.Drawing.Font("HP Simplified", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTips.ForeColor = System.Drawing.Color.White
        Me.BtnTips.Location = New System.Drawing.Point(1, 9)
        Me.BtnTips.Name = "BtnTips"
        Me.BtnTips.Size = New System.Drawing.Size(497, 20)
        Me.BtnTips.TabIndex = 11
        Me.BtnTips.Text = "Alerts Viewer"
        Me.BtnTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnTips.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-1, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(384, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "All operation will be exectuted in single click, save your unsaved data"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'AboutSupportToolStripMenuItem
        '
        Me.AboutSupportToolStripMenuItem.Name = "AboutSupportToolStripMenuItem"
        Me.AboutSupportToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutSupportToolStripMenuItem.Text = "About/Support"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(500, 173)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AlertViewer)
        Me.Controls.Add(Me.OneClick)
        Me.Controls.Add(Me.sysLOff)
        Me.Controls.Add(Me.sysSleep)
        Me.Controls.Add(Me.sysSchedule)
        Me.Controls.Add(Me.sysHibernate)
        Me.Controls.Add(Me.sysRStart)
        Me.Controls.Add(Me.sysTOff)
        Me.Controls.Add(Me.BtnTips)
        Me.Controls.Add(Me.Label7)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Utility"
        Me.TopMost = True
        CType(Me.sysTOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sysRStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sysHibernate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sysSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sysSleep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sysLOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OneClick As System.Windows.Forms.CheckBox
    Friend WithEvents AlertViewer As System.Windows.Forms.Label
    Friend WithEvents sysTOff As System.Windows.Forms.PictureBox
    Friend WithEvents sysRStart As System.Windows.Forms.PictureBox
    Friend WithEvents sysHibernate As System.Windows.Forms.PictureBox
    Friend WithEvents sysSchedule As System.Windows.Forms.PictureBox
    Friend WithEvents sysSleep As System.Windows.Forms.PictureBox
    Friend WithEvents sysLOff As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Countdown As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ActSchedule As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MaximizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnTips As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSupportToolStripMenuItem As ToolStripMenuItem
End Class
