<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grpTables = New System.Windows.Forms.GroupBox
        Me.grpDatabases = New System.Windows.Forms.GroupBox
        Me.cmbDatabases = New System.Windows.Forms.ComboBox
        Me.grpServer = New System.Windows.Forms.GroupBox
        Me.pnlAut = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.rdbSqlAut = New System.Windows.Forms.RadioButton
        Me.rdbWindowsAut = New System.Windows.Forms.RadioButton
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.grpDoXMLTables = New System.Windows.Forms.GroupBox
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.tbcTables = New System.Windows.Forms.TabControl
        Me.cmnuTabControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuTCTableClose = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.cmnuListboxes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuLstColumnDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnulstAllColumnsDel = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnulstAllColumns = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuLstMoveToUpColumn = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuLstMoveToDownColumn = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuTCClosAllTablesButThis = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuTCCloseAllTables = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.clbTables = New System.Windows.Forms.CheckedListBox
        Me.SelectAllTables = New System.Windows.Forms.ToolStripButton
        Me.DeselectAllTables = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpTables.SuspendLayout()
        Me.grpDatabases.SuspendLayout()
        Me.grpServer.SuspendLayout()
        Me.pnlAut.SuspendLayout()
        Me.grpDoXMLTables.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.cmnuTabControl.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.cmnuListboxes.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpTables)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpDatabases)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpServer)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpDoXMLTables)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.SplitContainer1.Size = New System.Drawing.Size(645, 464)
        Me.SplitContainer1.SplitterDistance = 231
        Me.SplitContainer1.TabIndex = 0
        '
        'grpTables
        '
        Me.grpTables.Controls.Add(Me.clbTables)
        Me.grpTables.Controls.Add(Me.ToolStrip2)
        Me.grpTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTables.Location = New System.Drawing.Point(5, 244)
        Me.grpTables.Name = "grpTables"
        Me.grpTables.Padding = New System.Windows.Forms.Padding(8)
        Me.grpTables.Size = New System.Drawing.Size(221, 215)
        Me.grpTables.TabIndex = 2
        Me.grpTables.TabStop = False
        Me.grpTables.Text = "Tablolar"
        '
        'grpDatabases
        '
        Me.grpDatabases.Controls.Add(Me.cmbDatabases)
        Me.grpDatabases.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatabases.Location = New System.Drawing.Point(5, 187)
        Me.grpDatabases.Name = "grpDatabases"
        Me.grpDatabases.Padding = New System.Windows.Forms.Padding(8)
        Me.grpDatabases.Size = New System.Drawing.Size(221, 57)
        Me.grpDatabases.TabIndex = 1
        Me.grpDatabases.TabStop = False
        Me.grpDatabases.Text = "Database'ler"
        '
        'cmbDatabases
        '
        Me.cmbDatabases.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbDatabases.FormattingEnabled = True
        Me.cmbDatabases.Location = New System.Drawing.Point(8, 21)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(205, 21)
        Me.cmbDatabases.TabIndex = 0
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.pnlAut)
        Me.grpServer.Controls.Add(Me.btnConnect)
        Me.grpServer.Controls.Add(Me.rdbSqlAut)
        Me.grpServer.Controls.Add(Me.rdbWindowsAut)
        Me.grpServer.Controls.Add(Me.txtServer)
        Me.grpServer.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpServer.Location = New System.Drawing.Point(5, 8)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Padding = New System.Windows.Forms.Padding(8)
        Me.grpServer.Size = New System.Drawing.Size(221, 179)
        Me.grpServer.TabIndex = 0
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Server Authentication"
        '
        'pnlAut
        '
        Me.pnlAut.Controls.Add(Me.Label2)
        Me.pnlAut.Controls.Add(Me.txtPassword)
        Me.pnlAut.Controls.Add(Me.txtUserID)
        Me.pnlAut.Controls.Add(Me.Label1)
        Me.pnlAut.Location = New System.Drawing.Point(3, 93)
        Me.pnlAut.Name = "pnlAut"
        Me.pnlAut.Size = New System.Drawing.Size(213, 50)
        Me.pnlAut.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(75, 27)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(135, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(75, 3)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(135, 20)
        Me.txtUserID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "UserID :"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(136, 149)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 7
        Me.btnConnect.Text = "Baðlan"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'rdbSqlAut
        '
        Me.rdbSqlAut.AutoSize = True
        Me.rdbSqlAut.Location = New System.Drawing.Point(51, 70)
        Me.rdbSqlAut.Name = "rdbSqlAut"
        Me.rdbSqlAut.Size = New System.Drawing.Size(117, 17)
        Me.rdbSqlAut.TabIndex = 2
        Me.rdbSqlAut.Text = "SQL Authentication"
        Me.rdbSqlAut.UseVisualStyleBackColor = True
        '
        'rdbWindowsAut
        '
        Me.rdbWindowsAut.AutoSize = True
        Me.rdbWindowsAut.Checked = True
        Me.rdbWindowsAut.Location = New System.Drawing.Point(51, 47)
        Me.rdbWindowsAut.Name = "rdbWindowsAut"
        Me.rdbWindowsAut.Size = New System.Drawing.Size(140, 17)
        Me.rdbWindowsAut.TabIndex = 1
        Me.rdbWindowsAut.TabStop = True
        Me.rdbWindowsAut.Text = "Windows Authentication"
        Me.rdbWindowsAut.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtServer.Location = New System.Drawing.Point(8, 21)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(205, 20)
        Me.txtServer.TabIndex = 0
        '
        'grpDoXMLTables
        '
        Me.grpDoXMLTables.Controls.Add(Me.ToolStripContainer1)
        Me.grpDoXMLTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDoXMLTables.Location = New System.Drawing.Point(8, 8)
        Me.grpDoXMLTables.Name = "grpDoXMLTables"
        Me.grpDoXMLTables.Padding = New System.Windows.Forms.Padding(8)
        Me.grpDoXMLTables.Size = New System.Drawing.Size(394, 448)
        Me.grpDoXMLTables.TabIndex = 0
        Me.grpDoXMLTables.TabStop = False
        Me.grpDoXMLTables.Text = "XML Dosya Yapýlacak Tablolarýn Ayarlarý"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tbcTables)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(378, 394)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(8, 21)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(378, 419)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'tbcTables
        '
        Me.tbcTables.ContextMenuStrip = Me.cmnuTabControl
        Me.tbcTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcTables.Location = New System.Drawing.Point(0, 0)
        Me.tbcTables.Name = "tbcTables"
        Me.tbcTables.SelectedIndex = 0
        Me.tbcTables.Size = New System.Drawing.Size(378, 394)
        Me.tbcTables.TabIndex = 2
        '
        'cmnuTabControl
        '
        Me.cmnuTabControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuTCTableClose, Me.cmnuTCClosAllTablesButThis, Me.ToolStripMenuItem2, Me.cmnuTCCloseAllTables})
        Me.cmnuTabControl.Name = "cmnuTabControl"
        Me.cmnuTabControl.Size = New System.Drawing.Size(251, 76)
        '
        'cmnuTCTableClose
        '
        Me.cmnuTCTableClose.Name = "cmnuTCTableClose"
        Me.cmnuTCTableClose.Size = New System.Drawing.Size(250, 22)
        Me.cmnuTCTableClose.Text = "Seçili Sekmeyi Kapat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(81, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.ToolTipText = "Yeni"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        Me.OpenToolStripButton.ToolTipText = "Aç"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Kaydet"
        '
        'cmnuListboxes
        '
        Me.cmnuListboxes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuLstColumnDel, Me.cmnulstAllColumnsDel, Me.cmnulstAllColumns, Me.ToolStripMenuItem1, Me.cmnuLstMoveToUpColumn, Me.cmnuLstMoveToDownColumn})
        Me.cmnuListboxes.Name = "cmnuListboxes"
        Me.cmnuListboxes.Size = New System.Drawing.Size(207, 120)
        '
        'cmnuLstColumnDel
        '
        Me.cmnuLstColumnDel.Name = "cmnuLstColumnDel"
        Me.cmnuLstColumnDel.Size = New System.Drawing.Size(206, 22)
        Me.cmnuLstColumnDel.Text = "Kolonu Sil"
        '
        'cmnulstAllColumnsDel
        '
        Me.cmnulstAllColumnsDel.Name = "cmnulstAllColumnsDel"
        Me.cmnulstAllColumnsDel.Size = New System.Drawing.Size(206, 22)
        Me.cmnulstAllColumnsDel.Text = "Tüm Kolonlarý Sil"
        '
        'cmnulstAllColumns
        '
        Me.cmnulstAllColumns.Name = "cmnulstAllColumns"
        Me.cmnulstAllColumns.Size = New System.Drawing.Size(206, 22)
        Me.cmnulstAllColumns.Text = "Tüm Kolonlarý Getir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 6)
        '
        'cmnuLstMoveToUpColumn
        '
        Me.cmnuLstMoveToUpColumn.Name = "cmnuLstMoveToUpColumn"
        Me.cmnuLstMoveToUpColumn.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmnuLstMoveToUpColumn.Size = New System.Drawing.Size(206, 22)
        Me.cmnuLstMoveToUpColumn.Text = "Kolonu Yukarý Taþý"
        '
        'cmnuLstMoveToDownColumn
        '
        Me.cmnuLstMoveToDownColumn.Name = "cmnuLstMoveToDownColumn"
        Me.cmnuLstMoveToDownColumn.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.cmnuLstMoveToDownColumn.Size = New System.Drawing.Size(206, 22)
        Me.cmnuLstMoveToDownColumn.Text = "Kolonu Aþaðý Taþý"
        '
        'cmnuTCClosAllTablesButThis
        '
        Me.cmnuTCClosAllTablesButThis.Name = "cmnuTCClosAllTablesButThis"
        Me.cmnuTCClosAllTablesButThis.Size = New System.Drawing.Size(250, 22)
        Me.cmnuTCClosAllTablesButThis.Text = "Seçili Sekme Hariç Diðerlerini Kapat"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(247, 6)
        '
        'cmnuTCCloseAllTables
        '
        Me.cmnuTCCloseAllTables.Name = "cmnuTCCloseAllTables"
        Me.cmnuTCCloseAllTables.Size = New System.Drawing.Size(250, 22)
        Me.cmnuTCCloseAllTables.Text = "Tüm Sekmeleri Kapat"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllTables, Me.DeselectAllTables})
        Me.ToolStrip2.Location = New System.Drawing.Point(8, 21)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(205, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'clbTables
        '
        Me.clbTables.CheckOnClick = True
        Me.clbTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbTables.FormattingEnabled = True
        Me.clbTables.Location = New System.Drawing.Point(8, 46)
        Me.clbTables.Name = "clbTables"
        Me.clbTables.Size = New System.Drawing.Size(205, 154)
        Me.clbTables.TabIndex = 2
        '
        'SelectAllTables
        '
        Me.SelectAllTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectAllTables.Image = CType(resources.GetObject("SelectAllTables.Image"), System.Drawing.Image)
        Me.SelectAllTables.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectAllTables.Name = "SelectAllTables"
        Me.SelectAllTables.Size = New System.Drawing.Size(23, 22)
        Me.SelectAllTables.Text = "ToolStripButton1"
        '
        'DeselectAllTables
        '
        Me.DeselectAllTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeselectAllTables.Image = CType(resources.GetObject("DeselectAllTables.Image"), System.Drawing.Image)
        Me.DeselectAllTables.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeselectAllTables.Name = "DeselectAllTables"
        Me.DeselectAllTables.Size = New System.Drawing.Size(23, 22)
        Me.DeselectAllTables.Text = "ToolStripButton2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 464)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Create XML File From SQL Database Tables"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpTables.ResumeLayout(False)
        Me.grpTables.PerformLayout()
        Me.grpDatabases.ResumeLayout(False)
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        Me.pnlAut.ResumeLayout(False)
        Me.pnlAut.PerformLayout()
        Me.grpDoXMLTables.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.cmnuTabControl.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.cmnuListboxes.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpServer As System.Windows.Forms.GroupBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents rdbSqlAut As System.Windows.Forms.RadioButton
    Friend WithEvents rdbWindowsAut As System.Windows.Forms.RadioButton
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents grpTables As System.Windows.Forms.GroupBox
    Friend WithEvents grpDatabases As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents pnlAut As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpDoXMLTables As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents tbcTables As System.Windows.Forms.TabControl
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmnuTabControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuTCTableClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuListboxes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuLstColumnDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnulstAllColumns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuLstMoveToUpColumn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuLstMoveToDownColumn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnulstAllColumnsDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbTables As System.Windows.Forms.CheckedListBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents SelectAllTables As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeselectAllTables As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmnuTCClosAllTablesButThis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuTCCloseAllTables As System.Windows.Forms.ToolStripMenuItem

End Class
