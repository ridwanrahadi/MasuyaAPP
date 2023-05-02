

Public Class FrmHisRetur

    Sub pengaturanDGVFrmRetur()
        FrmRetur.DGV.Columns(0).Width = 90
        FrmRetur.DGV.Columns(1).Width = 250
        FrmRetur.DGV.Columns(2).Width = 70
        FrmRetur.DGV.Columns(3).Width = 70
        FrmRetur.DGV.Columns(4).Width = 90
        FrmRetur.DGV.Columns(5).Width = 100
        FrmRetur.BtBaru.Enabled = False
        FrmRetur.BtSimpan.Enabled = False
        FrmRetur.BtKeluar.Enabled = True
        FrmRetur.BtEdit.Enabled = True
        FrmRetur.BtCari.Enabled = True
        FrmRetur.BtHapus.Enabled = True
        FrmRetur.BtKembali.Enabled = True
        FrmRetur.DGV.ReadOnly = True
        FrmRetur.CBCust.Enabled = False
        FrmRetur.txtCust.Enabled = False
        FrmRetur.txtNoFak.Enabled = False
        FrmRetur.txtDriver.Enabled = False
        FrmRetur.txtSales.Enabled = False
        FrmRetur.DTTanggal.Enabled = False
    End Sub
    Private Sub BtProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click
        Tabel = Proses.ExecuteQuery("Select * from tblGdRetur where tanggal >= '" & DTAwal.Text & "' and tanggal <= '" & DTAkhir.Text & "' order by tanggal asc")
        DGVHisRetur.DataSource = Tabel
        Me.DGVHisRetur.Columns(1).Visible = False
        Me.DGVHisRetur.Columns(3).Width = 60
        Me.DGVHisRetur.Columns(4).Width = 80
        Me.DGVHisRetur.Columns(0).Visible = False
        Me.DGVHisRetur.Columns(2).Width = 283
        Me.DGVHisRetur.Columns(5).Width = 80
        Me.DGVHisRetur.Columns(6).Width = 90
    End Sub
    Private Sub DGVHisRetur_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHisRetur.CellDoubleClick
        edit = True
        Dim i As Integer
        i = Me.DGVHisRetur.CurrentRow.Index
        With DGVHisRetur.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("Select * from tblGdRetur where NoBukti='" & .Cells(0).Value & "'")
                FrmRetur.txtNoBukti.Text = Tabel.Rows(0).Item(0)
                FrmRetur.txtKdCust.Text = Tabel.Rows(0).Item(1)
                FrmRetur.txtCust.Text = Tabel.Rows(0).Item(2)
                FrmRetur.DTTanggal.Value = Tabel.Rows(0).Item(3)
                FrmRetur.txtNoFak.Text = Tabel.Rows(0).Item(4)
                FrmRetur.txtSales.Text = Tabel.Rows(0).Item(5)
                FrmRetur.txtDriver.Text = Tabel.Rows(0).Item(6)
                FrmRetur.CBCust.Text = Tabel.Rows(0).Item(1)
                FrmRetur.Show()
                FrmRetur.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub

    Private Sub txtNoBukti_TextChanged(sender As Object, e As EventArgs) Handles txtNoBukti.TextChanged
        Try
            Tabel = Proses.ExecuteQuery("Select * from tblGdRetur where NoFaktur like '" & txtNoBukti.Text & "%' and tanggal >= '" & DTAwal.Text & "' and tanggal <= '" & DTAkhir.Text & "' order by tanggal asc")
            DGVHisRetur.DataSource = Tabel
            Me.DGVHisRetur.Columns(1).Visible = False
            Me.DGVHisRetur.Columns(3).Width = 60
            Me.DGVHisRetur.Columns(0).Visible = False
            Me.DGVHisRetur.Columns(2).Width = 283
            Me.DGVHisRetur.Columns(4).Width = 80
            Me.DGVHisRetur.Columns(5).Width = 80
            Me.DGVHisRetur.Columns(6).Width = 90

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtnmCust_TextChanged(sender As Object, e As EventArgs) Handles txtnmCust.TextChanged
        Try
            Tabel = Proses.ExecuteQuery("Select * from tblGdRetur where NmCust like '" & txtnmCust.Text & "%' and tanggal >= '" & DTAwal.Text & "' and tanggal <= '" & DTAkhir.Text & "' order by tanggal asc")
            DGVHisRetur.DataSource = Tabel
            Me.DGVHisRetur.Columns(1).Visible = False
            Me.DGVHisRetur.Columns(3).Width = 60
            Me.DGVHisRetur.Columns(4).Width = 80
            Me.DGVHisRetur.Columns(0).Visible = False
            Me.DGVHisRetur.Columns(2).Width = 283
            Me.DGVHisRetur.Columns(5).Width = 80
            Me.DGVHisRetur.Columns(6).Width = 90
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub DGVHisRetur_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHisRetur.CellClick
        Dim i As Integer
        i = Me.DGVHisRetur.CurrentRow.Index
        With DGVHisRetur.Rows.Item(i)
            Try
                Tabel = Proses.ExecuteQuery("Select * from tblGdReturDetail where NoBukti='" & .Cells(0).Value & "'")
                DGVHisDetail.DataSource = Tabel
                Me.DGVHisDetail.Columns(0).Visible = False
                Me.DGVHisDetail.Columns(1).Visible = False
                Me.DGVHisDetail.Columns(2).Width = 80
                Me.DGVHisDetail.Columns(3).Width = 250
                Me.DGVHisDetail.Columns(4).Width = 50
                Me.DGVHisDetail.Columns(5).Width = 50
                Me.DGVHisDetail.Columns(6).Visible = False
                Me.DGVHisDetail.Columns(7).Width = 200
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
            Try
                FrmReportLPB.LapPengembalianBarangBindingSource.Filter = "(Tanggal>='" & DTAwal.Text & "' and Tanggal<='" & DTAkhir.Text & "')"
                FrmReportLPB.Show()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
      


    End Sub
End Class