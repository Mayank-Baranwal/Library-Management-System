﻿Public Class Log

    Private Sub Forgot_Click(sender As Object, e As EventArgs) Handles Forgot.Click

    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        Form1.Panel4.Visible = True
        Form1.Panel1.Visible = False
        Form1.Log1.Visible = False
        Form1.MyprofileSidePanel.Visible = True
    End Sub

    Private Sub SIgn_Click(sender As Object, e As EventArgs) Handles Sign_up.Click
        Form1.SignUpPage1.Visible = True
        Form1.Panel4.Visible = False
        Form1.Log1.Visible = False
        Form1.MyprofileSidePanel.Visible = False

    End Sub

   
End Class
