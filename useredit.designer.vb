<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useredit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(useredit))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.chkItax = New System.Windows.Forms.CheckBox()
        Me.chknssf = New System.Windows.Forms.CheckBox()
        Me.chkadmin = New System.Windows.Forms.CheckBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtadpas = New System.Windows.Forms.TextBox()
        Me.txtadmin = New System.Windows.Forms.TextBox()
        Me.txtpas2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITAXEXPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LstAccounts = New System.Windows.Forms.ListBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdateOtherAccount = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.chkItax)
        Me.Panel1.Controls.Add(Me.chknssf)
        Me.Panel1.Controls.Add(Me.chkadmin)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.txtadpas)
        Me.Panel1.Controls.Add(Me.txtadmin)
        Me.Panel1.Controls.Add(Me.txtpas2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtpas)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Location = New System.Drawing.Point(10, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 385)
        Me.Panel1.TabIndex = 97
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(158, 340)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(68, 21)
        Me.btncancel.TabIndex = 94
        Me.btncancel.Text = "CLEAR"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'chkItax
        '
        Me.chkItax.AutoSize = True
        Me.chkItax.Location = New System.Drawing.Point(23, 305)
        Me.chkItax.Name = "chkItax"
        Me.chkItax.Size = New System.Drawing.Size(105, 17)
        Me.chkItax.TabIndex = 93
        Me.chkItax.Text = "Can Export &ITAX"
        Me.chkItax.UseVisualStyleBackColor = True
        '
        'chknssf
        '
        Me.chknssf.AutoSize = True
        Me.chknssf.Location = New System.Drawing.Point(23, 272)
        Me.chknssf.Name = "chknssf"
        Me.chknssf.Size = New System.Drawing.Size(109, 17)
        Me.chknssf.TabIndex = 92
        Me.chknssf.Text = "Can Export &NSSF"
        Me.chknssf.UseVisualStyleBackColor = True
        '
        'chkadmin
        '
        Me.chkadmin.AutoSize = True
        Me.chkadmin.Location = New System.Drawing.Point(158, 272)
        Me.chkadmin.Name = "chkadmin"
        Me.chkadmin.Size = New System.Drawing.Size(66, 17)
        Me.chkadmin.TabIndex = 91
        Me.chkadmin.Text = "Is &Admin"
        Me.chkadmin.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(23, 340)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(71, 21)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtadpas
        '
        Me.txtadpas.Location = New System.Drawing.Point(23, 121)
        Me.txtadpas.Name = "txtadpas"
        Me.txtadpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtadpas.Size = New System.Drawing.Size(220, 20)
        Me.txtadpas.TabIndex = 7
        '
        'txtadmin
        '
        Me.txtadmin.Location = New System.Drawing.Point(24, 64)
        Me.txtadmin.Name = "txtadmin"
        Me.txtadmin.Size = New System.Drawing.Size(220, 20)
        Me.txtadmin.TabIndex = 5
        '
        'txtpas2
        '
        Me.txtpas2.Location = New System.Drawing.Point(23, 237)
        Me.txtpas2.Name = "txtpas2"
        Me.txtpas2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas2.Size = New System.Drawing.Size(220, 20)
        Me.txtpas2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current &Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(22, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(220, 23)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Match &Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&User name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpas
        '
        Me.txtpas.Location = New System.Drawing.Point(25, 173)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas.Size = New System.Drawing.Size(220, 20)
        Me.txtpas.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "UPDATE ACCOUNT DETAILS"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(23, 153)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.USERACCOUNTSToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 96
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ITAXEXPORTToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.ToolStripMenuItem1.Text = "&EXPORT"
        '
        'ITAXEXPORTToolStripMenuItem
        '
        Me.ITAXEXPORTToolStripMenuItem.Image = CType(resources.GetObject("ITAXEXPORTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ITAXEXPORTToolStripMenuItem.Name = "ITAXEXPORTToolStripMenuItem"
        Me.ITAXEXPORTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ITAXEXPORTToolStripMenuItem.Text = "ITax Export"
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
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Location = New System.Drawing.Point(317, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(290, 37)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Ensure your password has at least one number,includes mixed case(upper and lower " & _
    "case) as well as alphabets. "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Welcome :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(500, 9)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(27, 13)
        Me.lbluser.TabIndex = 100
        Me.lbluser.Text = "user"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 102
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(173, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Favotech Ltd 05.2014"
        '
        'LstAccounts
        '
        Me.LstAccounts.FormattingEnabled = True
        Me.LstAccounts.Location = New System.Drawing.Point(15, 7)
        Me.LstAccounts.Name = "LstAccounts"
        Me.LstAccounts.Size = New System.Drawing.Size(220, 56)
        Me.LstAccounts.TabIndex = 103
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(136, 78)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(99, 21)
        Me.BtnDelete.TabIndex = 104
        Me.BtnDelete.Text = "Delete Account"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnUpdateOtherAccount)
        Me.Panel2.Controls.Add(Me.LstAccounts)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Location = New System.Drawing.Point(317, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(289, 117)
        Me.Panel2.TabIndex = 105
        Me.Panel2.Visible = False
        '
        'btnUpdateOtherAccount
        '
        Me.btnUpdateOtherAccount.Location = New System.Drawing.Point(15, 78)
        Me.btnUpdateOtherAccount.Name = "btnUpdateOtherAccount"
        Me.btnUpdateOtherAccount.Size = New System.Drawing.Size(99, 21)
        Me.btnUpdateOtherAccount.TabIndex = 105
        Me.btnUpdateOtherAccount.Text = "Update Account"
        Me.btnUpdateOtherAccount.UseVisualStyleBackColor = True
        '
        'useredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 469)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label18)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "useredit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FavoTax User Accounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents txtadpas As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkadmin As System.Windows.Forms.CheckBox
    Friend WithEvents txtpas2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpas As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents CreateAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITAXEXPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkItax As System.Windows.Forms.CheckBox
    Friend WithEvents chknssf As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LstAccounts As System.Windows.Forms.ListBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateOtherAccount As System.Windows.Forms.Button
End Class
