Public Class FrmIsiNoFP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Tabel = Proses.ExecuteQuery("Select * from IsiNoFP where tgl ='" & DateTimePicker1.Text & "' and (TglFP IS NULL) order by nobukti")
        DataGridView1.DataSource = Tabel
        Button3.Enabled = False
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nofp As Integer
        Dim gen As Integer
        Dim Noserifp1 As String
        Dim Noserifp2 As String
        Dim hasil As Integer

        If DataGridView1.RowCount = 0 Then
            MsgBox("Click lihat data terlebih dahulu", MsgBoxStyle.Information, "Pesan")
        Else
            Tabel = Proses.ExecuteQuery("Select * from tblSysinfo")
            nofp = Tabel(0).Item(56) + 1
            Noserifp1 = Tabel(0).Item(12)
            Noserifp2 = Tabel(0).Item(106)
            For baris As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(baris).Cells(4).Value = "PPPN" Then
                    gen = nofp + baris
                    DataGridView1.Rows(baris).Cells(2).Value = Noserifp1 & gen.ToString("00000000")
                    DataGridView1.Rows(baris).Cells(3).Value = DateTimePicker1.Text
                Else
                    gen = nofp + baris
                    DataGridView1.Rows(baris).Cells(2).Value = Noserifp2 & gen.ToString("00000000")
                    DataGridView1.Rows(baris).Cells(3).Value = DateTimePicker1.Text
                End If
            Next baris
            hasil = nofp + DataGridView1.RowCount - 1
            TextBox1.Text = hasil.ToString("00000000")
            TextBox2.Text = Tabel(0).Item(107)
            Button3.Enabled = True
        End If

        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim awalnofp As Integer
        Dim akhirnpfp As Integer

        awalnofp = TextBox1.Text
        akhirnpfp = TextBox2.Text

        Try
            If awalnofp > akhirnpfp Then
                MsgBox("Batas no faktur pajak melebihi yang ditentukan, hapus sebagian baris !!!", MsgBoxStyle.Critical, "Konfirmasi")
            Else
                For baris As Integer = 0 To DataGridView1.RowCount - 1
                    SQl = "update tblfak set NoFP='" & DataGridView1.Rows(baris).Cells(2).Value & "',TglFP='" & DataGridView1.Rows(baris).Cells(3).Value & "' where NoBukti ='" & DataGridView1.Rows(baris).Cells(0).Value & "' "
                    Proses.ExecuteNonQuery(SQl)
                Next baris
                SQl = "update tblsysinfo set FPNumber='" & TextBox1.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Pengisian No Faktur Pajak selesai", MsgBoxStyle.Information, "Pesan")
                Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       
    End Sub

    Private Sub FrmIsiNoFP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
    End Sub
End Class