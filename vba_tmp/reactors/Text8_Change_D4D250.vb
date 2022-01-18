Private Sub Text8_Change() 'D4D250
  loc_00D4D2B3: var_eax = Unknown_VTable_Call[edx+00000414h]
  loc_00D4D2CD: var_18 = Me.MousePointer
  loc_00D4D2F1: var_24 = var_18
  loc_00D4D31F: If Not (IsNumeric(var_18)) Then
  loc_00D4D38E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4D3AF: End If
  loc_00D4D3B7: GoTo loc_00D4D3E7
  loc_00D4D3E6: Exit Sub
  loc_00D4D3E7: 'Referenced from: 00D4D3B7
End Sub