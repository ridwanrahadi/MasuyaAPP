Public Class FrmTax
    Sub Pengaturan()
        DTBaru.Value = Format(Now, "M/dd/yyyy")
        DTLama.Value = Format(Now, "M/dd/yyyy")
        NfBarutxt.Text = ""
        NfLamatxt.Text = ""
        NoJltxt.Enabled = True
        NoJltxt.Focus()
    End Sub
    Sub IsiDGView()
        Try
            Tabel = Proses.ExecuteQuery("Select NoBukti,NmCust,NoFP,tglFP from tblFak where NoBukti='" & NoJltxt.Text & "'")
            If Tabel.Rows.Count = 0 Then
                MsgBox("No JL Tidak ditemukan...!", MsgBoxStyle.Exclamation, "Pesan")
                NoJltxt.Focus()
            Else
                DGView.DataSource = Tabel
                DGView.Columns(0).Width = 70
                DGView.Columns(1).Width = 120
                DGView.Columns(2).Width = 150
                DGView.Columns(3).Width = 70
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub NoJltxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NoJltxt.KeyPress
        If e.KeyChar = Chr(13) Then
            If NoJltxt.Text = "" Then
                MsgBox("Silahkan isi No JL !!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                NoJltxt.Focus()
            Else
                Call IsiDGView()

            End If
        End If
    End Sub

    Private Sub FrmTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Pengaturan()
    End Sub

    Private Sub DGView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGView.CellClick
        Try
            NoJltxt.Enabled = False

            Dim i As Integer
            i = Me.DGView.CurrentRow.Index
            With DGView.Rows.Item(i)
                NoJltxt.Text = .Cells(0).Value
                NfLamatxt.Text = .Cells(2).Value
                DTLama.Text = .Cells(3).Value
                DTBaru.Text = .Cells(3).Value
                NfBarutxt.Focus()
            End With
        Catch ex As Exception
            MsgBox("Coloms yang ada pilih kosong, Periksa kembali", MsgBoxStyle.Exclamation, "Konfirmasi")
        End Try
    End Sub

    Private Sub BtRubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRubah.Click
        If NoJltxt.Text = "" Then
            MsgBox("Isi No JL...!!!", MsgBoxStyle.Exclamation, "Pesan")
            NoJltxt.Focus()
        ElseIf NfBarutxt.Text = "" Then
            NfBarutxt.Text = NfLamatxt.Text
            SQl = "Update tblFak Set NoFP='" & NfBarutxt.Text & "',tglFP='" & Format(DTBaru.Value, "M/dd/yyyy") & "' where NoBukti='" & NoJltxt.Text & "'"
            Proses.ExecuteNonQuery(SQl)
            MsgBox("Perubahan berhasil...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            Call Pengaturan()
            Call IsiDGView()
        Else
            Try
                SQl = "Update tblFak Set NoFP='" & NfBarutxt.Text & "',tglFP='" & Format(DTBaru.Value, "M/dd/yyyy") & "' where NoBukti='" & NoJltxt.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Perubahan berhasil...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Call Pengaturan()
                Call IsiDGView()
            Catch ex As Exception
                MsgBox("Perubahan data gagal, No JL tidak di temukan", MsgBoxStyle.Critical, "ERROR")
                NoJltxt.Text = ""
                Call Pengaturan()

            End Try
        End If
    End Sub

    Private Sub BtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCancel.Click
        NoJltxt.Enabled = True
        NoJltxt.Text = ""
        Call Pengaturan()
    End Sub

   
End Class