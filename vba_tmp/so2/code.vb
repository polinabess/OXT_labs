 
 	SO2-m
 Option Explicit
      'Варианты
         Dim Variable1, Cat As Integer
         Dim DataVar(11) As String
             'Исходные данные по катализатору
         Dim Tz, Kz, E1, E2, E3, T12, T23, K12, K23, Rgas As Single
         Dim CatDatN(10, 7), Flow As String
             'Начальные условия
         Dim CSO20, CSO2, CO20, CO2, P, Tad, XH, XK, TH, TK, TayK, dX, dT As Single
         Dim Ncat As Integer
             'Текущие значения
         Dim X, T, Kr, Kp, W, FT, FV, EI, Tay, Tay1 As Single
               '1-Xp(T)
         Dim TXpKp(3, 250), TH1, TK1, dT1, A1, B1, P1, NXp As Variant
               '2-W(T)
         Dim WT(2, 250), XH2, TH2, TK2, dT2, A2, B2, P2, NW, Cat2 As Variant
               '3-Topt
         Dim XTopt(3, 250), XH3, XK3, dX3, A3, B3, P3, NTopt, Cat3 As Variant
               '4-Tay(X)
         Dim TayX(3, 120), Tad4, XH4, XK4, TH4, A4, B4, P4, NtX, Cat4 As Variant
         Dim Taymax As Single
         Dim Flow4 As String
               '5-X(Tay)
         Dim XTay(3, 120), Tad5, XH5, TH5, TayK5, A5, B5, P5, NXt, Cat5 As Variant
         Dim Taymax5 As Single
         Dim Flow5 As String
               '6-Р-р с Т.О.
         Dim ReactTO(6, 6), Tad6, XH6, TH6, XK6, A6, B6, P6, Cat6 As Variant
         Dim Fx, FF As Variant
         Dim Ncat6 As Integer
         Dim Flow6 As String
               '7-Р-р с Х.Г.
         Dim ReactCG(7, 6), Tad7, XH7, TH7, XK7, Tcg7, A7, B7, P7, Cat7, Vg1 As Variant
         Dim F12cg As Variant        'Для расчета Тн2
         Dim Ncat7 As Integer
               '8-Р-р с Х.B.
         Dim ReactCA(10, 6), Tad8, XH8, TH8, XK8, Tca8, A8, B8, P8, Cat8, Va8 As Variant
         Dim F12ca, Va8i As Variant        'Для расчета Тн2
         Dim Ncat8 As Integer
               '9-Р-р II ступень ДК
         Dim ReactII(6, 6), Tad9, XH9, TH9, XK9, A9, B9, P9, Cat9 As Variant
         Dim Ncat9 As Integer
             'Вспомогательные переменные
         Dim L, I, J, Oo, VarHelp As Integer
         Dim XU, XD, TU, TD, FU, FI, FD, BB As Single
         Dim diX, dTay, dFT, F, SFT, SFT1, W1, W2, FT1, WT1 As Single  'Для интегрирования
         Dim X1D, DX0 As Variant                       'Для подбора Х1к
         Dim XiH, TiH, XiK, TiK, dTiH As Variant       'Для расчета слоя реактора
         Dim WiK, DXS As Variant                 ' -"-
         Dim Xa, Xb, Xc As Single
         Dim AA As String
         Dim X1, X2, Y1, Y2, Ymax As Single    'Для графиков
         
 
 Private Sub Combo1_Click()
    'Выбор катализатора
   Cat = Combo1.ListIndex + 1
   Catalyst
 End Sub
 
 Private Sub Command1_Click()
    'Выход
  End
 End Sub
 
Private Sub Command2_Click()
    'В начало
  Frame1.Left = 120
  Command2.Visible = False
  Command4.Visible = False
  Command5.Visible = False
End Sub

Private Sub Command3_Click()
    'Вариант выбран - начало
 Frame1.Left = 26000
 Command2.Visible = True
 Command4.Visible = True
 Command5.Visible = False
      'Подготовка координат графика
  Select Case Variable1
  Case 1, 3, 6, 7, 8, 9  'График Т-Х
      Label16.Caption = " X 1"
      Label15.Caption = " 700"
      Label18.Caption = "800"
      Label19.Caption = "900 T,K"
      Label20.Visible = False
      Label21.Visible = False
  Case 2      'График W(T)
      Label16.Caption = "W 1"
      Label15.Caption = " 700"
      Label18.Caption = "800"
      Label19.Caption = "900 T,K"
      Label20.Visible = False
      Label21.Visible = False
  Case 4, 5     'График X(tay)
      Label16.Caption = " X 1"
      Label15.Visible = False
      Label18.Visible = False
      Label19.Caption = Format(Taymax, "0.00" & " Tay")
      Label20.Visible = True
      Label21.Visible = True
  End Select
          'Проверка - был ли вариант?
  Select Case Variable1
    Case 1
    If List1.ListCount > 0 Then Command5.Visible = True
    Case 2
    If List2.ListCount > 0 Then Command5.Visible = True
    Case 3
    If List3.ListCount > 0 Then Command5.Visible = True
    Case 4
    If List4.ListCount > 0 Then Command5.Visible = True
    Case 5
    If List5.ListCount > 0 Then Command5.Visible = True
    Case 6
    If List6.ListCount > 0 Then Command5.Visible = True
    Case 7
    If List7.ListCount > 0 Then Command5.Visible = True
    Case 8
    If List8.ListCount > 0 Then Command5.Visible = True
    Case 9
    If List9.ListCount > 0 Then Command5.Visible = True
  End Select
End Sub
 
Private Sub Command4_Click()
    'Расчет - Пуск!
      'Выбор варианта расчета
  Select Case Variable1
    Case 1        'Xp
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A1 = CSO2: B1 = CO2: P1 = P
        Equlibrim
    Case 2        'W(T)
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A2 = CSO2: B2 = CO2: P2 = P: Cat2 = Cat
        Rate_T
    Case 3        'Topt
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A3 = CSO2: B3 = CO2: P3 = P: Cat3 = Cat
        T_optimum
    Case 4        'tay(X)
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A4 = CSO2: B4 = CO2: P4 = P: Cat4 = Cat: Flow = Flow4
        Bed_Tay_X
    Case 5        'X(tay)
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A5 = CSO2: B5 = CO2: P5 = P: Cat5 = Cat: Flow = Flow5
        Bed_X_Tay
    Case 6        'Реактор с ТО
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A6 = CSO2: B6 = CO2: P6 = P: Cat6 = Cat: Flow = Flow6
        Select Case Flow
        Case "IF": ReactorTO
        Case "FM": ReactorTO_FM
        End Select
    Case 7        'Реактор с ХГ
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A7 = CSO2: B7 = CO2: P7 = P: Cat7 = Cat
        ReactorCG
    Case 8        'Реактор с ХВ
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A8 = CSO20: B8 = CO20: P8 = P: Cat8 = Cat
        ReactorCA
    Case 9        'Реактор второй ступени ДК/ДА
        Inspection
      If Oo = 1 Then Oo = 0: Exit Sub
    A9 = CSO20: B9 = CO20: P9 = P: Cat9 = Cat
        ReactorII_DK
  End Select

 Command5.Visible = True
End Sub

