Public Class FrmIsiFPBL

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If txtNoBL.Text = "" Then
            MsgBox("Isi kolom BL", MsgBoxStyle.Exclamation, "Pesan")
            txtNoBL.Focus()
        Else
            Try
                Tabel = Proses.ExecuteQuery("select NoBukti from tblBeli where NoBukti='" & txtNoBL.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("No Bukti tidak ditemukan", MsgBoxStyle.Exclamation, "Pesan")
                Else
                    SQl = "update tblbeli set NoFP='" & txtNoFP.Text & "',TglFP='" & DtFP.Text & "',TglSPM='" & DtSPM.Text & "' where NoBukti='" & txtNoBL.Text & "' "
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Berhasil di update", MsgBoxStyle.Information, "Pesan")
                    txtNoBL.Text = ""
                    txtNoFP.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
           
        End If

       

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If txtNoBL.Text = "" Then
            MsgBox("Isi kolom BL", MsgBoxStyle.Exclamation, "Pesan")
            txtNoBL.Focus()
        Else
            Try
                Tabel = Proses.ExecuteQuery("select NoBukti from tblBeli where NoBukti='" & txtNoBL.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("No Bukti tidak ditemukan", MsgBoxStyle.Exclamation, "Pesan")
                Else
                    SQl = "update tblbeli set NoFP='',TglFP=NULL,TglSPM=NULL where NoBukti='" & txtNoBL.Text & "' "
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Berhasil di delete", MsgBoxStyle.Information, "Pesan")
                    txtNoBL.Text = ""
                    txtNoFP.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            
        End If

       
    End Sub
End Class