<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHargamakan = New System.Windows.Forms.TextBox()
        Me.txtJenismakan = New System.Windows.Forms.TextBox()
        Me.txtHargaMinum = New System.Windows.Forms.TextBox()
        Me.txtJenisminum = New System.Windows.Forms.TextBox()
        Me.txtIdMenu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Pelanggan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHargamakan)
        Me.GroupBox1.Controls.Add(Me.txtJenismakan)
        Me.GroupBox1.Controls.Add(Me.txtHargaMinum)
        Me.GroupBox1.Controls.Add(Me.txtJenisminum)
        Me.GroupBox1.Controls.Add(Me.txtIdMenu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input_Menu"
        '
        'txtHargamakan
        '
        Me.txtHargamakan.Location = New System.Drawing.Point(125, 87)
        Me.txtHargamakan.Name = "txtHargamakan"
        Me.txtHargamakan.Size = New System.Drawing.Size(121, 20)
        Me.txtHargamakan.TabIndex = 9
        '
        'txtJenismakan
        '
        Me.txtJenismakan.Location = New System.Drawing.Point(125, 57)
        Me.txtJenismakan.Name = "txtJenismakan"
        Me.txtJenismakan.Size = New System.Drawing.Size(121, 20)
        Me.txtJenismakan.TabIndex = 8
        '
        'txtHargaMinum
        '
        Me.txtHargaMinum.Location = New System.Drawing.Point(125, 152)
        Me.txtHargaMinum.Name = "txtHargaMinum"
        Me.txtHargaMinum.Size = New System.Drawing.Size(121, 20)
        Me.txtHargaMinum.TabIndex = 7
        '
        'txtJenisminum
        '
        Me.txtJenisminum.Location = New System.Drawing.Point(125, 117)
        Me.txtJenisminum.Name = "txtJenisminum"
        Me.txtJenisminum.Size = New System.Drawing.Size(121, 20)
        Me.txtJenisminum.TabIndex = 6
        '
        'txtIdMenu
        '
        Me.txtIdMenu.Location = New System.Drawing.Point(125, 28)
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(121, 20)
        Me.txtIdMenu.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga_Makanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga_Minuman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis_Minuman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis_Makanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id_Menu"
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(21, 212)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(117, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(211, 212)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(21, 254)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(117, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(211, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(15, 28)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(456, 230)
        Me.DGV.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(359, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 282)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail_Menu"
        '
        'btn_Pelanggan
        '
        Me.btn_Pelanggan.Location = New System.Drawing.Point(665, 324)
        Me.btn_Pelanggan.Name = "btn_Pelanggan"
        Me.btn_Pelanggan.Size = New System.Drawing.Size(141, 38)
        Me.btn_Pelanggan.TabIndex = 12
        Me.btn_Pelanggan.Text = "Form Pelanggan"
        Me.btn_Pelanggan.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 370)
        Me.Controls.Add(Me.btn_Pelanggan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Menu"
        Me.Text = "Data Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHargaMinum As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisminum As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMenu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHargamakan As TextBox
    Friend WithEvents txtJenismakan As TextBox
    Friend WithEvents btn_Pelanggan As Button
End Class
