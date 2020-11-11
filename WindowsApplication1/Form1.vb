Public Class Menu

    Private Property Id_Menu As Object

    Sub KosongkanForm()
        txtIdMenu.Text = ""
        txtJenismakan.Text = ""
        txtJenisminum.Text = ""
        txtHargaMin.Text = ""
        txtHargaMakan.Text = ""
        txtIdMenu.Focus()
    End Sub
    Sub MatikanForm()
        txtIdMenu.Enabled = False
        txtJenismakan.Enabled = False
        txtJenisminum.Enabled = False
        txtHargaMin.Enabled = False
        txtHargaMakan.Enabled = False
    End Sub
    Sub HidupkanForm()
        txtIdMenu.Enabled = True
        txtJenismakan.Enabled = True
        txtJenisminum.Enabled = True
        txtHargaMin.Enabled = True
        txtHargaMakan.Enabled = True

    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select  * From Menu ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True
    End Sub

    Private Sub Input_Menu_Enter(sender As Object, e As EventArgs) Handles Input_Menu.Enter
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
        If txtIdMenu.Text = "" Or txtJenismakan.Text = "" Or txtJenisminum.Text = "" Or txtHargaMin.Text = "" Or txtHargaMakan.Text = "" Then
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
               "', '" & txtJenismakan.Text & "', '" & txtJenisminum.Text & "','" &
               txtHargaMin.Text & "','" & txtHargaMakan.Text & "')"
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
        txtJenisminum.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtHargaMin.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtHargaMakan.Text = DGV.Rows(e.RowIndex).Cells(4).Value

        Call HidupkanForm()
        txtIdMenu.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtIdMenu.Text = "" Or txtJenismakan.Text = "" Or txtJenisminum.Text = "" Or txtHargaMin.Text = "" Or txtHargaMakan.Text = "" Then
            MsgBox("Data Menu Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" update Menu set Jenis_Makanan = '" &
           txtJenismakan.Text & "', Jenis_Minuman = '" & txtJenisminum.Text & "', Harga_Minuman ='" & txtHargaMin.Text & "', Harga Makanan = '" &
           txtHargaMakan.Text & "'  where Id_Menu ='" & txtIdMenu.Text & "'", Conn)
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

    Private Sub btnPramusaji_Click(sender As Object, e As EventArgs) Handles btnPramusaji.Click
        Form_Pramusaji.Show()
    End Sub
End Class