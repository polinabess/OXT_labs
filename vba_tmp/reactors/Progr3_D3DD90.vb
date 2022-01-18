Public Sub Progr3() 'D3DD90
  Dim var_3C As OptionButton
  Dim var_1E0 As OptionButton
  loc_00D3DEAB: ecx = Me.Top = ecx = %S_edx_S
  loc_00D3DEBA: ecx = Me.ForeColor =
  loc_00D3DECC: ecx = esi+00000200h
  loc_00D3DEDE: ecx =  = Me.Count
  loc_00D3DEF0: ecx = esi+00000230h
  loc_00D3DF03: If var_D4F000 = 0 Then
  loc_00D3DF0B:   GoTo loc_00D3DF18
  loc_00D3DF0D: End If
  loc_00D3DF13: call _adj_fdiv_m32(var_401368)
  loc_00D3DF18: 'Referenced from: 00D3DF0B
  loc_00D3DF34: ecx = esi+00000230h
  loc_00D3DF46: ecx = esi+00000230h
  loc_00D3DF53: esi+00000230h = CSng()
  loc_00D3DF7F: ecx = "NO"
  loc_00D3DFAB: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D3DFD8: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D3DFF2:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D3DFFA:   If eax >= 0 Then GoTo loc_00D3E0A5
  loc_00D3E005:   GoTo loc_00D3E098
  loc_00D3E00A: End If
  loc_00D3E015: var_ret_1 = -Option13.Refresh
  loc_00D3E020: var_3C = var_ret_1
  loc_00D3E045: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D3E089: var_eax = Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h)
  loc_00D3E091: If Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) < 0 Then
  loc_00D3E098:   'Referenced from: 00D3E005
  loc_00D3E09F:   Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, esi+00000210h) = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D3E0A5: End If
  loc_00D3E0B1: var_154 = esi+00000398h
  loc_00D3E0DB: ecx = Form2.Option13 * esi+00000398
  loc_00D3E0E9: var_154 = esi+00000398h
  loc_00D3E125: ecx = %x1 = Option13.FontSize * Form2.Option13 * esi+00000398
  loc_00D3E14F: If (%x1 = Option13.Name = "PT") Then
  loc_00D3E180:   var_154 = %x1 = Option13.DragMode
  loc_00D3E18C:   var_164 = esi+00000398h
  loc_00D3E1D4:   ecx =  - %x1 = Option13.Value * esi+00000230h - %x1 = Option13.DragMode * esi+00000398
  loc_00D3E1D6: End If
  loc_00D3E20B: If (esi+000003E4h > 0.1#) Then
  loc_00D3E244:   var_3C = "Время реакции"
  loc_00D3E267:   var_2C = "Большой начальный градиент Х!"
  loc_00D3E290:   var_194 = MsgBox(var_2C, 0, var_3C, var_4C, var_5C)
  loc_00D3E2A0:   ecx = MsgBox(var_2C, 0, var_3C, var_4C, var_5C)
  loc_00D3E2BD:   GoTo loc_00D3F392
  loc_00D3E2C2: End If
  loc_00D3E2C5: var_eax = Unknown_VTable_Call[ecx+00000384h]
  loc_00D3E2E4: Option13.Caption = "  t         X          T"
  loc_00D3E32D: ecx = vbNullString
  loc_00D3E47D: var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000230h, "000.0")
  loc_00D3E4A9: ecx = var_CC & Chr(13) & Chr(10)
  loc_00D3E569: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D3E56F: 
  loc_00D3E571:   If esi+0000039Ch Then
  loc_00D3E5D3:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D3E5D9: 
  loc_00D3E5DB:       If esi+000003ACh Then
  loc_00D3E64A:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D3E675:         ecx = esi+00000210h + esi+000003E4h
  loc_00D3E6A0:         ecx = esi+00000230h + esi+00000424h
  loc_00D3E6D6:         If (esi+00000444h >= 1) Then
  loc_00D3E6F8:           ecx = 0
  loc_00D3E71A:           GoTo loc_00D3E8DB
  loc_00D3E71F:         End If
  loc_00D3E745:         Call Form2.K_react(esi+00000240h, esi+00000464h, Option13.DragMode = %StkVar1, Option13.TabStop = %x1b, )
  loc_00D3E772:         If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D3E790:           var_eax = Call Form2.Rirr(esi+00000320h, esi+00000240h, esi+00000444h)
  loc_00D3E7AC: 
  loc_00D3E7C4:           var_154 = esi+00000398h
  loc_00D3E7E2:           ecx = esi+00000320h * esi+00000398
  loc_00D3E7FC:           var_154 = esi+00000398h
  loc_00D3E82C:           ecx = %x1 = Option13.FontSize * esi+00000320h * esi+00000398
  loc_00D3E856:           If (%x1 = Option13.Name = "PT") Then
  loc_00D3E86D:             var_154 = %x1 = Option13.DragMode
  loc_00D3E894:             var_164 = esi+00000398h
  loc_00D3E8CD:             var_ret_11 = esi+00000434h - %x1 = Option13.Value * esi+00000230h - %x1 = Option13.DragMode * esi+00000398
  loc_00D3E8DB:             'Referenced from: 00D3E71A
  loc_00D3E8DB:             ecx = var_ret_11
  loc_00D3E8DD:           End If
  loc_00D3E932:           ecx = esi+00000210h + esi+000003E4h + esi+000003F4h / 2
  loc_00D3E953:           ecx = esi+000003F4h
  loc_00D3E9AE:           ecx = esi+00000230h + esi+00000424h + esi+00000434h / 2
  loc_00D3E9CF:           ecx = esi+00000434h
  loc_00D3E9E1:           var_154 = esi+00000398h
  loc_00D3EA0B:           ecx = esi+00000200h + esi+00000398
  loc_00D3EA1D:           var_ret_14 = CLng(esi+000003BCh)
  loc_00D3EA28:           var_1E0 = var_ret_14
  loc_00D3EA2E:           If var_ret_14 >= 211 Then
  loc_00D3EA30:             var_eax = Err.Raise
  loc_00D3EA3C:           End If
  loc_00D3EA4D:           var_1E0 = var_1E0 + esi+00000294h
  loc_00D3EA4F:           var_1E0 = esi+00000200h
  loc_00D3EA5C:           var_ret_15 = CLng(esi+000003BCh)
  loc_00D3EA67:           var_1E0 = var_ret_15
  loc_00D3EA6D:           If var_ret_15 >= 211 Then
  loc_00D3EA6F:             var_eax = Err.Raise
  loc_00D3EA7B:           End If
  loc_00D3EA8C:           var_1E0 = var_1E0 + esi+000002CCh
  loc_00D3EA8E:           var_1E0 = esi+00000210h
  loc_00D3EA9B:           var_ret_16 = CLng(esi+000003BCh)
  loc_00D3EAA6:           var_1E0 = var_ret_16
  loc_00D3EAAC:           If var_ret_16 >= 211 Then
  loc_00D3EAAE:             var_eax = Err.Raise
  loc_00D3EABA:           End If
  loc_00D3EACB:           var_1E0 = var_1E0 + esi+000002B0h
  loc_00D3EACD:           var_1E0 = esi+00000230h
  loc_00D3EAEA:           If (esi+00000230h < esi+0000051Ch) Then
  loc_00D3EAF8:             ecx = esi+00000230h
  loc_00D3EAFE:           End If
  loc_00D3EB15:           If (esi+00000230h > esi+0000053Ch) Then
  loc_00D3EB23:             ecx = esi+00000230h
  loc_00D3EB29:           End If
  loc_00D3EB2F:           var_154 = "NO"
  loc_00D3EB54:           If (esi+00000560h = "NO") Then
  loc_00D3EB87:             var_ret_18 = CLng(esi+000003BCh - 1)
  loc_00D3EB92:             var_1E0 = var_ret_18
  loc_00D3EB98:             If var_ret_18 >= 211 Then
  loc_00D3EB9A:               var_eax = Err.Raise
  loc_00D3EBA6:             End If
  loc_00D3EBB6:             var_1E0 = var_1E0 + esi+000002B0h
  loc_00D3EBC2:             If (esi+00000230h < var_1E0) Then
  loc_00D3EBE5:               var_3C = "000.00"
  loc_00D3EC18:               var_ret_1A = CLng(esi+000003BCh - 1)
  loc_00D3EC23:               var_1E0 = var_ret_1A
  loc_00D3EC29:               If var_ret_1A >= 211 Then
  loc_00D3EC2B:                 var_eax = Err.Raise
  loc_00D3EC37:               End If
  loc_00D3EC4F:               var_4C = Format(var_1E0 + esi+00000294h, var_3C)
  loc_00D3EC86:               var_8C = "0.000"
  loc_00D3ECB9:               var_ret_1C = CLng(esi+000003BCh - 1)
  loc_00D3ECC4:               var_1E4 = var_ret_1C
  loc_00D3ECCA:               If var_ret_1C >= 211 Then
  loc_00D3ECCC:                 var_eax = Err.Raise
  loc_00D3ECD8:               End If
  loc_00D3ECF6:               var_9C = Format(var_1E4 + esi+000002CCh, var_8C)
  loc_00D3ED2D:               var_DC = "000.0"
  loc_00D3ED63:               var_ret_1E = CLng(esi+000003BCh - 1)
  loc_00D3ED6E:               var_1E8 = var_ret_1E
  loc_00D3ED74:               If var_ret_1E >= 211 Then
  loc_00D3ED76:                 var_eax = Err.Raise
  loc_00D3ED82:               End If
  loc_00D3EDAF:               var_1D4 = "  maxT"
  loc_00D3EE39:               var_10C = esi+000003D0h & var_4C & "   " & var_9C & "    " & Format(var_1E8 + esi+000002B0h + esi+000002B0h + esi+000002B0h, var_DC) & "  maxT"
  loc_00D3EE65:               ecx = var_10C & Chr(13) & Chr(10)
  loc_00D3EEF6:               ecx = "YES"
  loc_00D3EEFC:             End If
  loc_00D3EEFC:           End If
  loc_00D3EF11:         Next esi+000003ACh
  loc_00D3EF17:         GoTo loc_00D3E5D9
  loc_00D3EF1C:       End If
  loc_00D3EF32:       var_3C = -Option13.Refresh
  loc_00D3EF57:       Call Form2.K_react(esi+00000250h, esi+00000464h, Option13.DragMode = %StkVar1, var_228, )
  loc_00D3EF9B:       var_eax = Call Form2.Rrev(esi+00000320h, esi+00000240h, esi+00000250h, esi+00000444h)
  loc_00D3EFE2:       If (esi+00000320h <= 0) = 0 Then GoTo loc_00D3E7AC
  loc_00D3F008:       ecx = 0
  loc_00D3F02A:       GoTo loc_00D3E8DB
  loc_00D3F02F:     End If
  loc_00D3F179:     var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000230h, "000.0")
  loc_00D3F18A:     var_EC = var_CC & Chr(13)
  loc_00D3F1A5:     ecx = var_EC & Chr(10)
  loc_00D3F21E:   Next esi+0000039Ch
  loc_00D3F224:   GoTo loc_00D3E56F
  loc_00D3F229: End If
  loc_00D3F22C: var_eax = Unknown_VTable_Call[ecx+00000348h]
  loc_00D3F250: var_EC & var_FC = CStr(esi+000003D0h)
  loc_00D3F260: Option13.MousePointer = var_EC & Chr(10)
  loc_00D3F2A2: ecx = esi+00000200h
  loc_00D3F2C4: ecx = "YES"
  loc_00D3F2EE: If (%x1 = Option13.Name = "PT") Then
  loc_00D3F321:   If (%x1 = Option13.DragMode < esi+0000051Ch) Then
  loc_00D3F331:     var_154 = %x1 = Option13.DragMode
  loc_00D3F341:     ecx = var_1F8 = Option13.DragMode
  loc_00D3F343:   End If
  loc_00D3F370:   If (%x1 = Option13.DragMode > esi+0000053Ch) Then
  loc_00D3F380:     var_154 = %x1 = Option13.DragMode
  loc_00D3F390:     ecx =  = Option13.DragMode
  loc_00D3F392:   End If
  loc_00D3F392: End If
  loc_00D3F398: GoTo loc_00D3F42E
  loc_00D3F42D: Exit Sub
  loc_00D3F42E: 'Referenced from: 00D3F398
  loc_00D3F455: Exit Sub
End Sub