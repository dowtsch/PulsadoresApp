﻿Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtAguilas.Text = ""
        txtLeones.Text = ""
        txtOsos.Text = ""
        txtTiburones.Text = ""
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
            Me.txtLeones.Text = Form1.leones
            Me.txtOsos.Text = Form1.osos
            Me.txtAguilas.Text = Form1.aguilas
            Me.txtTiburones.Text = Form1.tiburones
        Catch ex As Exception

        End Try
    End Sub
End Class