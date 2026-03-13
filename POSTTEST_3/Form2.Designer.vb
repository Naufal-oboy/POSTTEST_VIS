<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PicKartu = New PictureBox()
        Panel1 = New Panel()
        LblAlamat = New Label()
        LblNama = New Label()
        LblUmur = New Label()
        LblTelp = New Label()
        LblLahir = New Label()
        LblJK = New Label()
        LblHobi = New Label()
        CType(PicKartu, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicKartu
        ' 
        PicKartu.BackColor = Color.White
        PicKartu.Location = New Point(40, 32)
        PicKartu.Name = "PicKartu"
        PicKartu.Size = New Size(254, 412)
        PicKartu.TabIndex = 1
        PicKartu.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Panel1.Controls.Add(LblAlamat)
        Panel1.Controls.Add(LblNama)
        Panel1.Controls.Add(LblUmur)
        Panel1.Controls.Add(LblTelp)
        Panel1.Controls.Add(LblLahir)
        Panel1.Controls.Add(LblJK)
        Panel1.Controls.Add(LblHobi)
        Panel1.Controls.Add(PicKartu)
        Panel1.Location = New Point(26, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(917, 467)
        Panel1.TabIndex = 2
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblAlamat.Location = New Point(324, 401)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(83, 30)
        LblAlamat.TabIndex = 9
        LblAlamat.Text = "Alamat"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblNama.Location = New Point(324, 46)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(72, 30)
        LblNama.TabIndex = 3
        LblNama.Text = "Nama"
        ' 
        ' LblUmur
        ' 
        LblUmur.AutoSize = True
        LblUmur.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblUmur.Location = New Point(324, 100)
        LblUmur.Name = "LblUmur"
        LblUmur.Size = New Size(67, 30)
        LblUmur.TabIndex = 4
        LblUmur.Text = "Umur"
        ' 
        ' LblTelp
        ' 
        LblTelp.AutoSize = True
        LblTelp.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblTelp.Location = New Point(324, 154)
        LblTelp.Name = "LblTelp"
        LblTelp.Size = New Size(162, 30)
        LblTelp.TabIndex = 5
        LblTelp.Text = "Nomor Telepon"
        ' 
        ' LblLahir
        ' 
        LblLahir.AutoSize = True
        LblLahir.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblLahir.Location = New Point(324, 216)
        LblLahir.Name = "LblLahir"
        LblLahir.Size = New Size(145, 30)
        LblLahir.TabIndex = 6
        LblLahir.Text = "Tanggal Lahir"
        ' 
        ' LblJK
        ' 
        LblJK.AutoSize = True
        LblJK.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblJK.Location = New Point(324, 279)
        LblJK.Name = "LblJK"
        LblJK.Size = New Size(144, 30)
        LblJK.TabIndex = 7
        LblJK.Text = "Jenis Kelamin"
        ' 
        ' LblHobi
        ' 
        LblHobi.AutoSize = True
        LblHobi.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblHobi.Location = New Point(324, 343)
        LblHobi.Name = "LblHobi"
        LblHobi.Size = New Size(58, 30)
        LblHobi.TabIndex = 8
        LblHobi.Text = "Hobi"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(968, 523)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        CType(PicKartu, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PicKartu As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblNama As Label
    Friend WithEvents LblUmur As Label
    Friend WithEvents LblTelp As Label
    Friend WithEvents LblLahir As Label
    Friend WithEvents LblJK As Label
    Friend WithEvents LblHobi As Label
    Friend WithEvents LblAlamat As Label
End Class
