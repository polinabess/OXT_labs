Public Sub Train() 'D37620
  Dim var_24 As Variant
  Dim var_ret_3 As Me
  Dim var_34 As Variant
  Dim var_ret_6 As Me
  Dim var_44 As Variant
  Dim var_ret_9 As Me
  Dim var_64 As Me
  Dim var_ret_12 As Me
  Dim var_ret_13 As Me
  Dim var_ret_19 As Me
  Dim var_ret_1E As OptionButton
  Dim var_ret_22 As OptionButton
  loc_00D376C2: var_AC = "MIX"
  loc_00D376CC: var_BC = "IT"
  loc_00D376D6: var_CC = "TayX"
  loc_00D376E3: var_ret_1 = (Me = Me.GetPalette)
  loc_00D376F6: var_ret_2 = (%x1 = Me.Name <> "IT")
  loc_00D37707: var_ret_3 = var_ret_1 And var_ret_2
  loc_00D37724: var_ret_5 = %x1 = Me.Name And (%x1 = Me.hWnd = "TayX")
  loc_00D37730: If CBool(var_ret_5) Then
  loc_00D37757:   var_BC = "Вариант процесса"
  loc_00D3776B:   var_34 = "Вариант процесса"
  loc_00D37776:   var_AC = "Не предусмотрено расчетом!"
  loc_00D3778A:   var_24 = "Не предусмотрено расчетом!"
  loc_00D37799:   GoTo loc_00D38194
  loc_00D3779E: End If
  loc_00D377AC: var_AC = "MIX"
  loc_00D377E9: eax = ("COMP" = Me.ForeColor = "COMP") + 1
  loc_00D377F6: var_DC = ("COMP" = Me.ForeColor = "COMP") + 1
  loc_00D37809: var_ret_6 = (Me.GetPalette = "MIX")
  loc_00D3781F: var_ret_7 = (%x1 = Me.Name <> "IT")
  loc_00D3782A: var_44 = "IT"
  loc_00D3783C: var_ret_8 = (%x1 = Me.hWnd = "XTay")
  loc_00D37847: var_64 = "XTay"
  loc_00D37855: ecx = ("COMP" = Me.ForeColor = "COMP") + 1
  loc_00D37864: var_F8 = CBool(var_74)
  loc_00D37877: If var_F8 Then
  loc_00D3789E:   var_BC = "Вариант процесса"
  loc_00D378B2:   var_34 = "Вариант процесса"
  loc_00D378BD:   var_AC = "Не предусмотрено расчетом!"
  loc_00D378D1:   var_24 = "Не предусмотрено расчетом!"
  loc_00D378E0:   GoTo loc_00D38476
  loc_00D378E5: End If
  loc_00D3790B: var_AC = "DIS"
  loc_00D37915: var_BC = "TayX"
  loc_00D3791F: var_CC = "PT"
  loc_00D37929: var_ret_9 = (Me.GetPalette = "DIS")
  loc_00D3793F: var_ret_A = (%x1 = Me.hWnd = "TayX")
  loc_00D3794A: var_44 = "TayX"
  loc_00D3795C: var_ret_B = (%x1 = Me.Name = "PT")
  loc_00D37967: var_64 = "PT"
  loc_00D37973: If CBool(var_64) Then
  loc_00D3799A:   var_BC = "Вариант процесса"
  loc_00D379AE:   var_34 = "Вариант процесса"
  loc_00D379B0:   var_AC = "Не предусмотрено расчетом!"
  loc_00D379BA:   GoTo loc_00D37B0B
  loc_00D379BF: End If
  loc_00D379D0: If ("SREV" <> Me.ForeColor <> "SREV") <> 0 Then GoTo loc_00D37DB6
  loc_00D379DC: fcomp real4 ptr [004012E8h]
  loc_00D379F8: If Err.Number Then
  loc_00D379FF:   GoTo loc_00D37A03
  loc_00D37A01: End If
  loc_00D37A03: 'Referenced from: 00D379FF
  loc_00D37A34: var_CC = esi+000001FCh
  loc_00D37A4E: var_ret_C = (esi+000001ECh <= "")
  loc_00D37A66: call Or(var_34, var_C4, var_ret_C, var_ret_B, var_44, var_ret_A, var_34, var_44, var_54, var_74, var_E4, var_64, var_64, var_ret_8, var_44, var_ret_7)
  loc_00D37A8D: var_ret_D = (esi+000001ECh + esi+000001FC > 1)
  loc_00D37A98: call Or(var_64, var_ret_D, Or(var_34, var_C4, var_ret_C, var_ret_B, var_44, var_ret_A, var_34, var_44, var_54, var_74, var_E4, var_64, var_64, var_ret_8, var_44, var_ret_7))
  loc_00D37AA1: var_F8 = CBool(Or(var_64, var_ret_D, Or(var_34, var_C4, var_ret_C, var_ret_B, var_44, var_ret_A, var_34, var_44, var_54, var_74, var_E4, var_64, var_64, var_ret_8, var_44, var_ret_7)))
  loc_00D37AC4: If var_F8 Then
  loc_00D37AEB:   var_BC = "Концентрации"
  loc_00D37AFF:   var_34 = "Концентрации"
  loc_00D37B01:   var_AC = "Надо быть внимательнее!"
  loc_00D37B0B:   'Referenced from: 00D379BA
  loc_00D37B1E:   var_24 = "Надо быть внимательнее!"
  loc_00D37B2D:   GoTo loc_00D3857C
  loc_00D37B32: End If
  loc_00D37B38: fcomp real4 ptr [004012E8h]
  loc_00D37B53: If Err.Number Then
  loc_00D37B5A:   GoTo loc_00D37B5E
  loc_00D37B5C: End If
  loc_00D37B5E: 'Referenced from: 00D37B5A
  loc_00D37BA8: var_F8 = CBool((Me.Visible = %x1b > "") And False)
  loc_00D37BBB: If var_F8 Then
  loc_00D37BFA:   var_34 = "Обратимая реакция"
  loc_00D37C4F:   ecx = MsgBox("Реакция не пойдет!", 0, var_34, 10, 10)
  loc_00D37C70:   GoTo loc_00D37C78
  loc_00D37C72: End If
  loc_00D37C78: 'Referenced from: 00D37C70
  loc_00D37CB5: var_ret_10 = (Me.Visible = %x1b < "")
  loc_00D37CCE: var_ret_11 = (esi+000001CCh < "")
  loc_00D37CD9: var_C4 = var_34
  loc_00D37CEE: var_ret_12 = (Me.ClipControls = %x1b < "")
  loc_00D37D05: If CBool(var_64) Then
  loc_00D37D93:   ecx = MsgBox("Стехиометрические коэффициенты!", 0, "Обратимая реакция", var_44, var_54)
  loc_00D37DB4:   GoTo loc_00D37DC2
  loc_00D37DB6: 
  loc_00D37DC2: End If
  loc_00D37DEA: If (%x1 = Me.hWnd = "TayX") Then
  loc_00D37E3B:   var_ret_13 = (Me.Top = %x1s < "")
  loc_00D37E5C:   call Or(var_44, (Me.Top = %x1s >= var_C4), var_C4, var_ret_11, var_ret_10, var_44, var_54)
  loc_00D37E79:   call Or(var_64, ( > Me.WindowState = %StkVar1))
  loc_00D37E9C:   call Or(var_84, (Me.WindowState = %StkVar1 <= ""))
  loc_00D37EB4:   var_ret_17 = (Me.WindowState = %StkVar1 >= 1)
  loc_00D37EC2:   call Or(var_A4, var_ret_17)
  loc_00D37ECE:   If CBool(Or(var_A4, var_ret_17)) Then
  loc_00D37F04:     var_34 = "Степень превращения"
  loc_00D37F06:     var_AC = "Надо быть внимательнее!"
  loc_00D37F10:     GoTo loc_00D38175
  loc_00D37F15:   End If
  loc_00D37F5E:   var_ret_19 = (%x1 = Me.BorderStyle * Me.WindowState = %StkVar1 >= 1)
  loc_00D37F89:   var_ret_1B = ( * Me.WindowState = %StkVar1 <= &H8002)
  loc_00D37F94:   call ebx(var_64, var_ret_1B)
  loc_00D37FA0:   If CBool(ebx(var_64, var_ret_1B)) Then
  loc_00D37FD6:     var_34 = "Степень превращения"
  loc_00D37FD8:     var_AC = "Смотри Xк и r!"
  loc_00D37FE2:     GoTo loc_00D3855D
  loc_00D37FE7:   End If
  loc_00D37FF8:   If ("SREV" = Me.ForeColor = "SREV") = 0 Then
  loc_00D38026:     If (%x1 = Me.Name = "IT") Then
  loc_00D38043:       If (Me.WindowState = esi+000004A4h >= esi+000004A4h) Then
  loc_00D38079:         var_34 = "Обратимая реакция"
  loc_00D3807B:         var_AC = "Компонента В не достаточно для Хк!"
  loc_00D38085:         GoTo loc_00D38457
  loc_00D3808A:       End If
  loc_00D380AD:       Call Form2.K_react(%x1 = Me.Appearance, Me.ForeColor = %StkVar1, , , )
  loc_00D380E8:       Call Form2.Rrev(Form2.Option13, Me.ScaleWidth = %x1s, , )
  loc_00D3812F:       If (Form2.Option13 <= 0) Then
  loc_00D38169:         var_34 = "Степень превращения"
  loc_00D38175:         'Referenced from: 00D37F10
  loc_00D38184:         var_24 = "Xк превышает равновесие!"
  loc_00D38194:         'Referenced from: 00D37799
  loc_00D381BA:         ecx = MsgBox(var_24, 0, var_34, var_44, var_54)
  loc_00D381D0:         GoTo loc_00D385B8
  loc_00D381D5:       End If
  loc_00D381D5:     End If
  loc_00D381FD:     If (%x1 = Option13.Name = "AD") Then
  loc_00D3823F:       var_ret_1D = var_54 * %x1 = Option13.FontSize - Option13.Top = %x1s
  loc_00D3825B:       var_eax = Call Form2.K_react(esi+00000250h,  + var_ret_1D, , , )
  loc_00D38299:       Call Form2.Rrev(Form2.Option13, Option13.TabStop = %x1b, esi+00000250h, )
  loc_00D382E0:       If (Form2.Option13 <= 0) Then
  loc_00D38316:         var_34 = "Степень превращения"
  loc_00D38318:         var_AC = "Xк превышает равновесие!"
  loc_00D38322:         GoTo loc_00D3855D
  loc_00D38327:       End If
  loc_00D3832D:     End If
  loc_00D3832D:   End If
  loc_00D3832D: End If
  loc_00D3833E: If ("COMP" <> Option13.ForeColor <> "COMP") <> 0 Then GoTo loc_00D385C3
  loc_00D38394: var_ret_1E = (Option13.Top = %x1s + Option13.Height = %x1s >= 1)
  loc_00D383B5: call Or(var_54, ( > Option13.Top = %x1s))
  loc_00D383D2: call Or(var_74, (Option13.Top = %x1s < &H8002))
  loc_00D383EA: var_ret_21 = (Option13.Height = %x1s < "")
  loc_00D383F8: call Or(var_94, var_ret_21)
  loc_00D38411: If CBool(Or(var_94, var_ret_21)) Then
  loc_00D3844B:   var_34 = "Сложная реакция"
  loc_00D38457:   'Referenced from: 00D38085
  loc_00D38466:   var_24 = "Начальные условия!"
  loc_00D38476:   'Referenced from: 00D378E0
  loc_00D3849C:   ecx = MsgBox(var_24, 0, var_34, var_44, var_54)
  loc_00D384B2:   GoTo loc_00D385B8
  loc_00D384B7: End If
  loc_00D384BC: var_AC = var_34
  loc_00D384D1: var_BC = var_34
  loc_00D384E3: var_ret_22 = (Option13.Top = %x1s > var_34)
  loc_00D38507: var_ret_24 = var_34 And (Option13.Height = %x1s = &H8002)
  loc_00D38517: If CBool(var_ret_24) = 0 Then GoTo loc_00D385C3
  loc_00D38551: var_34 = "Сложная реакция"
  loc_00D3855D: 'Referenced from: 00D37FE2
  loc_00D3856C: var_24 = "Начальные условия!"
  loc_00D3857C: 'Referenced from: 00D37B2D
  loc_00D385A2: ecx = MsgBox(var_24, 0, var_34, var_44, var_54)
  loc_00D385B8: 'Referenced from: 00D381D0
  loc_00D385C3: 
  loc_00D385C9: GoTo loc_00D38604
  loc_00D38603: Exit Sub
  loc_00D38604: 'Referenced from: 00D385C9
End Sub