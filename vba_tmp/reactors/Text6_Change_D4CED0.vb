Private Sub Text6_Change() 'D4CED0
  loc_00D4CF33: var_eax = Unknown_VTable_Call[edx+0000041Ch]
  loc_00D4CF4D: var_18 = Me.MousePointer
  loc_00D4CF71: var_24 = var_18
  loc_00D4CF9F: If Not (IsNumeric(var_18)) Then
  loc_00D4D00E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4D02F: End If
  loc_00D4D037: GoTo loc_00D4D067
  loc_00D4D066: Exit Sub
  loc_00D4D067: 'Referenced from: 00D4D037
End Sub