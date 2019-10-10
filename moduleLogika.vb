Imports System.Console
Module moduleLogika
    Sub Main()
        aplikasi5a()
    End Sub

    Sub cekkelulusanLOGIKA()
        'LULUS jika:
        'nilaiuas > 90 OR nilaiuts>70 AND nilaitugas > 80

    End Sub

    Sub aplikasi5a()
        '1. siapkan variabel: status, nilai
        Dim status As String
        Dim nilai As Byte

        '2. input nilai
        Write("Masukkan nilai   = ")
        nilai = ReadLine()
        '3. cek nilai (jika nilai > 60, maka lulus)
        If nilai > 60 Then
            status = "LULUS"
        Else
            status = "TIDAK LULUS"
        End If
        '4. output status
        WriteLine("STATUS ANDA      = " & status)
        WriteLine()
        WriteLine()

    End Sub
End Module
