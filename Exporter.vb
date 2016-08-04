Imports System.Text
Imports System.Data.OleDb
Imports System.ComponentModel
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Exporter
    Public Sub New()
        TextDelimiter = ","c
    End Sub
    Private _TextDelimiter As Char
    Public Property TextDelimiter() As Char
        Get
            Return _TextDelimiter
        End Get
        Set(ByVal value As Char)
            _TextDelimiter = value
        End Set
    End Property

    Public Function CsvFromDatatable(ByVal InputTable As DataTable) As String
        Dim CsvBuilder As New StringBuilder()
        CreateRows(InputTable, CsvBuilder)
        Return CsvBuilder.ToString()
    End Function
    Private Sub CreateRows(ByVal InputTable As DataTable, ByVal CsvBuilder As StringBuilder)
        For Each ExportRow As DataRow In InputTable.Rows
            For Each ExportColumn As DataColumn In InputTable.Columns
                Dim ColumnText As String = ExportRow(ExportColumn.ColumnName).ToString()
                CsvBuilder.Append(ColumnText)
                CsvBuilder.Append(TextDelimiter)
            Next
            CsvBuilder.AppendLine()
        Next
    End Sub
    Public Function ConvertToDataTable(Of T)(data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        table.AcceptChanges()
        Return table
    End Function
    Public Function ImportExcelXLS(FileName As String, hasHeaders As Boolean) As DataTable
        Dim da As New OleDbDataAdapter()
        Dim HDR As String = If(hasHeaders, "Yes", "No")
        Dim strConn As String
        If FileName.Substring(FileName.LastIndexOf("."c)).ToLower() = ".xlsx" Then
            strConn = (Convert.ToString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=""Excel 12.0;HDR=") & HDR) + ";IMEX=0"""
        ElseIf FileName.Substring(FileName.LastIndexOf("."c)).ToLower() = ".csv" Then
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FileName & ";Extended Properties=""text;HDR=Yes;FMT=Delimited"";"
        Else
            strConn = (Convert.ToString("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=""Excel 8.0;HDR=") & HDR) + ";IMEX=0"""
        End If
        Dim output As New DataTable()

        Using conn As New OleDbConnection(strConn)
            conn.Open()

            Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

            For Each schemaRow As DataRow In schemaTable.Rows
                Dim sheet As String = schemaRow("TABLE_NAME").ToString()

                If Not sheet.EndsWith("_") Then
                    Try
                        Dim cmd As New OleDbCommand((Convert.ToString("SELECT * FROM [") & sheet) + "]", conn)
                        cmd.CommandType = CommandType.Text
                        da.SelectCommand = cmd
                        da.Fill(output)
                    Catch ex As Exception
                        Throw New Exception(ex.Message + String.Format("Sheet:{0}.File:F{1}", sheet, FileName), ex)
                    End Try
                End If
            Next
        End Using


        Return output

    End Function
End Class 'EXPORT TO CSV EXCEL CLASS
