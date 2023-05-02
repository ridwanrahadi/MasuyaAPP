Public Class FrmUtama
    Sub Akses()
        Tabel = Proses.ExecuteQuery("Select * from tblPengguna where Username='" & Unametxt.Text & "'")
        With Tabel.Rows(0)
            BtTagihan.Enabled = .Item("Tagihan")
            BtBukaHarga.Enabled = .Item("BukaHarga")
            BtLaporan.Enabled = .Item("Laporan")
            BtStatus.Enabled = .Item("Klaim")
            BtTax.Enabled = .Item("Tax")
            BtLostCust.Enabled = .Item("LostCust")
            BtPrintPO.Enabled = .Item("PrintPO")
            Btgudang.Enabled = .Item("Gudang")
            BtLapSales.Enabled = .Item("LapSales")
            btnIvMst.Enabled = .Item("inventory")
            btnSO.Enabled = .Item("SO")
            btnprinciple.Enabled = .Item("principle")
            btnExpense.Enabled = .Item("expense")
            BtLogin.Enabled = False
            BtKeluar.Enabled = True
            Pswtxt.Visible = False
            LabelPass.Visible = False
            Unametxt.Enabled = False
        End With
        MsgBox("Login Succses...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub
    Sub Pengaturan()
        Unametxt.Text = ""
        Pswtxt.Text = ""
        BtKeluar.Enabled = False
        btnIvMst.Enabled = False
        BtLapSales.Enabled = False
        BtBukaHarga.Enabled = False
        Btgudang.Enabled = False
        btnExpense.Enabled = False
        BtLapSales.Enabled = False
        BtTagihan.Enabled = False
        BtStatus.Enabled = False
        BtPrintPO.Enabled = False
        BtTax.Enabled = False
        BtLaporan.Enabled = False
        BtLogin.Enabled = True
        BtLostCust.Enabled = False
        btnSO.Enabled = False
        btnprinciple.Enabled = False
        Pswtxt.Visible = True
        LabelPass.Visible = True
        Unametxt.Enabled = True
        Unametxt.Focus()
    End Sub

    Private Sub FrmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbLocalDataSet.TblLogin' table. You can move, or remove it, as needed.
        Dim sc As String
        sc = (System.Threading.Thread.CurrentThread.CurrentCulture.ToString)
        If sc <> "en-US" Then
            MessageBox.Show("Anda harus merubah settingan region dan language ke English US", "Current region : " & sc, MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Diagnostics.Process.Start("intl.cpl")
            End
        End If
        Me.TblLoginTableAdapter.Fill(Me.DbLocalDataSet.TblLogin)
        Call Pengaturan()
        Label4.Text = My.Application.Info.Version.ToString



    End Sub

    Private Sub BtLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLogin.Click
        If Pelengkap.Isi(Unametxt.Text) = False Then Exit Sub
        If Pelengkap.Isi(Pswtxt.Text) = False Then Exit Sub
        Tabel = Proses.ExecuteQuery("Select * from tblSysInfo")
        Try
            Tabel = Proses.ExecuteQuery("Select * From tblPengguna where username='" & Unametxt.Text & "' and password='" & Pswtxt.Text & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("Username & Password tidak valid", MsgBoxStyle.Critical, "Pesan")
            Else
                Call Akses()
                DatabaseTextBox.Enabled = False
                ServerTextBox.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Cek kembali nama server & database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            ServerTextBox.Focus()
        End Try
        Try
            Me.Validate()
            Me.TblLoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DbLocalDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Terjadi kesalahan di local database", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        End Try


    End Sub

    Private Sub BtKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKeluar.Click
        Call Pengaturan()
        DatabaseTextBox.Enabled = True
        ServerTextBox.Enabled = True

    End Sub

    Private Sub BtFRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmRequest.Show()
    End Sub

 

    Private Sub BtStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtStatus.Click
        FrmSelKlaim.Show()
    End Sub

    Private Sub BtBukaHarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBukaHarga.Click
        FrmBukaHarga.Show()
    End Sub


    Private Sub Pswtxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pswtxt.KeyPress
        If e.KeyChar = Chr(13) Then
            BtLogin.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTax.Click
        SelectedTax.ShowDialog()
    End Sub

    Private Sub BtLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLaporan.Click
        FrmLaporan.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtTagihan.Click
        FrmTagih.Show()
    End Sub

    Private Sub BtKunjungan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmSales.Show()
    End Sub

    Private Sub BtAccount_Click(sender As Object, e As EventArgs) Handles BtAccount.Click
        If Unametxt.Text = "ADMIN" Then
            FrmAccount.Show()
        Else
            MsgBox("Anda tidak punya otoritas", MsgBoxStyle.Critical, "Peringantan kerassss")
        End If


    End Sub

    Private Sub BtExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLostCust.Click
        FrmLostCust.Show()
    End Sub

    Private Sub BtPrintPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrintPO.Click
        FrmPrintPO.Show()
    End Sub

    Private Sub BtKedatangan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btgudang.Click
        FrmExtendGudang.Show()
    End Sub

    Private Sub BtLapSales_Click(sender As Object, e As EventArgs) Handles BtLapSales.Click
        FrmLaporanSales.Show()
    End Sub

  

    Private Sub btnSO_Click(sender As Object, e As EventArgs) Handles btnSO.Click
        FrmDataSO.Show()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnprinciple.Click
        FrmLaporanPrinciple.Show()
    End Sub

    Private Sub TblLoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblLoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblLoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbLocalDataSet)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        FrmExportTaxReture.Show()
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        FrmListExpanse.Show()
    End Sub

    Private Sub btnIvMst_Click(sender As Object, e As EventArgs) Handles btnIvMst.Click
        FrmSafetyStock.Show()
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs)
        FrmEstimasi.Show()
    End Sub

End Class
