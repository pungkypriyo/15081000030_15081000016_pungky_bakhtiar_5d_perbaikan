<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataKTP
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
        Me.cmb_skawin = New System.Windows.Forms.ComboBox()
        Me.t_noktp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.t_namalengkap = New System.Windows.Forms.TextBox()
        Me.cmb_jk = New System.Windows.Forms.ComboBox()
        Me.t_alamat = New System.Windows.Forms.TextBox()
        Me.t_desa = New System.Windows.Forms.TextBox()
        Me.t_kecamatan = New System.Windows.Forms.TextBox()
        Me.t_kota = New System.Windows.Forms.TextBox()
        Me.cmb_agama = New System.Windows.Forms.ComboBox()
        Me.cmb_goldar = New System.Windows.Forms.ComboBox()
        Me.cmb_kwn = New System.Windows.Forms.ComboBox()
        Me.DataGridKTP = New System.Windows.Forms.DataGridView()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_baru = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.t_rt = New System.Windows.Forms.TextBox()
        Me.t_rw = New System.Windows.Forms.TextBox()
        Me.t_berlaku = New System.Windows.Forms.TextBox()
        CType(Me.DataGridKTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_skawin
        '
        Me.cmb_skawin.FormattingEnabled = True
        Me.cmb_skawin.Location = New System.Drawing.Point(164, 105)
        Me.cmb_skawin.Name = "cmb_skawin"
        Me.cmb_skawin.Size = New System.Drawing.Size(142, 21)
        Me.cmb_skawin.TabIndex = 17
        '
        't_noktp
        '
        Me.t_noktp.Location = New System.Drawing.Point(164, 25)
        Me.t_noktp.MaxLength = 16
        Me.t_noktp.Name = "t_noktp"
        Me.t_noktp.Size = New System.Drawing.Size(181, 20)
        Me.t_noktp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. KTP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Lengkap:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Kelamin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Status Perkawinan:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "RT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "RW:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Kelurahan/Desa:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(69, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Kecamatan:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Kota/Kabupaten:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(101, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 21)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Agama:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(74, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 21)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Gol. Darah:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 21)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Kewarganegaraan:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 21)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Berlaku Hingga:"
        '
        't_namalengkap
        '
        Me.t_namalengkap.Location = New System.Drawing.Point(164, 51)
        Me.t_namalengkap.Name = "t_namalengkap"
        Me.t_namalengkap.Size = New System.Drawing.Size(332, 20)
        Me.t_namalengkap.TabIndex = 15
        '
        'cmb_jk
        '
        Me.cmb_jk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmb_jk.FormattingEnabled = True
        Me.cmb_jk.Location = New System.Drawing.Point(164, 78)
        Me.cmb_jk.Name = "cmb_jk"
        Me.cmb_jk.Size = New System.Drawing.Size(141, 21)
        Me.cmb_jk.TabIndex = 16
        '
        't_alamat
        '
        Me.t_alamat.Location = New System.Drawing.Point(164, 132)
        Me.t_alamat.Multiline = True
        Me.t_alamat.Name = "t_alamat"
        Me.t_alamat.Size = New System.Drawing.Size(332, 73)
        Me.t_alamat.TabIndex = 18
        '
        't_desa
        '
        Me.t_desa.Location = New System.Drawing.Point(164, 242)
        Me.t_desa.Name = "t_desa"
        Me.t_desa.Size = New System.Drawing.Size(167, 20)
        Me.t_desa.TabIndex = 21
        '
        't_kecamatan
        '
        Me.t_kecamatan.Location = New System.Drawing.Point(164, 268)
        Me.t_kecamatan.Name = "t_kecamatan"
        Me.t_kecamatan.Size = New System.Drawing.Size(167, 20)
        Me.t_kecamatan.TabIndex = 22
        '
        't_kota
        '
        Me.t_kota.Location = New System.Drawing.Point(164, 294)
        Me.t_kota.Name = "t_kota"
        Me.t_kota.Size = New System.Drawing.Size(167, 20)
        Me.t_kota.TabIndex = 23
        '
        'cmb_agama
        '
        Me.cmb_agama.FormattingEnabled = True
        Me.cmb_agama.Location = New System.Drawing.Point(164, 320)
        Me.cmb_agama.Name = "cmb_agama"
        Me.cmb_agama.Size = New System.Drawing.Size(135, 21)
        Me.cmb_agama.TabIndex = 24
        '
        'cmb_goldar
        '
        Me.cmb_goldar.FormattingEnabled = True
        Me.cmb_goldar.Location = New System.Drawing.Point(164, 347)
        Me.cmb_goldar.Name = "cmb_goldar"
        Me.cmb_goldar.Size = New System.Drawing.Size(135, 21)
        Me.cmb_goldar.TabIndex = 25
        '
        'cmb_kwn
        '
        Me.cmb_kwn.FormattingEnabled = True
        Me.cmb_kwn.Location = New System.Drawing.Point(164, 374)
        Me.cmb_kwn.Name = "cmb_kwn"
        Me.cmb_kwn.Size = New System.Drawing.Size(135, 21)
        Me.cmb_kwn.TabIndex = 26
        '
        'DataGridKTP
        '
        Me.DataGridKTP.AllowUserToAddRows = False
        Me.DataGridKTP.AllowUserToDeleteRows = False
        Me.DataGridKTP.AllowUserToOrderColumns = True
        Me.DataGridKTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKTP.Location = New System.Drawing.Point(9, 504)
        Me.DataGridKTP.Name = "DataGridKTP"
        Me.DataGridKTP.ReadOnly = True
        Me.DataGridKTP.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridKTP.Size = New System.Drawing.Size(752, 128)
        Me.DataGridKTP.TabIndex = 33
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_delete_50
        Me.btn_cancel.Location = New System.Drawing.Point(312, 434)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(142, 59)
        Me.btn_cancel.TabIndex = 36
        Me.btn_cancel.Text = "Batal"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_refresh
        Me.btn_refresh.Location = New System.Drawing.Point(605, 201)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(142, 59)
        Me.btn_refresh.TabIndex = 32
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_hapus.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_delete
        Me.btn_hapus.Location = New System.Drawing.Point(605, 142)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(142, 59)
        Me.btn_hapus.TabIndex = 31
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ubah.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_edit
        Me.btn_ubah.Location = New System.Drawing.Point(605, 83)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(142, 59)
        Me.btn_ubah.TabIndex = 30
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_baru
        '
        Me.btn_baru.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_baru.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_new_copy
        Me.btn_baru.Location = New System.Drawing.Point(605, 24)
        Me.btn_baru.Name = "btn_baru"
        Me.btn_baru.Size = New System.Drawing.Size(142, 59)
        Me.btn_baru.TabIndex = 29
        Me.btn_baru.Text = "Baru"
        Me.btn_baru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_baru.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = Global.KoneksiDatabase.My.Resources.Resources.icons8_save
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(164, 434)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(142, 59)
        Me.btn_save.TabIndex = 28
        Me.btn_save.Text = "Simpan"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(312, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 17)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "*Pilih Jenis Kelamin"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(312, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 17)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "*Pilih Status Perkawinan"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(305, 322)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "*Pilih Agama"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(305, 349)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 17)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "*Pilih Golongan Darah"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(305, 376)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "*Pilih Kewarganegaraan"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(395, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 17)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "*ex:  001 ( Tiga Digit )"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(197, 215)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 17)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "*ex:  001 ( Tiga Digit )"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_rt
        '
        Me.t_rt.Location = New System.Drawing.Point(164, 213)
        Me.t_rt.MaxLength = 3
        Me.t_rt.Name = "t_rt"
        Me.t_rt.Size = New System.Drawing.Size(30, 20)
        Me.t_rt.TabIndex = 45
        '
        't_rw
        '
        Me.t_rw.Location = New System.Drawing.Point(361, 213)
        Me.t_rw.MaxLength = 3
        Me.t_rw.Name = "t_rw"
        Me.t_rw.Size = New System.Drawing.Size(30, 20)
        Me.t_rw.TabIndex = 46
        '
        't_berlaku
        '
        Me.t_berlaku.Location = New System.Drawing.Point(164, 400)
        Me.t_berlaku.Name = "t_berlaku"
        Me.t_berlaku.Size = New System.Drawing.Size(135, 20)
        Me.t_berlaku.TabIndex = 47
        '
        'FormDataKTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 644)
        Me.Controls.Add(Me.t_berlaku)
        Me.Controls.Add(Me.t_rw)
        Me.Controls.Add(Me.t_rt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.DataGridKTP)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_baru)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.t_noktp)
        Me.Controls.Add(Me.cmb_kwn)
        Me.Controls.Add(Me.cmb_goldar)
        Me.Controls.Add(Me.cmb_agama)
        Me.Controls.Add(Me.t_kota)
        Me.Controls.Add(Me.t_kecamatan)
        Me.Controls.Add(Me.t_desa)
        Me.Controls.Add(Me.t_alamat)
        Me.Controls.Add(Me.cmb_skawin)
        Me.Controls.Add(Me.cmb_jk)
        Me.Controls.Add(Me.t_namalengkap)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataKTP"
        Me.RightToLeftLayout = True
        Me.Text = "Form Data KTP"
        CType(Me.DataGridKTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t_noktp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents t_namalengkap As TextBox
    Friend WithEvents cmb_jk As ComboBox
    Friend WithEvents t_alamat As TextBox
    Friend WithEvents t_desa As TextBox
    Friend WithEvents t_kecamatan As TextBox
    Friend WithEvents t_kota As TextBox
    Friend WithEvents cmb_agama As ComboBox
    Friend WithEvents cmb_goldar As ComboBox
    Friend WithEvents cmb_kwn As ComboBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_baru As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents DataGridKTP As DataGridView
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents t_rt As TextBox
    Friend WithEvents t_rw As TextBox
    Friend WithEvents t_berlaku As TextBox
    Friend WithEvents cmb_skawin As ComboBox
End Class
