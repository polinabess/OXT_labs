Public Sub Progr7() 'D437D0
  Dim var_3C As OptionButton
  Dim var_160 As OptionButton
  loc_00D438BB: ecx = Me.Top = ebx
  loc_00D438CA: ecx = Me.ForeColor =
  loc_00D438DC: ecx = esi+00000200h
  loc_00D438EE: ecx =  = Me.Count
  loc_00D43900: ecx = esi+00000230h
  loc_00D43949: ecx = Me.WindowState = %StkVar1 - Me.Top = %x1s / 200
  loc_00D43971: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D4399E: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D439B8:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D439C0:   If eax >= 0 Then GoTo loc_00D43A6B
  loc_00D439CB:   GoTo loc_00D43A5E
  loc_00D439D0: End If
  loc_00D439E6: var_3C = -Option13.Refresh
  loc_00D43A0B: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D43A4F: var_eax = Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h)
  loc_00D43A57: If Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) < 0 Then
  loc_00D43A5E:   'Referenced from: 00D439CB
  loc_00D43A65:   Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D43A6B: End If
  loc_00D43A8B: ecx = esi+00000388h / Form2.Option13
  loc_00D43A90: var_eax = Unknown_VTable_Call[ecx+00000384h]
  loc_00D43AAF: Option13.Caption = "  t         X          T"
  loc_00D43AF8: ecx = vbNullString
  loc_00D43C48: var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000230h, "000.0")
  loc_00D43C74: ecx = var_CC & Chr(13) & Chr(10)
  loc_00D43D34: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D43D3A: 
  loc_00D43D3C:   If esi+0000039Ch Then
  loc_00D43D9E:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D43DA4: 
  loc_00D43DA6:       If esi+000003ACh Then
  loc_00D43E15:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D43E40:         ecx = esi+00000210h + esi+00000388h
  loc_00D43E89:         ecx =  + Option13.ForeColor = %StkVar1 * %x1 = Option13.FontSize - Option13.Top = %x1s
  loc_00D43EBA:         Call Form2.K_react(esi+00000240h, esi+00000230h, Option13.DragMode = %StkVar1, Option13.TabStop = %x1b, )
  loc_00D43EE7:         If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D43F01:           var_eax = Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h)
  loc_00D43F09:           If Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h) >= 0 Then GoTo loc_00D43FB4
  loc_00D43F14:           GoTo loc_00D43FA7
  loc_00D43F19:         End If
  loc_00D43F2F:         var_3C = -Option13.Refresh
  loc_00D43F54:         Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D43F98:         var_eax = Call Form2.Rrev(esi+00000320h, esi+00000240h, esi+00000250h, esi+00000210h)
  loc_00D43FA0:         If Call Form2.Rrev(esi+00000320h, esi+00000240h, esi+00000250h, esi+00000210h) < 0 Then
  loc_00D43FA7:           'Referenced from: 00D43F14
  loc_00D43FAE:           Call Form2.Rrev(esi+00000320h, esi+00000240h, esi+00000250h, esi+00000210h) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D43FB4:         End If
  loc_00D43FD4:         ecx = esi+00000388h / esi+00000320h
  loc_00D4402B:         ecx = esi+00000200h + esi+000003E4h + esi+000003F4h / 2
  loc_00D4404C:         ecx = esi+000003F4h
  loc_00D44059:         var_ret_C = CLng(esi+000003BCh)
  loc_00D44064:         var_160 = var_ret_C
  loc_00D4406A:         If var_ret_C >= 211 Then
  loc_00D4406C:           var_eax = Err.Raise
  loc_00D44078:         End If
  loc_00D44089:         var_160 = var_160 + esi+00000294h
  loc_00D4408B:         var_160 = esi+00000200h
  loc_00D44098:         var_ret_D = CLng(esi+000003BCh)
  loc_00D440A3:         var_160 = var_ret_D
  loc_00D440A9:         If var_ret_D >= 211 Then
  loc_00D440AB:           var_eax = Err.Raise
  loc_00D440B7:         End If
  loc_00D440C8:         var_160 = var_160 + esi+000002CCh
  loc_00D440CA:         var_160 = esi+00000210h
  loc_00D440D7:         var_ret_E = CLng(esi+000003BCh)
  loc_00D440E2:         var_160 = var_ret_E
  loc_00D440E8:         If var_ret_E >= 211 Then
  loc_00D440EA:           var_eax = Err.Raise
  loc_00D440F6:         End If
  loc_00D44107:         var_160 = var_160 + esi+000002B0h
  loc_00D44109:         var_160 = esi+00000230h
  loc_00D44124:       Next esi+000003ACh
  loc_00D4412A:       GoTo loc_00D43DA4
  loc_00D4412F:     End If
  loc_00D44279:     var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000230h, "000.0")
  loc_00D442A5:     ecx = var_CC & Chr(13) & Chr(10)
  loc_00D4431E:   Next esi+0000039Ch
  loc_00D44324:   GoTo loc_00D43D3A
  loc_00D44329: End If
  loc_00D4432C: var_eax = Unknown_VTable_Call[eax+00000348h]
  loc_00D44350: var_18 = CStr(esi+000003D0h)
  loc_00D44356: var_1B8 = var_18
  loc_00D4436A: Option13.MousePointer = var_18
  loc_00D443AC: ecx = esi+00000200h
  loc_00D443BA: var_114 = "YES"
  loc_00D443CE: ecx = "YES"
  loc_00D443FE: If (%x1 = Option13.FontSize > 0) Then
  loc_00D44406:   ecx = Option13.ForeColor = Me
  loc_00D44423:   GoTo loc_00D44448
  loc_00D44425: End If
  loc_00D4442B: ecx = Option13.ForeColor = var_184 + var_184 = Option13.FontSize
  loc_00D44448: 'Referenced from: 00D44423
  loc_00D44448: ecx = Option13.ForeColor =  +  = Option13.FontSize
  loc_00D44458: GoTo loc_00D444CF
  loc_00D444CE: Exit Sub
  loc_00D444CF: 'Referenced from: 00D44458
End Sub