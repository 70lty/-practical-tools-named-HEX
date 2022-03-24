<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RedemptionForm1 = New Hex_loader.RedemptionForm()
        Me.RedemptionControlBox1 = New Hex_loader.RedemptionControlBox()
        Me.RedemptionTabControl1 = New Hex_loader.RedemptionTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.RedemptionTextBox1 = New Hex_loader.RedemptionTextBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.RedemptionForm1.SuspendLayout()
        Me.RedemptionTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'RedemptionForm1
        '
        Me.RedemptionForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RedemptionForm1.BackgroundNoise = True
        Me.RedemptionForm1.Controls.Add(Me.RedemptionControlBox1)
        Me.RedemptionForm1.Controls.Add(Me.RedemptionTabControl1)
        Me.RedemptionForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedemptionForm1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.RedemptionForm1.Location = New System.Drawing.Point(0, 0)
        Me.RedemptionForm1.Name = "RedemptionForm1"
        Me.RedemptionForm1.Size = New System.Drawing.Size(580, 235)
        Me.RedemptionForm1.TabIndex = 0
        Me.RedemptionForm1.Text = "Hex loader"
        '
        'RedemptionControlBox1
        '
        Me.RedemptionControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedemptionControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionControlBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionControlBox1.Location = New System.Drawing.Point(520, 1)
        Me.RedemptionControlBox1.Name = "RedemptionControlBox1"
        Me.RedemptionControlBox1.Size = New System.Drawing.Size(60, 25)
        Me.RedemptionControlBox1.TabIndex = 2
        Me.RedemptionControlBox1.Text = "RedemptionControlBox1"
        '
        'RedemptionTabControl1
        '
        Me.RedemptionTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.RedemptionTabControl1.BackgroundNoise = False
        Me.RedemptionTabControl1.Controls.Add(Me.TabPage1)
        Me.RedemptionTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.RedemptionTabControl1.Location = New System.Drawing.Point(0, 28)
        Me.RedemptionTabControl1.Multiline = True
        Me.RedemptionTabControl1.Name = "RedemptionTabControl1"
        Me.RedemptionTabControl1.SelectedIndex = 0
        Me.RedemptionTabControl1.Size = New System.Drawing.Size(645, 234)
        Me.RedemptionTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.RedemptionTabControl1.TabIndex = 0
        Me.RedemptionTabControl1.TextAlign = Hex_loader.RedemptionTabControl.HorizontalAlignments.Left
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GunaCircleButton2)
        Me.TabPage1.Controls.Add(Me.RedemptionTextBox1)
        Me.TabPage1.Controls.Add(Me.GunaCircleButton1)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(537, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Spam"
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Nothing
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(70, 0)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton2.Size = New System.Drawing.Size(61, 59)
        Me.GunaCircleButton2.TabIndex = 2
        Me.GunaCircleButton2.Text = "Stop"
        '
        'RedemptionTextBox1
        '
        Me.RedemptionTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTextBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionTextBox1.Location = New System.Drawing.Point(3, 65)
        Me.RedemptionTextBox1.MaxLength = 32767
        Me.RedemptionTextBox1.MultiLine = False
        Me.RedemptionTextBox1.Name = "RedemptionTextBox1"
        Me.RedemptionTextBox1.Size = New System.Drawing.Size(135, 24)
        Me.RedemptionTextBox1.TabIndex = 1
        Me.RedemptionTextBox1.Text = "Enter text here"
        Me.RedemptionTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RedemptionTextBox1.UseSystemPasswordChar = False
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(3, 0)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(61, 59)
        Me.GunaCircleButton1.TabIndex = 0
        Me.GunaCircleButton1.Text = "Start"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 235)
        Me.Controls.Add(Me.RedemptionForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Hex loader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.RedemptionForm1.ResumeLayout(False)
        Me.RedemptionTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RedemptionForm1 As Hex_loader.RedemptionForm
    Friend WithEvents RedemptionTabControl1 As Hex_loader.RedemptionTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents RedemptionTextBox1 As Hex_loader.RedemptionTextBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RedemptionControlBox1 As Hex_loader.RedemptionControlBox
End Class
