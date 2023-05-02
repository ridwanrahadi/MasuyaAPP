Public Class FrmEdit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tabel = Proses.ExecuteQuery("select * from tbltemp")

        Try
            For baris As Integer = 0 To Tabel.Rows.Count - 1
                SQl = "update tblcustomer set kdsales='" & Tabel.Rows(baris).Item("sales") & "' where KdCust='" & Tabel.Rows(baris).Item("KdCust") & "'"
                Proses.ExecuteNonQuery(SQl)
            Next baris
            MsgBox("selesai")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       

    End Sub
End Class