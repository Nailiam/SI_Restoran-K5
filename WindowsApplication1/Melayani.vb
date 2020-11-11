Public Class Melayani
    Sub KosongkanForm()
        id_pramusaji.Text = ""
        nama_pramusaji.Text = ""
        nama_pemesan.Text = ""
        jumlah_pemesan.Text = ""
        nomor_meja.Text = ""
    End Sub
    Sub MatikanForm()
        id_pramusaji.Enabled = False
        nama_pramusaji.Enabled = False
        nama_pemesan.Enabled = False
        jumlah_pemesan.Enabled = False
        nomor_meja.Enabled = False
    End Sub
    Sub HidupkanForm()
        id_pramusaji.Enabled = True
        nama_pramusaji.Enabled = True
        nama_pemesan.Enabled = True
        jumlah_pemesan.Enabled = True
        nomor_meja.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Melayani ", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Melayani_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm() 'matikan form'
        Call TampilkanData()
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If id_pramusaji.Text = "" Or nama_pramusaji.Text = "" Or nama_pemesan.Text = "" Or jumlah_pemesan.Text = "" Or nomor_meja.Text = "" Then
            MsgBox("Data Melayani Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Melayani where Id_pramusaji='" & id_pramusaji.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into melayani values ('" & id_pramusaji.Text &
               "', '" & nama_pramusaji.Text & "', '" & nama_pemesan.Text & "', '" & jumlah_pemesan.Text & "', '" & nomor_meja.Text & "')"
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

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        id_pramusaji.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        nama_pramusaji.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        nama_pemesan.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        jumlah_pemesan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        nomor_meja.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Call HidupkanForm()
        id_pramusaji.Enabled = False
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If id_pramusaji.Text = "" Or nama_pramusaji.Text = "" Or nama_pemesan.Text = "" Or jumlah_pemesan.Text = "" Or nomor_meja.Text = "" Then
            MsgBox("Data Melayani Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update melayani set Nama_Pramusaji = '" &
           nama_pemesan.Text & "', Jenis_Kelamin = '" & nomor_meja.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If id_pramusaji.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from melayani where ID_Pramusaji = '" & id_pramusaji.Text & "'", Conn)
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