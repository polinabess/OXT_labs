Private Sub Text10_Change() 'D4A690
  loc_00D4A6F3: var_eax = Unknown_VTable_Call[edx+000003C8h]
  loc_00D4A70D: var_18 = Me.MousePointer
  loc_00D4A731: var_24 = var_18
  loc_00D4A75F: If Not (IsNumeric(var_18)) Then
  loc_00D4A7CE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4A7EF: End If
  loc_00D4A7F7: GoTo loc_00D4A827
  loc_00D4A826: Exit Sub
  loc_00D4A827: 'Referenced from: 00D4A7F7
End Sub