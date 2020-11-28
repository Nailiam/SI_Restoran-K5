<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Karyawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_foto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.txt_alamat = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmb_agama = New System.Windows.Forms.ComboBox()
        Me.cmb_jk = New System.Windows.Forms.ComboBox()
        Me.txt_lahir = New System.Windows.Forms.TextBox()
        Me.txt_hp = New System.Windows.Forms.TextBox()
        Me.txt_nama_karyawan = New System.Windows.Forms.TextBox()
        Me.txt_id_karyawan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblselamat = New System.Windows.Forms.Label()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(16, 521)
        Me.DGV2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.RowHeadersWidth = 51
        Me.DGV2.Size = New System.Drawing.Size(748, 112)
        Me.DGV2.TabIndex = 19
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(429, 465)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(101, 39)
        Me.btn_simpan.TabIndex = 18
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(663, 465)
        Me.btn_cari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(101, 39)
        Me.btn_cari.TabIndex = 17
        Me.btn_cari.Text = "Cari Data"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(549, 465)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 39)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_foto
        '
        Me.txt_foto.Location = New System.Drawing.Point(549, 418)
        Me.txt_foto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_foto.Name = "txt_foto"
        Me.txt_foto.Size = New System.Drawing.Size(213, 22)
        Me.txt_foto.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(425, 422)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Foto Diri :"
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(663, 372)
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(101, 39)
        Me.btn_browse.TabIndex = 13
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(429, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 311)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_status)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cmb_agama)
        Me.GroupBox1.Controls.Add(Me.cmb_jk)
        Me.GroupBox1.Controls.Add(Me.txt_lahir)
        Me.GroupBox1.Controls.Add(Me.txt_hp)
        Me.GroupBox1.Controls.Add(Me.txt_nama_karyawan)
        Me.GroupBox1.Controls.Add(Me.txt_id_karyawan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(401, 452)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Karyawan Tetap", "Karyawan Kontrak"})
        Me.cmb_status.Location = New System.Drawing.Point(137, 396)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(187, 24)
        Me.cmb_status.TabIndex = 17
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(137, 273)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(244, 115)
        Me.txt_alamat.TabIndex = 16
        Me.txt_alamat.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(137, 134)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(187, 22)
        Me.DateTimePicker1.TabIndex = 15
        '
        'cmb_agama
        '
        Me.cmb_agama.FormattingEnabled = True
        Me.cmb_agama.Items.AddRange(New Object() {"Islam", "Budha", "Hindhu", "Kristen"})
        Me.cmb_agama.Location = New System.Drawing.Point(137, 199)
        Me.cmb_agama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_agama.Name = "cmb_agama"
        Me.cmb_agama.Size = New System.Drawing.Size(187, 24)
        Me.cmb_agama.TabIndex = 14
        '
        'cmb_jk
        '
        Me.cmb_jk.FormattingEnabled = True
        Me.cmb_jk.Items.AddRange(New Object() {"Perempuan", "Laki-Laki"})
        Me.cmb_jk.Location = New System.Drawing.Point(137, 166)
        Me.cmb_jk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_jk.Name = "cmb_jk"
        Me.cmb_jk.Size = New System.Drawing.Size(187, 24)
        Me.cmb_jk.TabIndex = 13
        '
        'txt_lahir
        '
        Me.txt_lahir.Location = New System.Drawing.Point(137, 102)
        Me.txt_lahir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_lahir.Name = "txt_lahir"
        Me.txt_lahir.Size = New System.Drawing.Size(187, 22)
        Me.txt_lahir.TabIndex = 12
        '
        'txt_hp
        '
        Me.txt_hp.Location = New System.Drawing.Point(137, 233)
        Me.txt_hp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_hp.Name = "txt_hp"
        Me.txt_hp.Size = New System.Drawing.Size(187, 22)
        Me.txt_hp.TabIndex = 11
        '
        'txt_nama_karyawan
        '
        Me.txt_nama_karyawan.Location = New System.Drawing.Point(137, 69)
        Me.txt_nama_karyawan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nama_karyawan.Name = "txt_nama_karyawan"
        Me.txt_nama_karyawan.Size = New System.Drawing.Size(187, 22)
        Me.txt_nama_karyawan.TabIndex = 10
        '
        'txt_id_karyawan
        '
        Me.txt_id_karyawan.Location = New System.Drawing.Point(137, 36)
        Me.txt_id_karyawan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id_karyawan.Name = "txt_id_karyawan"
        Me.txt_id_karyawan.Size = New System.Drawing.Size(187, 22)
        Me.txt_id_karyawan.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 400)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Status :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 273)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Alamat :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 236)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "No HP :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Agama :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jenis Kelamin :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tanggal Lahir :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tempat Lahir :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Karyawan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Karyawan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Selamat Datang"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblselamat
        '
        Me.lblselamat.AutoSize = True
        Me.lblselamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselamat.Location = New System.Drawing.Point(289, 11)
        Me.lblselamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblselamat.Name = "lblselamat"
        Me.lblselamat.Size = New System.Drawing.Size(0, 39)
        Me.lblselamat.TabIndex = 20
        '
        'Data_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 647)
        Me.Controls.Add(Me.lblselamat)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_foto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Data_Karyawan"
        Me.Text = "Data Karyawan"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_foto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents txt_alamat As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmb_agama As ComboBox
    Friend WithEvents cmb_jk As ComboBox
    Friend WithEvents txt_lahir As TextBox
    Friend WithEvents txt_hp As TextBox
    Friend WithEvents txt_nama_karyawan As TextBox
    Friend WithEvents txt_id_karyawan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblselamat As Label
End Class
