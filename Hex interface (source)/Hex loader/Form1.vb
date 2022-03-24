Public Class Form1

    Private Sub GunaResizeControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaResizeControl1.Click

    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Me.GunaLinkLabel1.Text = "https://ns1.serenityservers.org/Hex/"
        System.Diagnostics.Process.Start(Me.GunaLinkLabel1.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub RedemptionTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionTextBox1.Click

    End Sub

    Private Sub Modules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modules.Click

    End Sub

    Private Sub RedemptionCheckBox1_CheckedChanged(ByVal sender As System.Object)

    End Sub

    Private Sub GunaSwitch1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaSwitch1.CheckedChanged
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel2.Text = "Caesar started !"
        End If
        Process1.Start()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton3.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel3.Text = "Password generator started !"
        End If
        Process2.Start()
    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel4.Text = "Autoclicker started !"
        End If
        Process3.Start()
    End Sub

    Private Sub GunaAdvenceButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton4.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel5.Text = "Mouse point started !"
        End If
        Process4.Start()
    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GunaSwitch1.Checked = True Then
            GunaLabel5.Text = "Mouse point started !"
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton5.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel6.Text = "Substitution started !"
        End If
        Process5.Start()
    End Sub

    Private Sub RedemptionLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionLabel3.Click

    End Sub

    Private Sub GunaCirclePictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCirclePictureBox2.Click

    End Sub

    Private Sub GunaAdvenceButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        If GunaSwitch1.Checked = True Then
            GunaLabel7.Text = "Spam open !"
        End If
        Form2.Show()
    End Sub

    Private Sub RedemptionForm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedemptionForm1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        Me.GunaLinkLabel1.Text = "https://ns1.serenityservers.org/Hex/"
        System.Diagnostics.Process.Start(Me.GunaLinkLabel1.Text)
    End Sub
End Class
