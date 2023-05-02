Public Class FrmListKlaim

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        If CheckBox1.Checked = True Then
            If txtNmSup.Text = "" Then
                Tabel = Proses.ExecuteQuery("Select NoKlaim,Supplier,Tanggal,deskripsi,Total,Lunas from tblklaim where tanggal>='" & Dt1.Text & "' and tanggal<='" & Dt2.Text & "' and lunas='1'")
            Else
                Tabel = Proses.ExecuteQuery("Select NoKlaim,Supplier,Tanggal,deskripsi,Total,Lunas from tblklaim where tanggal>='" & Dt1.Text & "' and tanggal<='" & Dt2.Text & "' and Supplier like '%" & txtNmSup.Text & "%' and lunas='1'")
            End If
        Else
            If txtNmSup.Text = "" Then
                Tabel = Proses.ExecuteQuery("Select NoKlaim,Supplier,Tanggal,deskripsi,Total,Lunas from tblklaim where tanggal>='" & Dt1.Text & "' and tanggal<='" & Dt2.Text & "'")
            Else
                Tabel = Proses.ExecuteQuery("Select NoKlaim,Supplier,Tanggal,deskripsi,Total,Lunas from tblklaim where tanggal>='" & Dt1.Text & "' and tanggal<='" & Dt2.Text & "' and Supplier like '%" & txtNmSup.Text & "%'")
            End If
        End If
       
        DataGridView1.DataSource = Tabel
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N"
    End Sub

    Private Sub FrmListKlaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)

            Try
                Tabel = Proses.ExecuteQuery("SELECT * FROM tblKlaim where NoKlaim='" & .Cells(0).Value & "'")
               
                FrmKlaim.txtNoKlaim.Text = Tabel.Rows(0).Item(0)
                FrmKlaim.CBSup.Text = Tabel.Rows(0).Item(1)
                FrmKlaim.DateTimePicker1.Text = Tabel.Rows(0).Item(2)
                FrmKlaim.TxtDesk.Text = Tabel.Rows(0).Item(3)
                FrmKlaim.txttotal.Text = Tabel.Rows(0).Item(4)
               

               
                FrmKlaim.Show()
                FrmKlaim.Focus()
                Tabel = Proses.ExecuteQuery("SELECT * FROM tblKlaim where NoKlaim='" & FrmKlaim.txtNoKlaim.Text & "'")
                If Tabel(0).Item(5) = "1" Then
                    FrmKlaim.LblLunas.Visible = True
                Else
                    FrmKlaim.LblLunas.Visible = False
                End If
                FrmKlaim.BtnEdit.Enabled = True
                FrmKlaim.BtnHapus.Enabled = True
                FrmKlaim.btnBaru.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End With
    End Sub
End Class