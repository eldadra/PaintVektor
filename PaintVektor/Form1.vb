Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Form1
    Dim modeGambar As String
    Dim warnaTepi As Color = Color.Black
    Dim warnaIsian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnaTepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaIsian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim namaFile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modeGambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modeGambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modeGambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modeGambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modeGambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElipsIsi.CheckedChanged
        modeGambar = "elipsisi"
    End Sub
    Private Sub RadioKotakTepiIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakTepiIsi.CheckedChanged
        modeGambar = "kotaktepiisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnaTepi
        isian.Color = warnaIsian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modeGambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnaTepi" + " " + warnaTepi.R.ToString + " " + warnaTepi.G.ToString + " " + warnaTepi.B.ToString & vbCrLf)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbCrLf)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modeGambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
            Case "kotaktepiisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                    g.DrawRectangle(tepi, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "warnatepi" + " " + warnaTepi.R.ToString + " " + warnaTepi.G.ToString + " " + warnaTepi.B.ToString & vbCrLf)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaIsian.R.ToString + " " + warnaIsian.G.ToString + " " + warnaIsian.B.ToString & vbCrLf)
            TextBox1.AppendText("o " + modeGambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString + " " + tepi.Width.ToString & vbCrLf)
        End If
    End Sub

    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna1.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna1.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna2.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna2.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna3.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna3.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna4.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna4.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna5.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna5.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna6.BackColor
            ShapeTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna6.BackColor
            ShapeIsian.BackColor = warnaIsian
        End If
    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnGbrUlang_Click(sender As Object, e As EventArgs) Handles btnGbrUlang.Click
        btnBersihkan.PerformClick()
        Dim a As Integer = TextBox1.Lines.Count
        For i As Integer = 0 To a
            Dim teksbaris As String = TextBox1.Lines(i)
            Dim pecah() As String
            pecah = teksbaris.Split(" "c)
            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)
            Select Case pecah(1)
                Case "warnatepi"
                    warnaTepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    tepi.Color = warnaTepi
                Case "warnaisian"
                    warnaIsian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    isian.Color = warnaIsian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotaktepiisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                        Dim thisTepi As New System.Drawing.Pen(warnaTepi, CInt(pecah(6)))
                        g.DrawRectangle(thisTepi, rect)
                    End Using
            End Select
        Next
        PictureBox1.Invalidate()
    End Sub

    Private Sub BukaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem1.Click
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            namaFile = openFileDialog1.FileName
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(namaFile)
            TextBox1.Text = fileReader
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = "C:\"
        saveFileDialog1.Filter = "Text Files (*.txt)|*txt"
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            namaFile = saveFileDialog1.FileName
            My.Computer.FileSystem.WriteAllText(namaFile, TextBox1.Text, False)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub BaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaruToolStripMenuItem.Click
        btnBersihkan.PerformClick()
        TextBox1.Text = Nothing
    End Sub

End Class
