Module ModPelengkap
    'Deklarasi Global
    Public api As String
    Public SQl As String
    Public Tabel As DataTable
    Public Tabel2 As DataTable
    Public Proses As New ClsKoneksi
    Public Kode As New ClsPelengkap
    Public Pelengkap As New ClsPelengkap
    Public VarStr, VarStr1, VarStr2, VarStr3 As String
    Public Status, Posisi_Record, edit As Boolean
    Public Diskon As Single
    Public No, Stock, Stock_Awal, Jml_Beli, Jml_Return, Jml_Jual, Sub_Total, No_Kartu As Integer
    Public Pengguna As String

    'Mengosongkan isi teks pada form keseluruhan
    Public Sub KosongkanIsiText(ByVal x As Form)
        For Each i As Control In x.Controls
            If TypeOf (i) Is TextBox Then
                i.Text = ""
            End If
        Next
    End Sub
    'Replace tanda kutip
    Public Function rep(ByVal kata As String) As String
        rep = Replace(kata, "'", "''")
    End Function

    'Mengosongkan isi teks combobox pada form seluruh
    Public Sub KosongkanIsiCombo(ByVal x As Form)
        For Each i As Control In x.Controls
            If TypeOf (i) Is ComboBox Then
                i.Text = ""
            End If
        Next
    End Sub
    'Fungsi untuk mengkonversi format uang string ke dalam bilangan (double/integer)
    Public Function formatUangKeBilangan(ByVal N As String) As Double
        formatUangKeBilangan = Replace(N, ",", "")
    End Function
    Public Function formatUang(ByVal Text As TextBox)
        If Len(Text.Text) > 0 Then
            Text.Text = FormatNumber(CDbl(Text.Text), 0)
            Dim x As Double = Text.SelectionStart.ToString
            If x = 0 Then
                Text.SelectionStart = Len(Text.Text)
                Text.SelectionLength = 0
            Else
                Text.SelectionStart = x
                Text.SelectionLength = 0
            End If
        End If
    End Function
End Module
