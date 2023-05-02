Public Class FrmRPB

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click


        If TextBox1.Text = "" Then
            MsgBox("Nomor Faktur belum di isi !!", MsgBoxStyle.Exclamation, "Konfirmasi")
        Else
            Try
                Tabel = Proses.ExecuteQuery("select * from tblRekapKirimInvoices WHERE NoFaktur = '" & TextBox1.Text & "'")
                If Tabel.Rows.Count > 0 Then
                    Dim result As DialogResult = MessageBox.Show("Apakah data ini akan di hapus ?", "Konfirmasi", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Try
                            SQl = "DELETE FROM tblRekapKirimInvoices WHERE NoFaktur = '" & TextBox1.Text & "'"
                            Proses.ExecuteNonQuery(SQl)
                            MsgBox("Hapus berhasil", MsgBoxStyle.Information, "Konfirmasi")
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    ElseIf result = DialogResult.No Then
                        TextBox1.Focus()
                    End If

                Else
                    MsgBox("Nomor Faktur ini tidak ada", MsgBoxStyle.Exclamation, "Konfirmasi")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            
        End If
        

    End Sub

  
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnDelete.Focus()
        End If
    End Sub
End Class