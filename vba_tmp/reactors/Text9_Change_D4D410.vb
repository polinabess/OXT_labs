Private Sub Text9_Change() 'D4D410
  loc_00D4D473: var_eax = Unknown_VTable_Call[edx+000003CCh]
  loc_00D4D48D: var_18 = Me.MousePointer
  loc_00D4D4B1: var_24 = var_18
  loc_00D4D4DF: If Not (IsNumeric(var_18)) Then
  loc_00D4D54E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4D56F: End If
  loc_00D4D577: GoTo loc_00D4D5A7
  loc_00D4D5A6: Exit Sub
  loc_00D4D5A7: 'Referenced from: 00D4D577
End Sub