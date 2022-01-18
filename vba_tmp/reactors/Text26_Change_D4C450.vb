Private Sub Text26_Change() 'D4C450
  loc_00D4C4B3: var_eax = Unknown_VTable_Call[edx+000003D4h]
  loc_00D4C4CD: var_18 = Me.MousePointer
  loc_00D4C4F1: var_24 = var_18
  loc_00D4C51F: If Not (IsNumeric(var_18)) Then
  loc_00D4C58E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C5AF: End If
  loc_00D4C5B7: GoTo loc_00D4C5E7
  loc_00D4C5E6: Exit Sub
  loc_00D4C5E7: 'Referenced from: 00D4C5B7
End Sub