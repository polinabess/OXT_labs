Public Sub Graf() 'D390A0
  Dim var_4C As Variant
  Dim var_D0 As Me
  loc_00D3918E: var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D391A6: Me.FillStyle = CInt(1)
  loc_00D391EB: var_38 = CInt(100)
  loc_00D3920A: var_48 = CInt(100)
  loc_00D3922E: var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D39241: var_D0 = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D39255: var_48 = CSng(var_45A4B000)
  loc_00D39271: var_38 = CSng(CSng(Me))
  loc_00D39286: var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D392B0: var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D392C7: Me.FillStyle = CInt(2)
  loc_00D392F7: var_E4 = Me.GetPalette 'Ignore this
  loc_00D39311: var_A4 = "DIS"
  loc_00D3932A: If (var_E4 = "DIS") Then
  loc_00D39362:   var_ret_1 = Me.PaletteMode = %StkVar1 / esi+0000050Ch
  loc_00D39374:   var_ret_2 = var_ret_1 * 7260
  loc_00D39397:   var_38 = var_ret_2 + 100
  loc_00D393D2:   var_ret_3 = 1 - Me.PaintPicture %x1s, %x2s, %StkVar3, %StkVar4, %StkVar5, %StkVar6, %StkVar7, %StkVar8, %StkVar9
  loc_00D393DD:   var_ret_4 = 5270 * var_ret_3
  loc_00D393E8:   var_24 = var_ret_4
  loc_00D39409:   var_24 = CSng(var_D0)
  loc_00D39415:   var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3943B:   var_48 = CSng(var_28)
  loc_00D39449:   var_24 = CSng(var_48)
  loc_00D39457:   var_38 = CSng(var_48)
  loc_00D3946C:   var_eax = Unknown_VTable_Call[ecx+0000027Ch]
  loc_00D394EA:   For esi+0000039Ch = 1 To 200 Step 1
  loc_00D394F6: 
  loc_00D394F8:     If esi+0000039Ch Then
  loc_00D39505:       var_ret_5 = CLng(esi+0000039Ch)
  loc_00D39510:       var_D0 = var_ret_5
  loc_00D39516:       If var_ret_5 >= 211 Then
  loc_00D39518:         var_eax = Err.Raise
  loc_00D3951E:       End If
  loc_00D3955B:       var_ret_6 = var_D0 / esi+0000050Ch
  loc_00D3958A:       var_48 = var_ret_6 * 7260 + 100
  loc_00D395B3:       var_ret_8 = CLng(esi+0000039Ch)
  loc_00D395C1:       If var_ret_8 >= 211 Then
  loc_00D395C3:         var_eax = Err.Raise
  loc_00D395C9:       End If
  loc_00D395F2:       var_ret_A = 5270 * 1 - var_ret_8
  loc_00D395F9:       var_ret_A = CSng(var_48)
  loc_00D39605:       var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3962B:       var_48 = CSng(var_28)
  loc_00D39647:       var_38 = CSng(CSng(var_4C))
  loc_00D3965C:       var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D39689:       var_38 = var_48
  loc_00D39698:       var_A4 = var_28
  loc_00D396B1:       var_24 = var_28
  loc_00D396C8:     Next esi+0000039Ch
  loc_00D396CE:     GoTo loc_00D394F6
  loc_00D396D3:   End If
  loc_00D396E4:   If ("COMP" = Me.ForeColor = "COMP") = 0 Then
  loc_00D3974B:     var_38 = Me.PaletteMode = %StkVar1 / esi+0000050Ch * 7260 + 100
  loc_00D3979C:     var_24 = 5270 * 1 - Me.TextHeight %StkVar1
  loc_00D397BD:     var_24 = CSng(6)
  loc_00D397C9:     var_eax = Unknown_VTable_Call[edx+0000034Ch]
  loc_00D397EF:     var_48 = CSng(var_28)
  loc_00D397FD:     var_24 = CSng(var_28)
  loc_00D3980B:     var_38 = CSng(var_28)
  loc_00D39820:     var_eax = Unknown_VTable_Call[edx+0000027Ch]
  loc_00D3989E:     For esi+0000039Ch = 1 To 200 Step 1
  loc_00D398AA: 
  loc_00D398AC:       If esi+0000039Ch Then
  loc_00D398B9:         var_ret_F = CLng(esi+0000039Ch)
  loc_00D398C4:         var_D0 = var_ret_F
  loc_00D398CA:         If var_ret_F >= 211 Then
  loc_00D398CC:           var_eax = Err.Raise
  loc_00D398D2:         End If
  loc_00D3993E:         var_48 = var_D0 / esi+0000050Ch * 7260 + 100
  loc_00D39967:         var_ret_12 = CLng(esi+0000039Ch)
  loc_00D39975:         If var_ret_12 >= 211 Then
  loc_00D39977:           var_eax = Err.Raise
  loc_00D3997D:         End If
  loc_00D399A6:         var_ret_14 = 5270 * 1 - var_ret_12
  loc_00D399AD:         var_ret_14 = CSng(var_38)
  loc_00D399B9:         var_eax = Unknown_VTable_Call[edx+0000034Ch]
  loc_00D399DF:         var_48 = CSng(var_28)
  loc_00D399ED:         var_24 = CSng(var_28)
  loc_00D399FB:         var_38 = CSng(var_28)
  loc_00D39A10:         var_eax = Unknown_VTable_Call[edx+0000027Ch]
  loc_00D39A3D:         var_38 = var_48
  loc_00D39A55:         var_A4 = var_28
  loc_00D39A65:         var_24 = var_28
  loc_00D39A7C:       Next esi+0000039Ch
  loc_00D39A82:       GoTo loc_00D398AA
  loc_00D39A87:     End If
  loc_00D39AE8:     var_38 = Me.PaletteMode = %StkVar1 / esi+0000050Ch * 7260 + 100
  loc_00D39B21:     var_24 = ((&H000800073F800000&H - eax) * &H45A4B000&H)
  loc_00D39B7A:     For esi+0000039Ch = 1 To 200 Step 1
  loc_00D39B80: 
  loc_00D39B82:       If esi+0000039Ch Then
  loc_00D39B8F:         var_ret_17 = CLng(esi+0000039Ch)
  loc_00D39B9A:         var_D0 = var_ret_17
  loc_00D39BA0:         If var_ret_17 >= 211 Then
  loc_00D39BA2:           var_eax = Err.Raise
  loc_00D39BA8:         End If
  loc_00D39C14:         var_48 = var_D0 + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D39C1D:         var_ret_1A = CLng(esi+0000039Ch)
  loc_00D39C2B:         If var_ret_1A >= 211 Then
  loc_00D39C2D:           var_eax = Err.Raise
  loc_00D39C33:         End If
  loc_00D39C58:         var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D39C7E:         var_48 = CSng(var_28)
  loc_00D39C9A:         var_38 = CSng(CSng(var_4C))
  loc_00D39CAF:         var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D39CDC:         var_38 = var_48
  loc_00D39CEB:         var_A4 = var_28
  loc_00D39D04:         var_24 = var_28
  loc_00D39D1B:       Next esi+0000039Ch
  loc_00D39D21:       GoTo loc_00D39B80
  loc_00D39D26:     End If
  loc_00D39D87:     var_38 = esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D39DEA:     var_24 = 5270 * 1 - esi+000002CCh + esi+000002E8h
  loc_00D39E4C:     For esi+0000039Ch = 1 To 200 Step 1
  loc_00D39E52: 
  loc_00D39E54:       If esi+0000039Ch Then
  loc_00D39E61:         var_ret_1F = CLng(esi+0000039Ch)
  loc_00D39E6C:         var_D0 = var_ret_1F
  loc_00D39E72:         If var_ret_1F >= 211 Then
  loc_00D39E74:           var_eax = Err.Raise
  loc_00D39E7A:         End If
  loc_00D39EE6:         var_48 = var_D0 + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D39F0F:         var_ret_22 = CLng(esi+0000039Ch)
  loc_00D39F1D:         If var_ret_22 >= 211 Then
  loc_00D39F1F:           var_eax = Err.Raise
  loc_00D39F25:         End If
  loc_00D39F2C:         var_ret_23 = CLng(esi+0000039Ch)
  loc_00D39F37:         var_D4 = var_ret_23
  loc_00D39F3D:         If var_ret_23 >= 211 Then
  loc_00D39F3F:           var_eax = Err.Raise
  loc_00D39F45:         End If
  loc_00D39F8B:         var_ret_25 = 5270 * 1 - var_ret_22 + esi+000002CCh + var_D4 + esi+000002E8h
  loc_00D39F92:         var_ret_25 = CSng(var_134)
  loc_00D39FA7:         var_eax = Unknown_VTable_Call[edx+0000034Ch]
  loc_00D39FCD:         var_48 = CSng(var_28)
  loc_00D39FDB:         var_24 = CSng(var_28)
  loc_00D39FE9:         var_38 = CSng(var_28)
  loc_00D39FFE:         var_eax = Unknown_VTable_Call[edx+0000027Ch]
  loc_00D3A02B:         var_38 = var_48
  loc_00D3A043:         var_A4 = var_28
  loc_00D3A053:         var_24 = var_28
  loc_00D3A06A:       Next esi+0000039Ch
  loc_00D3A070:       GoTo loc_00D39E52
  loc_00D3A075:     End If
  loc_00D3A075:   End If
  loc_00D3A09D:   If (%x1 = Option16.Name <> "IT") Then
  loc_00D3A104:     var_38 = esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3A18E:     var_24 = 5270 - 5270 * esi+000002B0h - esi+0000052Ch / esi+0000054Ch - esi+0000052Ch
  loc_00D3A1AF:     var_24 = CSng(var_164)
  loc_00D3A1BB:     var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3A1D1:     var_D0 = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3A1E1:     var_48 = CSng(var_28)
  loc_00D3A1FD:     var_38 = CSng(CSng(var_4C))
  loc_00D3A212:     var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3A290:     For esi+0000039Ch = 1 To 200 Step 1
  loc_00D3A29C: 
  loc_00D3A29E:       If esi+0000039Ch Then
  loc_00D3A2AB:         var_ret_2D = CLng(esi+0000039Ch)
  loc_00D3A2B9:         If var_ret_2D >= 211 Then
  loc_00D3A2BB:           var_eax = Err.Raise
  loc_00D3A2C1:         End If
  loc_00D3A327:         var_48 = var_ret_2D + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3A351:         var_ret_30 = CLng(esi+0000039Ch)
  loc_00D3A35F:         If var_ret_30 >= 211 Then
  loc_00D3A361:           var_eax = Err.Raise
  loc_00D3A367:         End If
  loc_00D3A3C8:         var_ret_35 = 5270 - 5270 * var_ret_30 + esi+000002B0h - esi+0000052Ch / esi+0000054Ch - esi+0000052Ch
  loc_00D3A3CB:         var_ret_35 = CSng(var_D0)
  loc_00D3A3D7:         var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3A3ED:         var_D0 = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3A3FD:         var_48 = CSng(var_28)
  loc_00D3A419:         var_38 = CSng(CSng(var_4C))
  loc_00D3A42E:         var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3A45B:         var_38 = var_48
  loc_00D3A46A:         var_A4 = var_28
  loc_00D3A483:         var_24 = var_28
  loc_00D3A49A:       Next esi+0000039Ch
  loc_00D3A4A0:       GoTo loc_00D3A29C
  loc_00D3A4A5:     End If
  loc_00D3A4CD:     If (%x1 = Option16.Name = "PT") Then
  loc_00D3A4F6:       var_A4 = %x1 = Option16.DragMode
  loc_00D3A571:       var_24 = 5270 - 5270 * %x1 = Option16.DragMode - esi+0000052Ch / esi+0000054Ch - esi+0000052Ch
  loc_00D3A577:       var_24 = CSng(var_D0)
  loc_00D3A5C3:       If (var_48 < 7260) = 0 Then GoTo loc_00D3B6B5
  loc_00D3A5F3:       var_48 = 0 + 100
  loc_00D3A5F8:       var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3A61E:       var_48 = CSng(var_28)
  loc_00D3A63A:       var_38 = CSng(CSng(var_4C))
  loc_00D3A64F:       var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3A6A6:       GoTo loc_00D3A599
  loc_00D3A6AB:     End If
  loc_00D3A6B9:     var_A4 = "MIX"
  loc_00D3A6CD:     var_E4 = "MIX"
  loc_00D3A6D2:     If var_E4 Then
  loc_00D3A73F:       var_38 = esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3A790:       var_24 = 5270 * 1 - esi+000002CCh
  loc_00D3A7B1:       var_24 = CSng(0)
  loc_00D3A7BD:       var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3A7E3:       var_48 = CSng(var_28)
  loc_00D3A7F1:       var_24 = CSng(var_48)
  loc_00D3A7FF:       var_38 = CSng(var_48)
  loc_00D3A814:       var_eax = Unknown_VTable_Call[ecx+0000027Ch]
  loc_00D3A83E:       var_eax = Unknown_VTable_Call[edx+0000034Ch]
  loc_00D3A855:       Option16.Font = CInt(2)
  loc_00D3A8C3:       For esi+0000039Ch = 1 To esi+000003BCh Step 1
  loc_00D3A8C9: 
  loc_00D3A8CB:         If esi+0000039Ch Then
  loc_00D3A8D8:           var_ret_3F = CLng(esi+0000039Ch)
  loc_00D3A8E6:           If var_ret_3F >= 211 Then
  loc_00D3A8E8:             var_eax = Err.Raise
  loc_00D3A8EE:           End If
  loc_00D3A954:           var_48 = var_ret_3F + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3A981:           var_ret_42 = CLng(esi+0000039Ch)
  loc_00D3A98F:           If var_ret_42 >= 211 Then
  loc_00D3A991:             var_eax = Err.Raise
  loc_00D3A997:           End If
  loc_00D3A9CB:           var_24 = 5270 * 1 - var_ret_42 + esi+000002CCh
  loc_00D3A9F8:           var_ret_45 = CLng(esi+0000039Ch)
  loc_00D3AA06:           If var_ret_45 >= 211 Then
  loc_00D3AA08:             var_eax = Err.Raise
  loc_00D3AA0E:           End If
  loc_00D3AA37:           var_ret_47 = 5270 * 1 - var_ret_45 + esi+000002CCh
  loc_00D3AA3E:           var_ret_47 = CSng(var_4C)
  loc_00D3AA4A:           var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3AA70:           var_48 = CSng(var_28)
  loc_00D3AA7E:           var_24 = CSng(var_48)
  loc_00D3AA8C:           var_38 = CSng(var_48)
  loc_00D3AAA1:           var_eax = Unknown_VTable_Call[ecx+0000027Ch]
  loc_00D3AADD:         Next esi+0000039Ch
  loc_00D3AAE3:         GoTo loc_00D3A8C9
  loc_00D3AAE8:       End If
  loc_00D3AAF9:       If ("COMP" = Option16.ForeColor = "COMP") = 0 Then
  loc_00D3AB66:         var_38 = esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3ABB7:         var_24 = 5270 * 1 - esi+000002E8h
  loc_00D3ABD8:         var_24 = CSng(var_1A4)
  loc_00D3ABE4:         var_eax = Unknown_VTable_Call[edx+0000034Ch]
  loc_00D3AC0A:         var_48 = CSng(var_28)
  loc_00D3AC18:         var_24 = CSng(var_28)
  loc_00D3AC26:         var_38 = CSng(var_28)
  loc_00D3AC3B:         var_eax = Unknown_VTable_Call[edx+0000027Ch]
  loc_00D3ACA9:         For esi+0000039Ch = 1 To esi+000003BCh Step 1
  loc_00D3ACAF: 
  loc_00D3ACB1:           If var_1C4 Then
  loc_00D3ACB8:             var_ret_4C = CLng(esi+0000039Ch)
  loc_00D3ACC3:             var_D0 = var_ret_4C
  loc_00D3ACC9:             If var_ret_4C >= 211 Then
  loc_00D3ACCB:               var_eax = Err.Raise
  loc_00D3ACD1:             End If
  loc_00D3ACE0:             var_D0 = var_D0 + esi+00000294h
  loc_00D3AD3D:             var_48 = var_D0 / esi+0000050Ch * 7260 + 100
  loc_00D3AD64:             var_ret_4F = CLng(esi+0000039Ch)
  loc_00D3AD72:             If var_ret_4F >= 211 Then
  loc_00D3AD74:               var_eax = Err.Raise
  loc_00D3AD7A:             End If
  loc_00D3ADAE:             var_24 = 5270 * 1 - var_ret_4F + esi+000002E8h
  loc_00D3ADB8:             var_24 = CSng(var_D0)
  loc_00D3ADC4:             var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3ADEA:             var_48 = CSng(var_28)
  loc_00D3AE06:             var_38 = CSng(CSng(var_4C))
  loc_00D3AE1B:             var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3AE57:           Next esi+0000039Ch
  loc_00D3AE5D:           GoTo loc_00D3ACAF
  loc_00D3AE62:         End If
  loc_00D3AEA3:         For esi+0000039Ch = 1 To esi+000003BCh Step 1
  loc_00D3AEA9: 
  loc_00D3AEAB:           If var_1E4 Then
  loc_00D3AEB2:             var_ret_52 = CLng(esi+0000039Ch)
  loc_00D3AEBD:             var_D0 = var_ret_52
  loc_00D3AEC3:             If var_ret_52 >= 211 Then
  loc_00D3AEC5:               var_eax = Err.Raise
  loc_00D3AECB:             End If
  loc_00D3AF37:             var_48 = var_D0 + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3AF3E:             var_ret_55 = CLng(esi+0000039Ch)
  loc_00D3AF4C:             If var_ret_55 >= 211 Then
  loc_00D3AF4E:               var_eax = Err.Raise
  loc_00D3AF54:             End If
  loc_00D3AF8C:             var_24 = ((&H000800073F800000&H - ecx+ebx*4) * &H45A4B000&H)
  loc_00D3AF96:             var_24 = CSng(var_1B4)
  loc_00D3AFA2:             var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3AFC8:             var_48 = CSng(var_28)
  loc_00D3AFE4:             var_38 = CSng(CSng(var_4C))
  loc_00D3AFF9:             var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3B035:           Next esi+0000039Ch
  loc_00D3B03B:           GoTo loc_00D3AEA9
  loc_00D3B040:         End If
  loc_00D3B081:         For esi+0000039Ch = 1 To esi+000003BCh Step 1
  loc_00D3B087: 
  loc_00D3B089:           If var_204 Then
  loc_00D3B090:             var_ret_56 = CLng(esi+0000039Ch)
  loc_00D3B09B:             var_D0 = var_ret_56
  loc_00D3B0A1:             If var_ret_56 >= 211 Then
  loc_00D3B0A3:               var_eax = Err.Raise
  loc_00D3B0A9:             End If
  loc_00D3B115:             var_48 = var_D0 + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3B13C:             var_ret_59 = CLng(esi+0000039Ch)
  loc_00D3B147:             var_D0 = var_ret_59
  loc_00D3B14D:             If var_ret_59 >= 211 Then
  loc_00D3B14F:               var_eax = Err.Raise
  loc_00D3B155:             End If
  loc_00D3B156:             var_ret_5A = CLng(esi+0000039Ch)
  loc_00D3B164:             If var_ret_5A >= 211 Then
  loc_00D3B166:               var_eax = Err.Raise
  loc_00D3B16C:             End If
  loc_00D3B189:             esi+000002CCh = esi+000002CCh + var_D0
  loc_00D3B1A0:             esi+000002E8h = esi+000002E8h + var_ret_5A
  loc_00D3B1BD:             var_24 = 5270 * 1 - esi+000002CCh + esi+000002E8h
  loc_00D3B1D0:             var_24 = CSng(var_1D4)
  loc_00D3B1DC:             var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3B202:             var_48 = CSng(var_28)
  loc_00D3B210:             var_24 = CSng(var_48)
  loc_00D3B21E:             var_38 = CSng(var_48)
  loc_00D3B233:             var_eax = Unknown_VTable_Call[ecx+0000027Ch]
  loc_00D3B26F:           Next esi+0000039Ch
  loc_00D3B275:           GoTo loc_00D3B087
  loc_00D3B27A:         End If
  loc_00D3B27A:       End If
  loc_00D3B2A2:       If (%x1 = Option16.Name <> "IT") Then
  loc_00D3B30F:         var_38 = esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3B3AC:         var_24 = 5270 - 5270 * esi+000002B0h - esi+0000052Ch / esi+0000054Ch - esi+0000052Ch
  loc_00D3B3B6:         var_24 = CSng(var_204)
  loc_00D3B3C2:         var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D3B3E8:         var_48 = CSng(var_28)
  loc_00D3B404:         var_38 = CSng(CSng(var_4C))
  loc_00D3B419:         var_eax = Unknown_VTable_Call[eax+0000027Ch]
  loc_00D3B443:         var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3B45A:         Option16.Font = CInt(2)
  loc_00D3B4C8:         For esi+0000039Ch = 1 To esi+000003BCh Step 1
  loc_00D3B4CE: 
  loc_00D3B4D0:           If esi+0000039Ch Then
  loc_00D3B4DD:             var_ret_64 = CLng(esi+0000039Ch)
  loc_00D3B4EB:             If var_ret_64 >= 211 Then
  loc_00D3B4ED:               var_eax = Err.Raise
  loc_00D3B4F3:             End If
  loc_00D3B559:             var_48 = var_ret_64 + esi+00000294h / esi+0000050Ch * 7260 + 100
  loc_00D3B583:             var_ret_67 = CLng(esi+0000039Ch)
  loc_00D3B591:             If var_ret_67 >= 211 Then
  loc_00D3B593:               var_eax = Err.Raise
  loc_00D3B599:             End If
  loc_00D3B601:             var_24 = 5270 - 5270 * var_ret_67 + esi+000002B0h - esi+0000052Ch / esi+0000054Ch - esi+0000052Ch
  loc_00D3B60B:             var_24 = CSng(var_4C)
  loc_00D3B617:             var_eax = Unknown_VTable_Call[ecx+0000034Ch]
  loc_00D3B63D:             var_48 = CSng(var_28)
  loc_00D3B64B:             var_24 = CSng(var_48)
  loc_00D3B659:             var_38 = CSng(var_48)
  loc_00D3B66E:             var_eax = Unknown_VTable_Call[ecx+0000027Ch]
  loc_00D3B6AA:           Next esi+0000039Ch
  loc_00D3B6B0:           GoTo loc_00D3B4CE
  loc_00D3B6B5:         End If
  loc_00D3B6B5:       End If
  loc_00D3B6B5:     End If
  loc_00D3B6B5:   End If
  loc_00D3B6B5: End If
  loc_00D3B6BB: GoTo loc_00D3B6EC
  loc_00D3B6EB: Exit Sub
  loc_00D3B6EC: 'Referenced from: 00D3B6BB
  loc_00D3B79F: Exit Sub
End Sub