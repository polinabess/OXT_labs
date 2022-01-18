Private Sub Option11_Click() 'D34230
  Dim var_18 As Variant
  Dim var_3C As Variant
  loc_00D34284: var_eax = Unknown_VTable_Call[edx+0000031Ch]
  loc_00D3429E: Me.Width = NAN
  loc_00D342D2: var_eax = Unknown_VTable_Call[edx+00000320h]
  loc_00D342E7: Me.Width = NAN
  loc_00D34310: var_eax = Unknown_VTable_Call[eax+0000031Ch]
  loc_00D34327: var_28 = Me.Top
  loc_00D34341: var_eax = Unknown_VTable_Call[eax+00000320h]
  loc_00D34351: var_3C = Unknown_VTable_Call[eax+00000320h]
  loc_00D34354: var_eax = Unknown_VTable_Call[edx+0000031Ch]
  loc_00D3436B: var_24 = Me.ForeColor
  loc_00D3439C: Me.ForeColor = var_3C
  loc_00D343CD: var_eax = Unknown_VTable_Call[edx+00000324h]
  loc_00D343E2: Me.Width = 0
  loc_00D3440B: var_eax = Unknown_VTable_Call[eax+00000328h]
  loc_00D34420: Me.Width = 0
  loc_00D34449: var_eax = Unknown_VTable_Call[edx+0000032Ch]
  loc_00D3445E: Me.Width = 0
  loc_00D34487: var_eax = Unknown_VTable_Call[eax+00000330h]
  loc_00D3449C: Me.Width = 0
  loc_00D344C5: var_eax = Unknown_VTable_Call[edx+00000334h]
  loc_00D344D7: var_2C = var_18
  loc_00D344DA: Me.Width = 0
  loc_00D34518: VScroll1.Value = 0
  loc_00D34541: var_eax = Unknown_VTable_Call[edx+0000031Ch]
  loc_00D34558: var_24 = VScroll1.Enabled
  loc_00D34572: var_eax = Unknown_VTable_Call[edx+00000320h]
  loc_00D34589: var_28 = VScroll1.Enabled
  loc_00D345D8: VScroll1.Max = CInt(((5.79330657065194E-315 - var_24) - var_28))
  loc_00D34616: var_eax = Call Form2.VScroll1_Change
  loc_00D3463B: GoTo loc_00D34655
  loc_00D34654: Exit Sub
  loc_00D34655: 'Referenced from: 00D3463B
  loc_00D34655: Exit Sub
End Sub