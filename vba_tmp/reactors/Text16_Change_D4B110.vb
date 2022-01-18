Private Sub Text16_Change() 'D4B110
  loc_00D4B173: var_eax = Unknown_VTable_Call[edx+000003B0h]
  loc_00D4B18D: var_18 = Me.MousePointer
  loc_00D4B1B1: var_24 = var_18
  loc_00D4B1DF: If Not (IsNumeric(var_18)) Then
  loc_00D4B24E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B26F: End If
  loc_00D4B277: GoTo loc_00D4B2A7
  loc_00D4B2A6: Exit Sub
  loc_00D4B2A7: 'Referenced from: 00D4B277
End Sub