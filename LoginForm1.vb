Imports System.Data.SqlClient
Public Class LoginForm1
    Dim dbcon As New Common

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String = txtuser.Text.Trim
        Dim pass As String = txtpass.Text.Trim
        Dim salt As String = "hcetfavoltd"
        'Create the salted hash.
        Dim rawSalted As String = salt & pass
        Dim saltedPwBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider()
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)
        If user = "" Then
            MessageBox.Show("Please Enter Your Username !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pass = "" Then
            MessageBox.Show("Please Enter Your Password !", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Dim cmd As New SqlCommand("select User_Name,user_id,Password from tblITaxAppPasswords where User_Name = @user and [Password] = @pass", dbcon.Getconnect)
            'cmd.CommandType = CommandType.Text
            'cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user
            'cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw
            Try
                If user = "Ramen" AndAlso pass = "japanese" Then
                    Dim f As New ExcelMerger
                    Me.Hide()
                    f.Show()
                    Me.Close()
                End If

                'Dim dr As SqlDataReader = cmd.ExecuteReader
                'If dr.HasRows = True Then
                '    dr.Read()
                '    If user = dr.Item("User_Name").ToString And hashedPw = dr.Item("Password").ToString Then
                '        Dim f As New ExcelMerger
                '        _user_id = dr.Item("user_id")
                '        _user = user
                '        Me.Hide()
                '        f.Show()
                '        Me.Close()
                '    ElseIf user.ToLower = dr.Item("User_Name").ToString.ToLower And txtpass.Text.ToLower = dr.Item("Password").ToString.ToLower Then
                '        MessageBox.Show("Login Failed." & Environment.NewLine & _
                '                             "Username and password are casesensitive.", _
                '                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End If
                'Else
                '    MessageBox.Show("Login Failed." & Environment.NewLine & _
                '                             "No credentials matched", _
                '                            Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'dbcon.Getconnect.Close()
            End Try
        End If

    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub logindata()
        Dim cmd As New SqlCommand("IF OBJECT_ID (N'tblITaxAppPasswords', N'U') IS NOT NULL " & _
             "SELECT * from tblITaxAppPasswords else CREATE TABLE [dbo].[tblITaxAppPasswords]( " & _
           "[User_ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL," & _
           "[User_Name] [nvarchar](50) NULL," & _
           "[Password] [nvarchar](50) NULL," & _
           "[Date_created] [smalldatetime] NULL,[Admin] [bit] NOT null,[Createdby] [nvarchar](50) NULL,[export_nssf] [bit] NOT NULL,[export_itax] [bit] NOT NULL)", dbcon.Getconnect)
        cmd.ExecuteNonQuery()
        dbcon.Getconnect.Close()
        Dim cmd2 As New SqlCommand("if not exists (select * from tblITaxAppPasswords where User_Name ='FTL' and Password ='U8SbMVH14NOXSM5f3H7RBVYwHA0=' )insert into tblITaxAppPasswords ([User_Name],[Password],[Date_created],[Admin],[Createdby],[export_nssf],[export_itax])values ('FTL','U8SbMVH14NOXSM5f3H7RBVYwHA0=',CURRENT_TIMESTAMP,1,'FTL',1,1)", dbcon.Getconnect)
        cmd2.ExecuteNonQuery()
        dbcon.Getconnect.Close()


    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'logindata()
        'license.Close()

    End Sub

End Class
