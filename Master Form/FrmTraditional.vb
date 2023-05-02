Public Class FrmTraditional
    Sub PengaturanDGV()
        DGV.Columns(0).Width = 100
        DGV.Columns(1).Width = 100
        Me.DGV.Columns(6).Visible = False
        DGV.Columns(2).Width = 95
        DGV.Columns(3).Width = 280
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 100
        DGV.Columns(6).Width = 60
        DGV.Columns(4).DefaultCellStyle.Format = "C"
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(5).DefaultCellStyle.Format = "C"
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub BTProses_Click(sender As Object, e As EventArgs) Handles BTProses.Click
        Try
            If RBTempo.Checked Then
                Tabel = Proses.ExecuteQuery("Select PiutangTraditional.NoBukti, PiutangTraditional.Tgl, PiutangTraditional.JthTempo,PiutangTraditional.NmCust, PiutangTraditional.Total, PiutangTraditional.Sisa, PiutangTraditional.Status from PiutangTraditional where Selisih = '1' and lunas='0'and ChannelID='RG'")
                DGV.DataSource = Tabel
                Call PengaturanDGV()
            Else
                If RBKirim.Checked Then
                    Tabel = Proses.ExecuteQuery("Select PiutangTraditional.NoBukti, PiutangTraditional.TglKirim, PiutangTraditional.JthTempo,PiutangTraditional.NmCust, PiutangTraditional.Total, PiutangTraditional.Sisa, PiutangTraditional.Status from PiutangTraditional where SelisihKirim ='-14' and lunas='0'and ChannelID='RG'and Kirim='1'")
                    DGV.DataSource = Tabel
                    Call PengaturanDGV()
                End If
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam filter", MsgBoxStyle.Critical, "Konfirmasi")
        End Try

    End Sub



    Private Sub DGV_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DGV.RowPrePaint
        Try
            For t As Integer = 0 To DGV.Rows.Count - 1
                If Val(DGV.Rows(t).Cells("Sisa").Value < DGV.Rows(t).Cells("Total").Value) Then
                    DGV.Rows(t).DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       
    End Sub
  
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        For i As Integer = 0 To DGV.Rows.Count - 1
            If CInt(DGV.Rows(i).Cells("Status").Value Is DBNull.Value) Then
                DGV.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                DGV.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
            End If
        Next
    End Sub


 
    Private Sub FrmTraditional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class