Private Sub Command5_Click()
        'Графики
           'Подготовка графика
  Select Case Variable1
  Case 1, 3, 6, 7, 8, 9  'График Т-Х
    Oo = MsgBox("Обновить график?", vbYesNo + vbExclamation, "График")
    If Oo = "6" Then
      Picture1.Cls
      Label16.Caption = " X 1"
      Label15.Caption = " 700"
      Label18.Caption = "800"
      Label19.Caption = "900 T,K"
      For X1 = 150 To 4150 Step 2000
        X2 = X1: Y1 = 0: Y2 = 100
      Do Until Y2 > 4500
        Picture1.Line (X1, Y1)-(X2, Y2): Y1 = Y2 + 100: Y2 = Y1 + 100
      Loop
      Next X1
    End If
  Case 2      'График W(T)
    Oo = MsgBox("Обновить график?", vbYesNo + vbExclamation, "График")
    If Oo = "6" Then
      Picture2.Cls
      Label16.Caption = "W 1"
      Label15.Caption = "700"
      Label18.Caption = "800"
      Label19.Caption = "900 T,K"
      For X1 = 150 To 4150 Step 2000
        X2 = X1: Y1 = 0: Y2 = 100
      Do Until Y2 > 4500
        Picture2.Line (X1, Y1)-(X2, Y2): Y1 = Y2 + 100: Y2 = Y1 + 100
      Loop
      Next X1
    End If
  Case 4, 5     'График X(tay)
    Oo = MsgBox("Обновить график?", vbYesNo + vbExclamation, "График")
    If Oo = "6" Then
      Picture3.Cls
      Label16.Caption = " X 1"
      Label15.Caption = ""
      Label18.Caption = ""
        Ymax = Taymax * 1.1
      Label19.Caption = Format(Taymax, "0.00" & " Tay")
        X1 = 4500 / 1.1: X2 = X1: Y1 = 0: Y2 = 100
      Do Until Y2 > 4300
        Picture3.Line (X1, Y1)-(X2, Y2): Y1 = Y2 + 100: Y2 = Y1 + 100
      Loop
    End If
  End Select
  
          'Рисуем графики
  Select Case Variable1
  Case 1    'График Хp
    X1 = 150 + 20 * (TXpKp(0, 1) - 700): Y1 = 4290 * (1 - TXpKp(1, 1))
      Picture1.DrawWidth = 2
    For I = 2 To NXp
    X2 = 150 + 20 * (TXpKp(0, I) - 700): Y2 = 4290 * (1 - TXpKp(1, I))
  '   Picture1.Line (X1, Y1)-(X2, Y2), &H00FF&:  X1 = X2: Y1 = Y2
    Picture1.Line (X1, Y1)-(X2, Y2), vbRed:  X1 = X2: Y1 = Y2
    Next I
      Picture1.DrawWidth = 1
  Case 2    'График W(T)
    X1 = 150 + 20 * (WT(0, 1) - 700): Y1 = 4290 * (1 - WT(1, 1))
      Picture2.DrawWidth = 2
    For I = 2 To NW
    X2 = 150 + 20 * (WT(0, I) - 700): Y2 = 4290 * (1 - WT(1, I))
    Picture2.Line (X1, Y1)-(X2, Y2):  X1 = X2: Y1 = Y2
    Next I
      Picture2.DrawWidth = 1
  Case 3    'График Tопт
    X1 = 150 + 20 * (XTopt(1, 1) - 700): Y1 = 4290 * (1 - XTopt(0, 1))
      Picture1.DrawWidth = 2
    For I = 2 To NTopt
    X2 = 150 + 20 * (XTopt(1, I) - 700): Y2 = 4290 * (1 - XTopt(0, I))
    Picture1.Line (X1, Y1)-(X2, Y2), &H80FF&:      X1 = X2: Y1 = Y2
    Next I
      Picture1.DrawWidth = 1
  Case 4    'График X,T-tay для Tay(X)
    X1 = 0: Y1 = 4200 * (1 - TayX(1, 1))
      Picture3.DrawWidth = 2
  Select Case Flow
    Case "FM"
    X1 = 0: Y1 = 4200 * (1 - TayX(1, 1))
    X2 = 0: Y2 = 4200 * (1 - TayX(1, 2))
      Picture3.Line (X1, Y1)-(X2, Y2):  X1 = X2: Y1 = Y2
    X2 = 4500 * TayX(0, 2) / Ymax: Y2 = Y1
      Picture3.Line (X1, Y1)-(X2, Y2)
    X1 = 0: Y1 = 4200 / 200 * (870 - TayX(2, 1))
    X2 = 0: Y2 = 4200 / 200 * (870 - TayX(2, 2))
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed:  X1 = X2: Y1 = Y2
    X2 = 4500 * TayX(0, 2) / Ymax: Y2 = Y1
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed
    Case "IF"
    For I = 2 To NtX
      X2 = 4500 * TayX(0, I) / Ymax: Y2 = 4200 * (1 - TayX(1, I))
      Picture3.Line (X1, Y1)-(X2, Y2):  X1 = X2: Y1 = Y2
    Next I
      X1 = 0: Y1 = 4200 / 200 * (870 - TayX(2, 1))
    For I = 2 To NtX
      X2 = 4500 * TayX(0, I) / Ymax: Y2 = 4200 / 200 * (870 - TayX(2, I))
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed:  X1 = X2: Y1 = Y2
    Next I
  End Select
      Picture3.DrawWidth = 1
  Case 5    'График X,T-tay для X(Tay)
      Picture3.DrawWidth = 2
  Select Case Flow
    Case "FM"
    X1 = 0: Y1 = 4200 * (1 - XTay(1, 1))
    X2 = 0: Y2 = 4200 * (1 - XTay(1, 2))
      Picture3.Line (X1, Y1)-(X2, Y2):  X1 = X2: Y1 = Y2
    X2 = 4500 * XTay(0, 2) / Ymax: Y2 = Y1
      Picture3.Line (X1, Y1)-(X2, Y2)
    X1 = 0: Y1 = 4200 / 200 * (870 - XTay(2, 1))
    X2 = 0: Y2 = 4200 / 200 * (870 - XTay(2, 2))
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed:  X1 = X2: Y1 = Y2
    X2 = 4500 * XTay(0, 2) / Ymax: Y2 = Y1
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed
    Case "IF"
    X1 = 0: Y1 = 5600 * (1 - XTay(1, 1))
    For I = 2 To NXt
      X2 = 4500 * XTay(0, I) / Ymax: Y2 = 4200 * (1 - XTay(1, I))
      Picture3.Line (X1, Y1)-(X2, Y2):  X1 = X2: Y1 = Y2
    Next I
      X1 = 0: Y1 = 4200 / 200 * (870 - XTay(2, 1))
    For I = 2 To NXt
      X2 = 4500 * XTay(0, I) / Ymax: Y2 = 4200 / 200 * (870 - XTay(2, I))
      Picture3.Line (X1, Y1)-(X2, Y2), vbRed:  X1 = X2: Y1 = Y2
    Next I
  End Select
  Case 6    'График T-X для реактора с ТО
    Select Case Flow
    Case "FM"
      Picture1.DrawWidth = 3
      For I = 1 To Ncat6
      X1 = 150 + 20 * (ReactTO(2, I) - 700): Y1 = 4290 * (1 - ReactTO(1, I))
      Picture1.Circle (X1, Y1), 50
      Next I
    Case "IF"
      Picture1.DrawWidth = 2
      X1 = 150 + 20 * (ReactTO(3, 1) - 700): Y1 = 4290 * (1 - ReactTO(1, 1))
      X2 = 150 + 20 * (ReactTO(4, 1) - 700): Y2 = 4290 * (1 - ReactTO(2, 1))
      Picture1.Line (X1, Y1)-(X2, Y2)
    For I = 2 To Ncat6
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactTO(3, I) - 700): Y2 = 4290 * (1 - ReactTO(1, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactTO(4, I) - 700): Y2 = 4290 * (1 - ReactTO(2, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
    Next I
  End Select
  Case 7    'График T-X для реактора с ХГ
      Picture1.DrawWidth = 2
      X1 = 150 + 20 * (ReactCG(3, 1) - 700): Y1 = 4290 * (1 - ReactCG(1, 1))
      X2 = 150 + 20 * (ReactCG(4, 1) - 700): Y2 = 4290 * (1 - ReactCG(2, 1))
      Picture1.Line (X1, Y1)-(X2, Y2)
    For I = 2 To Ncat7
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactCG(3, I) - 700): Y2 = 4290 * (1 - ReactCG(1, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactCG(4, I) - 700): Y2 = 4290 * (1 - ReactCG(2, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
    Next I
      Picture1.DrawWidth = 1
  Case 8    'График T-X для реактора с ХГ
      Picture1.DrawWidth = 2
      X1 = 150 + 20 * (ReactCA(3, 1) - 700): Y1 = 4290 * (1 - ReactCA(1, 1))
      X2 = 150 + 20 * (ReactCA(4, 1) - 700): Y2 = 4290 * (1 - ReactCA(2, 1))
      Picture1.Line (X1, Y1)-(X2, Y2)
    For I = 2 To Ncat8
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactCA(3, I) - 700): Y2 = 4290 * (1 - ReactCA(1, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
      X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactCA(4, I) - 700): Y2 = 4290 * (1 - ReactCA(2, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
    Next I
      Picture1.DrawWidth = 1
  Case 9    'График T-X для реактора II ДК/ДА
      Picture1.DrawWidth = 2
      X1 = 150 + 20 * (ReactII(3, 1) - 700): Y1 = 4290 * (1 - ReactII(1, 1))
    For I = 1 To Ncat9
      X2 = 150 + 20 * (ReactII(4, I) - 700): Y2 = 4290 * (1 - ReactII(2, I))
      Picture1.Line (X1, Y1)-(X2, Y2)
    If I < Ncat9 Then
        X1 = X2: Y1 = Y2
      X2 = 150 + 20 * (ReactII(3, I + 1) - 700)
      Y2 = 4290 * (1 - ReactII(1, I + 1))
      Picture1.Line (X1, Y1)-(X2, Y2)
      X1 = X2: Y1 = Y2
    End If
    Next I
      Picture1.DrawWidth = 1
  End Select
End Sub

Private Sub Command6_Click()
       'Вызов помощи
 Frame8.Left = 0
 Option12.Value = True
End Sub

Private Sub Command7_Click()
       'Выход из помощи
  Frame8.Left = 26000
End Sub

Private Sub Form_Load()
    'Запуск
 Frame1.Left = 120
 Command2.Visible = False
 Combo1.AddItem ("СВД"): Combo1.AddItem ("ИК-4")
 Combo1.AddItem ("'Классический'"): Combo1.AddItem ("Новый")
  Frame8.Left = 26000
  Rgas = 0.00819
  For I = 1 To 9: DataVar(I) = "b": Next I
End Sub

Private Sub Option1_Click()
    'Равновесие
 Variable1 = 1
 Frame2.Height = 1275: OLE1.Top = 0
 Label2.Caption = "Равновесные степени превращения Xр(Т)"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм"
  Text4.Visible = False
 Frame4.Visible = True
 Label4.Visible = False
  Text5.Visible = False: Text7.Visible = False: Text8.Visible = False
 Label5.Visible = True: Label5.Caption = "Tн      Tк"
  Text6.Visible = True: Text22.Visible = True
 Label6.Visible = True:
  Label6.Caption = "                Шаг по Т"
  Text9.Visible = False: Text10.Visible = True
 Label12.Visible = False
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = False: Frame7.Visible = False
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
 Label14.Visible = True
  Label14.Caption = " T, K      Xp     Kp"
 List1.Visible = True: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = False
  If DataVar(1) = "b" Then
    A1 = 0.1: B1 = 0.1: P1 = 1: TH1 = 700: dT1 = 10: TK1 = 900
    DataVar(1) = "c"
  End If
             'Исходные данные
   Text1.Text = Format(A1, "0.0000"): Text2.Text = Format(B1, "0.0000")
   Text3.Text = Format(P1, "0.00")
   Text6.Text = Format(TH1, "000.0"): Text10.Text = Format(dT1, "0.0")
   Text22.Text = Format(TK1, "000.0")
End Sub

Private Sub Option10_Click()
     'ИВ
 Flow = "IF"
  If Variable1 = 6 Then
    Label12.Caption = "Слой   Xiн      Хiк      Tiн      Tiк       Tay"
    Label13.Visible = True: Label13.Caption = "Т1н"
    Text13.Visible = True:
  End If
End Sub

Private Sub Option11_Click()
     'ИC
 Flow = "FM"
  If Variable1 = 6 Then
    Label12.Caption = "Слой   Xi       Ti       Tay"
    Label13.Visible = False: Text13.Visible = False:
  End If
End Sub

 Private Sub Option12_Click()
          'Help-00
   OLE2.Visible = True: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = -3400
   VarHelp = 0: VScroll1_Change
 End Sub
 
 Private Sub Option13_Click()
          'Help-01
   OLE2.Visible = False: OLE4.Visible = True: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   
   VScroll1.Value = 0
   VScroll1.Max = -4100
   VarHelp = 1: VScroll1_Change
 End Sub
 
 Private Sub Option14_Click()
          'Help-02
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = True
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = -9700
   VarHelp = 2: VScroll1_Change
 End Sub
 
 Private Sub Option15_Click()
          'Help-03
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = True: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = 0
   VarHelp = 3: VScroll1_Change
 End Sub
 
 Private Sub Option16_Click()
          'Help-04
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = True: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = -4600
   VarHelp = 4: VScroll1_Change
 End Sub
 
 Private Sub Option17_Click()
          'Help-05
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = True
   OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = -3000
   VarHelp = 5: VScroll1_Change
 End Sub
 
 Private Sub Option18_Click()
          'Help-06
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = True: OLE10.Visible = False: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   VScroll1.Value = 0
   VScroll1.Max = -7000
   VarHelp = 6: VScroll1_Change
 End Sub
 
 Private Sub Option19_Click()
          'Help-07
   OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
   OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
   OLE9.Visible = False: OLE10.Visible = True: OLE11.Visible = False
   OLE12.Visible = False: OLE13.Visible = False
   
   VScroll1.Value = 0
   VScroll1.Max = -8300
   VarHelp = 7: VScroll1_Change
 End Sub

Private Sub Option2_Click()
      'Скорость реакции
 Variable1 = 2
 Frame2.Height = 1450: OLE1.Top = -1250
 Label2.Caption = "Скорость реакции W(T) при степени превращения х"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм"
  Text4.Visible = False
 Frame4.Visible = True
 Label4.Visible = True: Label4.Caption = "  Х"
  Text5.Visible = True: Text7.Visible = False: Text8.Visible = False
 Label5.Visible = True: Label5.Caption = "Tн      Tк"
  Text6.Visible = True: Text22.Visible = True
 Label6.Visible = True:
  Label6.Caption = "                Шаг по Т"
  Text9.Visible = False: Text10.Visible = True
 Label12.Visible = False
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = True: Frame7.Visible = False
 Picture1.Visible = False: Picture2.Visible = True: Picture3.Visible = False
 Label14.Visible = True
  Label14.Caption = "T, K      W"
 List1.Visible = False: List2.Visible = True: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = False
 
   If DataVar(2) = "b" Then
     A2 = 0.1: B2 = 0.1: P2 = 1: XH2 = 0.7
     TH2 = 700: dT2 = 10: TK2 = 900: ' Cat2 = 1
    DataVar(2) = "c"
   End If

             'Исхолные данные
 Text1.Text = Format(A2, "0.0000"): Text2.Text = Format(B2, "0.0000")
 Text3.Text = Format(P2, "0.00"): Text5.Text = Format(XH2, "0.0000")
 Text6.Text = Format(TH2, "000.0"): Text10.Text = Format(dT2, "0.0")
 Text22.Text = Format(TK2, "000.0"): Cat = Cat2
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
End Sub

Private Sub Option20_Click()
         'Help-08
  OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
  OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
  OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = True
  OLE12.Visible = False: OLE13.Visible = False
  VScroll1.Value = 0
  VScroll1.Max = -8300
  VarHelp = 8: VScroll1_Change
End Sub

Private Sub Option21_Click()
         'Help-09
  OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
  OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
  OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
  OLE12.Visible = True: OLE13.Visible = False
  VScroll1.Value = 0
  VScroll1.Max = -7900
  VarHelp = 9: VScroll1_Change
End Sub

Private Sub Option22_Click()
         'Help-10
  OLE2.Visible = False: OLE4.Visible = False: OLE5.Visible = False
  OLE6.Visible = False: OLE7.Visible = False: OLE8.Visible = False
  OLE9.Visible = False: OLE10.Visible = False: OLE11.Visible = False
  OLE12.Visible = False: OLE13.Visible = True
  VScroll1.Value = 0
  VScroll1.Max = -7900
  VarHelp = 10: VScroll1_Change
End Sub

Private Sub Option3_Click()
     'T_opt
 Variable1 = 3
 Frame2.Height = 1450: OLE1.Top = -2750
 Label2.Caption = "Оптимальные температуры Топт(х)"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм"
  Text4.Visible = False
 Frame4.Visible = True
 Label4.Visible = True: Label4.Caption = " Хн          Xк"
  Text5.Visible = True: Text7.Visible = True: Text8.Visible = False
 Label5.Visible = False ': Label5.Caption = "Tн      Tк"
  Text6.Visible = False: Text22.Visible = False
 Label6.Visible = True:
  Label6.Caption = "Шаг по Х"
  Text9.Visible = True: Text10.Visible = False
 Label12.Visible = False
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = True: Frame7.Visible = False
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
 Label14.Visible = True
  Label14.Caption = "   X      Topt     W"
 List1.Visible = False: List2.Visible = False: List3.Visible = True
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = False
   If DataVar(3) = "b" Then
     A3 = 0.1: B3 = 0.1: P3 = 1
     XH3 = 0.5: XK3 = 0.99: dX3 = 0.01: 'Cat3 = 2
    DataVar(3) = "c"
   End If
 
             'Исхолные данные
 Text1.Text = Format(A3, "0.0000"): Text2.Text = Format(B3, "0.0000")
 Text3.Text = Format(P3, "0.00"): Text5.Text = Format(XH3, "0.000")
 Text7.Text = Format(XK3, "0.000"): Text9.Text = Format(dX3, "0.000")
 Cat = Cat3
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
End Sub

Private Sub Option4_Click()
       'Tay(x)
 Variable1 = 4
 Frame2.Height = 1690: OLE1.Top = -4250
 Label2.Caption = "Время контакта в слое tay(х) (режимы идеального вытеснения и смешения)"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = True
 Label4.Visible = True: Label4.Caption = " Хн          Xк"
  Text5.Visible = True: Text7.Visible = True: Text8.Visible = False
 Label5.Visible = True: Label5.Caption = "Tн"
  Text6.Visible = True: Text22.Visible = False
 Label6.Visible = False:
  Text9.Visible = False: Text10.Visible = False
 Label12.Visible = False
 Frame5.Visible = True: Label23.Visible = True
 Frame6.Visible = True: Frame7.Visible = False
 Picture1.Visible = False: Picture2.Visible = False: Picture3.Visible = True
 Label14.Visible = True
  Label14.Caption = " Tau      X      T"
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = True: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = False
   If DataVar(4) = "b" Then
     A4 = 0.1: B4 = 0.1: P4 = 1: Tad4 = 200
     XH4 = 0: XK4 = 0.6: TH4 = 720: Flow4 = "IF"
    DataVar(4) = "c"
   End If
             'Исхолные данные
 Text1.Text = Format(A4, "0.0000"): Text2.Text = Format(B4, "0.0000")
 Text3.Text = Format(P4, "0.00"): Text4.Text = Format(Tad4, "0.0")
 Text5.Text = Format(XH4, "0.000"): Text7.Text = Format(XK4, "0.000")
 Text6.Text = Format(TH4, "000.0"): Flow = Flow4: Cat = Cat4
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
  If Flow4 = "IF" Then Option10.Value = True Else Option10.Value = False
  If Flow4 = "FM" Then Option11.Value = True Else Option11.Value = False
       'X(tay)
 Variable1 = 5
 Frame2.Height = 1690: OLE1.Top = -6000
 Label2.Caption = "Степень превращения в слое Х(tay) (режимы идеального вытеснения и смешения)"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = True
 Label4.Visible = True: Label4.Caption = " Хн                     Tay"
  Text5.Visible = True: Text7.Visible = False: Text8.Visible = True
 Label5.Visible = True: Label5.Caption = "Tн"
  Text6.Visible = True: Text22.Visible = False
 Label6.Visible = False:
  Text9.Visible = False: Text10.Visible = False
 Label12.Visible = False
 Frame5.Visible = True: Label23.Visible = True
 Frame6.Visible = True: Frame7.Visible = False
 Picture1.Visible = False: Picture2.Visible = False: Picture3.Visible = True
 Label14.Visible = True
  Label14.Caption = " Tau      X      T"
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = True
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = False
   If DataVar(5) = "b" Then
     A5 = 0.1: B5 = 0.1: P5 = 1: Tad5 = 200
     XH5 = 0: TH5 = 720: TayK5 = 0.6: Flow5 = "IF"
    DataVar(5) = "c"
   End If
             'Исхолные данные
 Text1.Text = Format(A5, "0.0000"): Text2.Text = Format(B5, "0.0000")
 Text3.Text = Format(P5, "0.00"): Text4.Text = Format(Tad5, "0.0")
 Text5.Text = Format(XH5, "0.000"): Text8.Text = Format(TayK5, "0.000")
 Text6.Text = Format(TH5, "000.0"): Flow = Flow5: Cat = Cat5
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
  If Flow5 = "IF" Then Option10.Value = True Else Option10.Value = False
  If Flow5 = "FM" Then Option11.Value = True Else Option11.Value = False
End Sub

Private Sub Option6_Click()
     'Реактор с Т.О.
  Variable1 = 6
 Frame2.Height = 1590: OLE1.Top = -7850
 OLE3.Top = 100
 Label2.Caption = "Оптимизация многослойного реактора с промежуточными теплообменниками "
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = False
 Label12.Visible = True
 Label14.Visible = False: Text14.Visible = False
 Frame5.Visible = True: Label23.Visible = True
 Frame6.Visible = True: Frame7.Visible = True
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = True: List7.Visible = False
 List8.Visible = False: List9.Visible = False
   If DataVar(6) = "b" Then
     A6 = 0.075: B6 = 0.11: P6 = 1: Tad6 = 214: Ncat6 = 4
     XH6 = 0: TH6 = 713: XK6 = 0.97: Flow6 = "FM": Cat6 = 1
    DataVar(6) = "c"
   End If
             'Исхолные данные
 Text1.Text = Format(A6, "0.0000"): Text2.Text = Format(B6, "0.0000")
 Text3.Text = Format(P6, "0.00"): Text4.Text = Format(Tad6, "0.0")
 Text12.Text = Format(XH6, "0.000"): Text13.Text = Format(TH6, "000.0")
 Text23.Text = Format(XK6, "0.000"): Text11.Text = Format(Ncat6, "0")
   Flow = Flow6: Cat = Cat6
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
  If Flow6 = "IF" Then Option10.Value = True Else Option10.Value = False
  If Flow6 = "FM" Then Option11.Value = True Else Option11.Value = False
End Sub

Private Sub Option7_Click()
      'Реактор с Х.Г.
  Variable1 = 7
 Frame2.Height = 1590: OLE1.Top = -9500
 OLE3.Top = -1750
 Label2.Caption = "Оптимизация многослойного реактора с вводом холодного газа после 1-го слоя "
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = False
 Label12.Visible = True
  Label12.Caption = "Слой   Xiн      Хiк      Tiн      Tiк       Tay     Vгаз"
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = True: Frame7.Visible = True:
  Label13.Visible = True: Label13.Caption = "Т1н       Тхг":
  Text13.Visible = True: Text14.Visible = True
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
 Label14.Visible = False
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = True
 List8.Visible = False: List9.Visible = False
   If DataVar(7) = "b" Then
     A7 = 0.075: B7 = 0.11: P7 = 1: Tad7 = 214: Ncat7 = 5
     XH7 = 0: TH7 = 713: XK7 = 0.97: Tcg7 = 490: Cat7 = 1
    DataVar(7) = "c"
   End If

             'Исхолные данные
 Text1.Text = Format(A7, "0.0000"): Text2.Text = Format(B7, "0.0000")
 Text3.Text = Format(P7, "0.00"): Text4.Text = Format(Tad7, "0.0")
 Text11.Text = Format(Ncat7, "0"): Text12.Text = Format(XH7, "0.000")
 Text13.Text = Format(TH7, "000.0"): Text14.Text = Format(Tcg7, "000.0")
 Text23.Text = Format(XK7, "0.000"): Cat = Cat7
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
End Sub

Private Sub Option8_Click()
     'Реактор с Х.В.
  Variable1 = 8
 Frame2.Height = 1800: OLE1.Top = -11100
 OLE3.Top = -3650
 Label2.Caption = "Оптимизация многослойного реактора с вводом холодного воздуха между слоями катализатора "
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = False
 Label12.Visible = True:   Label12.Caption = "Слой   Xiн      Хiк     Tiн      Tiк       Tay      Vгаз"
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = True: Frame7.Visible = True:
  Label13.Visible = True: Label13.Caption = "Т1н       Тхв":
  Text13.Visible = True: Text14.Visible = True
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
  Label14.Visible = False
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = True: List9.Visible = False
   If DataVar(8) = "b" Then
     A8 = 0.085: B8 = 0.11: P8 = 1: Tad8 = 243: Ncat8 = 4
     XH8 = 0: TH8 = 693: XK8 = 0.97: Tca8 = 490: Cat8 = 2
    DataVar(8) = "c"
   End If
             'Исхолные данные
 Text1.Text = Format(A8, "0.0000"): Text2.Text = Format(B8, "0.0000")
 Text3.Text = Format(P8, "0.00"): Text4.Text = Format(Tad8, "0.0")
 Text11.Text = Format(Ncat8, "0"): Text12.Text = Format(XH8, "0.000")
 Text13.Text = Format(TH8, "000.0"): Text14.Text = Format(Tca8, "000.0")
 Text23.Text = Format(XK8, "0.000"): Cat = Cat8
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
End Sub

Private Sub Option9_Click()
    'Вторая ступень в системе ДК/ДА"
  Variable1 = 9
 Frame2.Height = 2800: OLE1.Top = -13000
 OLE3.Top = -5500
 Label2.Caption = "Оптимизация второй ступени в системе ДК/ДА"
 Label3.Caption = "Об.доли       SO2         O2                 P,атм                    Тад"
  Text4.Visible = True
 Frame4.Visible = False
 Label12.Visible = True:
  Label12.Caption = "Слой   Xiн      Хiк      Tiн      Tiк      Tay"
 Frame5.Visible = False: Label23.Visible = False
 Frame6.Visible = True: Frame7.Visible = True:
  Label13.Visible = False
  Text13.Visible = False: Text14.Visible = False
 Picture1.Visible = True: Picture2.Visible = False: Picture3.Visible = False
  Label14.Visible = False
 List1.Visible = False: List2.Visible = False: List3.Visible = False
 List4.Visible = False: List5.Visible = False
 List6.Visible = False: List7.Visible = False
 List8.Visible = False: List9.Visible = True
   If DataVar(9) = "b" Then
     A9 = 0.015: B9 = 0.06: P9 = 1: Tad9 = 43: Ncat9 = 2
     XH9 = 0:  XK9 = 0.9: Cat9 = 2
    DataVar(9) = "c"
   End If
             'Исхолные данные
 Text1.Text = Format(A9, "0.0000"): Text2.Text = Format(B9, "0.0000")
 Text3.Text = Format(P9, "0.00"): Text4.Text = Format(Tad9, "0.0")
 Text12.Text = Format(XH9, "0.000"): Text23.Text = Format(XK9, "0.000")
 Text11.Text = Format(Ncat9, "0"): Cat = Cat9
   Catalyst
 Combo1.Text = Combo1.List(Cat - 1)
End Sub

Public Sub Catalyst()
         'Запись параметров катализатора
 Select Case Cat
  Case 1
 Text15.Text = "753": Text16.Text = "1,35"
 Text17.Text = "176,7": Text18.Text = "58,6": Text19.Text = "0"
 Text20.Text = "713": Text21.Text = "803"
 Text15.Locked = True: Text16.Locked = True
 Text17.Locked = True: Text18.Locked = True: Text19.Locked = True
 Text20.Locked = True: Text21.Locked = True
  Case 2
 Text15.Text = "753": Text16.Text = "1,45"
 Text17.Text = "126,4": Text18.Text = "55,2": Text19.Text = "0"
 Text20.Text = "693": Text21.Text = "803"
 Text15.Locked = True: Text16.Locked = True
 Text17.Locked = True: Text18.Locked = True: Text19.Locked = True
 Text20.Locked = True: Text21.Locked = True
  Case 3
 Text15.Text = "753": Text16.Text = "1,45"
 Text17.Text = "58,6": Text18.Text = "58,6": Text19.Text = "58,6"
 Text20.Text = "300": Text21.Text = "1100"
 Text15.Locked = True: Text16.Locked = True
 Text17.Locked = True: Text18.Locked = True: Text19.Locked = True
 Text20.Locked = True: Text21.Locked = True
  Case 4
 Text15.Text = CatDatN(Variable1, 0): Text15.Locked = False
 Text16.Text = CatDatN(Variable1, 1): Text16.Locked = False
 Text17.Text = CatDatN(Variable1, 2): Text17.Locked = False
 Text18.Text = CatDatN(Variable1, 3): Text18.Locked = False
 Text19.Text = CatDatN(Variable1, 4): Text19.Locked = False
 Text20.Text = CatDatN(Variable1, 5): Text20.Locked = False
 Text21.Text = CatDatN(Variable1, 6): Text21.Locked = False
End Select
End Sub

Public Sub Inspection()
      'Контроль всех данных
         'Проверка ввода данных реакц. смеси
 If IsNumeric(Text1.Text) Then CSO2 = CSng(Text1.Text) Else GoTo 999
     CSO20 = CSO2
 If IsNumeric(Text2.Text) Then CO2 = CSng(Text2.Text) Else GoTo 999
     CO20 = CO2
 If IsNumeric(Text3.Text) Then P = CSng(Text3.Text) Else GoTo 999
 If Variable1 > 1 And Cat = 0 Then
  Oo = MsgBox("Реакция без катализатора?", vbOKOnly, "Катализатор")
  Exit Sub
 End If
         'Корректность данных
 If CSO2 <= 0 Or CSO2 >= 1 Or CO2 <= 0 Or CO2 >= 1 Or P <= 0 Then GoTo 998
         'Параметры кат-ра
  If Variable1 > 1 Then
   If Cat = 4 Then    'Проверка для нового кат-ра
    If IsNumeric(Text15.Text) Then CatDatN(Variable1, 0) = Text15.Text Else GoTo 999
    If IsNumeric(Text16.Text) Then CatDatN(Variable1, 1) = Text16.Text Else GoTo 999
    If IsNumeric(Text17.Text) Then CatDatN(Variable1, 2) = Text17.Text Else GoTo 999
    If IsNumeric(Text18.Text) Then CatDatN(Variable1, 3) = Text18.Text Else GoTo 999
    If IsNumeric(Text19.Text) Then CatDatN(Variable1, 4) = Text19.Text Else GoTo 999
    If IsNumeric(Text20.Text) Then CatDatN(Variable1, 5) = Text20.Text Else GoTo 999
    If IsNumeric(Text21.Text) Then CatDatN(Variable1, 6) = Text21.Text Else GoTo 999
   End If
    Tz = CSng(Text15.Text): Kz = CSng(Text16.Text)
    E1 = CSng(Text17.Text): E2 = CSng(Text18.Text)
    E3 = CSng(Text19.Text): T12 = CSng(Text20.Text)
    T23 = CSng(Text21.Text)
    K12 = Kz * Exp(E2 / Rgas * (1 / Tz - 1 / T12))
    K23 = Kz * Exp(E2 / Rgas * (1 / Tz - 1 / T23))
  End If
         'Проверка выбора режима потока
  Select Case Variable1
   Case 4, 5, 6
    If Flow = "" Then
     Oo = MsgBox("Режим движения потока???", vbOKOnly, "Внимание !"): Exit Sub
    End If
  End Select
         'Проверка данных по вариантам
  Select Case Variable1
    Case 1        'Xp
    If IsNumeric(Text6.Text) Then TH1 = CSng(Text6.Text) Else: GoTo 999
    If IsNumeric(Text10.Text) Then dT1 = CSng(Text10.Text) Else: GoTo 999
    If IsNumeric(Text22.Text) Then TK1 = CSng(Text22.Text) Else: GoTo 999
    If TK1 <= TH1 Or dT1 <= 0 Then GoTo 998
    Case 2        'W(T)
    If IsNumeric(Text5.Text) Then XH2 = CSng(Text5.Text) Else: GoTo 999
    If IsNumeric(Text6.Text) Then TH2 = CSng(Text6.Text) Else: GoTo 999
    If IsNumeric(Text10.Text) Then dT2 = CSng(Text10.Text) Else: GoTo 999
    If IsNumeric(Text22.Text) Then TK2 = CSng(Text22.Text) Else: GoTo 999
    If TK2 <= TH2 Or dT2 <= 0 Then GoTo 998
    If XH2 <= 0 Or XH2 >= 1 Then GoTo 997
    Case 3        'Topt
    If IsNumeric(Text5.Text) Then XH3 = CSng(Text5.Text) Else: GoTo 999
    If IsNumeric(Text7.Text) Then XK3 = CSng(Text7.Text) Else: GoTo 999
    If IsNumeric(Text9.Text) Then dX3 = CSng(Text9.Text) Else: GoTo 999
    If XK3 <= XH3 Or dX3 <= 0 Then GoTo 998
    If XH3 <= 0 Or XH3 >= 1 Or XK3 <= 0 Or XK3 >= 1 Then GoTo 997
    Case 4        'X(tay)
    If IsNumeric(Text4.Text) Then Tad4 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text5.Text) Then XH4 = CSng(Text5.Text) Else: GoTo 999
    If IsNumeric(Text6.Text) Then TH4 = CSng(Text6.Text) Else: GoTo 999
    If IsNumeric(Text7.Text) Then XK4 = CSng(Text7.Text) Else: GoTo 999
    If XH4 < 0 Or XH4 >= 1 Then GoTo 997
    If XK4 < 0 Or XK4 >= 1 Then GoTo 997
    If XK4 <= XH4 Then GoTo 998
      X = XH4: T = TH4: Reaction
    If W <= 0 Then GoTo 996
      X = XK4: T = TH4 + Tad4 * (XK4 - XH4): Reaction
    If W <= 0 Then GoTo 996
      Flow4 = Flow
    Case 5        'tay(X)
    If IsNumeric(Text4.Text) Then Tad5 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text5.Text) Then XH5 = CSng(Text5.Text) Else: GoTo 999
    If IsNumeric(Text6.Text) Then TH5 = CSng(Text6.Text) Else: GoTo 999
    If IsNumeric(Text8.Text) Then TayK5 = CSng(Text8.Text) Else: GoTo 999
    If XH5 < 0 Or XH5 >= 1 Then GoTo 997
      X = XH5: T = TH5: Reaction
    If W <= 0 Then GoTo 996
    If Flow = "IF" Then
      X = XH5: T = TH5 + Tad5 / 3: Reaction
        If W * TayK5 / 100 > 0.05 Then
      Oo = MsgBox("О-о-очень большой градиент!", vbOKOnly, "Время контакта...")
      Exit Sub
        End If
    End If
      Flow5 = Flow
    Case 6        'Реактор с ТО
    If IsNumeric(Text4.Text) Then Tad6 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text11.Text) Then Ncat6 = CSng(Text11.Text) Else: GoTo 999
    If IsNumeric(Text12.Text) Then XH6 = CSng(Text12.Text) Else: GoTo 999
      If Flow = "IF" Then
    If IsNumeric(Text13.Text) Then TH6 = CSng(Text13.Text) Else: GoTo 999
      End If
    If IsNumeric(Text23.Text) Then XK6 = CSng(Text23.Text) Else: GoTo 999
    If XH6 < 0 Or XH6 >= 1 Or XK6 >= 1 Then GoTo 997
    If XK6 <= XH6 Then GoTo 998
    Select Case Flow
      Case "IF"
      If Ncat6 < 2 Or Ncat6 > 6 Or TH6 < 670 Or TH6 > 770 Then GoTo 997
      Case "FM"
      If Ncat6 < 2 Or Ncat6 > 6 Then GoTo 997
    End Select
      Flow6 = Flow
    Case 7        'Реактор с ХГ
    If IsNumeric(Text4.Text) Then Tad7 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text11.Text) Then Ncat7 = CSng(Text11.Text) Else: GoTo 999
    If IsNumeric(Text12.Text) Then XH7 = CSng(Text12.Text) Else: GoTo 999
    If IsNumeric(Text13.Text) Then TH7 = CSng(Text13.Text) Else: GoTo 999
    If IsNumeric(Text14.Text) Then Tcg7 = CSng(Text14.Text) Else: GoTo 999
    If IsNumeric(Text23.Text) Then XK7 = CSng(Text23.Text) Else: GoTo 999
    If XH7 < 0 Or XH7 >= 1 Or XK7 >= 1 Then GoTo 997
    If Ncat7 < 2 Or Ncat7 > 6 Or TH7 < 670 Or TH7 > 770 Then GoTo 997
    If Tcg7 < 350 Or Tcg7 > 670 Then GoTo 997
    If XK7 <= XH7 Then GoTo 998
    
    Case 8        'Реактор с ХВ
    If IsNumeric(Text4.Text) Then Tad8 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text11.Text) Then Ncat8 = CSng(Text11.Text) Else: GoTo 999
    If IsNumeric(Text12.Text) Then XH8 = CSng(Text12.Text) Else: GoTo 999
    If IsNumeric(Text13.Text) Then TH8 = CSng(Text13.Text) Else: GoTo 999
    If IsNumeric(Text14.Text) Then Tca8 = CSng(Text14.Text) Else: GoTo 999
    If IsNumeric(Text23.Text) Then XK8 = CSng(Text23.Text) Else: GoTo 999
    If XH8 < 0 Or XH8 >= 1 Or XK8 >= 1 Then GoTo 997
    If Ncat8 < 2 Or Ncat8 > 6 Or TH8 < 670 Or TH8 > 770 Then GoTo 997
    If Tca8 < 350 Or Tca8 > 670 Then GoTo 997
    If XK8 <= XH8 Then GoTo 998
    
    Case 9        'Реактор второй ступени ДК/ДА
    If IsNumeric(Text4.Text) Then Tad9 = CSng(Text4.Text) Else: GoTo 999
    If IsNumeric(Text11.Text) Then Ncat9 = CSng(Text11.Text) Else: GoTo 999
    If IsNumeric(Text12.Text) Then XH9 = CSng(Text12.Text) Else: GoTo 999
    If IsNumeric(Text23.Text) Then XK9 = CSng(Text23.Text) Else: GoTo 999
    If XH9 < 0 Or XH9 >= 1 Or XK9 >= 1 Then GoTo 997
    If XK9 <= XH9 Then GoTo 998
    If Ncat9 < 1 Or Ncat9 > 3 Then GoTo 997
  End Select
                      Exit Sub
      
  996 Oo = MsgBox("Х > Хравн ?!?", vbOKOnly, "Степень превращения")
      Exit Sub
  997 Oo = MsgBox("Данные вне допустимого интервала!", vbOKOnly, "Ошибка ввода данных!")
      Exit Sub
  998 Oo = MsgBox("Проверьте корректность данных!", vbOKOnly, "Ошибка ввода данных!")
      Exit Sub
  999 Oo = MsgBox("Вводите цифры! Десятичное число через запятую! Пример: 12,3!", vbOKOnly, "Ошибка записи числа!")
End Sub

Public Sub Reaction()
         'Скорость реакции W
  Kp = 10 ^ (4905 / T - 4.6455)
 If T > T23 Then
  Kr = K23 * Exp(E3 / Rgas * (1 / T23 - 1 / T)): EI = E3 / Rgas
 Else
  If T > T12 Then
   Kr = Kz * Exp(E2 / Rgas * (1 / Tz - 1 / T)): EI = E2 / Rgas
  Else
   Kr = K12 * Exp(E1 / Rgas * (1 / T12 - 1 / T)): EI = E1 / Rgas
  End If
 End If
   FU = (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X) * P
   FI = (X / (1 - X) / Kp) ^ 2
  W = Kr / CSO20 * (1 - X) / (1 - 0.2 * X) * (FU - FI)
End Sub

Public Sub Reaction_T()
         'df/dT и cкорость реакции W
 Reaction
  If W = 0 Then F = 100000000# Else F = 1 / W
  FT = (2 * Log(10) * 4905 * FI / (FU - FI) - EI) / W / T / T
End Sub

Public Sub Reaction_T_V()
         'dF/dV, df/dT и cкорость реакции W
 Reaction_T
  FV = (FU - 0.21 * P) / W / (FU - FI) / (1 - 0.5 * CSO2 * X)
  F12ca = FT * (T - Tca8) - FV
End Sub

Public Sub Equlibrim()
    'Равновесие Хр
 List1.Clear
  T = TH1: NXp = 0
  Do Until T > TK1
    NXp = NXp + 1: AA = ""
  Kp = 10 ^ (4905 / T - 4.6455)
    XD = 0: XU = 1
    If CSO2 / CO2 / 2 > 1 Then XU = CSO2 / CO2 / 2
  60 X = (XU + XD) / 2
    If Abs(XU - XD) > 0.00005 Then
      FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
      FI = (X / (1 - X) / Kp) ^ 2:
      If FU < FI Then XU = X Else XD = X
      GoTo 60
    End If
      TXpKp(0, NXp) = T: TXpKp(1, NXp) = X: TXpKp(2, NXp) = Kp
      AA = AA & Format(T, "000.0") & "   " & Format(X, "0.0000")
      AA = AA & "   " & Format(Kp, "0.00")
    List1.AddItem (AA)
    T = T + dT1
  Loop
End Sub

Public Sub Rate_T()
     'Скорость реакции W(T)
 List2.Clear
  X = XH2: T = TH2: NW = 0
  Do Until T > TK2
    NW = NW + 1
      Reaction
    WT(0, NW) = T: WT(1, NW) = W
    List2.AddItem (Format(T, "000.0") & "   " & Format(W, "0.0000"))
      If W < 0 Then Exit Sub
    T = T + dT2
  Loop
End Sub

Public Sub T_optimum()
     'Оптимальные температуры Topt
 List3.Clear
  X = XH3: NTopt = 0
  Xa = 2 * Log(10) * 4905: Xb = 2 * Log(10) * 4.6455
  Do Until X > XK3
    NTopt = NTopt + 1: AA = ""
      FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
      FI = (X / (1 - X)) ^ 2
        T = Xa / (Xb + Log((Xa / E1 * Rgas + 1) * FI / FU))
      If T < T12 Then GoTo 911
        T = Xa / (Xb + Log((Xa / E2 * Rgas + 1) * FI / FU))
      If T < T12 Then T = T12: GoTo 911
      If T < T23 Then GoTo 911
      If E3 = 0 Then T = T23: GoTo 911
        T = Xa / (Xb + Log((Xa / E3 * Rgas + 1) * FI / FU))
      If T < T23 Then T = T23
  911 Reaction
      XTopt(0, NTopt) = X: XTopt(1, NTopt) = T: XTopt(2, NTopt) = W
      AA = AA & Format(X, "0.0000") & "   " & Format(T, "000.00")
      AA = AA & "   " & Format(W, "0.000")
    List3.AddItem (AA)
    X = X + dX3
  Loop
End Sub

Public Sub Bed_Tay_X()
     'Время контакта при заданном Х
 List4.Clear
   X = XH4:  T = TH4: Tay = 0: NtX = 1
   TayX(0, NtX) = Tay: TayX(1, NtX) = X: TayX(2, NtX) = T
      Reaction
     AA = "":
    AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
    AA = AA & "   " & Format(T, "000.0")
    List4.AddItem (AA)
 Select Case Flow      'ИС
  Case "FM"
   X = XK4: T = TH4 + Tad4 * (XK4 - XH4): Reaction
   Tay = (XK4 - XH4) / W
   NtX = NtX + 1
   TayX(0, NtX) = Tay: TayX(1, NtX) = X: TayX(2, NtX) = T
      AA = ""
   AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
    AA = AA & "   " & Format(T, "000.0")
    List4.AddItem (AA)
  Case "IF"    'ИВ
    diX = (XK4 - XH4) / 50
    X = XH4: T = TH4: Reaction
   For I = 1 To 10
    For J = 1 To 5
     F = 1 / W
      X = X + diX / 2: T = TH4 + Tad4 * (X - XH4): Reaction
     F = F + 4 / W
      X = X + diX / 2: T = TH4 + Tad4 * (X - XH4): Reaction
     Tay = Tay + (F + 1 / W) * diX / 6
     NtX = NtX + 1
     TayX(0, NtX) = Tay: TayX(1, NtX) = X: TayX(2, NtX) = T
    Next J
       AA = ""
     AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
     AA = AA & "   " & Format(T, "000.0")
     List4.AddItem (AA)
   Next I
  End Select
  Taymax = Tay
End Sub

Public Sub Bed_X_Tay()
     'Степень превращения при заданном tay
 List5.Clear
   XTay(0, 1) = 0: XTay(1, 1) = XH5: XTay(2, 1) = TH5
     AA = "":
    AA = AA & "0.000" & "   " & Format(XH5, "0.0000")
    AA = AA & "   " & Format(TH5, "000.0")
    List5.AddItem (AA)
 Select Case Flow      'ИС
  Case "FM"
     XD = XH5: XU = 1
   Do
    X = (XU + XD) / 2: T = TH5 + Tad5 * X: Reaction
    If TayK5 * W + XH5 - X > 0 Then XD = X Else XU = X
   Loop Until Abs(XU - XD) < 0.0001
   XTay(0, 2) = TayK5: XTay(1, 2) = X: XTay(2, 2) = T
      AA = ""
   AA = AA & Format(TayK5, "0.000") & "   " & Format(X, "0.0000")
    AA = AA & "   " & Format(T, "000.0")
    List5.AddItem (AA)
  Case "IF"    'ИВ
    dTay = TayK5 / 100: Tay = 0: NXt = 0
    X = XH5: T = TH5: Reaction
   For I = 1 To 10
    For J = 1 To 10
     W1 = W: X1 = X
     X = X + W * dTay: T = TH5 + Tad5 * X: Reaction
     X = X1 + (W + W1) / 2 * dTay
     Tay = Tay + dTay
     NXt = NXt + 1
     XTay(0, NXt) = Tay: XTay(1, NXt) = X: XTay(2, NXt) = T
    Next J
       AA = ""
     AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
     AA = AA & "   " & Format(T, "000.0")
     List5.AddItem (AA)
   Next I
  End Select
  Taymax = TayK5
End Sub

Public Sub ReactorTO()
         'Реактор с ТО
       'Определение макс. х1н
    XD = 0
  If 2 * CSO2 / CO2 < 1 Then XU = 2 * CSO2 / CO2 Else XU = 1
   W1 = -1: W2 = 1
  Do Until Abs(XU - XD) < 0.00005
    X = (XU + XD) / 2: T = TH6 + Tad6 * (X - XH6)
    Reaction
    If W < 0 Then XU = X: W1 = W Else XD = X: W2 = W
      Loop
    X = XD + (XU - XD) * W1 / (W2 - W1)
      ReactTO(0, 1) = 1: ReactTO(1, 1) = XH6: ReactTO(3, 1) = TH6
          'Условия в конце 1-го слоя
      X1D = X: DX0 = -0.02
  250 List6.Clear
      X1D = X1D + DX0: X = X1D: T = TH6 + Tad6 * (X - XH6)
        Reaction_T
      If FT <= 0 Or W <= 0 Then DX0 = DX0 / 2: GoTo 250
          'Расчет 1-го слоя
    diX = (X1D - XH6) / 50: X = XH6: T = TH6: Tay = 0
        Reaction
        F = 1 / W: DXS = diX / 6
  For I = 1 To 50
    Tay = Tay + DXS / W: X = X + diX / 2: T = TH6 + Tad6 * (X - XH6)
        Reaction
    Tay = Tay + 4 * DXS / W: X = X + diX / 2: T = TH6 + Tad6 * (X - XH6)
        Reaction
    Tay = Tay + DXS / W
  Next I
      ReactTO(2, 1) = X: ReactTO(4, 1) = T: ReactTO(5, 1) = Tay
    AA = "    1" & "      " & Format(ReactTO(1, 1), "0.000") & "     " _
    & Format(X, "0.000") & "     " & Format(ReactTO(3, 1), "000.0") _
    & "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000")
      List6.AddItem (AA)
          'Расчет всех слоев
  For J = 2 To Ncat6
            'Определение Tiн опт
    XiH = ReactTO(2, J - 1): TiK = ReactTO(4, J - 1)
    X = XiH: T = TiK: Reaction: WiK = W
    dTiH = -20: T = T - 0.001
  Do Until Abs(dTiH) < 0.01
    T = T + dTiH: Reaction
    If Sgn(W - WiK) * Sgn(dTiH) > 0 Then dTiH = -dTiH / 2
  Loop
    ReactTO(0, J) = J: ReactTO(1, J) = X: ReactTO(3, J) = T
          'Определение Хiк опт
    XiH = X: TiH = T: diX = (1 - X) / 50: Tay = 0: SFT = 0
    diX = (1 - X) / 100: DXS = diX / 6
        Reaction_T
  Do Until SFT > 0
        Tay1 = Tay: SFT1 = SFT
      Tay = Tay + DXS / W: SFT = SFT + DXS * FT
      X = X + diX / 2: T = TiH + Tad6 * (X - XiH)
        Reaction_T
      Tay = Tay + 4 * DXS / W: SFT = SFT + 4 * DXS * FT
      X = X + diX / 2: T = TiH + Tad6 * (X - XiH)
        Reaction_T
      Tay = Tay + DXS / W: SFT = SFT + DXS * FT
  Loop
      BB = SFT / (SFT - SFT1)
      X = X - BB * diX: T = TiH + Tad6 * (X - XiH)
        Reaction
      Tay = Tay - BB * (Tay - Tay1)
    ReactTO(2, J) = X: ReactTO(4, J) = T: ReactTO(5, J) = Tay
    AA = "    " & Format(J, "0") & "      " & Format(ReactTO(1, J), "0.000") _
      & "     " & Format(X, "0.000") & "     " & Format(ReactTO(3, J), "000.0") _
      & "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000")
      List6.AddItem (AA)
  If J < Ncat6 And X > XK6 Then GoTo 250
  Next J
          'Подобрались к XnK?
    If Sgn(X - XK6) * Sgn(DX0) > 0 Then DX0 = -DX0 / 2
    If Abs(X - XK6) > 0.0001 And Abs(DX0) > 0.0001 Then GoTo 250
