Imports System.Data.OleDb
Imports System.Data

Public Class frmsignup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmlogin.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please fill the all information.")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SaaN\Sahan\Saan All\Sahan\Sahan\My Projects\FoLock V2\FoLock V2.accdb;")
                Dim insert As String = "Insert into users values('" & TextBox1.Text & "','" & TextBox2.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("FoLock Account created successfully!Please login to FoLock.")
                Me.Close()
                frmlogin.Show()
            Catch ex As Exception
                MsgBox("Somthing went wrong!")
            End Try
        End If
    End Sub

    Private Sub frmsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class