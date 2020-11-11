Module Myconnection
        Public Koneksi As New Myconnection.KoneksiDatabase
        Public objConnection As OleDb.OleDbConnection
        Public objCommand As OleDb.OleDbCommand
        Public objDataAdapter As OleDb.OleDbDataAdapter
        Public objDatareader As OleDb.OleDbDataReader
        Public strSQL As String
        Public Class KoneksiDatabase
            Public Function open() As OleDb.OleDbConnection
                Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.1.2; Data Source= " & Application.StartupPath & "\SI_Restoran.accdb")
                conect.Open()
                Return conect
            End Function
        End Class
    End Module


