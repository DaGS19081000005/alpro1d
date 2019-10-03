Imports System.Console
Module Module1

    Sub Main()
        tesgenapganjil()
    End Sub

    Sub tesgenapganjil()
        Dim bil As Integer
        Dim sts As String
        '1. MASUKKAN bil    
        '2. JIKA SISA HASIL BAGI 2 DARI BIL ADALAH 0, MAKA  
        '   STATUS GENAP, SELAIN ITU STATUS GANJIL	
        '3. TAMPILKAN STATUS    
        bil = 5
        If (bil Mod 2) = 0 Then
            sts = "GENAP"
        Else
            sts = "GANJIL"
        End If
        WriteLine(sts)
    End Sub

    Sub cekvariabel()
        'PEMILIHAN TIPE DATA SANGAT PENTING:
        ' - ketelitian - akurasi

        Dim a As Single
        Dim b As Single
        Dim hasil As Integer
        a = 2.5
        b = 2
        hasil = a + b

        Write(hasil)
        WriteLine()
    End Sub

End Module
