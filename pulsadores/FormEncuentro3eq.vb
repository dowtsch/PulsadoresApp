Public Class FormEncuentro3eq


    Private Sub FormEncuentro3eq_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTiburones.Text = ""
        txtLeones.Text = ""
        ' txtAguilas.Text = ""
        'txtOsos.Text = ""
        Timer1.Enabled = True
        Timer1.Start()

    End Sub
    Public Sub writeMessage(str As String)
        Me.txtLeones.Text = str

        Application.DoEvents()
    End Sub 'writeMessage

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        writeMessage(Form1.leones)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.txtLeones.Text = Form1.leones 'En los pulsadores de Zgz, los leones aparecen como aguilas, ya que un relé no funciona. por modificar
            'Me.txtOsos.Text = Form1.aguilas
            Me.txtTiburones.Text = Form1.tiburones
            Me.txtOsos.Text = Form1.osos
        Catch ex As Exception

        End Try
    End Sub
End Class