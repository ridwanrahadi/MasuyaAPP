Public Class FrmHPP
    

    Private Sub FrmHPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("Select * from tblIvType")
        ComboBox1.DataSource = Tabel
        ComboBox1.DisplayMember = "NmType"
        ComboBox1.ValueMember = "KdType"
        txttahun.Text = Format(Now, ("yyyy"))
        txtbulan.Text = Format(Now, ("MM"))
    End Sub

    

    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        Dim kondisi As String
        Try
            If txtbulan.Text = "" Then
                kondisi = "tblIvMst.Type = '" & ComboBox1.SelectedValue & "' and Periode like'%" & txttahun.Text & "%'"
            Else
                kondisi = "tblIvMst.Type = '" & ComboBox1.SelectedValue & "' and Periode='" & txttahun.Text + txtbulan.Text & "'"
            End If

            Tabel = Proses.ExecuteQuery("SELECT tblIvMst.KdBrg, tblIvMst.NmBrg, tblIvMst.Type, tblHrgPokok.Periode, tblHrgPokok.HrgPokok FROM tblIvMst LEFT OUTER JOIN tblHrgPokok ON tblIvMst.KdBrg = tblHrgPokok.KdBrg where " & kondisi & "")
            DataGridView1.DataSource = Tabel
            DataGridView1.Columns(1).Width = "230"
            DataGridView1.Columns(4).DefaultCellStyle.Format = "C"
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        
    End Sub
End Class