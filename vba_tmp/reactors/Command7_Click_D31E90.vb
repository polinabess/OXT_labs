Private Sub Command7_Click() 'D31E90
  Dim var_1C As Me
  Dim var_A0 As Me
  Dim var_ret_2 As Me
  Dim var_ret_7 As Me
  loc_00D31F09: If (esi+00000384h = "100") = 0 Then
  loc_00D31F12:   ecx = 00D2AC10h
  loc_00D31F18:   GoTo loc_00D31FC3
  loc_00D31F1D: End If
  loc_00D31F3F: var_74 = "График"
  loc_00D31F55: var_64 = "Обновить график?"
  loc_00D31F93: ecx = CStr(MsgBox("Обновить график?", 52, "График", var_4C, 10))
  loc_00D31FC3: 'Referenced from: 00D31F18
  loc_00D31FCF: If (esi+00000384h = var_00D2AC10) = 0 Then
  loc_00D31FD8:   var_eax = Unknown_VTable_Call[eax+0000034Ch]
  loc_00D31FF0:   var_1C = Me.StartUpPosition
  loc_00D3201C:   var_eax = Unknown_VTable_Call[eax+00000378h]
  loc_00D32034:   Me.WindowState = 0
  loc_00D32060:   var_eax = Unknown_VTable_Call[edx+00000354h]
  loc_00D32078:   Me.WindowState = 0
  loc_00D320A4:   var_eax = Unknown_VTable_Call[eax+00000374h]
  loc_00D320BC:   Me.WindowState = 0
  loc_00D320E8:   var_eax = Unknown_VTable_Call[edx+0000036Ch]
  loc_00D32100:   Me.WindowState = 0
  loc_00D3212C:   var_eax = Unknown_VTable_Call[eax+00000380h]
  loc_00D32144:   Me.WindowState = 0
  loc_00D32170:   var_eax = Unknown_VTable_Call[edx+00000368h]
  loc_00D32188:   Me.WindowState = 0
  loc_00D321B4:   var_eax = Unknown_VTable_Call[eax+00000360h]
  loc_00D321CC:   Me.WindowState = 0
  loc_00D32227:   ecx = 1.1# * esi+000004FCh
  loc_00D32230:   var_eax = Unknown_VTable_Call[edx+00000364h]
  loc_00D32242:   var_A0 = var_1C
  loc_00D32248:   Me.WindowState = CInt(-1)
  loc_00D32293:   If (esi+0000050Ch < 10000) Then
  loc_00D3229C:     var_eax = Unknown_VTable_Call[ecx+00000364h]
  loc_00D322EE:     var_18 = CStr(Format(esi+0000050Ch, "0000"))
  loc_00D322FE:     Me.Caption = var_18
  loc_00D3233D:   End If
  loc_00D3235F:   If (esi+0000050Ch < 1000) Then
  loc_00D32368:     var_eax = Unknown_VTable_Call[edx+00000364h]
  loc_00D323BA:     var_18 = CStr(Format(esi+0000050Ch, "000"))
  loc_00D323CA:     Me.Caption = var_18
  loc_00D32409:   End If
  loc_00D3242B:   If (esi+0000050Ch < 100) Then
  loc_00D32434:     var_eax = Unknown_VTable_Call[eax+00000364h]
  loc_00D3248C:     var_B8 = ebx
  loc_00D324A0:     Me.Caption = CStr(Format(esi+0000050Ch, "00.0"))
  loc_00D324DF:   End If
  loc_00D32501:   If (esi+0000050Ch < 10) Then
  loc_00D3250A:     var_eax = Unknown_VTable_Call[ecx+00000364h]
  loc_00D3255C:     var_18 = CStr(Format(esi+0000050Ch, "0.000"))
  loc_00D3256C:     Me.Caption = var_18
  loc_00D325AB:   End If
  loc_00D325C2:   ecx = "New"
  loc_00D325DF:   ecx = "New"
  loc_00D325F6:   If ("COMP" = Me.ForeColor = "COMP") = 0 Then
  loc_00D325FF:     var_eax = Unknown_VTable_Call[edx+00000378h]
  loc_00D32617:     Me.WindowState = CInt(-1)
  loc_00D32643:     var_eax = Unknown_VTable_Call[eax+00000354h]
  loc_00D3265B:     Me.WindowState = CInt(-1)
  loc_00D32687:     var_eax = Unknown_VTable_Call[edx+00000374h]
  loc_00D3269F:     Me.WindowState = CInt(-1)
  loc_00D326DF:     ecx = "Old"
  loc_00D326E5:   End If
  loc_00D326F6:   var_64 = "AD"
  loc_00D32703:   var_74 = "PT"
  loc_00D3270A:   var_ret_2 = (%x1 = Me.Name = "AD")
  loc_00D3271D:   var_ret_3 = (%x1 = Me.Name = "PT")
  loc_00D32728:   call Or(var_4C, var_ret_3, Unknown_VTable_Call[edx+00000374h], Me, var_1C, Unknown_VTable_Call[eax+00000354h], Me, var_1C, Unknown_VTable_Call[edx+00000378h], Me, 00000001h, var_1C, Unknown_VTable_Call[ecx+00000364h])
  loc_00D32738:   If CBool(Or(var_4C, var_ret_3, Unknown_VTable_Call[edx+00000374h], Me, var_1C, Unknown_VTable_Call[eax+00000354h], Me, var_1C, Unknown_VTable_Call[edx+00000378h], Me, 00000001h, var_1C, Unknown_VTable_Call[ecx+00000364h])) Then
  loc_00D32769:     ecx = esi+0000051Ch - 10
  loc_00D3279A:     ecx = esi+0000053Ch + 10
  loc_00D327AC:     var_eax = Unknown_VTable_Call[edx+0000036Ch]
  loc_00D327C4:     Me.WindowState = CInt(-1)
  loc_00D327F0:     var_eax = Unknown_VTable_Call[eax+00000380h]
  loc_00D32808:     Me.WindowState = CInt(-1)
  loc_00D32834:     var_eax = Unknown_VTable_Call[edx+00000368h]
  loc_00D32846:     var_A0 = var_1C
  loc_00D3284C:     Me.WindowState = CInt(-1)
  loc_00D32878:     var_eax = Unknown_VTable_Call[eax+00000368h]
  loc_00D328D0:     var_C0 = ebx
  loc_00D328E4:     Me.Caption = CStr(Format(esi+0000052Ch, "000"))
  loc_00D32924:     var_eax = Unknown_VTable_Call[eax+0000036Ch]
  loc_00D3297C:     var_C4 = ebx
  loc_00D32990:     Me.Caption = CStr(Format(esi+0000054Ch, "000"))
  loc_00D329D2:     var_64 = "PT"
  loc_00D329EE:     If (%x1 = Me.Name = "PT") Then
  loc_00D329F3:       var_eax = Unknown_VTable_Call[ecx+00000360h]
  loc_00D32A07:       Me.WindowState = CInt(-1)
  loc_00D32A2A:     End If
  loc_00D32A41:     ecx = "Old"
  loc_00D32A47:     GoTo loc_00D32F04
  loc_00D32A4C:   End If
  loc_00D32A4F:   var_64 = "New"
  loc_00D32A6F:   eax = edi + 1
  loc_00D32A75:   var_74 = edi + 1
  loc_00D32A97:   var_ret_6 = (esi+000004E8h = "New") And edi + 1
  loc_00D32AB3:   If CBool(var_ret_6) Then
  loc_00D32ABC:     var_eax = Unknown_VTable_Call[eax+00000378h]
  loc_00D32AD6:     Me.WindowState = CInt(-1)
  loc_00D32B00:     var_eax = Unknown_VTable_Call[eax+00000354h]
  loc_00D32B14:     Me.WindowState = CInt(-1)
  loc_00D32B3E:     var_eax = Unknown_VTable_Call[eax+00000374h]
  loc_00D32B52:     Me.WindowState = CInt(-1)
  loc_00D32B90:     ecx = "Old"
  loc_00D32B9C:     GoTo loc_00D32BA4
  loc_00D32B9E:   End If
  loc_00D32BA4:   'Referenced from: 00D32B9C
  loc_00D32BB5:   var_64 = "AD"
  loc_00D32BC2:   var_74 = "PT"
  loc_00D32BC9:   var_ret_7 = (%x1 = Me.Name = "AD")
  loc_00D32BD8:   var_ret_8 = (%x1 = Me.Name = "PT")
  loc_00D32BDF:   call Or(var_4C, var_ret_8, Unknown_VTable_Call[eax+00000374h], Me, var_1C, Unknown_VTable_Call[eax+00000354h], Me, var_1C, Unknown_VTable_Call[eax+00000378h], Me, "COMP", %x1 = Me.ForeColor, Unknown_VTable_Call[ecx+00000360h])
  loc_00D32BEF:   If CBool(Or(var_4C, var_ret_8, Unknown_VTable_Call[eax+00000374h], Me, var_1C, Unknown_VTable_Call[eax+00000354h], Me, var_1C, Unknown_VTable_Call[eax+00000378h], Me, "COMP", %x1 = Me.ForeColor, Unknown_VTable_Call[ecx+00000360h])) Then
  loc_00D32C17:     If (esi+000004D8h = "New") Then
  loc_00D32C50:       ecx = esi+0000051Ch - 10
  loc_00D32C7D:       ecx = esi+0000053Ch + 10
  loc_00D32C8B:       var_eax = Unknown_VTable_Call[eax+0000036Ch]
  loc_00D32C9F:       Me.WindowState = CInt(-1)
  loc_00D32CC9:       var_eax = Unknown_VTable_Call[eax+00000380h]
  loc_00D32CDD:       Me.WindowState = CInt(-1)
  loc_00D32D07:       var_eax = Unknown_VTable_Call[eax+00000368h]
  loc_00D32D1B:       Me.WindowState = CInt(-1)
  loc_00D32D45:       var_eax = Unknown_VTable_Call[eax+00000368h]
  loc_00D32D9D:       var_C8 = ebx
  loc_00D32DB1:       Me.Caption = CStr(Format(esi+0000052Ch, "000"))
  loc_00D32DF1:       var_eax = Unknown_VTable_Call[eax+0000036Ch]
  loc_00D32E3D:       var_18 = CStr(Format(esi+0000054Ch, "000"))
  loc_00D32E45:       Me.Caption = var_18
  loc_00D32E99:       ecx = "Old"
  loc_00D32EA5:     End If
  loc_00D32EC4:     If (%x1 = Me.Name = "PT") Then
  loc_00D32EC9:       var_eax = Unknown_VTable_Call[eax+00000360h]
  loc_00D32EDD:       Me.WindowState = CInt(-1)
  loc_00D32F04:     End If
  loc_00D32F04:   End If
  loc_00D32F04: End If
  loc_00D32F07: var_eax = Call Form2.Graf
  loc_00D32F30: GoTo loc_00D32F60
  loc_00D32F5F: Exit Sub
  loc_00D32F60: 'Referenced from: 00D32F30
End Sub