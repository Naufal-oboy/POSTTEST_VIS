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
        PicGambar = New PictureBox()
        BtnGambar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtNama = New TextBox()
        TxtTelepon = New TextBox()
        TxtUmur = New TextBox()
        TxtAlamat = New TextBox()
        GbJK = New GroupBox()
        RbCewek = New RadioButton()
        RbCowo = New RadioButton()
        DtpLahir = New DateTimePicker()
        GbHobi = New GroupBox()
        CbNulis = New CheckBox()
        CbGambar = New CheckBox()
        CbMusik = New CheckBox()
        CbOlahraga = New CheckBox()
        CbMasak = New CheckBox()
        CbMancing = New CheckBox()
        CbGame = New CheckBox()
        CbNgoding = New CheckBox()
        CbBerenang = New CheckBox()
        CbMembaca = New CheckBox()
        BtnCetak = New Button()
        Panel1 = New Panel()
        OpenFileDialog1 = New OpenFileDialog()
        Label6 = New Label()
        CType(PicGambar, ComponentModel.ISupportInitialize).BeginInit()
        GbJK.SuspendLayout()
        GbHobi.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicGambar
        ' 
        PicGambar.BackColor = Color.White
        PicGambar.Location = New Point(41, 106)
        PicGambar.Name = "PicGambar"
        PicGambar.Size = New Size(243, 329)
        PicGambar.TabIndex = 0
        PicGambar.TabStop = False
        ' 
        ' BtnGambar
        ' 
        BtnGambar.BackColor = SystemColors.ButtonFace
        BtnGambar.Location = New Point(95, 458)
        BtnGambar.Name = "BtnGambar"
        BtnGambar.Size = New Size(116, 43)
        BtnGambar.TabIndex = 1
        BtnGambar.Text = "Tambah Gambar"
        BtnGambar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(376, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(376, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(376, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 4
        Label3.Text = "NoTelp"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(376, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 5
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(376, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' TxtNama
        ' 
        TxtNama.BorderStyle = BorderStyle.FixedSingle
        TxtNama.Location = New Point(475, 106)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(282, 23)
        TxtNama.TabIndex = 7
        ' 
        ' TxtTelepon
        ' 
        TxtTelepon.BorderStyle = BorderStyle.FixedSingle
        TxtTelepon.Location = New Point(475, 164)
        TxtTelepon.Name = "TxtTelepon"
        TxtTelepon.Size = New Size(282, 23)
        TxtTelepon.TabIndex = 8
        ' 
        ' TxtUmur
        ' 
        TxtUmur.BorderStyle = BorderStyle.FixedSingle
        TxtUmur.Location = New Point(475, 135)
        TxtUmur.Name = "TxtUmur"
        TxtUmur.Size = New Size(282, 23)
        TxtUmur.TabIndex = 9
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.BorderStyle = BorderStyle.FixedSingle
        TxtAlamat.Location = New Point(475, 222)
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(282, 23)
        TxtAlamat.TabIndex = 10
        ' 
        ' GbJK
        ' 
        GbJK.Controls.Add(RbCewek)
        GbJK.Controls.Add(RbCowo)
        GbJK.Location = New Point(326, 273)
        GbJK.Name = "GbJK"
        GbJK.Size = New Size(310, 174)
        GbJK.TabIndex = 11
        GbJK.TabStop = False
        GbJK.Text = "Jenis Kelamin"
        ' 
        ' RbCewek
        ' 
        RbCewek.AutoSize = True
        RbCewek.Location = New Point(23, 77)
        RbCewek.Name = "RbCewek"
        RbCewek.Size = New Size(86, 19)
        RbCewek.TabIndex = 1
        RbCewek.TabStop = True
        RbCewek.Text = "Perempuan"
        RbCewek.UseVisualStyleBackColor = True
        ' 
        ' RbCowo
        ' 
        RbCowo.AutoSize = True
        RbCowo.Location = New Point(23, 35)
        RbCowo.Name = "RbCowo"
        RbCowo.Size = New Size(70, 19)
        RbCowo.TabIndex = 0
        RbCowo.TabStop = True
        RbCowo.Text = "Laki Laki"
        RbCowo.UseVisualStyleBackColor = True
        ' 
        ' DtpLahir
        ' 
        DtpLahir.Location = New Point(475, 193)
        DtpLahir.Name = "DtpLahir"
        DtpLahir.Size = New Size(282, 23)
        DtpLahir.TabIndex = 0
        ' 
        ' GbHobi
        ' 
        GbHobi.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        GbHobi.Controls.Add(CbNulis)
        GbHobi.Controls.Add(CbGambar)
        GbHobi.Controls.Add(CbMusik)
        GbHobi.Controls.Add(CbOlahraga)
        GbHobi.Controls.Add(CbMasak)
        GbHobi.Controls.Add(CbMancing)
        GbHobi.Controls.Add(CbGame)
        GbHobi.Controls.Add(CbNgoding)
        GbHobi.Controls.Add(CbBerenang)
        GbHobi.Controls.Add(CbMembaca)
        GbHobi.ForeColor = SystemColors.ControlText
        GbHobi.Location = New Point(653, 273)
        GbHobi.Name = "GbHobi"
        GbHobi.Size = New Size(346, 174)
        GbHobi.TabIndex = 12
        GbHobi.TabStop = False
        GbHobi.Text = "Hobi"
        ' 
        ' CbNulis
        ' 
        CbNulis.AutoSize = True
        CbNulis.Location = New Point(201, 131)
        CbNulis.Name = "CbNulis"
        CbNulis.Size = New Size(68, 19)
        CbNulis.TabIndex = 9
        CbNulis.Text = "Menulis"
        CbNulis.UseVisualStyleBackColor = True
        ' 
        ' CbGambar
        ' 
        CbGambar.AutoSize = True
        CbGambar.Location = New Point(201, 106)
        CbGambar.Name = "CbGambar"
        CbGambar.Size = New Size(98, 19)
        CbGambar.TabIndex = 8
        CbGambar.Text = "Menggambar"
        CbGambar.UseVisualStyleBackColor = True
        ' 
        ' CbMusik
        ' 
        CbMusik.AutoSize = True
        CbMusik.Location = New Point(201, 77)
        CbMusik.Name = "CbMusik"
        CbMusik.Size = New Size(141, 19)
        CbMusik.TabIndex = 7
        CbMusik.Text = "Mendengarkan Musik"
        CbMusik.UseVisualStyleBackColor = True
        ' 
        ' CbOlahraga
        ' 
        CbOlahraga.AutoSize = True
        CbOlahraga.Location = New Point(201, 52)
        CbOlahraga.Name = "CbOlahraga"
        CbOlahraga.Size = New Size(74, 19)
        CbOlahraga.TabIndex = 6
        CbOlahraga.Text = "Olahraga"
        CbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' CbMasak
        ' 
        CbMasak.AutoSize = True
        CbMasak.Location = New Point(201, 27)
        CbMasak.Name = "CbMasak"
        CbMasak.Size = New Size(77, 19)
        CbMasak.TabIndex = 5
        CbMasak.Text = "Memasak"
        CbMasak.UseVisualStyleBackColor = True
        ' 
        ' CbMancing
        ' 
        CbMancing.AutoSize = True
        CbMancing.Location = New Point(19, 130)
        CbMancing.Name = "CbMancing"
        CbMancing.Size = New Size(90, 19)
        CbMancing.TabIndex = 4
        CbMancing.Text = "Memancing"
        CbMancing.UseVisualStyleBackColor = True
        ' 
        ' CbGame
        ' 
        CbGame.AutoSize = True
        CbGame.Location = New Point(19, 105)
        CbGame.Name = "CbGame"
        CbGame.Size = New Size(87, 19)
        CbGame.TabIndex = 3
        CbGame.Text = "Main Game"
        CbGame.UseVisualStyleBackColor = True
        ' 
        ' CbNgoding
        ' 
        CbNgoding.AutoSize = True
        CbNgoding.Location = New Point(19, 77)
        CbNgoding.Name = "CbNgoding"
        CbNgoding.Size = New Size(73, 19)
        CbNgoding.TabIndex = 2
        CbNgoding.Text = "Ngoding"
        CbNgoding.UseVisualStyleBackColor = True
        ' 
        ' CbBerenang
        ' 
        CbBerenang.AutoSize = True
        CbBerenang.Location = New Point(19, 52)
        CbBerenang.Name = "CbBerenang"
        CbBerenang.Size = New Size(76, 19)
        CbBerenang.TabIndex = 1
        CbBerenang.Text = "Berenang"
        CbBerenang.UseVisualStyleBackColor = True
        ' 
        ' CbMembaca
        ' 
        CbMembaca.AutoSize = True
        CbMembaca.Location = New Point(19, 27)
        CbMembaca.Name = "CbMembaca"
        CbMembaca.Size = New Size(79, 19)
        CbMembaca.TabIndex = 0
        CbMembaca.Text = "Membaca"
        CbMembaca.UseVisualStyleBackColor = True
        ' 
        ' BtnCetak
        ' 
        BtnCetak.Location = New Point(326, 479)
        BtnCetak.Name = "BtnCetak"
        BtnCetak.Size = New Size(673, 42)
        BtnCetak.TabIndex = 13
        BtnCetak.Text = "Cetak Kartu"
        BtnCetak.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1039, 87)
        Panel1.TabIndex = 14
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.PaleTurquoise
        Label6.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlDarkDark
        Label6.Location = New Point(404, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(282, 33)
        Label6.TabIndex = 0
        Label6.Text = "KARTU INDENTITAS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(1039, 576)
        Controls.Add(Panel1)
        Controls.Add(BtnCetak)
        Controls.Add(GbHobi)
        Controls.Add(DtpLahir)
        Controls.Add(GbJK)
        Controls.Add(TxtAlamat)
        Controls.Add(TxtUmur)
        Controls.Add(TxtTelepon)
        Controls.Add(TxtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnGambar)
        Controls.Add(PicGambar)
        Name = "Form1"
        Text = "Form1"
        CType(PicGambar, ComponentModel.ISupportInitialize).EndInit()
        GbJK.ResumeLayout(False)
        GbJK.PerformLayout()
        GbHobi.ResumeLayout(False)
        GbHobi.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicGambar As PictureBox
    Friend WithEvents BtnGambar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtTelepon As TextBox
    Friend WithEvents TxtUmur As TextBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents GbJK As GroupBox
    Friend WithEvents DtpLahir As DateTimePicker
    Friend WithEvents RbCewek As RadioButton
    Friend WithEvents RbCowo As RadioButton
    Friend WithEvents GbHobi As GroupBox
    Friend WithEvents CbNulis As CheckBox
    Friend WithEvents CbGambar As CheckBox
    Friend WithEvents CbMusik As CheckBox
    Friend WithEvents CbOlahraga As CheckBox
    Friend WithEvents CbMasak As CheckBox
    Friend WithEvents CbMancing As CheckBox
    Friend WithEvents CbGame As CheckBox
    Friend WithEvents CbNgoding As CheckBox
    Friend WithEvents CbBerenang As CheckBox
    Friend WithEvents CbMembaca As CheckBox
    Friend WithEvents BtnCetak As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label

End Class
