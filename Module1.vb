Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection
    Public cm As New SqlCommand
    Public dr As SqlDataReader

    Sub Connection()
        Try
            cn = New SqlConnection
            cn.ConnectionString = "Data Source=AMANI-KJB\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Module
