Private Sub Text11_Change() 'D4A850
  loc_00D4A8B3: var_eax = Unknown_VTable_Call[edx+000003C4h]
  loc_00D4A8CD: var_18 = Me.MousePointer
  loc_00D4A8F1: var_24 = var_18
  loc_00D4A91F: If Not (IsNumeric(var_18)) Then
  loc_00D4A98E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4A9AF: End If
  loc_00D4A9B7: GoTo loc_00D4A9E7
  loc_00D4A9E6: Exit Sub
  loc_00D4A9E7: 'Referenced from: 00D4A9B7
End Sub