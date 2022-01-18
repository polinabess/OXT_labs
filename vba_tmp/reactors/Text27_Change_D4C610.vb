Private Sub Text27_Change() 'D4C610
  loc_00D4C673: var_eax = Unknown_VTable_Call[edx+000003D8h]
  loc_00D4C68D: var_18 = Me.MousePointer
  loc_00D4C6B1: var_24 = var_18
  loc_00D4C6DF: If Not (IsNumeric(var_18)) Then
  loc_00D4C74E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4C76F: End If
  loc_00D4C777: GoTo loc_00D4C7A7
  loc_00D4C7A6: Exit Sub
  loc_00D4C7A7: 'Referenced from: 00D4C777
End Sub