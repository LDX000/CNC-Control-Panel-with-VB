<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gui))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CommandManual = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ManualControl = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioInch = New System.Windows.Forms.RadioButton()
        Me.Radiomm = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.SpindleOff = New System.Windows.Forms.Button()
        Me.SpindleOn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Feed50 = New System.Windows.Forms.RadioButton()
        Me.Feed100 = New System.Windows.Forms.RadioButton()
        Me.Feed500 = New System.Windows.Forms.RadioButton()
        Me.Feed1000 = New System.Windows.Forms.RadioButton()
        Me.grDistance = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SetHome = New System.Windows.Forms.Button()
        Me.Button4Zdown = New System.Windows.Forms.Button()
        Me.ButtonZup = New System.Windows.Forms.Button()
        Me.ButtonXright = New System.Windows.Forms.Button()
        Me.ButtonXleft = New System.Windows.Forms.Button()
        Me.ButtonYrev = New System.Windows.Forms.Button()
        Me.ButtonYforw = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBoxCOM = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBaud = New System.Windows.Forms.ComboBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.CommandManual.SuspendLayout()
        Me.ManualControl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grDistance.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CommandManual)
        Me.TabControl1.Controls.Add(Me.ManualControl)
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(360, 324)
        Me.TabControl1.TabIndex = 0
        '
        'CommandManual
        '
        Me.CommandManual.Controls.Add(Me.RichTextBox1)
        Me.CommandManual.Controls.Add(Me.Label5)
        Me.CommandManual.Controls.Add(Me.ButtonStop)
        Me.CommandManual.Controls.Add(Me.ButtonStart)
        Me.CommandManual.Controls.Add(Me.Label3)
        Me.CommandManual.Controls.Add(Me.TextBox2)
        Me.CommandManual.Controls.Add(Me.Button3)
        Me.CommandManual.Location = New System.Drawing.Point(4, 22)
        Me.CommandManual.Name = "CommandManual"
        Me.CommandManual.Padding = New System.Windows.Forms.Padding(3)
        Me.CommandManual.Size = New System.Drawing.Size(352, 298)
        Me.CommandManual.TabIndex = 0
        Me.CommandManual.Text = "Command"
        Me.CommandManual.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 75)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox1.Size = New System.Drawing.Size(340, 217)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "File Reading Content"
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(251, 10)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(82, 23)
        Me.ButtonStop.TabIndex = 15
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(163, 10)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(82, 23)
        Me.ButtonStart.TabIndex = 13
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Command"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 36)
        Me.TextBox2.MaximumSize = New System.Drawing.Size(330, 20)
        Me.TextBox2.MinimumSize = New System.Drawing.Size(330, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(330, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Send "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ManualControl
        '
        Me.ManualControl.Controls.Add(Me.Button5)
        Me.ManualControl.Controls.Add(Me.Button2)
        Me.ManualControl.Controls.Add(Me.GroupBox3)
        Me.ManualControl.Controls.Add(Me.GroupBox2)
        Me.ManualControl.Controls.Add(Me.GroupBox1)
        Me.ManualControl.Controls.Add(Me.grDistance)
        Me.ManualControl.Controls.Add(Me.SetHome)
        Me.ManualControl.Controls.Add(Me.Button4Zdown)
        Me.ManualControl.Controls.Add(Me.ButtonZup)
        Me.ManualControl.Controls.Add(Me.ButtonXright)
        Me.ManualControl.Controls.Add(Me.ButtonXleft)
        Me.ManualControl.Controls.Add(Me.ButtonYrev)
        Me.ManualControl.Controls.Add(Me.ButtonYforw)
        Me.ManualControl.Controls.Add(Me.ButtonHome)
        Me.ManualControl.Location = New System.Drawing.Point(4, 22)
        Me.ManualControl.Name = "ManualControl"
        Me.ManualControl.Padding = New System.Windows.Forms.Padding(3)
        Me.ManualControl.Size = New System.Drawing.Size(352, 298)
        Me.ManualControl.TabIndex = 1
        Me.ManualControl.Text = "Manual Control"
        Me.ManualControl.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(204, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Relative"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Absolute"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioInch)
        Me.GroupBox3.Controls.Add(Me.Radiomm)
        Me.GroupBox3.Location = New System.Drawing.Point(117, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(63, 103)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Scaling"
        '
        'RadioInch
        '
        Me.RadioInch.AutoSize = True
        Me.RadioInch.Location = New System.Drawing.Point(4, 74)
        Me.RadioInch.Name = "RadioInch"
        Me.RadioInch.Size = New System.Drawing.Size(46, 17)
        Me.RadioInch.TabIndex = 1
        Me.RadioInch.TabStop = True
        Me.RadioInch.Text = "Inch"
        Me.RadioInch.UseVisualStyleBackColor = True
        '
        'Radiomm
        '
        Me.Radiomm.AutoSize = True
        Me.Radiomm.Location = New System.Drawing.Point(4, 34)
        Me.Radiomm.Name = "Radiomm"
        Me.Radiomm.Size = New System.Drawing.Size(41, 17)
        Me.Radiomm.TabIndex = 0
        Me.Radiomm.TabStop = True
        Me.Radiomm.Text = "mm"
        Me.Radiomm.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.SpindleOff)
        Me.GroupBox2.Controls.Add(Me.SpindleOn)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 102)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Spindle Control"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 19)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(166, 45)
        Me.TrackBar1.TabIndex = 15
        '
        'SpindleOff
        '
        Me.SpindleOff.Location = New System.Drawing.Point(59, 75)
        Me.SpindleOff.Name = "SpindleOff"
        Me.SpindleOff.Size = New System.Drawing.Size(47, 22)
        Me.SpindleOff.TabIndex = 1
        Me.SpindleOff.Text = "Off"
        Me.SpindleOff.UseVisualStyleBackColor = True
        '
        'SpindleOn
        '
        Me.SpindleOn.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.SpindleOn.Location = New System.Drawing.Point(6, 74)
        Me.SpindleOn.Name = "SpindleOn"
        Me.SpindleOn.Size = New System.Drawing.Size(47, 22)
        Me.SpindleOn.TabIndex = 0
        Me.SpindleOn.Text = "On"
        Me.SpindleOn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Feed50)
        Me.GroupBox1.Controls.Add(Me.Feed100)
        Me.GroupBox1.Controls.Add(Me.Feed500)
        Me.GroupBox1.Controls.Add(Me.Feed1000)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 112)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Feed Rate"
        '
        'Feed50
        '
        Me.Feed50.AutoSize = True
        Me.Feed50.Location = New System.Drawing.Point(6, 89)
        Me.Feed50.Name = "Feed50"
        Me.Feed50.Size = New System.Drawing.Size(37, 17)
        Me.Feed50.TabIndex = 3
        Me.Feed50.TabStop = True
        Me.Feed50.Text = "50"
        Me.Feed50.UseVisualStyleBackColor = True
        '
        'Feed100
        '
        Me.Feed100.AutoSize = True
        Me.Feed100.Location = New System.Drawing.Point(7, 66)
        Me.Feed100.Name = "Feed100"
        Me.Feed100.Size = New System.Drawing.Size(43, 17)
        Me.Feed100.TabIndex = 2
        Me.Feed100.TabStop = True
        Me.Feed100.Text = "100"
        Me.Feed100.UseVisualStyleBackColor = True
        '
        'Feed500
        '
        Me.Feed500.AutoSize = True
        Me.Feed500.Location = New System.Drawing.Point(7, 43)
        Me.Feed500.Name = "Feed500"
        Me.Feed500.Size = New System.Drawing.Size(43, 17)
        Me.Feed500.TabIndex = 1
        Me.Feed500.TabStop = True
        Me.Feed500.Text = "500"
        Me.Feed500.UseVisualStyleBackColor = True
        '
        'Feed1000
        '
        Me.Feed1000.AutoSize = True
        Me.Feed1000.Location = New System.Drawing.Point(7, 20)
        Me.Feed1000.Name = "Feed1000"
        Me.Feed1000.Size = New System.Drawing.Size(49, 17)
        Me.Feed1000.TabIndex = 0
        Me.Feed1000.TabStop = True
        Me.Feed1000.Text = "1000"
        Me.Feed1000.UseVisualStyleBackColor = True
        '
        'grDistance
        '
        Me.grDistance.Controls.Add(Me.RadioButton4)
        Me.grDistance.Controls.Add(Me.RadioButton3)
        Me.grDistance.Controls.Add(Me.RadioButton2)
        Me.grDistance.Controls.Add(Me.RadioButton1)
        Me.grDistance.Location = New System.Drawing.Point(6, 64)
        Me.grDistance.Name = "grDistance"
        Me.grDistance.Size = New System.Drawing.Size(108, 112)
        Me.grDistance.TabIndex = 9
        Me.grDistance.TabStop = False
        Me.grDistance.Text = "Distance"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 89)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "0.01"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "0.1"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "10"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SetHome
        '
        Me.SetHome.Location = New System.Drawing.Point(6, 35)
        Me.SetHome.Name = "SetHome"
        Me.SetHome.Size = New System.Drawing.Size(75, 23)
        Me.SetHome.TabIndex = 8
        Me.SetHome.Text = "Set Zero"
        Me.SetHome.UseVisualStyleBackColor = True
        '
        'Button4Zdown
        '
        Me.Button4Zdown.Location = New System.Drawing.Point(275, 17)
        Me.Button4Zdown.Name = "Button4Zdown"
        Me.Button4Zdown.Size = New System.Drawing.Size(40, 40)
        Me.Button4Zdown.TabIndex = 7
        Me.Button4Zdown.Text = "Z-"
        Me.Button4Zdown.UseVisualStyleBackColor = True
        '
        'ButtonZup
        '
        Me.ButtonZup.Location = New System.Drawing.Point(275, 107)
        Me.ButtonZup.Name = "ButtonZup"
        Me.ButtonZup.Size = New System.Drawing.Size(40, 40)
        Me.ButtonZup.TabIndex = 6
        Me.ButtonZup.Text = "Z+"
        Me.ButtonZup.UseVisualStyleBackColor = True
        '
        'ButtonXright
        '
        Me.ButtonXright.Location = New System.Drawing.Point(232, 61)
        Me.ButtonXright.Name = "ButtonXright"
        Me.ButtonXright.Size = New System.Drawing.Size(40, 40)
        Me.ButtonXright.TabIndex = 5
        Me.ButtonXright.Text = "X+"
        Me.ButtonXright.UseVisualStyleBackColor = True
        '
        'ButtonXleft
        '
        Me.ButtonXleft.Location = New System.Drawing.Point(140, 61)
        Me.ButtonXleft.Name = "ButtonXleft"
        Me.ButtonXleft.Size = New System.Drawing.Size(40, 40)
        Me.ButtonXleft.TabIndex = 3
        Me.ButtonXleft.Text = "X-"
        Me.ButtonXleft.UseVisualStyleBackColor = True
        '
        'ButtonYrev
        '
        Me.ButtonYrev.Location = New System.Drawing.Point(186, 107)
        Me.ButtonYrev.Name = "ButtonYrev"
        Me.ButtonYrev.Size = New System.Drawing.Size(40, 40)
        Me.ButtonYrev.TabIndex = 2
        Me.ButtonYrev.Text = "Y-"
        Me.ButtonYrev.UseVisualStyleBackColor = True
        '
        'ButtonYforw
        '
        Me.ButtonYforw.Location = New System.Drawing.Point(186, 17)
        Me.ButtonYforw.Name = "ButtonYforw"
        Me.ButtonYforw.Size = New System.Drawing.Size(40, 40)
        Me.ButtonYforw.TabIndex = 1
        Me.ButtonYforw.Text = "Y+"
        Me.ButtonYforw.UseVisualStyleBackColor = True
        '
        'ButtonHome
        '
        Me.ButtonHome.Location = New System.Drawing.Point(6, 6)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHome.TabIndex = 0
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.DiscardNull = True
        Me.SerialPort1.DtrEnable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baud"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(13, 31)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(188, 21)
        Me.ButtonConnect.TabIndex = 6
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(207, 31)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(161, 21)
        Me.ButtonDisconnect.TabIndex = 9
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Open File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 389)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(266, 20)
        Me.TextBox3.TabIndex = 13
        '
        'ComboBoxCOM
        '
        Me.ComboBoxCOM.FormattingEnabled = True
        Me.ComboBoxCOM.Location = New System.Drawing.Point(74, 7)
        Me.ComboBoxCOM.Name = "ComboBoxCOM"
        Me.ComboBoxCOM.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxCOM.TabIndex = 14
        '
        'ComboBoxBaud
        '
        Me.ComboBoxBaud.FormattingEnabled = True
        Me.ComboBoxBaud.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaud.Location = New System.Drawing.Point(248, 7)
        Me.ComboBoxBaud.Name = "ComboBoxBaud"
        Me.ComboBoxBaud.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxBaud.TabIndex = 15
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Gcode Panel is Running"
        Me.NotifyIcon1.Visible = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(297, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 22)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "About"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Build Version 1.0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Com Ports"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "   "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(12, 426)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Gui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBoxBaud)
        Me.Controls.Add(Me.ComboBoxCOM)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDisconnect)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(400, 500)
        Me.MinimumSize = New System.Drawing.Size(400, 500)
        Me.Name = "Gui"
        Me.Text = "Gcode Sender"
        Me.TabControl1.ResumeLayout(False)
        Me.CommandManual.ResumeLayout(False)
        Me.CommandManual.PerformLayout()
        Me.ManualControl.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grDistance.ResumeLayout(False)
        Me.grDistance.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CommandManual As System.Windows.Forms.TabPage
    Friend WithEvents ManualControl As System.Windows.Forms.TabPage
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonConnect As System.Windows.Forms.Button
    Friend WithEvents ButtonDisconnect As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxCOM As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBaud As System.Windows.Forms.ComboBox
    Friend WithEvents Button4Zdown As System.Windows.Forms.Button
    Friend WithEvents ButtonZup As System.Windows.Forms.Button
    Friend WithEvents ButtonXright As System.Windows.Forms.Button
    Friend WithEvents ButtonXleft As System.Windows.Forms.Button
    Friend WithEvents ButtonYrev As System.Windows.Forms.Button
    Friend WithEvents ButtonYforw As System.Windows.Forms.Button
    Friend WithEvents ButtonHome As System.Windows.Forms.Button
    Friend WithEvents SetHome As System.Windows.Forms.Button
    Friend WithEvents grDistance As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Feed50 As System.Windows.Forms.RadioButton
    Friend WithEvents Feed100 As System.Windows.Forms.RadioButton
    Friend WithEvents Feed500 As System.Windows.Forms.RadioButton
    Friend WithEvents Feed1000 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SpindleOff As System.Windows.Forms.Button
    Friend WithEvents SpindleOn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioInch As System.Windows.Forms.RadioButton
    Friend WithEvents Radiomm As System.Windows.Forms.RadioButton
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
