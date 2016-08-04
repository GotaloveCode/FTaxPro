Imports System.Data.SqlClient
Public Class useredit
    Dim sql As New Common
    Dim dt As DataTable = New DataTable

    Private Sub useredit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbluser.Text = _user
        If dt.Rows.Count > 0 Then
            dt.Clear() 'clear datatable to avoid reentry of same data on reload
        End If
        Dim isAdmin As Boolean
        Dim comnd As New SqlCommand("select * from tblitaxapppasswords", sql.Getconnect)
        Dim datardr As SqlDataReader = comnd.ExecuteReader
        dt.Load(datardr)
        LstAccounts.DataSource = Nothing
        LstAccounts.Items.Clear()
        LstAccounts.DisplayMember = "User_Name"
        LstAccounts.ValueMember = "User_ID"
        LstAccounts.DataSource = dt
        LstAccounts.SelectedIndex = -1
        Dim dtOld2 As DataTable = DirectCast(LstAccounts.DataSource, DataTable)
        Dim drs2() As DataRow = dtOld2.Select("User_ID = " + _user_id.ToString() + "")
        For Each dr2 As DataRow In drs2
            isAdmin = dr2.Item(4) 'set adminstatus
            txtadmin.Text = lbluser.Text
            chknssf.Checked = dr2.Item(6)
            chkItax.Checked = dr2.Item(7)
            chkadmin.Checked = dr2.Item(4)
        Next
        sql.Getconnect.Close()
        If isAdmin = True Then
            Panel2.Visible = True 'set visible forr admin to delete
        End If
        Label3.Visible = True
        txtadpas.Visible = True
        btnupdate.Visible = True
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim user As String = txtadmin.Text.Trim
        Dim userpas As String = txtadpas.Text.Trim
        Dim pas As String = txtpas.Text.Trim
        Dim pas2 As String = txtpas2.Text.Trim
        Dim salt As String = "hcetfavoltd"
        Dim rawSalted As String = salt & userpas
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)
        Dim rawSalted2 As String = salt & pas
        Dim saltedPwBytes2() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted2)
        Dim sha2 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes2() As Byte = sha1.ComputeHash(saltedPwBytes2)
        Dim hashedPw2 As String = Convert.ToBase64String(hashedPwBytes2)
        Dim isadmin As Integer
        Dim admin As Integer = 0
        Dim nssfExport As Integer = 0
        Dim itaxExport As Integer = 0
        
        If chknssf.Checked = True Then
            nssfExport = 1 'assign 1 to indicate checked
        End If
        If chkItax.Checked = True Then
            itaxExport = 1
        End If
        If chkadmin.Checked = True Then
            admin = 1
        End If
        If user.Length = 0 And userpas.Length < 8 Then
            MessageBox.Show("Please enter Username and valid password", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas.Length < 8 Then
            MessageBox.Show("Please enter password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas <> pas2 Then
            MessageBox.Show("Password mismatch", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cmd As New SqlCommand("select User_Name,Password,Admin from tblITaxAppPasswords where User_Name =@user and Password = @pass", sql.Getconnect)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
            Dim dr As SqlDataReader = Nothing
            Try
                dr = cmd.ExecuteReader
                If dr.HasRows = True Then
                    dr.Read()
                    isadmin = dr.Item("Admin")
                    If isadmin = 0 Then 'if not admin update only password
                        sql.Getconnect.Close()
                        Dim cmd2 As New SqlCommand("update tblITaxAppPasswords set Password =@pasd where User_Name=@user and Password= @pass", sql.Getconnect)
                        cmd2.CommandType = CommandType.Text
                        cmd2.Parameters.Add("@pasd", SqlDbType.VarChar).Value = hashedPw2
                        cmd2.Parameters.Add("@user", SqlDbType.VarChar).Value = user
                        cmd2.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
                        cmd2.ExecuteNonQuery()
                    Else 'isadmin update pass,export nssf &Itax
                        sql.Getconnect.Close() 'closing 1st con
                        Dim cmd2 As New SqlCommand("update tblITaxAppPasswords set Password =@pasd,Admin=@adstatus,export_nssf=@exnssf,export_itax=@exitax where User_Name=@user and Password= @pass", sql.Getconnect)
                        cmd2.CommandType = CommandType.Text
                        cmd2.Parameters.Add("@pasd", SqlDbType.VarChar).Value = hashedPw2
                        cmd2.Parameters.Add("@adstatus", SqlDbType.Bit).Value = admin
                        cmd2.Parameters.Add("@exnssf", SqlDbType.Bit).Value = nssfExport
                        cmd2.Parameters.Add("@exitax", SqlDbType.Bit).Value = itaxExport
                        cmd2.Parameters.Add("@user", SqlDbType.VarChar).Value = user
                        cmd2.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
                        cmd2.ExecuteNonQuery()
                    End If
                    MessageBox.Show("User account updated", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtadmin.Clear()
                    txtpas.Clear()
                    txtpas2.Clear()
                    txtadpas.Clear()
                    chkadmin.CheckState = CheckState.Unchecked
                    chkItax.CheckState = CheckState.Unchecked
                    chknssf.CheckState = CheckState.Unchecked
                Else
                    MessageBox.Show("User Account Details invalid", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                dr.Close()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                If dr IsNot Nothing Then
                    If Not dr.IsClosed Then dr.Close()
                End If
                sql.Getconnect.Close()
            End Try
        End If
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        Dim createaccount As New Form2
        Me.Hide()
        createaccount.Show()
        Me.Close()
    End Sub
    Private Sub ITAXEXPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITAXEXPORTToolStripMenuItem.Click
        Dim f As New ExcelMerger
        Me.Hide()
        f.Show()
        Me.Close()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtadmin.Clear()
        txtadpas.Clear()
        txtpas.Clear()
        txtpas2.Clear()
        chkadmin.Checked = False
        chkItax.Checked = False
        chknssf.Checked = False
        LstAccounts.SelectedIndex = -1
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If LstAccounts.SelectedIndex = -1 Then
            MsgBox("You must select user account to delete")
            LstAccounts.Focus()
        Else
            Dim DResult As Windows.Forms.DialogResult = MessageBox.Show("Are you sure you want to delete the selected user account." & Environment.NewLine & "This process is irreversible.", "Delete UserAccount" _
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If DResult = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim cmd As New SqlCommand("delete from tblITaxAppPasswords where user_id=@userid", sql.Getconnect)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("userid", LstAccounts.SelectedValue)
                    Dim rowsaffected As Integer = cmd.ExecuteNonQuery()
                    If rowsaffected > 0 Then
                        MsgBox("User deleted")
                        useredit_Load(Nothing, Nothing)
                    Else
                        MsgBox("User delete action failed")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    sql.Getconnect.Close()
                End Try

            End If
        End If
    End Sub 'delete user

    Private Sub LstAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstAccounts.SelectedIndexChanged
        If Not LstAccounts.SelectedValue = Nothing Then
            Label3.Visible = False
            txtadpas.Visible = False
            btnupdate.Visible = False

            Dim drs2() As DataRow = dt.Select("User_ID = " + LstAccounts.SelectedValue.ToString() + "")
            For Each dr2 As DataRow In drs2
                txtadmin.Text = dr2.Item(1) 'set username
                chknssf.Checked = dr2.Item(6)
                chkItax.Checked = dr2.Item(7)
                chkadmin.Checked = dr2.Item(4)
            Next
        End If
    End Sub

    Private Sub btnUpdateOtherAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateOtherAccount.Click 'update other users
        If LstAccounts.SelectedIndex <> -1 Then

            Dim pas2 As String = txtpas2.Text.Trim
            Dim salt As String = "hcetfavoltd"
            Dim rawSalted As String = salt & pas2
            Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
            Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
            Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
            Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

            If pas2.Length < 8 Then
                MessageBox.Show("Please enter password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpas.Focus()
            ElseIf txtpas.Text.Trim <> pas2 Then
                MessageBox.Show("Password mismatch", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpas.Focus()
            Else
                Try
                    Dim Stry As String = String.Format("update tblITaxAppPasswords set password={0},Admin ={1},Createdby={2},export_nssf={3}, export_itax={4} and Date_created={5} where user_id={6}", hashedPw, amAdmin, lbluser.Text, nssf, Itax, Now, LstAccounts.SelectedValue)
                    Dim cmd2 As New SqlCommand("update tblITaxAppPasswords set password=@pass2,Admin =@admin2,Createdby=@creator,export_nssf=@nssf,export_itax=@itax,Date_created=@time where user_id=@userid", sql.Getconnect)
                    cmd2.CommandType = CommandType.Text
                    cmd2.Parameters.Add("@admin2", SqlDbType.Bit).Value = amAdmin
                    cmd2.Parameters.Add("@creator", SqlDbType.VarChar).Value = lbluser.Text
                    cmd2.Parameters.Add("@nssf", SqlDbType.Bit).Value = nssf
                    cmd2.Parameters.Add("@itax", SqlDbType.VarChar).Value = Itax
                    cmd2.Parameters.Add("@time", SqlDbType.DateTime).Value = Now
                    cmd2.Parameters.Add("@pass2", SqlDbType.VarChar).Value = hashedPw
                    cmd2.Parameters.Add("@userid", SqlDbType.VarChar).Value = LstAccounts.SelectedValue
                    Dim affected As Integer = cmd2.ExecuteNonQuery()
                    If affected > 0 Then
                        MsgBox("Account update successful", MsgBoxStyle.Information)
                        txtpas.Text = ""
                        txtpas2.Text = ""
                    End If
                Catch ex As SqlException
                    MessageBox.Show(ex.ToString())
                End Try
            End If
            Label3.Visible = True
            txtadpas.Visible = True
        End If
    End Sub

    Dim nssf As Integer = 0
    Private Sub chknssf_CheckedChanged(sender As Object, e As EventArgs) Handles chknssf.CheckedChanged
        If chknssf.Checked = True Then
            nssf = 1
        Else
            nssf = 0
        End If
    End Sub
    Dim amAdmin As Integer = 0
    Private Sub chkadmin_CheckedChanged(sender As Object, e As EventArgs) Handles chkadmin.CheckedChanged
        If chkadmin.Checked = True Then
            amAdmin = 1
        Else
            amAdmin = 0
        End If
    End Sub
    Dim Itax As Integer = 0
    Private Sub chkItax_CheckedChanged(sender As Object, e As EventArgs) Handles chkItax.CheckedChanged
        If chkItax.Checked = True Then
            Itax = 1
        Else
            Itax = 0
        End If
    End Sub


End Class