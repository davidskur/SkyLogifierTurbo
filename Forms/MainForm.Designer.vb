<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.stsTimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsCurrentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.MessageViewer = New System.Windows.Forms.Label()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tpCurrentUser = New System.Windows.Forms.TabPage()
        Me.tlpUserLog = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbDateRanges = New System.Windows.Forms.ComboBox()
        Me.lblDateRange = New System.Windows.Forms.Label()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.lbRecords = New System.Windows.Forms.ListBox()
        Me.tpBirds = New System.Windows.Forms.TabPage()
        Me.pnlBirdTab = New System.Windows.Forms.Panel()
        Me.gbBirdHelp = New System.Windows.Forms.GroupBox()
        Me.btnGetRecentSightings = New System.Windows.Forms.Button()
        Me.btnBirdFieldGuide = New System.Windows.Forms.Button()
        Me.gbBirdData = New System.Windows.Forms.GroupBox()
        Me.cbSpecies = New System.Windows.Forms.ComboBox()
        Me.tbBirdNotes = New System.Windows.Forms.TextBox()
        Me.lblBirdNotes = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.btnRecordBird = New System.Windows.Forms.Button()
        Me.tpPlanes = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLivePlanes = New System.Windows.Forms.Button()
        Me.btnPlaneRef = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbPlaneNotes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlaneModel = New System.Windows.Forms.Label()
        Me.btnRecordPlane = New System.Windows.Forms.Button()
        Me.tpSpace = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSpaceOverhead = New System.Windows.Forms.Button()
        Me.btnSpaceRef = New System.Windows.Forms.Button()
        Me.rbNaturalObject = New System.Windows.Forms.RadioButton()
        Me.rbManMade = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbSpaceNotes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSpaceObjectName = New System.Windows.Forms.TextBox()
        Me.lblSpaceObjectName = New System.Windows.Forms.Label()
        Me.btnRecordSpaceObject = New System.Windows.Forms.Button()
        Me.cbPlaneModel = New System.Windows.Forms.ComboBox()
        Me.btnGetIssPos = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        Me.stsMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tbcMain.SuspendLayout()
        Me.tpCurrentUser.SuspendLayout()
        Me.tlpUserLog.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tpBirds.SuspendLayout()
        Me.pnlBirdTab.SuspendLayout()
        Me.gbBirdHelp.SuspendLayout()
        Me.gbBirdData.SuspendLayout()
        Me.tpPlanes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpSpace.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.miHelp})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.msMain.Size = New System.Drawing.Size(690, 31)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miLogin, Me.miExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'miLogin
        '
        Me.miLogin.Name = "miLogin"
        Me.miLogin.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.miLogin.Size = New System.Drawing.Size(173, 26)
        Me.miLogin.Text = "&Login"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.miExit.Size = New System.Drawing.Size(173, 26)
        Me.miExit.Text = "E&xit"
        '
        'miHelp
        '
        Me.miHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAbout})
        Me.miHelp.Name = "miHelp"
        Me.miHelp.Size = New System.Drawing.Size(54, 25)
        Me.miHelp.Text = "&Help"
        '
        'miAbout
        '
        Me.miAbout.Name = "miAbout"
        Me.miAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.miAbout.Size = New System.Drawing.Size(210, 26)
        Me.miAbout.Text = "&About App"
        '
        'stsMain
        '
        Me.stsMain.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsTimeLabel, Me.stsTime, Me.stsConnectionStatus, Me.stsCurrentUser})
        Me.stsMain.Location = New System.Drawing.Point(0, 641)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.stsMain.Size = New System.Drawing.Size(690, 25)
        Me.stsMain.TabIndex = 1
        Me.stsMain.Text = "StatusStrip1"
        '
        'stsTimeLabel
        '
        Me.stsTimeLabel.Name = "stsTimeLabel"
        Me.stsTimeLabel.Size = New System.Drawing.Size(107, 20)
        Me.stsTimeLabel.Text = "~Current Time:"
        '
        'stsTime
        '
        Me.stsTime.Name = "stsTime"
        Me.stsTime.Size = New System.Drawing.Size(0, 20)
        '
        'stsConnectionStatus
        '
        Me.stsConnectionStatus.Name = "stsConnectionStatus"
        Me.stsConnectionStatus.Size = New System.Drawing.Size(0, 20)
        '
        'stsCurrentUser
        '
        Me.stsCurrentUser.Name = "stsCurrentUser"
        Me.stsCurrentUser.Size = New System.Drawing.Size(111, 20)
        Me.stsCurrentUser.Text = " ~Current User: "
        Me.stsCurrentUser.ToolTipText = "stsCurrentUser"
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.MessageViewer, 0, 0)
        Me.tlpMain.Controls.Add(Me.tbcMain, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 31)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(5)
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.55887!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.44112!))
        Me.tlpMain.Size = New System.Drawing.Size(690, 610)
        Me.tlpMain.TabIndex = 2
        '
        'MessageViewer
        '
        Me.MessageViewer.AutoSize = True
        Me.MessageViewer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MessageViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageViewer.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageViewer.Location = New System.Drawing.Point(8, 8)
        Me.MessageViewer.Margin = New System.Windows.Forms.Padding(3)
        Me.MessageViewer.Name = "MessageViewer"
        Me.MessageViewer.Size = New System.Drawing.Size(674, 123)
        Me.MessageViewer.TabIndex = 0
        Me.MessageViewer.Text = "Sky Object Log-ifier Turbo"
        Me.MessageViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tpCurrentUser)
        Me.tbcMain.Controls.Add(Me.tpBirds)
        Me.tbcMain.Controls.Add(Me.tpPlanes)
        Me.tbcMain.Controls.Add(Me.tpSpace)
        Me.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcMain.Location = New System.Drawing.Point(8, 137)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.Padding = New System.Drawing.Point(6, 6)
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(674, 465)
        Me.tbcMain.TabIndex = 1
        '
        'tpCurrentUser
        '
        Me.tpCurrentUser.BackColor = System.Drawing.SystemColors.Control
        Me.tpCurrentUser.Controls.Add(Me.tlpUserLog)
        Me.tpCurrentUser.Location = New System.Drawing.Point(4, 36)
        Me.tpCurrentUser.Name = "tpCurrentUser"
        Me.tpCurrentUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCurrentUser.Size = New System.Drawing.Size(666, 425)
        Me.tpCurrentUser.TabIndex = 3
        Me.tpCurrentUser.Text = "User Records"
        '
        'tlpUserLog
        '
        Me.tlpUserLog.ColumnCount = 1
        Me.tlpUserLog.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserLog.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUserLog.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpUserLog.Controls.Add(Me.lbRecords, 0, 1)
        Me.tlpUserLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserLog.Location = New System.Drawing.Point(3, 3)
        Me.tlpUserLog.Name = "tlpUserLog"
        Me.tlpUserLog.RowCount = 2
        Me.tlpUserLog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.00885!))
        Me.tlpUserLog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.99115!))
        Me.tlpUserLog.Size = New System.Drawing.Size(660, 419)
        Me.tlpUserLog.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.87156!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.12844!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCurrentUser, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(654, 90)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbDateRanges)
        Me.Panel1.Controls.Add(Me.lblDateRange)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 84)
        Me.Panel1.TabIndex = 0
        '
        'cbDateRanges
        '
        Me.cbDateRanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDateRanges.FormattingEnabled = True
        Me.cbDateRanges.Items.AddRange(New Object() {"Day", "Week", "Month", "Year", "All Time"})
        Me.cbDateRanges.Location = New System.Drawing.Point(3, 35)
        Me.cbDateRanges.Name = "cbDateRanges"
        Me.cbDateRanges.Size = New System.Drawing.Size(275, 37)
        Me.cbDateRanges.TabIndex = 1
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.Location = New System.Drawing.Point(3, 12)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(182, 21)
        Me.lblDateRange.TabIndex = 0
        Me.lblDateRange.Text = "Get Records For the Past:"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrentUser.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.Location = New System.Drawing.Point(302, 0)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(349, 90)
        Me.lblCurrentUser.TabIndex = 1
        Me.lblCurrentUser.Text = "Default User Log"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbRecords
        '
        Me.lbRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbRecords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRecords.FormattingEnabled = True
        Me.lbRecords.HorizontalScrollbar = True
        Me.lbRecords.ItemHeight = 17
        Me.lbRecords.Location = New System.Drawing.Point(3, 99)
        Me.lbRecords.Name = "lbRecords"
        Me.lbRecords.Size = New System.Drawing.Size(654, 317)
        Me.lbRecords.TabIndex = 3
        '
        'tpBirds
        '
        Me.tpBirds.BackColor = System.Drawing.SystemColors.Control
        Me.tpBirds.Controls.Add(Me.pnlBirdTab)
        Me.tpBirds.Location = New System.Drawing.Point(4, 36)
        Me.tpBirds.Name = "tpBirds"
        Me.tpBirds.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBirds.Size = New System.Drawing.Size(666, 425)
        Me.tpBirds.TabIndex = 0
        Me.tpBirds.Text = "Record Bird"
        '
        'pnlBirdTab
        '
        Me.pnlBirdTab.Controls.Add(Me.gbBirdHelp)
        Me.pnlBirdTab.Controls.Add(Me.gbBirdData)
        Me.pnlBirdTab.Controls.Add(Me.btnRecordBird)
        Me.pnlBirdTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBirdTab.Location = New System.Drawing.Point(3, 3)
        Me.pnlBirdTab.Name = "pnlBirdTab"
        Me.pnlBirdTab.Size = New System.Drawing.Size(660, 419)
        Me.pnlBirdTab.TabIndex = 0
        '
        'gbBirdHelp
        '
        Me.gbBirdHelp.Controls.Add(Me.btnGetRecentSightings)
        Me.gbBirdHelp.Controls.Add(Me.btnBirdFieldGuide)
        Me.gbBirdHelp.Location = New System.Drawing.Point(333, 17)
        Me.gbBirdHelp.Name = "gbBirdHelp"
        Me.gbBirdHelp.Size = New System.Drawing.Size(307, 230)
        Me.gbBirdHelp.TabIndex = 2
        Me.gbBirdHelp.TabStop = False
        Me.gbBirdHelp.Text = "Get Help!"
        '
        'btnGetRecentSightings
        '
        Me.btnGetRecentSightings.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGetRecentSightings.Location = New System.Drawing.Point(61, 133)
        Me.btnGetRecentSightings.Name = "btnGetRecentSightings"
        Me.btnGetRecentSightings.Size = New System.Drawing.Size(195, 66)
        Me.btnGetRecentSightings.TabIndex = 1
        Me.btnGetRecentSightings.Text = "Get Recent Sightings for Your Area"
        Me.btnGetRecentSightings.UseVisualStyleBackColor = False
        '
        'btnBirdFieldGuide
        '
        Me.btnBirdFieldGuide.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBirdFieldGuide.Location = New System.Drawing.Point(61, 48)
        Me.btnBirdFieldGuide.Name = "btnBirdFieldGuide"
        Me.btnBirdFieldGuide.Size = New System.Drawing.Size(195, 66)
        Me.btnBirdFieldGuide.TabIndex = 0
        Me.btnBirdFieldGuide.Text = "Use a Field Guide"
        Me.btnBirdFieldGuide.UseVisualStyleBackColor = False
        '
        'gbBirdData
        '
        Me.gbBirdData.Controls.Add(Me.cbSpecies)
        Me.gbBirdData.Controls.Add(Me.tbBirdNotes)
        Me.gbBirdData.Controls.Add(Me.lblBirdNotes)
        Me.gbBirdData.Controls.Add(Me.lblSpecies)
        Me.gbBirdData.Location = New System.Drawing.Point(20, 17)
        Me.gbBirdData.Name = "gbBirdData"
        Me.gbBirdData.Size = New System.Drawing.Size(307, 230)
        Me.gbBirdData.TabIndex = 1
        Me.gbBirdData.TabStop = False
        Me.gbBirdData.Text = "Sighting Data"
        '
        'cbSpecies
        '
        Me.cbSpecies.FormattingEnabled = True
        Me.cbSpecies.Items.AddRange(New Object() {"American Robin", "Northern Cardinal", "Blue Jay", "Mourning Dove", "American Crow", "European Starling", "Dark-eyed Junco", "Chickadee", "Tufted Titmouse", "House Sparrow", "House Finch", "Goldfinch"})
        Me.cbSpecies.Location = New System.Drawing.Point(49, 59)
        Me.cbSpecies.Name = "cbSpecies"
        Me.cbSpecies.Size = New System.Drawing.Size(206, 29)
        Me.cbSpecies.TabIndex = 4
        '
        'tbBirdNotes
        '
        Me.tbBirdNotes.Location = New System.Drawing.Point(49, 124)
        Me.tbBirdNotes.Multiline = True
        Me.tbBirdNotes.Name = "tbBirdNotes"
        Me.tbBirdNotes.Size = New System.Drawing.Size(207, 83)
        Me.tbBirdNotes.TabIndex = 3
        '
        'lblBirdNotes
        '
        Me.lblBirdNotes.AutoSize = True
        Me.lblBirdNotes.Location = New System.Drawing.Point(45, 100)
        Me.lblBirdNotes.Name = "lblBirdNotes"
        Me.lblBirdNotes.Size = New System.Drawing.Size(116, 21)
        Me.lblBirdNotes.TabIndex = 2
        Me.lblBirdNotes.Text = "Sighting Notes:"
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(45, 35)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(65, 21)
        Me.lblSpecies.TabIndex = 0
        Me.lblSpecies.Text = "Species:"
        '
        'btnRecordBird
        '
        Me.btnRecordBird.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRecordBird.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordBird.Location = New System.Drawing.Point(179, 280)
        Me.btnRecordBird.Name = "btnRecordBird"
        Me.btnRecordBird.Size = New System.Drawing.Size(302, 107)
        Me.btnRecordBird.TabIndex = 0
        Me.btnRecordBird.Text = "Record Sighting"
        Me.btnRecordBird.UseVisualStyleBackColor = False
        '
        'tpPlanes
        '
        Me.tpPlanes.BackColor = System.Drawing.SystemColors.Control
        Me.tpPlanes.Controls.Add(Me.Panel2)
        Me.tpPlanes.Location = New System.Drawing.Point(4, 36)
        Me.tpPlanes.Name = "tpPlanes"
        Me.tpPlanes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPlanes.Size = New System.Drawing.Size(666, 425)
        Me.tpPlanes.TabIndex = 1
        Me.tpPlanes.Text = "Record Plane"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnRecordPlane)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 419)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLivePlanes)
        Me.GroupBox1.Controls.Add(Me.btnPlaneRef)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 230)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Get Help!"
        '
        'btnLivePlanes
        '
        Me.btnLivePlanes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLivePlanes.Location = New System.Drawing.Point(61, 133)
        Me.btnLivePlanes.Name = "btnLivePlanes"
        Me.btnLivePlanes.Size = New System.Drawing.Size(195, 66)
        Me.btnLivePlanes.TabIndex = 1
        Me.btnLivePlanes.Text = "See What's Overhead"
        Me.btnLivePlanes.UseVisualStyleBackColor = False
        '
        'btnPlaneRef
        '
        Me.btnPlaneRef.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPlaneRef.Location = New System.Drawing.Point(61, 48)
        Me.btnPlaneRef.Name = "btnPlaneRef"
        Me.btnPlaneRef.Size = New System.Drawing.Size(195, 66)
        Me.btnPlaneRef.TabIndex = 0
        Me.btnPlaneRef.Text = "Use a Reference"
        Me.btnPlaneRef.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPlaneModel)
        Me.GroupBox2.Controls.Add(Me.tbPlaneNotes)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblPlaneModel)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 230)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sighting Data"
        '
        'tbPlaneNotes
        '
        Me.tbPlaneNotes.Location = New System.Drawing.Point(49, 124)
        Me.tbPlaneNotes.Multiline = True
        Me.tbPlaneNotes.Name = "tbPlaneNotes"
        Me.tbPlaneNotes.Size = New System.Drawing.Size(207, 83)
        Me.tbPlaneNotes.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sighting Notes:"
        '
        'lblPlaneModel
        '
        Me.lblPlaneModel.AutoSize = True
        Me.lblPlaneModel.Location = New System.Drawing.Point(45, 35)
        Me.lblPlaneModel.Name = "lblPlaneModel"
        Me.lblPlaneModel.Size = New System.Drawing.Size(99, 21)
        Me.lblPlaneModel.TabIndex = 0
        Me.lblPlaneModel.Text = "Plane Model:"
        '
        'btnRecordPlane
        '
        Me.btnRecordPlane.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRecordPlane.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordPlane.Location = New System.Drawing.Point(179, 280)
        Me.btnRecordPlane.Name = "btnRecordPlane"
        Me.btnRecordPlane.Size = New System.Drawing.Size(302, 107)
        Me.btnRecordPlane.TabIndex = 0
        Me.btnRecordPlane.Text = "Record Sighting"
        Me.btnRecordPlane.UseVisualStyleBackColor = False
        '
        'tpSpace
        '
        Me.tpSpace.BackColor = System.Drawing.SystemColors.Control
        Me.tpSpace.Controls.Add(Me.Panel3)
        Me.tpSpace.Location = New System.Drawing.Point(4, 36)
        Me.tpSpace.Name = "tpSpace"
        Me.tpSpace.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSpace.Size = New System.Drawing.Size(666, 425)
        Me.tpSpace.TabIndex = 2
        Me.tpSpace.Text = "Record Space Object"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.btnRecordSpaceObject)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 419)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGetIssPos)
        Me.GroupBox3.Controls.Add(Me.btnSpaceOverhead)
        Me.GroupBox3.Controls.Add(Me.btnSpaceRef)
        Me.GroupBox3.Controls.Add(Me.rbNaturalObject)
        Me.GroupBox3.Controls.Add(Me.rbManMade)
        Me.GroupBox3.Location = New System.Drawing.Point(333, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 230)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Get Help!"
        '
        'btnSpaceOverhead
        '
        Me.btnSpaceOverhead.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSpaceOverhead.Location = New System.Drawing.Point(30, 160)
        Me.btnSpaceOverhead.Name = "btnSpaceOverhead"
        Me.btnSpaceOverhead.Size = New System.Drawing.Size(121, 53)
        Me.btnSpaceOverhead.TabIndex = 3
        Me.btnSpaceOverhead.Text = "See What's Overhead"
        Me.btnSpaceOverhead.UseVisualStyleBackColor = False
        '
        'btnSpaceRef
        '
        Me.btnSpaceRef.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSpaceRef.Location = New System.Drawing.Point(30, 102)
        Me.btnSpaceRef.Name = "btnSpaceRef"
        Me.btnSpaceRef.Size = New System.Drawing.Size(121, 53)
        Me.btnSpaceRef.TabIndex = 2
        Me.btnSpaceRef.Text = "Use A Reference"
        Me.btnSpaceRef.UseVisualStyleBackColor = False
        '
        'rbNaturalObject
        '
        Me.rbNaturalObject.AutoSize = True
        Me.rbNaturalObject.Location = New System.Drawing.Point(86, 63)
        Me.rbNaturalObject.Name = "rbNaturalObject"
        Me.rbNaturalObject.Size = New System.Drawing.Size(129, 25)
        Me.rbNaturalObject.TabIndex = 1
        Me.rbNaturalObject.Text = "Natural Object"
        Me.rbNaturalObject.UseVisualStyleBackColor = True
        '
        'rbManMade
        '
        Me.rbManMade.AutoSize = True
        Me.rbManMade.Checked = True
        Me.rbManMade.Location = New System.Drawing.Point(86, 32)
        Me.rbManMade.Name = "rbManMade"
        Me.rbManMade.Size = New System.Drawing.Size(153, 25)
        Me.rbManMade.TabIndex = 0
        Me.rbManMade.TabStop = True
        Me.rbManMade.Text = "Man-Made Object"
        Me.rbManMade.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbSpaceNotes)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.tbSpaceObjectName)
        Me.GroupBox4.Controls.Add(Me.lblSpaceObjectName)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(307, 230)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sighting Data"
        '
        'tbSpaceNotes
        '
        Me.tbSpaceNotes.Location = New System.Drawing.Point(49, 124)
        Me.tbSpaceNotes.Multiline = True
        Me.tbSpaceNotes.Name = "tbSpaceNotes"
        Me.tbSpaceNotes.Size = New System.Drawing.Size(207, 83)
        Me.tbSpaceNotes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sighting Notes:"
        '
        'tbSpaceObjectName
        '
        Me.tbSpaceObjectName.Location = New System.Drawing.Point(49, 59)
        Me.tbSpaceObjectName.Name = "tbSpaceObjectName"
        Me.tbSpaceObjectName.Size = New System.Drawing.Size(207, 29)
        Me.tbSpaceObjectName.TabIndex = 1
        '
        'lblSpaceObjectName
        '
        Me.lblSpaceObjectName.AutoSize = True
        Me.lblSpaceObjectName.Location = New System.Drawing.Point(45, 35)
        Me.lblSpaceObjectName.Name = "lblSpaceObjectName"
        Me.lblSpaceObjectName.Size = New System.Drawing.Size(101, 21)
        Me.lblSpaceObjectName.TabIndex = 0
        Me.lblSpaceObjectName.Text = "Object Name"
        '
        'btnRecordSpaceObject
        '
        Me.btnRecordSpaceObject.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRecordSpaceObject.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordSpaceObject.Location = New System.Drawing.Point(179, 280)
        Me.btnRecordSpaceObject.Name = "btnRecordSpaceObject"
        Me.btnRecordSpaceObject.Size = New System.Drawing.Size(302, 107)
        Me.btnRecordSpaceObject.TabIndex = 0
        Me.btnRecordSpaceObject.Text = "Record Sighting"
        Me.btnRecordSpaceObject.UseVisualStyleBackColor = False
        '
        'cbPlaneModel
        '
        Me.cbPlaneModel.FormattingEnabled = True
        Me.cbPlaneModel.Items.AddRange(New Object() {"Airbus A320", "Airbus A330", "Boeing 737", "Boeing 747", "Boeing 767", "Boeing 787"})
        Me.cbPlaneModel.Location = New System.Drawing.Point(49, 59)
        Me.cbPlaneModel.Name = "cbPlaneModel"
        Me.cbPlaneModel.Size = New System.Drawing.Size(207, 29)
        Me.cbPlaneModel.TabIndex = 4
        '
        'btnGetIssPos
        '
        Me.btnGetIssPos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGetIssPos.Location = New System.Drawing.Point(157, 102)
        Me.btnGetIssPos.Name = "btnGetIssPos"
        Me.btnGetIssPos.Size = New System.Drawing.Size(121, 53)
        Me.btnGetIssPos.TabIndex = 4
        Me.btnGetIssPos.Text = "Get ISS Position"
        Me.btnGetIssPos.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 666)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.msMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sky Object Log-ifier Turbo"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tbcMain.ResumeLayout(False)
        Me.tpCurrentUser.ResumeLayout(False)
        Me.tlpUserLog.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tpBirds.ResumeLayout(False)
        Me.pnlBirdTab.ResumeLayout(False)
        Me.gbBirdHelp.ResumeLayout(False)
        Me.gbBirdData.ResumeLayout(False)
        Me.gbBirdData.PerformLayout()
        Me.tpPlanes.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpSpace.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miLogin As ToolStripMenuItem
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents miHelp As ToolStripMenuItem
    Friend WithEvents miAbout As ToolStripMenuItem
    Friend WithEvents stsMain As StatusStrip
    Friend WithEvents stsTime As ToolStripStatusLabel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents MessageViewer As Label
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tpBirds As TabPage
    Friend WithEvents tpPlanes As TabPage
    Friend WithEvents tpCurrentUser As TabPage
    Friend WithEvents tpSpace As TabPage
    Friend WithEvents stsTimeLabel As ToolStripStatusLabel
    Friend WithEvents stsCurrentUser As ToolStripStatusLabel
    Friend WithEvents stsConnectionStatus As ToolStripStatusLabel
    Friend WithEvents tlpUserLog As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbDateRanges As ComboBox
    Friend WithEvents lblDateRange As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents lbRecords As ListBox
    Friend WithEvents pnlBirdTab As Panel
    Friend WithEvents gbBirdHelp As GroupBox
    Friend WithEvents gbBirdData As GroupBox
    Friend WithEvents tbBirdNotes As TextBox
    Friend WithEvents lblBirdNotes As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents btnRecordBird As Button
    Friend WithEvents btnGetRecentSightings As Button
    Friend WithEvents btnBirdFieldGuide As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLivePlanes As Button
    Friend WithEvents btnPlaneRef As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbPlaneNotes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlaneModel As Label
    Friend WithEvents btnRecordPlane As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbNaturalObject As RadioButton
    Friend WithEvents rbManMade As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbSpaceNotes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSpaceObjectName As TextBox
    Friend WithEvents lblSpaceObjectName As Label
    Friend WithEvents btnRecordSpaceObject As Button
    Friend WithEvents btnSpaceOverhead As Button
    Friend WithEvents btnSpaceRef As Button
    Friend WithEvents cbSpecies As ComboBox
    Friend WithEvents cbPlaneModel As ComboBox
    Friend WithEvents btnGetIssPos As Button
End Class
