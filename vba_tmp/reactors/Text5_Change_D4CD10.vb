Private Sub Text5_Change() 'D4CD10
  loc_00D4CD73: var_eax = Unknown_VTable_Call[edx+00000434h]
  loc_00D4CD8D: var_18 = Me.MousePointer
  loc_00D4CDB1: var_24 = var_18
  loc_00D4CDDF: If Not (IsNumeric(var_18)) Then
  loc_00D4CE4E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4CE6F: End If
  loc_00D4CE77: GoTo loc_00D4CEA7
  loc_00D4CEA6: Exit Sub
  loc_00D4CEA7: 'Referenced from: 00D4CE77
End Sub