Public Sub Variant_process() 'D36800
  Dim var_18 As Me
  Dim var_28 As Me
  loc_00D36870: var_eax = Call Form2.Clean
  loc_00D36892: var_70 = Me.GetPalette 'Ignore this
  loc_00D368BA: If (var_70 = "DIS") Then
  loc_00D368C6:   var_80 = 32776 = Me.Name
  loc_00D368E3:   If (var_80 = "IT") Then
  loc_00D368EC:     var_eax = Unknown_VTable_Call[eax+000004F4h]
  loc_00D36906:     Me.Height = NAN
  loc_00D36935:     var_44 = Unknown_VTable_Call[eax+000004F4h] = Me.ForeColor
  loc_00D3694C:     If (var_44 = "COMP") = 0 Then
  loc_00D36951:       var_eax = Unknown_VTable_Call[ecx+000004F8h]
  loc_00D36966:       Me.Height = NAN
  loc_00D3698F:       var_eax = Unknown_VTable_Call[eax+000004E4h]
  loc_00D36995:       GoTo loc_00D3719A
  loc_00D3699A:     End If
  loc_00D369AB:     If (var_44 = "SIRR") = 0 Then
  loc_00D369B0:       var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D369C5:       Me.Height = NAN
  loc_00D369EE:       var_eax = Unknown_VTable_Call[edx+000004B0h]
  loc_00D369F4:       GoTo loc_00D3721C
  loc_00D369F9:     End If
  loc_00D36A0A:     If (var_44 <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D36A13:     var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D36A28:     Me.Height = NAN
  loc_00D36A51:     var_eax = Unknown_VTable_Call[eax+000004B0h]
  loc_00D36A57:     GoTo loc_00D3719A
  loc_00D36A5C:   End If
  loc_00D36A64:   var_20 = "AD"
  loc_00D36A73:   If var_28 Then
  loc_00D36A7C:     var_eax = Unknown_VTable_Call[ecx+000004D4h]
  loc_00D36A96:     Me.Height = NAN
  loc_00D36AC5:     var_48 = Unknown_VTable_Call[ecx+000004D4h] = Me.ForeColor
  loc_00D36ADC:     If (var_48 = "COMP") = 0 Then
  loc_00D36AE1:       var_eax = Unknown_VTable_Call[edx+000004F8h]
  loc_00D36AF6:       Me.Height = NAN
  loc_00D36B1F:       var_eax = Unknown_VTable_Call[eax+000004B8h]
  loc_00D36B25:       GoTo loc_00D3719A
  loc_00D36B2A:     End If
  loc_00D36B3B:     If (var_48 = "SIRR") = 0 Then
  loc_00D36B40:       var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D36B55:       Me.Height = NAN
  loc_00D36B7E:       var_eax = Unknown_VTable_Call[edx+000004ACh]
  loc_00D36B84:       GoTo loc_00D3721C
  loc_00D36B89:     End If
  loc_00D36B9A:     If (var_48 <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D36BA3:     var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D36BB8:     Me.Height = NAN
  loc_00D36BE1:     var_eax = Unknown_VTable_Call[eax+000004ACh]
  loc_00D36BE7:     GoTo loc_00D3719A
  loc_00D36BEC:   End If
  loc_00D36BF4:   var_20 = "PT"
  loc_00D36C03:   If var_28 = 0 Then GoTo loc_00D372EF
  loc_00D36C0C:   var_eax = Unknown_VTable_Call[ecx+000004D0h]
  loc_00D36C26:   Me.Height = NAN
  loc_00D36C55:   var_4C = Unknown_VTable_Call[ecx+000004D0h] = Me.ForeColor
  loc_00D36C6C:   If (var_4C = "COMP") = 0 Then
  loc_00D36C71:     var_eax = Unknown_VTable_Call[edx+000004F8h]
  loc_00D36C86:     Me.Height = NAN
  loc_00D36CAF:     var_eax = Unknown_VTable_Call[eax+000004B4h]
  loc_00D36CB5:     GoTo loc_00D3719A
  loc_00D36CBA:   End If
  loc_00D36CCB:   If (var_4C = "SIRR") = 0 Then
  loc_00D36CD0:     var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D36CE5:     Me.Height = NAN
  loc_00D36D0E:     var_eax = Unknown_VTable_Call[edx+000004A8h]
  loc_00D36D14:     GoTo loc_00D3721C
  loc_00D36D19:   End If
  loc_00D36D2A:   If (var_4C <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D36D33:   var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D36D48:   Me.Height = NAN
  loc_00D36D71:   var_eax = Unknown_VTable_Call[eax+000004A8h]
  loc_00D36D77:   GoTo loc_00D3719A
  loc_00D36D7C: End If
  loc_00D36D84: var_20 = "MIX"
  loc_00D36D93: If var_28 = 0 Then GoTo loc_00D372EF
  loc_00D36DA2: var_90 = var_70 = Me.Name
  loc_00D36DB3: var_20 = "IT"
  loc_00D36DC2: If var_90 Then
  loc_00D36DCB:   var_eax = Unknown_VTable_Call[eax+000004CCh]
  loc_00D36DE5:   Me.Height = NAN
  loc_00D36E14:   var_50 = Unknown_VTable_Call[eax+000004CCh] = Me.ForeColor
  loc_00D36E2B:   If (var_50 = "COMP") = 0 Then
  loc_00D36E30:     var_eax = Unknown_VTable_Call[ecx+000004F8h]
  loc_00D36E45:     Me.Height = NAN
  loc_00D36E6E:     var_eax = Unknown_VTable_Call[eax+000004A4h]
  loc_00D36E74:     GoTo loc_00D3719A
  loc_00D36E79:   End If
  loc_00D36E8A:   If (var_50 = "SIRR") = 0 Then
  loc_00D36E8F:     var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D36EA4:     Me.Height = NAN
  loc_00D36ECD:     var_eax = Unknown_VTable_Call[edx+00000498h]
  loc_00D36ED3:     GoTo loc_00D3721C
  loc_00D36ED8:   End If
  loc_00D36EE9:   If (var_50 <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D36EF2:   var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D36F07:   Me.Height = NAN
  loc_00D36F30:   var_eax = Unknown_VTable_Call[eax+00000498h]
  loc_00D36F36:   GoTo loc_00D3719A
  loc_00D36F3B: End If
  loc_00D36F46: var_20 = "AD"
  loc_00D36F55: If var_28 Then
  loc_00D36F5E:   var_eax = Unknown_VTable_Call[ecx+000004C8h]
  loc_00D36F78:   Me.Height = NAN
  loc_00D36FA7:   var_54 = Unknown_VTable_Call[ecx+000004C8h] = Me.ForeColor
  loc_00D36FBE:   If (var_54 = "COMP") = 0 Then
  loc_00D36FC3:     var_eax = Unknown_VTable_Call[edx+000004F8h]
  loc_00D36FD8:     Me.Height = NAN
  loc_00D37001:     var_eax = Unknown_VTable_Call[eax+000004A0h]
  loc_00D37007:     GoTo loc_00D3719A
  loc_00D3700C:   End If
  loc_00D3701D:   If (var_54 = "SIRR") = 0 Then
  loc_00D37022:     var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D37037:     Me.Height = NAN
  loc_00D37060:     var_eax = Unknown_VTable_Call[edx+00000494h]
  loc_00D37066:     GoTo loc_00D3721C
  loc_00D3706B:   End If
  loc_00D3707C:   If (var_54 <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D37085:   var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D3709A:   Me.Height = NAN
  loc_00D370C3:   var_eax = Unknown_VTable_Call[eax+00000494h]
  loc_00D370C9:   GoTo loc_00D3719A
  loc_00D370CE: End If
  loc_00D370D9: var_20 = "PT"
  loc_00D370E8: If var_28 = 0 Then GoTo loc_00D372EF
  loc_00D370F1: var_eax = Unknown_VTable_Call[ecx+000004C4h]
  loc_00D3710B: Me.Height = NAN
  loc_00D3713A: var_58 = Unknown_VTable_Call[ecx+000004C4h] = Me.ForeColor
  loc_00D37151: If (var_58 = "COMP") = 0 Then
  loc_00D37156:   var_eax = Unknown_VTable_Call[edx+000004F8h]
  loc_00D3716B:   Me.Height = NAN
  loc_00D37194:   var_eax = Unknown_VTable_Call[eax+0000049Ch]
  loc_00D3719A:   'Referenced from: 00D36995
  loc_00D371A6:   var_3C = Unknown_VTable_Call[eax+0000049Ch]
  loc_00D371A9:   Me.Height = NAN
  loc_00D371B3:   If Unknown_VTable_Call[eax+0000049Ch] < 0 Then
  loc_00D371B9:     GoTo loc_00D372D3
  loc_00D371BE:   End If
  loc_00D371CF:   If (var_58 = "SIRR") = 0 Then
  loc_00D371D8:     var_eax = Unknown_VTable_Call[eax+000004C0h]
  loc_00D371ED:     Me.Height = NAN
  loc_00D37216:     var_eax = Unknown_VTable_Call[edx+00000490h]
  loc_00D3721C:     'Referenced from: 00D369F4
  loc_00D3722B:     Me.Height = NAN
  loc_00D3726B:     If (var_58 <> "SREV") <> 0 Then GoTo loc_00D372FB
  loc_00D37274:     var_eax = Unknown_VTable_Call[ecx+000004BCh]
  loc_00D37289:     Me.Height = NAN
  loc_00D372B2:     var_eax = Unknown_VTable_Call[eax+00000490h]
  loc_00D372C4:     var_3C = Unknown_VTable_Call[eax+00000490h]
  loc_00D372C7:     Me.Height = NAN
  loc_00D372D1:     If Unknown_VTable_Call[eax+00000490h] < 0 Then
  loc_00D372D3:       'Referenced from: 00D371B9
  loc_00D372E2:       Unknown_VTable_Call[eax+00000490h] = CheckObj(var_3C, var_00D2ADE8, 140)
  loc_00D372E8:     End If
  loc_00D372E8:   End If
  loc_00D372E8: End If
  loc_00D372ED: GoTo loc_00D372FB
  loc_00D372EF: 
  loc_00D37304: var_A0 = Unknown_VTable_Call[eax+00000490h] = Me.Name
  loc_00D3732C: If (var_A0 = "IT") Then
  loc_00D37338:   var_5C = var_18 = Me.ForeColor
  loc_00D3734F:   If (var_5C = "SIRR") Then
  loc_00D37366:     If (var_5C = "SREV") = 0 Then GoTo loc_00D373DC
  loc_00D37379:     If (var_5C <> "COMP") <> 0 Then GoTo loc_00D375A0
  loc_00D37382:     var_eax = Unknown_VTable_Call[ecx+00000444h]
  loc_00D3739A:     Me.Caption = " T       Xн      Yн"
  loc_00D373BD:     var_eax = Unknown_VTable_Call[eax+0000043Ch]
  loc_00D373D1:     Me.Enabled = True
  loc_00D373D7:     GoTo loc_00D37523
  loc_00D373DC:   End If
  loc_00D373DF:   var_eax = Unknown_VTable_Call[eax+00000444h]
  loc_00D373F7:   Me.Caption = " T       Xн"
  loc_00D3741A:   var_eax = Unknown_VTable_Call[edx+0000043Ch]
  loc_00D3742D:   GoTo loc_00D3751C
  loc_00D37432: End If
  loc_00D37454: If (var_A0 = "AD") = 0 Then
  loc_00D37478:   If (var_A0 = "PT") = 0 Then GoTo loc_00D375A0
  loc_00D3747E: End If
  loc_00D37484: var_60 = var_18 = Me.ForeColor
  loc_00D3749B: If (var_60 = "SIRR") Then
  loc_00D374B2:   If (var_60 = "SREV") = 0 Then GoTo loc_00D3752B
  loc_00D374C5:   If (var_60 <> "COMP") <> 0 Then GoTo loc_00D375A0
  loc_00D374CE:   var_eax = Unknown_VTable_Call[eax+00000444h]
  loc_00D374E6:   Me.Caption = "Tн       Xн      Yн"
  loc_00D37509:   var_eax = Unknown_VTable_Call[edx+0000043Ch]
  loc_00D3751C:   'Referenced from: 00D3742D
  loc_00D3751D:   Me.Enabled = True
  loc_00D37523:   'Referenced from: 00D373D7
  loc_00D37527:   If var_18 < 0 Then
  loc_00D37529:     GoTo loc_00D37589
  loc_00D3752B:   End If
  loc_00D3752E:   var_eax = Unknown_VTable_Call[edx+00000444h]
  loc_00D37546:   Me.Caption = "Tн       Xн"
  loc_00D37569:   var_eax = Unknown_VTable_Call[eax+0000043Ch]
  loc_00D3757D:   Me.Enabled = False
  loc_00D37587:   If Unknown_VTable_Call[eax+0000043Ch] < 0 Then
  loc_00D37589:     'Referenced from: 00D37529
  loc_00D37595:     Unknown_VTable_Call[eax+0000043Ch] = CheckObj(Unknown_VTable_Call[eax+0000043Ch], var_00D2A928, 148)
  loc_00D3759B:   End If
  loc_00D3759B: End If
  loc_00D375A0: 
  loc_00D375A5: GoTo loc_00D375B1
  loc_00D375B0: Exit Sub
  loc_00D375B1: 'Referenced from: 00D375A5
End Sub