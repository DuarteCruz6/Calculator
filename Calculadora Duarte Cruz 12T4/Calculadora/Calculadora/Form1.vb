Public Class Form1
    Dim v1, v2, v5, v6, r1, r2 As Double
    Dim v3, v4, v9 As String
    Dim v7 As Decimal
    Dim v8 As Integer
    Private Sub bttDivisao_Click(sender As Object, e As EventArgs) Handles bttDivisao.Click
        If bttDivisao.Text = "/" Then
            v1 = Val(lblResultado.Text)
            v3 = "/"
            lblResultado.Text = ""
        Else
            lblResultado.Text = ""
            v3 = "!"
        End If
    End Sub

    Private Sub bttMultiplicacao_Click(sender As Object, e As EventArgs) Handles bttMultiplicacao.Click
        If bttMultiplicacao.Text = "X" Then
            v1 = Val(lblResultado.Text)
            v3 = "*"
            lblResultado.Text = ""
        Else
            lblResultado.Text = ""
            v3 = "tan"
        End If
    End Sub

    Private Sub bttSair_Click(sender As Object, e As EventArgs) Handles bttSair.Click
        Me.Close()
    End Sub

    Private Sub bttSubtracao_Click(sender As Object, e As EventArgs) Handles bttSubtracao.Click
        If bttSubtracao.Text = "-" Then
            If (lblResultado.Text IsNot "") Then
                v1 = Val(lblResultado.Text)
                v3 = "-"
                lblResultado.Text = ""
            Else
                lblResultado.Text = "-"
            End If
        ElseIf bttSubtracao.Text = "Cos" Then
            lblResultado.Text = ""
            v3 = "cos"
        End If

    End Sub
    Private Sub bttAdicao_Click(sender As Object, e As EventArgs) Handles bttAdicao.Click
        If bttAdicao.Text = "+" Then
            v1 = Val(lblResultado.Text)
            v3 = "+"
            lblResultado.Text = ""
        Else
            lblResultado.Text = ""
            v3 = "sen"
        End If
    End Sub

    Private Sub bttPotencia_Click(sender As Object, e As EventArgs) Handles bttPotencia.Click
        v1 = Val(lblResultado.Text)
        v3 = "^"
        lblResultado.Text = ""
    End Sub

    Private Sub bttC_Click(sender As Object, e As EventArgs) Handles bttC.Click
        lblResultado.Text = ""
    End Sub

    Private Sub bttRaiz_Click(sender As Object, e As EventArgs) Handles bttRaiz.Click
        If bttRaiz.Text = "√" Then
            v1 = Val(lblResultado.Text)
            v3 = "√"
            lblResultado.Text = ""
        Else
            v3 = "%"
            lblResultado.Text = ""
        End If
    End Sub

    Private Sub bttIgual_Click(sender As Object, e As EventArgs)
        v2 = Val(lblResultado.Text)
        If v3 = "*" Then
            lblResultado.Text = Math.Round(Val(v1 * v2), 9)
        ElseIf (v3 = "/" And (v2 <> 0)) Then
            lblResultado.Text = Math.Round(Val(v1 / v2), 9)
        ElseIf (v3 = "/" And (v2 = 0)) Then
            lblResultado.Text = "ERROR"
        ElseIf v3 = "+" Then
            lblResultado.Text = Math.Round(Val(v1 + v2), 9)
        ElseIf v3 = "-" Then
            lblResultado.Text = Math.Round(Val(v1 - v2), 9)
        ElseIf v3 = "^" Then
            lblResultado.Text = Math.Round(Val(v1 ^ v2), 9)
        ElseIf (v3 = "√" And v2 < 0 And v1 Mod 2 = 0) Then
            lblResultado.Text = "ERROR"
        ElseIf (v3 = "√" And v2 >= 0) Then
            lblResultado.Text = Math.Round(Val(v2 ^ (1 / v1)), 9)
        ElseIf (v3 = "√" And v2 < 0 And v1 Mod 2 <> 0) Then
            lblResultado.Text = Math.Round(Val(v2 ^ (1 / v1)), 9)
        ElseIf (v3 = "cos") Then
            If v4 = "Deg" Then
                v2 = v2 * Math.PI / 180
                lblResultado.Text = Math.Round(Math.Cos(v2), 5)
            ElseIf v4 = "Rad" Then
                lblResultado.Text = Math.Round(Math.Cos(v2), 9)
            Else
                lblResultado.Text = "ERROR"
            End If
        ElseIf v3 = "sen" Then
            If v4 = "Deg" Then
                v2 = v2 * Math.PI / 180
                lblResultado.Text = Math.Round(Math.Sin(v2), 5)
            ElseIf v4 = "Rad" Then
                lblResultado.Text = Math.Round(Math.Sin(v2), 9)
            Else
                lblResultado.Text = "ERROR"
            End If
        ElseIf v3 = "tan" Then
            If v4 = "Deg" Then
                If (v2 Mod 90) = 0 Then
                    lblResultado.Text = "ERROR"
                Else
                    v2 = v2 * Math.PI / 180
                    lblResultado.Text = Math.Round(Math.Tan(v2), 5)
                End If
            ElseIf v4 = "Rad" Then
                If (v2 Mod (Math.PI / 2)) = 0 Then
                    lblResultado.Text = "ERROR"
                Else
                    lblResultado.Text = Math.Round(Math.Tan(v2), 9)
                End If
            Else
                lblResultado.Text = "ERROR"
            End If
        ElseIf v3 = "!" Then
            v5 = 1
            While v2 <> 0
                v5 *= v2
                v2 -= 1
            End While
            lblResultado.Text = Math.Round(Val(v5), 9)
        ElseIf v3 = "%" Then
            lblResultado.Text = Math.Round((v2 / 100), 9)
        ElseIf v3 = "10^" Then
            lblResultado.Text = Math.Round(Val(v1) * (10 ^ Val(v2)), 9)

        ElseIf v3 = "log" Then
            If v2 < 0 Then
                lblResultado.Text = "ERROR"
            End If
            v5 = 0
            While v2 <> 1
                v2 = v2 / v1
                v5 += 1
            End While
            lblResultado.Text = v5

        ElseIf v3 = "arredondar" Then
            v8 = v2
            lblResultado.Text = Math.Round(v7, v8)

        ElseIf v3 = "nPr" Then
            v5 = 1
            v6 = v1 - v2
            r1 = 1
            While v1 <> 0
                v5 *= v1
                v1 -= 1
            End While
            While v6 <> 0
                r1 *= v6
                v6 -= 1
            End While
            lblResultado.Text = Math.Round(v5 / r1, 9)

        ElseIf v3 = "nCr" Then
            v5 = 1
            v6 = v1 - v2
            r1 = 1
            r2 = 1
            While v1 <> 0
                v5 *= v1
                v1 -= 1
            End While
            While v6 <> 0
                r1 *= v6
                v6 -= 1
            End While
            While v2 <> 0
                r1 *= v2
                v2 -= 1
            End While
            lblResultado.Text = Math.Round(v5 / (r1 * r2), 9)

        ElseIf v3 = "senm1" Then
            If v4 = "Rad" Then
                lblResultado.Text = Math.Round(Math.Asin(v2), 5)
            ElseIf v4 = "Deg" Then
                v2 = Math.Round(Math.Asin(v2), 9)
                lblResultado.Text = Math.Round(v2 * 180 / Math.PI, 5)
            Else
                lblResultado.Text = "ERROR"
            End If
        ElseIf v3 = "cosm1" Then
            If v4 = "Rad" Then
                lblResultado.Text = Math.Round(Math.Acos(v2), 5)
            ElseIf v4 = "Deg" Then
                v2 = Math.Round(Math.Acos(v2), 9)
                lblResultado.Text = Math.Round(v2 * 180 / Math.PI, 5)
            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "tanm1" Then
            If v4 = "Rad" Then
                lblResultado.Text = Math.Round(Math.Atan(v2), 5)
            ElseIf v4 = "Deg" Then
                v2 = Math.Round(Math.Atan(v2), 9)
                lblResultado.Text = Math.Round(v2 * 180 / Math.PI, 5)
            Else
                lblResultado.Text = "ERROR"
            End If
        End If

    End Sub

    Private Sub bttLimpar_Click(sender As Object, e As EventArgs) Handles bttLimpar.Click
        v1 = 0
        v2 = 0
        v5 = 0
        v6 = 0
        r1 = 0
        r2 = 0
        v7 = 0.0
        v8 = 0
        v3 = ""
        v4 = ""
        v9 = ""
        lblResultado.Text = ""

    End Sub
    Private Sub btt1_Click(sender As Object, e As EventArgs) Handles btt1.Click
        lblResultado.Text = lblResultado.Text & "1"
    End Sub

    Private Sub btt2_Click(sender As Object, e As EventArgs) Handles btt2.Click
        lblResultado.Text = lblResultado.Text & "2"
    End Sub

    Private Sub btt3_Click(sender As Object, e As EventArgs) Handles btt3.Click
        lblResultado.Text = lblResultado.Text & "3"
    End Sub

    Private Sub btt4_Click(sender As Object, e As EventArgs) Handles btt4.Click
        lblResultado.Text = lblResultado.Text & "4"
    End Sub

    Private Sub btt5_Click(sender As Object, e As EventArgs) Handles btt5.Click
        lblResultado.Text = lblResultado.Text & "5"
    End Sub

    Private Sub btt6_Click(sender As Object, e As EventArgs) Handles btt6.Click
        lblResultado.Text = lblResultado.Text & "6"
    End Sub

    Private Sub btt7_Click(sender As Object, e As EventArgs) Handles btt7.Click
        lblResultado.Text = lblResultado.Text & "7"
    End Sub

    Private Sub btt8_Click(sender As Object, e As EventArgs) Handles btt8.Click
        lblResultado.Text = lblResultado.Text & "8"
    End Sub

    Private Sub btt9_Click(sender As Object, e As EventArgs) Handles btt9.Click
        lblResultado.Text = lblResultado.Text & "9"
    End Sub

    Private Sub btt0_Click(sender As Object, e As EventArgs) Handles btt0.Click
        If lblResultado.Text <> "0" Then lblResultado.Text = lblResultado.Text & "0"
    End Sub

    Private Sub bttPi_Click(sender As Object, e As EventArgs) Handles bttPi.Click
        lblResultado.Text = "3.14159"
    End Sub

    Private Sub bttMenu2_Click(sender As Object, e As EventArgs) Handles bttMenu2.Click
        bttSubtracao.Text = "-"
        bttAdicao.Text = "+"
        bttMultiplicacao.Text = "X"
        bttDivisao.Text = "/"
        bttRaiz.Text = "√"
        bttMenu2.Visible = False
        bttPi.Visible = False
        bttFResolvente.Visible = False
        bttDeg.Visible = False
        bttRad.Visible = False
        bttPotencia10.Visible = False
        txtX.Visible = False
        bttLog.Visible = False
        bttPr.Visible = False
        bttCr.Visible = False
        bttArredondar.Visible = False
        bttConversor.Visible = False
        bttDecFra.Visible = False
        bttFracaoreduzida.Visible = False
        bttOFF2.Visible = False
        txtX.Visible = False
        bttCosm1.Visible = False
        bttSenm1.Visible = False
        bttTanm1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bttLog.Click
        v1 = Val(lblResultado.Text)
        lblResultado.Text = ""
        v3 = "log"
        If v1 < 0 Then
            lblResultado.Text = "ERROR"
        End If
    End Sub

    Private Sub bttArredondar_Click(sender As Object, e As EventArgs) Handles bttArredondar.Click
        v7 = Val(lblResultado.Text)
        lblResultado.Text = ""
        v3 = "arredondar"
    End Sub

    Private Sub bttPr_Click(sender As Object, e As EventArgs) Handles bttPr.Click
        v1 = Val(lblResultado.Text)
        lblResultado.Text = ""
        v3 = "nPr"
    End Sub

    Private Sub bttCr_Click(sender As Object, e As EventArgs) Handles bttCr.Click
        v1 = Val(lblResultado.Text)
        lblResultado.Text = ""
        v3 = "nCr"
    End Sub

    Private Sub bttFracaoreduzida_Click(sender As Object, e As EventArgs) Handles bttFracaoreduzida.Click
        v9 = lblResultado.Text
        v9 = v9.Replace(",", ".")
        If v9.Contains(".") Then
            v5 = v9.IndexOf(".")
            v4 = v9.Substring(v5 + 1, Len(v9) - v5 - 1)
            v2 = 10 ^ Len(v4)
            v1 = Val(v9) * v2
        ElseIf v9.Contains("/") Then
            v5 = v9.IndexOf("/")
            v4 = v9.Substring(0, v5)
            v9 = v9.Substring(v5 + 1, Len(v9) - v5 - 1)
            v1 = Val(v4)
            v2 = Val(v9)
        Else
            MsgBox("Não Disponível", 1)
            v3 = ""
        End If

        While ((v2 Mod 2 = 0) And (v1 Mod 2 = 0))
            v1 /= 2
            v2 /= 2
        End While
        While ((v2 Mod 3 = 0) And (v1 Mod 3 = 0))
            v1 /= 3
            v2 /= 3
        End While
        While ((v2 Mod 5 = 0) And (v1 Mod 5 = 0))
            v1 /= 5
            v2 /= 5
        End While
        While ((v2 Mod 7 = 0) And (v1 Mod 7 = 0))
            v1 /= 7
            v2 /= 7
        End While
        While ((v2 Mod 11 = 0) And (v1 Mod 11 = 0))
            v1 /= 11
            v2 /= 11
        End While
        While ((v2 Mod 13 = 0) And (v1 Mod 13 = 0))
            v1 /= 13
            v2 /= 13
        End While
        While ((v2 Mod 17 = 0) And (v1 Mod 17 = 0))
            v1 /= 17
            v2 /= 17
        End While
        While ((v2 Mod 19 = 0) And (v1 Mod 19 = 0))
            v1 /= 19
            v2 /= 19
        End While
        While ((v2 Mod 23 = 0) And (v1 Mod 23 = 0))
            v1 /= 23
            v2 /= 23
        End While
        While ((v2 Mod 29 = 0) And (v1 Mod 29 = 0))
            v1 /= 29
            v2 /= 29
        End While
        While ((v2 Mod 31 = 0) And (v1 Mod 31 = 0))
            v1 /= 31
            v2 /= 31
        End While
        While ((v2 Mod 37 = 0) And (v1 Mod 37 = 0))
            v1 /= 37
            v2 /= 37
        End While
        While ((v2 Mod 41 = 0) And (v1 Mod 41 = 0))
            v1 /= 41
            v2 /= 41
        End While
        While ((v2 Mod 43 = 0) And (v1 Mod 43 = 0))
            v1 /= 43
            v2 /= 43
        End While
        While ((v2 Mod 47 = 0) And (v1 Mod 47 = 0))
            v1 /= 47
            v2 /= 47
        End While
        lblResultado.Text = v1 & "/" & v2
    End Sub

    Private Sub bttDecFra_Click(sender As Object, e As EventArgs) Handles bttDecFra.Click
        v9 = lblResultado.Text
        v9 = v9.Replace(",", ".")
        If v9.Contains(".") Then
            v3 = "Dec"
        ElseIf v9.Contains("/") Then
            v3 = "Fra"
        Else
            MsgBox("Não Disponível", 1)
            v3 = ""
        End If
        If v3 = "Fra" Then
            v5 = v9.IndexOf("/")
            v4 = v9.Substring(0, v5)
            v9 = v9.Substring(v5 + 1, Len(v9) - v5 - 1)
            v1 = Val(v4)
            v2 = Val(v9)
            lblResultado.Text = Math.Round(v1 / v2, 9)

        ElseIf v3 = "Dec" Then
            v5 = v9.IndexOf(".")
            v4 = v9.Substring(v5 + 1, Len(v9) - v5 - 1)
            v2 = 10 ^ Len(v4)
            v1 = Val(v9) * v2
            lblResultado.Text = v1 & "/" & v2

        End If
    End Sub

    Private Sub bttOFF2_Click(sender As Object, e As EventArgs) Handles bttOFF2.Click
        Me.Close()
    End Sub

    Private Sub bttSenm1_Click(sender As Object, e As EventArgs) Handles bttSenm1.Click
        lblResultado.Text = ""
        v3 = "senm1"
    End Sub

    Private Sub bttCosm1_Click(sender As Object, e As EventArgs) Handles bttCosm1.Click
        lblResultado.Text = ""
        v3 = "cosm1"
    End Sub

    Private Sub bttTanm1_Click(sender As Object, e As EventArgs) Handles bttTanm1.Click
        lblResultado.Text = ""
        v3 = "tanm1"
    End Sub

    Private Sub bttConversor_Click(sender As Object, e As EventArgs) Handles bttConversor.Click
        v3 = InputBox("Tipo de Unidade", "Área, Comprimento, Volume, Tempo, Temperatura, Massa, Velocidade", 1)
        If v3 = "Área" Then
            v4 = InputBox("Qual Unidade", "cm2, m2, he, km2", 1)
            v9 = InputBox("Para qual Unidade", "cm2, m2, he, km2", 1)
            v1 = Val(InputBox("Área", "Área", 1))
            If v4 = "cm2" Then
                If v9 = "cm2" Then
                    lblResultado.Text = v1 & " cm2"

                ElseIf v9 = "m2" Then
                    lblResultado.Text = v1 / 10000 & " m2"

                ElseIf v9 = "he" Then
                    lblResultado.Text = v1 / 100000000 & " he"

                ElseIf v9 = "km2" Then
                    lblResultado.Text = v1 / 10000000000 & " km2"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "m2" Then
                If v9 = "m2" Then
                    lblResultado.Text = v1 & " m2"

                ElseIf v9 = "cm2" Then
                    lblResultado.Text = v1 * 10000 & " cm2"

                ElseIf v9 = "he" Then
                    lblResultado.Text = v1 / 10000 & " he"

                ElseIf v9 = "km2" Then
                    lblResultado.Text = v1 / 1000000 & " km2"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "he" Then
                If v9 = "he" Then
                    lblResultado.Text = v1 & " he"

                ElseIf v9 = "cm2" Then
                    lblResultado.Text = v1 * 100000000 & " cm2"

                ElseIf v9 = "m2" Then
                    lblResultado.Text = v1 * 10000 & " m2"

                ElseIf v9 = "km2" Then
                    lblResultado.Text = v1 / 100 & " km2"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "km2" Then
                If v9 = "km2" Then
                    lblResultado.Text = v1 & " km2"

                ElseIf v9 = "cm2" Then
                    lblResultado.Text = v1 * 10000000000 & " cm2"

                ElseIf v9 = "m2" Then
                    lblResultado.Text = v1 * 1000000 & " m2"

                ElseIf v9 = "he" Then
                    lblResultado.Text = v1 * 100 & " he"
                Else
                    lblResultado.Text = "ERROR"

                End If
            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "Comprimento" Then
            v4 = InputBox("Qual Unidade", "mm, cm, m, km", 1)
            v9 = InputBox("Para qual Unidade", "mm, cm, m, km", 1)
            v1 = Val(InputBox("Comprimento", "Comprimento", 1))
            If v4 = "mm" Then
                If v9 = "mm" Then
                    lblResultado.Text = v1 & " mm"

                ElseIf v9 = "cm" Then
                    lblResultado.Text = v1 / 10 & " cm"

                ElseIf v9 = "m" Then
                    lblResultado.Text = v1 / 1000 & " m"

                ElseIf v9 = "km" Then
                    lblResultado.Text = v1 / 1000000 & " km"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "cm" Then
                If v9 = "cm" Then
                    lblResultado.Text = v1 & " cm"

                ElseIf v9 = "mm" Then
                    lblResultado.Text = v1 * 10 & " mm"

                ElseIf v9 = "m" Then
                    lblResultado.Text = v1 / 100 & " m"

                ElseIf v9 = "km" Then
                    lblResultado.Text = v1 / 100000 & " km"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "m" Then
                If v9 = "m" Then
                    lblResultado.Text = v1 & " m"

                ElseIf v9 = "mm" Then
                    lblResultado.Text = v1 * 1000 & " mm"

                ElseIf v9 = "cm" Then
                    lblResultado.Text = v1 * 100 & " cm"

                ElseIf v9 = "km" Then
                    lblResultado.Text = v1 / 1000 & " km"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "km" Then
                If v9 = "km" Then
                    lblResultado.Text = v1 & " km"

                ElseIf v9 = "mm" Then
                    lblResultado.Text = v1 * 1000000 & " mm"

                ElseIf v9 = "cm" Then
                    lblResultado.Text = v1 * 100000 & " cm"

                ElseIf v9 = "m" Then
                    lblResultado.Text = v1 * 1000 & " m"
                Else
                    lblResultado.Text = "ERROR"

                End If
            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "Volume" Then
            v4 = InputBox("Qual Unidade", "cm3, m3, dm3", 1)
            v9 = InputBox("Para qual Unidade", "cm3, m3, dm3", 1)
            v1 = Val(InputBox("Volume", "Volume", 1))
            If v4 = "cm3" Then
                If v9 = "cm3" Then
                    lblResultado.Text = v1 & " cm3"

                ElseIf v9 = "m3" Then
                    lblResultado.Text = v1 / 1000000 & " m3"

                ElseIf v9 = "dm3" Then
                    lblResultado.Text = v1 / 1000000000 & " dm3"

                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "m3" Then
                If v9 = "m3" Then
                    lblResultado.Text = v1 & " m3"

                ElseIf v9 = "cm3" Then
                    lblResultado.Text = v1 * 1000 & " cm3"

                ElseIf v9 = "dm3" Then
                    lblResultado.Text = v1 / 1000 & " dm3"

                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "dm3" Then
                If v9 = "dm3" Then
                    lblResultado.Text = v1 & " dm3"

                ElseIf v9 = "cm3" Then
                    lblResultado.Text = v1 * 1000000 & " cm3"

                ElseIf v9 = "m3" Then
                    lblResultado.Text = v1 * 1000 & " m3"

                Else
                    lblResultado.Text = "ERROR"

                End If

            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "Tempo" Then
            v4 = InputBox("Qual Unidade", "ms, s, min, h", 1)
            v9 = InputBox("Para qual Unidade", "ms, s, min, h", 1)
            v1 = Val(InputBox("Tempo", "Tempo", 1))
            If v4 = "ms" Then
                If v9 = "ms" Then
                    lblResultado.Text = v1 & " ms"

                ElseIf v9 = "s" Then
                    lblResultado.Text = v1 / 100 & " s"

                ElseIf v9 = "min" Then
                    lblResultado.Text = v1 / 600 & " min"

                ElseIf v9 = "h" Then
                    lblResultado.Text = v1 / 36000 & " h"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "s" Then
                If v9 = "s" Then
                    lblResultado.Text = v1 & " s"

                ElseIf v9 = "ms" Then
                    lblResultado.Text = v1 * 100 & " ms"

                ElseIf v9 = "min" Then
                    lblResultado.Text = v1 / 60 & " min"

                ElseIf v9 = "h" Then
                    lblResultado.Text = v1 / 3600 & " h"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "min" Then
                If v9 = "min" Then
                    lblResultado.Text = v1 & " min"

                ElseIf v9 = "ms" Then
                    lblResultado.Text = v1 * 60 * 100 & " ms"

                ElseIf v9 = "s" Then
                    lblResultado.Text = v1 * 60 & " s"

                ElseIf v9 = "h" Then
                    lblResultado.Text = v1 / 60 & " h"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "h" Then
                If v9 = "h" Then
                    lblResultado.Text = v1 & " h"

                ElseIf v9 = "ms" Then
                    lblResultado.Text = v1 * 60 * 60 * 100 & " ms"

                ElseIf v9 = "s" Then
                    lblResultado.Text = v1 * 60 * 60 & " s"

                ElseIf v9 = "min" Then
                    lblResultado.Text = v1 * 60 & " min"
                Else
                    lblResultado.Text = "ERROR"

                End If
            Else
                lblResultado.Text = "ERROR"
            End If
        ElseIf v3 = "Temperatura" Then
            v4 = InputBox("Qual Unidade", "ºC, ºF, K", 1)
            v9 = InputBox("Para qual Unidade", "ºC, ºF, K", 1)
            v1 = Val(InputBox("Temperatura", "Temperatura", 1))
            If v4 = "ºC" Then
                If v9 = "ºC" Then
                    lblResultado.Text = v1 & " ºC"

                ElseIf v9 = "ºF" Then
                    lblResultado.Text = v1 * 1.8 + 32 & " ºF"

                ElseIf v9 = "K" Then
                    lblResultado.Text = v1 + 273.15 & " K"

                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "ºF" Then
                If v9 = "ºF" Then
                    lblResultado.Text = v1 & " ºF"

                ElseIf v9 = "ºC" Then
                    lblResultado.Text = (v1 - 32) / 1.8 & " ºC"

                ElseIf v9 = "K" Then
                    lblResultado.Text = (v1 + 459.67) / 1.8 & " K"

                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "K" Then
                If v9 = "K" Then
                    lblResultado.Text = v1 & " K"

                ElseIf v9 = "ºC" Then
                    lblResultado.Text = v1 - 273.15 & " ºC"

                ElseIf v9 = "ºF" Then
                    lblResultado.Text = v1 * 1.8 - 459.67 & " ºF"

                Else
                    lblResultado.Text = "ERROR"

                End If
            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "Massa" Then
            v4 = InputBox("Qual Unidade", "mg, g, kg, T", 1)
            v9 = InputBox("Para qual Unidade", "mg, g, kg, T", 1)
            v1 = Val(InputBox("Massa", "Massa", 1))

            If v4 = "mg" Then
                If v9 = "mg" Then
                    lblResultado.Text = v1 & " mg"

                ElseIf v9 = "g" Then
                    lblResultado.Text = v1 / 1000 & " g"

                ElseIf v9 = "kg" Then
                    lblResultado.Text = v1 / 1000000 & " kg"

                ElseIf v9 = "T" Then
                    lblResultado.Text = v1 / 1000000000 & " T"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "g" Then
                If v9 = "g" Then
                    lblResultado.Text = v1 & " g"

                ElseIf v9 = "mg" Then
                    lblResultado.Text = v1 * 1000 & " mg"

                ElseIf v9 = "kg" Then
                    lblResultado.Text = v1 / 1000 & " kg"

                ElseIf v9 = "T" Then
                    lblResultado.Text = v1 / 1000000 & " T"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "kg" Then
                If v9 = "kg" Then
                    lblResultado.Text = v1 & " kg"

                ElseIf v9 = "mg" Then
                    lblResultado.Text = v1 * 1000000 & " mg"

                ElseIf v9 = "kg" Then
                    lblResultado.Text = v1 * 1000 & " g"

                ElseIf v9 = "T" Then
                    lblResultado.Text = v1 / 1000 & " T"
                Else
                    lblResultado.Text = "ERROR"

                End If
            ElseIf v4 = "T" Then
                If v9 = "T" Then
                    lblResultado.Text = v1 & " T"

                ElseIf v9 = "mg" Then
                    lblResultado.Text = v1 * 1000000000 & " mg"

                ElseIf v9 = "g" Then
                    lblResultado.Text = v1 * 1000000 & " g"

                ElseIf v9 = "kg" Then
                    lblResultado.Text = v1 * 1000 & " kg"
                Else
                    lblResultado.Text = "ERROR"

                End If
            Else
                lblResultado.Text = "ERROR"
            End If

        ElseIf v3 = "Velocidade" Then
            v4 = InputBox("Qual Unidade", "m/s, km/h", 1)
            v1 = Val(InputBox("Velocidade", "Velocidade", 1))
            If v4 = "m/s" Then
                lblResultado.Text = v1 * 3.6 & " km/h"
            ElseIf v4 = "km/h" Then
                lblResultado.Text = v1 / 3.6 & " m/s"
            Else
                lblResultado.Text = "ERROR"
            End If
        Else
            lblResultado.Text = "ERROR"
        End If
    End Sub

    Private Sub bttPotencia10_Click(sender As Object, e As EventArgs) Handles bttPotencia10.Click
        v1 = lblResultado.Text
        lblResultado.Text = ""
        v3 = "10^"

    End Sub

    Private Sub bttDeg_Click(sender As Object, e As EventArgs) Handles bttDeg.Click
        If {"cos", "sen", "tan", "tanm1", "cosm1", "senm1"}.Contains(v3) Then
            v4 = "Deg"
        Else
            lblResultado.Text = (Val(lblResultado.Text) * Math.PI) / 180
        End If
    End Sub

    Private Sub bttFResolvente_Click(sender As Object, e As EventArgs) Handles bttFResolvente.Click
        v1 = Val(InputBox("Enter a: ", "Valor de A", 1))
        v2 = Val(InputBox("Enter b: ", "Valor de B", 1))
        v6 = Val(InputBox("Enter c: ", "Valor de C", 1))
        r1 = (-v2 + (((v2 ^ 2) - (4 * v1 * v6)) ^ (1 / 2))) / (2 * v1)
        r2 = (-v2 - (((v2 ^ 2) - (4 * v1 * v6)) ^ (1 / 2))) / (2 * v1)
        lblResultado.Text = Str(r1) + " or " + Str(r2)

    End Sub

    Private Sub bttRad_Click(sender As Object, e As EventArgs) Handles bttRad.Click
        If {"cos", "sen", "tan", "tanm1", "cosm1", "senm1"}.Contains(v3) Then
            v4 = "Rad"
        Else
            lblResultado.Text = (Val(lblResultado.Text) * 180) / Math.PI
        End If
    End Sub

    Private Sub bttMenu_Click(sender As Object, e As EventArgs) Handles bttMenu.Click
        bttSubtracao.Text = "Cos"
        bttAdicao.Text = "Sin"
        bttMultiplicacao.Text = "Tan"
        bttDivisao.Text = "!"
        bttRaiz.Text = "%"
        bttMenu2.Visible = True
        bttPi.Visible = True
        bttFResolvente.Visible = True
        bttDeg.Visible = True
        bttRad.Visible = True
        bttPotencia10.Visible = True
        txtX.Visible = True
        bttLog.Visible = True
        bttPr.Visible = True
        bttCr.Visible = True
        bttArredondar.Visible = True
        bttConversor.Visible = True
        bttDecFra.Visible = True
        bttFracaoreduzida.Visible = True
        bttOFF2.Visible = True
        bttCosm1.Visible = True
        bttSenm1.Visible = True
        bttTanm1.Visible = True
    End Sub

    Private Sub bttPonto_Click(sender As Object, e As EventArgs) Handles bttPonto.Click
        If (lblResultado.Text.Contains(".")) Then
            lblResultado.Text = "ERROR"
        Else
            lblResultado.Text = lblResultado.Text & "."
        End If
    End Sub


End Class
