
Imports System.Linq
Imports System.Collections.Generic
Imports System.Data
Imports System.Text
Imports System.IO

Public Class ExcelMerger


    Dim Csv As New Exporter()
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Dim dt4 As New DataTable
    Dim dt5 As New DataTable


    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim prnfile1 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax\Employee PIN Numbers.prn"
        Dim prnfile2 As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax\Employee Transactions.prn"
        Me.Cursor = Cursors.WaitCursor
        'For i As Integer = 0 To 100
        '    ProgressBar1.Value = i
        'Next
        Dim frmprogress As New progress
        Try
            frmprogress.Show()

            If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax") Then
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax")
                If Not File.Exists(prnfile1) Then
                    MessageBox.Show("Ensure file exists" & prnfile1, "File missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    frmprogress.Close()
                    Exit Sub
                End If
                If Not File.Exists(prnfile2) Then

                    MessageBox.Show("Ensure file exists" & prnfile2, "File missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            'get rid of header file in Employee Transactions
            Dim arrText() As String
            Dim sLine As String = ""

            arrText = File.ReadAllLines(prnfile2)
            prnfile2 = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax\Employee Transactions2.prn"
            Using objWriter As StreamWriter = New StreamWriter(prnfile2)
                For I As Integer = 1 To arrText.Length - 1
                    objWriter.WriteLine(arrText(I))
                Next
            End Using


            dt1 = readerToTable(",", prnfile1)

            dt2 = readerToTable(vbTab, prnfile2)

            dt4 = dt1.Clone

            dt4.Columns(2).DataType = GetType(Double) 'Basic Pay Kshs
            dt4.Columns(3).DataType = GetType(Double) 'Benefits Non cash Kshs
            dt4.Columns(7).DataType = GetType(Double) 'Defined Contribution Benefit Calculation Kshs Actual Cont
            dt4.Columns(13).DataType = GetType(Double) 'Monthly Relief + Insurance Relief Kshs
            dt4.Columns(14).DataType = GetType(Double) 'Insurance Relief
            dt4.Columns.Add("PersonalRelief", GetType(Double))
            dt4.Columns("PersonalRelief").Expression = "[Monthly Relief + Insurance Relief Kshs] - [Insurance Relief]"

            For Each row As DataRow In dt1.Rows
                ''row("Basic Pay Kshs") = Double.Parse(row("Basic Pay Kshs").ToString())
                dt4.ImportRow(row)
            Next

            dt1 = New DataTable
            dt1 = dt2.Clone

            Dim j As Integer
            j = dt1.Columns.IndexOf("Basic Pay")
            dt1.Columns(j).DataType = GetType(Double) 'basic pay
            j = dt1.Columns.IndexOf("PAYE")
            dt1.Columns(j).DataType = GetType(Double) 'PAYE

            j = dt1.Columns.IndexOf("House Allowance")
            If j <> -1 Then 'if house allowance exists
                dt1.Columns(j).DataType = GetType(Double) 'House Allowance
                For Each row As DataRow In dt2.Rows
                    dt1.ImportRow(row)
                Next

                Dim query = (From t1 In dt4.AsEnumerable() _
                Join t2 In dt1.AsEnumerable() _
                On t1.Field(Of String)("Employee's NAME") Equals _
                        t2.Field(Of String)("Name") _
                Select New With _
                { _
                     .PIN = t1.Field(Of String)("Employee's PIN"), _
                     .Name = t1.Field(Of String)("Employee's NAME"), _
                     .Residential_Status = "Resident", _
                     .Type_Of_Employmee = "Primary Employee", _
                     .BasicPay = t2.Field(Of Double)("Basic Pay"), _
                     .HouseAllowance = t2.Field(Of Double)("House Allowance"), _
                     .TransportAllowance = 0, _
                     .LeavePay = 0, _
                     .OvertimeAllowance = 0, _
                     .DirectorFee = 0, _
                     .LumpSum = 0, _
                     .OtherAllowance = (t1.Field(Of Double)("Basic pay Kshs") - t2.Field(Of Double)("Basic Pay") - t2.Field(Of Double)("House Allowance")), _
                     .TotalCashPay = "", _
                     .CarBenefitValue = 0, _
                     .OtherNonCash_Benefits = t1.Field(Of Double)("Benefits Non cash Kshs"), _
                     .TotalNonCash_Benefits = "", _
                     .GlobalIncome = 0, _
                     .Type_Of_Housing = "Benefit not given", _
                     .Rent = "", _
                     .ComputedRent = "", _
                     .RentRecovered = "", _
                     .NetHousing = "", _
                     .GrossPay = "", _
                     .Pay30 = "", _
                     .ActualContribution = t1.Field(Of Double)("Defined Contribution Benefit Calculation Kshs Actual Cont"), _
                     .PermLmt = "", _
                     .MortInt = 0, _
                     .HOSP = 0, _
                     .benefit = "", _
                     .TaxPay = "", _
                     .Slabrate = "", _
                     .PersonalRelief = t1.Field(Of Double)("PersonalRelief"), _
                     .InsuranceRelief = t1.Field(Of Double)("Insurance Relief"), _
                     .PayeTaxe = "", _
                     .PAYE = t2.Field(Of Double)("PAYE") _
                }).ToList()
                dt3 = Csv.ConvertToDataTable(query)
            Else
                For Each row As DataRow In dt2.Rows
                    dt1.ImportRow(row)
                Next

                Dim query = (From t1 In dt4.AsEnumerable() _
                Join t2 In dt1.AsEnumerable() _
                On t1.Field(Of String)("Employee's NAME") Equals _
                        t2.Field(Of String)("Name") _
                Select New With _
                { _
                     .PIN = t1.Field(Of String)("Employee's PIN"), _
                     .Name = t1.Field(Of String)("Employee's NAME"), _
                     .Residential_Status = "Resident", _
                     .Type_Of_Employmee = "Primary Employee", _
                     .BasicPay = t2.Field(Of Double)("Basic Pay"), _
                     .HouseAllowance = 0, _
                     .TransportAllowance = 0, _
                     .LeavePay = 0, _
                     .OvertimeAllowance = 0, _
                     .DirectorFee = 0, _
                     .LumpSum = 0, _
                     .OtherAllowance = (t1.Field(Of Double)("Basic pay Kshs") - t2.Field(Of Double)("Basic Pay")), _
                     .TotalCashPay = "", _
                     .CarBenefitValue = 0, _
                     .OtherNonCash_Benefits = t1.Field(Of Double)("Benefits Non cash Kshs"), _
                     .TotalNonCash_Benefits = "", _
                     .GlobalIncome = 0, _
                     .Type_Of_Housing = "Benefit not given", _
                     .Rent = "", _
                     .ComputedRent = "", _
                     .RentRecovered = "", _
                     .NetHousing = "", _
                     .GrossPay = "", _
                     .Pay30 = "", _
                     .ActualContribution = t1.Field(Of Double)("Defined Contribution Benefit Calculation Kshs Actual Cont"), _
                     .PermLmt = "", _
                     .MortInt = 0, _
                     .HOSP = 0, _
                     .benefit = "", _
                     .TaxPay = "", _
                     .Slabrate = "", _
                     .PersonalRelief = t1.Field(Of Double)("PersonalRelief"), _
                     .InsuranceRelief = t1.Field(Of Double)("Insurance Relief"), _
                     .PayeTaxe = "", _
                     .PAYE = t2.Field(Of Double)("PAYE") _
                }).ToList()
                dt3 = Csv.ConvertToDataTable(query)
            End If

            dt2 = Nothing
            dt1 = Nothing
            dt4 = Nothing
            DataGridView1.DataSource = dt3
            Dim fpath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Favotax\ITaxResults.csv"
            Using CsvWriter As New StreamWriter(fpath)
                CsvWriter.Write(Csv.CsvFromDatatable(dt3))
            End Using
            System.Diagnostics.Process.Start(fpath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If frmprogress.Visible Then
                frmprogress.Close()
            End If
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Function readerToTable(del As String, fp As String) As DataTable
        Dim SR As StreamReader = New StreamReader(fp)
        Dim line As String = SR.ReadLine()
        Dim strArray As String() = line.Split(del)
        Dim dt As New DataTable
        Dim row As DataRow

        For Each s As String In strArray
            dt.Columns.Add(New DataColumn(s))
        Next

        Do
            line = SR.ReadLine
            If Not line = String.Empty Then
                row = dt.NewRow()
                row.ItemArray = line.Split(del)
                dt.Rows.Add(row)
            Else
                Exit Do
            End If
        Loop
        Return dt
    End Function

#Region "Toolstrip Menu"
    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Dispose()
    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        'Dim createaccount As New Form2
        'Me.Hide()
        'createaccount.Show()
        'Me.Close()
    End Sub
    Private Sub ManageAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageAccountToolStripMenuItem.Click
        'Dim editaccount As New useredit
        'Me.Hide()
        'editaccount.Show()
        'Me.Close()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region ' - Toolstrip Menu


    Private Sub ExcelMerger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbluser.Text = _user
    End Sub
End Class