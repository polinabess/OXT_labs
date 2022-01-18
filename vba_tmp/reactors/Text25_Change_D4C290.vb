Private Sub Text25_Change() 'D4C290
  loc_00D4C2F3: var_eax = Unknown_VTable_Call[edx+00000390h]
  loc_00D4C30D: var_18 = Me.MousePointer
  loc_00D4C331: var_24 = var_18
  loc_00D4C35F: If Not (IsNumeric(var_18)) Then
  loc_00D4C3CE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C3EF: End If
  loc_00D4C3F7: GoTo loc_00D4C427
  loc_00D4C426: Exit Sub
  loc_00D4C427: 'Referenced from: 00D4C3F7
End Sub