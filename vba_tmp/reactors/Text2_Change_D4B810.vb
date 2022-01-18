Private Sub Text2_Change() 'D4B810
  loc_00D4B873: var_eax = Unknown_VTable_Call[edx+0000042Ch]
  loc_00D4B88D: var_18 = Me.MousePointer
  loc_00D4B8B1: var_24 = var_18
  loc_00D4B8DF: If Not (IsNumeric(var_18)) Then
  loc_00D4B94E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B96F: End If
  loc_00D4B977: GoTo loc_00D4B9A7
  loc_00D4B9A6: Exit Sub
  loc_00D4B9A7: 'Referenced from: 00D4B977
End Sub