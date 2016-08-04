<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExcelMerger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExcelMerger))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USERACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(935, 444)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERACCOUNTSToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 24)
        Me.MenuStrip1.TabIndex = 103
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USERACCOUNTSToolStripMenuItem
        '
        Me.USERACCOUNTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateAccountToolStripMenuItem, Me.ManageAccountToolStripMenuItem})
        Me.USERACCOUNTSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERACCOUNTSToolStripMenuItem.Name = "USERACCOUNTSToolStripMenuItem"
        Me.USERACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.USERACCOUNTSToolStripMenuItem.Text = "&USER ACCOUNTS"
        '
        'CreateAccountToolStripMenuItem
        '
        Me.CreateAccountToolStripMenuItem.Image = CType(resources.GetObject("CreateAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateAccountToolStripMenuItem.Name = "CreateAccountToolStripMenuItem"
        Me.CreateAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CreateAccountToolStripMenuItem.Text = "Create Account"
        '
        'ManageAccountToolStripMenuItem
        '
        Me.ManageAccountToolStripMenuItem.Image = CType(resources.GetObject("ManageAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem"
        Me.ManageAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ManageAccountToolStripMenuItem.Text = "Manage Account"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "&LOGOUT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "&EXIT"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
        Me.btnUpload.Location = New System.Drawing.Point(12, 33)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(83, 21)
        Me.btnUpload.TabIndex = 104
        Me.btnUpload.Text = "Export"
        Me.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(711, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 15)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Welcome :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.SteelBlue
        Me.lbluser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(781, 2)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(29, 15)
        Me.lbluser.TabIndex = 107
        Me.lbluser.Text = "user"
        '
        'ExcelMerger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 514)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ExcelMerger"
        Me.Text = "Favotax Prosoft Integration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USERACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
End Class
