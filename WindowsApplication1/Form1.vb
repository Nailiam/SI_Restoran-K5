Public Class Menu

    Private Property Id_Menu As Object

    Sub KosongkanForm()
        txtIdMenu.Text = ""
        CmbMakanan.Text = ""
        CmbMinuman.Text = ""
        txtHargaMin.Text = ""
        txtHargaMakan.Text = ""
        txtIdMenu.Focus()
    End Sub
    Sub MatikanForm()
        txtIdMenu.Enabled = False
        CmbMakanan.Enabled = False
        CmbMinuman.Enabled = False
        txtHargaMin.Enabled = False
        txtHargaMakan.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtIdMenu.Enabled = True
        CmbMakanan.Enabled = True
        CmbMinuman.Enabled = True
        txtHargaMin.Enabled = True
        txtHargaMakan.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Menu ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub Input_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
        'Coding diatas bermaksud , ketika form Input Buku di load pertamakali , form langsung dimatikan dan data yang dari Access langsung ditampilkan di Data Grid View
    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Coding diatas bermaksud ketika Button Exit di form nya di klik ,maka akan keluar dari form tersebut
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Call HidupkanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()
        ' Fungsi coding sama dengan diatas
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtIdMenu.Text = "" Or CmbMakanan.Text = "" Or CmbMinuman.Text =
"" Or txtHargaMin.Text = "" Or txtHargaMakan.Text = ""  Then
            MsgBox("Data Buku Belum Lengkap")
            Exit Sub
            'Coding ini berfungsi untuk mengecek jika salah satu field dataada yang kosong , atau belum diisi , maka akan tampil pesan bahwa data yangdi input belum lengkap
        Else
            Call KoneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu where Id_Menu='" & txtIdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            'Coding ini berfungsi untuk mengecek jika di bagian id menu(primary key) ada inputan data yang sama , maka ke Else : data sudah ada
            'Jika data inputan tidak sama , maka ke If Not : masukkan inputandari form ke database Ms.Access
            If Not DM.HasRows Then
                Call KoneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txtIdMenu.Text &
               "', '" & CmbMakanan.Text & "', '" & CmbMinuman.Text & "','" &
               txtHargaMin.Text & "','" & txtHargaMin.Text & "')"
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

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txtIdMenu.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        CmbMakanan.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        CmbMinuman.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtHargaMin.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtHargaMin.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kitaarahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan seterusnya()
        Call HidupkanForm()
        txtIdMenu.Enabled = False 'Ketika mengedit , kita tidak bisa mengedit kode buku nya ,kita hanya bisa mengedit di field2 lainnya
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtIdMenu.Text = "" Or CmbMakanan.Text = "" Or CmbMinuman.Text ="" Or txtHargaMin.Text = "" Or txtHargaMin.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub
            'Coding berfungsi untuk mengecek jika ada field yang belum terisiatau belum lengkap
        Else
            Call KoneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu set Jenis_Makanan = '" &
           CmbMakanan.Text & "', Jenis_Minuman = '" & CmbMinuman.Text & "', Harga_Minuman ='" & txtHargaMin.Text & "', Harga Makanan = '" &
           txtHargaMakan.Text & "'  where Id_Menu ='" & txtIdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
            'Coding berfungsi untuk mengedit dan mengupdate data yang dipilihuntuk kemudian disimpan lagi di tabel Ms.Access yang sdh dibuat
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()        'Ini komen masuk github
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtIdMenu.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
            'Coding berfungsi untuk mengecek , jika tidak ada data yangdipilih untuk dihapus , maka akan tampil pesan diatas
        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
           "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                'Coding berfungsi untuk memberi konfirmasi ke user , apakah yakin untuk mendelete data
                'Jika yakin , maka akan berjalan coding dibawah ini untuk mendelete data yang dipilih

                Call KoneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Buku where Id_Menu ='" & txtIdMenu.Text & "'", Conn)
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
End Class
