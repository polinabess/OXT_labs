Private Sub Text18_Change() 'D4B490
  loc_00D4B4F3: var_eax = Unknown_VTable_Call[edx+000003A8h]
  loc_00D4B50D: var_18 = Me.MousePointer
  loc_00D4B531: var_24 = var_18
  loc_00D4B55F: If Not (IsNumeric(var_18)) Then
  loc_00D4B5CE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B5EF: End If
  loc_00D4B5F7: GoTo loc_00D4B627
  loc_00D4B626: Exit Sub
  loc_00D4B627: 'Referenced from: 00D4B5F7
End Sub