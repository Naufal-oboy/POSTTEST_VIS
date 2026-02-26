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
        txtIPS = New TextBox()
        txtIPK = New TextBox()
        Label1 = New Label()
        lblPredikat = New Label()
        Label3 = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.BorderStyle = BorderStyle.FixedSingle
        txtIPS.Location = New Point(279, 155)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(161, 23)
        txtIPS.TabIndex = 0
        ' 
        ' txtIPK
        ' 
        txtIPK.BorderStyle = BorderStyle.FixedSingle
        txtIPK.Location = New Point(279, 255)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(161, 23)
        txtIPK.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(322, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 2
        Label1.Text = "IP Semester"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(279, 298)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(56, 15)
        lblPredikat.TabIndex = 3
        lblPredikat.Text = "Predikat :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(322, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 4
        Label3.Text = "IP Komulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(284, 197)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(365, 197)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(Label3)
        Controls.Add(lblPredikat)
        Controls.Add(Label1)
        Controls.Add(txtIPK)
        Controls.Add(txtIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
