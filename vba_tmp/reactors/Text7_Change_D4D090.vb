Private Sub Text7_Change() 'D4D090
  loc_00D4D0F3: var_eax = Unknown_VTable_Call[edx+00000418h]
  loc_00D4D10D: var_18 = Me.MousePointer
  loc_00D4D131: var_24 = var_18
  loc_00D4D15F: If Not (IsNumeric(var_18)) Then
  loc_00D4D1CE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4D1EF: End If
  loc_00D4D1F7: GoTo loc_00D4D227
  loc_00D4D226: Exit Sub
  loc_00D4D227: 'Referenced from: 00D4D1F7
End Sub