End Sub

Public Sub ReactorTO_FM()
          'Реактор с ТО для слоев ИС
      ReactTO(0, 0) = 0: ReactTO(1, 0) = XH6: DX0 = 0.05
      X = (XK6 - XH6) / 2: ReactTO(1, 1) = X
        Xa = 2 * Log(10) * 4905: Xb = 2 * Log(10) * 4.6455
  270 List6.Clear
      AA = "Вход    " & Format(ReactTO(1, 0), "0.000")
      List6.AddItem (AA)
      X = ReactTO(1, 1): X = X + DX0:
      ReactTO(1, 1) = X: ReactTO(0, 1) = 1
          'Температура в 1-м слое - Топт
      FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
      FI = (X / (1 - X)) ^ 2
        T = Xa / (Xb + Log((Xa / E1 * Rgas + 1) * FI / FU))
      If T < T12 Then GoTo 275
        T = Xa / (Xb + Log((Xa / E2 * Rgas + 1) * FI / FU))
      If T < T12 Then T = T12: GoTo 275
      If T < T23 Then GoTo 275
      If E3 = 0 Then T = T23: GoTo 275
        T = Xa / (Xb + Log((Xa / E3 * Rgas + 1) * FI / FU))
      If T < T23 Then T = T23
  275   ReactTO(2, 1) = T: Reaction: ReactTO(4, 1) = W
        ReactTO(3, 1) = (X - ReactTO(1, 0)) / W
      AA = "    " & Format(ReactTO(0, 1), "0") & "      " _
      & Format(ReactTO(1, 1), "0.000") & "     " _
      & Format(ReactTO(2, 1), "000.0") & "     " _
      & Format(ReactTO(3, 1), "0.000")
      List6.AddItem (AA)
        'Последующие слои
  For J = 2 To Ncat6
        ReactTO(0, J) = J
            'Производная f=1/W по Х для (i-1) слоя
      X = ReactTO(1, J - 1)
        X = X + 0.005: Reaction: W1 = W
        X = X - 0.01: Reaction:
        Fx = 100 * (1 / W1 - 1 / W)
    FF = 1 / ReactTO(4, J - 1) + (ReactTO(1, J - 1) - ReactTO(1, J - 2)) * Fx
              'Находим  Х и Т опт. для слоя
      X = ReactTO(1, J - 1)
    Do
      X = X + 0.0005
        FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
        FI = (X / (1 - X)) ^ 2
        T = Xa / (Xb + Log((Xa / E1 * Rgas + 1) * FI / FU))
        If T < T12 Then GoTo 276
        T = Xa / (Xb + Log((Xa / E2 * Rgas + 1) * FI / FU))
        If T < T12 Then T = T12: GoTo 276
        If T < T23 Then GoTo 276
        If E3 = 0 Then T = T23: GoTo 276
        T = Xa / (Xb + Log((Xa / E3 * Rgas + 1) * FI / FU))
        If T < T23 Then T = T23
  276
        Reaction
          FD = 1 / W
    Loop Until FD > FF
      ReactTO(1, J) = X: ReactTO(2, J) = T: ReactTO(4, J) = W
      ReactTO(3, J) = (X - ReactTO(1, 0)) / W
    
      AA = "    " & Format(ReactTO(0, J), "0") & "      " _
      & Format(ReactTO(1, J), "0.000") & "     " _
      & Format(ReactTO(2, J), "000.0") & "     " _
      & Format(ReactTO(3, J), "0.000")
      List6.AddItem (AA)
  Next J
          'Подобрались к XnK?
    If Sgn(X - XK6) * Sgn(DX0) > 0 Then DX0 = -DX0 / 2
    If Abs(X - XK6) > 0.0001 And Abs(DX0) > 0.0001 Then GoTo 270
