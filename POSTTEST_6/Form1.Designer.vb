<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TxtCari = New TextBox()
        DgvLapangan = New DataGridView()
        BtnReset = New Button()
        BtnUbah = New Button()
        BtnHapus = New Button()
        BtnSimpan = New Button()
        CmbAC = New ComboBox()
        CmbStatus = New ComboBox()
        CmbLokasi = New ComboBox()
        TxtHargaLapangan = New TextBox()
        TxtNama = New TextBox()
        TxtIdLapangan = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        TxtHarga = New TextBox()
        TxtID = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        BtnResetTransaksi = New Button()
        TxtTotalBayar = New TextBox()
        Label11 = New Label()
        DtpTanggal = New DateTimePicker()
        TxtCariTransaksi = New TextBox()
        DgvTransaksi = New DataGridView()
        BtnCetakTransaksi = New Button()
        BtnUbahTransaksi = New Button()
        BtnHapusTransaksi = New Button()
        BtnSimpanTransaksi = New Button()
        CmbLapangan = New ComboBox()
        TxtDurasi = New TextBox()
        TxtNamaPelanggan = New TextBox()
        TxtIdTransaksi = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DgvLapangan, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(DgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-3, 55)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(877, 507)
        TabControl1.TabIndex = 20
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.PaleTurquoise
        TabPage1.Controls.Add(TxtCari)
        TabPage1.Controls.Add(DgvLapangan)
        TabPage1.Controls.Add(BtnReset)
        TabPage1.Controls.Add(BtnUbah)
        TabPage1.Controls.Add(BtnHapus)
        TabPage1.Controls.Add(BtnSimpan)
        TabPage1.Controls.Add(CmbAC)
        TabPage1.Controls.Add(CmbStatus)
        TabPage1.Controls.Add(CmbLokasi)
        TabPage1.Controls.Add(TxtHargaLapangan)
        TabPage1.Controls.Add(TxtNama)
        TabPage1.Controls.Add(TxtIdLapangan)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(TxtHarga)
        TabPage1.Controls.Add(TxtID)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(869, 479)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Kelola Lapangan"
        ' 
        ' TxtCari
        ' 
        TxtCari.Location = New Point(69, 267)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari Lapangan"
        TxtCari.Size = New Size(662, 23)
        TxtCari.TabIndex = 56
        ' 
        ' DgvLapangan
        ' 
        DgvLapangan.BackgroundColor = SystemColors.ActiveCaption
        DgvLapangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvLapangan.Location = New Point(69, 296)
        DgvLapangan.Name = "DgvLapangan"
        DgvLapangan.Size = New Size(662, 150)
        DgvLapangan.TabIndex = 55
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = SystemColors.ActiveCaption
        BtnReset.Location = New Point(630, 201)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(101, 37)
        BtnReset.TabIndex = 54
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = SystemColors.ActiveCaption
        BtnUbah.Location = New Point(268, 201)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(101, 37)
        BtnUbah.TabIndex = 53
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = SystemColors.ActiveCaption
        BtnHapus.Location = New Point(431, 201)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(101, 37)
        BtnHapus.TabIndex = 52
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = SystemColors.ActiveCaption
        BtnSimpan.Location = New Point(69, 201)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(101, 37)
        BtnSimpan.TabIndex = 51
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' CmbAC
        ' 
        CmbAC.FormattingEnabled = True
        CmbAC.Location = New Point(431, 157)
        CmbAC.Name = "CmbAC"
        CmbAC.Size = New Size(300, 23)
        CmbAC.TabIndex = 50
        ' 
        ' CmbStatus
        ' 
        CmbStatus.FormattingEnabled = True
        CmbStatus.Location = New Point(431, 83)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(300, 23)
        CmbStatus.TabIndex = 49
        ' 
        ' CmbLokasi
        ' 
        CmbLokasi.FormattingEnabled = True
        CmbLokasi.Location = New Point(69, 156)
        CmbLokasi.Name = "CmbLokasi"
        CmbLokasi.Size = New Size(300, 23)
        CmbLokasi.TabIndex = 48
        ' 
        ' TxtHargaLapangan
        ' 
        TxtHargaLapangan.Location = New Point(431, 24)
        TxtHargaLapangan.Name = "TxtHargaLapangan"
        TxtHargaLapangan.Size = New Size(300, 23)
        TxtHargaLapangan.TabIndex = 47
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(69, 83)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(300, 23)
        TxtNama.TabIndex = 46
        ' 
        ' TxtIdLapangan
        ' 
        TxtIdLapangan.Location = New Point(69, 24)
        TxtIdLapangan.Name = "TxtIdLapangan"
        TxtIdLapangan.Size = New Size(300, 23)
        TxtIdLapangan.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(384, 161)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 15)
        Label6.TabIndex = 44
        Label6.Text = "AC"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(384, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 43
        Label5.Text = "Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(384, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 42
        Label3.Text = "Harga"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(22, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 15)
        Label8.TabIndex = 41
        Label8.Text = "Lokasi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(22, 83)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 40
        Label9.Text = "Nama"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(22, 27)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 15)
        Label10.TabIndex = 39
        Label10.Text = "ID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(53, -157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 64)
        Panel1.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(53, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(695, 27)
        Label7.TabIndex = 0
        Label7.Text = "KICK-OFF Manager: Sistem Kendali Inventaris dan Status Lapangan Futsal."
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(475, -87)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(300, 23)
        TxtHarga.TabIndex = 28
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(139, -69)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(300, 23)
        TxtID.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(454, -66)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 23
        Label4.Text = "Harga"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, -66)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 20
        Label1.Text = "ID"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.PaleTurquoise
        TabPage2.Controls.Add(BtnResetTransaksi)
        TabPage2.Controls.Add(TxtTotalBayar)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(DtpTanggal)
        TabPage2.Controls.Add(TxtCariTransaksi)
        TabPage2.Controls.Add(DgvTransaksi)
        TabPage2.Controls.Add(BtnCetakTransaksi)
        TabPage2.Controls.Add(BtnUbahTransaksi)
        TabPage2.Controls.Add(BtnHapusTransaksi)
        TabPage2.Controls.Add(BtnSimpanTransaksi)
        TabPage2.Controls.Add(CmbLapangan)
        TabPage2.Controls.Add(TxtDurasi)
        TabPage2.Controls.Add(TxtNamaPelanggan)
        TabPage2.Controls.Add(TxtIdTransaksi)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label16)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(854, 469)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kelola Transaksi"
        ' 
        ' BtnResetTransaksi
        ' 
        BtnResetTransaksi.BackColor = SystemColors.ActiveCaption
        BtnResetTransaksi.Location = New Point(627, 232)
        BtnResetTransaksi.Name = "BtnResetTransaksi"
        BtnResetTransaksi.Size = New Size(101, 37)
        BtnResetTransaksi.TabIndex = 78
        BtnResetTransaksi.Text = "Reset"
        BtnResetTransaksi.UseVisualStyleBackColor = False
        ' 
        ' TxtTotalBayar
        ' 
        TxtTotalBayar.Location = New Point(462, 188)
        TxtTotalBayar.Name = "TxtTotalBayar"
        TxtTotalBayar.Size = New Size(300, 23)
        TxtTotalBayar.TabIndex = 77
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(403, 191)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 15)
        Label11.TabIndex = 76
        Label11.Text = "Total"
        ' 
        ' DtpTanggal
        ' 
        DtpTanggal.Location = New Point(460, 85)
        DtpTanggal.Name = "DtpTanggal"
        DtpTanggal.Size = New Size(300, 23)
        DtpTanggal.TabIndex = 75
        ' 
        ' TxtCariTransaksi
        ' 
        TxtCariTransaksi.Location = New Point(66, 282)
        TxtCariTransaksi.Name = "TxtCariTransaksi"
        TxtCariTransaksi.PlaceholderText = "Cari Transaksi"
        TxtCariTransaksi.Size = New Size(662, 23)
        TxtCariTransaksi.TabIndex = 74
        ' 
        ' DgvTransaksi
        ' 
        DgvTransaksi.BackgroundColor = SystemColors.ActiveCaption
        DgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvTransaksi.Location = New Point(66, 311)
        DgvTransaksi.Name = "DgvTransaksi"
        DgvTransaksi.Size = New Size(662, 150)
        DgvTransaksi.TabIndex = 73
        ' 
        ' BtnCetakTransaksi
        ' 
        BtnCetakTransaksi.BackColor = SystemColors.ActiveCaption
        BtnCetakTransaksi.Location = New Point(747, 424)
        BtnCetakTransaksi.Name = "BtnCetakTransaksi"
        BtnCetakTransaksi.Size = New Size(101, 37)
        BtnCetakTransaksi.TabIndex = 72
        BtnCetakTransaksi.Text = "Cetak"
        BtnCetakTransaksi.UseVisualStyleBackColor = False
        ' 
        ' BtnUbahTransaksi
        ' 
        BtnUbahTransaksi.BackColor = SystemColors.ActiveCaption
        BtnUbahTransaksi.Location = New Point(240, 232)
        BtnUbahTransaksi.Name = "BtnUbahTransaksi"
        BtnUbahTransaksi.Size = New Size(101, 37)
        BtnUbahTransaksi.TabIndex = 71
        BtnUbahTransaksi.Text = "Ubah"
        BtnUbahTransaksi.UseVisualStyleBackColor = False
        ' 
        ' BtnHapusTransaksi
        ' 
        BtnHapusTransaksi.BackColor = SystemColors.ActiveCaption
        BtnHapusTransaksi.Location = New Point(435, 232)
        BtnHapusTransaksi.Name = "BtnHapusTransaksi"
        BtnHapusTransaksi.Size = New Size(101, 37)
        BtnHapusTransaksi.TabIndex = 70
        BtnHapusTransaksi.Text = "Hapus"
        BtnHapusTransaksi.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpanTransaksi
        ' 
        BtnSimpanTransaksi.BackColor = SystemColors.ActiveCaption
        BtnSimpanTransaksi.Location = New Point(66, 232)
        BtnSimpanTransaksi.Name = "BtnSimpanTransaksi"
        BtnSimpanTransaksi.Size = New Size(101, 37)
        BtnSimpanTransaksi.TabIndex = 69
        BtnSimpanTransaksi.Text = "Simpan"
        BtnSimpanTransaksi.UseVisualStyleBackColor = False
        ' 
        ' CmbLapangan
        ' 
        CmbLapangan.FormattingEnabled = True
        CmbLapangan.Location = New Point(81, 148)
        CmbLapangan.Name = "CmbLapangan"
        CmbLapangan.Size = New Size(300, 23)
        CmbLapangan.TabIndex = 66
        ' 
        ' TxtDurasi
        ' 
        TxtDurasi.Location = New Point(460, 26)
        TxtDurasi.Name = "TxtDurasi"
        TxtDurasi.Size = New Size(300, 23)
        TxtDurasi.TabIndex = 65
        ' 
        ' TxtNamaPelanggan
        ' 
        TxtNamaPelanggan.Location = New Point(81, 85)
        TxtNamaPelanggan.Name = "TxtNamaPelanggan"
        TxtNamaPelanggan.Size = New Size(300, 23)
        TxtNamaPelanggan.TabIndex = 64
        ' 
        ' TxtIdTransaksi
        ' 
        TxtIdTransaksi.Location = New Point(81, 26)
        TxtIdTransaksi.Name = "TxtIdTransaksi"
        TxtIdTransaksi.Size = New Size(300, 23)
        TxtIdTransaksi.TabIndex = 63
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(395, 88)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 15)
        Label12.TabIndex = 61
        Label12.Text = "Tanggal"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(395, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(40, 15)
        Label13.TabIndex = 60
        Label13.Text = "Durasi"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(19, 151)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 59
        Label14.Text = "Lapangan"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(19, 88)
        Label15.Name = "Label15"
        Label15.Size = New Size(39, 15)
        Label15.TabIndex = 58
        Label15.Text = "Nama"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(19, 29)
        Label16.Name = "Label16"
        Label16.Size = New Size(18, 15)
        Label16.TabIndex = 57
        Label16.Text = "ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(-6, -5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1115, 64)
        Panel2.TabIndex = 58
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(81, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(695, 27)
        Label2.TabIndex = 0
        Label2.Text = "KICK-OFF Manager: Sistem Kendali Inventaris dan Status Lapangan Futsal."
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(908, 574)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DgvLapangan, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents DgvLapangan As DataGridView
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents CmbAC As ComboBox
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents CmbLokasi As ComboBox
    Friend WithEvents TxtHargaLapangan As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtIdLapangan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCariTransaksi As TextBox
    Friend WithEvents DgvTransaksi As DataGridView
    Friend WithEvents BtnCetakTransaksi As Button
    Friend WithEvents BtnUbahTransaksi As Button
    Friend WithEvents BtnHapusTransaksi As Button
    Friend WithEvents BtnSimpanTransaksi As Button
    Friend WithEvents CmbLapangan As ComboBox
    Friend WithEvents TxtDurasi As TextBox
    Friend WithEvents TxtNamaPelanggan As TextBox
    Friend WithEvents TxtIdTransaksi As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents TxtTotalBayar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnResetTransaksi As Button

End Class
