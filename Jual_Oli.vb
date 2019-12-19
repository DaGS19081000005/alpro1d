Imports System.Console

Module Jual_Oli
    '1. DEKLARASI VARIABEL
    Dim strPilihan As String        'var utk menyimpan inputan pilihan barang 
    Dim intQty As Integer
    Dim TAMBAHITEM As Char          'var utk simpan jawaban Y/T pd proses menambah item/barang
    Dim TOTALSEKARANG As Single 'var utk simpan nilai total dari penjumlahan total per barang 
    Sub DisplayBarang()
        '2. TAMPILKAN JUDUL PROGRAM DAN PILIHAN barang
        WriteLine("======================================================")
        WriteLine("=                       CONTOH                       =")
        WriteLine("=                   PENJUALAN OLIE                   =")
        WriteLine("======================================================")
        WriteLine()
        WriteLine("                    DAFTAR BARANG                     ")
        WriteLine("------------------------------------------------------")
        WriteLine(" A. Duration SW20 1L             @ Rp 53.000")
        WriteLine(" B. Castrol Magnatec 1L          @ Rp 50.000")
        WriteLine(" C. Federal Supreme XX 1L        @ Rp 54.000")
        WriteLine("------------------------------------------------------")
    End Sub

    Sub Main()

        DisplayBarang()

        Do Until TAMBAHITEM = "T"
            '3. INPUTKAN PILIHAN
            Write("> Masukkan Pilihan Barang    = ")
            strPilihan = UCase(ReadLine())
            SeleksiBarang()

            '4. INPUTKAN QTY
            Write("> Masukkan Qty               = ")
            intQty = Val(ReadLine())
            HitungTotPerBarang()
            'tampilkan total sekarang
            WriteLine(">>> TOTAL SEKARANG                   = " & TOTALSEKARANG)

            '5. PROSES INPUT TAMBAH ITEM
            Write(">Tambah Barang lagi ? Y/T    = ")
            TAMBAHITEM = UCase(ReadLine())
        Loop
        Report()

    End Sub

    Dim strNamaBarang As String
    Dim hrg As Integer
    Sub SeleksiBarang()
        Select Case strPilihan
            Case Is = "A"
                strNamaBarang = "Duration SW20 1L"
                hrg = 53000
            Case Is = "B"
                strNamaBarang = "Castrol Magnatec 1L"
                hrg = 50000
            Case Is = "C"
                strNamaBarang = "Federal Supreme XX 1L"
                hrg = 54000
            Case Else
                '... 
        End Select
        WriteLine(">> Nama Barang               = " & strNamaBarang)
    End Sub

    Dim totperbarang As Integer
    Sub HitungTotPerBarang() 'qty x hrg
        totperbarang = intQty * hrg
        WriteLine(">> Total Per Barang          = " & totperbarang)
        TOTALSEKARANG = TOTALSEKARANG + totperbarang
        totQty = totQty + intQty

    End Sub

    Dim totQty, jmlItem As Integer

    'CETAK KE NOTEPAD - EXCEL - WORD
    Sub Report()
        WriteLine()
        WriteLine(">> --------- NOTA -------------------------")
        WriteLine(">> Total Qty             = " & totQty)
        WriteLine(">> Total Bayar           = " & FormatNumber(TOTALSEKARANG, 0, -1))
        WriteLine(">> --------- TERIMA KASIH -----------------")
        WriteLine()
    End Sub
End Module