End Sub

Public Sub ReactorCG()
          'Реактор с ХГ после первого слоя
        'Определение макс. х1н
      XD = 0
    If 2 * CSO2 / CO2 < 1 Then XU = 2 * CSO2 / CO2 Else XU = 1
    W1 = -1: W2 = 1
  Do Until Abs(XU - XD) < 0.00005
    X = (XU + XD) / 2: T = TH7 + Tad7 * (X - XH7)
    Reaction
    If W < 0 Then XU = X: W1 = W Else XD = X: W2 = W
    T = T
      Loop
    X = XD + (XU - XD) * W1 / (W2 - W1)
      ReactCG(0, 1) = 1: ReactCG(1, 1) = XH7: ReactCG(3, 1) = TH7
          'Условия в конце 1-го слоя
      X1D = X: DX0 = -0.02
  260 List7.Clear
      X1D = X1D + DX0: X = X1D: T = TH7 + Tad7 * (X - XH7)
        Reaction_T
      If FT <= 0 Or W <= 0 Then DX0 = DX0 / 2: GoTo 260
          'Расчет 1-го слоя
    diX = (X1D - XH7) / 50: X = XH7: T = TH7: Tay = 0
        Reaction
        F = 1 / W: DXS = diX / 6
  For I = 1 To 50
    Tay = Tay + DXS / W: X = X + diX / 2: T = TH7 + Tad7 * (X - XH7)
        Reaction
    Tay = Tay + 4 * DXS / W: X = X + diX / 2: T = TH7 + Tad7 * (X - XH6)
        Reaction
    Tay = Tay + DXS / W
  Next I
      ReactCG(2, 1) = X: ReactCG(4, 1) = T: ReactCG(5, 1) = Tay
          'Расчет всех слоев
  For J = 2 To Ncat7
            'Определение Tiн опт
    XiH = ReactCG(2, J - 1): TiK = ReactCG(4, J - 1)
    X = XiH: T = TiK: Reaction: WiK = W
    dTiH = -20: T = T - 0.001
  If J = 2 Then
    Do Until Abs(dTiH) < 0.01
    T = T + dTiH: Vg1 = (T - Tcg7) / (TiK - Tcg7)
      X = XiH * Vg1:
    Reaction
    If Sgn(W - WiK) * Sgn(dTiH) > 0 Then dTiH = -dTiH / 2
    Loop
    ReactCG(6, 1) = Vg1
    AA = "    1" & "      " & Format(ReactCG(1, 1), "0.000") & "     " _
      & Format(ReactCG(2, 1), "0.000") & "     " _
      & Format(ReactCG(3, 1), "000.0") & "     " _
      & Format(ReactCG(4, 1), "000.0") & "      " _
      & Format(ReactCG(5, 1), "0.000") & "      " _
      & Format(ReactCG(6, 1), "0.000")
      List7.AddItem (AA)
  Else
    Do Until Abs(dTiH) < 0.01
    T = T + dTiH: Reaction
    If Sgn(W - WiK) * Sgn(dTiH) > 0 Then dTiH = -dTiH / 2
    Loop
  End If
    ReactCG(0, J) = J: ReactCG(1, J) = X: ReactCG(3, J) = T
      ReactCG(6, J) = 1
          'Определение Хiк опт
    XiH = X: TiH = T: diX = (1 - X) / 50: Tay = 0: SFT = 0
    If J = 2 Then F12cg = (X / W - ReactCG(5, 1)) / (TH7 - Tcg7) Else F12cg = 0
    diX = (1 - X) / 100: DXS = diX / 6
        Reaction_T
  Do Until SFT - F12cg > 0
        Tay1 = Tay: SFT1 = SFT - F12cg
      Tay = Tay + DXS / W: SFT = SFT + DXS * FT
      X = X + diX / 2: T = TiH + Tad7 * (X - XiH)
        Reaction_T
      Tay = Tay + 4 * DXS / W: SFT = SFT + 4 * DXS * FT
      X = X + diX / 2: T = TiH + Tad7 * (X - XiH)
        Reaction_T
      Tay = Tay + DXS / W: SFT = SFT + DXS * FT
  Loop
      BB = (SFT - F12cg) / (SFT - F12cg - SFT1)
      X = X - BB * diX: T = TiH + Tad7 * (X - XiH)
        Reaction
      Tay = Tay - BB * (Tay - Tay1)
    ReactCG(2, J) = X: ReactCG(4, J) = T: ReactCG(5, J) = Tay
    AA = "    " & Format(J, "0") & "      " & Format(ReactCG(1, J), "0.000") _
      & "     " & Format(X, "0.000") & "     " & Format(ReactCG(3, J), "000.0") _
      & "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000") _
      & "      " & Format(ReactCG(6, J), "0.000")
      List7.AddItem (AA)
  If J < Ncat7 And X > XK7 Then GoTo 260
  Next J
          'Подобрались к XnK?
    If Sgn(X - XK7) * Sgn(DX0) > 0 Then DX0 = -DX0 / 2
    If Abs(X - XK7) > 0.0001 And Abs(DX0) > 0.0001 Then GoTo 260
