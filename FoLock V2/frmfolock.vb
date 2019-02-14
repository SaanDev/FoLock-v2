'SaanSoft Inc.

Imports System.Security.AccessControl
Imports System.IO
Public Class Frmfolock
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Me.ShowInTaskbar = True

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = Color.FromArgb(40, 40, 40)
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.BackColor = Color.Red
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.FromArgb(40, 40, 40)
        Label1.ForeColor = Color.White
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With FolderBrowserDialog1
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = .SelectedPath
            End If
        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            Dim fs As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(TextBox1.Text, fs)
            MsgBox("" & TextBox1.Text & "Successfully Locked")
        Else
            MsgBox("Select Folder To Lock", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" Then
            Dim fs As FileSystemSecurity = File.GetAccessControl(TextBox1.Text)
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(TextBox1.Text, fs)
            MsgBox("" & TextBox1.Text & "Successfully Unlocked")
        Else
            MsgBox("Select Folder To Unock", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class