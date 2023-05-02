Public Class frmExpense
    Public NoBuktiExpanse As String
    Sub print()
        FrmReportExp.TblExpanseBindingSource.Filter = "(NoBukti='" & NoBuktiExpanse & "')"
        FrmReportExp.Show()
    End Sub
    Sub pengaturanForm()
        cmbexpanse.Text = ""
        cmbPay.Text = ""
        txtamount.Text = ""
        txtpaidBy.Text = ""
        txtpaidTo.Text = ""
        txtRemarks.Text = ""
        txtNoref.Text = ""
    End Sub
    Sub dataupdate()
        Dim total As Double
        total = Replace(txtamount.Text, ",", "")
        'Update Data expanse
        Try
            Dim result As DialogResult = MessageBox.Show("Yakin data ini akan diupdate ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SQl = "update tblExpanse Set Tanggal='" & DateTime.Text & "',TypeExpanse='" & cmbexpanse.Text & "',Jumlah='" & total & "',Kepada='" & txtpaidTo.Text & "',CaraBayar='" & cmbPay.Text & "',NoRef='" & txtNoref.Text & "',Keterangan='" & txtRemarks.Text & "' where NoBukti='" & NoBuktiExpanse & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data berhasil diupdate", MsgBoxStyle.Information, "Konfirmasi")

            End If
            
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Sub simpan()
        Dim total As Double
        Dim bulan As String
        Dim NoOtomatis, inintial As String
        Dim Tanggal As Date = Date.Now
        'validasi cara bayar
        If cmbPay.SelectedIndex >= 1 And txtNoref.Text = "" Then
            MsgBox("Harap di isi no referensi pembayaran", MsgBoxStyle.Exclamation, "Pesan")
            txtNoref.Focus()

        Else
            'simpan data
            bulan = Tanggal.ToString("MM")
            'Nomor otomatis berdasarkan tipe bayar
            If cmbPay.Text = "BCA" Then
                inintial = "BCA"
                NoOtomatis = Kode.GenerateBCA("TblExpanse", "NoBukti", inintial)
                'pembuatan no Otomatis dengan gabungan cara bayar
                NoBuktiExpanse = inintial & "-" & bulan & "-" & NoOtomatis
            ElseIf cmbPay.Text = "DANAMON" Then
                inintial = "DNM"
                NoOtomatis = Kode.GenerateDana("TblExpanse", "NoBukti", inintial)
                'pembuatan no Otomatis dengan gabungan cara bayar
                NoBuktiExpanse = inintial & "-" & bulan & "-" & NoOtomatis
            Else
                inintial = "CAS"
                NoOtomatis = Kode.GenerateCash("TblExpanse", "NoBukti", inintial)
                'pembuatan no Otomatis dengan gabungan cara bayar
                NoBuktiExpanse = inintial & "-" & bulan & "-" & NoOtomatis
            End If

            total = Replace(txtamount.Text, ",", "")
            Try
                SQl = "Insert into TblExpanse values('" & NoBuktiExpanse & "','" & DateTime.Text & "','" & (cmbexpanse.Text) & "','" & total & "','" & txtpaidTo.Text & "','" & cmbPay.Text & "','" & txtNoref.Text & "','" & txtpaidBy.Text & "','" & txtRemarks.Text & "')"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Konfirmasi")
                Call pengaturanForm()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Sub isiTypeExpanse()
        Try
            Tabel = Proses.ExecuteQuery("Select * from TblExpanseType")
            cmbexpanse.DataSource = Tabel
            cmbexpanse.DisplayMember = ("NamaType")
            cmbexpanse.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Private Sub frmExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NoBuktiExpanse = "" Then
            Call isiTypeExpanse()
        Else
        End If


    End Sub


    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtamount_Leave(sender As Object, e As EventArgs) Handles txtamount.Leave
        Dim nilai As Double
        If Me.txtamount.Text = "" Then
        Else
            nilai = txtamount.Text

            LblT.Text = Kode.Terbilang(nilai)
            txtamount.Text = FormatNumber(txtamount.Text, 2)
        End If

    End Sub

    Private Sub cmbPay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPay.SelectedIndexChanged
        If cmbPay.SelectedIndex > 1 Then
            txtNoref.Enabled = True
        Else
            txtNoref.Enabled = False
        End If
        txtNoref.Text = ""
    End Sub

    Private Sub btnSaveUpdate_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        If txtamount.Text = "" Or txtpaidBy.Text = "" Or txtpaidTo.Text = "" Or txtRemarks.Text = "" Or cmbexpanse.Text = "" Or cmbPay.Text = "" Then
            MsgBox("Harap isi data dengan lengkap", MsgBoxStyle.Exclamation, "Pesan")
        Else
            Tabel = Proses.ExecuteQuery("Select * from tblExpanse where NoBukti='" & NoBuktiExpanse & "'")
            If Tabel.Rows.Count > 0 Then
                Call dataupdate()
            Else
                Call simpan()
                NoBuktiExpanse = ""
            End If

        End If

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtamount.Text = "" Or txtpaidBy.Text = "" Or txtpaidTo.Text = "" Or txtRemarks.Text = "" Or cmbexpanse.Text = "" Or cmbPay.Text = "" Then
            MsgBox("Harap isi data dengan lengkap", MsgBoxStyle.Exclamation, "Pesan")
        Else
            Tabel = Proses.ExecuteQuery("Select * from tblExpanse where NoBukti='" & NoBuktiExpanse & "'")
            If Tabel.Rows.Count > 0 Then
                Call dataupdate()
                Call print()
            Else
                Call simpan()
                Call print()
            End If

        End If
    End Sub

    Private Sub cmbexpanse_Leave(sender As Object, e As EventArgs) Handles cmbexpanse.Leave
        If cmbexpanse.Text = "" Then
        Else
            Tabel = Proses.ExecuteQuery("Select * from TblExpanseType where NamaType='" & cmbexpanse.Text & "'")
            If Tabel.Rows.Count = 0 Then
                Dim result As DialogResult = MessageBox.Show("Type Expanse belum ada, Apakah akan ditambahkan ?", "Konfimrasi", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        SQl = "insert into TblExpanseType Values('" & cmbexpanse.Text & "')"
                        Proses.ExecuteNonQuery(SQl)
                        MsgBox("Data Type Expanse baru berhasil ditambahkan", MsgBoxStyle.Information, "Konfirmasi")
                        Call isiTypeExpanse()
                    Catch ex As Exception
                        MsgBox(ex.ToString())
                    End Try
                   
                Else
                    cmbexpanse.Text = ""
                    txtamount.Focus()
                End If
            End If
        End If
       
    End Sub

    Private Sub txtamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpaidTo.Focus()
        End If
    End Sub

    Private Sub cmbexpanse_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbexpanse.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Focus()
        End If
    End Sub

 
End Class