End Sub

Public Sub ReactorCA()
          'Реактор с ХB после всех слоев
        'Определение макс. х1н
      XD = 0
    If 2 * CSO20 / CO20 < 1 Then XU = 2 * CSO20 / CO20 Else XU = 1
    W1 = -1: W2 = 1
  Do Until Abs(XU - XD) < 0.00005
    X = (XU + XD) / 2: T = TH8 + Tad8 * (X - XH8)
    Reaction
    If W < 0 Then XU = X: W1 = W Else XD = X: W2 = W
    T = T
      Loop
    X = XD + (XU - XD) * W1 / (W2 - W1)
    T = TH8 + Tad8 * (X - XH8)
        ReactCA(0, 1) = 1: ReactCA(1, 1) = XH8
        ReactCA(3, 1) = TH8: ReactCA(6, 1) = 1
          'Условия в конце 1-го слоя
      X1D = X: DX0 = -0.02
  280 List8.Clear
      X1D = X1D + DX0: X = X1D: T = TH8 + Tad8 * (X - XH8)
      CSO2 = CSO20: CO2 = CO20
        Reaction_T
      If FT <= 0 Or W <= 0 Then DX0 = DX0 / 2: GoTo 280
          'Расчет 1-го слоя
    diX = (X1D - XH8) / 50: X = XH8: T = TH8: Tay = 0
        Reaction
        F = 1 / W: DXS = diX / 6
  For I = 1 To 50
    Tay = Tay + DXS / W: X = X + diX / 2: T = TH8 + Tad8 * (X - XH8)
        Reaction
    Tay = Tay + 4 * DXS / W: X = X + diX / 2: T = TH8 + Tad8 * (X - XH8)
        Reaction
    Tay = Tay + DXS / W
  Next I
      ReactCA(2, 1) = X: ReactCA(4, 1) = T: ReactCA(5, 1) = Tay
      ReactCA(7, 1) = Tay: ReactCA(8, 1) = CSO2: ReactCA(9, 1) = CO2
      AA = "    " & Format(ReactCA(0, 1), "0") & "     " _
      & Format(ReactCA(1, 1), "0.000") & "     " _
      & Format(ReactCA(2, 1), "0.000") & "     " _
      & Format(ReactCA(3, 1), "000.0") & "     " _
      & Format(ReactCA(4, 1), "000.0") & "      " _
      & Format(ReactCA(5, 1), "0.000") & "      " _
      & Format(ReactCA(6, 1), "0.000")
      List8.AddItem (AA)
          'Расчет всех слоев
  For J = 2 To Ncat8
            'Определение Tiн опт
    XiH = ReactCA(2, J - 1): TiK = ReactCA(4, J - 1): Va8 = ReactCA(6, J - 1)
    X = XiH: T = TiK
    CSO2 = CSO20 / Va8: CO2 = 0.21 - (0.21 - CO20) / Va8
      Reaction
        WiK = W: Va8i = Va8
    dTiH = -20: T = T - 0.001
  Do Until Abs(dTiH) < 0.01
    T = T + dTiH:
    Va8 = Va8i * (TiK - Tca8) / (T - Tca8)
    CSO2 = CSO20 / Va8: CO2 = 0.21 - (0.21 - CO20) / Va8
      Reaction
    If Sgn(W - WiK) * Sgn(dTiH) > 0 Then dTiH = -dTiH / 2
  Loop
    ReactCA(0, J) = J: ReactCA(1, J) = X:
    ReactCA(3, J) = T: ReactCA(6, J) = Va8
          'Определение Хiк опт
    XiH = X: TiH = T: diX = (1 - X) / 50: Tay = 0: SFT = 0
    diX = (1 - X) / 100: DXS = diX / 6
        Reaction_T_V
  Do Until SFT > 0
        Tay1 = Tay: SFT1 = SFT
      Tay = Tay + DXS / W: SFT = SFT + DXS * F12ca
      X = X + diX / 2: T = TiH + Tad8 / Va8 * (X - XiH)
        Reaction_T_V
      Tay = Tay + 4 * DXS / W: SFT = SFT + 4 * DXS * F12ca
      X = X + diX / 2: T = TiH + Tad8 / Va8 * (X - XiH)
        Reaction_T_V
      Tay = Tay + DXS / W: SFT = SFT + DXS * F12ca
      FT = FT: FV = FV:
      T = T
  Loop
      BB = SFT / (SFT - SFT1)
      X = X - BB * diX: T = TiH + Tad8 / Va8 * (X - XiH)
        Reaction
      Tay = Tay - BB * (Tay - Tay1)
    ReactCA(2, J) = X: ReactCA(4, J) = T: ReactCA(5, J) = Tay / Va8
    ReactCA(7, J) = Tay: ReactCA(8, J) = CSO2: ReactCA(9, J) = CO2
    AA = "    " & Format(ReactCA(0, J), "0") & "     " _
      & Format(ReactCA(1, J), "0.000") & "     " _
      & Format(ReactCA(2, J), "0.000") & "     " _
      & Format(ReactCA(3, J), "000.0") & "     " _
      & Format(ReactCA(4, J), "000.0") & "      " _
      & Format(ReactCA(5, J), "0.000") & "      " _
      & Format(ReactCA(6, J), "0.000")
    List8.AddItem (AA)
  If J < Ncat8 And X > XK8 Then GoTo 280
  Next J
            'Exit Sub
          'Подобрались к XnK?
    If Sgn(X - XK8) * Sgn(DX0) > 0 Then DX0 = -DX0 / 2
    If Abs(X - XK8) > 0.0001 And Abs(DX0) > 0.0001 Then GoTo 280
