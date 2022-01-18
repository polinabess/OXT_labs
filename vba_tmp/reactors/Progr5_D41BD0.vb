Public Sub Progr5() 'D41BD0
  Dim var_3C As OptionButton
  loc_00D41C97: ecx = Me.Top = ecx = %S_edx_S
  loc_00D41CA6: ecx = Me.ForeColor =
  loc_00D41CB8: ecx = esi+00000200h
  loc_00D41CCA: ecx =  = Me.Count
  loc_00D41D13: ecx = Me.WindowState = %StkVar1 - Me.Top = %x1s / 200
  loc_00D41D3B: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D41D68: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D41D82:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D41D8A:   If eax >= 0 Then GoTo loc_00D41E35
  loc_00D41D95:   GoTo loc_00D41E28
  loc_00D41D9A: End If
  loc_00D41DB0: var_3C = -Option13.Refresh
  loc_00D41DD5: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D41E19: var_eax = Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h)
  loc_00D41E21: If Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) < 0 Then
  loc_00D41E28:   'Referenced from: 00D41D95
  loc_00D41E2F:   Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D41E35: End If
  loc_00D41E55: ecx = esi+00000388h / Form2.Option13
  loc_00D41E5A: var_eax = Unknown_VTable_Call[ecx+00000384h]
  loc_00D41E79: Option13.Caption = "  t         X "
  loc_00D41EC2: ecx = vbNullString
  loc_00D41FC6: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & Chr(13) & Chr(10)
  loc_00D4206A: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D42070: 
  loc_00D42072:   If esi+0000039Ch Then
  loc_00D420D4:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D420DA: 
  loc_00D420DC:       If esi+000003ACh Then
  loc_00D4214D:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D42174:         ecx = esi+00000210h + esi+00000388h
  loc_00D42199:         If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D421A4:           var_eax = Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h)
  loc_00D421AC:           If Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h) >= 0 Then GoTo loc_00D421E1
  loc_00D421B3:           GoTo loc_00D421D4
  loc_00D421B5:         End If
  loc_00D421C5:         var_eax = Call Form2.Rrev(Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h), esi+00000240h, esi+00000250h, 1800)
  loc_00D421CD:         If Call Form2.Rrev(Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h) >= 0 Then GoTo loc_00D421E1
  loc_00D421D4:         'Referenced from: 00D421B3
  loc_00D421DB:         Call Form2.Rrev(Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000210h), esi+00000240h, esi+00000250h, 1800) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D421E1: 
  loc_00D42203:         ecx = esi+00000388h / esi+00000320h
  loc_00D42254:         ecx = esi+00000200h + esi+000003E4h + esi+000003F4h / 2
  loc_00D42277:         ecx = esi+000003F4h
  loc_00D42280:         var_ret_9 = CLng(esi+000003BCh)
  loc_00D4228B:         var_100 = var_ret_9
  loc_00D42291:         If var_ret_9 >= 211 Then
  loc_00D42293:           var_eax = Err.Raise
  loc_00D4229F:         End If
  loc_00D422B0:         var_100 = var_100 + esi+00000294h
  loc_00D422B2:         var_100 = esi+00000200h
  loc_00D422BB:         var_ret_A = CLng(esi+000003BCh)
  loc_00D422C6:         var_100 = var_ret_A
  loc_00D422CC:         If var_ret_A >= 211 Then
  loc_00D422CE:           var_eax = Err.Raise
  loc_00D422DA:         End If
  loc_00D422EB:         var_100 = var_100 + esi+000002CCh
  loc_00D422ED:         var_100 = esi+00000210h
  loc_00D42304:       Next esi+000003ACh
  loc_00D42310:       GoTo loc_00D420DA
  loc_00D42315:     End If
  loc_00D42413:     ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & Chr(13) & Chr(10)
  loc_00D42470:   Next esi+0000039Ch
  loc_00D42476:   GoTo loc_00D42070
  loc_00D4247B: End If
  loc_00D4247E: var_eax = Unknown_VTable_Call[edx+00000348h]
  loc_00D4249E: var_18 = CStr(esi+000003D0h)
  loc_00D424A6: Option13.MousePointer = var_18
  loc_00D424E8: ecx = esi+00000200h
  loc_00D4250A: ecx = "NO"
  loc_00D42511: GoTo loc_00D4256C
  loc_00D4256B: Exit Sub
  loc_00D4256C: 'Referenced from: 00D42511
End Sub