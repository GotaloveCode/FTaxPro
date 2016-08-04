Imports System.Data.SqlClient
Module CommonMod
    Public _user As String
    Public _user_id As Integer
    Public Class Common
        Public Function Getconnect() As SqlConnection
            'Dim document As XDocument = XDocument.Load("C:\Users\Martin\Documents\Visual Studio 2008\Projects\dbcon.xml")
            Dim document As XDocument = XDocument.Load(Application.CommonAppDataPath + "\\dbcon.xml")
            Dim title = From t In document.Descendants("ServerName") Select t.Value
            Dim ServerName1 = title.First()
            Dim title2 = From t In document.Descendants("DatabaseName") Select t.Value
            Dim DatabaseName1 = title2.First()
            Dim title3 = From t In document.Descendants("UserID") Select t.Value
            Dim UserID1 = title3.First()
            Dim title4 = From t In document.Descendants("Password") Select t.Value
            Dim password1 = title4.First()
            Dim con As New SqlConnection("Server=" & ServerName1 & ";Database=" & DatabaseName1 & ";User ID=" & UserID1 & ";Password=" & password1 & ";")
            con.Open()
            Return con
        End Function 'SQLCONNECTION
    End Class
End Module