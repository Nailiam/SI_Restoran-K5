<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Menu_Makanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblwelcome = New System.Windows.Forms.GroupBox()
        Me.txtHargamakan = New System.Windows.Forms.TextBox()
        Me.txtJenismakan = New System.Windows.Forms.TextBox()
        Me.txtIdMakanan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.btn_Minuman = New System.Windows.Forms.Button()
        Me.lblwelcome.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.Controls.Add(Me.txtHargamakan)
        Me.lblwelcome.Controls.Add(Me.txtJenismakan)
        Me.lblwelcome.Controls.Add(Me.txtIdMakanan)
        Me.lblwelcome.Controls.Add(Me.Label5)
        Me.lblwelcome.Controls.Add(Me.Label2)
        Me.lblwelcome.Controls.Add(Me.Label1)
        Me.lblwelcome.Location = New System.Drawing.Point(12, 19)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(321, 194)
        Me.lblwelcome.TabIndex = 0
        Me.lblwelcome.TabStop = False
        Me.lblwelcome.Text = "Input_Menu_Makanan"
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
        'txtIdMakanan
        '
        Me.txtIdMakanan.Location = New System.Drawing.Point(125, 28)
        Me.txtIdMakanan.Name = "txtIdMakanan"
        Me.txtIdMakanan.Size = New System.Drawing.Size(121, 20)
        Me.txtIdMakanan.TabIndex = 5
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
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Makanan"
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(21, 234)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(128, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(241, 234)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(21, 278)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(128, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 278)
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
        Me.GroupBox2.Text = "Detail_Menu_Makanan"
        '
        'btn_Minuman
        '
        Me.btn_Minuman.Location = New System.Drawing.Point(695, 320)
        Me.btn_Minuman.Name = "btn_Minuman"
        Me.btn_Minuman.Size = New System.Drawing.Size(141, 38)
        Me.btn_Minuman.TabIndex = 12
        Me.btn_Minuman.Text = "Form Menu Minuman "
        Me.btn_Minuman.UseVisualStyleBackColor = True
        '
        'Data_Menu_Makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 370)
        Me.Controls.Add(Me.btn_Minuman)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "Data_Menu_Makanan"
        Me.Text = "Data Menu Makanan"
        Me.lblwelcome.ResumeLayout(False)
        Me.lblwelcome.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblwelcome As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdMakanan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents btn_Minuman As Button
End Class
