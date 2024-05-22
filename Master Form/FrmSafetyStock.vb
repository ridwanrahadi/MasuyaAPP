
Public Class FrmSafetyStock
    Dim tanggal_hari_ini
    Dim sampai_tanggal
    Dim bulan As Integer
    Sub pengaturandatagrid1()
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(2).Width = 250

    End Sub
    Sub pengaturandatagrid2()
        Me.DataGridView2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView2.Columns(1).Width = 300
    End Sub
    Private Sub FrmSafetyStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Timer1.Stop()
        Tabel = Proses.ExecuteQuery("select * from tblIvType")
        cbType.DataSource = Tabel
        cbType.DisplayMember = "Nmtype"
        cbType.SelectedIndex = -1
    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        txtKdbrg.Text = ""
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        If txtKdbrg.Text = "" And cbType.Text = "" Then
            MsgBox("Isi kode atau type barang !", MsgBoxStyle.Exclamation, "Konfirmasi")
            txtKdbrg.Focus()
        Else
            If Not BackgroundWorker1.IsBusy Then
                lblLoading.Visible = True
                Timer1.Start()
                BackgroundWorker1.RunWorkerAsync()
            Else
                MsgBox("Sedang Proses", MsgBoxStyle.Critical, "Konfirmasi")
            End If
        End If
       

    End Sub


    Private Sub btnSafStock_Click(sender As Object, e As EventArgs) Handles btnSafStock.Click

        If cbType.Text = "" And txtKdbrg.Text = "" Then
            MsgBox("Pilih filter barang terlebih dahulu !!!", MsgBoxStyle.Exclamation, "Konfimrasi")

        Else
            If txtKdbrg.Text = "" Then
                Try
                    Tabel = Proses.ExecuteQuery("SELECT tblIvMst.KdBrg, tblIvMst.NmBrg, tblIvMst.Type, TblIvType.NmType, SUM(tblIvGstk.Qty) AS GoodStock, tblIvMst.QtyMin" _
                                            & " FROM TblIvType INNER JOIN" _
                                            & " tblIvMst ON TblIvType.KdType = tblIvMst.Type LEFT OUTER JOIN" _
                                            & " tblIvGstk ON tblIvMst.KdBrg = tblIvGstk.KdBrg" _
                                            & " WHERE (tblIvGstk.KdGd IN ('SP', 'CB'))" _
                                            & " GROUP BY tblIvMst.KdBrg, tblIvMst.NmBrg, tblIvMst.QtyMin, TblIvType.NmType, tblIvMst.Type" _
                                            & " HAVING (TblIvType.NmType = '" & cbType.Text & "')")
                    DataGridView2.DataSource = Tabel
                    Call pengaturandatagrid2()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            ElseIf cbType.Text = "" Or txtKdbrg.Text <> "" And cbType.Text <> "" Then
                Try
                    Tabel = Proses.ExecuteQuery("SELECT tblIvMst.KdBrg, tblIvMst.NmBrg, tblIvMst.Type, TblIvType.NmType, SUM(tblIvGstk.Qty) AS GoodStock, tblIvMst.QtyMin" _
                                            & " FROM TblIvType INNER JOIN" _
                                            & " tblIvMst ON TblIvType.KdType = tblIvMst.Type LEFT OUTER JOIN" _
                                            & " tblIvGstk ON tblIvMst.KdBrg = tblIvGstk.KdBrg" _
                                            & " WHERE (tblIvGstk.KdGd IN ('SP', 'CB'))" _
                                            & " GROUP BY tblIvMst.KdBrg, tblIvMst.NmBrg, tblIvMst.QtyMin, TblIvType.NmType, tblIvMst.Type" _
                                            & " HAVING (tblIvMst.KdBrg = '" & txtKdbrg.Text & "')")
                    DataGridView2.DataSource = Tabel
                    Call pengaturandatagrid2()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If


        End If


    End Sub

    Private Sub btnUpdateMinimum_Click(sender As Object, e As EventArgs) Handles btnUpdateMinimum.Click
        If DataGridView1.ColumnCount = 0 Then
            MsgBox("Data table belum tersedia!!!", MsgBoxStyle.Exclamation, "Konfirmasi")
        Else
            Try
                For t As Integer = 0 To DataGridView1.Rows.Count - 1
                    SQl = "update tblIvMst set QtyMin='" & DataGridView1.Rows(t).Cells(9).Value & "' where KdBrg='" & DataGridView1.Rows(t).Cells(1).Value & "'"
                    Proses.ExecuteNonQuery(SQl)
                Next
                MsgBox("Update Qty Minimum berhasil", MsgBoxStyle.Information, "Konfirmasi")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If


    End Sub

    Private Sub DataGridView2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView2.RowPrePaint
        Try
            For t As Integer = 0 To DataGridView2.Rows.Count - 1
                If Val(DataGridView2.Rows(t).Cells(4).Value < DataGridView2.Rows(t).Cells(5).Value) Then
                    DataGridView2.Rows(t).DefaultCellStyle.ForeColor = Color.Red
                End If
                If Val(DataGridView2.Rows(t).Cells(5).Value = 0) Then
                    DataGridView2.Rows(t).Cells(5).Style.BackColor = Color.Yellow
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim tanggal_hari_ini
        Dim sampai_tanggal
        Dim bulan As Integer

       If txtKdbrg.Text = "" Then
            Try

                bulan = DateDiff(DateInterval.Month, Dt1.Value, Dt2.Value)
                'tanggal_hari_ini = Format(Date.Now, "M/dd/yyyy")
                'sampai_tanggal = Format(DateAdd(DateInterval.Month, -bulan, tanggal_hari_ini), "M/dd/yyyy")
                DataGridView1.Columns.Clear()
                Tabel = Proses.ExecuteQuery("SELECT TblFak.JnsTrans, TblFakDtl.KdBrg, tblIvMst.NmBrg,TblFakDtl.Satuan, tblIvMst.Type, MAX(a.Total) AS MAX, cast(AVG(a.Total) AS decimal(18,2)) AS AVG, CAST(MAX(a.Total) - AVG(a.Total) AS DECIMAL(18, 2)) AS [max-avg], tblIvMst.LeadTime" _
                         & " FROM TblFakDtl INNER JOIN" _
                         & " TblFak ON TblFakDtl.NoBukti = TblFak.NoBukti INNER JOIN" _
                         & " tblIvMst ON TblFakDtl.KdBrg = tblIvMst.KdBrg INNER JOIN" _
                         & " TblIvType ON tblIvMst.Type = TblIvType.KdType LEFT OUTER JOIN" _
                         & " (SELECT TblFak_1.JnsTrans, TblFakDtl_1.KdBrg, TblFakDtl_1.NmBrg, SUM(TblFakDtl_1.Qty) AS Total, MONTH(TblFak_1.Tgl) AS bln, YEAR(TblFak_1.Tgl) AS tahun" _
                           & " FROM TblFak AS TblFak_1 INNER JOIN" _
                           & " TblFakDtl AS TblFakDtl_1 ON TblFak_1.NoBukti = TblFakDtl_1.NoBukti" _
                           & " WHERE TblFak_1.Tgl >= '" & Dt1.Value & "' AND TblFak_1.Tgl <= '" & Dt2.Value & "'" _
                           & " GROUP BY TblFak_1.JnsTrans, TblFakDtl_1.KdBrg, TblFakDtl_1.NmBrg, MONTH(TblFak_1.Tgl), YEAR(TblFak_1.Tgl)" _
                           & " HAVING  (TblFak_1.JnsTrans = 'jl')) AS a ON TblFakDtl.KdBrg = a.KdBrg" _
                           & " WHERE TblFak.Tgl >= '" & Dt1.Value & "' AND TblFak.Tgl <= '" & Dt2.Value & "'" _
                           & " GROUP BY TblFak.JnsTrans, TblFakDtl.KdBrg, tblIvMst.Type,TblIvType.NmType, tblIvMst.NmBrg, tblIvMst.LeadTime, TblFakDtl.Satuan" _
                           & " HAVING (TblFak.JnsTrans = 'JL') AND (TblIvType.NmType = '" & cbType.Text & "')")
                DataGridView1.DataSource = Tabel

                'Label1.Text = tanggal_hari_ini
                'Label2.Text = sampai_tanggal
                'Isi Qty Minimum
                Me.DataGridView1.Columns.Add("Qty-minimum", "Qty-minimum")
                For t As Integer = 0 To DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(t).Cells(9).Value = DataGridView1.Rows(t).Cells(7).Value * DataGridView1.Rows(t).Cells(8).Value
                Next
                Call pengaturandatagrid1()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf cbType.Text = "" Or cbType.Text <> "" And txtKdbrg.Text <> "" Then
            Try
                bulan = DateDiff(DateInterval.Month, Dt1.Value, Dt2.Value)
                'tanggal_hari_ini = Format(Date.Now, "M/dd/yyyy")
                ' sampai_tanggal = Format(DateAdd(DateInterval.Month, -bulan, tanggal_hari_ini), "M/dd/yyyy")
                DataGridView1.Columns.Clear()
                Tabel = Proses.ExecuteQuery("SELECT TblFak.JnsTrans, TblFakDtl.KdBrg, tblIvMst.NmBrg,TblFakDtl.Satuan, tblIvMst.Type, MAX(a.Total) AS MAX, cast(AVG(a.Total) AS decimal(18,2)) AS AVG, CAST(MAX(a.Total) - AVG(a.Total) AS DECIMAL(18, 2)) AS [max-avg], tblIvMst.LeadTime" _
                         & " FROM TblFakDtl INNER JOIN" _
                         & " TblFak ON TblFakDtl.NoBukti = TblFak.NoBukti INNER JOIN" _
                         & " tblIvMst ON TblFakDtl.KdBrg = tblIvMst.KdBrg INNER JOIN" _
                         & " TblIvType ON tblIvMst.Type = TblIvType.KdType LEFT OUTER JOIN" _
                         & " (SELECT TblFak_1.JnsTrans, TblFakDtl_1.KdBrg, TblFakDtl_1.NmBrg, SUM(TblFakDtl_1.Qty) AS Total, MONTH(TblFak_1.Tgl) AS bln, YEAR(TblFak_1.Tgl) AS tahun" _
                           & " FROM TblFak AS TblFak_1 INNER JOIN" _
                           & " TblFakDtl AS TblFakDtl_1 ON TblFak_1.NoBukti = TblFakDtl_1.NoBukti" _
                           & " WHERE TblFak_1.Tgl >= '" & Dt1.Value & "' AND TblFak_1.Tgl <= '" & Dt2.Value & "'" _
                           & " GROUP BY TblFak_1.JnsTrans, TblFakDtl_1.KdBrg, TblFakDtl_1.NmBrg, MONTH(TblFak_1.Tgl), YEAR(TblFak_1.Tgl)" _
                           & " HAVING  (TblFak_1.JnsTrans = 'jl')) AS a ON TblFakDtl.KdBrg = a.KdBrg" _
                           & " WHERE TblFak.Tgl >= '" & Dt1.Value & "' AND TblFak.Tgl <= '" & Dt2.Value & "'" _
                           & " GROUP BY TblFak.JnsTrans, TblFakDtl.KdBrg, tblIvMst.Type, tblIvMst.NmBrg, tblIvMst.LeadTime, TblFakDtl.Satuan" _
                           & " HAVING (TblFak.JnsTrans = 'JL') AND (TblFakDtl.KdBrg = '" & txtKdbrg.Text & "')")
                DataGridView1.DataSource = Tabel
                'Label1.Text = tanggal_hari_ini
                'Label2.Text = sampai_tanggal
                'Label9.Text = bulan

                'Isi Qty Minimum
                Me.DataGridView1.Columns.Add("Qty-minimum", "Qty-minimum")
                For t As Integer = 0 To DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(t).Cells(9).Value = DataGridView1.Rows(t).Cells(7).Value * DataGridView1.Rows(t).Cells(8).Value
                Next
                Call pengaturandatagrid1()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub



    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        lblLoading.Visible = False
        Timer1.Stop()
        MsgBox("Pengambilan Data selesai", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim jumlah As Integer
        lblLoading.Text = lblLoading.Text + "."
        jumlah = Microsoft.VisualBasic.Len(lblLoading.Text)
        If jumlah = 10 Then
            lblLoading.Text = "LOADING"
        End If
    End Sub
End Class