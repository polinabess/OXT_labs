Private Sub Text1_Change() 'D4A4D0
  loc_00D4A533: var_eax = Unknown_VTable_Call[edx+00000430h]
  loc_00D4A54D: var_18 = Me.MousePointer
  loc_00D4A571: var_24 = var_18
  loc_00D4A59F: If Not (IsNumeric(var_18)) Then
  loc_00D4A60E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4A62F: End If
  loc_00D4A637: GoTo loc_00D4A667
  loc_00D4A666: Exit Sub
  loc_00D4A667: 'Referenced from: 00D4A637
End Sub