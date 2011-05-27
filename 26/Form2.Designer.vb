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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SelamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EkleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TemalarýmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TemaEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YükleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YardýmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YardýmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HakkýmýzdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeliþtiricilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TemaOluþturucuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(333, 107)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(478, 242)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelamToolStripMenuItem, Me.DüzenleToolStripMenuItem, Me.PaketToolStripMenuItem, Me.YardýmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelamToolStripMenuItem
        '
        Me.SelamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.ToolStripSeparator2, Me.EkleToolStripMenuItem1})
        Me.SelamToolStripMenuItem.Name = "SelamToolStripMenuItem"
        Me.SelamToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.SelamToolStripMenuItem.Text = "Dosya"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'EkleToolStripMenuItem1
        '
        Me.EkleToolStripMenuItem1.Name = "EkleToolStripMenuItem1"
        Me.EkleToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EkleToolStripMenuItem1.Text = "Kapat"
        '
        'DüzenleToolStripMenuItem
        '
        Me.DüzenleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemalarýmToolStripMenuItem, Me.TemaEkleToolStripMenuItem, Me.TemaOluþturucuToolStripMenuItem})
        Me.DüzenleToolStripMenuItem.Name = "DüzenleToolStripMenuItem"
        Me.DüzenleToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.DüzenleToolStripMenuItem.Text = "Düzenle"
        '
        'TemalarýmToolStripMenuItem
        '
        Me.TemalarýmToolStripMenuItem.Name = "TemalarýmToolStripMenuItem"
        Me.TemalarýmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TemalarýmToolStripMenuItem.Text = "Temalarým"
        '
        'TemaEkleToolStripMenuItem
        '
        Me.TemaEkleToolStripMenuItem.Name = "TemaEkleToolStripMenuItem"
        Me.TemaEkleToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TemaEkleToolStripMenuItem.Text = "Tema Ekle"
        '
        'PaketToolStripMenuItem
        '
        Me.PaketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YükleToolStripMenuItem})
        Me.PaketToolStripMenuItem.Name = "PaketToolStripMenuItem"
        Me.PaketToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.PaketToolStripMenuItem.Text = "Paket"
        '
        'YükleToolStripMenuItem
        '
        Me.YükleToolStripMenuItem.Name = "YükleToolStripMenuItem"
        Me.YükleToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.YükleToolStripMenuItem.Text = "Yükle"
        '
        'YardýmToolStripMenuItem
        '
        Me.YardýmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YardýmToolStripMenuItem1, Me.ToolStripSeparator1, Me.HakkýmýzdaToolStripMenuItem, Me.GeliþtiricilerToolStripMenuItem})
        Me.YardýmToolStripMenuItem.Name = "YardýmToolStripMenuItem"
        Me.YardýmToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.YardýmToolStripMenuItem.Text = "Yardým"
        '
        'YardýmToolStripMenuItem1
        '
        Me.YardýmToolStripMenuItem1.Name = "YardýmToolStripMenuItem1"
        Me.YardýmToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.YardýmToolStripMenuItem1.Text = "Yardým"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'HakkýmýzdaToolStripMenuItem
        '
        Me.HakkýmýzdaToolStripMenuItem.Name = "HakkýmýzdaToolStripMenuItem"
        Me.HakkýmýzdaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.HakkýmýzdaToolStripMenuItem.Text = "Hakkýmýzda"
        '
        'GeliþtiricilerToolStripMenuItem
        '
        Me.GeliþtiricilerToolStripMenuItem.Name = "GeliþtiricilerToolStripMenuItem"
        Me.GeliþtiricilerToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GeliþtiricilerToolStripMenuItem.Text = "Geliþtiriciler"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(59, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(59, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "gonderen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(59, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "baslik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(59, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "kategorisi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(59, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "eklenme tarihi"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 131)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(117, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(117, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(164, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(117, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(164, 212)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(117, 20)
        Me.TextBox5.TabIndex = 15
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TemaOluþturucuToolStripMenuItem
        '
        Me.TemaOluþturucuToolStripMenuItem.Name = "TemaOluþturucuToolStripMenuItem"
        Me.TemaOluþturucuToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TemaOluþturucuToolStripMenuItem.Text = "Tema Oluþturucu"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 391)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EkleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DüzenleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemalarýmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemaEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YardýmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YardýmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HakkýmýzdaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeliþtiricilerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents YükleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TemaOluþturucuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
