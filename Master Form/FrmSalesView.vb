Public Class FrmSalesView
    Sub Cari2()
        If CBCodeSales.Text = "" Then
            MsgBox("Code sales masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBCodeSales.Focus()
        Else

            Try
                Tabel = Proses.ExecuteQuery("Select tblKunjungan.CodeSales, tblSalesPerson.NMSALES, tblSalesPerson.DIVISI, tblKunjungan.Customer, tblKunjungan.Hari FROM  tblKunjungan INNER JOIN tblSalesPerson ON tblKunjungan.CodeSales = tblSalesPerson.KDSALES where codesales='" & CBCodeSales.Text & "' order by hari")
                DGView.DataSource = Tabel
                DGView.Columns(0).HeaderText = "Code"
                DGView.Columns(1).HeaderText = "Nama Sales"
                DGView.Columns(2).HeaderText = "Divisi"
                DGView.Columns(3).HeaderText = "Customer"
                DGView.Columns(4).HeaderText = "Kunjungan"
                DGView.Columns(0).Width = 35
                DGView.Columns(1).Width = 90
                DGView.Columns(2).Width = 80
                DGView.Columns(3).Width = 150
                DGView.Columns(4).Width = 100

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
    Sub Cari()
        If CBCodeSales.Text = "" Then
            MsgBox("Code sales masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBCodeSales.Focus()
        Else

            Try
                Tabel = Proses.ExecuteQuery("Select tblKunjungan.CodeSales, tblSalesPerson.NMSALES, tblSalesPerson.DIVISI, tblKunjungan.Customer, tblKunjungan.Hari FROM  tblKunjungan INNER JOIN tblSalesPerson ON tblKunjungan.CodeSales = tblSalesPerson.KDSALES where codesales='" & CBCodeSales.Text & "' and hari='" & CBhari.Text & "' order by hari")
                DGView.DataSource = Tabel
                DGView.Columns(0).HeaderText = "Code"
                DGView.Columns(1).HeaderText = "Nama Sales"
                DGView.Columns(2).HeaderText = "Divisi"
                DGView.Columns(3).HeaderText = "Customer"
                DGView.Columns(4).HeaderText = "Kunjungan"
                DGView.Columns(0).Width = 35
                DGView.Columns(1).Width = 90
                DGView.Columns(2).Width = 80
                DGView.Columns(3).Width = 150
                DGView.Columns(4).Width = 100

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub
    Sub IsiTextBox()
        Try
            Tabel = Proses.ExecuteQuery("Select NMSALES,Divisi From tblSalesPerson where KDSALES='" & CBCodeSales.Text & "'")
            If Tabel.Rows.Count = 0 Then
                NmSalestxt.Text = ""
            Else
                With Tabel.Columns(0)
                    NmSalestxt.Text = .Table.Rows(0).Item(0)

                End With
            End If
           
        Catch ex As Exception
            MsgBox("Kode Sales tidak ditemukan", MsgBoxStyle.Exclamation, "konfirmasi")
        End Try
    End Sub
    Sub IsiCBsales()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblSalesPerson order by KDSALES")
            CBCodeSales.DataSource = Tabel
            CBCodeSales.DisplayMember = "KDSALES"
            CBCodeSales.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub FrmSalesView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IsiCBsales()

    End Sub


    Private Sub CBCodeSales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBCodeSales.KeyPress
        If e.KeyChar = Chr(13) Then
            If CBCodeSales.Text = "" Then
                MsgBox("Tentukan Code sales", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                CBCodeSales.Focus()
            Else
                IsiTextBox()

            End If


        End If
    End Sub

    Private Sub BtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSearch.Click
        If CBhari.Text = "" Then
            Call Cari2()
        Else
            Call Cari()
        End If

    End Sub

    Private Sub BtKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKeluar.Click
        Me.Dispose()
    End Sub

    Private Sub CBCodeSales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCodeSales.SelectedIndexChanged
        Call IsiTextBox()

    End Sub
End Class