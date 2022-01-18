Public Sub Progr10() 'D470B0
  Dim var_50 As OptionButton
  Dim var_ret_4 As OptionButton
  loc_00D47165: ecx = Me.Top = %x1 = Me.Count
  loc_00D47174: ecx = Me.ForeColor =
  loc_00D47186: ecx = esi+00000200h
  loc_00D47194: ecx =  = Me.Count
  loc_00D471C0: Call Form2.K_react(esi+00000240h, esi+00000230h, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, )
  loc_00D471ED: If ("SIRR" = Me.ForeColor = "SIRR") = 0 Then
  loc_00D47207:   Call Form2.Rirr(Form2.Option13, esi+00000240h, Me.WindowState = %StkVar1)
  loc_00D4720F:   If eax >= 0 Then GoTo loc_00D472BE
  loc_00D4721A:   GoTo loc_00D472B1
  loc_00D4721F: End If
  loc_00D47235: var_50 = -Option13.Refresh
  loc_00D4725E: Call Form2.K_react(esi+00000250h, esi+00000230h, Option13.DragMode = %StkVar1, , )
  loc_00D472A2: Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, Option13.Visible = %x1b)
  loc_00D472AA: If eax < 0 Then
  loc_00D472B1:   'Referenced from: 00D4721A
  loc_00D472B8:   Form2.Option13 = CheckObj(Me, var_00D2A2D4, 1804)
  loc_00D472BE: End If
  loc_00D472C1: var_eax = Unknown_VTable_Call[edx+00000384h]
  loc_00D472E0: Option13.Caption = "  t         X "
  loc_00D47329: ecx = vbNullString
  loc_00D4742D: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & & Format(%x1 = Me.Count, "0.000") & Chr(13) & Chr(10)
  loc_00D4749E: ecx = Option13.FontName = 1
  loc_00D474B7: 
  loc_00D474D1: var_E8 = var_28
  loc_00D47506: ecx = var_28 + Option13.Top = 1.40129846432482E-45 /
  loc_00D47526: If ("SIRR" = Option13.ForeColor = "SIRR") = 0 Then
  loc_00D47548:   var_ret_3 = %x1 = Option13.ToolTipText * %x1 = Me.Count
  loc_00D4755F:   If (var_ret_3 < 1) = 0 Then GoTo loc_00D475DF
  loc_00D47573:   Call Form2.Rirr(Form2.Option13, esi+00000240h, %x1 = Me.Count)
  loc_00D47593:   GoTo loc_00D47605
  loc_00D475A6: If (%x1 = Me.Count < esi+000004A4h) Then
  loc_00D475C1:   Call Form2.Rrev(Form2.Option13, esi+00000240h, esi+00000250h, %x1 = Me.Count)
  loc_00D475DF: 
  loc_00D4762B: var_ret_4 = esi+00000200h * Form2.Option13
  loc_00D4765D: var_114 = ( + Option13.Top = %x1s - %x1 = Me.Count > 0)
  loc_00D47672: If var_114 Then
  loc_00D47679:   var_24 =  = Me.Count
  loc_00D4767F:   GoTo loc_00D4768B
  loc_00D47681: End If
  loc_00D47682: %x1 = Me.Count = CSng()
  loc_00D4768B: 'Referenced from: 00D4767F
  loc_00D47694: var_E8 = var_28
  loc_00D476D6: var_ret_7 = Abs(var_28 - var_24)
  loc_00D476ED: If (var_ret_7 < 0#) = 0 Then GoTo loc_00D474B7
  loc_00D476FB: esi+000002CCh = esi+000002CCh + 00000010h
  loc_00D476FE: ecx =  = Me.Count
  loc_00D47710: esi+00000294h = esi+00000294h + 00000010h
  loc_00D47713: ecx = esi+00000200h
  loc_00D47811: ecx = esi+000003D0h & Format(esi+00000200h, "000.00") & & Format(%x1 = Me.Count, "0.000") & Chr(13) & Chr(10)
  loc_00D47863: var_eax = Unknown_VTable_Call[eax+00000348h]
  loc_00D4787D: var_124 = Unknown_VTable_Call[eax+00000348h]
  loc_00D47883: var_2C = CStr(esi+000003D0h)
  loc_00D47891: Option13.MousePointer = var_2C
  loc_00D478D3: ecx = esi+00000200h
  loc_00D478F5: ecx = "NO"
  loc_00D47917: ecx = CInt(1)
  loc_00D47923: GoTo loc_00D47981
  loc_00D47980: Exit Sub
  loc_00D47981: 'Referenced from: 00D47923
End Sub