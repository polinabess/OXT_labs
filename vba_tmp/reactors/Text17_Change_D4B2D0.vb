Private Sub Text17_Change() 'D4B2D0
  loc_00D4B333: var_eax = Unknown_VTable_Call[edx+000003ACh]
  loc_00D4B34D: var_18 = Me.MousePointer
  loc_00D4B371: var_24 = var_18
  loc_00D4B39F: If Not (IsNumeric(var_18)) Then
  loc_00D4B40E:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4B42F: End If
  loc_00D4B437: GoTo loc_00D4B467
  loc_00D4B466: Exit Sub
  loc_00D4B467: 'Referenced from: 00D4B437
End Sub