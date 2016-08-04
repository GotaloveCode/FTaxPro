Option Strict On
Imports System.Data.SqlClient
Imports System.IO
Public Class license
    Dim dbcon As New Common
    Private kstrRegSubKeyName As String = "Favotech\\F-TaxPro" 'The name for the sub-key to store registry info
    Private mintUsedTrialDays As Integer
    Private mintTrialPeriod As Integer = 5 'Days in the trial.
    Private mblnInTrial As Boolean = True
    Private mblnFullVersion As Boolean = False

    Private Structure CurrentDate
        Dim Day As String
        Dim Month As String
        Dim Year As String
    End Structure


#Region " - Validate key - "

    Private Sub btnTestKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestKey.Click
        lblVKStatus.Visible = True
        lblVKStatus.Text = ""
        Dim strRegCode As String = Me.txtKeyToValidate.Text.ToUpper
        Dim strPassPhrase As String = txtPassPhrase.Text
        Dim strUserName As String = Encrypt(strPassPhrase, txtVKClientName.Text.ToUpper)
        strUserName = strUserName.Remove(16, (strUserName.Length - 16))
        strRegCode = strRegCode.Replace("-", "")
        If strUserName = strRegCode Then
            AuthorizeComputer(strPassPhrase, txtVKClientName.Text.ToUpper, strRegCode)
        Else
            lblVKStatus.Text = "The name and the key entered appears to be incorrect!"
        End If
    End Sub

    Private Function AuthorizeComputer(ByVal pPassPhrase As String, ByVal pUsername As String, ByVal pRegCode As String) As Boolean
        Try
            Dim strMotherboardID As String = Encrypt(pPassPhrase, cHardware.GetMotherBoardID.Trim)
            Dim oReg As Microsoft.Win32.RegistryKey
            oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
            oReg = oReg.CreateSubKey(kstrRegSubKeyName)
            oReg.SetValue("USERID", Encrypt(pPassPhrase, pUsername))
            oReg.SetValue("LOCALPATH", Encrypt(pPassPhrase, pRegCode))
            oReg.SetValue("Enabled", "")
            'Store these two values, the program will check for matches on each run.
            'Just to be safe. :P
            oReg.SetValue("CompID", strMotherboardID)
            oReg.Close()
            MessageBox.Show("The license of your application is now saved.", "FavoTax Licensing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoginForm1.Show()
            Me.Hide()
            Return True
        Catch ex As Exception
            MessageBox.Show("Impossible to save license info", "FavoTax Licensing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region ' - Validate key - 

#Region " - Common methods - "

    Private Function Encrypt(ByRef pPassPhrase As String, ByVal pTextToEncrypt As String) As String
        If pPassPhrase.Length > 16 Then
            'limitation of the encryption mechanism
            pPassPhrase = pPassPhrase.Substring(0, 16)
        End If

        If pTextToEncrypt.Trim.Length = 0 Then
            'the Text to encrypt not set!!!
            Return String.Empty
        End If

        Dim skey As New Encryption.Data(pPassPhrase)
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
        Dim objEncryptedData As Encryption.Data
        objEncryptedData = sym.Encrypt(New Encryption.Data(pTextToEncrypt), skey)
        Return objEncryptedData.ToHex
    End Function

    Private Function Decrypt(ByRef pPassPhrase As String, ByVal pHexStream As String) As String
        Try
            Dim objSym As New Encryption.Symmetric(Encryption.Symmetric.Provider.Rijndael)
            Dim encryptedData As New Encryption.Data
            encryptedData.Hex = pHexStream
            Dim decryptedData As Encryption.Data
            decryptedData = objSym.Decrypt(encryptedData, New Encryption.Data(pPassPhrase))
            Return decryptedData.Text
        Catch
            Return Nothing
        End Try
    End Function

#End Region ' - Common methods - 

#Region " - Application status - "
    Private Sub license_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regdata()
        Dim oReg As Microsoft.Win32.RegistryKey
        oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
        oReg = oReg.CreateSubKey(kstrRegSubKeyName)
        oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" & kstrRegSubKeyName)
        Dim strOldDay As String = oReg.GetValue("UserSettings", "").ToString
        Dim strOldMonth As String = oReg.GetValue("operatingsystem", "").ToString
        Dim strOldYear As String = oReg.GetValue("GUID", "").ToString
        Dim strRegName As String = oReg.GetValue("USERID", "").ToString
        Dim strRegCode As String = oReg.GetValue("LOCALPATH", "").ToString
        Dim strCompID As String = oReg.GetValue("CompID", "").ToString
        Dim strTrialDone As String = oReg.GetValue("Enable", "").ToString
        oReg.Close()

        'If the keys should automatically be created, then create them.
        If strOldDay = "" Then
            CreateRegKeys(txtPassPhrase.Text)
        End If

        'If the keys are encrypted, decrypt them.
        'If EncryptKeys = True Then
        strOldDay = Decrypt(txtPassPhrase.Text, strOldDay)
        strOldMonth = Decrypt(txtPassPhrase.Text, strOldMonth)
        strOldYear = Decrypt(txtPassPhrase.Text, strOldYear)
        'End If

        'Define global variables.
        mintUsedTrialDays = DiffDate(strOldDay, strOldMonth, strOldYear)

        'Fill the progress bar
        lblApplicationStatus.Text = DisplayApplicationStatus(DiffDate(strOldDay, strOldMonth, strOldYear), mintTrialPeriod)

        'Disable the continue button if the trial is over
        If DiffDate(strOldDay, strOldMonth, strOldYear) > mintTrialPeriod Then
            'unregbutton.Enabled = False
            mblnInTrial = False
            oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
            oReg = oReg.CreateSubKey(kstrRegSubKeyName)
            oReg.SetValue("Enable", "1")
            oReg.Close()
        End If

        'If the date is earlier than possible, then disable the program.
        If strOldMonth = "" Then
        Else
            Dim dtmOldDate As Date = New Date(Convert.ToInt32(strOldYear), Convert.ToInt32(strOldMonth), Convert.ToInt32(strOldDay))
            If Date.Compare(DateTime.Now, dtmOldDate) < 0 Then
                'unregbutton.Enabled = False
                mblnInTrial = False
                oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
                oReg = oReg.CreateSubKey(kstrRegSubKeyName)
                oReg.SetValue("Enable", "1")
                oReg.Close()
            End If
        End If


        'If the trial is done then disable the button
        If strTrialDone = "1" Then
            'unregbutton.Enabled = False
            mblnInTrial = False
            lblApplicationStatus.Text = "The system clock has been manually changed, and the application has been locked out to prevent unauthorized access!"
        End If

        'See if the user is already registered, if so re-process the info and check if the computer is all okay.
        If strRegName = "" Then
        Else
            Dim strRN As String = Decrypt(txtPassPhrase.Text, strRegName)
            Dim strRC As String = Decrypt(txtPassPhrase.Text, strRegCode)
            Dim UserName As String = strRegName
            UserName = UserName.Remove(16, (UserName.Length - 16))
            If UserName = Decrypt(txtPassPhrase.Text, strRegCode) Then
                If Encrypt(txtPassPhrase.Text, cHardware.GetMotherBoardID.Trim.ToString) = strCompID Then
                    mblnInTrial = False
                    mblnFullVersion = True

                    strRC = strRC.Insert(4, "-")
                    strRC = strRC.Insert(8, "-")
                    strRC = strRC.Insert(12, "-") 'Add dashes to make it look cool

                    lblApplicationStatus.Text = "Licensed version to " + strRN + " with the key " + strRC
                    oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
                    oReg = oReg.CreateSubKey(kstrRegSubKeyName)
                    oReg.SetValue("Enable", "")
                    oReg.Close()
                    LoginForm1.Show()

                End If

            End If
        End If
    End Sub

    Private Function DisplayApplicationStatus(ByVal pDaysUsed As Integer, ByVal pTotalDays As Integer) As String
        'Check if the author made the mistake of setting the trial period days to less than 0
        If pTotalDays < 0 Then
            Return "An error has occurred! The author has alloted you a trial period less than zero days, which is impossible. Please contact the author and tell him/her of this error."
        End If

        'Check if the trial is expired
        If pDaysUsed >= pTotalDays Then
            Return "Your trial has expired!"
            Me.Dispose()
        End If

        'Draw the bar
        'Return "You have " + (pTotalDays - pDaysUsed).ToString + " days remaining in your free trial period."
        Return "Please provide your license to activate this application"
    End Function

    Private Sub CreateRegKeys(ByVal pPassPhrase As String)
        Try
            Dim Current As CurrentDate
            Current.Day = DateTime.Now.Day.ToString
            Current.Month = DateTime.Now.Month.ToString
            Current.Year = DateTime.Now.Year.ToString
            'If EncryptKeys = True Then
            Current.Day = Encrypt(pPassPhrase, Current.Day)
            Current.Month = Encrypt(pPassPhrase, Current.Month)
            Current.Year = Encrypt(pPassPhrase, Current.Year)
            'End If
            Dim oReg As Microsoft.Win32.RegistryKey
            oReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True)
            oReg = oReg.CreateSubKey(kstrRegSubKeyName)
            oReg.SetValue("UserSettings", Current.Day)
            oReg.SetValue("operatingsystem", Current.Month)
            oReg.SetValue("GUID", Current.Year)
            oReg.Close()
        Catch
        End Try
    End Sub
    Private Function DiffDate(ByVal OrigDay As String, ByVal OrigMonth As String, ByVal OrigYear As String) As Integer
        Try
            Dim D1 As Date = New Date(Convert.ToInt32(OrigYear), Convert.ToInt32(OrigMonth), Convert.ToInt32(OrigDay))
            Return Convert.ToInt32(DateDiff(DateInterval.Day, D1, DateTime.Now))
        Catch
            Return 0
        End Try
    End Function
#End Region ' - Application status - 
#Region "- dbcon -"
    Private Sub regdata()
        'Dim cmd As New SqlCommand("IF OBJECT_ID (N'CompanyDetails', N'U') IS NOT NULL " & _
        '  "SELECT PINNumber from CompanyDetails", dbcon.Getconnect)
        'Dim dr As SqlDataReader = cmd.ExecuteReader()
        'If dr.HasRows Then
        '    Do While dr.Read
        '        txtPassPhrase.Text = dr.GetString(0)
        '    Loop

        'End If
        'dbcon.Getconnect.Close()
        Dim passfile As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData + "\FTL\FTaxPro.txt"
        If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData + "\FTL") Then
            Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData + "\FTL")
            If Not File.Exists(passfile) Then
                Using sw As New StreamWriter(File.Open(passfile, FileMode.OpenOrCreate))
                    sw.WriteLine(DateTime.Now & " Initial Attempt to register", True)
                End Using
            Else 'just use the pin to encrypt
                Using sr As New StreamReader(passfile)
                    Dim line As String = sr.ReadToEnd()
                    txtPassPhrase.Text = line
                End Using
            End If
        Else
            If Not File.Exists(passfile) Then
                Using sw As New StreamWriter(File.Open(passfile, FileMode.OpenOrCreate))
                    sw.WriteLine(DateTime.Now & " another Attempt to register failed", True)
                End Using
            Else 'just use the pin to encrypt
                Using sr As New StreamReader(passfile)
                    Dim line As String = sr.ReadToEnd()
                    txtPassPhrase.Text = line
                End Using
            End If
        End If
    End Sub
#End Region '- dbcon end -

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class
