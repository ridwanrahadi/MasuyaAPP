Public Class FrmKlaim
    Dim baru As Boolean
    Sub NoOtomatis()
        Tabel = Proses.ExecuteQuery("Select * From TblKlaim order by NoKlaim desc ")
        If Tabel.Rows.Count = 0 Then
            txtNoKlaim.Text = "KL-" + "0001"
        Else
            With Tabel.Rows(0)
                txtNoKlaim.Text = Val(Microsoft.VisualBasic.Mid(.Item("NoKlaim").ToString, 4, 4)) + 1
                If Len(txtNoKlaim.Text) = 1 Then
                    txtNoKlaim.Text = "KL-000" & txtNoKlaim.Text & ""
                ElseIf Len(txtNoKlaim.Text) = 2 Then
                    txtNoKlaim.Text = "KL-00" & txtNoKlaim.Text & ""
                ElseIf Len(txtNoKlaim.Text) = 3 Then
                    txtNoKlaim.Text = "KL-0" & txtNoKlaim.Text & ""
                ElseIf Len(txtNoKlaim.Text) = 4 Then
                    txtNoKlaim.Text = "KL-" & txtNoKlaim.Text & ""
                End If

            End With
        End If
    End Sub
    Sub edit()
        Select Case Status

            Case True
                BtnEdit.Enabled = False
                BtnSimpan.Enabled = True
                Btnbatal.Enabled = True
                btnBaru.Enabled = False
                TxtDesk.ReadOnly = False
                DateTimePicker1.Enabled = True
                CBSup.Enabled = True
                txttotal.ReadOnly = False
            Case False

        End Select

    End Sub
    Sub clear()
        txtNoKlaim.Text = ""
        txttotal.Text = ""
        TxtDesk.Text = ""
        CBSup.Text = ""
        LblLunas.Visible = False
        btnBaru.Focus()
    End Sub

    Sub Pengaturan()

        Select Case baru

            Case True
                txtNoKlaim.ReadOnly = True
                TxtDesk.ReadOnly = True
                txttotal.ReadOnly = True
                DateTimePicker1.Enabled = False
                CBSup.Enabled = False
                BtnSimpan.Enabled = False
                BtnEdit.Enabled = False
                BtnHapus.Enabled = False
                Btnbatal.Enabled = False
                btnBaru.Enabled = True
            Case False
                txtNoKlaim.ReadOnly = False
                TxtDesk.ReadOnly = False
                DateTimePicker1.Enabled = True
                CBSup.Enabled = True
                BtnSimpan.Enabled = True
                btnBaru.Enabled = False
                BtnHapus.Enabled = False
                BtnEdit.Enabled = False
                Btnbatal.Enabled = True
                txttotal.ReadOnly = False


        End Select
    End Sub

    Private Sub FrmKlaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tabel = Proses.ExecuteQuery("select * from tblSupplier")
        CBSup.DataSource = Tabel
        CBSup.DisplayMember = "NmSup"
        CBSup.SelectedIndex = -1
        baru = True
        LblLunas.Visible = False
        Call Pengaturan()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        baru = False
        clear()
        Call Pengaturan()
        txtNoKlaim.Text = "--AUTO--"
    End Sub

    Private Sub Btnbatal_Click(sender As Object, e As EventArgs) Handles Btnbatal.Click
        baru = True
        clear()
        Call Pengaturan()
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
        'input number only
        If Asc(e.Handled) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        formatUang(txttotal)

    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        FrmListKlaim.Show()
        FrmListKlaim.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim tgl As String
        Dim total As Integer
        Dim multiline As String

        If CBSup.Text = "" Then
            MsgBox("Nama supplier belum ditentukan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf TxtDesk.Text = "" Then
            MsgBox("Deskripsi belum diisi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        ElseIf txttotal.Text = "" Then
            MsgBox("Total belum diisi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
        Else
            'variable multitext
            multiline = Replace(TxtDesk.Text, "\n", "<br/>")
            'menghilangkan titik koma pada number
            total = Replace(txttotal.Text, ".", "")
            tgl = Format(Now, "M/d/yyyy")

            If txtNoKlaim.Text = "--AUTO--" Then
                Call NoOtomatis()
            End If
            Tabel = Proses.ExecuteQuery("SELECT * FROM tblKlaim where NoKlaim='" & txtNoKlaim.Text & "'")
            If Tabel.Rows.Count > 0 Then
                'update data
                Try
                    SQl = "Update tblKlaim set supplier='" & CBSup.Text & "',tanggal='" & DateTimePicker1.Text & "',deskripsi='" & multiline & "',total='" & total & "' where NoKlaim='" & txtNoKlaim.Text & "'"
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Update data Klaim berhasil", MsgBoxStyle.Information, "Konfirmasi")
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try

            Else
                'simpan data
                Try
                    SQl = "Insert into tblKlaim Values('" & txtNoKlaim.Text & "','" & CBSup.Text & "','" & DateTimePicker1.Text & "','" & multiline & "','" & total & "','','0','" & tgl & "')"
                    Proses.ExecuteNonQuery(SQl)
                    MsgBox("Data sudah tersimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
            baru = True
            Call Pengaturan()
        End If
        

    End Sub

    Private Sub txtNoKlaim_TextChanged(sender As Object, e As EventArgs) Handles txtNoKlaim.TextChanged

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Status = True
        Call edit()
    End Sub
End Class