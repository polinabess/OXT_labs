Private Sub Text14_Change() 'D4AD90
  loc_00D4ADF3: var_eax = Unknown_VTable_Call[edx+000003B8h]
  loc_00D4AE0D: var_18 = Me.MousePointer
  loc_00D4AE31: var_24 = var_18
  loc_00D4AE5F: If Not (IsNumeric(var_18)) Then
  loc_00D4AECE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4AEEF: End If
  loc_00D4AEF7: GoTo loc_00D4AF27
  loc_00D4AF26: Exit Sub
  loc_00D4AF27: 'Referenced from: 00D4AEF7
End Sub