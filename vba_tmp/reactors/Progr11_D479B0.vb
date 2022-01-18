Public Sub Progr11() 'D479B0
  Dim var_1A0 As Me
  Dim var_A0 As OptionButton
  Dim var_70 As OptionButton
  Dim var_ret_5 As OptionButton
  Dim var_ret_C As OptionButton
  Dim var_204 As OptionButton
  loc_00D47ABF: ecx = Me.Top =
  loc_00D47AD1: ecx = Me.Height =
  loc_00D47AE0: ecx = Me.ForeColor =
  loc_00D47B08: ecx = Me.FontName =
  loc_00D47B16: ecx = Me.Height =
  loc_00D47B42: Call Form2.K_react(%x1 = Me.WhatsThisHelp, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, , )
  loc_00D47B84: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, , , )
  loc_00D47BBD: var_188 = %x1 = Me.OLEDropMode
  loc_00D47BEF: Call Form2.K_react(var_190, esi+00000230h, Me.DrawStyle = %StkVar1, , )
  loc_00D47C32: If (Me.Height = %x1s > "") Then
  loc_00D47C43:   var_ret_1 =  / Me.Top = %x1s
  loc_00D47C4A:   var_ret_1 = CSng()
  loc_00D47C58:   GoTo loc_00D47C7E
  loc_00D47C5A: End If
  loc_00D47C7E: 'Referenced from: 00D47C58
  loc_00D47C81: var_eax = Unknown_VTable_Call[edx+00000384h]
  loc_00D47CA0: Option16.Caption = "  t         X          Y          S "
  loc_00D47CE8: ecx = vbNullString
  loc_00D47D59: var_A0 = "0.000"
  loc_00D47E0A: var_1E8 = Form2.Option16 'Ignore this
  loc_00D47EA6: var_100 = esi+000003D0h & Format(esi+00000294h, "000.00") & "   " & Format(Option16.Top = %x1s, 1) & "   " & Format(Option16.Height = %x1s, "0.000")
  loc_00D47EF4: ecx = var_100 & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D47F83: var_188 = Option16.FontName = %StkVar1
  loc_00D47F9F: ecx = Option16.FontName =
  loc_00D47FA7: var_24 = Option16.Top =
  loc_00D47FCC: 
  loc_00D48009: ecx = CInt(1) + var_24 / 2
  loc_00D48045: var_70 = 1 - esi+00000210h
  loc_00D48063: Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D480B9: var_70 = 1 - esi+00000210h
  loc_00D480D7: Call Form2.Rcom(esi+00000330h, esi+00000270h, %x1 = Option16.MaskColor, )
  loc_00D4811C: ecx = esi+00000320h + esi+00000330h
  loc_00D4814D: var_ret_5 = esi+00000200h * esi+00000350h
  loc_00D48185: var_204 = ( + Option16.Top = %x1s - esi+00000210h > 0)
  loc_00D481A3: If var_204 = 0 Then
  loc_00D481A8: End If
  loc_00D481E3: var_ret_8 = Abs(esi+00000210h - var_24)
  loc_00D481FA: If (var_ret_8 < 0.001#) = 0 Then GoTo loc_00D47FCC
  loc_00D48231: var_70 = 1 - esi+00000210h
  loc_00D4824F: Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D4828A: Option16.Visible = %x1b = CSng()
  loc_00D48293: 
  loc_00D4829C: var_188 = var_48
  loc_00D482E6: ecx = var_48 + Option16.Height = / 2
  loc_00D482F9: var_198 = Option16.AddItem
  loc_00D48324: var_188 = esi+00000280h
  loc_00D48339: var_eax = Call Form2.Rcom(esi+00000340h, var_190, var_1A0, esi+00000220h)
  loc_00D48375: ecx = esi+00000320h - esi+00000340h
  loc_00D4839D: var_ret_C = esi+00000200h * esi+00000360h
  loc_00D483D8: var_204 = ( + Option16.Height = %x1s - esi+00000220h > 0)
  loc_00D483ED: If var_204 Then
  loc_00D483F8:   var_44 = esi+00000220h
  loc_00D483FE:   GoTo loc_00D48410
  loc_00D48400: End If
  loc_00D48407: esi+00000220h = CSng()
  loc_00D48410: 'Referenced from: 00D483FE
  loc_00D48419: var_188 = var_48
  loc_00D4845B: var_ret_F = Abs(var_48 - var_44)
  loc_00D48472: If (var_ret_F < 0.001#) = 0 Then GoTo loc_00D48293
  loc_00D48484: esi+00000294h = esi+00000294h + 00000010h
  loc_00D48487: ecx = esi+00000200h
  loc_00D48499: esi+000002CCh = esi+000002CCh + 00000010h
  loc_00D4849C: ecx = esi+00000210h
  loc_00D484AE: esi+000002E8h = esi+000002E8h + 00000010h
  loc_00D484B1: ecx = esi+00000220h
  loc_00D484C9: var_ret_10 = esi+00000220h / esi+00000210h
  loc_00D484D0: var_ret_10 = CSng()
  loc_00D4860F: var_1E8 = Form2.Option16 'Ignore this
  loc_00D486A7: var_100 = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & "   " & Format(esi+00000220h, "0.000")
  loc_00D486F7: ecx = var_100 & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D48783: var_eax = Unknown_VTable_Call[eax+00000348h]
  loc_00D487A1: var_218 = var_4C
  loc_00D487A7: var_4C = CStr(esi+000003D0h)
  loc_00D487BB: Option16.MousePointer = var_4C
  loc_00D487FD: ecx = esi+00000200h
  loc_00D4881F: ecx = "NO"
  loc_00D48841: ecx = CInt(1)
  loc_00D48849: GoTo loc_00D488E8
  loc_00D488E7: Exit Sub
  loc_00D488E8: 'Referenced from: 00D48849
End Sub