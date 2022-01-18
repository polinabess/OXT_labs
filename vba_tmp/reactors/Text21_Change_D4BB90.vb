Private Sub Text21_Change() 'D4BB90
  loc_00D4BBF3: var_eax = Unknown_VTable_Call[edx+000003A0h]
  loc_00D4BC0D: var_18 = Me.MousePointer
  loc_00D4BC31: var_24 = var_18
  loc_00D4BC5F: If Not (IsNumeric(var_18)) Then
  loc_00D4BCCE:   ecx = MsgBox("Ошибка записи числа", 0, var_3C, var_4C, var_5C)
  loc_00D4BCEF: End If
  loc_00D4BCF7: GoTo loc_00D4BD27
  loc_00D4BD26: Exit Sub
  loc_00D4BD27: 'Referenced from: 00D4BCF7
End Sub