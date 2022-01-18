Public Sub Progr13() 'D496B0
  Dim var_50 As OptionButton
  Dim var_ret_3 As OptionButton
  Dim var_184 As OptionButton
  Dim var_ret_D As OptionButton
  loc_00D49789: ecx = Me.Top = %x1 = Me.Count
  loc_00D49798: ecx = Me.ForeColor =
  loc_00D497AA: ecx = esi+00000200h
  loc_00D497B8: ecx =  = Me.Count
  loc_00D497CA: ecx = esi+00000230h
  loc_00D497F2: ecx = Me.FontName =
  loc_00D4981E: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D4984B: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D4985F:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D49867:   If eax >= 0 Then GoTo loc_00D49910
  loc_00D49872:   GoTo loc_00D49903
  loc_00D49877: End If
  loc_00D49882: var_ret_1 = -Option13.Refresh
  loc_00D4988D: var_50 = var_ret_1
  loc_00D498B6: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D498F4: Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, %x1 = Me.Count)
  loc_00D498FC: If eax < 0 Then
  loc_00D49903:   'Referenced from: 00D49872
  loc_00D4990A:   Form2.Option13 = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D49910: End If
  loc_00D49916: var_184 = %x1 = Option13.FontSize
  loc_00D4993A: var_ret_3 = %x1 = Option13.FontSize * esi+00000200h * Form2.Option13
  loc_00D49969: ecx =  + Option13.ForeColor = %StkVar1 - esi+00000230h
  loc_00D499A0: If (%x1 = Option13.Name = "PT") Then
  loc_00D499BC:   var_128 = %x1 = Option13.DragMode
  loc_00D49A0E:   ecx =  - %x1 = Option13.Value * esi+00000230h - %x1 = Option13.DragMode * esi+00000200h
  loc_00D49A14: End If
  loc_00D49A17: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D49A36: Option13.Caption = "  t         X          T"
  loc_00D49A7E: ecx = vbNullString
  loc_00D49BC8: var_E0 = esi+000003D0h & Format(esi+00000200h, "000.00") & "    " & Format(%x1 = Me.Count, "0.000") & "    " & Format(esi+00000230h, "000.0")
  loc_00D49BF4: ecx = var_E0 & Chr(13) & Chr(10)
  loc_00D49C69: If var_D4F000 = 0 Then
  loc_00D49C71:   GoTo loc_00D49C84
  loc_00D49C73: End If
  loc_00D49C84: 'Referenced from: 00D49C71
  loc_00D49CB6: ecx = (1# / 200#)
  loc_00D49CDC: ecx = 0
  loc_00D49CE2: 
  loc_00D49CF8: ecx =  = Me.Count + esi+00000388h
  loc_00D49D3F: ecx =  + Option13.ForeColor = %StkVar1 * %x1 = Me.Count - Option13.Top = %x1s
  loc_00D49D74: Call Form2.K_react(esi+00000240h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D49DA1: If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D49DB5:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D49DBD:   If Form2.Option13 'Ignore this >= 0 Then GoTo loc_00D49E66
  loc_00D49DC8:   GoTo loc_00D49E59
  loc_00D49DCD: End If
  loc_00D49DE3: var_50 = -Option13.Refresh
  loc_00D49E0C: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D49E4A: Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, %x1 = Me.Count)
  loc_00D49E52: If Form2.Option13 'Ignore this < 0 Then
  loc_00D49E59:   'Referenced from: 00D49DC8
  loc_00D49E60:   Form2.Option13 = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D49E66: End If
  loc_00D49E8A: var_ret_D = var_184 * esi+00000200h * Form2.Option13
  loc_00D49EAB: var_ret_E =  + Option13.ForeColor = %StkVar1 - esi+00000230h
  loc_00D49EB2: var_ret_E = CSng()
  loc_00D49EEF: If (%x1 = Option13.Name = "PT") Then
  loc_00D49EFD:   var_138 = esi+00000594h
  loc_00D49F22:   var_128 = %x1 = Option13.DragMode
  loc_00D49F5C:   var_ret_12 = esi+00000594 - %x1 = Option13.Value * esi+00000230h - %x1 = Option13.DragMode * esi+00000200h
  loc_00D49F63:   var_ret_12 = CSng()
  loc_00D49F6F: End If
  loc_00D49F82: var_ret_13 = Sgn()
  loc_00D49F92: esi+00000594h = CSng(0000584h)
  loc_00D49F9B: If var_ret_13 Then
  loc_00D49FD1:   ecx = esi+000003BCh + 1
  loc_00D49FE1:   var_ret_14 = CLng(esi+000003BCh)
  loc_00D49FEC:   var_174 = var_ret_14
  loc_00D49FF2:   If var_ret_14 >= 211 Then
  loc_00D49FF4:     var_eax = Err.Raise
  loc_00D4A000:   End If
  loc_00D4A011:   var_174 = var_174 + esi+00000294h
  loc_00D4A013:   var_174 = esi+00000200h
  loc_00D4A01A:   var_ret_15 = CLng(esi+000003BCh)
  loc_00D4A025:   var_174 = var_ret_15
  loc_00D4A02B:   If var_ret_15 >= 211 Then
  loc_00D4A02D:     var_eax = Err.Raise
  loc_00D4A039:   End If
  loc_00D4A04A:   var_174 = var_174 + esi+000002B0h
  loc_00D4A04C:   var_174 = esi+00000230h
  loc_00D4A053:   var_ret_16 = CLng(esi+000003BCh)
  loc_00D4A05E:   var_174 = var_ret_16
  loc_00D4A064:   If var_ret_16 >= 211 Then
  loc_00D4A066:     var_eax = Err.Raise
  loc_00D4A072:   End If
  loc_00D4A083:   var_174 = var_174 + esi+000002CCh
  loc_00D4A085:   var_174 = esi+00000210h
  loc_00D4A0C1:   var_50 = Format(esi+00000200h, "000.00")
  loc_00D4A111:   var_90 = Format(esi+00000210h, "0.000")
  loc_00D4A148:   var_C0 = "000.0"
  loc_00D4A14F:   var_ret_17 = CLng(esi+000003BCh)
  loc_00D4A15D:   If var_ret_17 >= 211 Then
  loc_00D4A15F:     var_eax = Err.Raise
  loc_00D4A165:   End If
  loc_00D4A1B4:   var_60 = esi+000003D0h & var_50
  loc_00D4A217:   var_120 = var_60 & "    " & var_90 & "    " & Format(var_ret_17 + esi+000002B0h + esi+000002B0h + esi+000002B0h, var_C0) & Chr(13) & Chr(10)
  loc_00D4A21D:   ecx = var_120
  loc_00D4A290:   ecx = esi+00000584h
  loc_00D4A296: End If
  loc_00D4A2B8: ecx = esi+00000594
  loc_00D4A2F5: var_ret_18 = (esi+00000210h >= 1)
  loc_00D4A30E: var_ret_19 = (Form2.Option13 <= 0)
  loc_00D4A319: call Or(var_60, var_ret_19, var_ret_18)
  loc_00D4A329: If CBool(Or(var_60, var_ret_19, var_ret_18)) = 0 Then GoTo loc_00D49CE2
  loc_00D4A332: var_eax = Unknown_VTable_Call[ecx+00000348h]
  loc_00D4A352: var_2C = CStr(esi+000003D0h)
  loc_00D4A35A: Option13.MousePointer = var_2C
  loc_00D4A39C: ecx = esi+00000200h
  loc_00D4A3BE: ecx = "YES"
  loc_00D4A3CD: ecx = Option13.ForeColor = Unknown_VTable_Call[ecx+00000348h]
  loc_00D4A3EF: ecx = Option13.ForeColor = Me + var_184
  loc_00D4A409: If (esi+0000051Ch > Me) Then
  loc_00D4A415:   ecx = Me
  loc_00D4A41B:   ecx = Option13.ForeColor =
  loc_00D4A41D: End If
  loc_00D4A423: GoTo loc_00D4A49D
  loc_00D4A49C: Exit Sub
  loc_00D4A49D: 'Referenced from: 00D4A423
  loc_00D4A4A6: Exit Sub
End Sub