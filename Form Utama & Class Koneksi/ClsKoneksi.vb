Imports System.Data.SqlClient
Imports System.Data

Public Class ClsKoneksi
    Protected SQL As String
    Protected Cn As OleDb.OleDbConnection
    Protected cmd As OleDb.OleDbCommand
    Protected Da As OleDb.OleDbDataAdapter
    Protected Ds As DataSet
    Protected Dt As DataTable
    Protected read As String

    Public Function OpenConn()
        Try
            Cn = New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=True;UID=SA;PWD=Shield@1945;Connect timeout=15;Initial Catalog='" & FrmUtama.DatabaseTextBox.Text & "';Data Source='" & FrmUtama.ServerTextBox.Text & "'")
            Cn.Open()
            If Cn.State <> ConnectionState.Open Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Function

    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub


    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi gagal", MsgBoxStyle.Critical, "Accses failed")
            Return Nothing
            Exit Function
        End If
        cmd = New OleDb.OleDbCommand(Query, Cn)
        Da = New OleDb.OleDbDataAdapter
        Da.SelectCommand = cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        cmd = Nothing
        CloseConn()

    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi gagal", MsgBoxStyle.Critical, "Accses failed")
            Exit Sub
        End If
        cmd = New OleDb.OleDbCommand(Query, Cn)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = Query
        cmd.ExecuteNonQuery()
        cmd = Nothing
        CloseConn()

    End Sub
End Class
