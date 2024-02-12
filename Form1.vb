Imports Scripting
Imports Microsoft.VisualBasic.FileIO


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeaderListView()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "CSV Files|*.csv"
        ofd.FilterIndex = 1
        ofd.Multiselect = False

        If ofd.ShowDialog() = vbOK Then
            Dim selectedFilePath As String
            selectedFilePath = ofd.FileName
            'call procedur membaca file csv
            Call readCsvFile(selectedFilePath)
        End If
    End Sub

    Sub setHeaderListView()
        ListView1.Columns.Add("Nama", 150)
        ListView1.Columns.Add("NIM", 100)
        ListView1.Columns.Add("Jenis Kelamin", 110)
        ListView1.Columns.Add("Tempat", 80)
        ListView1.Columns.Add("Tgl Lahir", 100)
        ListView1.Columns.Add("Alamat", 150)
        ListView1.Columns.Add("Jurusan", 150)
        ListView1.Columns.Add("Nilai", 50)
        ListView1.Columns.Add("Status", 100)


    End Sub
    Sub simpanMahasiswa(nim As String, nama As String, jenisKelamin As String, tempat As String, tglLahir As String, alamat As String, jurusan As String, nilai As Int32)
        Dim newItems As New ListViewItem(nama)
        newItems.SubItems.Add(nim)
        newItems.SubItems.Add(jenisKelamin)
        newItems.SubItems.Add(tempat)
        newItems.SubItems.Add(tglLahir)
        newItems.SubItems.Add(alamat)
        newItems.SubItems.Add(jurusan)
        newItems.SubItems.Add(nilai)
        If nilai >= 70 Then
            newItems.SubItems.Add("Lulus")
        Else
            newItems.SubItems.Add("Tidak Lulus")
        End If
        ListView1.Items.Add(newItems)

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'validasi nim dan nama tidak boleh kosong
        If txtNim.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("NIM atau Nama tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Call simpanMahasiswa(txtNim.Text, txtNama.Text, cbJenisKelamin.Text, txtTempat.Text, dtpTglLahir.Value.ToString(), txtAlamat.Text, cbJurusan.Text, txtNilai.Text)
        Call clearInput()


    End Sub
    Private Sub clearInput()
        txtNim.Text = ""
        txtNama.Text = ""
        cbJenisKelamin.Text = ""
        txtTempat.Text = ""
        dtpTglLahir.Value = Now()
        txtAlamat.Text = ""
        cbJurusan.Text = ""
        txtNilai.Text = ""
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            txtNama.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtNim.Text = ListView1.SelectedItems(0).SubItems(1).Text
            cbJenisKelamin.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtTempat.Text = ListView1.SelectedItems(0).SubItems(3).Text
            Dim tglLahir As String = ListView1.SelectedItems(0).SubItems(4).Text
            txtAlamat.Text = ListView1.SelectedItems(0).SubItems(5).Text
            dtpTglLahir.Value = CDate(tglLahir)
            cbJurusan.Text = ListView1.SelectedItems(0).SubItems(6).Text
            txtNilai.Text = ListView1.SelectedItems(0).SubItems(7).Text

        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Yakin Anda akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ListView1.Items.Remove(ListView1.SelectedItems(0))
                Call clearInput()
            End If
        Else
            MessageBox.Show("Silahkan klik data yanag akan dihapus terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems(0).Text = txtNama.Text
            ListView1.SelectedItems(0).SubItems(1).Text = txtNim.Text
            ListView1.SelectedItems(0).SubItems(2).Text = cbJenisKelamin.Text
            ListView1.SelectedItems(0).SubItems(3).Text = txtTempat.Text
            ListView1.SelectedItems(0).SubItems(4).Text = dtpTglLahir.Value
            ListView1.SelectedItems(0).SubItems(5).Text = txtAlamat.Text
            ListView1.SelectedItems(0).SubItems(6).Text = cbJurusan.Text
            ListView1.SelectedItems(0).SubItems(7).Text = txtNilai.Text
            If txtNilai.Text >= 70 Then
                ListView1.SelectedItems(0).SubItems(8).Text = "Lulus"
            Else
                ListView1.SelectedItems(0).SubItems(8).Text = "Lulus Tidak Lulus"
            End If
        Else
            MessageBox.Show("Silahkan klik data yanag akan diedit terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Call clearInput()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        ' Menampilkan MessageBox konfirmasi sebelum menutup aplikasi
        Dim result As DialogResult = MessageBox.Show("Yakin Anda akan keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call clearInput()
    End Sub
    Private Sub readCsvFile(pathFile As String)
        Using MyReader As New TextFieldParser(pathFile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim i As Long = 0

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    'eksekusi selain header
                    If i > 0 Then
                        ' Menambahkan data mahasiswa dengan memanggail procedur simpanMahasiswa
                        Dim nim, nama, jenisKelamin, tempatLahir, tglLahir, alamat, jurusan As String
                        Dim nilai As Int32

                        nama = currentRow(0)
                        nim = currentRow(1)
                        jenisKelamin = currentRow(2)
                        tempatLahir = currentRow(3)
                        tglLahir = currentRow(4)
                        alamat = currentRow(5)
                        jurusan = currentRow(6)

                        'validasi nilai harus integer
                        nilai = CInt(currentRow(7))

                        'call procedur simpan data mahasiswa
                        Call simpanMahasiswa(nim, nama, jenisKelamin, tempatLahir, tglLahir, alamat, jurusan, nilai)
                    End If


                    i += 1
                Catch ex As Exception
                    MsgBox("Line " & i + 1 & " " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Private Sub btnHapusAll_Click(sender As Object, e As EventArgs) Handles btnHapusAll.Click

        Dim result As DialogResult = MessageBox.Show("Yakin Anda akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ListView1.Items.Clear()
        End If


    End Sub
End Class
