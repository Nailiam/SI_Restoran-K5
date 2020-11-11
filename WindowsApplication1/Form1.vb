Public Class Menu

    Private Property Id_Menu As Object

    Sub KosongkanForm()
        txtIdMenu.Text = ""
        txtJenismakan.Text = ""
        txtHargamakan.Text = ""
        txtJenisminum.Text = ""
        txtHargaMinum.Text = ""
        txtIdMenu.Focus()
    End Sub
    Sub MatikanForm()
        txtIdMenu.Enabled = False
        txtJenismakan.Enabled = False
        txtHargamakan.Enabled = False
        txtJenisminum.Enabled = False
        txtHargaMinum.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtIdMenu.Enabled = True
        txtJenismakan.Enabled = True
        txtHargamakan.Enabled = True
        txtJenisminum.Enabled = True
        txtHargaMinum.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Menu ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Call HidupkanForm()
        Call KosongkanForm()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call MatikanForm()
        Call KosongkanForm()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtIdMenu.Text = "" Or txtJenismakan.Text = "" Or txtHargamakan.Text = "" Or txtJenisminum.Text = "" Or txtHargaMinum.Text = "" Then
            MsgBox("Data Buku Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Menu where Id_Menu='" & txtIdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()

            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Menu values ('" & txtIdMenu.Text &
               "', '" & txtJenismakan.Text & "', '" & txtHargamakan.Text & "','" &
               txtJenisminum.Text & "','" & txtHargaMinum.Text & "')"
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
        txtJenismakan.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtHargamakan.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtJenisminum.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtHargaMinum.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        Call HidupkanForm()
        txtIdMenu.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtIdMenu.Text = "" Or txtJenismakan.Text = "" Or txtHargamakan.Text = "" Or txtJenisminum.Text = "" Or txtHargaMinum.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu set Jenis_Makanan = '" &
           txtJenismakan.Text & "', Jenis_Minuman = '" & txtHargamakan.Text & "', Harga_Minuman ='" & txtJenisminum.Text & "', Harga Makanan = '" &
           txtHargaMinum.Text & "'  where Id_Menu ='" & txtIdMenu.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtIdMenu.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ",
           "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then


                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Menu where Id_Menu ='" & txtIdMenu.Text & "'", Conn)
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

    Private Sub btn_Pelanggan_Click(sender As Object, e As EventArgs) Handles btn_Pelanggan.Click
        Pelanggan.Show()
    End Sub
End Class