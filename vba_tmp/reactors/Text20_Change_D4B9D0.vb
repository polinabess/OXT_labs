Private Sub Text20_Change() 'D4B9D0
  loc_00D4BA33: var_eax = Unknown_VTable_Call[edx+000003A4h]
  loc_00D4BA4D: var_18 = Me.MousePointer
  loc_00D4BA71: var_24 = var_18
  loc_00D4BA9F: If Not (IsNumeric(var_18)) Then
  loc_00D4BB0E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4BB2F: End If
  loc_00D4BB37: GoTo loc_00D4BB67
  loc_00D4BB66: Exit Sub
  loc_00D4BB67: 'Referenced from: 00D4BB37
End Sub