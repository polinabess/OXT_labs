Public Sub Progr2() 'D3C3D0
  Dim var_1AC As Me
  Dim var_3C As Variant
  loc_00D3C521: ecx = Me.Top = ecx = %S_edx_S
  loc_00D3C533: ecx = Me.Height =
  loc_00D3C542: ecx = Me.ForeColor =
  loc_00D3C554: ecx = esi+00000200h
  loc_00D3C566: ecx =  = Me.Count
  loc_00D3C578: ecx =  = Me.MouseIcon
  loc_00D3C58B: If var_D4F000 = 0 Then
  loc_00D3C593:   GoTo loc_00D3C5A0
  loc_00D3C595: End If
  loc_00D3C59B: call _adj_fdiv_m32(var_401368)
  loc_00D3C5A0: 'Referenced from: 00D3C593
  loc_00D3C5BB: ecx = "NO"
  loc_00D3C5E7: Call Form2.K_react(%x1 = Me.WhatsThisHelp, Me.ScaleLeft = %x1s, Me.ScaleWidth = %x1s, , )
  loc_00D3C629: var_ret_1 =  - %x1 = Me.Count
  loc_00D3C634: var_3C = var_ret_1
  loc_00D3C652: Call Form2.Rcom(esi+00000320h, %x1 = Me.WhatsThisHelp, , )
  loc_00D3C69D: Call Form2.K_react(%x1 = Me.RightToLeft, esi+00000230h, , , )
  loc_00D3C6DF: var_ret_2 = 1 - %x1 = Me.Count
  loc_00D3C6EA: var_3C = var_ret_2
  loc_00D3C708: Call Form2.Rcom(esi+00000330h, %x1 = Me.RightToLeft, , )
  loc_00D3C73F: var_1A4 = %x1 = Me.OLEDropMode
  loc_00D3C77C: Call Form2.K_react(&H4004, esi+00000230h, Me.ScaleLeft = %x1s, &H4004, )
  loc_00D3C7B8: var_1B4 = %x1 = Me.HasDC
  loc_00D3C7CB: var_1A4 = %x1 = Me.OLEDropMode
  loc_00D3C7E0: var_eax = Call Form2.Rcom(esi+00000340h, var_1AC, var_1BC, )
  loc_00D3C832: var_ret_4 = esi+00000320h - esi+00000340h / esi+00000320h + esi+00000330h
  loc_00D3C839: var_ret_4 = CSng()
  loc_00D3C859: var_1A4 = esi+00000398h
  loc_00D3C898: ecx = esi+00000320h + esi+00000330h * esi+00000398
  loc_00D3C8BB: var_1A4 = esi+00000398h
  loc_00D3C8EB: ecx = esi+00000320h - esi+00000340h * esi+00000398
  loc_00D3C922: If (esi+000003E4h > 0.1#) Then
  loc_00D3C95B:   var_3C = "Время реакции"
  loc_00D3C97E:   var_2C = "Большой начальный градиент Х!"
  loc_00D3C9A7:   var_1E4 = MsgBox(var_2C, 0, var_3C, var_4C, var_5C)
  loc_00D3C9B7:   ecx = MsgBox(var_2C, 0, var_3C, var_4C, var_5C)
  loc_00D3C9D4:   GoTo loc_00D3DC85
  loc_00D3C9D9: End If
  loc_00D3C9DC: var_eax = Unknown_VTable_Call[edx+00000384h]
  loc_00D3C9FB: Option16.Caption = "  t         X          Y          S "
  loc_00D3CA43: ecx = vbNullString
  loc_00D3CB5F: var_204 = Form2.Option16 'Ignore this
  loc_00D3CBF5: var_CC = esi+000003D0h & Format(esi+00000200h, "000.00") & "   " & Format(esi+00000210h, "0.000") & "   " & Format(esi+00000220h, "0.000")
  loc_00D3CC43: ecx = var_CC & "   " & Format(Form2.Option16 & Chr(13) & Chr(10)
  loc_00D3CD1F: For esi+0000039Ch = 1 To 10 Step 1
  loc_00D3CD25: 
  loc_00D3CD27:   If esi+0000039Ch Then
  loc_00D3CD89:     For esi+000003ACh = 1 To 20 Step 1
  loc_00D3CD8F: 
  loc_00D3CD91:       If esi+000003ACh Then
  loc_00D3CE00:         ecx = 20 * esi+0000039Ch - 1 + esi+000003ACh
  loc_00D3CE2B:         ecx = esi+00000210h + esi+000003E4h
  loc_00D3CE56:         ecx = esi+00000220h + esi+00000404h
  loc_00D3CE8C:         If (esi+00000444h < 1) Then
  loc_00D3CEC3:           var_3C = 1 - esi+00000444h
  loc_00D3CEE1:           Call Form2.Rcom(esi+00000320h, esi+00000260h, %x1 = Option16.Style, )
  loc_00D3CF37:           var_3C = 1 - esi+00000444h
  loc_00D3CF55:           Call Form2.Rcom(esi+00000330h, esi+00000270h, %x1 = Option16.MaskColor, )
  loc_00D3CF7A:           GoTo loc_00D3CFC0
  loc_00D3CF7C:         End If
  loc_00D3CF9C:         ecx = 0
  loc_00D3CFBE:         ecx = 0
  loc_00D3CFC0:         'Referenced from: 00D3CF7A
  loc_00D3CFEB:         If (esi+00000454h > 0) Then
  loc_00D3CFF9:           var_1A4 = esi+00000280h
  loc_00D3D008:           var_1B4 = Option16.AddItem
  loc_00D3D035:           var_eax = Call Form2.Rcom(esi+00000340h, var_1AC, var_1BC, esi+00000454h)
  loc_00D3D08D:         var_1A4 = esi+00000398h
  loc_00D3D0BD:         ecx = esi+00000320h + esi+00000330h * esi+00000398
  loc_00D3D0D1:         var_1A4 = esi+00000398h
  loc_00D3D110:         ecx = esi+00000320h - esi+00000340h * esi+00000398
  loc_00D3D167:         ecx = esi+00000210h + esi+000003E4h + esi+000003F4h / 2
  loc_00D3D188:         ecx = esi+000003F4h
  loc_00D3D1E3:         ecx = esi+00000220h + esi+00000404h + esi+00000414h / 2
  loc_00D3D204:         ecx = esi+00000414h
  loc_00D3D235:         If (esi+00000210h >= 1) Then
  loc_00D3D257:           ecx = CInt(1)
  loc_00D3D259:         End If
  loc_00D3D284:         If (esi+00000220h >= 1) Then
  loc_00D3D2A6:           ecx = CInt(1)
  loc_00D3D2A8:         End If
  loc_00D3D2D3:         If (esi+00000220h <= 0) Then
  loc_00D3D2F5:           ecx = 0
  loc_00D3D2F7:         End If
  loc_00D3D30F:         var_1A4 = esi+00000398h
  loc_00D3D32D:         ecx = esi+00000200h + esi+00000398
  loc_00D3D33F:         var_ret_11 = CLng(esi+000003BCh)
  loc_00D3D34A:         var_270 = var_ret_11
  loc_00D3D350:         If var_ret_11 >= 211 Then
  loc_00D3D352:           var_eax = Err.Raise
  loc_00D3D35E:         End If
  loc_00D3D36F:         var_270 = var_270 + esi+00000294h
  loc_00D3D371:         var_270 = esi+00000200h
  loc_00D3D37E:         var_ret_12 = CLng(esi+000003BCh)
  loc_00D3D389:         var_270 = var_ret_12
  loc_00D3D38F:         If var_ret_12 >= 211 Then
  loc_00D3D391:           var_eax = Err.Raise
  loc_00D3D39D:         End If
  loc_00D3D3AE:         var_270 = var_270 + esi+000002CCh
  loc_00D3D3B0:         var_270 = esi+00000210h
  loc_00D3D3BD:         var_ret_13 = CLng(esi+000003BCh)
  loc_00D3D3C8:         var_270 = var_ret_13
  loc_00D3D3CE:         If var_ret_13 >= 211 Then
  loc_00D3D3D0:           var_eax = Err.Raise
  loc_00D3D3DC:         End If
  loc_00D3D3ED:         var_270 = var_270 + esi+000002E8h
  loc_00D3D3EF:         var_270 = esi+00000220h
  loc_00D3D3FC:         var_ret_14 = CLng(esi+000003BCh)
  loc_00D3D407:         var_270 = var_ret_14
  loc_00D3D40D:         If var_ret_14 >= 211 Then
  loc_00D3D40F:           var_eax = Err.Raise
  loc_00D3D415:         End If
  loc_00D3D448:         var_ret_17 =  / esi+00000220h - Option16.Height = %x1s - Option16.Top = %x1s
  loc_00D3D44F:         var_ret_17 = CSng()
  loc_00D3D478:         If (esi+00000570h = "NO") = 0 Then
  loc_00D3D4AB:           var_ret_19 = CLng(esi+000003BCh - 1)
  loc_00D3D4B6:           var_270 = var_ret_19
  loc_00D3D4BC:           If var_ret_19 >= 211 Then
  loc_00D3D4BE:             var_eax = Err.Raise
  loc_00D3D4CA:           End If
  loc_00D3D4DA:           var_270 = var_270 + esi+000002E8h
  loc_00D3D4E6:           If (esi+00000220h < var_270) Then
  loc_00D3D509:             var_3C = "000.00"
  loc_00D3D53C:             var_ret_1B = CLng(esi+000003BCh - 1)
  loc_00D3D547:             var_270 = var_ret_1B
  loc_00D3D54D:             If var_ret_1B >= 211 Then
  loc_00D3D54F:               var_eax = Err.Raise
  loc_00D3D55B:             End If
  loc_00D3D573:             var_4C = Format(var_270 + esi+00000294h, var_3C)
  loc_00D3D5AA:             var_8C = "0.000"
  loc_00D3D5DD:             var_ret_1D = CLng(esi+000003BCh - 1)
  loc_00D3D5E8:             var_274 = var_ret_1D
  loc_00D3D5EE:             If var_ret_1D >= 211 Then
  loc_00D3D5F0:               var_eax = Err.Raise
  loc_00D3D5FC:             End If
  loc_00D3D61A:             var_9C = Format(var_274 + esi+000002CCh, var_8C)
  loc_00D3D651:             var_DC = "0.000"
  loc_00D3D687:             var_ret_1F = CLng(esi+000003BCh - 1)
  loc_00D3D692:             var_278 = var_ret_1F
  loc_00D3D698:             If var_ret_1F >= 211 Then
  loc_00D3D69A:               var_eax = Err.Raise
  loc_00D3D6A6:             End If
  loc_00D3D6C4:             var_EC = Format(var_278 + esi+000002E8h, var_DC)
  loc_00D3D6FB:             var_12C = "0.000"
  loc_00D3D731:             var_ret_21 = CLng(esi+000003BCh - 1)
  loc_00D3D73C:             var_27C = var_ret_21
  loc_00D3D742:             If var_ret_21 >= 211 Then
  loc_00D3D744:               var_eax = Err.Raise
  loc_00D3D750:             End If
  loc_00D3D769:             var_244 = edx+eax*4
  loc_00D3D791:             var_264 = "  maxY"
  loc_00D3D84E:             var_17C = esi+000003D0h & var_4C & "   " & var_9C & "   " & var_EC & "   " & Format(edx+eax*4, var_12C) & "  maxY" & Chr(13)
  loc_00D3D869:             ecx = var_17C & Chr(10)
  loc_00D3D901:             ecx = "YES"
  loc_00D3D907:           End If
  loc_00D3D907:         End If
  loc_00D3D91C:       Next esi+000003ACh
  loc_00D3D922:       GoTo loc_00D3CD8F
  loc_00D3D927:     End If
  loc_00D3D95D:     var_3C = Format(esi+00000200h, "000.00")
  loc_00D3D9AA:     var_7C = Format(esi+00000210h, "0.000")
  loc_00D3DA00:     var_BC = Format(esi+00000220h, "0.000")
  loc_00D3DA37:     var_EC = "0.000"
  loc_00D3DA44:     var_ret_22 = CLng(esi+000003BCh)
  loc_00D3DA4F:     var_270 = var_ret_22
  loc_00D3DA55:     If var_ret_22 >= 211 Then
  loc_00D3DA57:       var_eax = Err.Raise
  loc_00D3DA63:     End If
  loc_00D3DA80:     var_204 = ecx+eax*4
  loc_00D3DAB3:     var_13C = Chr(10)
  loc_00D3DB39:     var_12C = esi+000003D0h & var_3C & "   " & var_7C & "   " & var_BC & "   " & Format(ecx+eax*4, var_EC) & Chr(13)
  loc_00D3DB54:     ecx = var_12C & var_13C
  loc_00D3DBE9:   Next esi+0000039Ch
  loc_00D3DBEF:   GoTo loc_00D3CD25
  loc_00D3DBF4: End If
  loc_00D3DBF7: var_eax = Unknown_VTable_Call[edx+00000348h]
  loc_00D3DC17: var_18 = CStr(esi+000003D0h)
  loc_00D3DC1F: Option16.MousePointer = var_18
  loc_00D3DC61: ecx = esi+00000200h
  loc_00D3DC83: ecx = "NO"
  loc_00D3DC85: 'Referenced from: 00D3C9D4
  loc_00D3DC8B: GoTo loc_00D3DD44
  loc_00D3DD43: Exit Sub
  loc_00D3DD44: 'Referenced from: 00D3DC8B
  loc_00D3DD6B: Exit Sub
End Sub