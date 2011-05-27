Imports System.Data.Oledb 'oledb sýnýfýný projeyt ekler
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net

Public Class Form1
    Public Shared baglanti As OleDb.OleDbConnection
    Public Shared komut As OleDb.OleDbCommand
    Public Shared verioku As OleDb.OleDbDataReader

    Dim en As Integer, boy As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True ' her zaman üstte
        en = Screen.PrimaryScreen.Bounds.Width
        boy = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New System.Drawing.Point((en - 300), (0))

    End Sub

    Function ayiklama(ByVal donen As String) As String()
        Dim donus(5) As String
        'Dim id, gonderen, baslik, kategorisi, icerik, eklenmetarihi
        Dim silDesen As New Regex("<me.*>")
        donen = silDesen.Replace(donen, "")

        Dim id_bulunanlar As MatchCollection
        Dim id_desen As New Regex("<id>\d+</id>") ' id çekmek gerekli olan desen
        Dim id_temizle As New Regex("</?id>") ' <id> </id> taglarýný temizlemek için

        Dim baslik_bulunanlar As MatchCollection
        Dim baslik_desen As New Regex("(?<=<baslik>)[\s\S]*?(?=</baslik>)", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
        Dim baslik_temizle As New Regex("</?baslik>", RegexOptions.IgnoreCase Or RegexOptions.IgnorePatternWhitespace)


        Dim kategori_bulunanlar As MatchCollection
        Dim kategori_desen As New Regex("<kategorisi>\w+</kategorisi>")
        Dim kategori_temizle As New Regex("</?kategorisi>")

        Dim icerik_bulunanlar As MatchCollection
        Dim icerik_desen As New Regex("(?<=<icerik><pre>)[\s\S]*?(?=</pre></icerik>)", RegexOptions.Compiled Or RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        Dim icerik_temizle As New Regex("</?pre></?icerik>", RegexOptions.IgnoreCase Or RegexOptions.IgnorePatternWhitespace Or RegexOptions.Multiline)

        Dim tarih_bulunanlar As MatchCollection
        Dim tarih_desen As New Regex("<eklenmetarihi>.*.</eklenmetarihi>")
        Dim tarih_temizle As New Regex("</?eklenmetarihi>")

        Dim gonderen_bulunanlar As MatchCollection
        Dim gonderen_desen As New Regex("<gonderen>[^\s]*</gonderen>")
        Dim gonderen_temizle As New Regex("</?gonderen>")

        id_bulunanlar = id_desen.Matches(donen) 'bulunanlar özel veri tipinde
        baslik_bulunanlar = baslik_desen.Matches(donen)
        kategori_bulunanlar = kategori_desen.Matches(donen)
        icerik_bulunanlar = icerik_desen.Matches(donen)
        tarih_bulunanlar = tarih_desen.Matches(donen)
        gonderen_bulunanlar = gonderen_desen.Matches(donen)

        Dim a As Match

        For Each a In id_bulunanlar
            donus(0) = id_temizle.Replace(a.Value, "")
            ' MsgBox(donus(0))  'Form2.TextBox1.Text = (donus(0))
        Next


        For Each a In baslik_bulunanlar
            donus(1) = baslik_temizle.Replace(a.Value, RegexOptions.Multiline)
            'MsgBox(donus(1))  'Form2.TextBox2.Text = (donus(1)) 

        Next


        For Each a In kategori_bulunanlar
            donus(2) = kategori_temizle.Replace(a.Value, "")
            'MsgBox(donus(2)) 'Form2.TextBox3.Text = (donus(2))

        Next


        For Each a In icerik_bulunanlar
            donus(3) = icerik_temizle.Replace(a.Value, "")
            'MsgBox(donus(3)) 'Form2.RichTextBox1.Text = (donus(3))
        Next


        For Each a In tarih_bulunanlar
            donus(4) = tarih_temizle.Replace(a.Value, "")
            'MsgBox(donus(4)) 'Form2.TextBox4.Text = (donus(4))

        Next


        For Each a In gonderen_bulunanlar
            donus(5) = gonderen_temizle.Replace(a.Value, "")
            'MsgBox(donus(5)) 'Form2.TextBox5.Text = (donus(5))
        Next


        Return (donus)
    End Function
    Public Function zamanKontrol()
        Dim URL As String = "http://trakyali.webfactional.com/banka/"
        Dim client As WebClient = New WebClient()
        Dim data As Stream = client.OpenRead(URL)
        Dim reader As StreamReader = New StreamReader(data)
        Dim Str = reader.ReadLine()
        Dim v As OleDb.OleDbDataReader


        baglanti = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=kodbankasi.mdb")
        baglanti.Open()

        Dim veri As New OleDb.OleDbCommand("SELECT MAX(sirasi) FROM banka", baglanti)

        v = veri.ExecuteReader()
        v.Read()
        Dim sonID As Integer = v.Item(0) + 1

        baglanti.Close()

        If Str <> sonID Then

            Dim c, fark As Integer
            c = Convert.ToInt32(Str)
            fark = c - sonID


            Dim sayi As Integer
            For sayi = sonID To sonID + fark
                Try
                    Dim URLe As String = "http://trakyali.webfactional.com/banka/" & sayi
                    Dim cliente As WebClient = New WebClient()
                    Dim datae As Stream = cliente.OpenRead(URLe)
                    Dim readere As StreamReader = New StreamReader(datae)


                    Dim donen As String = readere.ReadToEnd

                    Dim degerler() As String = ayiklama(donen)


                    baglanti = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=kodbankasi.mdb")
                    baglanti.Open()

                    Dim sonuc = New OleDb.OleDbCommand("insert into banka(sirasi,gonderen,baslik,kategorisi,eklenmetarihi) values('" & degerler(0).ToString & "' , '" & degerler(5).ToString() & "' , '" & degerler(1).ToString() & "' , '" & degerler(2).ToString() & "' ,  '" & degerler(4).ToString() & "')", baglanti)
                    sonuc.ExecuteNonQuery()

                    RichTextBox1.Text = ""
                    RichTextBox1.Text = degerler(3)

                    RichTextBox1.SaveFile("kodlar/" & degerler(0) & ".txt", RichTextBoxStreamType.UnicodePlainText)

                    baglanti.Close()
                Catch
                End Try
            Next
        End If
        Return False
    End Function

    Function dile_gore_cek(ByVal dil As String)
        '
        'Amaç
        '___________
        'Veri tabanýndan dile göre veriyi çekme
        'dil adýnda string tipinde paramatre alýyor.


        Dim komut_cumle As String = "Select * from banka where kategorisi Like '" & dil & "' and baslik='" + TextBox1.Text + "'"

        Form1.komut = New OleDb.OleDbCommand(komut_cumle, Form1.baglanti)
        Form1.verioku = Form1.komut.ExecuteReader()
        While verioku.Read ' Form1.verioku.Read

            Form2.TextBox1.Text = verioku(0)
            Form2.TextBox2.Text = verioku.GetString(2)
            Form2.TextBox3.Text = verioku.GetString(3)
            Form2.TextBox4.Text = verioku.GetString(4)
            Form2.TextBox5.Text = verioku.GetString(5)

            Form2.RichTextBox1.LoadFile("kodlar/" & verioku(0) & ".txt", RichTextBoxStreamType.UnicodePlainText)

        End While

        Return True
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form2.Show()
   
        baglanti = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=kodbankasi.mdb")
        baglanti.Open()

        Dim diller As String
        diller = ComboBox1.Text

        dile_gore_cek(diller)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        zamanKontrol()
    End Sub
End Class
