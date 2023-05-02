Public Class FrmBukaHarga
    Sub Pengaturan()
        Call IsiDGview()
        CBKdBarang.Text = ""
        CBKdBarang.Focus()
    End Sub
    Sub IsiCombo()
        Tabel = Proses.ExecuteQuery("Select * From tblIvMst where NonAktif = 0 order by KdBrg")
        CBKdBarang.DataSource = Tabel
        CBKdBarang.DisplayMember = "KdBrg"
        CBKdBarang.SelectedIndex = -1

    End Sub
    Sub IsiDGview()
        Try
            Tabel = Proses.ExecuteQuery("Select KdBrg,NmBrg,NonInventory from tblIvMst where NonInventory=1 order by Kdbrg")
            DGVbuka.DataSource = Tabel
            DGVbuka.Columns(1).Width = 170

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub FrmBukaHarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Pengaturan()
        Call IsiCombo()

    End Sub

    Private Sub BtProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses.Click
        If CBKdBarang.Text = "" Then
            MsgBox("Isi kode barang", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            CBKdBarang.Focus()
        Else
            Try
                SQl = "Update tblIvMst Set NonInventory=1 where KdBrg='" & CBKdBarang.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                Call Pengaturan()
            Catch ex As Exception
                MsgBox("Buka harga gagal", MsgBoxStyle.Critical, "Pesan")
            End Try
        End If
    End Sub

    Private Sub BtRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRefresh.Click
        Call Pengaturan()
    End Sub

    Private Sub BtTutup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTutup1.Click
        Try
            SQl = "Update tblIvMst set NonInventory=0 where KdBrg='" & CBKdBarang.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtTutup2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTutup2.Click
        Try
            SQl = "Update tblIvMst set NonInventory=0 "
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses1.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y199','y200')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y271','y290')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses3.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y236','y237','y238','y239','y241')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

   

    Private Sub BtProses4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses4.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y256','y257')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses5.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('MPLD008','mpld052','mplf015','mpld048ma','mplf011','mplf012','mplf017ma','mplf016ma','mpld048ma','PLD001A','MPLD009','MPLD047A','MPLD047MA','mplf009')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses6.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y292','y293','y294','y295')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    
    Private Sub BtProses7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtProses7.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y273','y291')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub CBKdBarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBKdBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            BtProses.Focus()
        End If
    End Sub
    Private Sub CBKdBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles CBKdBarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                SQl = "Update tblIvMst Set NonInventory=1 where KdBrg='" & CBKdBarang.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                Call Pengaturan()
            Catch ex As Exception
                MsgBox("Buka harga gagal", MsgBoxStyle.Critical, "Pesan")
            End Try
        End If
    End Sub

    Private Sub BtProses10_Click(sender As Object, e As EventArgs) Handles BtProses10.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('y296','y297')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses8_Click(sender As Object, e As EventArgs) Handles BtProses8.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('NYG002','NYG018','NYG019','NYG024','NYG025','NYG028','NYG029','NYG033''NYG034','NYG035','NYG036','nyg034')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

  
    Private Sub BtProses11_Click(sender As Object, e As EventArgs) Handles BtProses11.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('vi001','vi002')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtProses9_Click(sender As Object, e As EventArgs) Handles BtProses9.Click
        Try
            SQl = "Update tblIvMst set NonInventory=1 where KdBrg IN ('n477','n701','n467a','n467b')"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Proses berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Call Pengaturan()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmHPP.Show()
    End Sub
End Class