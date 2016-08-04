<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class license
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(license))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblApplicationStatus = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblVKStatus = New System.Windows.Forms.Label()
        Me.btnTestKey = New System.Windows.Forms.Button()
        Me.txtKeyToValidate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVKClientName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassPhrase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Controls.Add(Me.lblApplicationStatus)
        Me.GroupBox2.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox2.Controls.Add(Me.lblVKStatus)
        Me.GroupBox2.Controls.Add(Me.btnTestKey)
        Me.GroupBox2.Controls.Add(Me.txtKeyToValidate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtVKClientName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(469, 223)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblApplicationStatus
        '
        Me.lblApplicationStatus.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblApplicationStatus.Location = New System.Drawing.Point(7, 171)
        Me.lblApplicationStatus.Name = "lblApplicationStatus"
        Me.lblApplicationStatus.Size = New System.Drawing.Size(464, 46)
        Me.lblApplicationStatus.TabIndex = 13
        Me.lblApplicationStatus.Text = "Status"
        Me.lblApplicationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(10, 17)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(49, 47)
        Me.LogoPictureBox.TabIndex = 8
        Me.LogoPictureBox.TabStop = False
        '
        'lblVKStatus
        '
        Me.lblVKStatus.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblVKStatus.Location = New System.Drawing.Point(7, 121)
        Me.lblVKStatus.Name = "lblVKStatus"
        Me.lblVKStatus.Size = New System.Drawing.Size(464, 50)
        Me.lblVKStatus.TabIndex = 11
        Me.lblVKStatus.Text = "Status"
        Me.lblVKStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVKStatus.Visible = False
        '
        'btnTestKey
        '
        Me.btnTestKey.Location = New System.Drawing.Point(168, 93)
        Me.btnTestKey.Name = "btnTestKey"
        Me.btnTestKey.Size = New System.Drawing.Size(93, 25)
        Me.btnTestKey.TabIndex = 10
        Me.btnTestKey.Text = "Confirm key"
        Me.btnTestKey.UseVisualStyleBackColor = True
        '
        'txtKeyToValidate
        '
        Me.txtKeyToValidate.Location = New System.Drawing.Point(168, 52)
        Me.txtKeyToValidate.Name = "txtKeyToValidate"
        Me.txtKeyToValidate.Size = New System.Drawing.Size(289, 23)
        Me.txtKeyToValidate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "License key"
        '
        'txtVKClientName
        '
        Me.txtVKClientName.Location = New System.Drawing.Point(168, 17)
        Me.txtVKClientName.Name = "txtVKClientName"
        Me.txtVKClientName.Size = New System.Drawing.Size(289, 23)
        Me.txtVKClientName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Client Name"
        '
        'txtPassPhrase
        '
        Me.txtPassPhrase.Location = New System.Drawing.Point(488, 8)
        Me.txtPassPhrase.MaxLength = 16
        Me.txtPassPhrase.Name = "txtPassPhrase"
        Me.txtPassPhrase.Size = New System.Drawing.Size(15, 23)
        Me.txtPassPhrase.TabIndex = 2
        Me.txtPassPhrase.Text = "favotaxsolution"
        Me.txtPassPhrase.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Copyright Favotech Ltd 05.2014"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(292, 93)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'license
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassPhrase)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "license"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favotax Licensing "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassPhrase As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyToValidate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVKClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTestKey As System.Windows.Forms.Button
    Friend WithEvents lblVKStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblApplicationStatus As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
