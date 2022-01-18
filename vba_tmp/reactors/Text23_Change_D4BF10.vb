Private Sub Text23_Change() 'D4BF10
  loc_00D4BF73: var_eax = Unknown_VTable_Call[edx+00000398h]
  loc_00D4BF8D: var_18 = Me.MousePointer
  loc_00D4BFB1: var_24 = var_18
  loc_00D4BFDF: If Not (IsNumeric(var_18)) Then
  loc_00D4C04E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C06F: End If
  loc_00D4C077: GoTo loc_00D4C0A7
  loc_00D4C0A6: Exit Sub
  loc_00D4C0A7: 'Referenced from: 00D4C077
End Sub