Imports MySql.Data.MySqlClient
Module ModuleConnection
    Public connection As MySqlConnection
    Public commandSQL As MySqlCommand
    Public dataAdapter As MySqlDataAdapter
    Public dataReader As MySqlDataReader
    Public dataSet As DataSet
    Public stringDB As String

    'MENGKONEKSIKAN DATABASE
    Sub connectionDB()
        Dim stringDB As String = "server=localhost; user=root; password=; database=testapp"
        connection = New MySqlConnection(stringDB)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                'MsgBox("Koneksi berhasil")
            End If
        Catch ex As Exception
            MsgBox("Kesalahan dalam mengkoneksikan ke database.")
        End Try
    End Sub

    'MENUTUP KONEKSI
    Sub connectionCloseDB()
        If Not IsNothing(connection) Then
            connection.Close()
            connection = Nothing
        End If
    End Sub

    'MENAMPILKAN DATAGRID TABLE KTP
    Sub showDataGrid()
        Try
            connectionDB()
            Dim strQuery As String = "SELECT
                                    ktp.ktp_no,
                                    ktp.ktp_nama_lengkap,
                                    ktp.ktp_jk,
                                    ktp.ktp_status_kawin,
                                    ktp.ktp_alamat,
                                    ktp.ktp_alamat_rtrw,
                                    ktp.ktp_alamat_desa,
                                    ktp.ktp_alamat_kecamatan,
                                    ktp.ktp_alamat_kota,
                                    ktp.ktp_agama,
                                    ktp.ktp_goldar,
                                    ktp.ktp_kwn,
                                    ktp.ktp_berlaku
                                  FROM
                                    ktp"
            dataAdapter = New MySqlDataAdapter(strQuery, connection)
            dataSet = New DataSet

            dataAdapter.Fill(dataSet, "ktp")
            FormDataKTP.DataGridKTP.DataSource = dataSet.Tables("ktp")
            FormDataKTP.DataGridKTP.ReadOnly = True
            With FormDataKTP.DataGridKTP
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "No.KTP"
                .Columns(1).HeaderCell.Value = "Nama"
                .Columns(2).HeaderCell.Value = "JenisKelamin"
                .Columns(2).Width = 30
                .Columns(3).HeaderCell.Value = "StatusPerkawinan"
                .Columns(3).Width = 30
                .Columns(4).HeaderCell.Value = "Alamat"
                .Columns(5).HeaderCell.Value = "RT/RW"
                .Columns(5).Width = 45
                .Columns(6).HeaderCell.Value = "Kelurahan"
                .Columns(7).HeaderCell.Value = "Kecamatan"
                .Columns(8).HeaderCell.Value = "Kota/Kab."
                .Columns(9).HeaderCell.Value = "Agama"
                .Columns(10).HeaderCell.Value = "Gol.Darah"
                .Columns(10).Width = 30
                .Columns(11).HeaderCell.Value = "Kewarganegaraan"
                .Columns(12).HeaderCell.Value = "Berlaku"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'SourceProto
    'Public Sub ExecuteNonQuery(ByVal Query As String)
    '    connectionDB()
    '    commandSQL = New MySqlCommand(Query, connection)
    '    commandSQL.ExecuteNonQuery()
    '    commandSQL = Nothing
    '    connectionCloseDB()
    'End Sub

    'PROSES SIMPAN DATA
    Sub act_simpan()
        Dim NoKtp, NamaLengkap, JenisKelamin, StatusKawin, Alamat, Rt, Rw, Desa, Kecamatan, Kota, Agama, Goldar, Kwn, Berlaku As String
        NoKtp = FormDataKTP.t_noktp.Text
        NamaLengkap = FormDataKTP.t_namalengkap.Text
        JenisKelamin = convert_JK(FormDataKTP.cmb_jk.Text)
        StatusKawin = convert_SK(FormDataKTP.cmb_skawin.Text)
        Alamat = FormDataKTP.t_alamat.Text
        Rt = FormDataKTP.t_rt.Text
        Rw = FormDataKTP.t_rw.Text
        Desa = FormDataKTP.t_desa.Text
        Kecamatan = FormDataKTP.t_kecamatan.Text
        Kota = FormDataKTP.t_kota.Text
        Agama = FormDataKTP.cmb_agama.Text
        Goldar = FormDataKTP.cmb_goldar.Text
        Kwn = FormDataKTP.cmb_kwn.Text
        Berlaku = FormDataKTP.t_berlaku.Text

        'ExecuteNonQuery(strQuery)

        Try
            Dim strQuery As String
            strQuery = "INSERT INTO ktp (ktp.ktp_no,ktp.ktp_nama_lengkap,ktp.ktp_jk,ktp.ktp_status_kawin,ktp.ktp_alamat,ktp.ktp_alamat_rtrw,ktp.ktp_alamat_desa,ktp.ktp_alamat_kecamatan,ktp.ktp_alamat_kota,ktp.ktp_agama,ktp.ktp_goldar,ktp.ktp_kwn,ktp.ktp_berlaku)" _
                    & "VALUES('" _
                    & NoKtp & "','" _
                    & NamaLengkap & "','" _
                    & JenisKelamin & "','" _
                    & StatusKawin & "','" _
                    & Alamat & "','" _
                    & Rt & "/" & Rw & "','" _
                    & Desa & "','" _
                    & Kecamatan & "','" _
                    & Kota & "','" _
                    & Agama & "','" _
                    & Goldar & "','" _
                    & Kwn & "','" _
                    & Berlaku _
                    & "')"
            commandSQL = New MySqlCommand(strQuery, connection)
            commandSQL.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'MENGHAPUS DATA YANG TELAH DI SUBMIT
        'DISINI
    End Sub

    'PROSES UBAH DATA
    Sub act_ubah()
        Dim NoKtp, NamaLengkap, JenisKelamin, StatusKawin, Alamat, Rt, Rw, Desa, Kecamatan, Kota, Agama, Goldar, Kwn, Berlaku As String
        NoKtp = FormDataKTP.t_noktp.Text
        NamaLengkap = FormDataKTP.t_namalengkap.Text
        JenisKelamin = convert_JK(FormDataKTP.cmb_jk.Text)
        StatusKawin = convert_SK(FormDataKTP.cmb_skawin.Text)
        Alamat = FormDataKTP.t_alamat.Text
        Rt = FormDataKTP.t_rt.Text
        Rw = FormDataKTP.t_rw.Text
        Desa = FormDataKTP.t_desa.Text
        Kecamatan = FormDataKTP.t_kecamatan.Text
        Kota = FormDataKTP.t_kota.Text
        Agama = FormDataKTP.cmb_agama.Text
        Goldar = FormDataKTP.cmb_goldar.Text
        Kwn = FormDataKTP.cmb_kwn.Text
        Berlaku = FormDataKTP.t_berlaku.Text

        'ExecuteNonQuery(strQuery)

        Try
            Dim strQuery As String
            strQuery = "UPDATE ktp SET" _
                       & " ktp.ktp_nama_lengkap='" & NamaLengkap & "'" _
                       & ",ktp.ktp_jk='" & JenisKelamin & "'" _
                       & ",ktp.ktp_status_kawin='" & StatusKawin & "'" _
                       & ",ktp.ktp_alamat='" & Alamat & "'" _
                       & ",ktp.ktp_alamat_rtrw='" & Rt & "/" & Rw & "'" _
                       & ",ktp.ktp_alamat_desa='" & Desa & "'" _
                       & ",ktp.ktp_alamat_kecamatan='" & Kecamatan & "'" _
                       & ",ktp.ktp_alamat_kota='" & Kota & "'" _
                       & ",ktp.ktp_agama='" & Agama & "'" _
                       & ",ktp.ktp_goldar='" & Goldar & "'" _
                       & ",ktp.ktp_kwn='" & Kwn & "'" _
                       & ",ktp.ktp_berlaku='" & Berlaku & "' " _
                       & "WHERE  " _
                       & "ktp.ktp_no='" & NoKtp & "';"
            commandSQL = New MySqlCommand(strQuery, connection)
            commandSQL.ExecuteNonQuery()
            MsgBox("Data berhasil diubah.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'PROSES HAPUS DATA
    Sub act_hapus()
        Dim NoKtp As String
        NoKtp = FormDataKTP.t_noktp.Text

        Try
            Dim strQuery As String
            strQuery = "DELETE FROM ktp " _
                       & "WHERE  " _
                       & "ktp.ktp_no='" & NoKtp & "';"
            commandSQL = New MySqlCommand(strQuery, connection)
            commandSQL.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'KONVERSI COMBO JK
    Public Function convert_JK(ByVal jk As String) As String
        If jk.ToUpper = "LAKI-LAKI" Then
            jk = "L"
        ElseIf jk.ToUpper = "PEREMPUAN" Then
            jk = "P"
        End If
        Return jk
    End Function

    Public Function convertBack_JK(ByVal jk As String) As String
        If jk.ToUpper = "L" Then
            jk = "LAKI-LAKI"
        ElseIf jk.ToUpper = "P" Then
            jk = "PEREMPUAN"
        End If
        Return jk
    End Function

    'KONVERSI COMBO STATUS KAWIN
    Public Function convert_SK(ByVal sk As String)
        If sk.ToUpper = "KAWIN" Then
            sk = "K"
        ElseIf sk.ToUpper = "BELUM KAWIN" Then
            sk = "BK"
        ElseIf sk.ToUpper = "JANDA" Then
            sk = "J"
        ElseIf sk.ToUpper = "DUDA" Then
            sk = "D"
        End If
        Return sk
    End Function

    Public Function convertBack_SK(ByVal sk As String)
        If sk.ToUpper = "K" Then
            sk = "KAWIN"
        ElseIf sk.ToUpper = "BK" Then
            sk = "BELUM KAWIN"
        ElseIf sk.ToUpper = "J" Then
            sk = "JANDA"
        ElseIf sk.ToUpper = "D" Then
            sk = "DUDA"
        End If
        Return sk
    End Function

    'KONVERSI COMBO AGAMA
    Public Function convert_AGAMA(ByVal a As String)
        Dim conA As String = "NULL"
        Select Case a
            Case a.ToLower = "islam"
                conA = "AG1"
            Case a.ToLower = "kristen"
                conA = "AG2"
            Case a.ToLower = "katholik"
                conA = "AG3"
            Case a.ToLower = "hindu"
                conA = "AG$"
            Case a.ToLower = "budha"
                conA = "AG5"
        End Select
        Return conA
    End Function

    'VALIDASI INPUTAN COMBO KOSONG
    Public Function check_empty_combo(item As String, def As String)
        Dim retVal As String
        If item = [String].Empty Then
            retVal = def
        Else
            retVal = item
        End If
        Return retVal
    End Function

    'VALIDASI INPUTAN COMBO
    Public Function check_valid_combo(ByVal item As String)
        Dim msgResult As String
        Dim comboName As String
        If item.ToLower = "1" Then
            comboName = "Jenis Kelamin"
            msgResult = "Anda belum memilih : " & comboName
        ElseIf item.ToLower = "2" Then
            comboName = "Status Perkawinan"
            msgResult = "Anda belum memilih : " & comboName
        ElseIf item.ToLower = "3" Then
            comboName = "Agama"
            msgResult = "Anda belum memilih : " & comboName
        ElseIf item.ToLower = "4" Then
            comboName = "Gol. Darah"
            msgResult = "Anda belum memilih : " & comboName
        ElseIf item.ToLower = "5" Then
            comboName = "Kewarganegaraan"
            msgResult = "Anda belum memilih : " & comboName
        Else
            msgResult = "TRUE"
        End If
        Return msgResult
    End Function


End Module
