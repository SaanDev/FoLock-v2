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
            MsgBox("Plz Fill All the info")
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
                MsgBox("Username does not exit")
            End Try
            If (pword = pass) Then
                MsgBox("Login success")
                frmsignup.Show()
                If frmsignup.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed")
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
        Label3.BackColor = Color.Gray
        Label3.ForeColor = Color.Black
    End Sub
End Class
