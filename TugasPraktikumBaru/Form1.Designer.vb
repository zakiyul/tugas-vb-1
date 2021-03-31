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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_namaBarang = New System.Windows.Forms.TextBox()
        Me.tb_hargaBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_jumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_totalHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_hitung1 = New System.Windows.Forms.Button()
        Me.tb_tunai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_kembalian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penjualan Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang : "
        '
        'tb_namaBarang
        '
        Me.tb_namaBarang.Location = New System.Drawing.Point(187, 148)
        Me.tb_namaBarang.Name = "tb_namaBarang"
        Me.tb_namaBarang.Size = New System.Drawing.Size(196, 20)
        Me.tb_namaBarang.TabIndex = 2
        '
        'tb_hargaBarang
        '
        Me.tb_hargaBarang.Location = New System.Drawing.Point(187, 185)
        Me.tb_hargaBarang.Name = "tb_hargaBarang"
        Me.tb_hargaBarang.Size = New System.Drawing.Size(196, 20)
        Me.tb_hargaBarang.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Harga Barang : "
        '
        'tb_jumlahBarang
        '
        Me.tb_jumlahBarang.Location = New System.Drawing.Point(187, 227)
        Me.tb_jumlahBarang.Name = "tb_jumlahBarang"
        Me.tb_jumlahBarang.Size = New System.Drawing.Size(196, 20)
        Me.tb_jumlahBarang.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jumlah Barang : "
        '
        'tb_totalHarga
        '
        Me.tb_totalHarga.Location = New System.Drawing.Point(187, 263)
        Me.tb_totalHarga.Name = "tb_totalHarga"
        Me.tb_totalHarga.ReadOnly = True
        Me.tb_totalHarga.Size = New System.Drawing.Size(196, 20)
        Me.tb_totalHarga.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Harga : "
        '
        'btn_hitung1
        '
        Me.btn_hitung1.Location = New System.Drawing.Point(187, 305)
        Me.btn_hitung1.Name = "btn_hitung1"
        Me.btn_hitung1.Size = New System.Drawing.Size(75, 23)
        Me.btn_hitung1.TabIndex = 9
        Me.btn_hitung1.Text = "Hitung"
        Me.btn_hitung1.UseVisualStyleBackColor = True
        '
        'tb_tunai
        '
        Me.tb_tunai.Location = New System.Drawing.Point(187, 366)
        Me.tb_tunai.Name = "tb_tunai"
        Me.tb_tunai.Size = New System.Drawing.Size(196, 20)
        Me.tb_tunai.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tunai : "
        '
        'tb_kembalian
        '
        Me.tb_kembalian.Location = New System.Drawing.Point(187, 407)
        Me.tb_kembalian.Name = "tb_kembalian"
        Me.tb_kembalian.ReadOnly = True
        Me.tb_kembalian.Size = New System.Drawing.Size(196, 20)
        Me.tb_kembalian.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kembalian : "
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(140, 449)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(75, 23)
        Me.btn_hitung.TabIndex = 14
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(233, 449)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 15
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(325, 449)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 16
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 497)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.tb_kembalian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_tunai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_hitung1)
        Me.Controls.Add(Me.tb_totalHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_jumlahBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_hargaBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_namaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_namaBarang As System.Windows.Forms.TextBox
    Friend WithEvents tb_hargaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_jumlahBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_totalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_hitung1 As System.Windows.Forms.Button
    Friend WithEvents tb_tunai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_kembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button

End Class
