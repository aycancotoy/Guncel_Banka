Imports System.Text.RegularExpressions

Public Class Form2
    Public Shared baglanti As OleDb.OleDbConnection
    Public Shared komut As OleDb.OleDbCommand
    Public Shared verioku As OleDb.OleDbDataReader
    Dim oRead As System.IO.StreamReader
    
    Function arayuzu_guncelle()
        Dim okunan As String
        Dim a
        Dim textboxlar() As TextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5}

        oRead = IO.File.OpenText("temalar/gecerli.tma")

        okunan = oRead.ReadToEnd
        oRead.Close()

        Me.BackColor = tema_dosyasi_temizle(okunan)(0)
        Me.RichTextBox1.BackColor = tema_dosyasi_temizle(okunan)(2)
        Me.MenuStrip1.BackColor = tema_dosyasi_temizle(okunan)(4)

        For Each a In textboxlar
            a.backcolor = tema_dosyasi_temizle(okunan)(3)
        Next


        Return False
    End Function

    Function duzenli_ifadelere_gonder(ByVal desen As String, ByVal temizle As String, ByVal metin As String)
        Dim bulunanlar As MatchCollection

        Dim a
        Dim desena As New Regex(desen)
        Dim temizlea As New Regex(temizle)

        Dim donucek_deger
        bulunanlar = desena.Matches(metin)

        For Each a In bulunanlar
            donucek_deger = (ColorTranslator.FromHtml(temizlea.Replace(a.value, "")))
        Next

        Return donucek_deger
    End Function

    Function tema_dosyasi_temizle(ByVal dosya_icerigi As String)
        Dim donucek_degerler(10)

        donucek_degerler(0) = duzenli_ifadelere_gonder("<arka_plan_renk>\#(\w+){6}</arka_plan_renk>", "</?arka_plan_renk>", dosya_icerigi)
        donucek_degerler(1) = duzenli_ifadelere_gonder("<yazi_renk>\#(\w+){6}</yazi_renk>", "</?yazi_renk>", dosya_icerigi)
        donucek_degerler(2) = duzenli_ifadelere_gonder("<richtextbox_arka_plan>\#(\w+){6}</richtextbox_arka_plan>", "</?richtextbox_arka_plan>", dosya_icerigi)
        donucek_degerler(4) = duzenli_ifadelere_gonder("<textbox_arka_plan>\#(\w+){6}</textbox_arka_plan>", "</?textbox_arka_plan>", dosya_icerigi)
        donucek_degerler(5) = duzenli_ifadelere_gonder("<menu_arka_plan>\#(\w+){6}</menu_arka_plan>", "</?menu_arka_plan>", dosya_icerigi)


        Return donucek_degerler
    End Function


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        AutoScroll = True
        'AutoScrollMargin=

        arayuzu_guncelle()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.zamanKontrol()
    End Sub

    Private Sub Hakk�m�zdaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hakk�m�zdaToolStripMenuItem.Click
        MessageBox.Show("Bu bir Kod Bankas�d�r." & Chr(10) & "Daha detayl� bilgi i�in www.trakyali.webfactional.com/hakkimizda ", "Hakk�m�zda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Geli�tiricilerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Geli�tiricilerToolStripMenuItem.Click
        MessageBox.Show("Aycan �otoy" & Chr(10) & "Emre Torun" & Chr(10) & "Yi�it Sad��", "Geli�tiriciler", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Function oku_ve_yazdir()
        '
        'Ama�
        '------
        ' Dosyay� a��p i�eri�ini Richtextbox1'e yazd�rmak...
        '

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then


            oRead = IO.File.OpenText(OpenFileDialog1.FileName)
            RichTextBox1.Text = oRead.ReadToEnd
        End If
        Return True
    End Function

    Private Sub TemaEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemaEkleToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            FileOpen(1, "temalar/gecerli.tma", OpenMode.Binary)

            FilePut(1, IO.File.OpenText(OpenFileDialog1.FileName).ReadToEnd)
            FileClose(1)

            arayuzu_guncelle()
            MessageBox.Show("Aray�z ba�ar�l� bir �ekilde g�ncellendi.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub A�ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A�ToolStripMenuItem.Click
        oku_ve_yazdir()
    End Sub

    Private Sub Temalar�mToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temalar�mToolStripMenuItem.Click

    End Sub

    Private Sub TemaOlu�turucuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemaOlu�turucuToolStripMenuItem.Click
        tema_olusturucu.Show()
    End Sub
End Class