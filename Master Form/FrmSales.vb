Public Class FrmSales
    Sub Delete()
        If CBcodesales.Text = "" Then
            MsgBox("Code sales masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBcodesales.Focus()
        End If
        If CBCust.Text = "" Then
            MsgBox("Code Customer masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBCust.Focus()
        Else
            Try
                SQl = "Delete From tblKunjungan where codesales='" & CBcodesales.Text & "' and Customer='" & CBCust.Text & "' and hari ='" & CBHari.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data sudah dihapus", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Call BersihkanIsian()
                Call IsiDGVsales()
            Catch ex As Exception
                MsgBox("Data belum terupdate, Terjadi kesalahan", MsgBoxStyle.Critical, "Konfirmasi")
            End Try
        End If
    End Sub
    Sub Simpan()
        If CBcodesales.Text = "" Then
            MsgBox("Code sales masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBcodesales.Focus()
        Else
            Try
                SQl = "Insert into tblKunjungan Values('" & CBcodesales.Text & "','" & CBCust.Text & "','" & CBHari.Text & "')"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data sudah tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Call BersihkanIsian()
                Call IsiDGVsales()
            Catch ex As Exception
                MsgBox("Data belum tersimpan, Terjadi kesalahan", MsgBoxStyle.Critical, "Konfirmasi")
            End Try
        End If

    End Sub
    Sub IsiTextBox()
        Try
            Tabel = Proses.ExecuteQuery("Select NMSALES,Divisi From tblSalesPerson where KDSALES='" & CBcodesales.Text & "'")
            If Tabel.Rows.Count = 0 Then
                Call BersihkanIsian()
            Else
                With Tabel.Columns(0)
                    NmSalestxt.Text = .Table.Rows(0).Item(0)
                    DivSalestxt.Text = .Table.Rows(0).Item(1)

                End With
            End If
           
        Catch ex As Exception
            MsgBox("Kode Sales tidak ditemukan", MsgBoxStyle.Exclamation, "konfirmasi")
        End Try
    End Sub
    Sub Pengaturan()
        Call IsiCbSales()
        Call IsiCbCust()
        Call IsiDGVsales()
        Call BersihkanIsian()
    End Sub
    Sub BersihkanIsian()
        CBcodesales.Text = ""
        NmSalestxt.Text = ""
        DivSalestxt.Text = ""
        CBCust.Text = ""
        CBHari.Text = ""
    End Sub
    Sub IsiCbSales()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblSalesPerson order by KDSALES")
            CBcodesales.DataSource = Tabel
            CBcodesales.DisplayMember = "KDSALES"
            CBcodesales.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiCbCust()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblCustomer order by NmCust")
            CBCust.DataSource = Tabel
            CBCust.DisplayMember = "NmCust"
            CBCust.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiDGVsales()
        Try
            Tabel = Proses.ExecuteQuery("Select tblKunjungan.CodeSales, tblSalesPerson.NMSALES, tblSalesPerson.DIVISI, tblKunjungan.Customer, tblKunjungan.Hari FROM  tblKunjungan INNER JOIN tblSalesPerson ON tblKunjungan.CodeSales = tblSalesPerson.KDSALES order by codesales")
            DGSales.DataSource = Tabel
            DGSales.Columns(0).HeaderText = "Code"
            DGSales.Columns(1).HeaderText = "Nama Sales"
            DGSales.Columns(2).HeaderText = "Divisi"
            DGSales.Columns(3).HeaderText = "Customer"
            DGSales.Columns(4).HeaderText = "Kunjungan"
            DGSales.Columns(0).Width = 35
            DGSales.Columns(1).Width = 90
            DGSales.Columns(2).Width = 80
            DGSales.Columns(3).Width = 150
            DGSales.Columns(4).Width = 100

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub
    Private Sub FrmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Pengaturan()
    End Sub

    Private Sub CBcodesales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBcodesales.KeyPress
        If e.KeyChar = Chr(13) Then
            If CBcodesales.Text = "" Then
                MsgBox("Tentukan Code sales", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                CBcodesales.Focus()
            Else
                IsiTextBox()

            End If


        End If
    End Sub

    Private Sub BtSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSimpan.Click
        Call Simpan()
    End Sub

    Private Sub BtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCancel.Click
        Call Pengaturan()
    End Sub

    Private Sub BtEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DGSales_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSales.CellDoubleClick
        Try
            Dim i As Integer
            i = Me.DGSales.CurrentRow.Index
            With DGSales.Rows.Item(i)

                CBcodesales.Text = .Cells(0).Value
                NmSalestxt.Text = .Cells(1).Value
                DivSalestxt.Text = .Cells(2).Value
                CBCust.Text = .Cells(3).Value
                CBHari.Text = .Cells(4).Value

            End With
        Catch ex As Exception
            MsgBox("Database Kosong", MsgBoxStyle.Critical, "Pesan")
        End Try
    End Sub

    Private Sub BtHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHapus.Click
        Call Delete()

    End Sub

    Private Sub BtView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtView.Click
        FrmSalesView.Show()
    End Sub

    Private Sub CBcodesales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcodesales.SelectedIndexChanged
        Call IsiTextBox()

    End Sub
End Class