Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmLaporanSales
    Sub ExportToExcel()
        Dim xlApp As excel.Application
        Dim xlWorkBook As excel.Workbook
        Dim xlWorkSheet As excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value


        xlApp = New excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        'Dim connectionString As String = "Persist Security Info=True;UID=SA;PWD=Shield@1945;Connect timeout=600;Initial Catalog='" & FrmUtama.DatabaseTextBox.Text & "';Data Source='" & FrmUtama.ServerTextBox.Text & "'"
        'Dim connection As SqlConnection = New SqlConnection(connectionString)
        'connection.Open()
        'SQl = "SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc"
        'Dim dscmd As New SqlDataAdapter(SQl, connection)
        'Dim ds As New DataSet
        'dscmd.Fill(ds)

        Dim connectionString As String = "Persist Security Info=True;UID=SA;PWD=Shield@1945;Connect timeout=600;Initial Catalog='" & FrmUtama.DatabaseTextBox.Text & "';Data Source='" & FrmUtama.ServerTextBox.Text & "'"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim command As SqlCommand = New SqlCommand("SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc", connection)

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        xlWorkSheet.Cells(1, 1).Value = reader.GetName(0)
        xlWorkSheet.Cells(1, 2).Value = reader.GetName(1)
        xlWorkSheet.Cells(1, 3).Value = reader.GetName(2)
        xlWorkSheet.Cells(1, 4).Value = reader.GetName(3)
        xlWorkSheet.Cells(1, 5).Value = reader.GetName(4)
        xlWorkSheet.Cells(1, 6).Value = reader.GetName(5)
        xlWorkSheet.Cells(1, 7).Value = reader.GetName(6)
        xlWorkSheet.Cells(1, 8).Value = reader.GetName(7)
        xlWorkSheet.Cells(1, 9).Value = reader.GetName(8)
        Dim row As Integer = 2
        While reader.Read()
            xlWorkSheet.Cells(row, 1).Value = reader.GetString(0)
            xlWorkSheet.Cells(row, 2).Value = reader.GetDateTime(1)
            xlWorkSheet.Cells(row, 3).Value = reader.GetInt32(2)
            xlWorkSheet.Cells(row, 4).Value = reader.GetString(3)
            xlWorkSheet.Cells(row, 5).Value = reader.GetString(4)
            xlWorkSheet.Cells(row, 6).Value = reader.GetString(5)
            xlWorkSheet.Cells(row, 7).Value = reader.GetString(6)
            xlWorkSheet.Cells(row, 8).Value = reader.GetDecimal(7)
            xlWorkSheet.Cells(row, 9).Value = reader.GetString(8)
            row += 1
        End While

        reader.Close()
        connection.Close()

        xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)



    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub TotalDpp()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DGLaporan.Rows.Count - 1
            total = total + Val(DGLaporan.Rows(t).Cells(16).Value)
        Next
        Totaltxt.Text = total
        Totaltxt.Text = FormatCurrency(Totaltxt.Text)
    End Sub
    Sub TotalPpn()
        Dim totalppn As Double
        TotalPpn = 0
        For t As Integer = 0 To DGLaporan.Rows.Count - 1
            totalppn = totalppn + Val(DGLaporan.Rows(t).Cells(17).Value)
        Next
        txttotalppn.Text = totalppn
        txttotalppn.Text = FormatCurrency(txttotalppn.Text)
    End Sub
    Sub TotalQty()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DGLaporan.Rows.Count - 1
            total = total + Val(DGLaporan.Rows(t).Cells(9).Value)
        Next
        TotalQtytxt.Text = total
        TotalQtytxt.Text = FormatNumber(TotalQtytxt.Text)
    End Sub
    Sub PengaturanDGV()

        DGLaporan.Columns(0).Width = 75
        DGLaporan.Columns(1).Width = 75
        DGLaporan.Columns(2).Width = 45
        DGLaporan.Columns(3).Width = 90
        DGLaporan.Columns(4).Width = 180
        DGLaporan.Columns(5).Width = 75
        DGLaporan.Columns(6).Width = 180
        DGLaporan.Columns(7).Width = 50
        DGLaporan.Columns(8).Width = 50
        DGLaporan.Columns(9).Width = 50
        DGLaporan.Columns(10).Width = 50
        DGLaporan.Columns(11).Width = 75
        DGLaporan.Columns(12).Width = 60
        DGLaporan.Columns(13).Width = 60
        DGLaporan.Columns(14).Width = 60
        DGLaporan.Columns(19).Width = 70
        DGLaporan.Columns(20).Width = 70
        DGLaporan.Columns(11).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(12).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(13).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(14).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(15).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(16).DefaultCellStyle.Format = "C"
        DGLaporan.Columns(17).DefaultCellStyle.Format = "C"


    End Sub
    Sub isiGDView()
        If CBType.Text = "" And CBKodeSales.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBSales.Text = "" And CBKodeSales.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE NmType='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBSales.Text = "" And CBType.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE KdSales='" & CBKodeSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBSales.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE NmType='" & CBType.Text & "'and KdSales='" & CBKodeSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBType.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "'and KdSales='" & CBKodeSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBKodeSales.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "'and NmType='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE DivisiSales='" & CBSales.Text & "'and NmType='" & CBType.Text & "' and KdSales='" & CBKodeSales.Text & "'and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
    Sub isicombo()
        Tabel = Proses.ExecuteQuery("Select * From tblIvType order by NmType")
        CBType.DataSource = Tabel
        CBType.DisplayMember = "NmType"
        CBType.SelectedIndex = -1
    End Sub
    Sub isiSales()
        Tabel = Proses.ExecuteQuery("Select * From tblSalesPerson")
        CBKodeSales.DataSource = Tabel
        CBKodeSales.DisplayMember = "KdSales"
        CBKodeSales.SelectedIndex = -1
    End Sub
    Sub isiDivisi()
        Tabel = Proses.ExecuteQuery("Select DISTINCT Divisi From tblSalesPerson")
        CBSales.DataSource = Tabel
        CBSales.DisplayMember = "Divisi"
        CBSales.SelectedIndex = -1
    End Sub
    Private Sub FrmLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isicombo()
        isiSales()
        isiDivisi()
        TglAwal.Value = Now.Date.AddDays(-(Now.Day) + 1)
        LabelProses.Hide()
        LabelCount.Hide()
        ProgressBar1.Hide()
    End Sub
    Private Sub BtKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub BtStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtStock.Click
        FrmStock.Show()
    End Sub

    Private Sub BtExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExport.Click
        'Using save file dialog that allow you to chosse the file name.
        Dim objDlg As New SaveFileDialog
        objDlg.Filter = "Xml File|*.xml"
        objDlg.OverwritePrompt = False
        If objDlg.ShowDialog = DialogResult.OK Then
            Dim filepath As String = objDlg.FileName '
            Tabel.WriteXml(filepath)
        End If
        'Call ExportToExcel()
        MsgBox("Export sukses", MsgBoxStyle.Information, "Pesan")
    End Sub
  
    Private Sub BtCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCari.Click
        If CBType.Text = "" And CBSales.Text = "" And CBKodeSales.Text = "" Then
            MsgBox("Pilihan filter belum di tetapkan", MsgBoxStyle.Information, "konfirmasi")
        Else
            Call isiGDView()
            Call TotalQty()
            Call TotalDpp()
            Call TotalPpn()
        End If
        'LabelCount.Text = "To " & DGLaporan.RowCount + 1
        'ProgressBar1.Maximum = DGLaporan.RowCount
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmExtendLaporan.Show()
    End Sub

    Private Sub BTGp_Click(sender As Object, e As EventArgs)
        FrmGP.Show()

    End Sub
End Class