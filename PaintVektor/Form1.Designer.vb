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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioKotakTepiIsi = New System.Windows.Forms.RadioButton()
        Me.ShapeIsian = New System.Windows.Forms.Panel()
        Me.ShapeTepi = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.RadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGbrUlang = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.Warna6 = New System.Windows.Forms.Panel()
        Me.Warna5 = New System.Windows.Forms.Panel()
        Me.Warna4 = New System.Windows.Forms.Panel()
        Me.Warna3 = New System.Windows.Forms.Panel()
        Me.Warna2 = New System.Windows.Forms.Panel()
        Me.Warna1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(200, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 389)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaruToolStripMenuItem, Me.BukaToolStripMenuItem1, Me.SimpanToolStripMenuItem1, Me.KeluarToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BaruToolStripMenuItem
        '
        Me.BaruToolStripMenuItem.Name = "BaruToolStripMenuItem"
        Me.BaruToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BaruToolStripMenuItem.Text = "Baru"
        '
        'BukaToolStripMenuItem1
        '
        Me.BukaToolStripMenuItem1.Name = "BukaToolStripMenuItem1"
        Me.BukaToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.BukaToolStripMenuItem1.Text = "Buka"
        '
        'SimpanToolStripMenuItem1
        '
        Me.SimpanToolStripMenuItem1.Name = "SimpanToolStripMenuItem1"
        Me.SimpanToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.SimpanToolStripMenuItem1.Text = "Simpan"
        '
        'KeluarToolStripMenuItem1
        '
        Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.KeluarToolStripMenuItem1.Text = "Keluar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioKotakTepiIsi)
        Me.GroupBox1.Controls.Add(Me.ShapeIsian)
        Me.GroupBox1.Controls.Add(Me.ShapeTepi)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.lblUkuran)
        Me.GroupBox1.Controls.Add(Me.RadioElipsIsi)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 475)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'RadioKotakTepiIsi
        '
        Me.RadioKotakTepiIsi.AutoSize = True
        Me.RadioKotakTepiIsi.Location = New System.Drawing.Point(13, 269)
        Me.RadioKotakTepiIsi.Name = "RadioKotakTepiIsi"
        Me.RadioKotakTepiIsi.Size = New System.Drawing.Size(90, 17)
        Me.RadioKotakTepiIsi.TabIndex = 10
        Me.RadioKotakTepiIsi.Text = "Kotak Tepi Isi"
        Me.RadioKotakTepiIsi.UseVisualStyleBackColor = True
        '
        'ShapeIsian
        '
        Me.ShapeIsian.BackColor = System.Drawing.Color.White
        Me.ShapeIsian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeIsian.Location = New System.Drawing.Point(85, 406)
        Me.ShapeIsian.Name = "ShapeIsian"
        Me.ShapeIsian.Size = New System.Drawing.Size(66, 39)
        Me.ShapeIsian.TabIndex = 9
        '
        'ShapeTepi
        '
        Me.ShapeTepi.BackColor = System.Drawing.Color.Black
        Me.ShapeTepi.Location = New System.Drawing.Point(13, 406)
        Me.ShapeTepi.Name = "ShapeTepi"
        Me.ShapeTepi.Size = New System.Drawing.Size(66, 39)
        Me.ShapeTepi.TabIndex = 8
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 350)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 7
        Me.NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Location = New System.Drawing.Point(12, 319)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(93, 13)
        Me.lblUkuran.TabIndex = 6
        Me.lblUkuran.Text = "Ukuran Garis Tepi"
        '
        'RadioElipsIsi
        '
        Me.RadioElipsIsi.AutoSize = True
        Me.RadioElipsIsi.Location = New System.Drawing.Point(12, 224)
        Me.RadioElipsIsi.Name = "RadioElipsIsi"
        Me.RadioElipsIsi.Size = New System.Drawing.Size(62, 17)
        Me.RadioElipsIsi.TabIndex = 5
        Me.RadioElipsIsi.Text = "Eilips Isi"
        Me.RadioElipsIsi.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(13, 182)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(66, 17)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(13, 141)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(47, 17)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(13, 103)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(53, 17)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(13, 66)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(49, 17)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Checked = True
        Me.RadioBebas.Location = New System.Drawing.Point(13, 31)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(55, 17)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(609, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 401)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(171, 327)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGbrUlang)
        Me.GroupBox2.Controls.Add(Me.btnBersihkan)
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Controls.Add(Me.Warna6)
        Me.GroupBox2.Controls.Add(Me.Warna5)
        Me.GroupBox2.Controls.Add(Me.Warna4)
        Me.GroupBox2.Controls.Add(Me.Warna3)
        Me.GroupBox2.Controls.Add(Me.Warna2)
        Me.GroupBox2.Controls.Add(Me.Warna1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(200, 425)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 74)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'btnGbrUlang
        '
        Me.btnGbrUlang.Location = New System.Drawing.Point(505, 19)
        Me.btnGbrUlang.Name = "btnGbrUlang"
        Me.btnGbrUlang.Size = New System.Drawing.Size(75, 36)
        Me.btnGbrUlang.TabIndex = 7
        Me.btnGbrUlang.Text = "Gambar Ulang"
        Me.btnGbrUlang.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(409, 26)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 6
        Me.btnBersihkan.Text = "Bersihkan Kanvas"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(328, 26)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 5
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.Black
        Me.Warna6.Location = New System.Drawing.Point(259, 19)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(42, 43)
        Me.Warna6.TabIndex = 4
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.Color.White
        Me.Warna5.Location = New System.Drawing.Point(211, 19)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(42, 43)
        Me.Warna5.TabIndex = 4
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.Blue
        Me.Warna4.Location = New System.Drawing.Point(163, 19)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(42, 43)
        Me.Warna4.TabIndex = 3
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.Green
        Me.Warna3.Location = New System.Drawing.Point(115, 19)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(42, 43)
        Me.Warna3.TabIndex = 2
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.Location = New System.Drawing.Point(67, 19)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(42, 43)
        Me.Warna2.TabIndex = 1
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.Location = New System.Drawing.Point(19, 19)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(42, 43)
        Me.Warna1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 499)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Corat-Coret Vektor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblUkuran As Label
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RadioKotakTepiIsi As RadioButton
End Class
