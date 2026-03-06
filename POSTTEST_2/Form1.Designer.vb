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
        GroupBox1 = New GroupBox()
        BtnTambah = New Button()
        TxtGenre = New TextBox()
        TxtNamaTambah = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        BtnHapus = New Button()
        TxtNamaHapus = New TextBox()
        Label4 = New Label()
        LstBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGray
        GroupBox1.Controls.Add(BtnTambah)
        GroupBox1.Controls.Add(TxtGenre)
        GroupBox1.Controls.Add(TxtNamaTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(49, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 146)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = SystemColors.ButtonFace
        BtnTambah.Location = New Point(167, 117)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(75, 23)
        BtnTambah.TabIndex = 3
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' TxtGenre
        ' 
        TxtGenre.BorderStyle = BorderStyle.FixedSingle
        TxtGenre.Location = New Point(120, 81)
        TxtGenre.Name = "TxtGenre"
        TxtGenre.Size = New Size(100, 23)
        TxtGenre.TabIndex = 2
        ' 
        ' TxtNamaTambah
        ' 
        TxtNamaTambah.BorderStyle = BorderStyle.FixedSingle
        TxtNamaTambah.Location = New Point(120, 32)
        TxtNamaTambah.Name = "TxtNamaTambah"
        TxtNamaTambah.Size = New Size(100, 23)
        TxtNamaTambah.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Genre           :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Buku :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightGray
        GroupBox2.Controls.Add(BtnHapus)
        GroupBox2.Controls.Add(TxtNamaHapus)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(392, 53)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 146)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = SystemColors.ButtonFace
        BtnHapus.Location = New Point(167, 117)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(75, 23)
        BtnHapus.TabIndex = 3
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' TxtNamaHapus
        ' 
        TxtNamaHapus.BorderStyle = BorderStyle.FixedSingle
        TxtNamaHapus.Location = New Point(120, 32)
        TxtNamaHapus.Name = "TxtNamaHapus"
        TxtNamaHapus.Size = New Size(100, 23)
        TxtNamaHapus.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 0
        Label4.Text = "Nama Buku :"
        ' 
        ' LstBuku
        ' 
        LstBuku.BackColor = Color.LightGray
        LstBuku.BorderStyle = BorderStyle.FixedSingle
        LstBuku.FormattingEnabled = True
        LstBuku.Location = New Point(235, 232)
        LstBuku.Name = "LstBuku"
        LstBuku.Size = New Size(241, 182)
        LstBuku.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(702, 450)
        Controls.Add(LstBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents TxtNamaTambah As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents TxtNamaHapus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LstBuku As ListBox

End Class
