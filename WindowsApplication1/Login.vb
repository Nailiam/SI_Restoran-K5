Public Class Login
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Call koneksiDB()
        Dim cek As String
        cek = "Select * From Kasir Where Username= '" & txtUN.Text & "'and Password = '" & txtPass.Text & "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)
        CMD.ExecuteNonQuery()
        DM = CMD.ExecuteReader
        If DM.HasRows = True Then
            DM.Read()
            Kasir.Show()
            Me.Hide()
        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            Me.Show()
        End If
        Kasir.lblselamat.Text = txtUN.Text
        Data_Menu_Makanan.lblwelcome.Text = txtUN.Text
    End Sub
End Class
