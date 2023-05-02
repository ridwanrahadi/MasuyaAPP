Public Class FrmNearED

    Sub aturgrid()
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(1).HeaderText = "Kode Barang"
        Me.DataGridView1.Columns(2).HeaderText = "Nama Barang"
        Me.DataGridView1.Columns(3).HeaderText = "Qty"
        Me.DataGridView1.Columns(4).HeaderText = "Tanggal Expired"
        Me.DataGridView1.Columns(5).HeaderText = "Type Barang"
        Me.DataGridView1.Columns(6).HeaderText = "Lokasi"
        Me.DataGridView1.Columns(1).Frozen = True
    End Sub
    Sub isigrid()
        Try
            Tabel = Proses.ExecuteQuery("SELECT TOP 100 TblIvExpired.id,tblIvMst.KdBrg, tblIvMst.NmBrg, TblIvExpired.Qty, TblIvExpired.Tglexpired, TblIvType.NmType, tblIvMst.Lokasi FROM tblIvMst INNER JOIN TblIvExpired ON tblIvMst.KdBrg = TblIvExpired.Kdbrg INNER JOIN TblIvType ON tblIvMst.Type = TblIvType.KdType order by TblIvmst.Kdbrg ASC")
            DataGridView1.DataSource = Tabel
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmNearED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isigrid()
        Call aturgrid()
        Dim tanggal As DateTime = DateTime.Now
        lblCurrentdate.Text = (tanggal.ToLongDateString())
        Label6.Text = Format(DateAdd(DateInterval.Day, 90, DateTimePicker.Value), "dd-MMMM-yyyy")
    End Sub

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("select * from tblIvGstk where KdBrg='" & .Cells(1).Value & "'")

                ListView1.Items.Clear()
                For j As Integer = 0 To Tabel.Rows.Count - 1
                    With ListView1
                        .Items.Add(Tabel.Rows(j)("KdGd"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(Tabel.Rows(j)("Qty"))
                        End With
                    End With
                Next

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub
End Class