Public Class LOGIN
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusuario.Text = "jpomayay" And txtcontraseña.Text = "jpomayay" Then
            Me.Hide()
            HOME.Show()
        Else
            MsgBox("DATOS INCORRECTOS", vbCritical, "ALMACEN FARMACIA")
        End If
    End Sub
End Class
