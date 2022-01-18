Public Sub Progr12() 'D48930
  Dim var_170 As Me
  Dim var_50 As Me
  Dim var_80 As OptionButton
  Dim var_ret_8 As OptionButton
  Dim var_1E4 As OptionButton
  loc_00D48A37: ecx = Me.Top =
  loc_00D48A45: ecx = Me.Height =
  loc_00D48A50: ecx = Me.ForeColor =
  loc_00D48A5E: ecx = Me.WindowState =
  loc_00D48A6C: ecx = Me.Height =
  loc_00D48A94: Call Form2.K_react(%x1 = Me.WhatsThisHelp, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, , )
  loc_00D48AE1: var_50 =  - %x1 = Me.Count
  loc_00D48B03: Call Form2.Rcom(esi+00000320h, %x1 = Me.WhatsThisHelp, , )
  loc_00D48B4E: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, , , )
  loc_00D48B9B: var_50 = 1 - %x1 = Me.Count
  loc_00D48BBD: Call Form2.Rcom(esi+00000330h, %x1 = Me.RightToLeft, , )
  loc_00D48BF4: var_168 = %x1 = Me.OLEDropMode
  loc_00D48C31: Call Form2.K_react(&H4004, esi+00000230h, Me.ScaleLeft = %x1s, &H4004, )
  loc_00D48C6D: ecx = esi+00000320h + esi+00000330h
  loc_00D48CA3: If (Me.Height = %x1s > "") Then
  loc_00D48CB4:   var_ret_3 =  / Me.Top = %x1s
  loc_00D48CBB:   var_ret_3 = CSng()
  loc_00D48CC9:   GoTo loc_00D48CEF
  loc_00D48CCB: End If
  loc_00D48CEF: 'Referenced from: 00D48CC9
  loc_00D48CF2: var_eax = Unknown_VTable_Call[edx+00000384h]
  loc_00D48D11: Option16.Caption = "  t         X          Y          S"
  loc_00D48D58: ecx = vbNullString
  loc_00D48DC6: var_80 = "0.000"
  loc_00D48E74: var_1C8 = Form2.Option16 'Ignore this
  loc_00D48F0D: var_E0 = esi+000003D0h & Format(esi+00000294h, "000.00") & "   " & Format(Option16.Top = %x1s, 1) & "   " & Format(Option16.Height = %x1s, "0.000")
  loc_00D48F5B: ecx = var_E0 & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D49011: ecx =  - Option16.Top = %x1s / esi+00000350h
  loc_00D4902D: Option16.Visible = %x1b = CSng()
  loc_00D49036: 
  loc_00D49050: var_168 = var_28
  loc_00D49089: ecx = var_28 + Option16.Height = / 2
  loc_00D490A0: var_178 = Option16.AddItem
  loc_00D490CB: var_168 = esi+00000280h
  loc_00D490E0: var_eax = Call Form2.Rcom(esi+00000340h, var_170, var_180, esi+00000220h)
  loc_00D4911C: ecx = esi+00000320h - esi+00000340h
  loc_00D49144: var_ret_8 = esi+00000200h * esi+00000360h
  loc_00D4917F: var_1E4 = ( + Option16.Height = %x1s - esi+00000220h > "")
  loc_00D49193: If var_1E4 Then
  loc_00D4919E:   var_24 = esi+00000220h
  loc_00D491A4:   GoTo loc_00D491B6
  loc_00D491A6: End If
  loc_00D491AD: esi+00000220h = CSng()
  loc_00D491B6: 'Referenced from: 00D491A4
  loc_00D491BF: var_168 = var_28
  loc_00D49201: var_ret_B = Abs(var_28 - var_24)
  loc_00D49218: If (var_ret_B < 0.001#) = 0 Then GoTo loc_00D49036
  loc_00D4922A: esi+00000294h = esi+00000294h + 00000010h
  loc_00D4922D: ecx = esi+00000200h
  loc_00D4923F: esi+000002CCh = esi+000002CCh + 00000010h
  loc_00D49242: ecx = esi+00000210h
  loc_00D49254: esi+000002E8h = esi+000002E8h + 00000010h
  loc_00D49257: ecx = esi+00000220h
  loc_00D4926F: var_ret_C = esi+00000220h / esi+00000210h
  loc_00D49276: var_ret_C = CSng()
  loc_00D493AF: var_1C8 = Form2.Option16 'Ignore this
  loc_00D49444: var_E0 = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & "   " & Format(esi+00000220h, "0.000")
  loc_00D49494: ecx = var_E0 & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D4951E: var_eax = Unknown_VTable_Call[ecx+00000348h]
  loc_00D4953C: var_1F8 = var_2C
  loc_00D49542: var_2C = CStr(esi+000003D0h)
  loc_00D49556: Option16.MousePointer = var_2C
  loc_00D49598: ecx = esi+00000200h
  loc_00D495BA: ecx = "NO"
  loc_00D495DC: ecx = CInt(1)
  loc_00D495E8: GoTo loc_00D49681
  loc_00D49680: Exit Sub
  loc_00D49681: 'Referenced from: 00D495E8
End Sub