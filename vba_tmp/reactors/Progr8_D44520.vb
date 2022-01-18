Public Sub Progr8() 'D44520
  Dim var_3C As Variant
  Dim var_ret_A As OptionButton
  Dim var_ret_19 As OptionButton
  Dim var_ret_29 As OptionButton
  Dim var_2F0 As OptionButton
  loc_00D446A5: ecx = Me.Top = ebx
  loc_00D446B3: ecx = Me.Height =
  loc_00D446BE: ecx = Me.ForeColor =
  loc_00D446CC: ecx = esi+00000200h
  loc_00D446DA: ecx =  = Me.Count
  loc_00D446E8: ecx =  = Me.MouseIcon
  loc_00D446F6: ecx = esi+00000230h
  loc_00D4471B: var_ret_1 = Me.WindowState = %StkVar1 - Me.Top = %x1s
  loc_00D4472D: var_ret_2 = var_ret_1 / 200
  loc_00D4473B: ecx = var_ret_2
  loc_00D4474D: ecx = esi+00000230h
  loc_00D4475B: ecx = esi+00000230h
  loc_00D44764: esi+00000230h = CSng()
  loc_00D44790: ecx = "NO"
  loc_00D4479D: ecx = "NO"
  loc_00D447C9: Call Form2.K_react(%x1 = Me.WhatsThisHelp, esi+00000230h, Me.ScaleWidth = %x1s, , )
  loc_00D4480B: var_ret_3 = 1 - %x1 = Me.Count
  loc_00D44816: var_3C = var_ret_3
  loc_00D44832: Call Form2.Rcom(esi+00000320h, %x1 = Me.WhatsThisHelp, %x1 = Me.MaxButton, )
  loc_00D4487D: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, Me.DrawMode = %StkVar1, , )
  loc_00D448BF: var_ret_4 = 1 - %x1 = Me.Count
  loc_00D448CA: var_3C = var_ret_4
  loc_00D448E6: Call Form2.Rcom(esi+00000330h, %x1 = Me.RightToLeft, %x1 = Me.ControlBox, )
  loc_00D4494D: var_1F4 = %x1 = Me.OLEDropMode
  loc_00D4495D: Call Form2.K_react(&H4004, Me.ScaleLeft = %x1s, &H4004, , )
  loc_00D44988: var_204 = %x1 = Me.HasDC
  loc_00D449B5: var_1F4 = %x1 = Me.OLEDropMode
  loc_00D449BB: Call Form2.Rcom(esi+00000340h, &H4004, &H4004, %x1 = Me.MouseIcon)
  loc_00D44A07: var_ret_6 = esi+00000320h - esi+00000340h / esi+00000320h + esi+00000330h
  loc_00D44A0E: var_ret_6 = CSng()
  loc_00D44A51: ecx = esi+00000388h / esi+00000320h + esi+00000330h
  loc_00D44A8E: ecx = esi+00000320h - esi+00000340h * esi+000003E4h
  loc_00D44AA6: var_ret_A = %x1 = Option16.FontSize * esi+00000320h
  loc_00D44ABB: var_ret_B = %x1 = Option16.FontItalic * esi+00000330h
  loc_00D44AFE: ecx =  + %x1 = Option16.FontUnderline * esi+00000340h * esi+000003E4h
  loc_00D44B20: var_1F4 = "PT"
  loc_00D44B3F: If (%x1 = Option16.Name = "PT") Then
  loc_00D44B5B:   var_1F4 = %x1 = Option16.DragMode
  loc_00D44BA5:   ecx =  - %x1 = Option16.Value * esi+00000230h - %x1 = Option16.DragMode * esi+000003E4h
  loc_00D44BAB: End If
  loc_00D44BAE: var_eax = Unknown_VTable_Call[eax+00000384h]
  loc_00D44BC9: Option16.Caption = "  t          X         Y        S        T"
  loc_00D44C0B: ecx = vbNullString
  loc_00D44C30: var_2C = "000.00"
  loc_00D44D27: var_254 = Form2.Option16 'Ignore this
  loc_00D44D53: var_274 = "    "
  loc_00D44E0F: var_CC = esi+000003D0h & Format(esi+00000200h, var_2C) & "    " & Format(esi+00000210h, "0.000") & "    " & Format(esi+00000220h, "0.000")
  loc_00D44E7F: ecx = var_CC & "    " & Format(Form2.Option16 & "    " & Format(esi+00000230h, "000.0") & Chr(13) & Chr(10)
  loc_00D44F7B: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D44F83:   If esi+0000039Ch Then
  loc_00D44FE5:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D44FED:       If esi+000003ACh Then
  loc_00D4505E:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D4508D:         ecx = esi+00000210h + esi+00000388h
  loc_00D450BC:         ecx = esi+00000220h + esi+00000404h
  loc_00D450EB:         ecx = esi+00000230h + esi+00000424h
  loc_00D45120:         Call Form2.K_react(esi+00000260h, esi+00000464h, Option16.DragMode = %StkVar1, Option16.TabStop = %x1b, )
  loc_00D4516D:         var_3C = 1 - esi+00000444h
  loc_00D4518F:         Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D451DA:         Call Form2.K_react(esi+00000270h, esi+00000464h, Option16.DragMode = %StkVar1, , )
  loc_00D45227:         var_3C = 1 - esi+00000444h
  loc_00D45249:         Call Form2.Rcom(esi+00000330h, esi+00000270h, %x1 = Option16.MaskColor, )
  loc_00D45299:         If (esi+00000454h > 0) Then
  loc_00D452AB:           var_204 = Option16.RightToLeft = %x1b
  loc_00D452B7:           var_1F4 = esi+00000280h
  loc_00D452EE:           Call Form2.K_react(&H4004, esi+00000464h, Option16.DragMode = %StkVar1, &H4004, )
  loc_00D4532A:           var_204 = Option16.AddItem
  loc_00D4533D:           var_1F4 = esi+00000280h
  loc_00D45352:           var_eax = Call Form2.Rcom(esi+00000340h, var_1FC, var_20C, esi+00000454h)
  loc_00D45396:         End If
  loc_00D453C8:         ecx = esi+00000388h / esi+00000320h + esi+00000330h
  loc_00D45409:         ecx = esi+00000320h - esi+00000340h * esi+000003F4h
  loc_00D45421:         var_ret_19 = %x1 = Option16.FontSize * esi+00000320h
  loc_00D4543A:         var_ret_1A = %x1 = Option16.FontItalic * esi+00000330h
  loc_00D45489:         ecx =  + %x1 = Option16.FontUnderline * esi+00000340h * esi+000003F4h
  loc_00D454CA:         If (%x1 = Option16.Name = "PT") Then
  loc_00D454E7:           var_1F4 = %x1 = Option16.DragMode
  loc_00D45538:           ecx =  - %x1 = Option16.Value * esi+00000230h - %x1 = Option16.DragMode * esi+000003F4h
  loc_00D4553E:         End If
  loc_00D4553F:         var_ret_21 = CLng(esi+000003BCh)
  loc_00D4554A:         var_2F0 = var_ret_21
  loc_00D45550:         If var_ret_21 >= 211 Then
  loc_00D45552:           var_eax = Err.Raise
  loc_00D45558:         End If
  loc_00D4556D:         var_2F0 = var_2F0 + esi+000002CCh
  loc_00D4556F:         var_2F0 = esi+00000210h
  loc_00D455CA:         ecx = esi+00000200h + esi+000003E4h + esi+000003F4h / 2
  loc_00D455EF:         ecx = esi+000003F4h
  loc_00D455F6:         var_ret_23 = CLng(esi+000003BCh)
  loc_00D45601:         var_2F0 = var_ret_23
  loc_00D45607:         If var_ret_23 >= 211 Then
  loc_00D45609:           var_eax = Err.Raise
  loc_00D4560F:         End If
  loc_00D45624:         var_2F0 = var_2F0 + esi+00000294h
  loc_00D45626:         var_2F0 = esi+00000200h
  loc_00D45681:         ecx = esi+00000220h + esi+00000404h + esi+00000414h / 2
  loc_00D456A6:         ecx = esi+00000414h
  loc_00D456AD:         var_ret_25 = CLng(esi+000003BCh)
  loc_00D456B8:         var_2F0 = var_ret_25
  loc_00D456BE:         If var_ret_25 >= 211 Then
  loc_00D456C0:           var_eax = Err.Raise
  loc_00D456C6:         End If
  loc_00D456DB:         var_2F0 = var_2F0 + esi+000002E8h
  loc_00D456DD:         var_2F0 = esi+00000220h
  loc_00D45738:         ecx = esi+00000230h + esi+00000424h + esi+00000434h / 2
  loc_00D4575D:         ecx = esi+00000434h
  loc_00D45764:         var_ret_27 = CLng(esi+000003BCh)
  loc_00D4576F:         var_2F0 = var_ret_27
  loc_00D45775:         If var_ret_27 >= 211 Then
  loc_00D45777:           var_eax = Err.Raise
  loc_00D4577D:         End If
  loc_00D45792:         var_2F0 = var_2F0 + esi+000002B0h
  loc_00D45794:         var_2F0 = esi+00000230h
  loc_00D4579B:         var_ret_28 = CLng(esi+000003BCh)
  loc_00D457A6:         var_2F0 = var_ret_28
  loc_00D457AC:         If var_ret_28 >= 211 Then
  loc_00D457AE:           var_eax = Err.Raise
  loc_00D457B4:         End If
  loc_00D457C6:         var_ret_29 = esi+00000220h - Option16.Height = %x1s
  loc_00D457E7:         var_ret_2B =  / esi+00000210h - Option16.Top = %x1s
  loc_00D457EE:         var_ret_2B = CSng()
  loc_00D4581A:         If (esi+00000230h < esi+0000051Ch) Then
  loc_00D45828:           ecx = esi+00000230h
  loc_00D4582E:         End If
  loc_00D45845:         If (esi+00000230h > esi+0000053Ch) Then
  loc_00D45853:           ecx = esi+00000230h
  loc_00D45859:         End If
  loc_00D4585F:         var_1F4 = "NO"
  loc_00D45884:         If (esi+00000560h = "NO") Then
  loc_00D458B1:           var_ret_2D = CLng(esi+000003BCh - 1)
  loc_00D458BC:           var_2F0 = var_ret_2D
  loc_00D458C2:           If var_ret_2D >= 211 Then
  loc_00D458C4:             var_eax = Err.Raise
  loc_00D458CA:           End If
  loc_00D458E0:           var_2F0 = var_2F0 + esi+000002B0h
  loc_00D458EC:           If (esi+00000230h < var_2F0) Then
  loc_00D4590F:             var_3C = "000.00"
  loc_00D4593C:             var_ret_2F = CLng(esi+000003BCh - 1)
  loc_00D45947:             var_2F0 = var_ret_2F
  loc_00D4594D:             If var_ret_2F >= 211 Then
  loc_00D4594F:               var_eax = Err.Raise
  loc_00D45955:             End If
  loc_00D45973:             var_4C = Format(var_2F0 + esi+00000294h, var_3C)
  loc_00D459AA:             var_8C = "0.000"
  loc_00D459D7:             var_ret_31 = CLng(esi+000003BCh - 1)
  loc_00D459E2:             var_2F4 = var_ret_31
  loc_00D459E8:             If var_ret_31 >= 211 Then
  loc_00D459EA:               var_eax = Err.Raise
  loc_00D459F0:             End If
  loc_00D45A14:             var_9C = Format(var_2F4 + esi+000002CCh, var_8C)
  loc_00D45A4B:             var_DC = "0.000"
  loc_00D45A7B:             var_ret_33 = CLng(esi+000003BCh - 1)
  loc_00D45A86:             var_2F8 = var_ret_33
  loc_00D45A8C:             If var_ret_33 >= 211 Then
  loc_00D45A8E:               var_eax = Err.Raise
  loc_00D45A94:             End If
  loc_00D45AB8:             var_EC = Format(var_2F8 + esi+000002E8h, var_DC)
  loc_00D45AEF:             var_12C = "0.000"
  loc_00D45B1F:             var_ret_35 = CLng(esi+000003BCh - 1)
  loc_00D45B2A:             var_2FC = var_ret_35
  loc_00D45B30:             If var_ret_35 >= 211 Then
  loc_00D45B32:               var_eax = Err.Raise
  loc_00D45B38:             End If
  loc_00D45B51:             var_294 = edx+eax*4
  loc_00D45B70:             var_13C = Format(edx+eax*4, var_12C)
  loc_00D45BA7:             var_17C = "000.0"
  loc_00D45BD7:             var_ret_37 = CLng(esi+000003BCh - 1)
  loc_00D45BE2:             var_300 = var_ret_37
  loc_00D45BE8:             If var_ret_37 >= 211 Then
  loc_00D45BEA:               var_eax = Err.Raise
  loc_00D45BF0:             End If
  loc_00D45C23:             var_2E4 = "maxT"
  loc_00D45CE0:             var_19C = esi+000003D0h & var_4C & "    " & var_9C & "    " & var_EC & "    " & var_13C & "    " & Format(var_300 + esi+000002B0h + esi+000002B0h, var_17C)
  loc_00D45D1D:             ecx = var_19C & "maxT" & Chr(13) & Chr(10)
  loc_00D45DEA:             ecx = "YES"
  loc_00D45DF0:           End If
  loc_00D45DF0:         End If
  loc_00D45E04:         If (esi+00000570h = "NO") = 0 Then
  loc_00D45E31:           var_ret_39 = CLng(esi+000003BCh - 1)
  loc_00D45E3C:           var_2F0 = var_ret_39
  loc_00D45E42:           If var_ret_39 >= 211 Then
  loc_00D45E44:             var_eax = Err.Raise
  loc_00D45E4A:           End If
  loc_00D45E60:           var_2F0 = var_2F0 + esi+000002E8h
  loc_00D45E6C:           If (esi+00000220h < var_2F0) Then
  loc_00D45E8F:             var_3C = "000.00"
  loc_00D45EBC:             var_ret_3B = CLng(esi+000003BCh - 1)
  loc_00D45EC7:             var_2F0 = var_ret_3B
  loc_00D45ECD:             If var_ret_3B >= 211 Then
  loc_00D45ECF:               var_eax = Err.Raise
  loc_00D45ED5:             End If
  loc_00D45EF3:             var_4C = Format(var_2F0 + esi+00000294h, var_3C)
  loc_00D45F2A:             var_8C = "0.000"
  loc_00D45F57:             var_ret_3D = CLng(esi+000003BCh - 1)
  loc_00D45F62:             var_2F4 = var_ret_3D
  loc_00D45F68:             If var_ret_3D >= 211 Then
  loc_00D45F6A:               var_eax = Err.Raise
  loc_00D45F70:             End If
  loc_00D45F94:             var_9C = Format(var_2F4 + esi+000002CCh, var_8C)
  loc_00D45FCB:             var_DC = "0.000"
  loc_00D45FFB:             var_ret_3F = CLng(esi+000003BCh - 1)
  loc_00D46006:             var_2F8 = var_ret_3F
  loc_00D4600C:             If var_ret_3F >= 211 Then
  loc_00D4600E:               var_eax = Err.Raise
  loc_00D46014:             End If
  loc_00D46038:             var_EC = Format(var_2F8 + esi+000002E8h, var_DC)
  loc_00D4606F:             var_12C = "0.000"
  loc_00D4609F:             var_ret_41 = CLng(esi+000003BCh - 1)
  loc_00D460AA:             var_2FC = var_ret_41
  loc_00D460B0:             If var_ret_41 >= 211 Then
  loc_00D460B2:               var_eax = Err.Raise
  loc_00D460B8:             End If
  loc_00D460D1:             var_294 = ecx+edx*4
  loc_00D460F0:             var_13C = Format(ecx+edx*4, var_12C)
  loc_00D46127:             var_17C = "000.0"
  loc_00D46157:             var_ret_43 = CLng(esi+000003BCh - 1)
  loc_00D46165:             If var_ret_43 >= 211 Then
  loc_00D46167:               var_eax = Err.Raise
  loc_00D4616D:             End If
  loc_00D461A0:             var_2E4 = "maxY"
  loc_00D46255:             var_19C = esi+000003D0h & var_4C & "    " & var_9C & "    " & var_EC & "    " & var_13C & "    " & Format(var_ret_43 + esi+000002B0h + esi+000002B0h, var_17C)
  loc_00D4628E:             ecx = var_19C & "maxY" & Chr(13) & Chr(10)
  loc_00D46346:             ecx = "YES"
  loc_00D4634C:           End If
  loc_00D4634C:         End If
  loc_00D46361:       Next esi+000003ACh
  loc_00D46369:       GoTo loc_00D44FEB
  loc_00D4636E:     End If
  loc_00D4638B:     var_2C = "000.00"
  loc_00D46398:     var_ret_44 = CLng(esi+000003BCh)
  loc_00D463A3:     var_2F0 = var_ret_44
  loc_00D463A9:     If var_ret_44 >= 211 Then
  loc_00D463AB:       var_eax = Err.Raise
  loc_00D463B1:     End If
  loc_00D463CF:     var_3C = Format(var_2F0 + esi+00000294h, var_2C)
  loc_00D46403:     var_6C = "0.000"
  loc_00D46410:     var_ret_45 = CLng(esi+000003BCh)
  loc_00D4641B:     var_2F4 = var_ret_45
  loc_00D46421:     If var_ret_45 >= 211 Then
  loc_00D46423:       var_eax = Err.Raise
  loc_00D46429:     End If
  loc_00D46447:     var_7C = Format(var_2F4 + esi+000002CCh, var_6C)
  loc_00D4647E:     var_AC = "0.000"
  loc_00D4648B:     var_ret_46 = CLng(esi+000003BCh)
  loc_00D46496:     var_2F8 = var_ret_46
  loc_00D4649C:     If var_ret_46 >= 211 Then
  loc_00D4649E:       var_eax = Err.Raise
  loc_00D464A4:     End If
  loc_00D464C8:     var_BC = Format(var_2F8 + esi+000002E8h, var_AC)
  loc_00D464FF:     var_EC = "0.000"
  loc_00D4650C:     var_ret_47 = CLng(esi+000003BCh)
  loc_00D46517:     var_2FC = var_ret_47
  loc_00D4651D:     If var_ret_47 >= 211 Then
  loc_00D4651F:       var_eax = Err.Raise
  loc_00D46525:     End If
  loc_00D4653E:     var_254 = eax+ecx*4
  loc_00D4655D:     var_FC = Format(eax+ecx*4, var_EC)
  loc_00D46594:     var_12C = "000.0"
  loc_00D465A1:     var_ret_48 = CLng(esi+000003BCh)
  loc_00D465AC:     var_300 = var_ret_48
  loc_00D465B2:     If var_ret_48 >= 211 Then
  loc_00D465B4:       var_eax = Err.Raise
  loc_00D465BA:     End If
  loc_00D46693:     var_14C = esi+000003D0h & var_3C & "    " & var_7C & "    " & var_BC & "    " & var_FC & "    " & Format(var_300 + esi+000002B0h, var_12C)
  loc_00D466BF:     ecx = var_14C & Chr(13) & Chr(10)
  loc_00D46774:   Next esi+0000039Ch
  loc_00D4677A:   GoTo loc_00D44F81
  loc_00D4677F: End If
  loc_00D46782: var_eax = Unknown_VTable_Call[eax+00000348h]
  loc_00D467A6: var_18 = CStr(esi+000003D0h)
  loc_00D467AC: var_354 = var_18
  loc_00D467C0: Option16.MousePointer = var_18
  loc_00D46802: ecx = esi+00000200h
  loc_00D46824: ecx = "YES"
  loc_00D4684E: If (%x1 = Option16.Name = "PT") Then
  loc_00D46882:   If (%x1 = Option16.DragMode < esi+0000051Ch) Then
  loc_00D468A2:     ecx = var_310 = Option16.DragMode
  loc_00D468A8:   End If
  loc_00D468D1:   If (%x1 = Option16.DragMode > esi+0000053Ch) Then
  loc_00D468F1:     ecx =  = Option16.DragMode
  loc_00D468F7:   End If
  loc_00D468F7: End If
  loc_00D468FD: GoTo loc_00D469D9
  loc_00D469D8: Exit Sub
  loc_00D469D9: 'Referenced from: 00D468FD
End Sub