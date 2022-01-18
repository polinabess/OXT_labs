Private Sub Text15_Change() 'D4AF50
  loc_00D4AFB3: var_eax = Unknown_VTable_Call[edx+000003B4h]
  loc_00D4AFCD: var_18 = Me.MousePointer
  loc_00D4AFF1: var_24 = var_18
  loc_00D4B01F: If Not (IsNumeric(var_18)) Then
  loc_00D4B08E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B0AF: End If
  loc_00D4B0B7: GoTo loc_00D4B0E7
  loc_00D4B0E6: Exit Sub
  loc_00D4B0E7: 'Referenced from: 00D4B0B7
End Sub