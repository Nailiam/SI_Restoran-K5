Public Class Bayar
    Private Sub Bayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Sub KosongkanForm()
        txtkodetransaksi.Text = ""
        txtnama.Text = ""
        txttotal.Text = ""
        txtjumlah.Text = ""
        txtidmenu.Text = ""
    End Sub
        Sub MatikanForm()
        txtkodetransaksi.Enabled = False
        txtnama.Enabled = False
        txttotal.Enabled = False
        txtjumlah.Enabled = False
        txtidmenu.Enabled = False
    End Sub
        Sub HidupkanForm()
        txtkodetransaksi.Enabled = True
        txtnama.Enabled = True
        txttotal.Enabled = True
        txtjumlah.Enabled = True
        txtidmenu.Enabled = True
    End Sub
        Sub TampilkanData()
            Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Bayar", Conn)
        DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            DataGridView1.ReadOnly = True
        End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtkodetransaksi.Text = "" Or txtnama.Text = "" Or txttotal.Text = "" Or txtjumlah.Text = "" Or txtidmenu.Text = "" Then
            MsgBox("Data pPembayaran Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Bayar where txtkodetransaksi ='" & txtkodetransaksi.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Bayar values ('" & txtkodetransaksi.Text &
               "', '" & txtnama.Text & "', '" & txttotal.Text & "', '" & txtjumlah.Text & "','" & txtidmenu.Text & "')"
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtkodetransaksi.Text = "" Or txtnama.Text = "" Or txttotal.Text = "" Or txtjumlah.Text = "" Or
            txtidmenu.Text = "" Then
            MsgBox("Data Pembayaran Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Bayar set nama_kasir = '" &
           txtnama.Text & "', total_harga = '" & txttotal.Text & "', jumlah_pesanan = '" & txtjumlah.Text & "', id_menu = '" & txtidmenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkodetransaksi.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Pesan where kode_transaksi = '" & txtkodetransaksi.Text & "'", Conn)
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
        txtkodetransaksi.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value

        txttotal.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtjumlah.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtidmenu.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Call HidupkanForm()
        txtkodetransaksi.Enabled = False
    End Sub
    End Class