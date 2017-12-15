Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        Dim koneksi As MySqlConnection
        Dim str As String

        str = "server=localhost; user=root; password=; database=testapp"

        koneksi = New MySqlConnection(str)
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
            MsgBox("Koneksi Berhasil")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connectionDB()
    End Sub
End Class
