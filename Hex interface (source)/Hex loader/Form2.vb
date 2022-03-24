Public Class Form2

    Private Sub GunaCircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCircleButton1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub GunaCircleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCircleButton2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        SendKeys.Send(RedemptionTextBox1.Text)
        On Error Resume Next
        SendKeys.Send("{ENTER}")
    End Sub
End Class