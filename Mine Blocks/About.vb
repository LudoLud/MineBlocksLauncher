Public Class About
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("https://zanzlanz.com/")
        Catch ex As Exception
            Main.ChngStat.Enabled = True
            Main.ToolStripStatusLabel2.Text = "Error!"
            Main.ToolStripStatusLabel2.ForeColor = Color.Red
            MessageBox.Show("Unable to launch Zanzlanz website. Detailed error: 

" & ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("https://github.com/LudoLud/MineBlocksLauncher")
        Catch ex As Exception
            Main.ChngStat.Enabled = True
            Main.ToolStripStatusLabel2.Text = "Error!"
            Main.ToolStripStatusLabel2.ForeColor = Color.Red
            MessageBox.Show("Unable to launch the GitHub page. Detailed error: 

" & ex.ToString)
        End Try
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub About_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Enabled = True
    End Sub
End Class