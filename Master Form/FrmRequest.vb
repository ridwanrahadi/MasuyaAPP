Public Class FrmRequest
    
    Sub IsiNoRequest()
        Tabel = Proses.ExecuteQuery("Select * From tblRequest order by NoRequest desc")
        With Tabel
            If Tabel.Rows.Count = 0 Then
                NoReqtxt.Text = Kode.Generate("tblRequest", "NoRequest")
            Else
                NoReqtxt.Text = Tabel.Rows(0).Item(0)
            End If
        End With
    End Sub

    Sub Kunci()
        Try
            SQl = "insert into tblStatus values('Locked')"
            Proses.ExecuteNonQuery(SQl)
            Statustxt.Text = Kode.Teks("tblStatus", "Status")
            NoSOtxt.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub Bersihkan()
        NmBrgtxt.Text = ""
        NoSOtxt.Text = ""
        KdBarangCmb.Text = ""
        Qtytxt.Text = ""
        Hargatxt.Text = ""
        NoSOtxt.Focus()
    End Sub
    Sub cari()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblRequest where NoRequest='" & NoReqtxt.Text & "' order by CodeBrg asc")
            If Tabel.Rows.Count = 0 Then
                MsgBox("No Request Tidak di temukan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "konfirmasi")
                Call Bersihkan()
                NoReqtxt.Focus()
            Else

                DGView.DataSource = Tabel
                DGView.Columns(4).DefaultCellStyle.Format = "C"
                DGView.Columns(0).Width = 70
                DGView.Columns(1).Width = 70
                DGView.Columns(2).Width = 60
                DGView.Columns(3).Width = 90
                DGView.Columns(4).Width = 90
                DGView.Columns(5).Width = 90
                DGView.Columns(6).Width = 120

                NoSOtxt.Focus()
                BtAdd.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiDGSales()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblSalesPerson order by NMSALES asc")
            CBNamasales.DataSource = Tabel
            CBNamasales.DisplayMember = "NMSALES"
            CBNamasales.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiCBcostumer()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblCustomer order by NmCust asc")
            CBNamaCostumer.DataSource = Tabel
            CBNamaCostumer.DisplayMember = "NmCust"
            CBNamaCostumer.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiCmb()
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblIvMst order by KdBrg asc")
            KdBarangCmb.DataSource = Tabel
            KdBarangCmb.DisplayMember = "KdBrg"
            KdBarangCmb.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Sub IsiDGview()
        Try
            Tabel = Proses.ExecuteQuery("Select NoRequest,NoSO,CodeBrg,Quantity,Harga,NamaSales,NamaCustomer,Pengajuan From tblRequest where NoRequest='" & NoReqtxt.Text & "' order by CodeBrg desc ")
            If Tabel.Rows.Count = 0 Then
                Call Bersihkan()
            End If
            DGView.DataSource = Tabel
            DGView.Columns(4).DefaultCellStyle.Format = "C"
            DGView.Columns(0).Width = 70
            DGView.Columns(1).Width = 70
            DGView.Columns(2).Width = 60
            DGView.Columns(3).Width = 90
            DGView.Columns(4).Width = 90
            DGView.Columns(5).Width = 90
            DGView.Columns(6).Width = 120


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Pengaturan()
        Call Bersihkan()
        Call KosongkanIsiCombo(Me)

        Call IsiCmb()
        Call IsiDGview()
        Call IsiCBcostumer()
        Call IsiDGSales()

        BtAdd.Enabled = True
        BtHapus.Enabled = False




    End Sub

    Private Sub FrmRequest_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call IsiNoRequest()
        Call Pengaturan()
        Statustxt.Text = Kode.Teks("tblStatus", "Status")




    End Sub


    Private Sub NoReqtxt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles NoReqtxt.KeyPress
        If e.KeyChar = Chr(13) Then
            If NoReqtxt.Text = "" Then
                MsgBox("No Request harus di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                NoReqtxt.Focus()
            Else
                cari()

            End If


        End If
    End Sub

    Private Sub NoSOtxt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles NoSOtxt.KeyPress
        If e.KeyChar = Chr(13) Then
            If NoSOtxt.Text = "" Then
                MsgBox("No SO tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                NoSOtxt.Focus()
            Else
                KdBarangCmb.Focus()
            End If
        End If
    End Sub

    Private Sub KdBarangCmb_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles KdBarangCmb.KeyPress
        If e.KeyChar = Chr(13) Then
            If KdBarangCmb.Text = "" Then
                MsgBox("Kode Barang tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                KdBarangCmb.Focus()
            Else
                Qtytxt.Focus()
            End If
        End If
    End Sub

    Private Sub Qtytxt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Qtytxt.KeyPress
        If e.KeyChar = Chr(13) Then
            If Qtytxt.Text = "" Then
                MsgBox("Quantity tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Qtytxt.Focus()
            Else
                Hargatxt.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            e.Handled = True

        End If
    End Sub

    Private Sub Hargatxt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Hargatxt.KeyPress
        If e.KeyChar = Chr(13) Then


            If Hargatxt.Text = "" Then
                MsgBox("Isi harga barang", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Pesan")
                Hargatxt.Focus()
            Else
                Hargatxt.Text = FormatCurrency(Hargatxt.Text, 0)
                BtAdd.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            e.Handled = True

        End If

    End Sub

    Sub simpan()
        Dim currency As Integer = Integer.Parse(Hargatxt.Text, Globalization.NumberStyles.Currency)
        Hargatxt.Text = currency
        Try
            SQl = "Insert into tblRequest Values ('" & NoReqtxt.Text & "','" & NoSOtxt.Text & "','" & KdBarangCmb.Text & "','" & Qtytxt.Text & "','" & Hargatxt.Text & "','" & CBNamasales.Text & "','" & CBNamaCostumer.Text & "','0','1')"
            Proses.ExecuteNonQuery(SQl)
            Call Bersihkan()
            Call IsiDGview()
            NoSOtxt.Focus()
        Catch ex As Exception
            MsgBox("Kode barang tersebut sudah di requsest, Untuk mengajukan request tunggu transaksi selesai di bagian Invoice", MsgBoxStyle.Information, "Pesan")
            KdBarangCmb.Focus()
        End Try
    End Sub

    Private Sub BtAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtAdd.Click
        If Pelengkap.Isi(KdBarangCmb.Text) = False Then Exit Sub
        If Pelengkap.Isi(Qtytxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(Hargatxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NoReqtxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(NoSOtxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(CBNamasales.Text) = False Then Exit Sub
        If Pelengkap.Isi(CBNamaCostumer.Text) = False Then Exit Sub

        Try
            Tabel = Proses.ExecuteQuery("Select * From tblStatus order by Status Desc")
            If Tabel.Rows.Count = 0 Then
                NoReqtxt.Text = Kode.Generate("tblRequest", "NoRequest")
                Call simpan()
                Call Kunci()
            Else
                Call simpan()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Sub

    Private Sub BtNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Statustxt.Text = "Locked" Then
            MsgBox("Transaksi tidak diperbolehkan, Minta Divisi Invoice untuk menutup Harga", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Konfirmasi")
            Bersihkan()
            NoSOtxt.Focus()
        Else
            NoReqtxt.Text = Kode.Generate("tblRequest", "NoRequest")
            SQl = "insert into tblStatus values('Locked')"
            Proses.ExecuteNonQuery(SQl)
            Statustxt.Text = Kode.Teks("tblStatus", "Status")
            NoSOtxt.Focus()


        End If
    End Sub

    Private Sub DGView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView.CellClick
        Try
            Dim i As Integer
            i = Me.DGView.CurrentRow.Index
            With DGView.Rows.Item(i)
                BtHapus.Enabled = False
                BtAdd.Enabled = True

                NoReqtxt.Text = .Cells(0).Value
                Call Bersihkan()
            End With
        Catch ex As Exception
            MsgBox("Database Kosong", MsgBoxStyle.Critical, "Pesan")
            NoSOtxt.Focus()

        End Try

    End Sub

    Private Sub DGView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView.CellDoubleClick
        Try
            Dim i As Integer
            i = Me.DGView.CurrentRow.Index
            With DGView.Rows.Item(i)
                BtHapus.Enabled = True
                BtAdd.Enabled = False

                NoReqtxt.Text = .Cells(0).Value
                NoSOtxt.Text = .Cells(1).Value
                KdBarangCmb.Text = .Cells(2).Value
                Qtytxt.Text = .Cells(3).Value
                Hargatxt.Text = .Cells(4).Value
                CBNamasales.Text = .Cells(5).Value
                CBNamaCostumer.Text = .Cells(6).Value
            End With
        Catch ex As Exception
            MsgBox("Database Kosong", MsgBoxStyle.Critical, "Pesan")
        End Try

    End Sub

    Private Sub BtHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHapus.Click
        If Pelengkap.Isi(KdBarangCmb.Text) = False Then Exit Sub
        Try
            SQl = "Delete From tblRequest where CodeBrg='" & KdBarangCmb.Text & "' and NoSO='" & NoSOtxt.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            MessageBox.Show("Data di hapus..", "Perubahan data sukses !!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Pengaturan()
            Call Bersihkan()
            BtAdd.Enabled = True
            BtHapus.Enabled = False



            NoSOtxt.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRefresh.Click
        IsiDGview()

        Statustxt.Text = Kode.Teks("tblStatus", "Status")
        NoSOtxt.Focus()
    End Sub

    Private Sub BtKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKembali.Click
        Call Bersihkan()
        Call KosongkanIsiCombo(Me)
        Call IsiDGview()

        BtAdd.Enabled = True
        BtHapus.Enabled = False


    End Sub

    Private Sub BtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExit.Click
        Me.Dispose()
    End Sub

    Private Sub DGView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGView.CellFormatting
        For Each row As DataGridViewRow In DGView.Rows
            If Not row.IsNewRow Then
                If Not row.Cells(7).Value Is DBNull.Value Then
                    If row.Cells(7).Value = "0" Then
                        row.DefaultCellStyle.ForeColor = Color.Red
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub KdBarangCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KdBarangCmb.SelectedIndexChanged
        Try
            Tabel = Proses.ExecuteQuery("Select * from tblIvMst where KdBrg='" & KdBarangCmb.Text & "' order by KdBrg")
            With Tabel
                NmBrgtxt.Text = Tabel.Rows(0).Item(1)

            End With
        Catch ex As Exception
            Call Bersihkan()
        End Try
       
    End Sub

  
End Class