Public Class tema_olusturucu
    Dim degerler(3)
    Private Sub tema_olusturucu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            degerler(0) = ColorDialog1.Color
            MsgBox(ColorTranslator.FromHtml("red").ToString)
            'MsgBox(ColorTranslator.ToWin32(ColorDialog1.Color))
        End If

    End Sub
End Class