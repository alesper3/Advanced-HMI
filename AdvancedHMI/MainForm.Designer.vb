<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.AnalogValueDisplay2 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay3 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay4 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay5 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay6 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay7 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.ChartBySampling1 = New AdvancedHMIControls.ChartBySampling()
        Me.Emailer1 = New AdvancedHMIControls.Emailer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emailer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1023, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 32)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "10.16.188.97"
        Me.EthernetIPforCLXCom1.PollRateOverride = 100
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'AnalogValueDisplay2
        '
        Me.AnalogValueDisplay2.AutoSize = True
        Me.AnalogValueDisplay2.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay2.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay2.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay2.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay2.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay2.KeypadMaxValue = 0R
        Me.AnalogValueDisplay2.KeypadMinValue = 0R
        Me.AnalogValueDisplay2.KeypadPasscode = Nothing
        Me.AnalogValueDisplay2.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay2.KeypadText = Nothing
        Me.AnalogValueDisplay2.KeypadWidth = 300
        Me.AnalogValueDisplay2.Location = New System.Drawing.Point(529, 114)
        Me.AnalogValueDisplay2.Name = "AnalogValueDisplay2"
        Me.AnalogValueDisplay2.NumericFormat = Nothing
        Me.AnalogValueDisplay2.PLCAddressKeypad = ""
        Me.AnalogValueDisplay2.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay2.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay2.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay2.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay2.ShowValue = True
        Me.AnalogValueDisplay2.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay2.TabIndex = 58
        Me.AnalogValueDisplay2.Text = "0000"
        Me.AnalogValueDisplay2.Value = "0000"
        Me.AnalogValueDisplay2.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay2.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay2.ValuePrefix = Nothing
        Me.AnalogValueDisplay2.ValueSuffix = Nothing
        Me.AnalogValueDisplay2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay1
        '
        Me.AnalogValueDisplay1.AutoSize = True
        Me.AnalogValueDisplay1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay1.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay1.KeypadMaxValue = 0R
        Me.AnalogValueDisplay1.KeypadMinValue = 0R
        Me.AnalogValueDisplay1.KeypadPasscode = Nothing
        Me.AnalogValueDisplay1.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay1.KeypadText = Nothing
        Me.AnalogValueDisplay1.KeypadWidth = 300
        Me.AnalogValueDisplay1.Location = New System.Drawing.Point(21, 34)
        Me.AnalogValueDisplay1.Name = "AnalogValueDisplay1"
        Me.AnalogValueDisplay1.NumericFormat = Nothing
        Me.AnalogValueDisplay1.PLCAddressKeypad = ""
        Me.AnalogValueDisplay1.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay1.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay1.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay1.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay1.ShowValue = True
        Me.AnalogValueDisplay1.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay1.TabIndex = 59
        Me.AnalogValueDisplay1.Text = "0000"
        Me.AnalogValueDisplay1.Value = "0000"
        Me.AnalogValueDisplay1.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay1.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay1.ValuePrefix = Nothing
        Me.AnalogValueDisplay1.ValueSuffix = Nothing
        Me.AnalogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay3
        '
        Me.AnalogValueDisplay3.AutoSize = True
        Me.AnalogValueDisplay3.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay3.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay3.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay3.KeypadMaxValue = 0R
        Me.AnalogValueDisplay3.KeypadMinValue = 0R
        Me.AnalogValueDisplay3.KeypadPasscode = Nothing
        Me.AnalogValueDisplay3.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay3.KeypadText = Nothing
        Me.AnalogValueDisplay3.KeypadWidth = 300
        Me.AnalogValueDisplay3.Location = New System.Drawing.Point(21, 61)
        Me.AnalogValueDisplay3.MaximumSize = New System.Drawing.Size(400, 400)
        Me.AnalogValueDisplay3.Name = "AnalogValueDisplay3"
        Me.AnalogValueDisplay3.NumericFormat = Nothing
        Me.AnalogValueDisplay3.PLCAddressKeypad = ""
        Me.AnalogValueDisplay3.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay3.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay3.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay3.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay3.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay3.ShowValue = True
        Me.AnalogValueDisplay3.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay3.TabIndex = 60
        Me.AnalogValueDisplay3.Text = "0000"
        Me.AnalogValueDisplay3.Value = "0000"
        Me.AnalogValueDisplay3.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay3.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay3.ValuePrefix = Nothing
        Me.AnalogValueDisplay3.ValueSuffix = Nothing
        Me.AnalogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay4
        '
        Me.AnalogValueDisplay4.AutoSize = True
        Me.AnalogValueDisplay4.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay4.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay4.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay4.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay4.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay4.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AnalogValueDisplay4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay4.KeypadMaxValue = 0R
        Me.AnalogValueDisplay4.KeypadMinValue = 0R
        Me.AnalogValueDisplay4.KeypadPasscode = Nothing
        Me.AnalogValueDisplay4.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay4.KeypadText = Nothing
        Me.AnalogValueDisplay4.KeypadWidth = 300
        Me.AnalogValueDisplay4.Location = New System.Drawing.Point(21, 88)
        Me.AnalogValueDisplay4.Name = "AnalogValueDisplay4"
        Me.AnalogValueDisplay4.NumericFormat = Nothing
        Me.AnalogValueDisplay4.PLCAddressKeypad = ""
        Me.AnalogValueDisplay4.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay4.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay4.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay4.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay4.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay4.ShowValue = True
        Me.AnalogValueDisplay4.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay4.TabIndex = 61
        Me.AnalogValueDisplay4.Text = "0000"
        Me.AnalogValueDisplay4.Value = "0000"
        Me.AnalogValueDisplay4.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay4.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay4.ValuePrefix = Nothing
        Me.AnalogValueDisplay4.ValueSuffix = Nothing
        Me.AnalogValueDisplay4.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay5
        '
        Me.AnalogValueDisplay5.AutoSize = True
        Me.AnalogValueDisplay5.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay5.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay5.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay5.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay5.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay5.KeypadMaxValue = 0R
        Me.AnalogValueDisplay5.KeypadMinValue = 0R
        Me.AnalogValueDisplay5.KeypadPasscode = Nothing
        Me.AnalogValueDisplay5.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay5.KeypadText = Nothing
        Me.AnalogValueDisplay5.KeypadWidth = 300
        Me.AnalogValueDisplay5.Location = New System.Drawing.Point(104, 34)
        Me.AnalogValueDisplay5.Name = "AnalogValueDisplay5"
        Me.AnalogValueDisplay5.NumericFormat = Nothing
        Me.AnalogValueDisplay5.PLCAddressKeypad = ""
        Me.AnalogValueDisplay5.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay5.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay5.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay5.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay5.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay5.ShowValue = True
        Me.AnalogValueDisplay5.Size = New System.Drawing.Size(246, 27)
        Me.AnalogValueDisplay5.TabIndex = 62
        Me.AnalogValueDisplay5.Text = "Low Alarm  0000  Low"
        Me.AnalogValueDisplay5.Value = "0000"
        Me.AnalogValueDisplay5.ValueLimitLower = 6.0R
        Me.AnalogValueDisplay5.ValueLimitUpper = 7.0R
        Me.AnalogValueDisplay5.ValuePrefix = "Low Alarm  "
        Me.AnalogValueDisplay5.ValueSuffix = "  Low"
        Me.AnalogValueDisplay5.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.BelowLimit
        '
        'AnalogValueDisplay6
        '
        Me.AnalogValueDisplay6.AutoSize = True
        Me.AnalogValueDisplay6.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay6.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay6.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay6.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay6.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay6.KeypadMaxValue = 0R
        Me.AnalogValueDisplay6.KeypadMinValue = 0R
        Me.AnalogValueDisplay6.KeypadPasscode = Nothing
        Me.AnalogValueDisplay6.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay6.KeypadText = Nothing
        Me.AnalogValueDisplay6.KeypadWidth = 300
        Me.AnalogValueDisplay6.Location = New System.Drawing.Point(104, 61)
        Me.AnalogValueDisplay6.MaximumSize = New System.Drawing.Size(400, 400)
        Me.AnalogValueDisplay6.Name = "AnalogValueDisplay6"
        Me.AnalogValueDisplay6.NumericFormat = Nothing
        Me.AnalogValueDisplay6.PLCAddressKeypad = ""
        Me.AnalogValueDisplay6.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay6.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay6.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay6.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay6.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay6.ShowValue = True
        Me.AnalogValueDisplay6.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay6.TabIndex = 63
        Me.AnalogValueDisplay6.Text = "0000"
        Me.AnalogValueDisplay6.Value = "0000"
        Me.AnalogValueDisplay6.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay6.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay6.ValuePrefix = Nothing
        Me.AnalogValueDisplay6.ValueSuffix = Nothing
        Me.AnalogValueDisplay6.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay7
        '
        Me.AnalogValueDisplay7.AutoSize = True
        Me.AnalogValueDisplay7.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay7.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay7.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay7.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay7.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay7.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AnalogValueDisplay7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay7.KeypadMaxValue = 0R
        Me.AnalogValueDisplay7.KeypadMinValue = 0R
        Me.AnalogValueDisplay7.KeypadPasscode = Nothing
        Me.AnalogValueDisplay7.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay7.KeypadText = Nothing
        Me.AnalogValueDisplay7.KeypadWidth = 300
        Me.AnalogValueDisplay7.Location = New System.Drawing.Point(104, 88)
        Me.AnalogValueDisplay7.Name = "AnalogValueDisplay7"
        Me.AnalogValueDisplay7.NumericFormat = Nothing
        Me.AnalogValueDisplay7.PLCAddressKeypad = ""
        Me.AnalogValueDisplay7.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay7.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay7.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay7.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay7.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay7.ShowValue = True
        Me.AnalogValueDisplay7.Size = New System.Drawing.Size(64, 27)
        Me.AnalogValueDisplay7.TabIndex = 64
        Me.AnalogValueDisplay7.Text = "0000"
        Me.AnalogValueDisplay7.Value = "0000"
        Me.AnalogValueDisplay7.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay7.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay7.ValuePrefix = Nothing
        Me.AnalogValueDisplay7.ValueSuffix = Nothing
        Me.AnalogValueDisplay7.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'ChartBySampling1
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartBySampling1.ChartAreas.Add(ChartArea1)
        Me.ChartBySampling1.ComComponent = Me.EthernetIPforCLXCom1
        Legend1.Name = "Legend1"
        Me.ChartBySampling1.Legends.Add(Legend1)
        Me.ChartBySampling1.Location = New System.Drawing.Point(87, 195)
        Me.ChartBySampling1.MaximumActivePoints = 1000
        Me.ChartBySampling1.Name = "ChartBySampling1"
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressYAxisMax = Nothing
        Me.ChartBySampling1.PLCAddressYAxisMin = Nothing
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.ChartBySampling1.Series.Add(Series1)
        Me.ChartBySampling1.Size = New System.Drawing.Size(608, 300)
        Me.ChartBySampling1.TabIndex = 65
        Me.ChartBySampling1.Text = "ChartBySampling1"
        Me.ChartBySampling1.YAxisMax = Double.NaN
        Me.ChartBySampling1.YAxisMin = Double.NaN
        '
        'Emailer1
        '
        Me.Emailer1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Emailer1.ErrorMessageDisplayLabel = Nothing
        Me.Emailer1.MessageBody = ""
        Me.Emailer1.MessageFrom = ""
        Me.Emailer1.MessageSubject = "Email from AdvancedHMI Emailer"
        Me.Emailer1.MessageTo = "2628752191@txt.att.net"
        Me.Emailer1.PLCAddressValue = CType(resources.GetObject("Emailer1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Emailer1.ServerPresets = MfgControl.AdvancedHMI.Controls.EmailerEx.ServerPresetsEnum.SelectOne
        Me.Emailer1.SmtpLoginPassword = "Gogogogo1_"
        Me.Emailer1.SmtpLoginUserName = "allen.esper@harley-davidson.com"
        Me.Emailer1.SmtpPort = 25
        Me.Emailer1.SmtpServer = Nothing
        Me.Emailer1.TargetValue = "5"
        Me.Emailer1.TriggerType = MfgControl.AdvancedHMI.Controls.EmailerEx.TriggerTypeEnum.AboveTargetValue
        Me.Emailer1.UseSsl = False
        Me.Emailer1.Value = ""
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1145, 561)
        Me.Controls.Add(Me.ChartBySampling1)
        Me.Controls.Add(Me.AnalogValueDisplay7)
        Me.Controls.Add(Me.AnalogValueDisplay6)
        Me.Controls.Add(Me.AnalogValueDisplay5)
        Me.Controls.Add(Me.AnalogValueDisplay4)
        Me.Controls.Add(Me.AnalogValueDisplay3)
        Me.Controls.Add(Me.AnalogValueDisplay1)
        Me.Controls.Add(Me.AnalogValueDisplay2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emailer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents AnalogValueDisplay2 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay3 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay4 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay5 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay6 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay7 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents ChartBySampling1 As AdvancedHMIControls.ChartBySampling
    Friend WithEvents Emailer1 As AdvancedHMIControls.Emailer
End Class
