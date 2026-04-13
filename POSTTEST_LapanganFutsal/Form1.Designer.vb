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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TxtID = New TextBox()
        TxtNama = New TextBox()
        TxtHarga = New TextBox()
        CmbLokasi = New ComboBox()
        CmbStatus = New ComboBox()
        CmbAC = New ComboBox()
        BtnSimpan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnReset = New Button()
        DgvLapangan = New DataGridView()
        TxtCari = New TextBox()
        Panel1 = New Panel()
        Label7 = New Label()
        CType(DgvLapangan, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 2
        Label3.Text = "Lokasi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(398, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(398, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 4
        Label5.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(398, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(23, 15)
        Label6.TabIndex = 5
        Label6.Text = "AC"
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(83, 90)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(300, 23)
        TxtID.TabIndex = 6
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(83, 149)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(300, 23)
        TxtNama.TabIndex = 7
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(445, 90)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(300, 23)
        TxtHarga.TabIndex = 8
        ' 
        ' CmbLokasi
        ' 
        CmbLokasi.FormattingEnabled = True
        CmbLokasi.Location = New Point(83, 222)
        CmbLokasi.Name = "CmbLokasi"
        CmbLokasi.Size = New Size(300, 23)
        CmbLokasi.TabIndex = 9
        ' 
        ' CmbStatus
        ' 
        CmbStatus.FormattingEnabled = True
        CmbStatus.Location = New Point(445, 149)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(300, 23)
        CmbStatus.TabIndex = 10
        ' 
        ' CmbAC
        ' 
        CmbAC.FormattingEnabled = True
        CmbAC.Location = New Point(445, 223)
        CmbAC.Name = "CmbAC"
        CmbAC.Size = New Size(300, 23)
        CmbAC.TabIndex = 11
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = SystemColors.ActiveCaption
        BtnSimpan.Location = New Point(83, 267)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(101, 37)
        BtnSimpan.TabIndex = 12
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = SystemColors.ActiveCaption
        BtnHapus.Location = New Point(445, 267)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(101, 37)
        BtnHapus.TabIndex = 14
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = SystemColors.ActiveCaption
        BtnUbah.Location = New Point(257, 267)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(101, 37)
        BtnUbah.TabIndex = 15
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = SystemColors.ActiveCaption
        BtnReset.Location = New Point(644, 267)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(101, 37)
        BtnReset.TabIndex = 16
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' DgvLapangan
        ' 
        DgvLapangan.BackgroundColor = SystemColors.ActiveCaption
        DgvLapangan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvLapangan.Location = New Point(83, 356)
        DgvLapangan.Name = "DgvLapangan"
        DgvLapangan.Size = New Size(662, 150)
        DgvLapangan.TabIndex = 17
        ' 
        ' TxtCari
        ' 
        TxtCari.Location = New Point(83, 327)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari Lapangan"
        TxtCari.Size = New Size(662, 23)
        TxtCari.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(-3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 64)
        Panel1.TabIndex = 19
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(800, 517)
        Controls.Add(Panel1)
        Controls.Add(TxtCari)
        Controls.Add(DgvLapangan)
        Controls.Add(BtnReset)
        Controls.Add(BtnUbah)
        Controls.Add(BtnHapus)
        Controls.Add(BtnSimpan)
        Controls.Add(CmbAC)
        Controls.Add(CmbStatus)
        Controls.Add(CmbLokasi)
        Controls.Add(TxtHarga)
        Controls.Add(TxtNama)
        Controls.Add(TxtID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DgvLapangan, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents CmbLokasi As ComboBox
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents CmbAC As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents DgvLapangan As DataGridView
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label

End Class
