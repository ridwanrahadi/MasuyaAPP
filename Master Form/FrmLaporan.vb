Imports Microsoft.Office.Interop

Public Class FrmLaporan
    Sub export()
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range

        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True

        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet

        ' Add table headers going cell by cell.
        shXL.Cells(1, 1).Value = "No Bukti"
        shXL.Cells(1, 2).Value = "Tanggal"
        shXL.Cells(1, 3).Value = "Bulan"
        shXL.Cells(1, 4).Value = "Kode Customer"
        shXL.Cells(1, 5).Value = "Nama Customer"
        shXL.Cells(1, 6).Value = "Kode Barang"
        shXL.Cells(1, 7).Value = "Nama Barang"
        shXL.Cells(1, 8).Value = "Qty"
        shXL.Cells(1, 9).Value = "Satuan"
        shXL.Cells(1, 10).Value = "QtyKvs"
        shXL.Cells(1, 11).Value = "Satuan 2"
        shXL.Cells(1, 12).Value = "Harga"
        shXL.Cells(1, 13).Value = "Disc1"
        shXL.Cells(1, 14).Value = "Disc2"
        shXL.Cells(1, 15).Value = "Disc3"
        shXL.Cells(1, 16).Value = "Harga Net"
        shXL.Cells(1, 17).Value = "Dpp"
        shXL.Cells(1, 18).Value = "Total Inc"
        shXL.Cells(1, 19).Value = "Type Cust"
        shXL.Cells(1, 20).Value = "Brand Produk"
        shXL.Cells(1, 21).Value = "Kode Sales"
        shXL.Cells(1, 22).Value = "JnsPPN"
        shXL.Cells(1, 23).Value = "DivSales"
        shXL.Cells(1, 24).Value = "KdGroup"
        shXL.Cells(1, 25).Value = "Nama Sales"
        shXL.Cells(1, 26).Value = "NoPO"
        shXL.Cells(1, 27).Value = "JnsTrans"
        shXL.Cells(1, 28).Value = "Sales Kota"
        shXL.Cells(1, 29).Value = "Kota"

        ' Format A1:D1 as bold, vertical alignment = center.
        With shXL.Range("A1", "AC1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim baris As Integer = Tabel.Rows.Count
        Dim kolom As Integer = Tabel.Columns.Count
        Dim data(baris, kolom) As String

        'Create an array to set multiple values at once.
        For i As Integer = 0 To baris - 1
            Dim columnIndex As Integer = 0
            Do Until columnIndex = kolom
                If IsDBNull(Tabel.Rows(i).Item(columnIndex)) Then
                    data(i, columnIndex) = ""
                Else
                    data(i, columnIndex) = Tabel.Rows(i).Item(columnIndex)
                End If
                columnIndex += 1
            Loop

        Next



        ' Fill A:AC with an array of values (From table query).
        shXL.Range("A2", "AC" & baris + 1).Value = data

        ' AutoFit columns 
        raXL = shXL.Range("A1", "AC1")
        raXL.EntireColumn.AutoFit()

        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True

        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        appXL = Nothing
        Exit Sub



Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub
    Sub Total()
        Dim total As Double
        total = 0
        For t As Integer = 0 To DGLaporan.Rows.Count - 1
            total = total + Val(DGLaporan.Rows(t).Cells(16).Value)
        Next
        Totaltxt.Text = total
        Totaltxt.Text = FormatCurrency(Totaltxt.Text)
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
    Sub isiGDView2()
        Try
            Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
            DGLaporan.DataSource = Tabel
            Call PengaturanDGV()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub isiGDView()
        If CBKota.SelectedIndex > -1 And CBSales.SelectedIndex > -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE Wilayah='" & CBKota.Text & "' AND DivisiSales='" & CBSales.Text & "'  and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBKota.SelectedIndex > -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE Wilayah='" & CBKota.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        ElseIf CBSales.SelectedIndex = -1 And CBType.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE SalesKota='" & CmbWil.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        ElseIf CmbWil.SelectedIndex = -1 And CBType.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE  DivisiSales='" & CBSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

        ElseIf CmbWil.SelectedIndex = -1 And CBSales.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE NmType='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CmbWil.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE divisisales='" & CBSales.Text & "' AND NmType='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBSales.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE NmType='" & CBType.Text & "' AND SalesKota='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf CBType.SelectedIndex = -1 Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE SalesKota='" & CmbWil.Text & "' AND divisisales='" & CBSales.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanDetail  WHERE SalesKota='" & CmbWil.Text & "' AND DivisiSales='" & CBSales.Text & "'and NmType='" & CBType.Text & "' and  Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
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
        Tabel = Proses.ExecuteQuery("Select * From tblWilayah order by NmWilayah")
        CBKota.DataSource = Tabel
        CBKota.DisplayMember = "NmWilayah"
        CBKota.SelectedIndex = -1
        Tabel = Nothing
    End Sub
    Private Sub FrmLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isicombo()
        TglAwal.Value = Now.Date.AddDays(-(Now.Day) + 1)

    End Sub
    Private Sub BtKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub BtStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtStock.Click
        FrmStock.Show()
    End Sub

    Private Sub BtExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExport.Click
        Call export()
    End Sub


    Private Sub BtCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCari.Click
        If CBType.Text = "" And CBSales.Text = "" And CmbWil.Text = "" And CBKota.Text = "" Then
            MsgBox("Data yang ditarik adalah keseluruhan, memerlukan waktu lebih lama", MsgBoxStyle.Exclamation, "konfirmasi")
            Call isiGDView2()
            Call TotalQty()
            Call Total()
        Else
            Call isiGDView()
            Call TotalQty()
            Call Total()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmExtendLaporan.Show()
    End Sub

    Private Sub BTGp_Click(sender As Object, e As EventArgs) Handles BTGp.Click
            FrmGP.Show()

    End Sub

   

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CBKota.Enabled = True
            CBKota.SelectedIndex = -1
            CBType.Enabled = False
            CmbWil.Enabled = False

        Else
            CBKota.Enabled = False
            CBKota.SelectedIndex = -1
            CBType.Enabled = True
            CmbWil.Enabled = True
        End If

    End Sub
End Class