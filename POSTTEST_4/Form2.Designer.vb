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
        PbKartu = New PictureBox()
        Panel1 = New Panel()
        LblKontak = New Label()
        LblAktivitas = New Label()
        LblRole = New Label()
        LblGenre = New Label()
        LblID = New Label()
        Lblnama = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        CType(PbKartu, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PbKartu
        ' 
        PbKartu.BackColor = SystemColors.ControlLightLight
        PbKartu.Location = New Point(21, 104)
        PbKartu.Name = "PbKartu"
        PbKartu.Size = New Size(179, 272)
        PbKartu.SizeMode = PictureBoxSizeMode.StretchImage
        PbKartu.TabIndex = 0
        PbKartu.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(LblKontak)
        Panel1.Controls.Add(LblAktivitas)
        Panel1.Controls.Add(LblRole)
        Panel1.Controls.Add(LblGenre)
        Panel1.Controls.Add(LblID)
        Panel1.Controls.Add(Lblnama)
        Panel1.Location = New Point(216, 104)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 272)
        Panel1.TabIndex = 1
        ' 
        ' LblKontak
        ' 
        LblKontak.AutoSize = True
        LblKontak.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblKontak.Location = New Point(29, 150)
        LblKontak.Name = "LblKontak"
        LblKontak.Size = New Size(69, 21)
        LblKontak.TabIndex = 5
        LblKontak.Text = "Kontak :"
        ' 
        ' LblAktivitas
        ' 
        LblAktivitas.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAktivitas.Location = New Point(29, 182)
        LblAktivitas.Name = "LblAktivitas"
        LblAktivitas.Size = New Size(327, 81)
        LblAktivitas.TabIndex = 4
        LblAktivitas.Text = "Aktivitas :"
        ' 
        ' LblRole
        ' 
        LblRole.AutoSize = True
        LblRole.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblRole.Location = New Point(29, 120)
        LblRole.Name = "LblRole"
        LblRole.Size = New Size(51, 21)
        LblRole.TabIndex = 3
        LblRole.Text = "Role :"
        ' 
        ' LblGenre
        ' 
        LblGenre.AutoSize = True
        LblGenre.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblGenre.Location = New Point(29, 84)
        LblGenre.Name = "LblGenre"
        LblGenre.Size = New Size(62, 21)
        LblGenre.TabIndex = 2
        LblGenre.Text = "Genre :"
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblID.Location = New Point(29, 53)
        LblID.Name = "LblID"
        LblID.Size = New Size(34, 21)
        LblID.TabIndex = 1
        LblID.Text = "ID :"
        ' 
        ' Lblnama
        ' 
        Lblnama.AutoSize = True
        Lblnama.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblnama.Location = New Point(29, 22)
        Lblnama.Name = "Lblnama"
        Lblnama.Size = New Size(60, 21)
        Lblnama.TabIndex = 0
        Lblnama.Text = "Nama :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Logo_komunitas_Gamer_Nexus_futuristik
        PictureBox2.Location = New Point(465, -9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(202, 84)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(817, 64)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 30)
        Label1.TabIndex = 3
        Label1.Text = "GAMER NEXUS COMMUNITY - DIGITAL ID CARD"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(624, 403)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PbKartu)
        Name = "Form2"
        Text = "Form2"
        CType(PbKartu, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PbKartu As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAktivitas As Label
    Friend WithEvents LblRole As Label
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblID As Label
    Friend WithEvents Lblnama As Label
    Friend WithEvents LblKontak As Label
End Class
