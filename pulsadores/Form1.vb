Imports System.IO.Ports

Public Class Form1
    Dim f_go As Boolean = False
    Public leones, osos, aguilas, tiburones As String
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
            myCOlor = btnGo.BackColor
        Catch ex As Exception

        End Try
    End Sub



    Dim cnt As Byte
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim Incoming As Byte
            Incoming = SerialPort1.ReadByte()
            'MessageBox.Show(Incoming.ToString)
            If f_go Then
                If Incoming = 161 Then
                    If tiburones = "" Then
                        cnt += 1
                        tiburones = cnt.ToString
                        If (flag_ganador = False) Then
                            SerialPort1.Write({&H62}, 0, 1)
                            flag_ganador = True
                        End If
                    End If
                ElseIf Incoming = 162
                    If leones = "" Then
                        cnt += 1
                        leones = cnt.ToString
                        If (flag_ganador = False) Then
                            SerialPort1.Write({&H52}, 0, 1)
                            flag_ganador = True
                        End If
                    End If
                ElseIf Incoming = 163
                    If aguilas = "" Then
                        cnt += 1
                        aguilas = cnt.ToString
                        If (flag_ganador = False) Then
                            SerialPort1.Write({&H82}, 0, 1)
                            flag_ganador = True
                        End If
                    End If
                ElseIf Incoming = 164
                    If osos = "" Then
                        cnt += 1
                        osos = cnt.ToString
                        If (flag_ganador = False) Then
                            SerialPort1.Write({&H72}, 0, 1)
                            flag_ganador = True
                        End If
                    End If
                End If
                If cnt = 4 Then
                    f_go = False
                    cnt = 0
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Dim myCOlor As New Color
    Dim flag_ganador As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            leones = ""
            osos = ""
            aguilas = ""
            tiburones = ""
            btnGo.BackColor = myCOlor
            f_go = False
            SerialPort1.Write({&H51, &H61, &H71, &H81}, 0, 4)
            cnt = 0
            flag_ganador = False
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            f_go = True
            btnGo.BackColor = Color.GreenYellow
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (lion = 1) Then
            lion = 0
            Application.DoEvents()
            lionPlay()
        End If
    End Sub

    Private Sub btnVentanaResultados_Click(sender As Object, e As EventArgs) Handles btnVentanaResultados.Click
        Try
            Form2.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            FormZgz.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            FormEncuentro2eq.Show()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            FormEncuentro3eq.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class
