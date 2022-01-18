Private Sub Text19_Change() 'D4B650
  loc_00D4B6B3: var_eax = Unknown_VTable_Call[edx+000003D0h]
  loc_00D4B6CD: var_18 = Me.MousePointer
  loc_00D4B6F1: var_24 = var_18
  loc_00D4B71F: If Not (IsNumeric(var_18)) Then
  loc_00D4B78E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B7AF: End If
  loc_00D4B7B7: GoTo loc_00D4B7E7
  loc_00D4B7E6: Exit Sub
  loc_00D4B7E7: 'Referenced from: 00D4B7B7
End Sub