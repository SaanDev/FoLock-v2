'Copyright 2019 SaanSoft Inc. All Rights Reserved.
'Author :- Sahan S Liyanage
Imports System.Data.OleDb
Imports System.Data

Public Class frmlogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmsignup.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fil the all informations")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select password From users where name= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SaaN\Sahan\Saan All\Sahan\Sahan\My Projects\FoLock V2\FoLock V2.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username or Password incorrect! Try Again!")
            End Try
            If (pword = pass) Then
                frmfolock.Show()
                If frmfolock.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("Login Failed.Try again.")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.BackColor = Color.Red
        Label3.ForeColor = Color.White

    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.FromArgb(40, 40, 40)
        Label3.ForeColor = Color.White
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.BackColor = Color.AliceBlue
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.FromArgb(40, 40, 40)
        Label4.ForeColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Settings will be available in next update.")
    End Sub


End Class
