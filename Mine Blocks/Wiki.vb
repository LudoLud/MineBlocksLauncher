Imports System.Net
Imports System.IO
Public Class Wiki
    Public Function CheckAdress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim reponse As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try
            Process.Start("https://mineblocks.com/1/wiki/index.php?title=Main_Page")
        Catch ex As Exception
            ChngStat.Enabled = True
            ToolStripStatusLabel2.Text = "Error!"
            ToolStripStatusLabel2.ForeColor = Color.Red
            MessageBox.Show("Unable to launch the wiki. Detailed error: 

" & ex.ToString)
        End Try
    End Sub

    Private Sub Wiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckAdress("https://www.google.com/") = True Then
            Mark.Text = "Internet"
            MarkIco.Image = My.Resources._257_10
        Else
            Mark.Text = "Offline"
            MarkIco.Image = My.Resources._16_10
        End If
    End Sub

    Private Sub Wiki_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChngStat_Tick(sender As Object, e As EventArgs) Handles ChngStat.Tick
        ToolStripStatusLabel2.Text = "Browsing..."
        ToolStripStatusLabel2.ForeColor = Color.Purple
    End Sub

    Private Sub InternetDxD_Tick(sender As Object, e As EventArgs)
        If CheckAdress("https://www.google.com/") = True Then
            Mark.Text = "Internet"
            MarkIco.Image = My.Resources._257_10
        Else
            Mark.Text = "Offline"
            MarkIco.Image = My.Resources._16_10
        End If
    End Sub
End Class