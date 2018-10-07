' Programma creato da hackerscrackers
' Data: 08/02/2015
'
Imports System.Drawing.Color

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case BackColor
            Case Color.Black
                BackColor = White

            Case Color.White
                BackColor = Red

            Case Color.Red
                BackColor = Blue

            Case Color.Blue
                BackColor = Gray

            Case Color.Gray
                BackColor = Green

            Case Color.Green
                BackColor = Black

            Case Color.Black
                Timer1.Stop()
                Timer1.Start()

        End Select
    End Sub

End Class
