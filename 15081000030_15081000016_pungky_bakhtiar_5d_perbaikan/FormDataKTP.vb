Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class FormDataKTP
    Private Sub FormDataKTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DEFAULT ACTION FORM_LOAD
        reset_inputs()
        disable_inputs()
        action_button_onLoad()
        showDataGrid()
    End Sub

    Sub default_onLoad()
        'DEFAULT ACTION FORM_LOAD
        reset_inputs()
        disable_inputs()
        action_button_onLoad()
        showDataGrid()
    End Sub

    'RESET INPUTAN
    Sub reset_inputs()
        t_noktp.Text = ""
        t_namalengkap.Text = ""
        t_alamat.Text = ""
        t_rt.Text = ""
        t_rw.Text = ""
        t_desa.Text = ""
        t_kecamatan.Text = ""
        t_kota.Text = ""
        t_berlaku.Text = ""

        cmb_jk.Items.Clear()
        cmb_skawin.Items.Clear()
        cmb_agama.Items.Clear()
        cmb_goldar.Items.Clear()
        cmb_kwn.Items.Clear()

        cmb_jk.Text = ""
        cmb_skawin.Text = ""
        cmb_agama.Text = ""
        cmb_goldar.Text = ""
        cmb_kwn.Text = ""

        'cmb_jk.Items.Add("Pilih Jenis Kelamin")
        'cmb_skawin.Items.Add("Pilih Status Perkawinan")
        'cmb_agama.Items.Add("Pilih Agamas")
        'cmb_goldar.Items.Add("Pilih Gol. Darah")
        'cmb_kwn.Items.Add("Pilih Kewarganegaraan")
    End Sub

    'DISABLE INPUTAN
    Sub disable_inputs()
        t_noktp.Enabled = False
        t_namalengkap.Enabled = False
        cmb_jk.Enabled = False
        cmb_skawin.Enabled = False
        t_alamat.Enabled = False
        t_rt.Enabled = False
        t_rw.Enabled = False
        t_desa.Enabled = False
        t_kecamatan.Enabled = False
        t_kota.Enabled = False
        cmb_agama.Enabled = False
        cmb_goldar.Enabled = False
        cmb_kwn.Enabled = False
        t_berlaku.Enabled = False
    End Sub

    'ENABLE INPUTAN
    Sub enable_inputs()
        t_noktp.Enabled = True
        t_namalengkap.Enabled = True
        cmb_jk.Enabled = True
        cmb_skawin.Enabled = True
        t_alamat.Enabled = True
        t_rt.Enabled = True
        t_rw.Enabled = True
        t_desa.Enabled = True
        t_kecamatan.Enabled = True
        t_kota.Enabled = True
        cmb_agama.Enabled = True
        cmb_goldar.Enabled = True
        cmb_kwn.Enabled = True
        t_berlaku.Enabled = True
    End Sub

    'ONBUTTON _Load
    Sub action_button_onLoad()
        btn_baru.Enabled = True
        btn_refresh.Enabled = True
        btn_save.Enabled = False
        btn_ubah.Enabled = False
        btn_hapus.Enabled = False
        btn_cancel.Enabled = False
    End Sub

    'ONBUTTON _New
    Sub action_button_onNew()
        btn_baru.Enabled = False
        btn_ubah.Enabled = False
        btn_refresh.Enabled = False
        btn_hapus.Enabled = False
        btn_cancel.Enabled = True
        btn_save.Enabled = True
    End Sub

    'ONBUTTON _Edit
    Sub action_button_onEdit()
        btn_baru.Enabled = False
        btn_ubah.Enabled = False
        btn_hapus.Enabled = False
        btn_refresh.Enabled = True
        btn_cancel.Enabled = True
        btn_save.Enabled = True
    End Sub

    'ONBUTTON _Refresh DataGrids
    Sub action_button_onRefresh()
        DataGridKTP.Columns.Clear()
        showDataGrid()
    End Sub

    'INIT ALL COMBOBOX
    Sub init_combo()
        get_combo_AGAMA()
        get_combo_GOLDAR()
        get_combo_JK()
        get_combo_KWN()
        get_combo_SP()
    End Sub

    'INIT COMBO JENIS KELAMAIN
    Sub get_combo_JK()
        cmb_jk.Items.Add("LAKI-LAKI")
        cmb_jk.Items.Add("PEREMPUAN")
    End Sub

    'INIT COMBO STATUS PERKAWINAN
    Sub get_combo_SP()
        cmb_skawin.Items.Add("KAWIN")
        cmb_skawin.Items.Add("BELUM KAWIN")
        cmb_skawin.Items.Add("JANDA")
        cmb_skawin.Items.Add("DUDA")
    End Sub

    'INIT COMBO AGAMA
    Sub get_combo_AGAMA()
        cmb_agama.Items.Add("ISLAM")
        cmb_agama.Items.Add("KRISTEN")
        cmb_agama.Items.Add("KATHOLIK")
        cmb_agama.Items.Add("HINDU")
        cmb_agama.Items.Add("BUDHA")
    End Sub

    'INIT COMBO GOLONGAN DARAH
    Sub get_combo_GOLDAR()
        cmb_goldar.Items.Add("A")
        cmb_goldar.Items.Add("B")
        cmb_goldar.Items.Add("AB")
        cmb_goldar.Items.Add("O")
    End Sub

    'INIT COMBO KEWARGANEGARAAN
    Sub get_combo_KWN()
        cmb_kwn.Items.Add("WNA")
        cmb_kwn.Items.Add("WNI")
    End Sub


    'BUTTON ACTION BATAL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim result As Integer = MessageBox.Show("Anda yakin akan membatalkan proses ini ?", "Konfirmasi Pembatalan", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            reset_inputs()
            disable_inputs()
            action_button_onLoad()
            btn_baru.Focus()
        End If
    End Sub

    'BUTTON ACTION SIMPAN BARU / UBAH
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text.ToLower = "simpan" Then
            If input_check() = True Then
                act_simpan()
                default_onLoad()
            Else
                Exit Sub
            End If
        ElseIf btn_save.Text.ToLower = "ubah" Then
            If input_check() = True Then
                act_ubah()
                default_onLoad()
            Else
                Exit Sub
            End If
        End If

        'MsgBox(NoKtp & NamaLengkap & JenisKelamin & StatusKawin & Alamat & Rt & Rw)
        'MsgBox(Desa & Kecamatan & Kota & Agama & Goldar & Kwn & Berlaku)

    End Sub

    'BUTTON ACTION BARU
    Private Sub btn_baru_Click(sender As Object, e As EventArgs) Handles btn_baru.Click
        reset_inputs()
        enable_inputs()
        action_button_onNew()
        init_combo()
        t_noktp.Focus()
    End Sub

    'BUTTON ACTION UBAH
    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        btn_save.Text = "Ubah"
        enable_inputs()
        t_noktp.Enabled = False
        action_button_onEdit()
        init_combo()
    End Sub

    'BUTTON ACTION HAPUS
    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim result As Integer = MessageBox.Show("Anda yakin akan menghapus data: " & t_noktp.Text & " ?", "Konfirmasi Hapus", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            act_hapus()
            reset_inputs()
            disable_inputs()
            showDataGrid()
            action_button_onLoad()
            btn_baru.Focus()
        End If
    End Sub

    'BUTTON ACTION REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        action_button_onRefresh()
    End Sub

    'VALIDASI SEMUA INPUTAN
    Sub input_check_validation()
        Dim NoKtp, NamaLengkap, JenisKelamin, StatusKawin, Alamat, Rt, Rw, Desa, Kecamatan, Kota, Agama, Goldar, Kwn, Berlaku As String

        NoKtp = t_noktp.Text
        NamaLengkap = t_namalengkap.Text
        JenisKelamin = cmb_jk.Text
        StatusKawin = cmb_skawin.Text
        Alamat = t_alamat.Text
        Rt = t_rt.Text
        Rw = t_rw.Text
        Desa = t_desa.Text
        Kecamatan = t_kecamatan.Text
        Kota = t_kota.Text
        Agama = cmb_agama.Text
        Goldar = cmb_goldar.Text
        Kwn = cmb_kwn.Text
        Berlaku = t_berlaku.Text

        If NoKtp = "" Then
            MsgBox("No. KTP harus diisi.")
            t_noktp.Focus()
        ElseIf NamaLengkap = "" Then
            MsgBox("Nama Lengkap harus diisi.")
            t_namalengkap.Focus()
        ElseIf JenisKelamin = "" Then
            MsgBox("Jenis Kelamin harus diisi.")
            cmb_jk.Focus()
        ElseIf StatusKawin = "" Then
            MsgBox("Status Perkawinan harus diisi.")
            cmb_skawin.Focus()
        ElseIf Alamat = "" Then
            MsgBox("Alamat harus diisi.")
            t_alamat.Focus()
        ElseIf Rt = "" Or Rt.Length < 3 Then
            MsgBox("RT harus diisi dengan format yang benar.")
            t_rt.Focus()
        ElseIf Rw = "" Or Rw.Length < 3 Then
            MsgBox("RW harus diisi.")
            t_rw.Focus()
        ElseIf Desa = "" Then
            MsgBox("Kelurahan/Desa harus diisi.")
            t_desa.Focus()
        ElseIf Kecamatan = "" Then
            MsgBox("Kecamatan harus diisi.")
            t_kecamatan.Focus()
        ElseIf Kota = "" Then
            MsgBox("Kota/Kabupaten harus diisi.")
            t_kota.Focus()
        ElseIf Agama = "" Then
            MsgBox("Agama harus diisi.")
            cmb_agama.Focus()
        ElseIf Goldar = "" Then
            MsgBox("Golongan Darah harus diisi.")
            cmb_goldar.Focus()
        ElseIf Kwn = "" Then
            MsgBox("Kewarganegaraan harus diisi.")
            cmb_kwn.Focus()
        ElseIf Berlaku = "" Then
            MsgBox("Masa Berlaku harus diisi.")
            t_berlaku.Focus()
        End If

    End Sub

    Public Function input_check()
        Dim NoKtp, NamaLengkap, JenisKelamin, StatusKawin, Alamat, Rt, Rw, Desa, Kecamatan, Kota, Agama, Goldar, Kwn, Berlaku As String
        Dim retBool As Boolean = False
        NoKtp = t_noktp.Text
        NamaLengkap = t_namalengkap.Text
        JenisKelamin = cmb_jk.Text
        StatusKawin = cmb_skawin.Text
        Alamat = t_alamat.Text
        Rt = t_rt.Text
        Rw = t_rw.Text
        Desa = t_desa.Text
        Kecamatan = t_kecamatan.Text
        Kota = t_kota.Text
        Agama = cmb_agama.Text
        Goldar = cmb_goldar.Text
        Kwn = cmb_kwn.Text
        Berlaku = t_berlaku.Text

        If NoKtp = "" Then
            MsgBox("No. KTP harus diisi.")
            t_noktp.Focus()
        ElseIf NamaLengkap = "" Then
            MsgBox("Nama Lengkap harus diisi.")
            t_namalengkap.Focus()
        ElseIf JenisKelamin = "" Then
            MsgBox("Jenis Kelamin harus diisi.")
            cmb_jk.Focus()
        ElseIf StatusKawin = "" Then
            MsgBox("Status Perkawinan harus diisi.")
            cmb_skawin.Focus()
        ElseIf Alamat = "" Then
            MsgBox("Alamat harus diisi.")
            t_alamat.Focus()
        ElseIf Rt = "" Or Rt.Length < 3 Then
            MsgBox("RT harus diisi dengan format yang benar.")
            t_rt.Focus()
        ElseIf Rw = "" Or Rw.Length < 3 Then
            MsgBox("RW harus diisi.")
            t_rw.Focus()
        ElseIf Desa = "" Then
            MsgBox("Kelurahan/Desa harus diisi.")
            t_desa.Focus()
        ElseIf Kecamatan = "" Then
            MsgBox("Kecamatan harus diisi.")
            t_kecamatan.Focus()
        ElseIf Kota = "" Then
            MsgBox("Kota/Kabupaten harus diisi.")
            t_kota.Focus()
        ElseIf Agama = "" Then
            MsgBox("Agama harus diisi.")
            cmb_agama.Focus()
        ElseIf Goldar = "" Then
            MsgBox("Golongan Darah harus diisi.")
            cmb_goldar.Focus()
        ElseIf Kwn = "" Then
            MsgBox("Kewarganegaraan harus diisi.")
            cmb_kwn.Focus()
        ElseIf Berlaku = "" Then
            MsgBox("Masa Berlaku harus diisi.")
            t_berlaku.Focus()
        Else
            retBool = True
        End If

        Return retBool

    End Function

    'MENAMPILKAN DATAGRID KE INPUTAN
    Private Sub DataGridKTP_DoubleClick(sender As Object, e As EventArgs) Handles DataGridKTP.DoubleClick
        'MEMECAH DATA RT RW
        Dim rtrw As String = DataGridKTP.Item(5, DataGridKTP.CurrentRow.Index).Value
        Dim rt, rw As String
        Dim rtrwSplit() As String
        rtrwSplit = rtrw.Split("/")
        rt = rtrwSplit(0) 'value RT
        rw = rtrwSplit(1) 'value RW

        'PARSING DATA DARI DATA GRID KE TEXT BOX & COMBO
        t_noktp.Text = DataGridKTP.Item(0, DataGridKTP.CurrentRow.Index).Value
        t_namalengkap.Text = DataGridKTP.Item(1, DataGridKTP.CurrentRow.Index).Value
        t_alamat.Text = DataGridKTP.Item(4, DataGridKTP.CurrentRow.Index).Value
        t_rt.Text = rt
        t_rw.Text = rw
        t_desa.Text = DataGridKTP.Item(6, DataGridKTP.CurrentRow.Index).Value
        t_kecamatan.Text = DataGridKTP.Item(7, DataGridKTP.CurrentRow.Index).Value
        t_kota.Text = DataGridKTP.Item(8, DataGridKTP.CurrentRow.Index).Value
        t_berlaku.Text = DataGridKTP.Item(12, DataGridKTP.CurrentRow.Index).Value
        cmb_jk.Text = convertBack_JK(DataGridKTP.Item(2, DataGridKTP.CurrentRow.Index).Value)
        cmb_skawin.Text = convertBack_SK(DataGridKTP.Item(3, DataGridKTP.CurrentRow.Index).Value)
        cmb_agama.Text = DataGridKTP.Item(9, DataGridKTP.CurrentRow.Index).Value
        cmb_goldar.Text = DataGridKTP.Item(10, DataGridKTP.CurrentRow.Index).Value
        cmb_kwn.Text = DataGridKTP.Item(11, DataGridKTP.CurrentRow.Index).Value

        btn_ubah.Enabled = True
        btn_hapus.Enabled = True
    End Sub

    Private Sub DataGridKTP_Click(sender As Object, e As EventArgs) Handles DataGridKTP.Click
        'MEMECAH DATA RT RW
        Dim rtrw As String = DataGridKTP.Item(5, DataGridKTP.CurrentRow.Index).Value
        Dim rt, rw As String
        Dim rtrwSplit() As String
        rtrwSplit = rtrw.Split("/")
        rt = rtrwSplit(0) 'value RT
        rw = rtrwSplit(1) 'value RW

        'PARSING DATA DARI DATA GRID KE TEXT BOX & COMBO
        t_noktp.Text = DataGridKTP.Item(0, DataGridKTP.CurrentRow.Index).Value
        t_namalengkap.Text = DataGridKTP.Item(1, DataGridKTP.CurrentRow.Index).Value
        t_alamat.Text = DataGridKTP.Item(4, DataGridKTP.CurrentRow.Index).Value
        t_rt.Text = rt
        t_rw.Text = rw
        t_desa.Text = DataGridKTP.Item(6, DataGridKTP.CurrentRow.Index).Value
        t_kecamatan.Text = DataGridKTP.Item(7, DataGridKTP.CurrentRow.Index).Value
        t_kota.Text = DataGridKTP.Item(8, DataGridKTP.CurrentRow.Index).Value
        t_berlaku.Text = DataGridKTP.Item(12, DataGridKTP.CurrentRow.Index).Value
        cmb_jk.Text = convertBack_JK(DataGridKTP.Item(2, DataGridKTP.CurrentRow.Index).Value)
        cmb_skawin.Text = convertBack_SK(DataGridKTP.Item(3, DataGridKTP.CurrentRow.Index).Value)
        cmb_agama.Text = DataGridKTP.Item(9, DataGridKTP.CurrentRow.Index).Value
        cmb_goldar.Text = DataGridKTP.Item(10, DataGridKTP.CurrentRow.Index).Value
        cmb_kwn.Text = DataGridKTP.Item(11, DataGridKTP.CurrentRow.Index).Value

        btn_ubah.Enabled = True
        btn_hapus.Enabled = True
    End Sub



    '*START
    '*DISABLE KEYPRESS ON COMBOBOX
    '*==============================*\
    Private Sub cmb_jk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_jk.KeyPress
        If Asc(e.KeyChar) >= 13 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmb_skawin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_skawin.KeyPress
        If Asc(e.KeyChar) >= 13 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmb_agama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_agama.KeyPress
        If Asc(e.KeyChar) >= 13 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmb_goldar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_goldar.KeyPress
        If Asc(e.KeyChar) >= 13 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmb_kwn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_kwn.KeyPress
        If Asc(e.KeyChar) >= 13 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

End Class