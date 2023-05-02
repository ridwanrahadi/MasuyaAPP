Public Class FrmPelunasanKlaim
    Private baru As Boolean
    Sub NoOtomatis()
        Tabel = Proses.ExecuteQuery("Select * From Tblreceivklaim order by NoBukti desc ")
        If Tabel.Rows.Count = 0 Then
            txtNoLunas.Text = "PK-" + "0001"
        Else
            With Tabel.Rows(0)
                txtNoLunas.Text = Val(Microsoft.VisualBasic.Mid(.Item("NoBukti").ToString, 4, 4)) + 1
                If Len(txtNoLunas.Text) = 1 Then
                    txtNoLunas.Text = "PK-000" & txtNoLunas.Text & ""
                ElseIf Len(txtNoLunas.Text) = 2 Then
                    txtNoLunas.Text = "PK-00" & txtNoLunas.Text & ""
                ElseIf Len(txtNoLunas.Text) = 3 Then
                    txtNoLunas.Text = "PK-0" & txtNoLunas.Text & ""
                ElseIf Len(txtNoLunas.Text) = 4 Then
                    txtNoLunas.Text = "PK-" & txtNoLunas.Text & ""
                End If

            End With
        End If
    End Sub
    Sub Pengaturan()

        Select Case baru

            Case True
                txtNoLunas.ReadOnly = True
                txtbayar.ReadOnly = True

                cbakun.Enabled = False
                cbklaim.Enabled = False
                txtket.ReadOnly = True
                DateTimePicker1.Enabled = False
                cbsup.Enabled = False
                btnbaru.Enabled = False
                btnubah.Enabled = False
                btnhapus.Enabled = False
                btnclear.Enabled = False
                btnsimpan.Enabled = False
                btnbaru.Enabled = True
                clear()
            Case False
                txtNoLunas.ReadOnly = False
                txtbayar.ReadOnly = False

                cbakun.Enabled = True
                cbklaim.Enabled = True
                txtket.ReadOnly = False
                DateTimePicker1.Enabled = True
                cbsup.Enabled = True
                btnbaru.Enabled = True
                btnbaru.Enabled = False
                btnhapus.Enabled = False
                btnubah.Enabled = False
                btnclear.Enabled = True
                btnsimpan.Enabled = True
                cbsup.Focus()

        End Select
    End Sub
    Sub clear()
        txtNoLunas.Text = ""
        cbsup.SelectedIndex = -1
        TxtDesk.Text = ""
        cbsup.SelectedIndex = -1
        cbakun.SelectedIndex = -1
        cbklaim.Text = ""
        txtket.Text = ""
        txtbayar.Text = ""
        txtselisih.Text = ""
        txttotal.Text = ""

        lblakun.Text = "-"
        btnBaru.Focus()
    End Sub
    Private Sub FrmPelunasanKlaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("Select * from tblGLAccount")
        cbakun.DataSource = Tabel
        cbakun.DisplayMember = "KdAcct"
        Tabel = Proses.ExecuteQuery("Select * from tblsupplier")
        cbsup.DataSource = Tabel
        cbsup.DisplayMember = "NmSup"
        baru = True
        Call Pengaturan()
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        baru = False
        Call Pengaturan()
        txtNoLunas.Text = "--AUTO--"
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        baru = True
        cbklaim.DataSource = Nothing
        Call Pengaturan()

    End Sub


    Private Sub cbsup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsup.SelectedIndexChanged
        Tabel = Proses.ExecuteQuery("Select * from tblKlaim where supplier='" & cbsup.Text & "' and lunas=0")
        cbklaim.DataSource = Tabel
        cbklaim.DisplayMember = "NoKlaim"
        cbklaim.SelectedIndex = -1
    End Sub


    Private Sub cbklaim_Leave(sender As Object, e As EventArgs) Handles cbklaim.Leave
        If cbklaim.Text = "" Then
            txtDesk.Text = ""
            txttotal.Text = ""
        Else
            Tabel = Proses.ExecuteQuery("SELECT * FROM tblKlaim where NoKlaim='" & cbklaim.Text & "'")
            txtDesk.Text = Tabel.Rows(0).Item(3)
            txttotal.Text = Tabel.Rows(0).Item(4)
        End If
        
    End Sub

    Private Sub cbakun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbakun.SelectedIndexChanged
        Tabel = Proses.ExecuteQuery("Select * from tblGLAccount where KdAcct='" & cbakun.Text & "'")
        If cbakun.Text = "" Then
            lblakun.Text = "-"
        Else
            If Tabel.Rows.Count > 0 Then
                lblakun.Text = Tabel(0).Item(1)
            End If

        End If
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        formatUang(txttotal)
    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged
        formatUang(txtbayar)
    End Sub

    Private Sub txtbayar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbayar.KeyDown
        Dim a, b, c As Integer
        If e.KeyCode = Keys.Enter Then
            a = Replace(txttotal.Text, ".", "")
            b = Replace(txtbayar.Text, ".", "")
            c = a - b
            txtselisih.Text = c
            txtselisih.Focus()
        End If
    End Sub

    Private Sub txtselisih_TextChanged(sender As Object, e As EventArgs) Handles txtselisih.TextChanged
        formatUang(txtselisih)
    End Sub

    Private Sub txtselisih_KeyDown(sender As Object, e As KeyEventArgs) Handles txtselisih.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim tgl As String
        Dim bayar, total, selisih As Integer

        bayar = Replace(txtbayar.Text, ".", "")
        total = Replace(txttotal.Text, ".", "")
        selisih = Replace(txtselisih.Text, ".", "")
        tgl = Format(Now, "M/d/yyyy")
        If cbsup.Text = "" Then
            MsgBox("Nama supplier belum ditentukan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf cbakun.Text = "" Then
            MsgBox("Kolom Account belum diisi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf cbklaim.Text = "" Then
            MsgBox("Kolom Klaim belum diisi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf txtbayar.Text = "" Then
            MsgBox("Isi kolom bayar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf txtselisih.Text <> 0 Then
            MsgBox("Total terjadi selisih", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        Else
            If txtNoLunas.Text = "--AUTO--" Then
                Call NoOtomatis()
            End If
            Tabel = Proses.ExecuteQuery("SELECT * FROM tblreceivklaim where NoBukti='" & txtNoLunas.Text & "'")
            If Tabel.Rows.Count > 0 Then
                'update data
                ' Try
                'SQl = "Update tblKlaim set "
                '  Proses.ExecuteNonQuery(SQl)
                '  MsgBox("Update data Klaim berhasil", MsgBoxStyle.Information, "Konfirmasi")
                '  Catch ex As Exception
                'MsgBox(ex.ToString())
                '  End Try

            Else
                'simpan data
                Try
                    SQl = "Insert into tblreceivklaim Values('" & txtNoLunas.Text & "','" & DateTimePicker1.Text & "','" & cbakun.Text & "','" & cbsup.Text & "','" & bayar & "','" & total & "','" & selisih & "','" & tgl & "','" & txtket.Text & "')"
                    Proses.ExecuteNonQuery(SQl)
                    SQl = "Update tblKlaim set bayar='" & bayar & "' where noklaim='" & cbklaim.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    If txttotal.Text = txtbayar.Text Then
                        SQl = "Update tblKlaim set lunas='1' where noklaim='" & cbklaim.Text & "'"
                        Proses.ExecuteNonQuery(SQl)
                    End If
                    MsgBox("Data sudah tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                    baru = True
                    Call Pengaturan()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
           
        End If

    End Sub

    Private Sub txtbayar_Leave(sender As Object, e As EventArgs) Handles txtbayar.Leave
        Dim a, b, c As Integer

        a = Replace(txttotal.Text, ".", "")
        b = Replace(txtbayar.Text, ".", "")
        c = a - b
        txtselisih.Text = c
        txtselisih.Focus()

    End Sub
End Class