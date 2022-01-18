Public Sub Rrev(Rs, Ks, Kps, Xs) 'D38CD0
  Dim var_ret_4 As Me
  loc_00D38D89: call __vbaVarVargNofree(edi, Me, __vbaVarVargNofree)
  loc_00D38D97: var_ret_1 = __vbaVarVargNofree(edi, Me, __vbaVarVargNofree) ^ esi+00000474h
  loc_00D38DAE: call __vbaVarVargNofree(var_D8, var_ret_1)
  loc_00D38DC0: var_ret_3 =  /  - __vbaVarVargNofree(var_D8, var_ret_1)
  loc_00D38DD7: call __vbaVarVargNofree(esi+000004A4h, var_ret_3)
  loc_00D38DDE: var_ret_4 =  - __vbaVarVargNofree(esi+000004A4h, var_ret_3)
  loc_00D38DFB: var_ret_6 =  /  ^ Me.Visible = %x1b
  loc_00D38E19: call __vbaVarVargNofree(esi+00000494h, var_118, var_ret_6)
  loc_00D38E54: var_ret_9 =  /  +  * __vbaVarVargNofree(esi+00000494h, var_118, var_ret_6) ^ esi+00000484h
  loc_00D38E5B: var_ret_9 = CSng()
  loc_00D38E79: var_C0 = esi+000004B4h
  loc_00D38E9C: var_E0 = var_18
  loc_00D38EC1: call __vbaVarVargNofree(var_C8, var_F8)
  loc_00D38EE5: var_ret_C =  -  / __vbaVarVargNofree(var_C8, var_F8) * var_18
  loc_00D38EEC: var_ret_C = CSng()
  loc_00D38F04: var_eax = Call Form2.Rirr(Rs, Ks, Xs)
  loc_00D38F26: var_C0 = var_18
  loc_00D38F3E: call __vbaVarVargNofree
  loc_00D38F4C: var_ret_D = __vbaVarVargNofree * var_18
  loc_00D38F56: call __vbaVargVarMove
  loc_00D38F62: GoTo loc_00D38FA4
  loc_00D38FA3: Exit Sub
  loc_00D38FA4: 'Referenced from: 00D38F62
End Sub