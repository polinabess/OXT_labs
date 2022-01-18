Public Sub Progr6() 'D425C0
  Dim var_3C As Variant
  Dim var_16C As OptionButton
  Dim var_ret_19 As OptionButton
  loc_00D426D5: ecx = Me.Top = ebx
  loc_00D426E7: ecx = Me.Height =
  loc_00D426F6: ecx = Me.ForeColor =
  loc_00D42708: ecx = esi+00000200h
  loc_00D4271A: ecx =  = Me.Count
  loc_00D4272C: ecx =  = Me.MouseIcon
  loc_00D42758: var_ret_1 = Me.WindowState = %StkVar1 - %x1 = Me.Count
  loc_00D42778: ecx = var_ret_1 / 200
  loc_00D427A0: Call Form2.K_react(%x1 = Me.WhatsThisHelp, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, , )
  loc_00D427ED: var_3C = 1 - %x1 = Me.Count
  loc_00D4280B: Call Form2.Rcom(esi+00000320h, %x1 = Me.WhatsThisHelp, , )
  loc_00D42856: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, , , )
  loc_00D428A3: var_3C = 1 - %x1 = Me.Count
  loc_00D428C1: Call Form2.Rcom(esi+00000330h, %x1 = Me.RightToLeft, , )
  loc_00D428F8: var_154 = %x1 = Me.OLEDropMode
  loc_00D42935: Call Form2.K_react(&H4004, esi+00000230h, Me.ScaleLeft = %x1s, &H4004, )
  loc_00D42971: var_164 = %x1 = Me.HasDC
  loc_00D42984: var_154 = %x1 = Me.OLEDropMode
  loc_00D42999: var_eax = Call Form2.Rcom(esi+00000340h, var_15C, var_16C, )
  loc_00D429E9: ecx = esi+00000388h / esi+00000320h + esi+00000330h
  loc_00D42A46: ecx = esi+00000388h * esi+00000320h - esi+00000340h / esi+00000320h + esi+00000330h
  loc_00D42A83: var_ret_A = esi+00000320h - esi+00000340h / esi+00000320h + esi+00000330h
  loc_00D42A8A: var_ret_A = CSng()
  loc_00D42AA4: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D42AC3: Option16.Caption = "  t         X          Y          S "
  loc_00D42B0A: ecx = vbNullString
  loc_00D42C34: var_1B4 = Form2.Option16 'Ignore this
  loc_00D42CD6: var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & "   " & Format(esi+00000220h, "0.000")
  loc_00D42D38: ecx = var_CC & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D42E14: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D42E1A: 
  loc_00D42E1C:   If esi+0000039Ch Then
  loc_00D42E7E:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D42E84: 
  loc_00D42E86:       If esi+000003ACh Then
  loc_00D42EF1:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D42F18:         ecx = esi+00000210h + esi+00000388h
  loc_00D42F3F:         ecx = esi+00000220h + esi+00000404h
  loc_00D42F7B:         var_3C = 1 - esi+00000210h
  loc_00D42F99:         Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D42FEF:         var_3C = 1 - esi+00000210h
  loc_00D4300D:         Call Form2.Rcom(esi+00000330h, esi+00000270h, %x1 = Option16.MaskColor, )
  loc_00D4303D:         var_154 = esi+00000280h
  loc_00D4306F:         var_164 = Option16.AddItem
  loc_00D4307A:         var_eax = Call Form2.Rcom(esi+00000340h, var_15C, esi+00000454h, )
  loc_00D430C4:         ecx = esi+00000388h / esi+00000320h + esi+00000330h
  loc_00D43121:         ecx = esi+00000388h * esi+00000320h - esi+00000340h / esi+00000320h + esi+00000330h
  loc_00D43179:         ecx = esi+00000200h + esi+000003E4h + esi+000003F4h / 2
  loc_00D4319A:         ecx = esi+000003F4h
  loc_00D431ED:         ecx = esi+00000220h + esi+00000404h + esi+00000414h / 2
  loc_00D4320E:         ecx = esi+00000414h
  loc_00D4321B:         var_ret_15 = CLng(esi+000003BCh)
  loc_00D43226:         var_1D0 = var_ret_15
  loc_00D4322C:         If var_ret_15 >= 211 Then
  loc_00D4322E:           var_eax = Err.Raise
  loc_00D4323A:         End If
  loc_00D4324B:         var_1D0 = var_1D0 + esi+00000294h
  loc_00D4324D:         var_1D0 = esi+00000200h
  loc_00D4325A:         var_ret_16 = CLng(esi+000003BCh)
  loc_00D43265:         var_1D0 = var_ret_16
  loc_00D4326B:         If var_ret_16 >= 211 Then
  loc_00D4326D:           var_eax = Err.Raise
  loc_00D43279:         End If
  loc_00D4328A:         var_1D0 = var_1D0 + esi+000002CCh
  loc_00D4328C:         var_1D0 = esi+00000210h
  loc_00D43299:         var_ret_17 = CLng(esi+000003BCh)
  loc_00D432A4:         var_1D0 = var_ret_17
  loc_00D432AA:         If var_ret_17 >= 211 Then
  loc_00D432AC:           var_eax = Err.Raise
  loc_00D432B8:         End If
  loc_00D432C9:         var_1D0 = var_1D0 + esi+000002E8h
  loc_00D432CB:         var_1D0 = esi+00000220h
  loc_00D432D8:         var_ret_18 = CLng(esi+000003BCh)
  loc_00D432E3:         var_1D0 = var_ret_18
  loc_00D432E9:         If var_ret_18 >= 211 Then
  loc_00D432EB:           var_eax = Err.Raise
  loc_00D432F1:         End If
  loc_00D43303:         var_ret_19 = esi+00000220h - Option16.Height = %x1s
  loc_00D43324:         var_ret_1B =  / esi+00000210h - Option16.Top = %x1s
  loc_00D4332B:         var_ret_1B = CSng()
  loc_00D43355:       Next esi+000003ACh
  loc_00D4335B:       GoTo loc_00D42E84
  loc_00D43360:     End If
  loc_00D43396:     var_3C = Format(esi+00000200h, "000.00")
  loc_00D433E3:     var_7C = Format(esi+00000210h, "0.000")
  loc_00D43439:     var_BC = Format(esi+00000220h, "0.000")
  loc_00D43470:     var_EC = "0.000"
  loc_00D4347D:     var_ret_1C = CLng(esi+000003BCh)
  loc_00D43488:     var_1D0 = var_ret_1C
  loc_00D4348E:     If var_ret_1C >= 211 Then
  loc_00D43490:       var_eax = Err.Raise
  loc_00D4349C:     End If
  loc_00D434B9:     var_1B4 = ecx+eax*4
  loc_00D434EC:     var_13C = Chr(10)
  loc_00D43564:     var_DC = esi+000003D0h & var_3C & "   " & var_7C & "   " & var_BC & "   "
  loc_00D4358E:     var_12C = var_DC & Format(ecx+eax*4, var_EC) & Chr(13)
  loc_00D435B1:     ecx = var_12C & var_13C
  loc_00D43646:   Next esi+0000039Ch
  loc_00D4364C:   GoTo loc_00D42E1A
  loc_00D43651: End If
  loc_00D43654: var_eax = Unknown_VTable_Call[edx+00000348h]
  loc_00D43674: var_DC & var_FC = CStr(esi+000003D0h)
  loc_00D4367C: Option16.MousePointer = var_DC & Format(ecx+eax*4, var_EC)
  loc_00D436BE: ecx = esi+00000200h
  loc_00D436E0: ecx = "NO"
  loc_00D436E8: GoTo loc_00D4377E
  loc_00D4377D: Exit Sub
  loc_00D4377E: 'Referenced from: 00D436E8
End Sub