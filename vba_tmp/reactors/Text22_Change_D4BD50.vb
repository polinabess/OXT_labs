Private Sub Text22_Change() 'D4BD50
  loc_00D4BDB3: var_eax = Unknown_VTable_Call[edx+0000039Ch]
  loc_00D4BDCD: var_18 = Me.MousePointer
  loc_00D4BDF1: var_24 = var_18
  loc_00D4BE1F: If Not (IsNumeric(var_18)) Then
  loc_00D4BE8E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4BEAF: End If
  loc_00D4BEB7: GoTo loc_00D4BEE7
  loc_00D4BEE6: Exit Sub
  loc_00D4BEE7: 'Referenced from: 00D4BEB7
End Sub