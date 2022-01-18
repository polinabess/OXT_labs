Public Sub Progr1() 'D3B7D0
  Dim var_3C As OptionButton
  loc_00D3B89D: ecx = Me.Top = ebx
  loc_00D3B8AC: ecx = Me.ForeColor =
  loc_00D3B8BE: ecx = esi+00000200h
  loc_00D3B8D0: ecx =  = Me.Count
  loc_00D3B8E3: If var_D4F000 = 0 Then
  loc_00D3B8EB:   GoTo loc_00D3B8F8
  loc_00D3B8ED: End If
  loc_00D3B8F3: call _adj_fdiv_m32(var_401368)
  loc_00D3B8F8: 'Referenced from: 00D3B8EB
  loc_00D3B92E: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, , )
  loc_00D3B95B: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D3B975:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D3B97D:   If eax >= 0 Then GoTo loc_00D3BA28
  loc_00D3B988:   GoTo loc_00D3BA1B
  loc_00D3B98D: End If
  loc_00D3B9A3: var_3C = -Option13.Refresh
  loc_00D3B9C8: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D3BA0C: var_eax = Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h)
  loc_00D3BA14: If Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) < 0 Then
  loc_00D3BA1B:   'Referenced from: 00D3B988
  loc_00D3BA22:   Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D3BA28: End If
  loc_00D3BA34: var_D4 = esi+00000398h
  loc_00D3BA5E: ecx = Form2.Option13 * esi+00000398
  loc_00D3BA95: If (esi+000003E4h > 0.1#) Then
  loc_00D3BB2A:   ecx = MsgBox("Большой начальный градиент Х!", 0, "Время реакции", var_4C, var_5C)
  loc_00D3BB47:   GoTo loc_00D3C31B
  loc_00D3BB4C: End If
  loc_00D3BB4F: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D3BB6E: Option13.Caption = "  t         X "
  loc_00D3BBB7: ecx = vbNullString
  loc_00D3BCBB: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & Chr(13) & Chr(10)
  loc_00D3BD5F: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D3BD65: 
  loc_00D3BD67:   If esi+0000039Ch Then
  loc_00D3BDC9:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D3BDCF: 
  loc_00D3BDD1:       If esi+000003ACh Then
  loc_00D3BE42:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D3BE6F:         ecx = esi+00000210h + esi+000003E4h
  loc_00D3BE9F:         If (esi+00000444h >= 1) Then
  loc_00D3BEAB:           GoTo loc_00D3C109
  loc_00D3BEB0:         End If
  loc_00D3BEC1:         If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D3BED9:           var_eax = Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000444h)
  loc_00D3BEF5: 
  loc_00D3BF0D:           var_D4 = esi+00000398h
  loc_00D3BF2B: 
  loc_00D3BF2D:           ecx = esi+00000320h * esi+00000398
  loc_00D3BF7E:           ecx = esi+00000210h + esi+000003E4h + esi+000003F4h / 2
  loc_00D3BFA1:           ecx = esi+000003F4h
  loc_00D3BFBB:           var_D4 = esi+00000398h
  loc_00D3BFD9:           ecx = esi+00000200h + esi+00000398
  loc_00D3BFEB:           var_ret_7 = CLng(esi+000003BCh)
  loc_00D3BFF6:           var_120 = var_ret_7
  loc_00D3BFFC:           If var_ret_7 >= 211 Then
  loc_00D3BFFE:             var_eax = Err.Raise
  loc_00D3C00A:           End If
  loc_00D3C01B:           var_120 = var_120 + esi+00000294h
  loc_00D3C01D:           var_120 = esi+00000200h
  loc_00D3C026:           var_ret_8 = CLng(esi+000003BCh)
  loc_00D3C031:           var_120 = var_ret_8
  loc_00D3C037:           If var_ret_8 >= 211 Then
  loc_00D3C039:             var_eax = Err.Raise
  loc_00D3C045:           End If
  loc_00D3C056:           var_120 = var_120 + esi+000002CCh
  loc_00D3C058:           var_120 = esi+00000210h
  loc_00D3C06F:         Next esi+000003ACh
  loc_00D3C07B:         GoTo loc_00D3BDCF
  loc_00D3C080:       End If
  loc_00D3C091:       If (%x1 = %StkVar3 & %StkVar2 >= esi+000004A4h) Then
  loc_00D3C09D:         GoTo loc_00D3C109
  loc_00D3C09F:       End If
  loc_00D3C0B8:       Call Form2.Rrev(esi+00000320h, esi+00000240h, esi+00000250h, %x1 = %StkVar3 & %StkVar2)
  loc_00D3C0FD:       If (esi+00000320h <= "") = 0 Then GoTo loc_00D3BEF5
  loc_00D3C109:       'Referenced from: 00D3BEAB
  loc_00D3C11F:       GoTo loc_00D3BF2B
  loc_00D3C124:     End If
  loc_00D3C15A:     var_3C = Format(esi+00000200h, "000.00")
  loc_00D3C1A7:     var_7C = Format(esi+00000210h, "0.000")
  loc_00D3C1B6:     var_9C = Chr(13)
  loc_00D3C1C5:     var_BC = Chr(10)
  loc_00D3C1DA:     var_eax = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C1E8:     var_eax = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C1F6:     var_eax = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C207:     var_eax = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C218:     var_eax = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C222:     ecx = Unknown_VTable_Call[esi+000003F4h]
  loc_00D3C27F:   Next esi+0000039Ch
  loc_00D3C285:   GoTo loc_00D3BD65
  loc_00D3C28A: End If
  loc_00D3C28D: var_eax = Unknown_VTable_Call[edx+00000348h]
  loc_00D3C2AD: var_18 = CStr(esi+000003D0h)
  loc_00D3C2B5: Option13.MousePointer = var_18
  loc_00D3C2F7: ecx = esi+00000200h
  loc_00D3C319: ecx = "NO"
  loc_00D3C31B: 'Referenced from: 00D3BB47
  loc_00D3C321: GoTo loc_00D3C37C
  loc_00D3C37B: Exit Sub
  loc_00D3C37C: 'Referenced from: 00D3C321
  loc_00D3C3A3: Exit Sub
End Sub