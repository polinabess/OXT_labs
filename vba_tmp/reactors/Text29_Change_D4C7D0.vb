Private Sub Text29_Change() 'D4C7D0
  loc_00D4C833: var_eax = Unknown_VTable_Call[edx+00000410h]
  loc_00D4C84D: var_18 = Me.MousePointer
  loc_00D4C871: var_24 = var_18
  loc_00D4C89F: If Not (IsNumeric(var_18)) Then
  loc_00D4C90E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C92F: End If
  loc_00D4C937: GoTo loc_00D4C967
  loc_00D4C966: Exit Sub
  loc_00D4C967: 'Referenced from: 00D4C937
End Sub