Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLaporanPrinciple

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
        If CBKodeSales.Text = "" Then
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE NmType='" & lblNmType.Text & "' and Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            Try
                Tabel = Proses.ExecuteQuery("SELECT * from ViewPenjualanSales  WHERE NmType='" & lblNmType.Text & "' and kdsales='" & CBKodeSales.Text & "' and Tanggal >='" & TglAwal.Text & "' and Tanggal <='" & TglAkhir.Text & "'order by Tanggal asc")
                DGLaporan.DataSource = Tabel
                Call PengaturanDGV()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
   
    Sub isiSales()
        Tabel = Proses.ExecuteQuery("Select * From tblSalesPerson")
        CBKodeSales.DataSource = Tabel
        CBKodeSales.DisplayMember = "KdSales"
        CBKodeSales.SelectedIndex = -1
    End Sub
    Private Sub FrmLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lblKdType.Text = FrmUtama.Unametxt.Text
            Tabel = Proses.ExecuteQuery("Select * from TblIvType where Kdtype='" & lblKdType.Text & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("Anda bukan principle", MsgBoxStyle.Exclamation, "Pesan")
                BtCari.Enabled = False
            Else
                lblNmType.Text = Tabel(0).Item(1)
                isiSales()
                BtCari.Enabled = True
            End If
            
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        

        TglAwal.Value = Now.Date.AddDays(-(Now.Day) + 1)

    End Sub
    Private Sub BtKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub BtStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmStock.Show()
    End Sub

    Private Sub BtExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Using save file dialog that allow you to chosse the file name.
        Dim objDlg As New SaveFileDialog
        objDlg.Filter = "Xml File|*.xml"
        objDlg.OverwritePrompt = False
        If objDlg.ShowDialog = DialogResult.OK Then
            Dim filepath As String = objDlg.FileName
            Tabel.WriteXml(filepath)
        End If

        MsgBox("Export sukses", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub BtCari_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCari.Click
       
            Call isiGDView()
            Call TotalQty()
            Call TotalDpp()
            Call TotalPpn()

        'LabelCount.Text = "To " & DGLaporan.RowCount + 1
        'ProgressBar1.Maximum = DGLaporan.RowCount
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmExtendLaporan.Show()
    End Sub

    Private Sub BTGp_Click(sender As Object, e As EventArgs)
        FrmGP.Show()

    End Sub
End Class