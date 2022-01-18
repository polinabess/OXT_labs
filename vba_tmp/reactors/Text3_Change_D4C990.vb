Private Sub Text3_Change() 'D4C990
  loc_00D4C9F3: var_eax = Unknown_VTable_Call[edx+0000043Ch]
  loc_00D4CA0D: var_18 = Me.MousePointer
  loc_00D4CA31: var_24 = var_18
  loc_00D4CA5F: If Not (IsNumeric(var_18)) Then
  loc_00D4CACE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4CAEF: End If
  loc_00D4CAF7: GoTo loc_00D4CB27
  loc_00D4CB26: Exit Sub
  loc_00D4CB27: 'Referenced from: 00D4CAF7
End Sub