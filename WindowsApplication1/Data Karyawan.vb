Public Class Data_Karyawan
    Sub KosongkanForm()
        txt_id_karyawan.Text = ""
        txt_nama_karyawan.Text = ""
        txt_lahir.Text = ""
        cmb_jk.Text = ""
        cmb_agama.Text = ""
        txt_hp.Text = ""
        txt_alamat.Text = ""
        cmb_status.Text = ""
        txt_id_karyawan.Focus()
    End Sub
    Sub MatikanForm()
        txt_id_karyawan.Enabled = False
        txt_nama_karyawan.Enabled = False
        txt_lahir.Enabled = False
        cmb_jk.Enabled = False
        cmb_agama.Enabled = False
        txt_hp.Enabled = False
        txt_alamat.Enabled = False
        cmb_status.Enabled = False
    End Sub
    Sub HidupkanForm()
        txt_id_karyawan.Enabled = True
        txt_nama_karyawan.Enabled = True
        txt_lahir.Enabled = True
        cmb_jk.Enabled = True
        cmb_agama.Enabled = True
        txt_hp.Enabled = True
        txt_alamat.Enabled = True
        cmb_status.Enabled = True
    End Sub
    Sub TampilkanData()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("Select * from From Data Karyawan", Conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Sub Foto1()
        PictureBox1.ImageLocation = ""
    End Sub
End Class