End Sub

Public Sub ReactorII_DK()
        'Реактор II ступени в системе ДК/ДА
      'Определение Т1н
    TU = 800: TD = 650
    ReactII(0, 1) = 1: ReactII(1, 1) = XH9:
  Do
      List9.Clear
    T = (TU + TD) / 2: ReactII(3, 1) = T
      'Расчет слоев
  For J = 1 To Ncat9
            'Определение Хiк опт
      XiH = ReactII(1, J): TiH = ReactII(3, J)
      X = XiH: T = TiH: Tay = 0: SFT = 0
      diX = (1 - X) / 100: DXS = diX / 6
          Reaction_T
      Do Until SFT > 0
            Tay1 = Tay: SFT1 = SFT
          Tay = Tay + DXS / W: SFT = SFT + DXS * FT
          X = X + diX / 2: T = TiH + Tad9 * (X - XiH)
            Reaction_T
          Tay = Tay + 4 * DXS / W: SFT = SFT + 4 * DXS * FT
          X = X + diX / 2: T = TiH + Tad9 * (X - XiH)
            Reaction_T
          Tay = Tay + DXS / W: SFT = SFT + DXS * FT
      Loop
        BB = SFT / (SFT - SFT1)
        X = X - BB * diX: T = TiH + Tad9 * (X - XiH)
          Reaction
        Tay = Tay - BB * (Tay - Tay1)
      ReactII(2, J) = X: ReactII(4, J) = T: ReactII(5, J) = Tay
      AA = "    " & Format(J, "0") & "     " & Format(ReactII(1, J), "0.000") _
        & "     " & Format(X, "0.000") & "     " & Format(ReactII(3, J), "000.0") _
        & "     " & Format(T, "000.0") & "     " & Format(Tay, "0.000")
        List9.AddItem (AA)
              'Определение Ti+1,н опт
    If J < Ncat9 Then
        XiH = ReactII(2, J): TiK = ReactII(4, J)
          X = XiH: T = TiK: Reaction: WiK = W
          dTiH = -20: T = T - 0.001
      Do Until Abs(dTiH) < 0.01
          T = T + dTiH: Reaction
          If Sgn(W - WiK) * Sgn(dTiH) > 0 Then dTiH = -dTiH / 2
      Loop
        ReactII(0, J + 1) = J + 1: ReactII(1, J + 1) = X: ReactII(3, J + 1) = T
    End If
  Next J
  If ReactII(2, Ncat9) < XK9 Then TU = ReactII(3, 1) Else TD = ReactII(3, 1)
          'Подобрались к Т1н?
  Loop Until Abs(ReactII(1, Ncat9) - XK9) < 0.0001 Or Abs(TU - TD) < 0.01
End Sub

Private Sub VScroll1_Change()
  'Привязка бегунка к окну
 Select Case VarHelp
  Case 0
   OLE2.Top = VScroll1.Value - 1
  Case 1
   OLE4.Top = VScroll1.Value - 1
  Case 2
   OLE5.Top = VScroll1.Value - 1
  Case 3
   OLE6.Top = VScroll1.Value - 1
  Case 4
   OLE7.Top = VScroll1.Value - 1
  Case 5
   OLE8.Top = VScroll1.Value - 1
  Case 6
   OLE9.Top = VScroll1.Value - 1
  Case 7
   OLE10.Top = VScroll1.Value - 1
  Case 8
   OLE11.Top = VScroll1.Value - 1
  Case 9
   OLE12.Top = VScroll1.Value - 1
  Case 10
   OLE13.Top = VScroll1.Value - 1
 End Select
 
End Sub

