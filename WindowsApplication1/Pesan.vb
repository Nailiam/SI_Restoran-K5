Public Class Pesan
    Private Sub Pesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub
    Sub KosongkanForm()
        kode_pemesanan.Text = ""
        nama_pemesan.Text = ""
        jumlah_pemesanan.Text = ""
        harga_makanan.Text = ""
        harga_minuman.Text = ""
    End Sub
    Sub MatikanForm()
        kode_pemesanan.Enabled = False
        nama_pemesan.Enabled = False
        jumlah_pemesanan.Enabled = False
        harga_makanan.Enabled = False
        harga_minuman.Enabled = False
    End Sub
    Sub HidupkanForm()
        kode_pemesanan.Enabled = True
        nama_pemesan.Enabled = True
        jumlah_pemesanan.Enabled = True
        harga_makanan.Enabled = True
        harga_minuman.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Pesan", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If kode_pemesanan.Text = "" Or nama_pemesan.Text = "" Or jumlah_pemesanan.Text = "" Or harga_makanan.Text = "" Or harga_minuman.Text = "" Then
            MsgBox("Data Pemesanan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Pesan where kode_pemesanan ='" & kode_pemesanan.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Pesan values ('" & kode_pemesanan.Text &
               "', '" & nama_pemesan.Text & "', '" & jumlah_pemesanan.Text & "', '" & harga_makanan.Text & "','" & harga_minuman.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If kode_pemesanan.Text = "" Or nama_pemesan.Text = "" Or jumlah_pemesanan.Text = "" Or harga_makanan.Text = "" Or harga_minuman.Text = "" Then
            MsgBox("Data Pemesanan Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update pesan set nama_pemesan = '" &
           nama_pemesan.Text & "', jumlah_pemesanan = '" & jumlah_pemesanan.Text & "', harga_makanan = '" & harga_makanan.Text & "', harga_minuman = '" & harga_minuman.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If kode_pemesanan.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Pesan where kode_pemesanan = '" & kode_pemesanan.Text & "'", Conn)
                DM = CMD.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        kode_pemesanan.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        nama_pemesan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        jumlah_pemesanan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        harga_makanan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        harga_minuman.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Call HidupkanForm()
        kode_pemesanan.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Bayar.Show()
    End Sub
End Class