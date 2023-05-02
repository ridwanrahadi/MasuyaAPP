Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmLostCust
    ' Dim tahun As Integer

    Sub Chart()
        'tahun = Format(Dt1.Value, "yyyy")
        Tabel = Proses.ExecuteQuery("SELECT COUNT(KdCust) AS Total, SALES, DIVISI FROM AnalystLostCust WHERE Tanggal >= '" & Dt1.Value & "' AND Tanggal < '" & Dt2.Value & "' GROUP BY SALES, DIVISI HAVING DIVISI = '" & ComboBox1.Text & "'")
        Chart1.DataSource = Tabel
        Chart1.Series.Clear()
        
        Dim Series1 As New DataVisualization.Charting.Series
        Series1.ChartType = SeriesChartType.Doughnut
        With Series1
            .Name = "Customer"
            .XValueMember = "SALES"
            .YValueMembers = "Total"
            .IsValueShownAsLabel = True

        End With

        Chart1.Series.Add(Series1)
        Chart1.Invalidate()
    End Sub
    Sub CHART2()
        ' tahun = Format(Dt1.Value, "yyyy")
        Tabel = Proses.ExecuteQuery("SELECT COUNT(KdCust) AS Total, SALES FROM AnalystLostCust Where tanggal >='" & Dt1.Value & "' and tanggal < '" & Dt2.Value & "' GROUP BY SALES")
        Chart1.DataSource = Tabel
        Chart1.Series.Clear()
        Dim Series1 As New DataVisualization.Charting.Series
        Series1.ChartType = SeriesChartType.Doughnut
        With Series1
            .Name = "Customer"
            .XValueMember = "SALES"
            .YValueMembers = "Total"
            .IsValueShownAsLabel = True

        End With

        Chart1.Series.Add(Series1)
        Chart1.Invalidate()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dt1.Value = DateAdd("d", -90, Dt2.Value)

    End Sub

    Private Sub FrmLostCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dt1.Value = Now.Date.AddDays(-(Now.Day) + 1)
        Dt2.Value = Now.Date.AddDays(-(Now.Day) + 1)
        Chart1.Series.Add("Customer")
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        Chart1.ChartAreas(0).AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.NotSet

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dt1.Value = DateAdd("d", -180, Dt2.Value)

    End Sub

    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        '  Dim tahun As Integer
        ' tahun = Format(Dt1.Value, "yyyy")
        Try
            If ComboBox1.Text = "" Then
                Tabel = Proses.ExecuteQuery("SELECT TblFak.KdCust,TblCustomer.NmCust, MAX(TblFak.Tgl) AS [Tanggal Terakhir] ,MAX(YEAR(TblFak.Tgl)) AS Tahun, MAX(tblSalesPerson.NMSALES) AS SALES, SUM(TblFak.Total) AS [Total Penjualan/Tahun],TblSalesPerson.Divisi FROM TblFak INNER JOIN tblSalesPerson ON TblFak.KdSales = tblSalesPerson.KDSALES INNER JOIN TblCustomer ON tblfak.KdCust = tblCustomer.KdCust GROUP BY TblFak.KdCust,tblCustomer.NmCust,TblSalesPerson.DIVISI HAVING (TblFak.KdCust <> 'TOKU') AND (TblFak.KdCust <> 'WALKIN') AND (MAX(TblFak.Tgl)>='" & Dt1.Value & "') AND (MAX(TblFak.Tgl)<'" & Dt2.Value & "') ORDER BY MAX(TblFak.Tgl)")
                DataGridView.DataSource = Tabel
                Me.DataGridView.Columns(5).DefaultCellStyle.Format = "Rp 0,00"
                Me.DataGridView.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Call CHART2()
            Else
                Tabel = Proses.ExecuteQuery("SELECT TblFak.KdCust,TblCustomer.NmCust, MAX(TblFak.Tgl) AS [Tanggal Terakhir] ,MAX(YEAR(TblFak.Tgl)) AS Tahun, MAX(tblSalesPerson.NMSALES) AS SALES, SUM(TblFak.Total) AS [Total Penjualan/Tahun],TblSalesPerson.Divisi FROM TblFak INNER JOIN tblSalesPerson ON TblFak.KdSales = tblSalesPerson.KDSALES INNER JOIN TblCustomer ON tblfak.KdCust = tblCustomer.KdCust GROUP BY TblFak.KdCust,tblCustomer.NmCust,TblSalesPerson.DIVISI HAVING (TblFak.KdCust <> 'TOKU') AND (TblFak.KdCust <> 'WALKIN') AND (MAX(TblFak.Tgl)>='" & Dt1.Value & "') AND (MAX(TblFak.Tgl)<'" & Dt2.Value & "') AND (tblSalesPerson.DIVISI='" & ComboBox1.Text & "') ORDER BY MAX(TblFak.Tgl)")
                DataGridView.DataSource = Tabel
                Me.DataGridView.Columns(5).DefaultCellStyle.Format = "Rp 0,00"
                Me.DataGridView.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Call Chart()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub


    Private Sub DataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView.DoubleClick
        Dim i As Integer
        i = Me.DataGridView.CurrentRow.Index
        With DataGridView.Rows.Item(i)
            Try
                Tabel = Proses.ExecuteQuery("SELECT TblFak.KdCust AS Kode_Cust, TblFakDtl.KdBrg AS Kode_Barang, TblFakDtl.NmBrg AS Nama_Barang, SUM(TblFakDtl.Qty) AS jumlah, tblIvMst.Satuan AS Satuan FROM TblFak INNER JOIN TblFakDtl ON TblFak.NoBukti = TblFakDtl.NoBukti INNER JOIN TblIvMst ON TblFakDtl.Kdbrg = TblIvMst.Kdbrg GROUP BY TblFak.KdCust, TblFakDtl.NmBrg, TblFakDtl.KdBrg ,tblIvMst.Satuan HAVING TblFak.KdCust ='" & .Cells(0).Value & "'")
                ListView1.Items.Clear()
                For j As Integer = 0 To Tabel.Rows.Count - 1
                    With ListView1
                        .Items.Add(Tabel.Rows(j)("Kode_Cust"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(Tabel.Rows(j)("Kode_Barang"))
                            .Add(Tabel.Rows(j)("Nama_Barang"))
                            .Add(Tabel.Rows(j)("Jumlah"))
                            .Add(Tabel.Rows(j)("Satuan"))
                        End With
                    End With
                Next
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub

 
End Class