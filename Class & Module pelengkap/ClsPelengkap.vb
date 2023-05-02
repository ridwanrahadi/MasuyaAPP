Imports VB = Microsoft.VisualBasic
Public Class ClsPelengkap
    'Function untuk membuat penomoran otomatis dengan format angka 6 digit
    Public Function Generate(ByVal Nama_Table As String, ByVal Nama_Field As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Table & " order by " & Nama_Field & " desc ")
        If Tabel.Rows.Count = 0 Then
            Generate = "000001"
        Else
            With Tabel.Rows(0)
                VarStr = Val(.Item(0)) + 1
                VarStr1 = VB.Len(VarStr)
                VarStr2 = "000000"
                VarStr3 = VarStr2.Substring(VarStr1)
                Generate = VarStr3 & Mid(.Item("" & Nama_Field & ""), 2, 6) + 1

            End With
        End If
    End Function
    Public Function Terbilang(ByVal x As Integer) As String
        Dim bilangan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima",
        "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        Dim temp As String = ""

        If x < 12 Then
            temp = " " + bilangan(x)
        ElseIf x < 20 Then
            temp = Terbilang(x - 10).ToString + " Belas"
        ElseIf x < 100 Then
            temp = Terbilang(x / 10) + " Puluh" + Terbilang(x Mod 10)
        ElseIf x < 200 Then
            temp = " Seratus" + Terbilang(x - 100)
        ElseIf x < 1000 Then
            temp = Terbilang(x / 100) + " Ratus" + Terbilang(x Mod 100)
        ElseIf x < 2000 Then
            temp = " Seribu" + Terbilang(x - 1000)
        ElseIf x < 1000000 Then
            temp = Terbilang(x / 1000) + " Ribu" + Terbilang(x Mod 1000)
        ElseIf x < 2000000 Then
            temp = " Satu Juta" + Terbilang(x - 1000000)
        ElseIf x < 1000000000 Then
            temp = Terbilang(x / 1000000) + " Juta" + Terbilang(x Mod 1000000)
        End If

        Return temp
    End Function
    'Function untuk membuat penomoran otomatis dengan format angka 6 digit
    Public Function GenerateCash(ByVal Nama_Table As String, ByVal Nama_Field As String, ByVal value As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Table & " where " & Nama_Field & " like '%" & value & "%' order by " & Nama_Field & " desc ")
        If Tabel.Rows.Count = 0 Then
            GenerateCash = "00001"
        Else
            With Tabel.Rows(0)
                'ambil 6 angka dari kanan dari database ditambahkan 1
                VarStr = Microsoft.VisualBasic.Right(.Item(0), 5) + 1
                'penggabungan hasil hitungan dari database dengan string 
                GenerateCash = Microsoft.VisualBasic.Right("00000" & VarStr, 5)
            End With
        End If
    End Function
    Public Function GenerateBCA(ByVal Nama_Table As String, ByVal Nama_Field As String, ByVal value As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Table & " where " & Nama_Field & " like '%" & value & "%' order by " & Nama_Field & " desc ")
        If Tabel.Rows.Count = 0 Then
            GenerateBCA = "00001"
        Else
            With Tabel.Rows(0)
                'ambil 6 angka dari kanan dari database ditambahkan 1
                VarStr = Microsoft.VisualBasic.Right(.Item(0), 5) + 1
                'penggabungan hasil hitungan dari database dengan string 
                GenerateBCA = Microsoft.VisualBasic.Right("00000" & VarStr, 5)
            End With
        End If
    End Function
    Public Function GenerateDana(ByVal Nama_Table As String, ByVal Nama_Field As String, ByVal value As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Table & " where " & Nama_Field & " like '%" & value & "%' order by " & Nama_Field & " desc ")
        If Tabel.Rows.Count = 0 Then
            GenerateDana = "00001"
        Else
            With Tabel.Rows(0)
                'ambil 6 angka dari kanan dari database ditambahkan 1
                VarStr = Microsoft.VisualBasic.Right(.Item(0), 5) + 1
                'penggabungan hasil hitungan dari database dengan string 
                GenerateDana = Microsoft.VisualBasic.Right("00000" & VarStr, 5)
            End With
        End If
    End Function
    'Function untuk cek keadaan kolom teks 
    Public Function Isi(ByRef Teks As Object) As Boolean
        If Teks.ToString = "" Then
            Isi = False
            MsgBox("Data tidak boleh kosong, Silahkan cek lagi!", vbExclamation, "Peringatan")
        Else
            Isi = True
        End If
    End Function
    Public Function Teks(ByVal Nama_Table As String, ByVal Nama_Field As String) As String
        Tabel = Proses.ExecuteQuery("Select * From " & Nama_Table & " order by " & Nama_Field & " desc ")
        If Tabel.Rows.Count = 0 Then
            Teks = "Open"
        Else
            
            Teks = "Locked"


        End If
    End Function
    Public Function NormSInv(ByVal p As Double) As Double
        Const a1 As Double = -39.6968302866538, a2 As Double = 220.946098424521
        Const a3 As Double = -275.928510446969, a4 As Double = 138.357751867269
        Const a5 As Double = -30.6647980661472, a6 As Double = 2.50662827745924
        Const b1 As Double = -54.4760987982241, b2 As Double = 161.585836858041
        Const b3 As Double = -155.698979859887, b4 As Double = 66.8013118877197
        Const b5 As Double = -13.2806815528857, c1 As Double = -0.00778489400243029
        Const c2 As Double = -0.322396458041136, c3 As Double = -2.40075827716184
        Const c4 As Double = -2.54973253934373, c5 As Double = 4.37466414146497
        Const c6 As Double = 2.93816398269878, d1 As Double = 0.00778469570904146
        Const d2 As Double = 0.32246712907004, d3 As Double = 2.445134137143
        Const d4 As Double = 3.75440866190742
        Const p_low As Double = 0.02425, p_high As Double = 1 - p_low

        Dim q As Double, r As Double

        If p < 0 Or p > 1 Then
            Throw New ArgumentException("Argument must not be negative or greater than 1.", "p")
        ElseIf p < p_low Then
            q = Math.Sqrt(-2 * Math.Log(p))
            Return (((((c1 * q + c2) * q + c3) * q + c4) * q + c5) * q + c6) / _
             ((((d1 * q + d2) * q + d3) * q + d4) * q + 1)
        ElseIf p <= p_high Then
            q = p - 0.5
            r = q * q
            Return (((((a1 * r + a2) * r + a3) * r + a4) * r + a5) * r + a6) * q / _
             (((((b1 * r + b2) * r + b3) * r + b4) * r + b5) * r + 1)
        Else
            q = Math.Sqrt(-2 * Math.Log(1 - p))
            Return -(((((c1 * q + c2) * q + c3) * q + c4) * q + c5) * q + c6) / _
             ((((d1 * q + d2) * q + d3) * q + d4) * q + 1)
        End If
    End Function
End Class
