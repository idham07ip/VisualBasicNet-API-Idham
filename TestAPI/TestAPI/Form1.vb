Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Data.Entity

Public Class Form1
    Public id As String

    Private Sub UpdateData()
        Try
            DataGridView1.Rows.Clear()
            Dim uriString As String = "http://localhost/ci3_restapi/index.php/Api/PutData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub


    Private Sub HapusData()
        Try
            DataGridView1.Rows.Clear()
            Dim uriString As String = "http://localhost/ci3_restapi/index.php/Api/DeleteData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "DELETE"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub
    Private Sub tambahdata()
        Try
            DataGridView1.Rows.Clear()
            Dim uriString As String = "http://localhost/ci3_restapi/index.php/Api/PostData/" & txt_npm.Text.Trim & "/" & txt_nama.Text.Trim & "/" & txt_jurusan.Text.Trim & "/" & txt_prodi.Text.Trim & "/" & txt_kelas.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub

    Private Sub carinama()
        Try
            DataGridView1.Rows.Clear()
            Dim uriString As String = "http://localhost/ci3_restapi/index.php/Api/SearchData/" & TextBox1.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("id").ToString, item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub getdata()
        Try

            Dim uriString As String = "http://localhost/ci3_restapi/index.php/Api/GetData"
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("id").ToString, item("npm").ToString, item("nama").ToString, item("jurusan").ToString,
                                       item("prodi").ToString, item("kelas").ToString)

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        getdata()
    End Sub


    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        tambahdata()
        getdata()

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        HapusData()
        getdata()

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        UpdateData()
        getdata()

        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        id = Nothing
        id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_npm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_jurusan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_prodi.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_kelas.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = Nothing
        id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_npm.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_jurusan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_prodi.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_kelas.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
        txt_npm.Focus()
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        txt_npm.Text = ""
        txt_nama.Text = ""
        txt_jurusan.Text = ""
        txt_prodi.Text = ""
        txt_kelas.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        carinama()
        If TextBox1.Text Is "" Then
            getdata()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Clear()
        getdata()
    End Sub
End Class