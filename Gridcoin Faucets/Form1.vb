Public Class Form1
    Dim GridcoinAsiaReady As Integer = 1
    Dim EOBOTReady As Integer = 1
    Dim GridcoinStatsReady As Integer = 1
    Dim GridcoinAsiaTimeToShow As TimeSpan
    Dim GridcoinAsiaTotalTime As Long = TimeSpan.FromHours(6).TotalMilliseconds
    Dim GridcoinAsiaRemaining As Long = GridcoinAsiaTotalTime
    Dim EOBOTTimeToShow As TimeSpan
    Dim EOBOTTotalTime As Long = TimeSpan.FromDays(1).TotalMilliseconds
    Dim EOBOTRemaining As Long = EOBOTTotalTime
    Dim GridcoinStatsTimeToShow As TimeSpan
    Dim GridcoinStatsTotalTime As Long = TimeSpan.FromDays(1).TotalMilliseconds
    Dim GridcoinStatsRemaining As Long = GridcoinStatsTotalTime
    Private Sub GridcoinAsiaButton_Click(sender As Object, e As EventArgs) Handles GridcoinAsiaButton.Click
        If GridcoinAsiaReady = 1 Then
            GridcoinAsiaReady = 0
            GridcoinAsiaTimer.Interval = 1000
            GridcoinAsiaTimer.Enabled = True
            GridcoinAsiaTimeToShow = TimeSpan.FromMilliseconds(GridcoinAsiaRemaining)
            Process.Start("http://faucet.gridcoin.asia")
        Else
            Dim Result As DialogResult = MessageBox.Show("You can use this faucet in " & GridcoinAsiaTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & GridcoinAsiaTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & GridcoinAsiaTimeToShow.Seconds.ToString.PadLeft(2, "0"c) & vbCrLf & "Do you want to visit this faucet anyway?", "Gridcoin Faucets", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                Process.Start("http://faucet.gridcoin.asia")
            End If
        End If
    End Sub
    Private Sub GridcoinAsiaTimer_Tick(sender As Object, e As EventArgs) Handles GridcoinAsiaTimer.Tick
        If GridcoinAsiaRemaining = 0 Then
            GridcoinAsiaRemaining = GridcoinAsiaTotalTime
            GridcoinAsiaReady = 1
            GridcoinAsiaText.ForeColor = Color.Green
            GridcoinAsiaText.Text = "You can use this faucet now!"
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Gridcoin Faucets"
            NotifyIcon1.BalloonTipText = "You can now use Gridcoin Asia Faucet!"
            NotifyIcon1.ShowBalloonTip(10000)
            GridcoinAsiaTimer.Stop()
        ElseIf GridcoinAsiaRemaining > 0 Then
            GridcoinAsiaRemaining = GridcoinAsiaRemaining - TimeSpan.FromSeconds(1).TotalMilliseconds
            GridcoinAsiaTimeToShow = TimeSpan.FromMilliseconds(GridcoinAsiaRemaining)
            GridcoinAsiaText.ForeColor = Color.Red
            GridcoinAsiaText.Text = "You can use this faucet again in " & GridcoinAsiaTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & GridcoinAsiaTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & GridcoinAsiaTimeToShow.Seconds.ToString.PadLeft(2, "0"c)
        End If
    End Sub

    Private Sub EOBOTFaucetButton_Click(sender As Object, e As EventArgs) Handles EOBOTFaucetButton.Click
        If EOBOTReady = 1 Then
            EOBOTReady = 0
            EOBOTFaucetTimer.Interval = 1000
            EOBOTFaucetTimer.Enabled = True
            EOBOTTimeToShow = TimeSpan.FromMilliseconds(EOBOTRemaining)
            Process.Start("https://www.eobot.com/faucet")
        Else
            Dim Result As DialogResult = MessageBox.Show("You can use this faucet in " & EOBOTTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & EOBOTTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & EOBOTTimeToShow.Seconds.ToString.PadLeft(2, "0"c) & vbCrLf & "Do you want to visit this faucet anyway?", "Gridcoin Faucets", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                Process.Start("https://www.eobot.com/faucet")
            End If
        End If
    End Sub
    Private Sub EOBOTFaucetTimer_Tick(sender As Object, e As EventArgs) Handles EOBOTFaucetTimer.Tick
        If EOBOTRemaining = 0 Then
            EOBOTRemaining = EOBOTTotalTime
            EOBOTReady = 1
            EOBOTText.ForeColor = Color.Green
            EOBOTText.Text = "You can use this faucet now!"
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Gridcoin Faucets"
            NotifyIcon1.BalloonTipText = "You can now use EOBOT Faucet!"
            NotifyIcon1.ShowBalloonTip(10000)
            EOBOTFaucetTimer.Stop()
        ElseIf EOBOTRemaining > 0 Then
            EOBOTRemaining = EOBOTRemaining - TimeSpan.FromSeconds(1).TotalMilliseconds
            EOBOTTimeToShow = TimeSpan.FromMilliseconds(EOBOTRemaining)
            EOBOTText.ForeColor = Color.Red
            EOBOTText.Text = "You can use this faucet again in " & EOBOTTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & EOBOTTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & EOBOTTimeToShow.Seconds.ToString.PadLeft(2, "0"c)
        End If
    End Sub


    Private Sub GridcoinStatsButton_Click(sender As Object, e As EventArgs) Handles GridcoinStatsButton.Click
        If GridcoinStatsReady = 1 Then
            GridcoinStatsReady = 0
            GridcoinStatsTimer.Interval = 1000
            GridcoinStatsTimer.Enabled = True
            GridcoinStatsTimeToShow = TimeSpan.FromMilliseconds(GridcoinStatsRemaining)
            Process.Start("https://gridcoinstats.eu/faucet.php")
        Else
            Dim Result As DialogResult = MessageBox.Show("You can use this faucet in " & GridcoinStatsTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & GridcoinStatsTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & GridcoinStatsTimeToShow.Seconds.ToString.PadLeft(2, "0"c) & vbCrLf & "Do you want to visit this faucet anyway?", "Gridcoin Faucets", MessageBoxButtons.YesNo)
            If Result = DialogResult.Yes Then
                Process.Start("https://gridcoinstats.eu/faucet.php")
            End If
        End If
    End Sub
    Private Sub GridcoinStatsTimer_Tick(sender As Object, e As EventArgs) Handles GridcoinStatsTimer.Tick
        If GridcoinStatsRemaining = 0 Then
            GridcoinStatsRemaining = GridcoinStatsTotalTime
            GridcoinStatsReady = 1
            GridcoinStatsText.ForeColor = Color.Green
            GridcoinStatsText.Text = "You can use this faucet now!"
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Gridcoin Faucets"
            NotifyIcon1.BalloonTipText = "You can now use Gridcoin Stats Faucet!"
            NotifyIcon1.ShowBalloonTip(10000)
            GridcoinStatsTimer.Stop()
        ElseIf GridcoinStatsRemaining > 0 Then
            GridcoinStatsRemaining = GridcoinStatsRemaining - TimeSpan.FromSeconds(1).TotalMilliseconds
            GridcoinStatsTimeToShow = TimeSpan.FromMilliseconds(GridcoinStatsRemaining)
            GridcoinStatsText.ForeColor = Color.Red
            GridcoinStatsText.Text = "You can use this faucet again in " & GridcoinStatsTimeToShow.Hours.ToString.PadLeft(2, "0"c) & ":" & GridcoinStatsTimeToShow.Minutes.ToString.PadLeft(2, "0"c) & ":" & GridcoinStatsTimeToShow.Seconds.ToString.PadLeft(2, "0"c)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://moisescardona.me")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://gridcoinapp.xyz")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = My.Resources.favicon
        NotifyIcon1.Text = "Gridcoin Faucets"
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            If CheckBox1.Checked = True Then
                ShowInTaskbar = False
            End If
        Else
            ShowInTaskbar = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
    End Sub

End Class
