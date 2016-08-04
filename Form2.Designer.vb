<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnvalidate = New System.Windows.Forms.Button()
        Me.txtadpas = New System.Windows.Forms.TextBox()
        Me.txtadmin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtusr = New System.Windows.Forms.TextBox()
        Me.txtpas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtpas2 = New System.Windows.Forms.TextBox()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.ChkAdmin = New System.Windows.Forms.CheckBox()
        Me.chknssf = New System.Windows.Forms.CheckBox()
        Me.chkItax = New System.Windows.Forms.CheckBox()
        Me.btncancel2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITAXEXPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Location = New System.Drawing.Point(318, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(290, 37)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Ensure your password has at least one number,includes mixed case(upper and lower " & _
    "case) as well as alphabets."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 37)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Only admin accounts can create user accounts."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.btnvalidate)
        Me.Panel1.Controls.Add(Me.txtadpas)
        Me.Panel1.Controls.Add(Me.txtadmin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 224)
        Me.Panel1.TabIndex = 96
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(154, 163)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(68, 21)
        Me.btncancel.TabIndex = 90
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnvalidate
        '
        Me.btnvalidate.Location = New System.Drawing.Point(40, 163)
        Me.btnvalidate.Name = "btnvalidate"
        Me.btnvalidate.Size = New System.Drawing.Size(73, 21)
        Me.btnvalidate.TabIndex = 10
        Me.btnvalidate.Text = "VALIDATE"
        Me.btnvalidate.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "VERIFY ADMIN STATUS TO PROCEED"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 22)
        Me.StatusStrip1.TabIndex = 98
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(143, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright Favotech Ltd 05.2014"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(33, 44)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(32, 101)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtusr
        '
        Me.txtusr.Location = New System.Drawing.Point(33, 64)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(220, 20)
        Me.txtusr.TabIndex = 5
        '
        'txtpas
        '
        Me.txtpas.Location = New System.Drawing.Point(36, 121)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas.Size = New System.Drawing.Size(220, 20)
        Me.txtpas.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(60, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "CREATE USER ACCOUNT"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(32, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(220, 23)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Match &Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpas2
        '
        Me.txtpas2.Location = New System.Drawing.Point(33, 187)
        Me.txtpas2.Name = "txtpas2"
        Me.txtpas2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas2.Size = New System.Drawing.Size(220, 20)
        Me.txtpas2.TabIndex = 9
        '
        'btncreate
        '
        Me.btncreate.Location = New System.Drawing.Point(33, 296)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(66, 21)
        Me.btncreate.TabIndex = 10
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'ChkAdmin
        '
        Me.ChkAdmin.AutoSize = True
        Me.ChkAdmin.Location = New System.Drawing.Point(33, 260)
        Me.ChkAdmin.Name = "ChkAdmin"
        Me.ChkAdmin.Size = New System.Drawing.Size(66, 17)
        Me.ChkAdmin.TabIndex = 96
        Me.ChkAdmin.Text = "Is &Admin"
        Me.ChkAdmin.UseVisualStyleBackColor = True
        '
        'chknssf
        '
        Me.chknssf.AutoSize = True
        Me.chknssf.Location = New System.Drawing.Point(33, 228)
        Me.chknssf.Name = "chknssf"
        Me.chknssf.Size = New System.Drawing.Size(109, 17)
        Me.chknssf.TabIndex = 97
        Me.chknssf.Text = "Can Export &NSSF"
        Me.chknssf.UseVisualStyleBackColor = True
        '
        'chkItax
        '
        Me.chkItax.AutoSize = True
        Me.chkItax.Location = New System.Drawing.Point(150, 228)
        Me.chkItax.Name = "chkItax"
        Me.chkItax.Size = New System.Drawing.Size(105, 17)
        Me.chkItax.TabIndex = 98
        Me.chkItax.Text = "Can Export &ITAX"
        Me.chkItax.UseVisualStyleBackColor = True
        '
        'btncancel2
        '
        Me.btncancel2.Location = New System.Drawing.Point(150, 296)
        Me.btncancel2.Name = "btncancel2"
        Me.btncancel2.Size = New System.Drawing.Size(64, 21)
        Me.btncancel2.TabIndex = 99
        Me.btncancel2.Text = "CANCEL"
        Me.btncancel2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btncancel2)
        Me.Panel3.Controls.Add(Me.chkItax)
        Me.Panel3.Controls.Add(Me.chknssf)
        Me.Panel3.Controls.Add(Me.ChkAdmin)
        Me.Panel3.Controls.Add(Me.btncreate)
        Me.Panel3.Controls.Add(Me.txtpas2)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtpas)
        Me.Panel3.Controls.Add(Me.txtusr)
        Me.Panel3.Controls.Add(Me.PasswordLabel)
        Me.Panel3.Controls.Add(Me.UsernameLabel)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(318, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 371)
        Me.Panel3.TabIndex = 87
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.USERACCOUNTSToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 103
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
        Me.USERACCOUNTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateAccountToolStripMenuItem})
        Me.USERACCOUNTSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERACCOUNTSToolStripMenuItem.Name = "USERACCOUNTSToolStripMenuItem"
        Me.USERACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.USERACCOUNTSToolStripMenuItem.Text = "&USER ACCOUNTS"
        '
        'CreateAccountToolStripMenuItem
        '
        Me.CreateAccountToolStripMenuItem.Name = "CreateAccountToolStripMenuItem"
        Me.CreateAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CreateAccountToolStripMenuItem.Text = "Manage Account"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Welcome :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(614, 0)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(27, 13)
        Me.lbluser.TabIndex = 104
        Me.lbluser.Text = "user"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(719, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FavoTax User Accounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnvalidate As System.Windows.Forms.Button
    Friend WithEvents txtadpas As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtusr As System.Windows.Forms.TextBox
    Friend WithEvents txtpas As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpas2 As System.Windows.Forms.TextBox
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents ChkAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chknssf As System.Windows.Forms.CheckBox
    Friend WithEvents chkItax As System.Windows.Forms.CheckBox
    Friend WithEvents btncancel2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITAXEXPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
End Class
