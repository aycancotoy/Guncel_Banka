Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = ""
        Dim URL As String = "http://trakyali.webfactional.com/banka/1"
        Dim client As WebClient = New WebClient()
        Dim data As Stream = client.OpenRead(URL)
        Dim reader As StreamReader = New StreamReader(data)
        Dim val As String = ""
        Do While Not reader.EndOfStream
            str = reader.ReadLine()
            ' RichTextBox1.Text += str
        Loop
    End Sub
    Function ayiklama(ByVal metin As String) As String()
        Dim donus(1) As String
        Dim icerik, baslik
        Dim silDesen As New Regex("<me.*>")
        metin = silDesen.Replace(metin, "") 'silDesen.Replace(donen, "")

        Dim baslik_bulunanlar As MatchCollection
        Dim baslik_desen As New Regex("<baslik>\w+</baslik>", RegexOptions.Multiline)
        Dim baslik_temizle As New Regex("</?baslik>", RegexOptions.Multiline)

        Dim icerik_bulunanlar As MatchCollection
        Dim icerik_desen As New Regex("<pr.*<", RegexOptions.Multiline)
        Dim icerik_temizle As New Regex("(</?pre>)", RegexOptions.Multiline)

        icerik_bulunanlar = icerik_desen.Matches(metin)
        baslik_bulunanlar = baslik_desen.Matches(metin)

        Dim a As Match

        For Each a In icerik_bulunanlar
            donus(0) = icerik_temizle.Replace(a.Value, "")
            MsgBox(donus(0))
        Next


        For Each a In baslik_bulunanlar
            donus(1) = baslik_temizle.Replace(a.Value, "")
            MsgBox(donus(1))
        Next
        Return (donus)
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim URL As String = "http://trakyali.webfactional.com/banka/1/"
        Dim client As WebClient = New WebClient()
        Dim data As Stream = client.OpenRead(URL)
        Dim reader As StreamReader = New StreamReader(data)
        Dim Str = reader.ReadLine()
        Dim okunan = reader.ReadToEnd
        Dim f(1) As String
        f = ayiklama(okunan)
        MsgBox(f(1)) 'TextBox1.Text = (ayiklama(okunan)) 
    End Sub

    
End Class
