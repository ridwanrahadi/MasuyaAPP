Imports System.Math
Public Class FrmEstimasi
    Sub pengaturan()
        DataGridView1.Columns(3).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(9).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(10).DefaultCellStyle.Format = "0.00"
        DataGridView1.Columns(11).DefaultCellStyle.Format = "0.00"

        For kolom As Integer = 0 To DataGridView1.Columns.Count - 7
            DataGridView1.Columns(kolom).ReadOnly = Enabled
        Next
        For kolom As Integer = 7 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(kolom).ReadOnly = Enabled
        Next
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
       
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cek As Double
        If CmbType.Text = "" Then
            MsgBox("Tentukan Type Produk", MsgBoxStyle.Exclamation, "Konfirmasi")
        ElseIf txtLead.Text = "" Or txtService.Text = "" Then

            MsgBox("Kolom leadtime atau Service Level belum terisi", MsgBoxStyle.Exclamation, "Konfirmasi")

        Else

            DataGridView1.Columns.Clear()

            Tabel = Proses.ExecuteQuery("SELECT Type, KdBrg, Tahun, AVG(DISTINCT Total) AS [Rata-rata], STDEV(Total) AS Stddev, Stock FROM ViewEstimasi GROUP BY KdBrg, Tahun, Type, Stock HAVING (Tahun = 2022) AND (STDEV(Total) IS NOT NULL) AND (Type = '" & CmbType.SelectedValue & "')")
            DataGridView1.DataSource = Tabel

            DataGridView1.Columns.Add("estimasi", "Estimasi")
            DataGridView1.Columns.Add("service", "Service Faktor")
            DataGridView1.Columns.Add("leadtime", "Lead Time Faktor")
            DataGridView1.Columns.Add("safety", "Safety Stock")


            For baris1 As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(baris1).Cells(7).Value = Kode.NormSInv(txtService.Text)
            Next
            For baris2 As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(baris2).Cells(8).Value = Math.Sqrt(txtLead.Text)
            Next
            For baris3 As Integer = 0 To DataGridView1.RowCount - 1

                DataGridView1.Rows(baris3).Cells(9).Value = DataGridView1.Rows(baris3).Cells(4).Value * DataGridView1.Rows(baris3).Cells(7).Value * DataGridView1.Rows(baris3).Cells(8).Value
            Next
            DataGridView1.Columns.Add("order", "Reorder Point")
            DataGridView1.Columns.Add("estimasiorder", "Estimasi Order")
            Call pengaturan()



        End If



    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 6 Then
            DataGridView1.Rows(e.RowIndex).Cells(10).Value = DataGridView1.Rows(e.RowIndex).Cells(6).Value + DataGridView1.Rows(e.RowIndex).Cells(9).Value
            DataGridView1.Rows(e.RowIndex).Cells(11).Value = DataGridView1.Rows(e.RowIndex).Cells(10).Value - DataGridView1.Rows(e.RowIndex).Cells(5).Value

        End If
    End Sub


    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Try
            For t As Integer = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Columns(6).DefaultCellStyle.BackColor = Color.LightBlue
                If Val(DataGridView1.Rows(t).Cells("Stock").Value < DataGridView1.Rows(t).Cells("Safety").Value) Then
                    DataGridView1.Rows(t).DefaultCellStyle.BackColor = Color.Yellow
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmEstimasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("Select * from tblIvType order by NmType")
        CmbType.DataSource = Tabel
        CmbType.DisplayMember = "NmType"
        CmbType.ValueMember = "KdType"
        CmbType.SelectedIndex = -1
    End Sub



   
End Class