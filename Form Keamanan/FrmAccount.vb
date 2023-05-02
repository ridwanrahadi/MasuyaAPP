Public Class FrmAccount
    Dim lvlSO As String
    Sub IsiCBUname()
        Tabel = Proses.ExecuteQuery("Select * From tblPengguna order by Username")
        CBUname.DataSource = Tabel
        CBUname.DisplayMember = "Username"

    End Sub
    Sub TampilHakAkses()
        Dim lvlso As Integer
        Tabel = Proses.ExecuteQuery("Select * From tblPengguna where Username='" & CBUname.Text & "'")
        If Tabel.Rows.Count = 0 Then
            Call Pengaturan()
        Else
            With Tabel.Rows(0)
                PricipleChk.Checked = .Item("Gudang")
                KlaimChk.Checked = .Item("Klaim")
                SpvChk.Checked = .Item("Spv")
                TaxChk.Checked = .Item("Tax")
                BukaChk.Checked = .Item("BukaHarga")
                TagihanChk.Checked = .Item("Tagihan")
                LapBdChk.Checked = .Item("Laporan")
                GudangChk.Checked = .Item("Gudang")
                LostCustChk.Checked = .Item("LostCust")
                PrintPOChk.Checked = .Item("PrintPO")
                SalesChk.Checked = .Item("LapSales")
                PricipleChk.Checked = .Item("Principle")
                InvChk.Checked = .Item("inventory")
                ChkSO.Checked = .Item("SO")
                Namatxt.Text = .Item("Nama")
                Pswtxt.Text = .Item("password")
                If Not IsDBNull(Tabel.Rows(0).Item("divisi")) Then
                    cmbdivisi.Text = .Item("divisi")
                Else
                    cmbdivisi.Text = "NULL"
                End If
                lvlso = .Item("levelSODesktop")

                Select Case lvlso
                    Case 2
                        cmblvlSO.Text = "Costing"
                    Case 1
                        cmblvlSO.Text = "Invoicing"
                    Case 0
                        cmblvlSO.Text = "Sales"
                    Case Else
                        cmblvlSO.Text = ""
                End Select

                cmblevel.Text = .Item("level")

                Unametxt.Text = .Item("username")
            End With
        End If

    End Sub
    Sub Pengaturan()
        Unametxt.Text = ""
        Pswtxt.Text = ""
        Namatxt.Text = ""
        CBUname.Text = ""
        cmbdivisi.Text = ""
        cmblevel.Text = ""
        cmblvlSO.Text = ""
        Unametxt.Focus()
        KlaimChk.Checked = False
        SpvChk.Checked = False
        InvChk.Checked = False
        TaxChk.Checked = False
        BukaChk.Checked = False
        TagihanChk.Checked = False
        LapBdChk.Checked = False
        GudangChk.Checked = False
        LostCustChk.Checked = False
        PrintPOChk.Checked = False
        PricipleChk.Checked = False
        SalesChk.Checked = False


    End Sub
    Sub simpan()


        If Unametxt.Text = "" Then
            MsgBox("Username masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            Unametxt.Focus()

        ElseIf Pswtxt.Text = "" Then
            MsgBox("Password masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            Pswtxt.Focus()
        ElseIf cmbdivisi.Text = "" Then
            MsgBox("Divisi masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            cmbdivisi.Focus()
        ElseIf cmblevel.Text = "" Then
            MsgBox("Level masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            cmblevel.Focus()
        ElseIf cmblvlSO.Text = "" Then
            MsgBox("Level SO masih kosong, silahkan di isi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
            cmblvlSO.Focus()
        Else
            lvlSO = cmblvlSO.Text
            Select Case lvlSO
                Case "Costing"
                    lvlSO = 2
                Case "Invoicing"
                    lvlSO = 1
                Case "Sales"
                    lvlSO = 0

            End Select

            Try
                SQl = "Insert into tblPengguna Values('" & Unametxt.Text & "','" & Pswtxt.Text & "','" & CInt(KlaimChk.Checked) * -1 & "','" & CInt(SpvChk.Checked) * -1 & "','" & CInt(TaxChk.Checked) * -1 & "','" & CInt(TagihanChk.Checked) * -1 & "','" & CInt(BukaChk.Checked) * -1 & "','" & CInt(LapBdChk.Checked) * -1 & "','" & CInt(LostCustChk.Checked) * -1 & "','" & CInt(PrintPOChk.Checked) * -1 & "','" & CInt(GudangChk.Checked) * -1 & "','" & CInt(SalesChk.Checked) * -1 & "','" & CInt(PricipleChk.Checked) * -1 & "','" & CInt(InvChk.Checked) * -1 & "','" & cmblevel.Text & "','" & cmbdivisi.Text & "','" & CInt(ChkSO.Checked) * -1 & "','','" & lvlSO & "','" & Namatxt.Text & "')"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Konfirmasi")
                Call IsiCBUname()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub


    Private Sub FrmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Pengaturan()
        Call IsiCBUname()
    End Sub


    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        Call Pengaturan()
        CBUname.Text = ""

    End Sub



    Private Sub CBUname_TextChanged(sender As Object, e As EventArgs) Handles CBUname.TextChanged
        If Me.CBUname.SelectedIndex > -1 Then
            Call TampilHakAkses()
        End If

    End Sub


    Private Sub BtSimpan_Click_1(sender As Object, e As EventArgs) Handles BtSimpan.Click
        Call simpan()

    End Sub

    Private Sub BtUpdate_Click_1(sender As Object, e As EventArgs) Handles BtUpdate.Click
        If CBUname.Text = "" Then
            MsgBox("Pilih username yang telah terdaftar, dengan mengklik combo box di atas", MsgBoxStyle.Critical, "Konfirmasi")
        Else
            lvlSO = cmblvlSO.Text
            Select Case lvlSO
                Case "Costing"
                    lvlSO = 2
                Case "Invoicing"
                    lvlSO = 1
                Case "Sales"
                    lvlSO = 0

            End Select
            Try
                SQl = "Update tblPengguna set Level ='" & cmblevel.Text & "',Divisi ='" & cmbdivisi.Text & "',Klaim='" & CInt(KlaimChk.Checked) * -1 & "',Spv='" & CInt(SpvChk.Checked) * -1 & "',inventory='" & CInt(InvChk.Checked) * -1 & "',Tax='" & CInt(TaxChk.Checked) * -1 & "',Tagihan='" & CInt(TagihanChk.Checked) * -1 & "',Gudang='" & CInt(GudangChk.Checked) * -1 & "',BukaHarga='" & CInt(BukaChk.Checked) * -1 & "',Laporan='" & CInt(LapBdChk.Checked) * -1 & "',Principle='" & CInt(PricipleChk.Checked) * -1 & "',PrintPO='" & CInt(PrintPOChk.Checked) * -1 & "',LapSales='" & CInt(SalesChk.Checked) * -1 & "',LostCust='" & CInt(LostCustChk.Checked) * -1 & "',SO='" & CInt(ChkSO.Checked) * -1 & "',levelSODesktop='" & lvlSO & "' where Username='" & CBUname.Text & "'"
                Proses.ExecuteNonQuery(SQl)
                MsgBox("Update berhasil", MsgBoxStyle.Information, "Konfirmasi")
                CBUname.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

End Class