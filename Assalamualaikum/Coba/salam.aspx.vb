Public Class salam
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Nama anda " & txtnama.Text & "<br> NIM anda " & txtnim.Text & "<br> Prodi anda " & txtkelas
    End Sub

End Class
