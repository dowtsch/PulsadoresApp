Imports System.IO.Ports

Public Class Form1
    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\wtrfall.wav",
        AudioPlayMode.WaitToComplete)
    End Sub
    Sub lionPlay()
        My.Computer.Audio.Play("C:\lion2.wav",
        AudioPlayMode.WaitToComplete)
    End Sub
    Dim lion As Byte = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SerialPort1.PortName = "COM5"
            SerialPort1.Open()
            Timer1.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim Incoming As Byte
            Incoming = SerialPort1.ReadByte()
            'MessageBox.Show(Incoming.ToString)
            If (Incoming = 162) Then
                lion = 1

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (lion = 1) Then
                'pic1.Visible = True
                'Application.DoEvents()
                'lionPlay()
                AxWindowsMediaPlayer1.URL = "C:\lion.wmv"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (lion = 1) Then
            lion = 0

            pic1.Visible = True
            pic1.Enabled = False
            Application.DoEvents()
            lionPlay()
            'Application.DoEvents()
            'AxWindowsMediaPlayer1.URL = "C:\lion.gif"
        End If
    End Sub
End Class
