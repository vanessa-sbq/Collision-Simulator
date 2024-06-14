<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pbCarro1 = New PictureBox()
        pbCarro2 = New PictureBox()
        Label1 = New Label()
        btnstart = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnreset = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        rbVelocidade = New RadioButton()
        rbMomentoLinear = New RadioButton()
        rbEnergiaCinetica = New RadioButton()
        CamLenta = New CheckBox()
        lblVinicial1 = New Label()
        lblVfinal1 = New Label()
        lblVinicial2 = New Label()
        lblVfinal2 = New Label()
        PictureBox3 = New PictureBox()
        pbSetaVermelha = New PictureBox()
        PictureBox4 = New PictureBox()
        pbSetaAzul = New PictureBox()
        PictureBox1 = New PictureBox()
        lblPfinal1 = New Label()
        lblPinicial1 = New Label()
        lblPinicial2 = New Label()
        lblPfinal2 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        lblPinicial_total = New Label()
        lblPfinal_total = New Label()
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        GroupBox3 = New GroupBox()
        nuVelocidade2 = New NumericUpDown()
        nuMassa2 = New NumericUpDown()
        nuVelocidade1 = New NumericUpDown()
        nuMassa1 = New NumericUpDown()
        Label18 = New Label()
        nuCoRest = New NumericUpDown()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        pbMomentoLinearTotal_ = New PictureBox()
        pbMomentoLinearTotal = New PictureBox()
        pbSetaPreta = New PictureBox()
        pbSetaPreta_ = New PictureBox()
        pbSetaVermelha_ = New PictureBox()
        PictureBox5 = New PictureBox()
        pbSetaAzul_ = New PictureBox()
        PictureBox6 = New PictureBox()
        lblEnergiaC1 = New Label()
        lblEnergiaC2 = New Label()
        lblEnergiaC1_ = New Label()
        lblEnergiaC2_ = New Label()
        Label28 = New Label()
        Label29 = New Label()
        pbSetaVermelhaNeg_ = New PictureBox()
        lblEnergcin_total1 = New Label()
        Label24 = New Label()
        lblEnergcin_total2 = New Label()
        Label26 = New Label()
        pbSetaAzulNeg_ = New PictureBox()
        pbSetaPretaNeg_ = New PictureBox()
        pbSetaPretaNeg = New PictureBox()
        lblVermelho = New Label()
        lblAzul = New Label()
        lblAmarelo = New Label()
        lblAmarelo_ = New Label()
        lblAzul_ = New Label()
        lblVermelho_ = New Label()
        PictureBoxExtraAzul = New PictureBox()
        PictureBoxExtraVermelho = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(pbCarro1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbCarro2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaVermelha, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaAzul, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(nuVelocidade2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nuMassa2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nuVelocidade1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nuMassa1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nuCoRest, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMomentoLinearTotal_, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMomentoLinearTotal, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaPreta, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaPreta_, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaVermelha_, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaAzul_, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaVermelhaNeg_, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaAzulNeg_, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaPretaNeg_, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSetaPretaNeg, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxExtraAzul, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxExtraVermelho, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbCarro1
        ' 
        pbCarro1.BackgroundImage = My.Resources.Resources.Red_circle
        pbCarro1.BackgroundImageLayout = ImageLayout.Stretch
        pbCarro1.Location = New Point(53, 349)
        pbCarro1.Margin = New Padding(4)
        pbCarro1.Name = "pbCarro1"
        pbCarro1.Size = New Size(54, 54)
        pbCarro1.TabIndex = 0
        pbCarro1.TabStop = False
        ' 
        ' pbCarro2
        ' 
        pbCarro2.BackgroundImage = My.Resources.Resources.Pan_Blue_Circle
        pbCarro2.BackgroundImageLayout = ImageLayout.Stretch
        pbCarro2.Location = New Point(700, 349)
        pbCarro2.Margin = New Padding(4)
        pbCarro2.Name = "pbCarro2"
        pbCarro2.Size = New Size(54, 54)
        pbCarro2.TabIndex = 1
        pbCarro2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 38)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 30)
        Label1.TabIndex = 2
        Label1.Text = "Velocidade antes do choque:"
        ' 
        ' btnstart
        ' 
        btnstart.BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(0))
        btnstart.Location = New Point(34, 91)
        btnstart.Margin = New Padding(4)
        btnstart.Name = "btnstart"
        btnstart.Size = New Size(366, 41)
        btnstart.TabIndex = 6
        btnstart.Text = "Start"
        btnstart.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(43, 119)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 30)
        Label2.TabIndex = 4
        Label2.Text = "Corpo 1:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(389, 119)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 30)
        Label3.TabIndex = 5
        Label3.Text = "Corpo 2:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 450)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(262, 30)
        Label4.TabIndex = 6
        Label4.Text = "Velocidade após o choque:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(47, 536)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 30)
        Label5.TabIndex = 7
        Label5.Text = "Corpo 1:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Blue
        Label6.Location = New Point(414, 534)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 30)
        Label6.TabIndex = 8
        Label6.Text = "Corpo 2:"
        ' 
        ' btnreset
        ' 
        btnreset.BackColor = Color.Cyan
        btnreset.Location = New Point(34, 43)
        btnreset.Margin = New Padding(4)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(366, 41)
        btnreset.TabIndex = 5
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(30, 296)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 30)
        Label7.TabIndex = 14
        Label7.Text = "Corpo 1:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(31, 341)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 30)
        Label8.TabIndex = 15
        Label8.Text = "Massa:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(30, 382)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 30)
        Label9.TabIndex = 16
        Label9.Text = "Velocidade:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.Blue
        Label10.Location = New Point(31, 451)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 30)
        Label10.TabIndex = 17
        Label10.Text = "Corpo 2:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.Blue
        Label11.Location = New Point(31, 487)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 30)
        Label11.TabIndex = 18
        Label11.Text = "Massa:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.Blue
        Label12.Location = New Point(31, 524)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 30)
        Label12.TabIndex = 19
        Label12.Text = "Velocidade:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbVelocidade)
        GroupBox2.Controls.Add(rbMomentoLinear)
        GroupBox2.Controls.Add(rbEnergiaCinetica)
        GroupBox2.Location = New Point(31, 575)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(220, 161)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        ' 
        ' rbVelocidade
        ' 
        rbVelocidade.AutoSize = True
        rbVelocidade.Checked = True
        rbVelocidade.Location = New Point(7, 28)
        rbVelocidade.Margin = New Padding(4)
        rbVelocidade.Name = "rbVelocidade"
        rbVelocidade.Size = New Size(139, 34)
        rbVelocidade.TabIndex = 2
        rbVelocidade.TabStop = True
        rbVelocidade.Text = "Velocidade"
        rbVelocidade.UseVisualStyleBackColor = True
        ' 
        ' rbMomentoLinear
        ' 
        rbMomentoLinear.AutoSize = True
        rbMomentoLinear.Location = New Point(7, 70)
        rbMomentoLinear.Margin = New Padding(4)
        rbMomentoLinear.Name = "rbMomentoLinear"
        rbMomentoLinear.Size = New Size(186, 34)
        rbMomentoLinear.TabIndex = 3
        rbMomentoLinear.Text = "Momento linear"
        rbMomentoLinear.UseVisualStyleBackColor = True
        ' 
        ' rbEnergiaCinetica
        ' 
        rbEnergiaCinetica.AutoSize = True
        rbEnergiaCinetica.Location = New Point(7, 112)
        rbEnergiaCinetica.Margin = New Padding(4)
        rbEnergiaCinetica.Name = "rbEnergiaCinetica"
        rbEnergiaCinetica.Size = New Size(184, 34)
        rbEnergiaCinetica.TabIndex = 4
        rbEnergiaCinetica.Text = "Energia cinética"
        rbEnergiaCinetica.UseVisualStyleBackColor = True
        ' 
        ' CamLenta
        ' 
        CamLenta.AutoSize = True
        CamLenta.Location = New Point(34, 157)
        CamLenta.Margin = New Padding(4)
        CamLenta.Name = "CamLenta"
        CamLenta.Size = New Size(162, 34)
        CamLenta.TabIndex = 22
        CamLenta.Text = "Câmara lenta"
        CamLenta.UseVisualStyleBackColor = True
        ' 
        ' lblVinicial1
        ' 
        lblVinicial1.AutoSize = True
        lblVinicial1.ForeColor = Color.Red
        lblVinicial1.Location = New Point(139, 119)
        lblVinicial1.Margin = New Padding(4, 0, 4, 0)
        lblVinicial1.Name = "lblVinicial1"
        lblVinicial1.Size = New Size(112, 30)
        lblVinicial1.TabIndex = 23
        lblVinicial1.Text = "lblVinicial1"
        ' 
        ' lblVfinal1
        ' 
        lblVfinal1.AutoSize = True
        lblVfinal1.ForeColor = Color.Red
        lblVfinal1.Location = New Point(134, 534)
        lblVfinal1.Margin = New Padding(4, 0, 4, 0)
        lblVfinal1.Name = "lblVfinal1"
        lblVfinal1.Size = New Size(99, 30)
        lblVfinal1.TabIndex = 24
        lblVfinal1.Text = "lblVfinal1"
        ' 
        ' lblVinicial2
        ' 
        lblVinicial2.AutoSize = True
        lblVinicial2.ForeColor = Color.Blue
        lblVinicial2.Location = New Point(485, 119)
        lblVinicial2.Margin = New Padding(4, 0, 4, 0)
        lblVinicial2.Name = "lblVinicial2"
        lblVinicial2.Size = New Size(112, 30)
        lblVinicial2.TabIndex = 25
        lblVinicial2.Text = "lblVinicial2"
        ' 
        ' lblVfinal2
        ' 
        lblVfinal2.AutoSize = True
        lblVfinal2.ForeColor = Color.Blue
        lblVfinal2.Location = New Point(505, 534)
        lblVfinal2.Margin = New Padding(4, 0, 4, 0)
        lblVfinal2.Name = "lblVfinal2"
        lblVfinal2.Size = New Size(99, 30)
        lblVfinal2.TabIndex = 26
        lblVfinal2.Text = "lblVfinal2"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__4_
        PictureBox3.Location = New Point(43, 80)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(154, 35)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 28
        PictureBox3.TabStop = False
        ' 
        ' pbSetaVermelha
        ' 
        pbSetaVermelha.Image = My.Resources.Resources.png_red_arrow_67905___Cópia1
        pbSetaVermelha.Location = New Point(43, 80)
        pbSetaVermelha.Margin = New Padding(4)
        pbSetaVermelha.Name = "pbSetaVermelha"
        pbSetaVermelha.Size = New Size(154, 35)
        pbSetaVermelha.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaVermelha.TabIndex = 29
        pbSetaVermelha.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__2____Cópia___Cópia
        PictureBox4.Location = New Point(464, 80)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(154, 35)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 30
        PictureBox4.TabStop = False
        ' 
        ' pbSetaAzul
        ' 
        pbSetaAzul.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia___Cópia
        pbSetaAzul.Location = New Point(464, 80)
        pbSetaAzul.Margin = New Padding(4)
        pbSetaAzul.Name = "pbSetaAzul"
        pbSetaAzul.Size = New Size(154, 35)
        pbSetaAzul.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaAzul.TabIndex = 31
        pbSetaAzul.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Black_line2
        PictureBox1.Location = New Point(-3, 402)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(817, 19)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' lblPfinal1
        ' 
        lblPfinal1.AutoSize = True
        lblPfinal1.ForeColor = Color.Red
        lblPfinal1.Location = New Point(138, 536)
        lblPfinal1.Margin = New Padding(4, 0, 4, 0)
        lblPfinal1.Name = "lblPfinal1"
        lblPfinal1.Size = New Size(98, 30)
        lblPfinal1.TabIndex = 34
        lblPfinal1.Text = "lblPfinal1"
        ' 
        ' lblPinicial1
        ' 
        lblPinicial1.AutoSize = True
        lblPinicial1.ForeColor = Color.Red
        lblPinicial1.Location = New Point(140, 119)
        lblPinicial1.Margin = New Padding(4, 0, 4, 0)
        lblPinicial1.Name = "lblPinicial1"
        lblPinicial1.Size = New Size(111, 30)
        lblPinicial1.TabIndex = 35
        lblPinicial1.Text = "lblPinicial1"
        ' 
        ' lblPinicial2
        ' 
        lblPinicial2.AutoSize = True
        lblPinicial2.ForeColor = Color.Blue
        lblPinicial2.Location = New Point(486, 119)
        lblPinicial2.Margin = New Padding(4, 0, 4, 0)
        lblPinicial2.Name = "lblPinicial2"
        lblPinicial2.Size = New Size(111, 30)
        lblPinicial2.TabIndex = 36
        lblPinicial2.Text = "lblPinicial2"
        ' 
        ' lblPfinal2
        ' 
        lblPfinal2.AutoSize = True
        lblPfinal2.ForeColor = Color.Blue
        lblPfinal2.Location = New Point(506, 534)
        lblPfinal2.Margin = New Padding(4, 0, 4, 0)
        lblPfinal2.Name = "lblPfinal2"
        lblPfinal2.Size = New Size(98, 30)
        lblPfinal2.TabIndex = 37
        lblPfinal2.Text = "lblPfinal2"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(137, 228)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(214, 30)
        Label13.TabIndex = 38
        Label13.Text = "Momento linear total:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(127, 677)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(214, 30)
        Label14.TabIndex = 39
        Label14.Text = "Momento linear total:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(43, 38)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(327, 30)
        Label15.TabIndex = 40
        Label15.Text = "Momento linear antes do choque:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(47, 454)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(309, 30)
        Label16.TabIndex = 41
        Label16.Text = "Momento linear após o choque:"
        ' 
        ' lblPinicial_total
        ' 
        lblPinicial_total.AutoSize = True
        lblPinicial_total.Location = New Point(365, 228)
        lblPinicial_total.Margin = New Padding(4, 0, 4, 0)
        lblPinicial_total.Name = "lblPinicial_total"
        lblPinicial_total.Size = New Size(151, 30)
        lblPinicial_total.TabIndex = 42
        lblPinicial_total.Text = "lblPinicial_total"
        ' 
        ' lblPfinal_total
        ' 
        lblPfinal_total.AutoSize = True
        lblPfinal_total.Location = New Point(362, 677)
        lblPfinal_total.Margin = New Padding(4, 0, 4, 0)
        lblPfinal_total.Name = "lblPfinal_total"
        lblPfinal_total.Size = New Size(138, 30)
        lblPfinal_total.TabIndex = 43
        lblPfinal_total.Text = "lblPfinal_total"
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 1
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Lime
        GroupBox3.Controls.Add(nuVelocidade2)
        GroupBox3.Controls.Add(nuMassa2)
        GroupBox3.Controls.Add(nuVelocidade1)
        GroupBox3.Controls.Add(nuMassa1)
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(nuCoRest)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(Label22)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(btnstart)
        GroupBox3.Controls.Add(btnreset)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(CamLenta)
        GroupBox3.Location = New Point(802, -16)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(434, 794)
        GroupBox3.TabIndex = 45
        GroupBox3.TabStop = False
        ' 
        ' nuVelocidade2
        ' 
        nuVelocidade2.DecimalPlaces = 1
        nuVelocidade2.ForeColor = Color.Blue
        nuVelocidade2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        nuVelocidade2.Location = New Point(161, 529)
        nuVelocidade2.Margin = New Padding(4)
        nuVelocidade2.Maximum = New Decimal(New Integer() {0, 0, 0, -2147418112})
        nuVelocidade2.Minimum = New Decimal(New Integer() {1, 0, 0, Integer.MinValue})
        nuVelocidade2.Name = "nuVelocidade2"
        nuVelocidade2.Size = New Size(181, 35)
        nuVelocidade2.TabIndex = 67
        nuVelocidade2.TextAlign = HorizontalAlignment.Center
        nuVelocidade2.Value = New Decimal(New Integer() {1, 0, 0, -2147418112})
        ' 
        ' nuMassa2
        ' 
        nuMassa2.DecimalPlaces = 1
        nuMassa2.ForeColor = Color.Blue
        nuMassa2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        nuMassa2.Location = New Point(160, 485)
        nuMassa2.Margin = New Padding(4)
        nuMassa2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        nuMassa2.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        nuMassa2.Name = "nuMassa2"
        nuMassa2.Size = New Size(181, 35)
        nuMassa2.TabIndex = 66
        nuMassa2.TextAlign = HorizontalAlignment.Center
        nuMassa2.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        ' 
        ' nuVelocidade1
        ' 
        nuVelocidade1.DecimalPlaces = 1
        nuVelocidade1.ForeColor = Color.Red
        nuVelocidade1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        nuVelocidade1.Location = New Point(160, 374)
        nuVelocidade1.Margin = New Padding(4)
        nuVelocidade1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        nuVelocidade1.Name = "nuVelocidade1"
        nuVelocidade1.Size = New Size(181, 35)
        nuVelocidade1.TabIndex = 65
        nuVelocidade1.TextAlign = HorizontalAlignment.Center
        nuVelocidade1.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        ' 
        ' nuMassa1
        ' 
        nuMassa1.DecimalPlaces = 1
        nuMassa1.ForeColor = Color.Red
        nuMassa1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        nuMassa1.Location = New Point(160, 334)
        nuMassa1.Margin = New Padding(4)
        nuMassa1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        nuMassa1.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        nuMassa1.Name = "nuMassa1"
        nuMassa1.Size = New Size(181, 35)
        nuMassa1.TabIndex = 64
        nuMassa1.TextAlign = HorizontalAlignment.Center
        nuMassa1.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        ' 
        ' Label18
        ' 
        Label18.Location = New Point(34, 209)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(169, 68)
        Label18.TabIndex = 63
        Label18.Text = "Coeficiente de restituição:"
        ' 
        ' nuCoRest
        ' 
        nuCoRest.DecimalPlaces = 1
        nuCoRest.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        nuCoRest.Location = New Point(199, 229)
        nuCoRest.Margin = New Padding(4)
        nuCoRest.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        nuCoRest.Name = "nuCoRest"
        nuCoRest.Size = New Size(106, 35)
        nuCoRest.TabIndex = 27
        nuCoRest.TextAlign = HorizontalAlignment.Center
        nuCoRest.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.ForeColor = Color.Blue
        Label23.Location = New Point(348, 524)
        Label23.Margin = New Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(48, 30)
        Label23.TabIndex = 26
        Label23.Text = "m/s"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.ForeColor = Color.Blue
        Label22.Location = New Point(348, 480)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(35, 30)
        Label22.TabIndex = 25
        Label22.Text = "kg"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.ForeColor = Color.Red
        Label21.Location = New Point(348, 382)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(48, 30)
        Label21.TabIndex = 24
        Label21.Text = "m/s"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.ForeColor = Color.Red
        Label20.Location = New Point(348, 338)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(35, 30)
        Label20.TabIndex = 23
        Label20.Text = "kg"
        ' 
        ' pbMomentoLinearTotal_
        ' 
        pbMomentoLinearTotal_.Image = My.Resources.Resources.png_red_arrow_67905__Neg1
        pbMomentoLinearTotal_.Location = New Point(288, 589)
        pbMomentoLinearTotal_.Margin = New Padding(4)
        pbMomentoLinearTotal_.Name = "pbMomentoLinearTotal_"
        pbMomentoLinearTotal_.Size = New Size(157, 35)
        pbMomentoLinearTotal_.SizeMode = PictureBoxSizeMode.StretchImage
        pbMomentoLinearTotal_.TabIndex = 49
        pbMomentoLinearTotal_.TabStop = False
        ' 
        ' pbMomentoLinearTotal
        ' 
        pbMomentoLinearTotal.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__3_
        pbMomentoLinearTotal.Location = New Point(296, 178)
        pbMomentoLinearTotal.Margin = New Padding(4)
        pbMomentoLinearTotal.Name = "pbMomentoLinearTotal"
        pbMomentoLinearTotal.Size = New Size(157, 35)
        pbMomentoLinearTotal.SizeMode = PictureBoxSizeMode.StretchImage
        pbMomentoLinearTotal.TabIndex = 50
        pbMomentoLinearTotal.TabStop = False
        ' 
        ' pbSetaPreta
        ' 
        pbSetaPreta.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia__2_
        pbSetaPreta.Location = New Point(296, 178)
        pbSetaPreta.Margin = New Padding(4)
        pbSetaPreta.Name = "pbSetaPreta"
        pbSetaPreta.Size = New Size(157, 35)
        pbSetaPreta.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaPreta.TabIndex = 51
        pbSetaPreta.TabStop = False
        ' 
        ' pbSetaPreta_
        ' 
        pbSetaPreta_.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia__2_
        pbSetaPreta_.Location = New Point(288, 589)
        pbSetaPreta_.Margin = New Padding(4)
        pbSetaPreta_.Name = "pbSetaPreta_"
        pbSetaPreta_.Size = New Size(157, 35)
        pbSetaPreta_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaPreta_.TabIndex = 52
        pbSetaPreta_.TabStop = False
        ' 
        ' pbSetaVermelha_
        ' 
        pbSetaVermelha_.Image = My.Resources.Resources.png_red_arrow_67905___Cópia1
        pbSetaVermelha_.Location = New Point(47, 496)
        pbSetaVermelha_.Margin = New Padding(4)
        pbSetaVermelha_.Name = "pbSetaVermelha_"
        pbSetaVermelha_.Size = New Size(154, 35)
        pbSetaVermelha_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaVermelha_.TabIndex = 54
        pbSetaVermelha_.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__4_
        PictureBox5.Location = New Point(47, 496)
        PictureBox5.Margin = New Padding(4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(154, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 53
        PictureBox5.TabStop = False
        ' 
        ' pbSetaAzul_
        ' 
        pbSetaAzul_.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia
        pbSetaAzul_.Location = New Point(464, 496)
        pbSetaAzul_.Margin = New Padding(4)
        pbSetaAzul_.Name = "pbSetaAzul_"
        pbSetaAzul_.Size = New Size(154, 35)
        pbSetaAzul_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaAzul_.TabIndex = 56
        pbSetaAzul_.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__2____Cópia___Cópia
        PictureBox6.InitialImage = My.Resources.Resources.png_red_arrow_67905___Cópia__2____Cópia___Cópia
        PictureBox6.Location = New Point(464, 496)
        PictureBox6.Margin = New Padding(4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(154, 35)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 55
        PictureBox6.TabStop = False
        ' 
        ' lblEnergiaC1
        ' 
        lblEnergiaC1.AutoSize = True
        lblEnergiaC1.ForeColor = Color.Red
        lblEnergiaC1.Location = New Point(140, 119)
        lblEnergiaC1.Margin = New Padding(4, 0, 4, 0)
        lblEnergiaC1.Name = "lblEnergiaC1"
        lblEnergiaC1.Size = New Size(84, 30)
        lblEnergiaC1.TabIndex = 57
        lblEnergiaC1.Text = "Label24"
        ' 
        ' lblEnergiaC2
        ' 
        lblEnergiaC2.AutoSize = True
        lblEnergiaC2.ForeColor = Color.Blue
        lblEnergiaC2.Location = New Point(486, 119)
        lblEnergiaC2.Margin = New Padding(4, 0, 4, 0)
        lblEnergiaC2.Name = "lblEnergiaC2"
        lblEnergiaC2.Size = New Size(84, 30)
        lblEnergiaC2.TabIndex = 58
        lblEnergiaC2.Text = "Label25"
        ' 
        ' lblEnergiaC1_
        ' 
        lblEnergiaC1_.AutoSize = True
        lblEnergiaC1_.ForeColor = Color.Red
        lblEnergiaC1_.Location = New Point(140, 534)
        lblEnergiaC1_.Margin = New Padding(4, 0, 4, 0)
        lblEnergiaC1_.Name = "lblEnergiaC1_"
        lblEnergiaC1_.Size = New Size(84, 30)
        lblEnergiaC1_.TabIndex = 59
        lblEnergiaC1_.Text = "Label26"
        ' 
        ' lblEnergiaC2_
        ' 
        lblEnergiaC2_.AutoSize = True
        lblEnergiaC2_.ForeColor = Color.Blue
        lblEnergiaC2_.Location = New Point(511, 534)
        lblEnergiaC2_.Margin = New Padding(4, 0, 4, 0)
        lblEnergiaC2_.Name = "lblEnergiaC2_"
        lblEnergiaC2_.Size = New Size(84, 30)
        lblEnergiaC2_.TabIndex = 60
        lblEnergiaC2_.Text = "Label27"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(43, 43)
        Label28.Margin = New Padding(4, 0, 4, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(325, 30)
        Label28.TabIndex = 61
        Label28.Text = "Energia cinética antes do choque:"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(53, 450)
        Label29.Margin = New Padding(4, 0, 4, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(307, 30)
        Label29.TabIndex = 62
        Label29.Text = "Energia cinética após o choque:"
        ' 
        ' pbSetaVermelhaNeg_
        ' 
        pbSetaVermelhaNeg_.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia__3_
        pbSetaVermelhaNeg_.Location = New Point(47, 496)
        pbSetaVermelhaNeg_.Margin = New Padding(4)
        pbSetaVermelhaNeg_.Name = "pbSetaVermelhaNeg_"
        pbSetaVermelhaNeg_.Size = New Size(154, 35)
        pbSetaVermelhaNeg_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaVermelhaNeg_.TabIndex = 64
        pbSetaVermelhaNeg_.TabStop = False
        ' 
        ' lblEnergcin_total1
        ' 
        lblEnergcin_total1.AutoSize = True
        lblEnergcin_total1.Location = New Point(365, 228)
        lblEnergcin_total1.Margin = New Padding(4, 0, 4, 0)
        lblEnergcin_total1.Name = "lblEnergcin_total1"
        lblEnergcin_total1.Size = New Size(177, 30)
        lblEnergcin_total1.TabIndex = 66
        lblEnergcin_total1.Text = "lblEnergcin_total1"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(127, 228)
        Label24.Margin = New Padding(4, 0, 4, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(212, 30)
        Label24.TabIndex = 65
        Label24.Text = "Energia cinética total:"
        ' 
        ' lblEnergcin_total2
        ' 
        lblEnergcin_total2.AutoSize = True
        lblEnergcin_total2.Location = New Point(354, 677)
        lblEnergcin_total2.Margin = New Padding(4, 0, 4, 0)
        lblEnergcin_total2.Name = "lblEnergcin_total2"
        lblEnergcin_total2.Size = New Size(177, 30)
        lblEnergcin_total2.TabIndex = 68
        lblEnergcin_total2.Text = "lblEnergcin_total2"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(138, 677)
        Label26.Margin = New Padding(4, 0, 4, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(212, 30)
        Label26.TabIndex = 67
        Label26.Text = "Energia cinética total:"
        ' 
        ' pbSetaAzulNeg_
        ' 
        pbSetaAzulNeg_.Image = My.Resources.Resources.png_red_arrow_67905___Cópia___Cópia___Cópia
        pbSetaAzulNeg_.Location = New Point(464, 496)
        pbSetaAzulNeg_.Margin = New Padding(4)
        pbSetaAzulNeg_.Name = "pbSetaAzulNeg_"
        pbSetaAzulNeg_.Size = New Size(154, 35)
        pbSetaAzulNeg_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaAzulNeg_.TabIndex = 69
        pbSetaAzulNeg_.TabStop = False
        ' 
        ' pbSetaPretaNeg_
        ' 
        pbSetaPretaNeg_.Image = My.Resources.Resources.png_red_arrow_67905__Neg
        pbSetaPretaNeg_.Location = New Point(288, 589)
        pbSetaPretaNeg_.Margin = New Padding(4)
        pbSetaPretaNeg_.Name = "pbSetaPretaNeg_"
        pbSetaPretaNeg_.Size = New Size(157, 35)
        pbSetaPretaNeg_.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaPretaNeg_.TabIndex = 70
        pbSetaPretaNeg_.TabStop = False
        ' 
        ' pbSetaPretaNeg
        ' 
        pbSetaPretaNeg.Image = My.Resources.Resources.png_red_arrow_67905__Neg
        pbSetaPretaNeg.Location = New Point(296, 178)
        pbSetaPretaNeg.Margin = New Padding(4)
        pbSetaPretaNeg.Name = "pbSetaPretaNeg"
        pbSetaPretaNeg.Size = New Size(157, 35)
        pbSetaPretaNeg.SizeMode = PictureBoxSizeMode.StretchImage
        pbSetaPretaNeg.TabIndex = 72
        pbSetaPretaNeg.TabStop = False
        ' 
        ' lblVermelho
        ' 
        lblVermelho.BackColor = Color.Red
        lblVermelho.BorderStyle = BorderStyle.FixedSingle
        lblVermelho.ForeColor = Color.Gray
        lblVermelho.Location = New Point(149, 178)
        lblVermelho.Margin = New Padding(4, 0, 4, 0)
        lblVermelho.Name = "lblVermelho"
        lblVermelho.Size = New Size(90, 36)
        lblVermelho.TabIndex = 76
        ' 
        ' lblAzul
        ' 
        lblAzul.BackColor = Color.MediumBlue
        lblAzul.BorderStyle = BorderStyle.FixedSingle
        lblAzul.ForeColor = Color.Gray
        lblAzul.Location = New Point(538, 178)
        lblAzul.Margin = New Padding(4, 0, 4, 0)
        lblAzul.Name = "lblAzul"
        lblAzul.Size = New Size(90, 36)
        lblAzul.TabIndex = 77
        ' 
        ' lblAmarelo
        ' 
        lblAmarelo.BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(0))
        lblAmarelo.BorderStyle = BorderStyle.FixedSingle
        lblAmarelo.ForeColor = Color.Gray
        lblAmarelo.Location = New Point(148, 178)
        lblAmarelo.Margin = New Padding(4, 0, 4, 0)
        lblAmarelo.Name = "lblAmarelo"
        lblAmarelo.Size = New Size(480, 36)
        lblAmarelo.TabIndex = 78
        ' 
        ' lblAmarelo_
        ' 
        lblAmarelo_.BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(0))
        lblAmarelo_.BorderStyle = BorderStyle.FixedSingle
        lblAmarelo_.ForeColor = Color.Gray
        lblAmarelo_.Location = New Point(140, 628)
        lblAmarelo_.Margin = New Padding(4, 0, 4, 0)
        lblAmarelo_.Name = "lblAmarelo_"
        lblAmarelo_.Size = New Size(480, 36)
        lblAmarelo_.TabIndex = 81
        ' 
        ' lblAzul_
        ' 
        lblAzul_.BackColor = Color.MediumBlue
        lblAzul_.BorderStyle = BorderStyle.FixedSingle
        lblAzul_.ForeColor = Color.Gray
        lblAzul_.Location = New Point(530, 628)
        lblAzul_.Margin = New Padding(4, 0, 4, 0)
        lblAzul_.Name = "lblAzul_"
        lblAzul_.Size = New Size(90, 36)
        lblAzul_.TabIndex = 80
        ' 
        ' lblVermelho_
        ' 
        lblVermelho_.BackColor = Color.Red
        lblVermelho_.BorderStyle = BorderStyle.FixedSingle
        lblVermelho_.ForeColor = Color.Gray
        lblVermelho_.Location = New Point(138, 628)
        lblVermelho_.Margin = New Padding(4, 0, 4, 0)
        lblVermelho_.Name = "lblVermelho_"
        lblVermelho_.Size = New Size(90, 36)
        lblVermelho_.TabIndex = 79
        ' 
        ' PictureBoxExtraAzul
        ' 
        PictureBoxExtraAzul.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__2____Cópia___Cópia
        PictureBoxExtraAzul.InitialImage = My.Resources.Resources.png_red_arrow_67905___Cópia__2____Cópia___Cópia
        PictureBoxExtraAzul.Location = New Point(464, 496)
        PictureBoxExtraAzul.Margin = New Padding(4)
        PictureBoxExtraAzul.Name = "PictureBoxExtraAzul"
        PictureBoxExtraAzul.Size = New Size(154, 35)
        PictureBoxExtraAzul.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxExtraAzul.TabIndex = 82
        PictureBoxExtraAzul.TabStop = False
        ' 
        ' PictureBoxExtraVermelho
        ' 
        PictureBoxExtraVermelho.Image = My.Resources.Resources.png_red_arrow_67905___Cópia__4_
        PictureBoxExtraVermelho.Location = New Point(47, 496)
        PictureBoxExtraVermelho.Margin = New Padding(4)
        PictureBoxExtraVermelho.Name = "PictureBoxExtraVermelho"
        PictureBoxExtraVermelho.Size = New Size(154, 35)
        PictureBoxExtraVermelho.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxExtraVermelho.TabIndex = 83
        PictureBoxExtraVermelho.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.MicrosoftTeams_image
        PictureBox2.Location = New Point(679, 14)
        PictureBox2.Margin = New Padding(4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 77)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 84
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(242), CByte(0))
        ClientSize = New Size(1230, 763)
        Controls.Add(PictureBox2)
        Controls.Add(GroupBox3)
        Controls.Add(pbSetaAzul_)
        Controls.Add(pbSetaVermelha_)
        Controls.Add(lblAzul_)
        Controls.Add(lblVermelho_)
        Controls.Add(lblAzul)
        Controls.Add(lblVermelho)
        Controls.Add(pbSetaPretaNeg)
        Controls.Add(pbSetaPretaNeg_)
        Controls.Add(pbSetaAzulNeg_)
        Controls.Add(lblEnergcin_total2)
        Controls.Add(Label26)
        Controls.Add(lblEnergcin_total1)
        Controls.Add(Label24)
        Controls.Add(pbSetaVermelhaNeg_)
        Controls.Add(Label29)
        Controls.Add(Label28)
        Controls.Add(lblEnergiaC2_)
        Controls.Add(lblEnergiaC1_)
        Controls.Add(lblEnergiaC2)
        Controls.Add(lblEnergiaC1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(pbSetaPreta_)
        Controls.Add(pbSetaPreta)
        Controls.Add(pbMomentoLinearTotal)
        Controls.Add(pbMomentoLinearTotal_)
        Controls.Add(lblPfinal_total)
        Controls.Add(lblPinicial_total)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblPfinal2)
        Controls.Add(lblPinicial2)
        Controls.Add(lblPinicial1)
        Controls.Add(lblPfinal1)
        Controls.Add(PictureBox1)
        Controls.Add(pbSetaAzul)
        Controls.Add(PictureBox4)
        Controls.Add(pbSetaVermelha)
        Controls.Add(PictureBox3)
        Controls.Add(lblVfinal2)
        Controls.Add(lblVinicial2)
        Controls.Add(lblVfinal1)
        Controls.Add(lblVinicial1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbCarro2)
        Controls.Add(pbCarro1)
        Controls.Add(lblAmarelo)
        Controls.Add(lblAmarelo_)
        Controls.Add(PictureBoxExtraVermelho)
        Controls.Add(PictureBoxExtraAzul)
        ForeColor = Color.Black
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        Text = " Colisões"
        CType(pbCarro1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbCarro2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaVermelha, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaAzul, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(nuVelocidade2, ComponentModel.ISupportInitialize).EndInit()
        CType(nuMassa2, ComponentModel.ISupportInitialize).EndInit()
        CType(nuVelocidade1, ComponentModel.ISupportInitialize).EndInit()
        CType(nuMassa1, ComponentModel.ISupportInitialize).EndInit()
        CType(nuCoRest, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMomentoLinearTotal_, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMomentoLinearTotal, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaPreta, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaPreta_, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaVermelha_, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaAzul_, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaVermelhaNeg_, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaAzulNeg_, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaPretaNeg_, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSetaPretaNeg, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxExtraAzul, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxExtraVermelho, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pbCarro1 As PictureBox
    Friend WithEvents pbCarro2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnstart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnreset As Button
    Friend WithEvents txtvelocidade2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbVelocidade As RadioButton
    Friend WithEvents rbMomentoLinear As RadioButton
    Friend WithEvents rbEnergiaCinetica As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblVinicial1 As Label
    Friend WithEvents lblVfinal1 As Label
    Friend WithEvents lblVinicial2 As Label
    Friend WithEvents lblVfinal2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbSetaVermelha As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents pbSetaAzul As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPfinal1 As Label
    Friend WithEvents lblPinicial1 As Label
    Friend WithEvents lblPinicial2 As Label
    Friend WithEvents lblPfinal2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPinicial_total As Label
    Friend WithEvents lblPfinal_total As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pbMomentoLinearTotal_ As PictureBox
    Friend WithEvents pbMomentoLinearTotal As PictureBox
    Friend WithEvents pbSetaPreta As PictureBox
    Friend WithEvents pbSetaPreta_ As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents pbSetaVermelha_ As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pbSetaAzul_ As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblEnergiaC1 As Label
    Friend WithEvents lblEnergiaC2 As Label
    Friend WithEvents lblEnergiaC1_ As Label
    Friend WithEvents lblEnergiaC2_ As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents nuCoRest As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents nuMassa1 As NumericUpDown
    Friend WithEvents nuVelocidade1 As NumericUpDown
    Friend WithEvents nuMassa2 As NumericUpDown
    Friend WithEvents nuVelocidade2 As NumericUpDown
    Friend WithEvents lblEnergcin_total1 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblEnergcin_total2 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents pbSetaVermelhaNeg_ As PictureBox
    Friend WithEvents pbSetaAzulNeg_ As PictureBox
    Friend WithEvents pbSetaPretaNeg_ As PictureBox
    Friend WithEvents pbSetaPretaNeg As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblVermelho As Label
    Friend WithEvents lblAzul As Label
    Friend WithEvents lblAmarelo As Label
    Friend WithEvents lblAmarelo_ As Label
    Friend WithEvents lblAzul_ As Label
    Friend WithEvents lblVermelho_ As Label
    Friend WithEvents CamLenta As CheckBox
    Friend WithEvents PictureBoxExtra1 As PictureBox
    Friend WithEvents PictureBoxExtraAzul As PictureBox
    Friend WithEvents PictureBoxExtraVermelho As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
