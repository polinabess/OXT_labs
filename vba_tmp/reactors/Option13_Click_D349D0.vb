Private Sub Option13_Click() 'D349D0
  Dim var_3C As Variant
  loc_00D34A24: var_eax = Unknown_VTable_Call[edx+0000031Ch]
  loc_00D34A3E: Me.Width = 0
  loc_00D34A72: var_eax = Unknown_VTable_Call[edx+00000320h]
  loc_00D34A87: Me.Width = 0
  loc_00D34AB0: var_eax = Unknown_VTable_Call[eax+00000324h]
  loc_00D34AC5: Me.Width = 0
  loc_00D34AEE: var_eax = Unknown_VTable_Call[edx+00000328h]
  loc_00D34B03: Me.Width = NAN
  loc_00D34B2C: var_eax = Unknown_VTable_Call[eax+0000032Ch]
  loc_00D34B41: Me.Width = NAN
  loc_00D34B6A: var_eax = Unknown_VTable_Call[edx+00000328h]
  loc_00D34B81: var_28 = Me.Top
  loc_00D34B9B: var_eax = Unknown_VTable_Call[edx+0000032Ch]
  loc_00D34BAB: var_3C = var_20
  loc_00D34BAE: var_eax = Unknown_VTable_Call[ecx+00000328h]
  loc_00D34BC5: var_24 = Me.ForeColor
  loc_00D34BF6: Me.ForeColor = var_3C
  loc_00D34C27: var_eax = Unknown_VTable_Call[edx+00000330h]
  loc_00D34C3C: Me.Width = 0
  loc_00D34C65: var_eax = Unknown_VTable_Call[eax+00000334h]
  loc_00D34C7A: Me.Width = 0
  loc_00D34CB8: VScroll1.Value = 0
  loc_00D34CE1: var_eax = Unknown_VTable_Call[eax+00000328h]
  loc_00D34CF8: var_24 = VScroll1.Enabled
  loc_00D34D12: var_eax = Unknown_VTable_Call[eax+0000032Ch]
  loc_00D34D29: var_28 = VScroll1.Enabled
  loc_00D34D78: VScroll1.Max = CInt(((5.79330657065194E-315 - var_24) - var_28))
  loc_00D34DB6: var_eax = Call Form2.VScroll1_Change
  loc_00D34DDB: GoTo loc_00D34DF5
  loc_00D34DF4: Exit Sub
  loc_00D34DF5: 'Referenced from: 00D34DDB
  loc_00D34DF5: Exit Sub
End Sub