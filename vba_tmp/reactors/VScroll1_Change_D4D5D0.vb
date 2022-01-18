Private Sub VScroll1_Change() 'D4D5D0
  Dim var_1C As VScrollBar
  Dim var_34 As VScrollBar
  Dim var_18 As VScrollBar
  loc_00D4D62C: If esi+00000598h = var_3F800000 Then
  loc_00D4D635:   var_eax = Unknown_VTable_Call[edx+0000031Ch]
  loc_00D4D64B:   var_34 = var_1C
  loc_00D4D664:   var_24 = VScroll1.Value
  loc_00D4D696:   var_50 = var_24 - 0001h
  loc_00D4D6A6:   VScroll1.Width = var_54
  loc_00D4D6D4:   var_eax = Unknown_VTable_Call[eax+0000031Ch]
  loc_00D4D6EA:   var_28 = VScroll1.Enabled
  loc_00D4D705:   var_eax = Unknown_VTable_Call[ecx+00000320h]
  loc_00D4D72D:   var_24 = VScroll1.Value
  loc_00D4D74F:   var_58 = var_24
  loc_00D4D775:   VScroll1.Width = Unknown_VTable_Call[ecx+00000320h]
  loc_00D4D77C:   If Err.Number < 0 Then
  loc_00D4D782:     GoTo loc_00D4D958
  loc_00D4D787:   End If
  loc_00D4D78C:   If Err.Number = var_40000000 Then
  loc_00D4D791:     var_eax = Unknown_VTable_Call[eax+00000324h]
  loc_00D4D7BF:     var_24 = VScroll1.Value
  loc_00D4D7F0:     var_60 = var_24 - 0001h
  loc_00D4D7FC:     GoTo loc_00D4D9FC
  loc_00D4D801:   End If
  loc_00D4D806:   If edi = var_40400000 Then
  loc_00D4D80F:     var_eax = Unknown_VTable_Call[ecx+00000328h]
  loc_00D4D822:     var_34 = Unknown_VTable_Call[ecx+00000328h]
  loc_00D4D83E:     var_24 = VScroll1.Value
  loc_00D4D863:     var_24 = var_24 - 0001h
  loc_00D4D870:     var_68 = var_24
  loc_00D4D880:     VScroll1.Width = var_6C
  loc_00D4D8AE:     var_eax = Unknown_VTable_Call[edx+00000328h]
  loc_00D4D8C4:     var_28 = VScroll1.Enabled
  loc_00D4D8DF:     var_eax = Unknown_VTable_Call[eax+0000032Ch]
  loc_00D4D907:     var_24 = VScroll1.Value
  loc_00D4D929:     var_70 = var_24
  loc_00D4D94F:     VScroll1.Width = Unknown_VTable_Call[eax+0000032Ch]
  loc_00D4D956:     If Err.Number < 0 Then
  loc_00D4D958:       'Referenced from: 00D4D782
  loc_00D4D961:       Err.Number = CheckObj(Unknown_VTable_Call[eax+0000032Ch], var_00D2ACD4, 108)
  loc_00D4D967:     End If
  loc_00D4D967:   End If
  loc_00D4D97E:   GoTo loc_00D4DACF
  loc_00D4D983: End If
  loc_00D4D988: If var_20 = var_40800000 Then
  loc_00D4D991:   var_eax = Unknown_VTable_Call[eax+00000330h]
  loc_00D4D9BF:   var_24 = VScroll1.Value
  loc_00D4D9F0:   var_78 = var_24 - 0001h
  loc_00D4D9FC:   'Referenced from: 00D4D7FC
  loc_00D4D9FE:   VScroll1.Width = var_7C
  loc_00D4DA1E:   GoTo loc_00D4DAC4
  loc_00D4DA23: End If
  loc_00D4DA28: If var_18 <> var_40A00000 Then GoTo loc_00D4DACF
  loc_00D4DA31: var_eax = Unknown_VTable_Call[ecx+00000334h]
  loc_00D4DA5F: var_24 = VScroll1.Value
  loc_00D4DA83: var_24 = var_24 - 0001h
  loc_00D4DA90: var_80 = var_24
  loc_00D4DAA4: VScroll1.Width = var_84
  loc_00D4DAC4: 'Referenced from: 00D4DA1E
  loc_00D4DACF: 'Referenced from: 00D4D97E
  loc_00D4DADC: GoTo loc_00D4DAF6
  loc_00D4DAF5: Exit Sub
  loc_00D4DAF6: 'Referenced from: 00D4DADC
  loc_00D4DAF6: Exit Sub
End Sub