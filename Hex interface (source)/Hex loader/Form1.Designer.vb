<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaResize1 = New Guna.UI.WinForms.GunaResize(Me.components)
        Me.Process1 = New System.Diagnostics.Process()
        Me.Process2 = New System.Diagnostics.Process()
        Me.Process3 = New System.Diagnostics.Process()
        Me.Process4 = New System.Diagnostics.Process()
        Me.Process5 = New System.Diagnostics.Process()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.RedemptionControlBox1 = New Hex_loader.RedemptionControlBox()
        Me.RedemptionTabControl1 = New Hex_loader.RedemptionTabControl()
        Me.Modules = New System.Windows.Forms.TabPage()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaSwitch1 = New Guna.UI.WinForms.GunaSwitch()
        Me.RedemptionTextBox1 = New Hex_loader.RedemptionTextBox()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaResizeControl3 = New Guna.UI.WinForms.GunaResizeControl()
        Me.Glua = New System.Windows.Forms.TabPage()
        Me.RedemptionLabel1 = New Hex_loader.RedemptionLabel()
        Me.GunaGauge1 = New Guna.UI.WinForms.GunaGauge()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaResizeControl2 = New Guna.UI.WinForms.GunaResizeControl()
        Me.Info = New System.Windows.Forms.TabPage()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.RedemptionLabel3 = New Hex_loader.RedemptionLabel()
        Me.RedemptionLabel2 = New Hex_loader.RedemptionLabel()
        Me.GunaResizeControl1 = New Guna.UI.WinForms.GunaResizeControl()
        Me.RedemptionForm1 = New Hex_loader.RedemptionForm()
        Me.RedemptionControlBox2 = New Hex_loader.RedemptionControlBox()
        Me.RedemptionTabControl2 = New Hex_loader.RedemptionTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.RedemptionTabControl1.SuspendLayout()
        Me.Modules.SuspendLayout()
        Me.Glua.SuspendLayout()
        Me.Info.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RedemptionForm1.SuspendLayout()
        Me.RedemptionTabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaResize1
        '
        Me.GunaResize1.TargetForm = Nothing
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.FileName = "C:\Windows\PLA\System\launch caesar.bat"
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Process2
        '
        Me.Process2.StartInfo.Domain = ""
        Me.Process2.StartInfo.FileName = "C:\Windows\PLA\System\Launch pass.bat"
        Me.Process2.StartInfo.LoadUserProfile = False
        Me.Process2.StartInfo.Password = Nothing
        Me.Process2.StartInfo.StandardErrorEncoding = Nothing
        Me.Process2.StartInfo.StandardOutputEncoding = Nothing
        Me.Process2.StartInfo.UserName = ""
        Me.Process2.SynchronizingObject = Me
        '
        'Process3
        '
        Me.Process3.StartInfo.Domain = ""
        Me.Process3.StartInfo.FileName = "C:\Windows\PLA\System\launch autoclick.bat"
        Me.Process3.StartInfo.LoadUserProfile = False
        Me.Process3.StartInfo.Password = Nothing
        Me.Process3.StartInfo.StandardErrorEncoding = Nothing
        Me.Process3.StartInfo.StandardOutputEncoding = Nothing
        Me.Process3.StartInfo.UserName = ""
        Me.Process3.SynchronizingObject = Me
        '
        'Process4
        '
        Me.Process4.StartInfo.Domain = ""
        Me.Process4.StartInfo.FileName = "C:\Windows\PLA\System\Mouse point.bat"
        Me.Process4.StartInfo.LoadUserProfile = False
        Me.Process4.StartInfo.Password = Nothing
        Me.Process4.StartInfo.StandardErrorEncoding = Nothing
        Me.Process4.StartInfo.StandardOutputEncoding = Nothing
        Me.Process4.StartInfo.UserName = ""
        Me.Process4.SynchronizingObject = Me
        '
        'Process5
        '
        Me.Process5.StartInfo.Domain = ""
        Me.Process5.StartInfo.FileName = "C:\Windows\PLA\System\launch subti.bat"
        Me.Process5.StartInfo.LoadUserProfile = False
        Me.Process5.StartInfo.Password = Nothing
        Me.Process5.StartInfo.StandardErrorEncoding = Nothing
        Me.Process5.StartInfo.StandardOutputEncoding = Nothing
        Me.Process5.StartInfo.UserName = ""
        Me.Process5.SynchronizingObject = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'RedemptionControlBox1
        '
        Me.RedemptionControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedemptionControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionControlBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionControlBox1.Location = New System.Drawing.Point(663, 1)
        Me.RedemptionControlBox1.Name = "RedemptionControlBox1"
        Me.RedemptionControlBox1.Size = New System.Drawing.Size(60, 25)
        Me.RedemptionControlBox1.TabIndex = 1
        Me.RedemptionControlBox1.Text = "RedemptionControlBox1"
        '
        'RedemptionTabControl1
        '
        Me.RedemptionTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.RedemptionTabControl1.BackgroundNoise = False
        Me.RedemptionTabControl1.Controls.Add(Me.Modules)
        Me.RedemptionTabControl1.Controls.Add(Me.Glua)
        Me.RedemptionTabControl1.Controls.Add(Me.Info)
        Me.RedemptionTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTabControl1.ItemSize = New System.Drawing.Size(35, 100)
        Me.RedemptionTabControl1.Location = New System.Drawing.Point(0, 28)
        Me.RedemptionTabControl1.Multiline = True
        Me.RedemptionTabControl1.Name = "RedemptionTabControl1"
        Me.RedemptionTabControl1.SelectedIndex = 0
        Me.RedemptionTabControl1.Size = New System.Drawing.Size(723, 466)
        Me.RedemptionTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.RedemptionTabControl1.TabIndex = 0
        Me.RedemptionTabControl1.TextAlign = Hex_loader.RedemptionTabControl.HorizontalAlignments.Left
        '
        'Modules
        '
        Me.Modules.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Modules.Controls.Add(Me.GunaLabel7)
        Me.Modules.Controls.Add(Me.GunaAdvenceButton2)
        Me.Modules.Controls.Add(Me.GunaLabel6)
        Me.Modules.Controls.Add(Me.GunaLabel5)
        Me.Modules.Controls.Add(Me.GunaLabel4)
        Me.Modules.Controls.Add(Me.GunaLabel3)
        Me.Modules.Controls.Add(Me.GunaLabel2)
        Me.Modules.Controls.Add(Me.GunaLabel1)
        Me.Modules.Controls.Add(Me.Label1)
        Me.Modules.Controls.Add(Me.GunaSwitch1)
        Me.Modules.Controls.Add(Me.RedemptionTextBox1)
        Me.Modules.Controls.Add(Me.GunaAdvenceButton5)
        Me.Modules.Controls.Add(Me.GunaAdvenceButton4)
        Me.Modules.Controls.Add(Me.GunaAdvenceButton3)
        Me.Modules.Controls.Add(Me.GunaAdvenceButton1)
        Me.Modules.Controls.Add(Me.GunaButton1)
        Me.Modules.Controls.Add(Me.GunaResizeControl3)
        Me.Modules.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Modules.Location = New System.Drawing.Point(104, 4)
        Me.Modules.Name = "Modules"
        Me.Modules.Size = New System.Drawing.Size(615, 458)
        Me.Modules.TabIndex = 1
        Me.Modules.Text = "Modules"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(435, 131)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel7.TabIndex = 19
        Me.GunaLabel7.Text = "."
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(0, 284)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(160, 42)
        Me.GunaAdvenceButton2.TabIndex = 18
        Me.GunaAdvenceButton2.Text = "Spam"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(435, 116)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel6.TabIndex = 17
        Me.GunaLabel6.Text = "."
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(435, 101)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel5.TabIndex = 16
        Me.GunaLabel5.Text = "."
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(435, 86)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel4.TabIndex = 15
        Me.GunaLabel4.Text = "."
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(435, 71)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel3.TabIndex = 14
        Me.GunaLabel3.Text = "."
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(435, 55)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "."
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(445, 55)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(0, 15)
        Me.GunaLabel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Logs"
        '
        'GunaSwitch1
        '
        Me.GunaSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaSwitch1.CheckedOffColor = System.Drawing.Color.Maroon
        Me.GunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaSwitch1.Location = New System.Drawing.Point(244, 306)
        Me.GunaSwitch1.Name = "GunaSwitch1"
        Me.GunaSwitch1.Size = New System.Drawing.Size(28, 20)
        Me.GunaSwitch1.TabIndex = 10
        '
        'RedemptionTextBox1
        '
        Me.RedemptionTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTextBox1.ForeColor = System.Drawing.Color.White
        Me.RedemptionTextBox1.Location = New System.Drawing.Point(429, 44)
        Me.RedemptionTextBox1.MaxLength = 32767
        Me.RedemptionTextBox1.MultiLine = False
        Me.RedemptionTextBox1.Name = "RedemptionTextBox1"
        Me.RedemptionTextBox1.Size = New System.Drawing.Size(190, 234)
        Me.RedemptionTextBox1.TabIndex = 9
        Me.RedemptionTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RedemptionTextBox1.UseSystemPasswordChar = False
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.Image = CType(resources.GetObject("GunaAdvenceButton5.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(0, 236)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(160, 42)
        Me.GunaAdvenceButton5.TabIndex = 7
        Me.GunaAdvenceButton5.Text = "Substitution"
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(0, 188)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(160, 42)
        Me.GunaAdvenceButton4.TabIndex = 6
        Me.GunaAdvenceButton4.Text = "Mouse point"
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(0, 92)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(160, 42)
        Me.GunaAdvenceButton3.TabIndex = 5
        Me.GunaAdvenceButton3.Text = "Password generator"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(0, 140)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaAdvenceButton1.TabIndex = 3
        Me.GunaAdvenceButton1.Text = "Autoclicker"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(0, 44)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "Caesar"
        '
        'GunaResizeControl3
        '
        Me.GunaResizeControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaResizeControl3.ForeColor = System.Drawing.Color.Maroon
        Me.GunaResizeControl3.ForeColorDepth = 255
        Me.GunaResizeControl3.Location = New System.Drawing.Point(599, 442)
        Me.GunaResizeControl3.Name = "GunaResizeControl3"
        Me.GunaResizeControl3.Size = New System.Drawing.Size(20, 20)
        Me.GunaResizeControl3.TabIndex = 0
        Me.GunaResizeControl3.TargetControl = Nothing
        '
        'Glua
        '
        Me.Glua.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Glua.Controls.Add(Me.RedemptionLabel1)
        Me.Glua.Controls.Add(Me.GunaGauge1)
        Me.Glua.Controls.Add(Me.GunaLinkLabel1)
        Me.Glua.Controls.Add(Me.GunaResizeControl2)
        Me.Glua.Location = New System.Drawing.Point(104, 4)
        Me.Glua.Name = "Glua"
        Me.Glua.Size = New System.Drawing.Size(615, 458)
        Me.Glua.TabIndex = 2
        Me.Glua.Text = "Glua"
        '
        'RedemptionLabel1
        '
        Me.RedemptionLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel1.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel1.Location = New System.Drawing.Point(439, 313)
        Me.RedemptionLabel1.Name = "RedemptionLabel1"
        Me.RedemptionLabel1.Size = New System.Drawing.Size(168, 23)
        Me.RedemptionLabel1.TabIndex = 3
        Me.RedemptionLabel1.Text = "Server saturation"
        '
        'GunaGauge1
        '
        Me.GunaGauge1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.GunaGauge1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaGauge1.Location = New System.Drawing.Point(433, 330)
        Me.GunaGauge1.Margin = New System.Windows.Forms.Padding(6)
        Me.GunaGauge1.MaximumColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGauge1.MinimumColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGauge1.Name = "GunaGauge1"
        Me.GunaGauge1.ShowText = True
        Me.GunaGauge1.Size = New System.Drawing.Size(174, 117)
        Me.GunaGauge1.TabIndex = 2
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(3, 442)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(81, 15)
        Me.GunaLinkLabel1.TabIndex = 1
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Website Panel"
        '
        'GunaResizeControl2
        '
        Me.GunaResizeControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaResizeControl2.ForeColor = System.Drawing.Color.Maroon
        Me.GunaResizeControl2.ForeColorDepth = 255
        Me.GunaResizeControl2.Location = New System.Drawing.Point(599, 442)
        Me.GunaResizeControl2.Name = "GunaResizeControl2"
        Me.GunaResizeControl2.Size = New System.Drawing.Size(20, 20)
        Me.GunaResizeControl2.TabIndex = 0
        Me.GunaResizeControl2.TargetControl = Nothing
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Info.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Info.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Info.Controls.Add(Me.RedemptionLabel3)
        Me.Info.Controls.Add(Me.RedemptionLabel2)
        Me.Info.Controls.Add(Me.GunaResizeControl1)
        Me.Info.Location = New System.Drawing.Point(104, 4)
        Me.Info.Name = "Info"
        Me.Info.Padding = New System.Windows.Forms.Padding(3)
        Me.Info.Size = New System.Drawing.Size(615, 458)
        Me.Info.TabIndex = 0
        Me.Info.Text = "Info"
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(0, 431)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 4
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(3, 344)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(85, 85)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 3
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'RedemptionLabel3
        '
        Me.RedemptionLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel3.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel3.Location = New System.Drawing.Point(0, 326)
        Me.RedemptionLabel3.Name = "RedemptionLabel3"
        Me.RedemptionLabel3.Size = New System.Drawing.Size(179, 23)
        Me.RedemptionLabel3.TabIndex = 2
        Me.RedemptionLabel3.Text = "By Zolty'CXX#0001"
        '
        'RedemptionLabel2
        '
        Me.RedemptionLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionLabel2.ForeColor = System.Drawing.Color.White
        Me.RedemptionLabel2.Location = New System.Drawing.Point(33, 435)
        Me.RedemptionLabel2.Name = "RedemptionLabel2"
        Me.RedemptionLabel2.Size = New System.Drawing.Size(75, 23)
        Me.RedemptionLabel2.TabIndex = 1
        Me.RedemptionLabel2.Text = "Hex v1.0"
        '
        'GunaResizeControl1
        '
        Me.GunaResizeControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaResizeControl1.ForeColor = System.Drawing.Color.Maroon
        Me.GunaResizeControl1.ForeColorDepth = 255
        Me.GunaResizeControl1.Location = New System.Drawing.Point(599, 442)
        Me.GunaResizeControl1.Name = "GunaResizeControl1"
        Me.GunaResizeControl1.Size = New System.Drawing.Size(20, 20)
        Me.GunaResizeControl1.TabIndex = 0
        Me.GunaResizeControl1.TargetControl = Nothing
        '
        'RedemptionForm1
        '
        Me.RedemptionForm1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RedemptionForm1.BackgroundNoise = True
        Me.RedemptionForm1.Controls.Add(Me.RedemptionTabControl2)
        Me.RedemptionForm1.Controls.Add(Me.RedemptionControlBox2)
        Me.RedemptionForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedemptionForm1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.RedemptionForm1.Location = New System.Drawing.Point(0, 0)
        Me.RedemptionForm1.Name = "RedemptionForm1"
        Me.RedemptionForm1.Size = New System.Drawing.Size(723, 494)
        Me.RedemptionForm1.TabIndex = 0
        Me.RedemptionForm1.Text = "Hex loader"
        '
        'RedemptionControlBox2
        '
        Me.RedemptionControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RedemptionControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.RedemptionControlBox2.ForeColor = System.Drawing.Color.White
        Me.RedemptionControlBox2.Location = New System.Drawing.Point(663, 3)
        Me.RedemptionControlBox2.Name = "RedemptionControlBox2"
        Me.RedemptionControlBox2.Size = New System.Drawing.Size(60, 25)
        Me.RedemptionControlBox2.TabIndex = 0
        Me.RedemptionControlBox2.Text = "RedemptionControlBox2"
        '
        'RedemptionTabControl2
        '
        Me.RedemptionTabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.RedemptionTabControl2.BackgroundNoise = False
        Me.RedemptionTabControl2.Controls.Add(Me.TabPage1)
        Me.RedemptionTabControl2.Controls.Add(Me.TabPage2)
        Me.RedemptionTabControl2.Controls.Add(Me.TabPage3)
        Me.RedemptionTabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RedemptionTabControl2.ItemSize = New System.Drawing.Size(35, 100)
        Me.RedemptionTabControl2.Location = New System.Drawing.Point(0, 28)
        Me.RedemptionTabControl2.Multiline = True
        Me.RedemptionTabControl2.Name = "RedemptionTabControl2"
        Me.RedemptionTabControl2.SelectedIndex = 0
        Me.RedemptionTabControl2.Size = New System.Drawing.Size(783, 511)
        Me.RedemptionTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.RedemptionTabControl2.TabIndex = 1
        Me.RedemptionTabControl2.TextAlign = Hex_loader.RedemptionTabControl.HorizontalAlignments.Left
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modules"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GunaLinkLabel2)
        Me.TabPage2.Location = New System.Drawing.Point(104, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(675, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Glua"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.GunaLabel9)
        Me.TabPage3.Controls.Add(Me.GunaLabel8)
        Me.TabPage3.Controls.Add(Me.GunaCirclePictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(675, 503)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Info"
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Image = CType(resources.GetObject("GunaCirclePictureBox3.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(0, 330)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(117, 114)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 0
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.Control
        Me.GunaLabel8.Location = New System.Drawing.Point(-3, 312)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(103, 15)
        Me.GunaLabel8.TabIndex = 1
        Me.GunaLabel8.Text = "By ""Zolty'Cxx#001"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Location = New System.Drawing.Point(-3, 447)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(52, 15)
        Me.GunaLabel9.TabIndex = 2
        Me.GunaLabel9.Text = "Hex v1.0"
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(3, 447)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(81, 15)
        Me.GunaLinkLabel2.TabIndex = 0
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "Website panel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 494)
        Me.Controls.Add(Me.RedemptionForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.RedemptionTabControl1.ResumeLayout(False)
        Me.Modules.ResumeLayout(False)
        Me.Modules.PerformLayout()
        Me.Glua.ResumeLayout(False)
        Me.Glua.PerformLayout()
        Me.Info.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RedemptionForm1.ResumeLayout(False)
        Me.RedemptionTabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RedemptionTabControl1 As Hex_loader.RedemptionTabControl
    Friend WithEvents Info As System.Windows.Forms.TabPage
    Friend WithEvents GunaResizeControl1 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents GunaResize1 As Guna.UI.WinForms.GunaResize
    Friend WithEvents RedemptionControlBox1 As Hex_loader.RedemptionControlBox
    Friend WithEvents Modules As System.Windows.Forms.TabPage
    Friend WithEvents GunaResizeControl3 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents Glua As System.Windows.Forms.TabPage
    Friend WithEvents GunaResizeControl2 As Guna.UI.WinForms.GunaResizeControl
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents RedemptionLabel1 As Hex_loader.RedemptionLabel
    Friend WithEvents GunaGauge1 As Guna.UI.WinForms.GunaGauge
    Friend WithEvents RedemptionTextBox1 As Hex_loader.RedemptionTextBox
    Friend WithEvents RedemptionLabel3 As Hex_loader.RedemptionLabel
    Friend WithEvents RedemptionLabel2 As Hex_loader.RedemptionLabel
    Friend WithEvents GunaSwitch1 As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents Process2 As System.Diagnostics.Process
    Friend WithEvents Process3 As System.Diagnostics.Process
    Friend WithEvents Process4 As System.Diagnostics.Process
    Friend WithEvents Process5 As System.Diagnostics.Process
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents RedemptionForm1 As Hex_loader.RedemptionForm
    Friend WithEvents RedemptionTabControl2 As Hex_loader.RedemptionTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RedemptionControlBox2 As Hex_loader.RedemptionControlBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel

End Class
