Public Sub Progr4() 'D3F480
  Dim var_1FC As Me
  Dim var_3C As Variant
  Dim var_ret_8 As OptionButton
  Dim var_ret_17 As OptionButton
  Dim var_2F0 As OptionButton
  loc_00D3F605: ecx = Me.Top = ebx
  loc_00D3F613: ecx = Me.Height =
  loc_00D3F61E: ecx = Me.ForeColor =
  loc_00D3F62C: ecx = esi+00000200h
  loc_00D3F63A: ecx =  = Me.Count
  loc_00D3F648: ecx =  = Me.MouseIcon
  loc_00D3F656: ecx = esi+00000230h
  loc_00D3F665: If var_D4F000 = 0 Then
  loc_00D3F66D:   GoTo loc_00D3F67A
  loc_00D3F66F: End If
  loc_00D3F675: call _adj_fdiv_m32(var_401368)
  loc_00D3F67A: 'Referenced from: 00D3F66D
  loc_00D3F696: ecx = esi+00000230h
  loc_00D3F6A4: ecx = esi+00000230h
  loc_00D3F6AD: esi+00000230h = CSng()
  loc_00D3F6D9: ecx = "NO"
  loc_00D3F6E6: ecx = "NO"
  loc_00D3F712: Call Form2.K_react(%x1 = Me.WhatsThisHelp, esi+00000230h, Me.ScaleWidth = %x1s, , )
  loc_00D3F754: var_ret_1 =  - %x1 = Me.Count
  loc_00D3F75F: var_3C = var_ret_1
  loc_00D3F77B: Call Form2.Rcom(esi+00000320h, %x1 = Me.WhatsThisHelp, %x1 = Me.MaxButton, )
  loc_00D3F7C6: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, Me.ScaleMode = %StkVar1, , )
  loc_00D3F808: var_ret_2 = 1 - %x1 = Me.Count
  loc_00D3F813: var_3C = var_ret_2
  loc_00D3F82F: Call Form2.Rcom(esi+00000330h, %x1 = Me.RightToLeft, %x1 = Me.ControlBox, )
  loc_00D3F896: var_1F4 = %x1 = Me.OLEDropMode
  loc_00D3F8A6: Call Form2.K_react(&H4004, Me.ScaleLeft = %x1s, &H4004, , )
  loc_00D3F8D1: var_204 = %x1 = Me.HasDC
  loc_00D3F8FE: var_1F4 = %x1 = Me.OLEDropMode
  loc_00D3F904: Call Form2.Rcom(esi+00000340h, &H4004, &H4004, %x1 = Me.MouseIcon)
  loc_00D3F932: var_ret_3 = esi+00000320h - esi+00000340h
  loc_00D3F950: var_ret_4 = var_ret_3 / esi+00000320h + esi+00000330h
  loc_00D3F957: var_ret_4 = CSng()
  loc_00D3F975: var_1F4 = esi+00000398h
  loc_00D3F9B2: ecx = esi+00000320h + esi+00000330h * esi+00000398
  loc_00D3F9D9: var_1F4 = esi+00000398h
  loc_00D3FA05: ecx = esi+00000320h - esi+00000340h * esi+00000398
  loc_00D3FA23: var_1F4 = esi+00000398h
  loc_00D3FA33: var_ret_8 = %x1 = Option16.FontSize * esi+00000320h
  loc_00D3FA48: var_ret_9 = %x1 = Option16.FontItalic * esi+00000330h
  loc_00D3FA8B: ecx =  + %x1 = Option16.FontUnderline * esi+00000340h * esi+00000398
  loc_00D3FAAD: var_1F4 = "PT"
  loc_00D3FACC: If (%x1 = Option16.Name = "PT") Then
  loc_00D3FADF:   var_1F4 = %x1 = Option16.DragMode
  loc_00D3FB06:   var_204 = esi+00000398h
  loc_00D3FB45:   ecx = esi+00000424h - %x1 = Option16.Value * esi+00000230h - %x1 = Option16.DragMode * esi+00000398
  loc_00D3FB4B: End If
  loc_00D3FB80: If (esi+000003E4h > 0.1#) Then
  loc_00D3FC13:   ecx = MsgBox("Большой начальный градиент Х!", 0, "Время реакции", var_4C, var_5C)
  loc_00D3FC34:   GoTo loc_00D41A98
  loc_00D3FC39: End If
  loc_00D3FC3C: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D3FC57: Option16.Caption = "  t          X         Y        S        T"
  loc_00D3FC99: ecx = vbNullString
  loc_00D3FCBE: var_2C = "000.00"
  loc_00D3FDB5: var_254 = Form2.Option16 'Ignore this
  loc_00D3FDE1: var_274 = "    "
  loc_00D3FE9D: var_CC = esi+000003D0h & Format(esi+00000200h, var_2C) & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000220h, "0.000")
  loc_00D3FF0D: ecx = var_CC & "    " & Format(Form2.Option16 & "    " & Format(esi+00000230h, "000.0") & Chr(13) & Chr(10)
  loc_00D40009: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D40011:   If esi+0000039Ch Then
  loc_00D40073:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D4007B:       If esi+000003ACh Then
  loc_00D400EC:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D4011B:         ecx = esi+00000210h + esi+000003E4h
  loc_00D4014A:         ecx = esi+00000220h + esi+00000404h
  loc_00D40179:         ecx = esi+00000230h + esi+00000424h
  loc_00D401B3:         If (esi+00000444h < 1) Then
  loc_00D401DF:           Call Form2.K_react(esi+00000260h, esi+00000464h, Option16.DragMode = %StkVar1, Option16.TabStop = %x1b, )
  loc_00D4022C:           var_3C = 1 - esi+00000444h
  loc_00D4024E:           Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D40299:           Call Form2.K_react(esi+00000270h, esi+00000464h, Option16.DragMode = %StkVar1, , )
  loc_00D402E6:           var_3C = 1 - esi+00000444h
  loc_00D40308:           Call Form2.Rcom(esi+00000330h, esi+00000270h, %x1 = Option16.MaskColor, )
  loc_00D4032D:           GoTo loc_00D4037B
  loc_00D4032F:         End If
  loc_00D4034F:         ecx = 0
  loc_00D40375:         ecx = 0
  loc_00D4037B:         'Referenced from: 00D4032D
  loc_00D403A6:         If (esi+00000454h > 0) Then
  loc_00D403B8:           var_204 = Option16.RightToLeft = %x1b
  loc_00D403C4:           var_1F4 = esi+00000280h
  loc_00D403FB:           Call Form2.K_react(var_1FC, esi+00000464h, Option16.DragMode = %StkVar1, &H4004, )
  loc_00D4041F:           var_204 = Option16.AddItem
  loc_00D4044A:           var_1F4 = esi+00000280h
  loc_00D4045F:           var_eax = Call Form2.Rcom(esi+00000340h, var_1FC, var_20C, esi+00000454h)
  loc_00D404A3:         End If
  loc_00D404BB:         var_1F4 = esi+00000398h
  loc_00D404EB:         ecx = esi+00000320h + esi+00000330h * esi+00000398
  loc_00D40503:         var_1F4 = esi+00000398h
  loc_00D40542:         ecx = esi+00000320h - esi+00000340h * esi+00000398
  loc_00D40560:         var_1F4 = esi+00000398h
  loc_00D40570:         var_ret_17 = %x1 = Option16.FontSize * esi+00000320h
  loc_00D40589:         var_ret_18 = %x1 = Option16.FontItalic * esi+00000330h
  loc_00D405D8:         ecx =  + %x1 = Option16.FontUnderline * esi+00000340h * esi+00000398
  loc_00D405FA:         var_1F4 = "PT"
  loc_00D40619:         If (%x1 = Option16.Name = "PT") Then
  loc_00D4064A:           var_1F4 = %x1 = Option16.DragMode
  loc_00D40656:           var_204 = esi+00000398h
  loc_00D4069E:           ecx =  - %x1 = Option16.Value * esi+00000464h - %x1 = Option16.DragMode * esi+00000398
  loc_00D406A4:         End If
  loc_00D406F9:         ecx = esi+00000210h + esi+000003E4h + esi+000003F4h / 2
  loc_00D4071E:         ecx = esi+000003F4h
  loc_00D40725:         var_ret_20 = CLng(esi+000003BCh)
  loc_00D40730:         var_2F0 = var_ret_20
  loc_00D40736:         If var_ret_20 >= 211 Then
  loc_00D40738:           var_eax = Err.Raise
  loc_00D4073E:         End If
  loc_00D40753:         var_2F0 = var_2F0 + esi+000002CCh
  loc_00D40755:         var_2F0 = esi+00000210h
  loc_00D407B0:         ecx = esi+00000220h + esi+00000404h + esi+00000414h / 2
  loc_00D407D5:         ecx = esi+00000414h
  loc_00D407DC:         var_ret_22 = CLng(esi+000003BCh)
  loc_00D407E7:         var_2F0 = var_ret_22
  loc_00D407ED:         If var_ret_22 >= 211 Then
  loc_00D407EF:           var_eax = Err.Raise
  loc_00D407F5:         End If
  loc_00D4080A:         var_2F0 = var_2F0 + esi+000002E8h
  loc_00D4080C:         var_2F0 = esi+00000220h
  loc_00D40867:         ecx = esi+00000230h + esi+00000424h + esi+00000434h / 2
  loc_00D4088C:         ecx = esi+00000434h
  loc_00D40893:         var_ret_24 = CLng(esi+000003BCh)
  loc_00D4089E:         var_2F0 = var_ret_24
  loc_00D408A4:         If var_ret_24 >= 211 Then
  loc_00D408A6:           var_eax = Err.Raise
  loc_00D408AC:         End If
  loc_00D408C1:         var_2F0 = var_2F0 + esi+000002B0h
  loc_00D408C3:         var_2F0 = esi+00000230h
  loc_00D408CA:         var_ret_25 = CLng(esi+000003BCh)
  loc_00D408D5:         var_2F0 = var_ret_25
  loc_00D408DB:         If var_ret_25 >= 211 Then
  loc_00D408DD:           var_eax = Err.Raise
  loc_00D408E3:         End If
  loc_00D40916:         var_ret_28 =  / esi+00000220h - Option16.Height = %x1s - Option16.Top = %x1s
  loc_00D4091D:         var_ret_28 = CSng()
  loc_00D4094A:         var_1F4 = esi+00000398h
  loc_00D40968:         ecx = esi+00000200h + esi+00000398
  loc_00D40978:         var_ret_29 = CLng(esi+000003BCh)
  loc_00D40983:         var_2F0 = var_ret_29
  loc_00D40989:         If var_ret_29 >= 211 Then
  loc_00D4098B:           var_eax = Err.Raise
  loc_00D40991:         End If
  loc_00D409A6:         var_2F0 = var_2F0 + esi+00000294h
  loc_00D409A8:         var_2F0 = esi+00000200h
  loc_00D409C5:         If (esi+00000230h < esi+0000051Ch) Then
  loc_00D409D3:           ecx = esi+00000230h
  loc_00D409D9:         End If
  loc_00D409F0:         If (esi+00000230h > esi+0000053Ch) Then
  loc_00D409FE:           ecx = esi+00000230h
  loc_00D40A04:         End If
  loc_00D40A2F:         If (esi+00000560h = "NO") Then
  loc_00D40A5C:           var_ret_2B = CLng(esi+000003BCh - 1)
  loc_00D40A67:           var_2F0 = var_ret_2B
  loc_00D40A6D:           If var_ret_2B >= 211 Then
  loc_00D40A6F:             var_eax = Err.Raise
  loc_00D40A75:           End If
  loc_00D40A8B:           var_2F0 = var_2F0 + esi+000002B0h
  loc_00D40A97:           If (esi+00000230h < var_2F0) Then
  loc_00D40ABA:             var_3C = "000.00"
  loc_00D40AE7:             var_ret_2D = CLng(esi+000003BCh - 1)
  loc_00D40AF2:             var_2F0 = var_ret_2D
  loc_00D40AF8:             If var_ret_2D >= 211 Then
  loc_00D40AFA:               var_eax = Err.Raise
  loc_00D40B00:             End If
  loc_00D40B1E:             var_4C = Format(var_2F0 + esi+00000294h, var_3C)
  loc_00D40B55:             var_8C = "0.000"
  loc_00D40B82:             var_ret_2F = CLng(esi+000003BCh - 1)
  loc_00D40B8D:             var_2F4 = var_ret_2F
  loc_00D40B93:             If var_ret_2F >= 211 Then
  loc_00D40B95:               var_eax = Err.Raise
  loc_00D40B9B:             End If
  loc_00D40BBF:             var_9C = Format(var_2F4 + esi+000002CCh, var_8C)
  loc_00D40BF6:             var_DC = "0.000"
  loc_00D40C26:             var_ret_31 = CLng(esi+000003BCh - 1)
  loc_00D40C31:             var_2F8 = var_ret_31
  loc_00D40C37:             If var_ret_31 >= 211 Then
  loc_00D40C39:               var_eax = Err.Raise
  loc_00D40C3F:             End If
  loc_00D40C63:             var_EC = Format(var_2F8 + esi+000002E8h, var_DC)
  loc_00D40C9A:             var_12C = "0.000"
  loc_00D40CCA:             var_ret_33 = CLng(esi+000003BCh - 1)
  loc_00D40CD5:             var_2FC = var_ret_33
  loc_00D40CDB:             If var_ret_33 >= 211 Then
  loc_00D40CDD:               var_eax = Err.Raise
  loc_00D40CE3:             End If
  loc_00D40CFC:             var_294 = ecx+edx*4
  loc_00D40D1B:             var_13C = Format(ecx+edx*4, var_12C)
  loc_00D40D52:             var_17C = "000.0"
  loc_00D40D82:             var_ret_35 = CLng(esi+000003BCh - 1)
  loc_00D40D8D:             var_300 = var_ret_35
  loc_00D40D93:             If var_ret_35 >= 211 Then
  loc_00D40D95:               var_eax = Err.Raise
  loc_00D40D9B:             End If
  loc_00D40DCE:             var_2E4 = "  maxT"
  loc_00D40E8B:             var_19C = esi+000003D0h & var_4C & "    " & var_9C & "    " & var_EC & "    " & var_13C & "    " & Format(var_300 + esi+000002B0h + esi+000002B0h, var_17C)
  loc_00D40EC8:             ecx = var_19C & "  maxT" & Chr(13) & Chr(10)
  loc_00D40F95:             ecx = "YES"
  loc_00D40F9B:           End If
  loc_00D40F9B:         End If
  loc_00D40FAF:         If (esi+00000570h = "NO") = 0 Then
  loc_00D40FDC:           var_ret_37 = CLng(esi+000003BCh - 1)
  loc_00D40FE7:           var_2F0 = var_ret_37
  loc_00D40FED:           If var_ret_37 >= 211 Then
  loc_00D40FEF:             var_eax = Err.Raise
  loc_00D40FF5:           End If
  loc_00D4100B:           var_2F0 = var_2F0 + esi+000002E8h
  loc_00D41017:           If (esi+00000220h < var_2F0) Then
  loc_00D4103A:             var_3C = "000.00"
  loc_00D41067:             var_ret_39 = CLng(esi+000003BCh - 1)
  loc_00D41072:             var_2F0 = var_ret_39
  loc_00D41078:             If var_ret_39 >= 211 Then
  loc_00D4107A:               var_eax = Err.Raise
  loc_00D41080:             End If
  loc_00D4109E:             var_4C = Format(var_2F0 + esi+00000294h, var_3C)
  loc_00D410D5:             var_8C = "0.000"
  loc_00D41102:             var_ret_3B = CLng(esi+000003BCh - 1)
  loc_00D4110D:             var_2F4 = var_ret_3B
  loc_00D41113:             If var_ret_3B >= 211 Then
  loc_00D41115:               var_eax = Err.Raise
  loc_00D4111B:             End If
  loc_00D4113F:             var_9C = Format(var_2F4 + esi+000002CCh, var_8C)
  loc_00D41176:             var_DC = "0.000"
  loc_00D411A6:             var_ret_3D = CLng(esi+000003BCh - 1)
  loc_00D411B1:             var_2F8 = var_ret_3D
  loc_00D411B7:             If var_ret_3D >= 211 Then
  loc_00D411B9:               var_eax = Err.Raise
  loc_00D411BF:             End If
  loc_00D411E3:             var_EC = Format(var_2F8 + esi+000002E8h, var_DC)
  loc_00D4121A:             var_12C = "0.000"
  loc_00D4124A:             var_ret_3F = CLng(esi+000003BCh - 1)
  loc_00D41255:             var_2FC = var_ret_3F
  loc_00D4125B:             If var_ret_3F >= 211 Then
  loc_00D4125D:               var_eax = Err.Raise
  loc_00D41263:             End If
  loc_00D4127C:             var_294 = eax+ecx*4
  loc_00D4129B:             var_13C = Format(eax+ecx*4, var_12C)
  loc_00D412D2:             var_17C = "000.0"
  loc_00D41302:             var_ret_41 = CLng(esi+000003BCh - 1)
  loc_00D41310:             If var_ret_41 >= 211 Then
  loc_00D41312:               var_eax = Err.Raise
  loc_00D41318:             End If
  loc_00D4134B:             var_2E4 = "  maxY"
  loc_00D41400:             var_19C = esi+000003D0h & var_4C & "    " & var_9C & "    " & var_EC & "    " & var_13C & "    " & Format(var_ret_41 + esi+000002B0h + esi+000002B0h, var_17C)
  loc_00D41439:             ecx = var_19C & "  maxY" & Chr(13) & Chr(10)
  loc_00D414F1:             ecx = "YES"
  loc_00D414F7:           End If
  loc_00D414F7:         End If
  loc_00D4150C:       Next esi+000003ACh
  loc_00D41514:       GoTo loc_00D40079
  loc_00D41519:     End If
  loc_00D41536:     var_2C = "000.00"
  loc_00D41543:     var_ret_42 = CLng(esi+000003BCh)
  loc_00D4154E:     var_2F0 = var_ret_42
  loc_00D41554:     If var_ret_42 >= 211 Then
  loc_00D41556:       var_eax = Err.Raise
  loc_00D4155C:     End If
  loc_00D4157A:     var_3C = Format(var_2F0 + esi+00000294h, var_2C)
  loc_00D415AE:     var_6C = "0.000"
  loc_00D415BB:     var_ret_43 = CLng(esi+000003BCh)
  loc_00D415C6:     var_2F4 = var_ret_43
  loc_00D415CC:     If var_ret_43 >= 211 Then
  loc_00D415CE:       var_eax = Err.Raise
  loc_00D415D4:     End If
  loc_00D415F2:     var_7C = Format(var_2F4 + esi+000002CCh, var_6C)
  loc_00D41629:     var_AC = "0.000"
  loc_00D41636:     var_ret_44 = CLng(esi+000003BCh)
  loc_00D41641:     var_2F8 = var_ret_44
  loc_00D41647:     If var_ret_44 >= 211 Then
  loc_00D41649:       var_eax = Err.Raise
  loc_00D4164F:     End If
  loc_00D41673:     var_BC = Format(var_2F8 + esi+000002E8h, var_AC)
  loc_00D416AA:     var_EC = "0.000"
  loc_00D416B7:     var_ret_45 = CLng(esi+000003BCh)
  loc_00D416C2:     var_2FC = var_ret_45
  loc_00D416C8:     If var_ret_45 >= 211 Then
  loc_00D416CA:       var_eax = Err.Raise
  loc_00D416D0:     End If
  loc_00D416E9:     var_254 = edx+eax*4
  loc_00D41708:     var_FC = Format(edx+eax*4, var_EC)
  loc_00D4173F:     var_12C = "000.0"
  loc_00D4174C:     var_ret_46 = CLng(esi+000003BCh)
  loc_00D41757:     var_300 = var_ret_46
  loc_00D4175D:     If var_ret_46 >= 211 Then
  loc_00D4175F:       var_eax = Err.Raise
  loc_00D41765:     End If
  loc_00D4183E:     var_14C = esi+000003D0h & var_3C & "    " & var_7C & "    " & var_BC & "    " & var_FC & "    " & Format(var_300 + esi+000002B0h, var_12C)
  loc_00D4186A:     ecx = var_14C & Chr(13) & Chr(10)
  loc_00D4191F:   Next esi+0000039Ch
  loc_00D41925:   GoTo loc_00D4000F
  loc_00D4192A: End If
  loc_00D4192D: var_eax = Unknown_VTable_Call[edx+00000348h]
  loc_00D41951: var_18 = CStr(esi+000003D0h)
  loc_00D41961: Option16.MousePointer = var_18
  loc_00D419A3: ecx = esi+00000200h
  loc_00D419C5: ecx = "YES"
  loc_00D419EF: If (%x1 = Option16.Name = "PT") Then
  loc_00D41A23:   If (%x1 = Option16.DragMode < esi+0000051Ch) Then
  loc_00D41A31:     var_1F4 = %x1 = Option16.DragMode
  loc_00D41A43:     ecx = var_310 = Option16.DragMode
  loc_00D41A49:   End If
  loc_00D41A72:   If (%x1 = Option16.DragMode > esi+0000053Ch) Then
  loc_00D41A80:     var_1F4 = %x1 = Option16.DragMode
  loc_00D41A92:     ecx =  = Option16.DragMode
  loc_00D41A98:   End If
  loc_00D41A98: End If
  loc_00D41A9E: GoTo loc_00D41B7A
  loc_00D41B79: Exit Sub
  loc_00D41B7A: 'Referenced from: 00D41A9E
  loc_00D41BA1: Exit Sub
End Sub