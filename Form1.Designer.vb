<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        lblNim = New Label()
        lblNama = New Label()
        lblJenisKelamin = New Label()
        lblTempat = New Label()
        lblTglLahir = New Label()
        lblAlamat = New Label()
        txtNim = New TextBox()
        txtNama = New TextBox()
        cbJenisKelamin = New ComboBox()
        txtTempat = New TextBox()
        dtpTglLahir = New DateTimePicker()
        txtAlamat = New TextBox()
        btnImport = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        btnSimpan = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        ListView1 = New ListView()
        txtNilai = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        cbJurusan = New ComboBox()
        Button1 = New Button()
        btnHapusAll = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(214, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 31)
        Label1.TabIndex = 0
        Label1.Text = "Data Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblNim.Location = New Point(13, 83)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(32, 20)
        lblNim.TabIndex = 2
        lblNim.Text = "NIM"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblNama.Location = New Point(12, 53)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(43, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblJenisKelamin.Location = New Point(12, 112)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(93, 20)
        lblJenisKelamin.TabIndex = 4
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblTempat
        ' 
        lblTempat.AutoSize = True
        lblTempat.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTempat.Location = New Point(12, 143)
        lblTempat.Name = "lblTempat"
        lblTempat.Size = New Size(53, 20)
        lblTempat.TabIndex = 5
        lblTempat.Text = "Tempat"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTglLahir.Location = New Point(12, 173)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(59, 20)
        lblTglLahir.TabIndex = 6
        lblTglLahir.Text = "Tgl Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblAlamat.Location = New Point(12, 204)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(49, 20)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNim
        ' 
        txtNim.BorderStyle = BorderStyle.FixedSingle
        txtNim.Location = New Point(191, 84)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(199, 23)
        txtNim.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(190, 54)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(199, 23)
        txtNama.TabIndex = 8
        ' 
        ' cbJenisKelamin
        ' 
        cbJenisKelamin.FormattingEnabled = True
        cbJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        cbJenisKelamin.Location = New Point(190, 113)
        cbJenisKelamin.Name = "cbJenisKelamin"
        cbJenisKelamin.Size = New Size(199, 23)
        cbJenisKelamin.TabIndex = 10
        ' 
        ' txtTempat
        ' 
        txtTempat.BorderStyle = BorderStyle.FixedSingle
        txtTempat.Location = New Point(190, 142)
        txtTempat.Name = "txtTempat"
        txtTempat.Size = New Size(199, 23)
        txtTempat.TabIndex = 11
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.CustomFormat = "yyyy/MM/dd"
        dtpTglLahir.Format = DateTimePickerFormat.Custom
        dtpTglLahir.Location = New Point(190, 172)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(199, 23)
        dtpTglLahir.TabIndex = 12
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Location = New Point(190, 201)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(199, 99)
        txtAlamat.TabIndex = 13
        ' 
        ' btnImport
        ' 
        btnImport.Location = New Point(12, 321)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(75, 23)
        btnImport.TabIndex = 16
        btnImport.Text = "&Import"
        btnImport.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(197, 321)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 18
        btnEdit.Text = "&Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(383, 321)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 19
        btnHapus.Text = "&Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(574, 321)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 20
        btnKeluar.Text = "&Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(104, 321)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 17
        btnSimpan.Text = "&Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ListView1
        ' 
        ListView1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 362)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(899, 152)
        ListView1.TabIndex = 21
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' txtNilai
        ' 
        txtNilai.BorderStyle = BorderStyle.FixedSingle
        txtNilai.Location = New Point(600, 85)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(199, 23)
        txtNilai.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(422, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 22
        Label2.Text = "Nilai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(422, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 21
        Label3.Text = "Jurusan"
        ' 
        ' cbJurusan
        ' 
        cbJurusan.FormattingEnabled = True
        cbJurusan.Items.AddRange(New Object() {"PJJ - Informatika", "PJJ - System informatika", "PJJ - Management", "PJJ - Komunikasi", "PJJ - Akuntansi"})
        cbJurusan.Location = New Point(600, 53)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(199, 23)
        cbJurusan.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(291, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 23
        Button1.Text = "&Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnHapusAll
        ' 
        btnHapusAll.Location = New Point(478, 321)
        btnHapusAll.Name = "btnHapusAll"
        btnHapusAll.Size = New Size(75, 23)
        btnHapusAll.TabIndex = 24
        btnHapusAll.Text = "Hapus &All"
        btnHapusAll.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 598)
        Controls.Add(btnHapusAll)
        Controls.Add(Button1)
        Controls.Add(cbJurusan)
        Controls.Add(txtNilai)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(ListView1)
        Controls.Add(btnSimpan)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnImport)
        Controls.Add(txtAlamat)
        Controls.Add(dtpTglLahir)
        Controls.Add(txtTempat)
        Controls.Add(cbJenisKelamin)
        Controls.Add(txtNama)
        Controls.Add(txtNim)
        Controls.Add(lblAlamat)
        Controls.Add(lblTglLahir)
        Controls.Add(lblTempat)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblNama)
        Controls.Add(lblNim)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UAS Pemprograman Visual"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblTempat As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbJenisKelamin As ComboBox
    Friend WithEvents txtTempat As TextBox
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnImport As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHapusAll As Button
End Class
