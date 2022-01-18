Private Sub Text4_Change() 'D4CB50
  loc_00D4CBB3: var_eax = Unknown_VTable_Call[edx+00000438h]
  loc_00D4CBCD: var_18 = Me.MousePointer
  loc_00D4CBF1: var_24 = var_18
  loc_00D4CC1F: If Not (IsNumeric(var_18)) Then
  loc_00D4CC8E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4CCAF: End If
  loc_00D4CCB7: GoTo loc_00D4CCE7
  loc_00D4CCE6: Exit Sub
  loc_00D4CCE7: 'Referenced from: 00D4CCB7
End Sub