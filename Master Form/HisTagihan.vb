Public Class FrmHisTagihan
    Sub isiDG()
        Tabel = Proses.ExecuteQuery("Select TOP 100 NoTran,tanggal,NoBukti,Customer,Total,Kolektor from tbltagih order by notran desc ")
        DGView.DataSource = Tabel
        Me.DGView.Columns(4).DefaultCellStyle.Format = "Rp 0,00"

    End Sub
    Sub isiDG2()
        
        If txtCust.Text = "" Then
            Tabel = Proses.ExecuteQuery("Select NoTran,tanggal,NoBukti,Customer,Total,Kolektor from tbltagih where kolektor like '%" & txtSales.Text & "%' and tanggal >= '" & DateTimePicker1.Text & "' AND tanggal <= '" & DateTimePicker1.Text & "' order by notran desc ")
            DGView.DataSource = Tabel
            Me.DGView.Columns(4).DefaultCellStyle.Format = "Rp 0,00"
        ElseIf txtSales.Text = "" Then
            Tabel = Proses.ExecuteQuery("Select NoTran,tanggal,NoBukti,Customer,Total,Kolektor from tbltagih where Customer like '%" & txtCust.Text & "%' and tanggal >= '" & DateTimePicker1.Text & "' AND tanggal <= '" & DateTimePicker1.Text & "' order by notran desc ")
            DGView.DataSource = Tabel
            Me.DGView.Columns(4).DefaultCellStyle.Format = "Rp 0,00"
        ElseIf txtSales.Text = "" And txtCust.Text = "" Then
            Tabel = Proses.ExecuteQuery("Select NoTran,tanggal,NoBukti,Customer,Total,Kolektor from tbltagih where tanggal >= '" & DateTimePicker1.Text & "' AND tanggal <= '" & DateTimePicker1.Text & "' order by notran desc ")
            DGView.DataSource = Tabel
            Me.DGView.Columns(4).DefaultCellStyle.Format = "Rp 0,00"
        Else
            Tabel = Proses.ExecuteQuery("Select NoTran,tanggal,NoBukti,Customer,Total,Kolektor from tbltagih where customer like '%" & txtCust.Text & "%' and kolektor like %" & txtSales.Text & "' and tanggal >= '" & DateTimePicker1.Text & "' AND tanggal <= '" & DateTimePicker1.Text & "' order by notran desc ")
            DGView.DataSource = Tabel
            Me.DGView.Columns(4).DefaultCellStyle.Format = "Rp 0,00"
        End If
    End Sub
    Private Sub HisTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiDG()
    End Sub

    Private Sub Btncari_Click(sender As Object, e As EventArgs) Handles Btncari.Click
        Call isiDG2()
    End Sub
End Class