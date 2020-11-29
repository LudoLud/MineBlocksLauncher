Imports System.Net
Imports System.IO

Public Class Main
    Public MineBlocksVersion = 1

    Public Function CheckAdress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim reponse As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CheckAdress("https://www.google.com/") = True Then
                Mark.Text = "Internet"
                MarkIco.Image = My.Resources._257_10
            Else
                Mark.Text = "Offline"
                MarkIco.Image = My.Resources._16_10
            End If
            AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData\MineBlocks.swf"
        Catch ex As Exception
            ChngStat.Enabled = True
            ToolStripStatusLabel2.Text = "Error!"
            ToolStripStatusLabel2.ForeColor = Color.Red

            MessageBox.Show("Unable to launch the game. Detailed error: 

" & ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim result As DialogResult = MessageBox.Show("Warning! This will change the entire game. Continue?", "Mine Blocks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then

            ChngStat.Enabled = True
            ToolStripStatusLabel2.Text = "Changing game..."
            ToolStripStatusLabel2.ForeColor = Color.Blue
        End If
        Try
            If MineBlocksVersion = 1 Then
                Text = "Mine Blocks 2"
                ToolStripButton1.Text = "Play Mine Blocks"
                ToolStripButton4.Text = "Mine Blocks 2"
                MineBlocksVersion = 2
                AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData_MB2\Mine-Blocks-2.swf"
            Else
                Text = "Mine Blocks"
                ToolStripButton1.Text = "Try Mine Blocks 2"
                ToolStripButton4.Text = "Mine Blocks"

                MineBlocksVersion = 1
                AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData\MineBlocks.swf"
            End If
        Catch ex As Exception
            ChngStat.Enabled = True
            ToolStripStatusLabel2.Text = "Error!"
            ToolStripStatusLabel2.ForeColor = Color.Red

            MessageBox.Show("Unable to launch the game. Detailed error: 

" & ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Try
            Wiki.Show()
            Me.Enabled = False
        Catch ex As Exception
            ChngStat.Enabled = True
            ToolStripStatusLabel2.Text = "Error!"
            ToolStripStatusLabel2.ForeColor = Color.Red

            MessageBox.Show("Unable to launch the wiki. Detailed error: 

" & ex.ToString)
        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Warning! This will restart the entire game. Continue?", "Mine Blocks", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then

        End If
        If MineBlocksVersion = 1 Then
            AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData_MB2\Mine-Blocks-2.swf"
            AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData\MineBlocks.swf"
        Else
            AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData\MineBlocks.swf"
            AxShockwaveFlash1.Movie = Application.StartupPath & "\GameData_MB2\Mine-Blocks-2.swf"
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Enabled = False
        About.Show()
    End Sub

    Private Sub ChngStat_Tick(sender As Object, e As EventArgs) Handles ChngStat.Tick
        ToolStripStatusLabel2.Text = "Ready to play"
        ToolStripStatusLabel2.ForeColor = Color.Green
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
