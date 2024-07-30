Imports Microsoft.Reporting.WinForms
Public Class FrmLabelValet

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        If txtBL.Text = "" Or txtKdBrg.Text = "" Then
            MsgBox("Isi kolom BL atau kolom kode barang masih kosong", MsgBoxStyle.Information, "Konfirmasi")
        Else
            Try
                Tabel = Proses.ExecuteQuery("select NoBukti,KdBrg from tblBeliDtl where Kdbrg='" & txtKdBrg.Text & "' and NoBukti='" & txtBL.Text & "'")
                If Tabel.Rows.Count = 0 Then
                    MsgBox("Kode barang tersebut tidak ada !!!", MsgBoxStyle.Information, "Pesan")
                    txtKdBrg.Focus()
                Else
                    Dim Param_batch_text As New ReportParameter("Batch", "*" + txtBatch.Text + "*")
                    Dim Param_batch_qr As New ReportParameter("QRCode", txtBatch.Text)
                    Dim Param_tglkedatangan As New ReportParameter("tglkedatangan", DtKedatangan.Value)
                    Dim Param_checker As New ReportParameter("Checker", txtcek.Text)
                    FrmReportLabel.ReportViewer1.LocalReport.SetParameters(Param_batch_text)
                    FrmReportLabel.ReportViewer1.LocalReport.SetParameters(Param_batch_qr)
                    FrmReportLabel.ReportViewer1.LocalReport.SetParameters(Param_tglkedatangan)
                    FrmReportLabel.ReportViewer1.LocalReport.SetParameters(Param_checker)
                    FrmReportLabel.DataLabelBindingSource.Filter = "(NoBukti='" & txtBL.Text & "' and KdBrg='" & txtKdBrg.Text & "')"
                    FrmReportLabel.Show()
                End If      
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtKdBrg_Leave(sender As Object, e As EventArgs) Handles txtKdBrg.Leave
        Tabel = Proses.ExecuteQuery("select NoBukti,KdBrg from tblBeliDtl where Kdbrg='" & txtKdBrg.Text & "' and NoBukti='" & txtBL.Text & "'")
        If txtKdBrg.Text <> "" Then
            If Tabel.Rows.Count = 0 Then
                MsgBox("Kode barang tersebut tidak ada !!!", MsgBoxStyle.Information, "Pesan")
                txtKdBrg.Focus()
            End If
        End If
        
    End Sub

    Private Sub txtBL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBL.KeyPress
        If e.KeyChar = Chr(13) Then
            txtKdBrg.Focus()
        End If
    End Sub

    Private Sub txtKdBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKdBrg.KeyPress
        If e.KeyChar = Chr(13) Then
            DtKedatangan.Focus()
        End If
    End Sub

    Private Sub DtKedatangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtKedatangan.KeyPress
        If e.KeyChar = Chr(13) Then
            txtcek.Focus()
        End If
    End Sub

    Private Sub txtcek_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcek.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBatch.Focus()
        End If
    End Sub

    Private Sub txtBatch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBatch.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub
End Class