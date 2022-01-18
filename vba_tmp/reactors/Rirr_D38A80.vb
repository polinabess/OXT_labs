Public Sub Rirr(Rs, Ks, Xs) 'D38A80
  Dim var_ret_3 As Me
  Dim var_ret_5 As Me
  loc_00D38B45: var_13C = %x1 = Me.HasDC
  loc_00D38B6D: call __vbaVarVargNofree(__vbaVarVargNofree, ebx)
  loc_00D38B80: call __vbaVarVargNofree(var_D4, __vbaVarVargNofree(__vbaVarVargNofree, ebx))
  loc_00D38BAA: var_ret_3 =  *  - __vbaVarVargNofree(var_D4, __vbaVarVargNofree(__vbaVarVargNofree, ebx)) ^ %x1 = Me.MaxButton
  loc_00D38BC4: call __vbaVarVargNofree(%x1 = Me.BorderStyle, var_114)
  loc_00D38BD2: var_ret_5 =  -  * __vbaVarVargNofree(%x1 = Me.BorderStyle, var_114)
  loc_00D38BF2: var_ret_7 =  *  ^ %x1 = Me.ControlBox
  loc_00D38C0C: call __vbaVarVargNofree(Me, var_134, var_ret_7)
  loc_00D38C43: var_ret_A =  /  +  * __vbaVarVargNofree(Me, var_134, var_ret_7) ^ %x1 = Me.HasDC
  loc_00D38C4E: call __vbaVargVarMove
  loc_00D38C66: GoTo loc_00D38CAF
  loc_00D38CAE: Exit Sub
  loc_00D38CAF: 'Referenced from: 00D38C66
End Sub