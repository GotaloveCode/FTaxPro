Imports System.Data.SqlClient
Public Class Form2

    Dim sql As New Common

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        Dim adm As String = txtadmin.Text.Trim
        Dim usr As String = txtusr.Text.Trim
        Dim pas As String = txtpas.Text.Trim
        Dim salt As String = "hcetfavoltd"
        Dim rawSalted As String = salt & pas
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)
        Dim nssfExport As Integer = 0
        Dim itaxExport As Integer = 0
        Dim admin As Integer = 0
        If chknssf.Checked = True Then
            nssfExport = 1 'assign 1 to indicate checked
        End If
        If chkItax.Checked = True Then
            itaxExport = 1
        End If
        If ChkAdmin.Checked = True Then
            admin = 1
        End If

        If usr.Length = 0 Then
            MessageBox.Show("Please enter Username", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas.Length < 8 Then
            MessageBox.Show("Please enter password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pas.Length < 8 Then
            MessageBox.Show("Please enter confirm password at least 8 characters", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpas.Text <> txtpas2.Text Then
            MessageBox.Show("Password mismatch", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cmd As New SqlCommand("select User_Name,Password from tblITaxAppPasswords where User_Name =@user", sql.Getconnect) 'check for username only to avoid duplicate user with diff pass
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = usr
            Try
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows = True Then
                    MessageBox.Show("User account already exists", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtusr.Text = ""
                    txtpas.Text = ""
                    txtpas2.Text = ""
                Else
                    Dim cmd2 As New SqlCommand("insert into tblITaxAppPasswords([User_Name],[Password],[Date_created],[Admin],[Createdby],export_nssf,export_itax)values (@user,@pass,CURRENT_TIMESTAMP,@adstatus,@creator,@exnssf,@exitax)", sql.Getconnect)
                    cmd2.CommandType = CommandType.Text
                    cmd2.Parameters.Add("@user", SqlDbType.VarChar).Value = usr
                    cmd2.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
                    cmd2.Parameters.Add("@adstatus", SqlDbType.VarChar).Value = admin
                    cmd2.Parameters.Add("@creator", SqlDbType.VarChar).Value = adm
                    cmd2.Parameters.Add("@exnssf", SqlDbType.VarChar).Value = nssfExport
                    cmd2.Parameters.Add("@exitax", SqlDbType.VarChar).Value = itaxExport
                    cmd2.ExecuteNonQuery()
                    MessageBox.Show("User Registration successful.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusr.Clear()
                    txtpas.Clear()
                    txtpas2.Clear()
                    txtadmin.Clear()
                    txtadpas.Clear()
                    ChkAdmin.CheckState = CheckState.Unchecked
                    chkItax.CheckState = CheckState.Unchecked
                    chknssf.CheckState = CheckState.Unchecked
                    Panel3.Enabled = False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                sql.Getconnect.Close()
            End Try
        End If
    End Sub 'BTNCREATE ACCOUNT

    Private Sub btnvalidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvalidate.Click

        Dim adm As String = txtadmin.Text.Trim
        Dim adpas As String = txtadpas.Text.Trim
        Dim salt As String = "hcetfavoltd"
        Dim rawSalted As String = salt & adpas
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedadPw As String = Convert.ToBase64String(hashedPwBytes)
        Dim cmd As New SqlCommand("select User_Name,Password from tblITaxAppPasswords where User_Name =@user and Password = @pass and admin = 1", sql.Getconnect)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = adm
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedadPw
        Try
            Dim readr As SqlDataReader = cmd.ExecuteReader
            If readr.HasRows Then
                Panel3.Enabled = True
                MessageBox.Show("Admin " + adm + " valid" & Environment.NewLine & "Proceed to create account", "Admin Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The account " + adm + " is not a valid admin account", "Admin Validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Panel3.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sql.Getconnect.Close()
        End Try
    End Sub 'VALIDATE ISADMIN

#Region " TOOLSTRIPMENU "
    Private Sub ManageAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        Dim editaccount As New useredit
        Me.Hide()
        editaccount.Show()
        Me.Close()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Hide()
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub ITAXEXPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITAXEXPORTToolStripMenuItem.Click
        Dim f As New ExcelMerger
        Me.Hide()
        f.Show()
        Me.Close()
    End Sub
#End Region 'TOOLSTRIPMENU

 
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtadmin.Clear()
        txtadpas.Clear()
    End Sub

    Private Sub btncancel2_Click(sender As Object, e As EventArgs) Handles btncancel2.Click
        txtusr.Clear()
        txtpas.Clear()
        txtpas2.Clear()
        ChkAdmin.Checked = False
        chkItax.Checked = False
        chknssf.Checked = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser.Text = _user

        If sql.Getconnect.State = ConnectionState.Open Then
            sql.Getconnect.Close()
        End If

    End Sub


End Class