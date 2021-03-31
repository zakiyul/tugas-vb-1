Public Class Form1

    Public nama As String
    Public harga, jumlah, total, tunai, kembalian As Integer


    Private Sub btn_hitung1_Click(sender As Object, e As EventArgs) Handles btn_hitung1.Click
        nama = tb_namaBarang.Text
        harga = tb_hargaBarang.Text
        jumlah = tb_jumlahBarang.Text
        total = tb_hargaBarang.Text * tb_jumlahBarang.Text
        tb_totalHarga.Text = total
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        tunai = tb_tunai.Text
        kembalian = tunai - total
        tb_kembalian.Text = kembalian
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        For Each txt In {tb_namaBarang, tb_hargaBarang, tb_jumlahBarang, tb_kembalian, tb_totalHarga, tb_tunai}
            txt.Clear()
        Next
    End Sub
End Class
