Imports System.Console

Module transaksi

    Sub Main()
        Dim kdtujuan, kotapil As String
        Dim ongkirperkm, jrk, ongkir As Integer
        Dim ulang As String

        Do Until ulang = "T"
            Clear()
            kotapil = ""
            ongkirperkm = 0
            jrk = 0
            ongkir = 0
            kdtujuan = ""

            'materi No 8 - Aplikasi 6e
            WriteLine("KODE KOTA        ONGKIR/KM   JARAK")
            WriteLine("-----------------------------------")
            WriteLine("A    SURABAYA    Rp.2500     169")
            WriteLine("B    BANDUNG     Rp.4000     452")
            WriteLine("-----------------------------------")
            Do Until kdtujuan = "A" Or kdtujuan = "B"
                '1. MASUKKAN KODE TUJUAN (kdtujuan)
                Write(">> Masukkan kode tujuan  : ")
                kdtujuan = UCase(ReadLine())

                '2. JIKA kdtujuan=.., MAKA 
                Select Case kdtujuan
                    Case Is = "A"
                        kotapil = "SURABAYA"
                        ongkirperkm = 2500
                        jrk = 169

                    Case Is = "B"
                        kotapil = "BANDUNG"
                        ongkirperkm = 4000
                        jrk = 452

                    Case Else
                        kotapil = "Pilih Kode dengan Benar"
                End Select
            Loop

            '3. hitung ongkir = ongkirperkm * jrk
            ongkir = ongkirperkm * jrk
            WriteLine(">>> Kota Tujuan   = " & kotapil)
            WriteLine(">>> Biaya Kirim   = " & ongkirperkm & " * " & jrk)
            WriteLine(">>>               = " & ongkir)
            WriteLine()

            '5. muat ulang transaksi baru
            Write("> MULAI TRANSAKSI BARU (Y/T) = ")
            ulang = UCase(ReadLine())
        Loop

        'kotapil = ...
        'ongkirperkm = ...
        'jrk = ...




    End Sub
End Module
