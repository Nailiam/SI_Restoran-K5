﻿Public Class Kasir
    Sub KosongkanForm()
        txt_id.Text = ""
        txt_nama.Text = ""
        ComboBox1.Text = ""
    End Sub
    Sub MatikanForm()
        txt_id.Enabled = False
        txt_nama.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id.Enabled = True
        txt_nama.Enabled = True
        ComboBox1.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Kasir", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Kasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_input.Click
        Call HidupkanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand(" select * from Kasir where Id_Kasir ='" & txt_id.Text & "'", Conn)
            DM = CMD.ExecuteReader
            DM.Read()
            If Not DM.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Kasir values ('" & txt_id.Text &
               "', '" & txt_nama.Text & "', '" & ComboBox1.Text & "')"
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
        txt_id.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Call HidupkanForm()
        txt_id.Enabled = False
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If txt_id.Text = "" Or txt_nama.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Kasir Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update Kasir set Nama_Kasir = '" &
           txt_nama.Text & "', Jenis_Kelamin = '" & ComboBox1.Text & "'", Conn)
            DM = CMD.ExecuteReader
            MsgBox("Update Data Berhasil")
        End If
        Call KosongkanForm()
        Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txt_id.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub
        Else
            If MessageBox.Show(" Are you sure to delete this data?", "Konfirmasi", MessageBoxButtons.YesNoCancel) Then
                Call koneksiDB()
                CMD = New OleDb.OleDbCommand(" delete from Kasir where ID_Kasir = '" & txt_id.Text & "'", Conn)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class