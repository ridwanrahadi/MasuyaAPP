Public Class FrmGP
    Sub Atur()
        dgv.Columns(0).Visible = False
        dgv.Columns(1).Visible = False
        dgv.Columns(4).Visible = False
        dgv.Columns(5).Visible = False
        dgv.Columns(6).Visible = False
        dgv.Columns(7).DefaultCellStyle.Format = "C"
        dgv.Columns(8).DefaultCellStyle.Format = "C"
        dgv.Columns(9).DefaultCellStyle.Format = "C"
        dgv.Columns(10).DefaultCellStyle.Format = "0.00"
        dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Sub GPpersen()

        dgv.Columns.Add("%", "%")

        For baris3 As Integer = 0 To dgv.RowCount - 1
            dgv.Rows(baris3).Cells(10).Value = (dgv.Rows(baris3).Cells(9).Value / dgv.Rows(baris3).Cells(7).Value) * 100
        Next
    End Sub
    Sub TotalHPP()
        Dim totalHPP As Double
        totalHPP = 0
        For t As Integer = 0 To dgv.Rows.Count - 1
            totalHPP = totalHPP + Val(dgv.Rows(t).Cells(8).Value)
        Next
        txtHPP.Text = totalHPP
        txtHPP.Text = FormatCurrency(txtHPP.Text)
    End Sub
    Sub TotalSales()
        Dim total As Double
        total = 0
        For t As Integer = 0 To dgv.Rows.Count - 1
            total = total + Val(dgv.Rows(t).Cells(7).Value)
        Next
        txtTotSales.Text = total
        txtTotSales.Text = FormatCurrency(txtTotSales.Text)
    End Sub
    Sub TotalGP()
        Dim total As Double
        total = 0
        For t As Integer = 0 To dgv.Rows.Count - 1
            total = total + Val(dgv.Rows(t).Cells(9).Value)
        Next
        txtTotGP.Text = total
        txtTotGP.Text = FormatCurrency(txtTotGP.Text)
    End Sub
    Sub TotalPpn()
        Dim totalHPP As Double
        totalHPP = 0
        For t As Integer = 0 To dgv.Rows.Count - 1
            totalHPP = totalHPP + Val(dgv.Rows(t).Cells(5).Value)
        Next
        txtHPP.Text = totalHPP
        txtHPP.Text = FormatCurrency(txtHPP.Text)
    End Sub
    Private Sub ExportToExcel()
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

    Private Sub txtbln_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbln.KeyPress
        If e.KeyChar = Chr(13) Then
            txttahun.Focus()
        End If
    End Sub

    Private Sub txttahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttahun.KeyPress
        If e.KeyChar = Chr(13) Then
            txtperiod.Text = txttahun.Text + txtbln.Text
            btcari.Focus()
        End If
    End Sub

    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        If Label7.Text = "admin" Then
            If RadioButton1.Checked Then
                If txtperiod.Text = "" Then
                    MsgBox("Kolom periode harus di isi", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Pesan")
                Else
                    Tabel = Proses.ExecuteQuery("Select * from tblHrgPokok where periode = '" & txtperiod.Text & "'")
                    If Tabel.Rows.Count = 0 Then
                        MsgBox("Harga Pokok inventory belum dihitung, harap dihitung dahulu di sistem Masuya", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Else
                        Try
                            dgv.Columns.Clear()
                            Tabel = Proses.ExecuteQuery("Select PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl) AS Tahun, PenjDetailIncPpn.KdType, PenjDetailIncPpn.NmType, AVG(tblHrgPokok.HrgPokok) AS HPP, SUM(PenjDetailIncPpn.Qty) AS Quantity, tblHrgPokok.Periode,SUM(PenjDetailIncPpn.Dpp) AS Total, SUM(CAST(tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS HPPTotal, SUM(CAST(PenjDetailIncPpn.Dpp - tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS GP FROM PenjDetailIncPpn INNER JOIN tblSalesPerson ON PenjDetailIncPpn.KdSales = tblSalesPerson.KDSALES LEFT OUTER JOIN tblHrgPokok ON PenjDetailIncPpn.KdBrg = tblHrgPokok.KdBrg where (tblsalesperson.provinsi = '" & ComboBox1.Text & "') GROUP BY PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl), PenjDetailIncPpn.NmType, tblHrgPokok.Periode, PenjDetailIncPpn.KdType HAVING (PenjDetailIncPpn.Bulan = '" & txtbln.Text & "') AND (YEAR(PenjDetailIncPpn.Tgl) = '" & txttahun.Text & "') AND (tblHrgPokok.Periode = '" & txtperiod.Text & "') AND (SUM(PenjDetailIncPpn.Dpp)<>0) ORDER BY GP desc")
                            dgv.DataSource = Tabel

                            Call TotalGP()
                            Call TotalSales()
                            Call TotalHPP()
                            Call GPpersen()
                            Call Atur()
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    End If

                End If
            ElseIf RadioButton2.Checked Then
                If txtperiod.Text = "" Then
                    MsgBox("Kolom periode harus di isi", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Pesan")
                Else
                    Tabel = Proses.ExecuteQuery("Select * from tblHrgPokok where periode = '" & txtperiod.Text & "'")
                    If Tabel.Rows.Count = 0 Then
                        MsgBox("Harga Pokok inventory belum dihitung, harap dihitung dahulu di sistem Masuya", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Else
                        Try
                            dgv.Columns.Clear()
                            Tabel = Proses.ExecuteQuery("Select PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl) AS Tahun, PenjDetailIncPpn.KdSales, tblSalesPerson.NMSALES, AVG(tblHrgPokok.HrgPokok) AS HPP, SUM(PenjDetailIncPpn.Qty) AS Quantity, tblHrgPokok.Periode,SUM(PenjDetailIncPpn.Dpp) AS Total, SUM(CAST(tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS HPPTotal, SUM(CAST(PenjDetailIncPpn.Dpp - tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS GP FROM PenjDetailIncPpn INNER JOIN tblSalesPerson ON PenjDetailIncPpn.KdSales = tblSalesPerson.KDSALES LEFT OUTER JOIN tblHrgPokok ON PenjDetailIncPpn.KdBrg = tblHrgPokok.KdBrg WHERE (tblSalesPerson.provinsi = '" & ComboBox1.Text & "') GROUP BY PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl), tblSalesPerson.NMSALES, tblHrgPokok.Periode, PenjDetailIncPpn.KdSales HAVING (PenjDetailIncPpn.Bulan = '" & txtbln.Text & "') AND (YEAR(PenjDetailIncPpn.Tgl) = '" & txttahun.Text & "') AND (tblHrgPokok.Periode = '" & txtperiod.Text & "') AND (SUM(PenjDetailIncPpn.Dpp)<>0) ORDER BY GP desc")
                            dgv.DataSource = Tabel

                            Call TotalGP()
                            Call TotalSales()
                            Call TotalHPP()
                            Call GPpersen()
                            Call Atur()
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    End If

                End If
            End If
        Else
            If RadioButton1.Checked Then
                If txtperiod.Text = "" Then
                    MsgBox("Kolom periode harus di isi", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Pesan")
                Else
                    Tabel = Proses.ExecuteQuery("Select * from tblHrgPokok where periode = '" & txtperiod.Text & "'")
                    If Tabel.Rows.Count = 0 Then
                        MsgBox("Harga Pokok inventory belum dihitung, harap dihitung dahulu di sistem Masuya", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Else
                        Try
                            dgv.Columns.Clear()
                            Tabel = Proses.ExecuteQuery("Select PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl) AS Tahun, PenjDetailIncPpn.KdType, PenjDetailIncPpn.NmType, AVG(tblHrgPokok.HrgPokok) AS HPP, SUM(PenjDetailIncPpn.Qty) AS Quantity, tblHrgPokok.Periode,SUM(PenjDetailIncPpn.Dpp) AS Total, SUM(CAST(tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS HPPTotal, SUM(CAST(PenjDetailIncPpn.Dpp - tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS GP FROM PenjDetailIncPpn INNER JOIN tblSalesPerson ON PenjDetailIncPpn.KdSales = tblSalesPerson.KDSALES LEFT OUTER JOIN tblHrgPokok ON PenjDetailIncPpn.KdBrg = tblHrgPokok.KdBrg where (tblsalesperson.provinsi = '" & ComboBox1.Text & "') and (tblsalesperson.SEKTOR_DIV = '" & Label7.Text & "')  GROUP BY PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl), PenjDetailIncPpn.NmType, tblHrgPokok.Periode, PenjDetailIncPpn.KdType HAVING (PenjDetailIncPpn.Bulan = '" & txtbln.Text & "') AND (YEAR(PenjDetailIncPpn.Tgl) = '" & txttahun.Text & "') AND (tblHrgPokok.Periode = '" & txtperiod.Text & "') AND (SUM(PenjDetailIncPpn.Dpp)<>0) ORDER BY GP desc")
                            dgv.DataSource = Tabel

                            Call TotalGP()
                            Call TotalSales()
                            Call TotalHPP()
                            Call GPpersen()
                            Call Atur()
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    End If

                End If
            ElseIf RadioButton2.Checked Then
                If txtperiod.Text = "" Then
                    MsgBox("Kolom periode harus di isi", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Pesan")
                Else
                    Tabel = Proses.ExecuteQuery("Select * from tblHrgPokok where periode = '" & txtperiod.Text & "'")
                    If Tabel.Rows.Count = 0 Then
                        MsgBox("Harga Pokok inventory belum dihitung, harap dihitung dahulu di sistem Masuya", MsgBoxStyle.Exclamation, "Konfirmasi")
                    Else
                        Try
                            dgv.Columns.Clear()
                            Tabel = Proses.ExecuteQuery("Select PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl) AS Tahun, PenjDetailIncPpn.KdSales, tblSalesPerson.NMSALES, AVG(tblHrgPokok.HrgPokok) AS HPP, SUM(PenjDetailIncPpn.Qty) AS Quantity, tblHrgPokok.Periode,SUM(PenjDetailIncPpn.Dpp) AS Total, SUM(CAST(tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS HPPTotal, SUM(CAST(PenjDetailIncPpn.Dpp - tblHrgPokok.HrgPokok * PenjDetailIncPpn.Qty AS DECIMAL(14, 2))) AS GP FROM PenjDetailIncPpn INNER JOIN tblSalesPerson ON PenjDetailIncPpn.KdSales = tblSalesPerson.KDSALES LEFT OUTER JOIN tblHrgPokok ON PenjDetailIncPpn.KdBrg = tblHrgPokok.KdBrg WHERE (tblSalesPerson.provinsi = '" & ComboBox1.Text & "') and (tblsalesperson.SEKTOR_DIV = '" & Label7.Text & "') GROUP BY PenjDetailIncPpn.Bulan, YEAR(PenjDetailIncPpn.Tgl), tblSalesPerson.NMSALES, tblHrgPokok.Periode, PenjDetailIncPpn.KdSales HAVING (PenjDetailIncPpn.Bulan = '" & txtbln.Text & "') AND (YEAR(PenjDetailIncPpn.Tgl) = '" & txttahun.Text & "') AND (tblHrgPokok.Periode = '" & txtperiod.Text & "') AND (SUM(PenjDetailIncPpn.Dpp)<>0) ORDER BY GP desc")
                            dgv.DataSource = Tabel

                            Call TotalGP()
                            Call TotalSales()
                            Call TotalHPP()
                            Call GPpersen()
                            Call Atur()
                        Catch ex As Exception
                            MsgBox(ex.ToString())
                        End Try
                    End If

                End If
            End If
        End If
        


    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Me.Dispose()
    End Sub

    Private Sub btexport_Click(sender As Object, e As EventArgs) Handles btexport.Click
        ExportToExcel()
    End Sub

    Private Sub FrmGP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            RadioButton1.Checked = True
            Tabel = Proses.ExecuteQuery("Select * from tblpengguna where username ='" & FrmUtama.Unametxt.Text & "'")
            Label7.Text = Tabel.Rows(0).Item("Divisi")
        Catch ex As Exception
            MsgBox("Akses di tolak", MsgBoxStyle.Critical, "Pesan")
            Me.Close()
        End Try

    End Sub
End Class