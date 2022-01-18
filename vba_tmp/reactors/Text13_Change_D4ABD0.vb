Private Sub Text13_Change() 'D4ABD0
  loc_00D4AC33: var_eax = Unknown_VTable_Call[edx+000003BCh]
  loc_00D4AC4D: var_18 = Me.MousePointer
  loc_00D4AC71: var_24 = var_18
  loc_00D4AC9F: If Not (IsNumeric(var_18)) Then
  loc_00D4AD0E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4AD2F: End If
  loc_00D4AD37: GoTo loc_00D4AD67
  loc_00D4AD66: Exit Sub
  loc_00D4AD67: 'Referenced from: 00D4AD37
End Sub