Private Sub Text12_Change() 'D4AA10
  loc_00D4AA73: var_eax = Unknown_VTable_Call[edx+000003C0h]
  loc_00D4AA8D: var_18 = Me.MousePointer
  loc_00D4AAB1: var_24 = var_18
  loc_00D4AADF: If Not (IsNumeric(var_18)) Then
  loc_00D4AB4E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4AB6F: End If
  loc_00D4AB77: GoTo loc_00D4ABA7
  loc_00D4ABA6: Exit Sub
  loc_00D4ABA7: 'Referenced from: 00D4AB77
End Sub