<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.npm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cari_npm = New System.Windows.Forms.Button()
        Me.txt_cari_npm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btn_cari_npm)
        Me.GroupBox1.Controls.Add(Me.txt_cari_npm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 426)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.npm, Me.nama, Me.jurusan, Me.prodi, Me.kelas})
        Me.DataGridView1.Location = New System.Drawing.Point(39, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(814, 234)
        Me.DataGridView1.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "Nomor ID"
        Me.id.MinimumWidth = 10
        Me.id.Name = "id"
        Me.id.Width = 90
        '
        'npm
        '
        Me.npm.HeaderText = "Nomor Pokok Mahasiswa"
        Me.npm.Name = "npm"
        Me.npm.Width = 190
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.Width = 165
        '
        'jurusan
        '
        Me.jurusan.HeaderText = "Jurusan"
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Width = 125
        '
        'prodi
        '
        Me.prodi.HeaderText = "Prodi"
        Me.prodi.Name = "prodi"
        Me.prodi.Width = 135
        '
        'kelas
        '
        Me.kelas.HeaderText = "Kelas"
        Me.kelas.Name = "kelas"
        Me.kelas.Width = 55
        '
        'btn_cari_npm
        '
        Me.btn_cari_npm.Location = New System.Drawing.Point(537, 76)
        Me.btn_cari_npm.Name = "btn_cari_npm"
        Me.btn_cari_npm.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari_npm.TabIndex = 2
        Me.btn_cari_npm.Text = "Search"
        Me.btn_cari_npm.UseVisualStyleBackColor = True
        '
        'txt_cari_npm
        '
        Me.txt_cari_npm.Location = New System.Drawing.Point(299, 78)
        Me.txt_cari_npm.Name = "txt_cari_npm"
        Me.txt_cari_npm.Size = New System.Drawing.Size(232, 23)
        Me.txt_cari_npm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari NPM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cari_npm As Button
    Friend WithEvents txt_cari_npm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents npm As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jurusan As DataGridViewTextBoxColumn
    Friend WithEvents prodi As DataGridViewTextBoxColumn
    Friend WithEvents kelas As DataGridViewTextBoxColumn
End Class
