Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("C:\Program Files\3dsfilebackup\core\start.bat")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.SONG, AudioPlayMode.BackgroundLoop)﻿
    End Sub
End Class
