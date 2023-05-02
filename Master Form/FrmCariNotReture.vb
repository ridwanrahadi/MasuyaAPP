Public Class FrmCariNotReture

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If Me.Text = "Cari Nota Reture Beli" Then
            Try
                If txtPKP.Text = "" Then
                    Tabel = Proses.ExecuteQuery("SELECT NoReture,tanggal,PKP,NoFp,TglFp,NoJl,Npwp,Total,ppn from tblnotretbl where tanggal >='" & Dt1.Text & "' and tanggal <='" & Dt2.Text & "'")
                Else
                    Tabel = Proses.ExecuteQuery("SELECT NoReture,tanggal,PKP,NoFp,TglFp,NoJl,Npwp,Total,ppn from tblnotretbl where tanggal >='" & Dt1.Text & "' and tanggal <='" & Dt2.Text & "' and PKP like '%" & txtPKP.Text & "%'")
                End If
                DataGridView1.DataSource = Tabel
                DataGridView1.Columns(7).DefaultCellStyle.Format = "C"
                DataGridView1.Columns(8).DefaultCellStyle.Format = "C"
                DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.DataGridView1.Columns(2).Frozen = True
            Catch ex As Exception

            End Try
        Else
            Try
                If txtPKP.Text = "" Then
                    Tabel = Proses.ExecuteQuery("SELECT NoReture,tanggal,PKP,NoFp,TglFp,NoJl,Npwp,Total,ppn from tblnotaret where tanggal >='" & Dt1.Text & "' and tanggal <='" & Dt2.Text & "'")
                Else
                    Tabel = Proses.ExecuteQuery("SELECT NoReture,tanggal,PKP,NoFp,TglFp,NoJl,Npwp,Total,ppn from tblnotaret where tanggal >='" & Dt1.Text & "' and tanggal <='" & Dt2.Text & "' and PKP like '%" & txtPKP.Text & "%'")
                End If
                DataGridView1.DataSource = Tabel
                DataGridView1.Columns(7).DefaultCellStyle.Format = "C"
                DataGridView1.Columns(8).DefaultCellStyle.Format = "C"
                DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.DataGridView1.Columns(2).Frozen = True
            Catch ex As Exception

            End Try
        End If
        

    End Sub
End Class