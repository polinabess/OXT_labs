Private Sub Text24_Change() 'D4C0D0
  loc_00D4C133: var_eax = Unknown_VTable_Call[edx+00000394h]
  loc_00D4C14D: var_18 = Me.MousePointer
  loc_00D4C171: var_24 = var_18
  loc_00D4C19F: If Not (IsNumeric(var_18)) Then
  loc_00D4C20E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C22F: End If
  loc_00D4C237: GoTo loc_00D4C267
  loc_00D4C266: Exit Sub
  loc_00D4C267: 'Referenced from: 00D4C237
End Sub