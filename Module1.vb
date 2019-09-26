Imports System.Console

Module Module1

    Sub Main()
        tampilnama()
    End Sub

    Sub tampilnama()
        'cara mmbuat variabel di VB
        Dim nama As String
        Dim umur As Byte

        nama = "Budi"
        umur = 17
        'cara cetak ke layar
        System.Console.WriteLine("Nama : " & nama)
        System.Console.WriteLine("Umur : " & umur)
        System.Console.WriteLine()

        'Run program dengan Ctrl-F5
    End Sub

    Sub hitungluasPersegiPanjang()
        'algoritma
        '1. MASUKKAN NILAI P DAN L
        '2. HITUNG LUAS = P * L
        '3. TAMPILKAN LUAS
        '----------
        Dim P, L, Luas As Integer

        '1.
        WriteLine("Masukkan P = ")
        P = ReadLine()
        WriteLine("Masukkan L = ")
        L = ReadLine()

        '2
        Luas = P * L
        '3
        WriteLine("Luas = " & Luas)


    End Sub

End Module