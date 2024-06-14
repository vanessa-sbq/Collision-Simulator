Public Class Form1
    Dim colidiram As Boolean
    Dim p1inicial, p2inicial, p1final, p2final, massa1, massa2, velocidade1, velocidade2, pinicial_total, velocidade1_, velocidade2_, CoRest As Decimal
    Dim EnergiaC1, EnergiaC2, EnergiaC1_, EnergiaC2_, EnergiaCTotal, EnergiaCTotal_ As Double



    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        lblPinicial1.Hide()
        lblPinicial2.Hide()
        lblPfinal1.Hide()
        lblPfinal2.Hide()
        lblPinicial_total.Hide()
        lblPfinal_total.Hide()
        pbSetaPreta.Hide()
        pbSetaPretaNeg.Hide()
        pbSetaPreta_.Hide()
        pbSetaPretaNeg_.Hide()
        pbMomentoLinearTotal.Hide()
        pbMomentoLinearTotal_.Hide()

        lblEnergiaC1.Hide()
        lblEnergiaC2.Hide()
        lblEnergiaC1_.Hide()
        lblEnergiaC2_.Hide()

        Label24.Hide()
        Label26.Hide()
        lblEnergcin_total1.Hide()
        lblEnergcin_total2.Hide()

        lblVermelho.Hide()
        lblAmarelo.Hide()
        lblAzul.Hide()
        lblVermelho_.Hide()
        lblAmarelo_.Hide()
        lblAzul_.Hide()
        'recalculate functions estado inicial
        Format()
        CalcMomentoLinear()

    End Sub



    'Botão Start
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click

        btnstart.Enabled = False
        btnreset.Enabled = True

        Format()
        CalcMomentoLinear()

        Timer1.Start()
        Timer2.Start()

        nuCoRest.Enabled = False
        nuMassa1.Enabled = False
        nuVelocidade1.Enabled = False
        nuMassa2.Enabled = False
        nuVelocidade2.Enabled = False
        rbVelocidade.Enabled = False
        rbMomentoLinear.Enabled = False
        rbEnergiaCinetica.Enabled = False
    End Sub



    'Botão Reset
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        pbCarro1.Location = New Point(39, 291)
        pbCarro1.Width = 45
        pbCarro1.Height = pbCarro1.Width
        pbCarro2.Location = New Point(552, 291)
        pbCarro2.Width = 45
        pbCarro2.Height = pbCarro2.Width

        nuMassa1.Value = 0.1
        nuVelocidade1.Value = 0.1
        nuMassa2.Value = 0.1
        nuVelocidade2.Value = -0.1

        velocidade1 = 0.1
        velocidade2 = 0.1
        massa1 = 0.1
        massa2 = 0.1
        velocidade1_ = 0
        velocidade2_ = 0

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        colidiram = False

        nuCoRest.Enabled = True
        nuMassa1.Enabled = True
        nuVelocidade1.Enabled = True
        nuMassa2.Enabled = True
        nuVelocidade2.Enabled = True
        rbVelocidade.Enabled = True
        rbMomentoLinear.Enabled = True
        rbEnergiaCinetica.Enabled = True

        lblVinicial1.Text = "0,100 m/s"
        lblVinicial2.Text = "- 0,100 m/s"
        lblVfinal1.Text = "- 0,100 m/s"
        lblVfinal2.Text = "0, 100 m/s"


        btnstart.Enabled = True

        'recalculate functions
        Format()
        CalcMomentoLinear()

    End Sub



    'NumericUpDown Coeficiente de Restituição (nuCoRest)
    Private Sub nuCoRest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuCoRest.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Format()
            CalcMomentoLinear()
        End If
    End Sub

    Private Sub nuCoRest_ValueChanged(sender As Object, e As EventArgs) Handles nuCoRest.ValueChanged
        Format()
        CalcMomentoLinear()
    End Sub



    'NumericUpDown massa 1 (nuMassa1)
    Private Sub nuMassa1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuMassa1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Format()
            CalcMomentoLinear()
        End If
    End Sub

    Private Sub nuMassa1_ValueChanged(sender As Object, e As EventArgs) Handles nuMassa1.ValueChanged
        Format()
        CalcMomentoLinear()
    End Sub




    'NumericUpDown velocidade 1 (nuVelocidade1)
    Private Sub nuVelocidade1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuVelocidade1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Format()
            CalcMomentoLinear()
        End If
    End Sub

    Private Sub nuVelocidade1_ValueChanged(sender As Object, e As EventArgs) Handles nuVelocidade1.ValueChanged
        Format()
        CalcMomentoLinear()
    End Sub



    'NumericUpDown massa 2 (nuMassa2)
    Private Sub nuMassa2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuMassa2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Format()
            CalcMomentoLinear()
        End If
    End Sub

    Private Sub nuMassa2_ValueChanged(sender As Object, e As EventArgs) Handles nuMassa2.ValueChanged
        Format()
        CalcMomentoLinear()
    End Sub



    'NumericUpDown velocidade 2 (nuVelocidade2)
    Private Sub nuVelocidade2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuVelocidade2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Format()
            CalcMomentoLinear()
        End If
    End Sub

    Private Sub nuVelocidade2_ValueChanged(sender As Object, e As EventArgs) Handles nuVelocidade2.ValueChanged
        Format()
        CalcMomentoLinear()
    End Sub



    'Formatar grandezas
    Sub Format()
        CoRest = nuCoRest.Value

        massa1 = nuMassa1.Value

        velocidade1 = nuVelocidade1.Value
        lblVinicial1.Text = velocidade1.ToString("0.0000") & " m/s"

        massa2 = nuMassa2.Value

        velocidade2 = nuVelocidade2.Value
        lblVinicial2.Text = velocidade2.ToString("0.0000") & " m/s"
    End Sub



    'Cálculo do momento linear
    Sub CalcMomentoLinear()
        velocidade1_ = 0
        velocidade2_ = 0

        p1inicial = massa1 * velocidade1
        lblPinicial1.Text = p1inicial.ToString("0.0000") & " kg m/s"

        p2inicial = massa2 * velocidade2
        lblPinicial2.Text = p2inicial.ToString("0.0000") & " kg m/s"

        pinicial_total = p1inicial + p2inicial
        lblPinicial_total.Text = pinicial_total.ToString("0.0000") & " kg m/s"
        lblPfinal_total.Text = pinicial_total.ToString("0.0000") & " kg m/s"

        'Tamanho do corpo Vermelho
        pbCarro1.Width = 45 + 75 * massa1
        pbCarro1.Height = pbCarro1.Width
        pbCarro1.Left = 39
        pbCarro1.Top = 291 - pbCarro1.Width + 45

        'Tamanho do corpo Azul
        pbCarro2.Width = 45 + 75 * massa2
        pbCarro2.Height = pbCarro2.Width
        pbCarro2.Left = 552
        pbCarro2.Top = 291 - pbCarro2.Width + 45

        'Velocidade
        If rbVelocidade.Checked.Equals(True) Then
            'Seta Vermelha
            pbSetaVermelha.Location = New Point(36 + (velocidade1 * 100), 67)
            'Seta Azul
            pbSetaAzul.Location = New Point(387 + (velocidade2 * 100), 67)
        End If

        'Momento Linear inicial
        If rbMomentoLinear.Checked.Equals(True) Then
            'Seta Vermelha
            pbSetaVermelha.Location = New Point(36 + (p1inicial * 100), 67)
            'Seta Azul
            pbSetaAzul.Location = New Point(387 + (p2inicial * 100), 67)
        End If

        'Setas Pretas
        If pinicial_total > 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaPreta.Show()
            pbSetaPreta_.Show()
            pbSetaPretaNeg.Hide()
            pbSetaPretaNeg_.Hide()
            pbSetaPreta.Location = New Point(247 + (pinicial_total * 100), 148)
            pbSetaPreta_.Location = New Point(240 + (pinicial_total * 100), 491)
        End If
        If pinicial_total < 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaPreta.Hide()
            pbSetaPreta_.Hide()
            pbSetaPretaNeg.Show()
            pbSetaPretaNeg_.Show()
            pbSetaPretaNeg.Location = New Point(247 + (pinicial_total * 100), 148)
            pbSetaPretaNeg_.Location = New Point(240 + (pinicial_total * 100), 491)
        End If

        'Velocidades finais
        If (massa1 + massa2) <> 0 Then
            velocidade1_ = (CoRest * massa2 * (velocidade2 - velocidade1) + massa1 * velocidade1 + massa2 * velocidade2) / (massa1 + massa2)
            velocidade2_ = (CoRest * massa1 * (velocidade1 - velocidade2) + massa1 * velocidade1 + massa2 * velocidade2) / (massa1 + massa2)
        End If

        'Velocidade final
        'Seta Vermelha
        If velocidade1_ >= 0 And rbVelocidade.Checked.Equals(True) Then
            pbSetaVermelha_.Show()
            pbSetaVermelhaNeg_.Hide()
            pbSetaVermelha_.Location = New Point(39 + (velocidade1_ * 90), 413)
            PictureBox5.Location = New Point(39, 413)
            PictureBoxExtraVermelho.Location = New Point(39 + (velocidade1_ * 90 / 2), 413)
        End If

        If velocidade1_ < 0 And rbVelocidade.Checked.Equals(True) Then
            pbSetaVermelha_.Hide()
            pbSetaVermelhaNeg_.Show()
            pbSetaVermelhaNeg_.Location = New Point(150 + (velocidade1_ * 90), 413)
            PictureBox5.Location = New Point(150, 413)
            PictureBoxExtraVermelho.Location = New Point(150 + (velocidade1_ * 90 / 2), 413)
        End If

        'Seta Azul
        If velocidade2_ >= 0 And rbVelocidade.Checked.Equals(True) Then
            pbSetaAzul_.Show()
            pbSetaAzulNeg_.Hide()
            pbSetaAzul_.Location = New Point(387 + (velocidade2_ * 90), 413)
            PictureBox6.Location = New Point(387, 413)
            PictureBoxExtraAzul.Location = New Point(387 + (velocidade2_ * 90 / 2), 413)
        End If
        If velocidade2_ < 0 And rbVelocidade.Checked.Equals(True) Then
            pbSetaAzul_.Hide()
            pbSetaAzulNeg_.Show()
            pbSetaAzulNeg_.Location = New Point(387 + (velocidade2_ * 90), 413)
            PictureBox6.Location = New Point(387, 413)
            PictureBoxExtraAzul.Location = New Point(387 + (velocidade2_ * 90 / 2), 413)
        End If


        'Energia cinética inicial
        EnergiaC1 = 1 / 2 * massa1 * (velocidade1) ^ 2
        EnergiaC2 = 1 / 2 * massa2 * (velocidade2) ^ 2
        EnergiaCTotal = EnergiaC1 + EnergiaC2
        lblEnergiaC1.Text = EnergiaC1.ToString("0.0000") & " J"
        lblEnergiaC2.Text = EnergiaC2.ToString("0.0000") & " J"
        lblEnergcin_total1.Text = EnergiaCTotal.ToString("0.0000") & " J"

        lblVermelho.Width = CInt(Val((Math.Truncate((EnergiaC1 / EnergiaCTotal) * 400)).ToString))
        lblAzul.Width = CInt(Val((Math.Truncate((EnergiaC2 / EnergiaCTotal) * 400)).ToString))
        lblAzul.Location = New Point(448 + 75 - CInt(Val((Math.Truncate((EnergiaC2 / EnergiaCTotal) * 400)).ToString)), 148)


        'Energia cinética final
        EnergiaC1_ = 1 / 2 * massa1 * (velocidade1_) ^ 2
        EnergiaC2_ = 1 / 2 * massa2 * (velocidade2_) ^ 2
        EnergiaCTotal_ = EnergiaC1_ + EnergiaC2_
        lblEnergiaC1_.Text = EnergiaC1_.ToString("0.0000") & " J"
        lblEnergiaC2_.Text = EnergiaC2_.ToString("0.0000") & " J"
        lblEnergcin_total2.Text = EnergiaCTotal_.ToString("0.0000") & " J"

        lblVermelho_.Width = CInt(Val((Math.Truncate((EnergiaC1_ / EnergiaCTotal) * 400)).ToString)) + 5
        lblAzul_.Width = CInt(Val((Math.Truncate((EnergiaC2_ / EnergiaCTotal) * 400)).ToString)) + 5
        lblAzul_.Location = New Point(442 + 75 - CInt(Val((Math.Truncate((EnergiaC2_ / EnergiaCTotal) * 400)).ToString)), 523)



        'Labels velocidade final
        lblVfinal1.Text = velocidade1_.ToString("0.0000") & " m/s"
        lblVfinal2.Text = velocidade2_.ToString("0.0000") & " m/s"


        'Momento linear final
        p1final = velocidade1_ * massa1
        p2final = velocidade2_ * massa2

        'Labels momento linear final
        lblPfinal1.Text = p1final.ToString("0.0000") & " kg m/s"
        lblPfinal2.Text = p2final.ToString("0.0000") & " kg m/s"

        'Setas Momento Linear final
        'Seta Vermelha
        If p1final >= 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaVermelha_.Show()
            pbSetaVermelhaNeg_.Hide()
            PictureBox5.Location = New Point(39, 413)
            pbSetaVermelha_.Location = New Point(39 + (p1final * 100), 413)
        End If

        If p1final < 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaVermelha_.Hide()
            pbSetaVermelhaNeg_.Show()
            PictureBox5.Location = New Point(39, 413)
            pbSetaVermelhaNeg_.Location = New Point(39 + (p1final * 100), 413)
        End If

        'Seta Azul
        If p2final >= 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaAzul_.Show()
            pbSetaAzulNeg_.Hide()
            PictureBox6.Location = New Point(387, 413)
            pbSetaAzul_.Location = New Point(387 + (p2final * 100), 413)
        End If
        If p2final < 0 And rbMomentoLinear.Checked.Equals(True) Then
            pbSetaAzul_.Hide()
            pbSetaAzulNeg_.Show()
            PictureBox6.Location = New Point(387, 413)
            pbSetaAzulNeg_.Location = New Point(387 + (p2final * 100), 413)
        End If

    End Sub



    'Animações:

    'Animação Carro 1
    'Ida:
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (CamLenta.Checked = True) Then
            Threading.Thread.Sleep(50) 'miliseconds
        End If
        pbCarro1.Left = pbCarro1.Left + velocidade1 * 8

        Colisao()
        If colidiram = True Then
            Timer3.Start()
            Timer4.Start()
        End If
    End Sub

    'Volta:
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If (CamLenta.Checked = True) Then
            Threading.Thread.Sleep(50) 'miliseconds
        End If
        pbCarro1.Left = pbCarro1.Left + velocidade1_ * 8
    End Sub



    'Animação Carro 2 
    'Ida:
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pbCarro2.Left = pbCarro2.Left + velocidade2 * 8
    End Sub

    'Volta:
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pbCarro2.Left = pbCarro2.Left + velocidade2_ * 8
    End Sub



    'Verificação de colisão
    Sub Colisao()
        If pbCarro1.Location.X + pbCarro1.Width >= pbCarro2.Location.X Then
            Timer1.Stop()
            Timer2.Stop()
            colidiram = True
        End If

    End Sub



    'Radiobuttons (Velocidade, Momento Linear, Energia cinética)
    Private Sub rbVelocidade_CheckedChanged(sender As Object, e As EventArgs) Handles rbVelocidade.CheckedChanged

        'Hide
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        lblPinicial1.Hide()
        lblPinicial2.Hide()
        lblPfinal1.Hide()
        lblPfinal2.Hide()
        lblPinicial_total.Hide()
        lblPfinal_total.Hide()
        pbMomentoLinearTotal.Hide()
        pbMomentoLinearTotal_.Hide()
        pbSetaPreta.Hide()
        pbSetaPretaNeg.Hide()
        pbSetaPreta_.Hide()
        pbSetaPretaNeg_.Hide()
        Label24.Hide()
        Label26.Hide()
        lblEnergcin_total1.Hide()
        lblEnergcin_total2.Hide()

        lblVermelho.Hide()
        lblAmarelo.Hide()
        lblAzul.Hide()
        lblVermelho_.Hide()
        lblAmarelo_.Hide()
        lblAzul_.Hide()

        'Show
        Label1.Show()
        PictureBox3.Show()
        PictureBox4.Show()
        pbSetaVermelha.Show()
        pbSetaAzul.Show()
        lblVinicial1.Show()
        lblVinicial2.Show()
        lblVfinal1.Show()
        lblVfinal2.Show()
        Label4.Show()
        PictureBox5.Show()
        PictureBox6.Show()
        pbSetaVermelha_.Show()
        pbSetaAzul_.Show()
        PictureBoxExtraVermelho.Show()
        PictureBoxExtraAzul.Show()

        lblEnergiaC1.Hide()
        lblEnergiaC2.Hide()
        lblEnergiaC1_.Hide()
        lblEnergiaC2_.Hide()
        Label28.Hide()
        Label29.Hide()

        'recalculate functions
        Format()
        CalcMomentoLinear()

    End Sub

    Private Sub rbMomentoLinear_CheckedChanged(sender As Object, e As EventArgs) Handles rbMomentoLinear.CheckedChanged

        'Hide
        Label1.Hide()
        lblVinicial1.Hide()
        lblVinicial2.Hide()
        lblVfinal1.Hide()
        lblVfinal2.Hide()
        Label4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBoxExtraVermelho.Hide()
        PictureBoxExtraAzul.Hide()

        lblEnergiaC1.Hide()
        lblEnergiaC2.Hide()
        lblEnergiaC1_.Hide()
        lblEnergiaC2_.Hide()
        Label28.Hide()
        Label29.Hide()
        Label24.Hide()
        Label26.Hide()
        lblEnergcin_total1.Hide()
        lblEnergcin_total2.Hide()

        lblVermelho.Hide()
        lblAmarelo.Hide()
        lblAzul.Hide()
        lblVermelho_.Hide()
        lblAmarelo_.Hide()
        lblAzul_.Hide()

        'Show
        PictureBox3.Show()
        PictureBox4.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
        lblPinicial1.Show()
        lblPinicial2.Show()
        lblPfinal1.Show()
        lblPfinal2.Show()
        lblPinicial_total.Show()
        lblPfinal_total.Show()
        pbSetaVermelha.Show()
        pbSetaAzul.Show()
        pbSetaVermelha_.Show()
        pbSetaAzul_.Show()

        If pinicial_total >= 0 Then
            pbSetaPreta.Show()
            pbSetaPreta_.Show()
        End If
        If pinicial_total < 0 Then
            pbSetaPretaNeg.Show()
            pbSetaPretaNeg_.Show()
        End If

        pbMomentoLinearTotal.Show()
        pbMomentoLinearTotal_.Show()

        PictureBox5.Show()
        PictureBox6.Show()

        'recalculate functions
        Format()
        CalcMomentoLinear()

    End Sub

    Private Sub rbEnergiaCinetica_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnergiaCinetica.CheckedChanged

        'Hide
        Label1.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        pbSetaVermelha.Hide()
        pbSetaAzul.Hide()
        pbSetaVermelha_.Hide()
        pbSetaAzul_.Hide()
        pbSetaVermelhaNeg_.Hide()
        pbSetaAzulNeg_.Hide()
        lblVinicial1.Hide()
        lblVinicial2.Hide()
        lblVfinal1.Hide()
        lblVfinal2.Hide()
        Label4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBoxExtraVermelho.Hide()
        PictureBoxExtraAzul.Hide()
        pbSetaVermelha_.Hide()
        pbSetaVermelhaNeg_.Hide()
        pbSetaAzul_.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        lblPinicial1.Hide()
        lblPinicial2.Hide()
        lblPfinal1.Hide()
        lblPfinal2.Hide()
        lblPinicial_total.Hide()
        lblPfinal_total.Hide()
        pbMomentoLinearTotal.Hide()
        pbMomentoLinearTotal_.Hide()
        pbSetaPreta.Hide()
        pbSetaPretaNeg.Hide()
        pbSetaPreta_.Hide()
        pbSetaPretaNeg_.Hide()

        'Show
        lblEnergiaC1.Show()
        lblEnergiaC2.Show()
        lblEnergiaC1_.Show()
        lblEnergiaC2_.Show()
        Label28.Show()
        Label29.Show()
        Label24.Show()
        Label26.Show()
        lblEnergcin_total1.Show()
        lblEnergcin_total2.Show()

        lblVermelho.Show()
        lblAmarelo.Show()
        lblAzul.Show()
        lblVermelho_.Show()
        lblAmarelo_.Show()
        lblAzul_.Show()

        'recalculate functions
        Format()
        CalcMomentoLinear()
    End Sub
End Class
