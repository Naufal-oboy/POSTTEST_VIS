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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TpData = New TabPage()
        PictureBox4 = New PictureBox()
        CmbGenre = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        RbPerempuan = New RadioButton()
        RbLaki = New RadioButton()
        DtpLahir = New DateTimePicker()
        Label4 = New Label()
        TxtId = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TxtNama = New TextBox()
        TpKontak = New TabPage()
        PictureBox3 = New PictureBox()
        TxtAlamat = New TextBox()
        Label10 = New Label()
        TxtEmail = New TextBox()
        MtxtNoTelp = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TpProfil = New TabPage()
        BtnSimpan = New Button()
        GbAktivitas = New GroupBox()
        CbModding = New CheckBox()
        CbCoaching = New CheckBox()
        CbTheorycrafting = New CheckBox()
        CbPhotography = New CheckBox()
        CbGameTheory = New CheckBox()
        CbSpeed = New CheckBox()
        CbLive = New CheckBox()
        CbKompetitif = New CheckBox()
        GbRole = New GroupBox()
        RbAdmin = New RadioButton()
        RbCoach = New RadioButton()
        RbProPlayer = New RadioButton()
        RbAnggota = New RadioButton()
        RbKetua = New RadioButton()
        BtnBrowse = New Button()
        PbProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TpData.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TpKontak.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TpProfil.SuspendLayout()
        GbAktivitas.SuspendLayout()
        GbRole.SuspendLayout()
        CType(PbProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Logo_komunitas_Gamer_Nexus_futuristik
        PictureBox1.Location = New Point(-35, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(202, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(120, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 30)
        Label1.TabIndex = 2
        Label1.Text = "GAMER NEXUS COMMUNITY"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SteelBlue
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(603, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(76, 20)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(86, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(72, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpData)
        TabControl1.Controls.Add(TpKontak)
        TabControl1.Controls.Add(TpProfil)
        TabControl1.Location = New Point(12, 88)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(577, 356)
        TabControl1.TabIndex = 4
        ' 
        ' TpData
        ' 
        TpData.BackColor = Color.SteelBlue
        TpData.Controls.Add(PictureBox4)
        TpData.Controls.Add(CmbGenre)
        TpData.Controls.Add(Label6)
        TpData.Controls.Add(Label5)
        TpData.Controls.Add(RbPerempuan)
        TpData.Controls.Add(RbLaki)
        TpData.Controls.Add(DtpLahir)
        TpData.Controls.Add(Label4)
        TpData.Controls.Add(TxtId)
        TpData.Controls.Add(Label3)
        TpData.Controls.Add(Label2)
        TpData.Controls.Add(TxtNama)
        TpData.Location = New Point(4, 24)
        TpData.Name = "TpData"
        TpData.Padding = New Padding(3)
        TpData.Size = New Size(569, 328)
        TpData.TabIndex = 0
        TpData.Text = "Data Utama"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.Logo_komunitas_Gamer_Nexus_futuristik
        PictureBox4.Location = New Point(464, 263)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(109, 65)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' CmbGenre
        ' 
        CmbGenre.FormattingEnabled = True
        CmbGenre.Items.AddRange(New Object() {"MOBA", "Battle Royale", "FPS", "RPG", "Fighting"})
        CmbGenre.Location = New Point(136, 185)
        CmbGenre.Name = "CmbGenre"
        CmbGenre.Size = New Size(220, 23)
        CmbGenre.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label6.Location = New Point(21, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 19)
        Label6.TabIndex = 9
        Label6.Text = "Genre Game"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label5.Location = New Point(21, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 19)
        Label5.TabIndex = 8
        Label5.Text = "Jenis Kelamin"
        ' 
        ' RbPerempuan
        ' 
        RbPerempuan.AutoSize = True
        RbPerempuan.Location = New Point(136, 159)
        RbPerempuan.Name = "RbPerempuan"
        RbPerempuan.Size = New Size(86, 19)
        RbPerempuan.TabIndex = 7
        RbPerempuan.TabStop = True
        RbPerempuan.Text = "Perempuan"
        RbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RbLaki
        ' 
        RbLaki.AutoSize = True
        RbLaki.Location = New Point(136, 134)
        RbLaki.Name = "RbLaki"
        RbLaki.Size = New Size(72, 19)
        RbLaki.TabIndex = 6
        RbLaki.TabStop = True
        RbLaki.Text = "Laki-Laki"
        RbLaki.UseVisualStyleBackColor = True
        ' 
        ' DtpLahir
        ' 
        DtpLahir.Location = New Point(136, 95)
        DtpLahir.Name = "DtpLahir"
        DtpLahir.Size = New Size(220, 23)
        DtpLahir.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label4.Location = New Point(21, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 19)
        Label4.TabIndex = 4
        Label4.Text = "Tanggal Lahir"
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(136, 56)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(220, 23)
        TxtId.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.Location = New Point(21, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 19)
        Label3.TabIndex = 2
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.Location = New Point(21, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 19)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(136, 20)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(220, 23)
        TxtNama.TabIndex = 0
        ' 
        ' TpKontak
        ' 
        TpKontak.BackColor = Color.SteelBlue
        TpKontak.Controls.Add(PictureBox3)
        TpKontak.Controls.Add(TxtAlamat)
        TpKontak.Controls.Add(Label10)
        TpKontak.Controls.Add(TxtEmail)
        TpKontak.Controls.Add(MtxtNoTelp)
        TpKontak.Controls.Add(Label9)
        TpKontak.Controls.Add(Label8)
        TpKontak.Controls.Add(Label7)
        TpKontak.ForeColor = SystemColors.Control
        TpKontak.Location = New Point(4, 24)
        TpKontak.Name = "TpKontak"
        TpKontak.Padding = New Padding(3)
        TpKontak.Size = New Size(569, 328)
        TpKontak.TabIndex = 1
        TpKontak.Text = " Kontak & Info"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.Logo_komunitas_Gamer_Nexus_futuristik
        PictureBox3.Location = New Point(464, 263)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(109, 65)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(154, 114)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(220, 55)
        TxtAlamat.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ControlText
        Label10.Location = New Point(261, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 19)
        Label10.TabIndex = 7
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(154, 68)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(220, 23)
        TxtEmail.TabIndex = 6
        ' 
        ' MtxtNoTelp
        ' 
        MtxtNoTelp.Location = New Point(154, 28)
        MtxtNoTelp.Mask = "0000-0000-0000"
        MtxtNoTelp.Name = "MtxtNoTelp"
        MtxtNoTelp.Size = New Size(220, 23)
        MtxtNoTelp.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AllowDrop = True
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ControlText
        Label9.Location = New Point(21, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 19)
        Label9.TabIndex = 4
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(21, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 19)
        Label8.TabIndex = 3
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(21, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 19)
        Label7.TabIndex = 2
        Label7.Text = "Nomor Telepon"
        ' 
        ' TpProfil
        ' 
        TpProfil.BackColor = Color.SteelBlue
        TpProfil.Controls.Add(BtnSimpan)
        TpProfil.Controls.Add(GbAktivitas)
        TpProfil.Controls.Add(GbRole)
        TpProfil.Controls.Add(BtnBrowse)
        TpProfil.Controls.Add(PbProfil)
        TpProfil.Location = New Point(4, 24)
        TpProfil.Name = "TpProfil"
        TpProfil.Padding = New Padding(3)
        TpProfil.Size = New Size(569, 328)
        TpProfil.TabIndex = 2
        TpProfil.Text = "Profil & Aktivitas"
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(201, 278)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(309, 31)
        BtnSimpan.TabIndex = 7
        BtnSimpan.Text = "Simpan dan Cetak Kartu"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GbAktivitas
        ' 
        GbAktivitas.BackColor = SystemColors.ControlLightLight
        GbAktivitas.Controls.Add(CbModding)
        GbAktivitas.Controls.Add(CbCoaching)
        GbAktivitas.Controls.Add(CbTheorycrafting)
        GbAktivitas.Controls.Add(CbPhotography)
        GbAktivitas.Controls.Add(CbGameTheory)
        GbAktivitas.Controls.Add(CbSpeed)
        GbAktivitas.Controls.Add(CbLive)
        GbAktivitas.Controls.Add(CbKompetitif)
        GbAktivitas.Location = New Point(174, 135)
        GbAktivitas.Name = "GbAktivitas"
        GbAktivitas.Size = New Size(348, 127)
        GbAktivitas.TabIndex = 6
        GbAktivitas.TabStop = False
        GbAktivitas.Text = "Aktivitas"
        ' 
        ' CbModding
        ' 
        CbModding.AutoSize = True
        CbModding.Location = New Point(184, 101)
        CbModding.Name = "CbModding"
        CbModding.Size = New Size(132, 19)
        CbModding.TabIndex = 12
        CbModding.Text = "Modding Enthusiast"
        CbModding.UseVisualStyleBackColor = True
        ' 
        ' CbCoaching
        ' 
        CbCoaching.AutoSize = True
        CbCoaching.Location = New Point(184, 76)
        CbCoaching.Name = "CbCoaching"
        CbCoaching.Size = New Size(159, 19)
        CbCoaching.TabIndex = 11
        CbCoaching.Text = "Coaching dan Mentoring"
        CbCoaching.UseVisualStyleBackColor = True
        ' 
        ' CbTheorycrafting
        ' 
        CbTheorycrafting.AutoSize = True
        CbTheorycrafting.Location = New Point(184, 47)
        CbTheorycrafting.Name = "CbTheorycrafting"
        CbTheorycrafting.Size = New Size(103, 19)
        CbTheorycrafting.TabIndex = 10
        CbTheorycrafting.Text = "Theorycrafting"
        CbTheorycrafting.UseVisualStyleBackColor = True
        ' 
        ' CbPhotography
        ' 
        CbPhotography.AutoSize = True
        CbPhotography.Location = New Point(184, 22)
        CbPhotography.Name = "CbPhotography"
        CbPhotography.Size = New Size(142, 19)
        CbPhotography.TabIndex = 9
        CbPhotography.Text = "In Game Photography"
        CbPhotography.UseVisualStyleBackColor = True
        ' 
        ' CbGameTheory
        ' 
        CbGameTheory.AutoSize = True
        CbGameTheory.Location = New Point(39, 101)
        CbGameTheory.Name = "CbGameTheory"
        CbGameTheory.Size = New Size(96, 19)
        CbGameTheory.TabIndex = 8
        CbGameTheory.Text = "Game Theory"
        CbGameTheory.UseVisualStyleBackColor = True
        ' 
        ' CbSpeed
        ' 
        CbSpeed.AutoSize = True
        CbSpeed.Location = New Point(39, 76)
        CbSpeed.Name = "CbSpeed"
        CbSpeed.Size = New Size(96, 19)
        CbSpeed.TabIndex = 7
        CbSpeed.Text = "SpeedRunner"
        CbSpeed.UseVisualStyleBackColor = True
        ' 
        ' CbLive
        ' 
        CbLive.AutoSize = True
        CbLive.Location = New Point(39, 47)
        CbLive.Name = "CbLive"
        CbLive.Size = New Size(104, 19)
        CbLive.TabIndex = 6
        CbLive.Text = "Live Streaming"
        CbLive.UseVisualStyleBackColor = True
        ' 
        ' CbKompetitif
        ' 
        CbKompetitif.AutoSize = True
        CbKompetitif.Location = New Point(39, 22)
        CbKompetitif.Name = "CbKompetitif"
        CbKompetitif.Size = New Size(139, 19)
        CbKompetitif.TabIndex = 5
        CbKompetitif.Text = "Kompetitif Turnamen"
        CbKompetitif.UseVisualStyleBackColor = True
        ' 
        ' GbRole
        ' 
        GbRole.BackColor = SystemColors.ControlLightLight
        GbRole.Controls.Add(RbAdmin)
        GbRole.Controls.Add(RbCoach)
        GbRole.Controls.Add(RbProPlayer)
        GbRole.Controls.Add(RbAnggota)
        GbRole.Controls.Add(RbKetua)
        GbRole.Location = New Point(174, 17)
        GbRole.Name = "GbRole"
        GbRole.Size = New Size(348, 112)
        GbRole.TabIndex = 2
        GbRole.TabStop = False
        GbRole.Text = "Role"
        ' 
        ' RbAdmin
        ' 
        RbAdmin.AutoSize = True
        RbAdmin.Location = New Point(136, 47)
        RbAdmin.Name = "RbAdmin"
        RbAdmin.Size = New Size(61, 19)
        RbAdmin.TabIndex = 4
        RbAdmin.TabStop = True
        RbAdmin.Text = "Admin"
        RbAdmin.UseVisualStyleBackColor = True
        ' 
        ' RbCoach
        ' 
        RbCoach.AutoSize = True
        RbCoach.Location = New Point(136, 22)
        RbCoach.Name = "RbCoach"
        RbCoach.Size = New Size(59, 19)
        RbCoach.TabIndex = 3
        RbCoach.TabStop = True
        RbCoach.Text = "Coach"
        RbCoach.UseVisualStyleBackColor = True
        ' 
        ' RbProPlayer
        ' 
        RbProPlayer.AutoSize = True
        RbProPlayer.Location = New Point(39, 72)
        RbProPlayer.Name = "RbProPlayer"
        RbProPlayer.Size = New Size(78, 19)
        RbProPlayer.TabIndex = 2
        RbProPlayer.TabStop = True
        RbProPlayer.Text = "Pro Player"
        RbProPlayer.UseVisualStyleBackColor = True
        ' 
        ' RbAnggota
        ' 
        RbAnggota.AutoSize = True
        RbAnggota.Location = New Point(39, 47)
        RbAnggota.Name = "RbAnggota"
        RbAnggota.Size = New Size(71, 19)
        RbAnggota.TabIndex = 1
        RbAnggota.TabStop = True
        RbAnggota.Text = "Anggota"
        RbAnggota.UseVisualStyleBackColor = True
        ' 
        ' RbKetua
        ' 
        RbKetua.AutoSize = True
        RbKetua.Location = New Point(39, 22)
        RbKetua.Name = "RbKetua"
        RbKetua.Size = New Size(55, 19)
        RbKetua.TabIndex = 0
        RbKetua.TabStop = True
        RbKetua.Text = "Ketua"
        RbKetua.UseVisualStyleBackColor = True
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.Location = New Point(48, 250)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(99, 27)
        BtnBrowse.TabIndex = 1
        BtnBrowse.Text = "Browse"
        BtnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PbProfil
        ' 
        PbProfil.BackColor = SystemColors.ControlLightLight
        PbProfil.Location = New Point(15, 17)
        PbProfil.Name = "PbProfil"
        PbProfil.Size = New Size(153, 227)
        PbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        PbProfil.TabIndex = 0
        PbProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(603, 456)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TpData.ResumeLayout(False)
        TpData.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TpKontak.ResumeLayout(False)
        TpKontak.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TpProfil.ResumeLayout(False)
        GbAktivitas.ResumeLayout(False)
        GbAktivitas.PerformLayout()
        GbRole.ResumeLayout(False)
        GbRole.PerformLayout()
        CType(PbProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpData As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TpKontak As TabPage
    Friend WithEvents TpProfil As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RbPerempuan As RadioButton
    Friend WithEvents RbLaki As RadioButton
    Friend WithEvents DtpLahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CmbGenre As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents MtxtNoTelp As MaskedTextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents PbProfil As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GbRole As GroupBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RbAdmin As RadioButton
    Friend WithEvents RbCoach As RadioButton
    Friend WithEvents RbProPlayer As RadioButton
    Friend WithEvents RbAnggota As RadioButton
    Friend WithEvents RbKetua As RadioButton
    Friend WithEvents GbAktivitas As GroupBox
    Friend WithEvents CbGameTheory As CheckBox
    Friend WithEvents CbSpeed As CheckBox
    Friend WithEvents CbLive As CheckBox
    Friend WithEvents CbKompetitif As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents CbModding As CheckBox
    Friend WithEvents CbCoaching As CheckBox
    Friend WithEvents CbTheorycrafting As CheckBox
    Friend WithEvents CbPhotography As CheckBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
