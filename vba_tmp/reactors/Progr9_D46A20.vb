Public Sub Progr9() 'D46A20
  Dim var_3C As OptionButton
  Dim var_6C As OptionButton
  loc_00D46AD3: ecx = Me.Top = ebx
  loc_00D46ADE: ecx = Me.ForeColor =
  loc_00D46AEC: ecx = esi+00000200h
  loc_00D46AFA: ecx =  = Me.Count
  loc_00D46B22: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D46B4F: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D46B69:   Call Form2.Rirr(Form2.Option13, esi+00000240h, Me.WindowState = %StkVar1)
  loc_00D46B71:   If esi+00000240h >= 0 Then GoTo loc_00D46C20
  loc_00D46B7C:   GoTo loc_00D46C13
  loc_00D46B81: End If
  loc_00D46B97: var_3C = -Option13.Refresh
  loc_00D46BC0: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D46C04: Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, Option13.Visible = %x1b)
  loc_00D46C0C: If esi+00000240h < 0 Then
  loc_00D46C13:   'Referenced from: 00D46B7C
  loc_00D46C1A:   esi+00000240h = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D46C20: End If
  loc_00D46C23: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D46C42: Option13.Caption = "  t         X "
  loc_00D46C8B: ecx = vbNullString
  loc_00D46D83: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & Chr(13) & Chr(10)
  loc_00D46DFE: ecx = 1 - Option13.Top = %x1s / Form2.Option13
  loc_00D46E10: esi+000002CCh = esi+000002CCh + 00000010h
  loc_00D46E13: ecx = Option13.Visible = True
  loc_00D46E25: esi+00000294h = esi+00000294h + 00000010h
  loc_00D46E28: ecx = esi+00000200h
  loc_00D46E98: var_6C = "0.000"
  loc_00D46F22: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(Option13.Visible = %x1b, 1) & Chr(13) & Chr(10)
  loc_00D46F71: var_eax = Unknown_VTable_Call[ecx+00000348h]
  loc_00D46F8B: var_110 = Unknown_VTable_Call[ecx+00000348h]
  loc_00D46F91: var_18 = CStr(esi+000003D0h)
  loc_00D46F9F: Option13.MousePointer = var_18
  loc_00D46FE1: ecx = esi+00000200h
  loc_00D47003: ecx = "NO"
  loc_00D47025: ecx = CInt(1)
  loc_00D47030: GoTo loc_00D4708B
  loc_00D4708A: Exit Sub
  loc_00D4708B: 'Referenced from: 00D47030
End Sub