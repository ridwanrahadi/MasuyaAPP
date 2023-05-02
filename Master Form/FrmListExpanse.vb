Public Class FrmListExpanse
    Sub deletedata()
        Try
            Dim result As DialogResult = MessageBox.Show("Yakin akan menghapus pembayaran : Rp." & DataGridView1.CurrentRow.Cells(3).Value & " Kepada " & DataGridView1.CurrentRow.Cells(4).Value & " : ?", "Konfimrasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                SQl = "Delete from tblExpanse  where NoBukti='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data berhasil didelete !!!", MsgBoxStyle.Information, "Konfirmasi")
                btnsearch.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub GetTotal()
        Try
            If txtsearch.Text = "" Then
                Tabel = Proses.ExecuteQuery("SELECT SUM(Jumlah) AS Total FROM tblExpanse WHERE (Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "')")
                txtJumlah.Text = Tabel.Rows(0).Item("Total")
                txtJumlah.Text = FormatCurrency(txtJumlah.Text)
            Else
                Tabel = Proses.ExecuteQuery("SELECT SUM(Jumlah) AS Total FROM tblExpanse WHERE (TypeExpanse like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' or kepada like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' or keterangan like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "')")
                txtJumlah.Text = Tabel.Rows(0).Item("Total")
                txtJumlah.Text = FormatCurrency(txtJumlah.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub
    Sub DG()

        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N"
        With DataGridView1
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        End With
    End Sub
    Private Sub FrmListExpanse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("Select * from tblexpanse where Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' order by NoBukti desc")
        DataGridView1.DataSource = Tabel
        Call DG()
    End Sub


    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsearch.Focus()
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmExpense.Close()
        frmExpense.Show()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If txtsearch.Text = "" Then
            Tabel = Proses.ExecuteQuery("Select * from tblexpanse where Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' order by NoBukti desc")
            DataGridView1.DataSource = Tabel
        Else
            Tabel = Proses.ExecuteQuery("Select * from tblexpanse where TypeExpanse like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' or kepada like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' or keterangan like '%" & txtsearch.Text & "%' and Tanggal >='" & dt1.Text & "' and Tanggal <='" & dt2.Text & "' order by NoBukti desc")
            DataGridView1.DataSource = Tabel
        End If
        Call DG()
        Call GetTotal()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        frmExpense.Dispose()
        Dim i As Integer
        Dim nilai As Double
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("Select * from tblexpanse where NoBukti='" & .Cells(0).Value & "'")
                frmExpense.NoBuktiExpanse = Tabel.Rows(0).Item("NoBukti")
                frmExpense.DateTime.Text = Tabel.Rows(0).Item("Tanggal")
                frmExpense.cmbexpanse.Text = Tabel.Rows(0).Item("TypeExpanse")
                frmExpense.txtamount.Text = Tabel.Rows(0).Item("Jumlah")
                frmExpense.txtpaidTo.Text = Tabel.Rows(0).Item("Kepada")
                frmExpense.cmbPay.Text = Tabel.Rows(0).Item("CaraBayar")
                If Not IsDBNull(Tabel.Rows(0).Item("noRef")) Then
                    frmExpense.txtNoref.Text = Tabel.Rows(0).Item("noRef")
                Else
                    frmExpense.txtNoref.Text = ""
                End If
                frmExpense.txtpaidBy.Text = Tabel.Rows(0).Item("oleh")
                frmExpense.txtRemarks.Text = Tabel.Rows(0).Item("Keterangan")
                frmExpense.Show()
                nilai = Tabel.Rows(0).Item("Jumlah")

                frmExpense.LblT.Text = Kode.Terbilang(nilai)
                frmExpense.txtamount.Text = FormatNumber(frmExpense.txtamount.Text, 2)
                frmExpense.Text = "Expense"
                frmExpense.btnSaveUpdate.Text = "Update"
                frmExpense.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            'if possible insert code here to read selected option from context menu and get relevant content from respective cell

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call deletedata()
    End Sub
End Class