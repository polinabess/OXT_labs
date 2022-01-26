// Функция создания двухмерного массива
function makeArray(a, b) {
    var arr = new Array(a)
    for (var i = 0; i < a; i++)
        arr[i] = new Array(b).fill(0);
    return arr
}

// Варианты
var Variable1, Cat = 2;
var DataVar = new Array(9).fill("b");
//Исходные данные по катализатору
var Tz, Kz, E1, E2, E3, T12, T23, K12, K23, Rgas = 0.00819;
var CatDatN = makeArray(10, 7),
    Flow = "IF";
//Начальные условия
var CSO20, CSO2, CO20, CO2, P, Tad, XH, XK, TH, TK, TayK, dX, dT;
var Ncat;
//Текущие значения
var X, T, Kr, Kp, W, FT, FV, EI, Tay, Tay1;
//1-Xp(T)
var TXpKp = makeArray(3, 250),
    TH1, TK1, dT1, A1, B1, P1, NXp;
//2-W(T)
var WT = makeArray(2, 250),
    XH2, TH2, TK2, dT2, A2, B2, P2, NW, Cat2;
//3-Topt
var XTopt = makeArray(3, 250),
    XH3, XK3, dX3, A3, B3, P3, NTopt, Cat3;
//4-Tay(X)
var TayX = makeArray(3, 120),
    Tad4, XH4, XK4, TH4, A4, B4, P4, NtX, Cat4;
var Taymax;
var Flow4;
//5-X(Tay)
var XTay = makeArray(3, 120),
    Tad5, XH5, TH5, TayK5, A5, B5, P5, NXt, Cat5;
var Taymax5;
var Flow5;
//6-Р-р с Т.О.
var ReactTO = makeArray(6, 6),
    Tad6, XH6, TH6, XK6, A6, B6, P6, Cat6;
var Fx, FF;
var Ncat6;
var Flow6;
//7-Р-р с Х.Г.
var ReactCG = makeArray(7, 6),
    Tad7, XH7, TH7, XK7, Tcg7, A7, B7, P7, Cat7, Vg1;
var F12cg; //Для расчета Тн2
var Ncat7;
//8-Р-р с Х.B.
var ReactCA = makeArray(10, 6),
    Tad8, XH8, TH8, XK8, Tca8, A8, B8, P8, Cat8, Va8;
var F12ca, Va8i; //Для расчета Тн2
var Ncat8;
//9-Р-р II ступень ДК
var ReactII = makeArray(6, 6),
    Tad9, XH9, TH9, XK9, A9, B9, P9, Cat9;
var Ncat9;
//Вспомогательные переменные
var L, I, J, Oo, VarHelp;
var XU, XD, TU, TD, FU, FI, FD, BB;
var diX, dTay, dFT, F, SFT, SFT1, W1, W2, FT1, WT1; //Для интегрирования
var X1D, DX0; //Для подбора Х1к
var XiH, TiH, XiK, TiK, dTiH; //Для расчета слоя реактора
var WiK, DXS; // -"-
var Xa, Xb, Xc;
var AA;
var X1, X2, Y1, Y2, Ymax; //Для графиков

function Catalyst(evt) {
    // Запись параметров катализатора
    Cat = evt.currentTarget.value;
    var cat_texts = document.getElementsByClassName('form-control');
    for (var i = 0; i < cat_texts.length; i++) {
        switch (Cat) {
            case "1":
                switch (cat_texts[i].id) {
                    case "t":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 753;
                        break;
                    case "k":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 1.35;
                        break;
                    case "e1":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 176.7;
                        break;
                    case "e2":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 58.6;
                        break;
                    case "e3":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 0;
                        break;
                    case "t12":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 713;
                        break;
                    case "t23":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 803;
                        break;
                }
                break;
            case "2":
                switch (cat_texts[i].id) {
                    case "t":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 753;
                        break;
                    case "k":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 1.45;
                        break;
                    case "e1":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 126.4;
                        break;
                    case "e2":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 55.2;
                        break;
                    case "e3":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 0;
                        break;
                    case "t12":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 693;
                        break;
                    case "t23":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 803;
                        break;
                }
                /*
                Text15.Text = "753": Text16.Text = "1,45"
                Text17.Text = "126,4": Text18.Text = "55,2": Text19.Text = "0"
                Text20.Text = "693": Text21.Text = "803"
                Text15.Locked = True: Text16.Locked = True
                Text17.Locked = True: Text18.Locked = True: Text19.Locked = True
                Text20.Locked = True: Text21.Locked = True
                */
                break;
            case "3":
                switch (cat_texts[i].id) {
                    case "t":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 753;
                        break;
                    case "k":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 1.45;
                        break;
                    case "e1":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 58.6;
                        break;
                    case "e2":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 58.6;
                        break;
                    case "e3":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 58.6;
                        break;
                    case "t12":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 300;
                        break;
                    case "t23":
                        cat_texts[i].setAttribute('disabled', 'disabled');
                        cat_texts[i].setAttribute('readonly', 'readonly');
                        cat_texts[i].value = 1100;
                        break;
                }
                /*
                Text15.Text = "753": Text16.Text = "1,45"
                Text17.Text = "58,6": Text18.Text = "58,6": Text19.Text = "58,6"
                Text20.Text = "300": Text21.Text = "1100"
                Text15.Locked = True: Text16.Locked = True
                Text17.Locked = True: Text18.Locked = True: Text19.Locked = True
                Text20.Locked = True: Text21.Locked = True
                */
                break;
            case "4":
                switch (cat_texts[i].id) {
                    case "t":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "k":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "e1":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "e2":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "e3":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "t12":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                    case "t23":
                        cat_texts[i].removeAttribute('disabled');
                        cat_texts[i].removeAttribute('readonly');
                        cat_texts[i].value = "";
                        break;
                }
                /*
                Text15.Text = CatDatN(Variable1, 0): Text15.Locked = False
                Text16.Text = CatDatN(Variable1, 1): Text16.Locked = False
                Text17.Text = CatDatN(Variable1, 2): Text17.Locked = False
                Text18.Text = CatDatN(Variable1, 3): Text18.Locked = False
                Text19.Text = CatDatN(Variable1, 4): Text19.Locked = False
                Text20.Text = CatDatN(Variable1, 5): Text20.Locked = False
                Text21.Text = CatDatN(Variable1, 6): Text21.Locked = False
                */
                break;

        }
    }


}

var cat_selects = document.getElementsByClassName('form-select');
for (var i = 0; i < cat_selects.length; i++) {
    cat_selects[i].addEventListener('change', Catalyst, false);
}

function IsNumeric(input) {
    return (input - 0) == input && ('' + input).trim().length > 0;
}

function Reaction() {
    // Скорость реакции W
    Kp = Math.pow(10, 4905 / T - 4.6455);

    if (T > T23) {
        Kr = K23 * Math.exp(E3 / Rgas * (1 / T23 - 1 / T));
        EI = E3 / Rgas;
    } else {
        if (T > T12) {
            Kr = Kz * Math.exp(E2 / Rgas * (1 / Tz - 1 / T));
            EI = E2 / Rgas;
        } else {
            Kr = K12 * Math.exp(E1 / Rgas * (1 / T12 - 1 / T));
            EI = E1 / Rgas;
        }
    }

    FU = (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X) * P
    FI = Math.pow(X / (1 - X) / Kp, 2)
    W = Kr / CSO20 * (1 - X) / (1 - 0.2 * X) * (FU - FI)
}

function Reaction_T() {
    // df/dT и cкорость реакции W
    Reaction();
    if (W = 0) { F = 100000000 } else { F = 1 / W; }
    FT = (2 * Math.log(10) * 4905 * FI / (FU - FI) - EI) / W / T / T;

}

function ReactorII_DK() {

    // Реактор II ступени в системе ДК/ДА
    // Определение Т1н
    TU = 800;
    TD = 650
    ReactII[0, 1] = 1;
    ReactII[1, 1] = XH9;
    do {
        T = (TU + TD) / 2;
        ReactII[3, 1] = T
        for (let J = 1; J < Ncat9; J++) {
            XiH = ReactII[1, J];
            TiH = ReactII[3, J];
            X = XiH;
            T = TiH;
            Tay = 0;
            SFT = 0
            diX = (1 - X) / 100;
            DXS = diX / 6
            Reaction_T();
            while (SFT <= 0) {
                Tay1 = Tay;
                SFT1 = SFT
                Tay = Tay + DXS / W;
                SFT = SFT + DXS * FT
                X = X + diX / 2;
                T = TiH + Tad9 * (X - XiH)
                Reaction_T();
                Tay = Tay + 4 * DXS / W;
                SFT = SFT + 4 * DXS * FT
                X = X + diX / 2;
                T = TiH + Tad9 * (X - XiH)
                Reaction_T();
                Tay = Tay + DXS / W;
                SFT = SFT + DXS * FT
            }
            BB = SFT / (SFT - SFT1)
            X = X - BB * diX;
            T = TiH + Tad9 * (X - XiH)

            Reaction();
            Tay = Tay - BB * (Tay - Tay1);

            ReactII[2, J] = X;
            ReactII[4, J] = T;
            ReactII[5, J] = Tay
                /* 
                AA = "    " & Format(J, "0") & "     " & Format(ReactII(1, J), "0.000") _
                & "     " & Format(X, "0.000") & "     " & Format(ReactII(3, J), "000.0") _
                & "     " & Format(T, "000.0") & "     " & Format(Tay, "0.000")
                List9.AddItem (AA)
                */

            console.log(J, ReactII[1, J], X, ReactII[3, J], T, Tay)
            if (J < Ncat9) {
                XiH = ReactII[2, J];
                TiK = ReactII[4, J];
                X = XiH;
                T = TiK;
                Reaction();
                WiK = W;
                dTiH = -20;
                T = T - 0.001;
                while (Math.abs(dTiH) < 0.01) {
                    T = T + dTiH;
                    Reaction();
                    if (Math.sign(W - WiK) * Math.sign(dTiH) > 0) { dTiH = -dTiH / 2 }
                }
                ReactII[0, J + 1] = J + 1;
                ReactII[1, J + 1] = X;
                ReactII[3, J + 1] = T;
            }

        }
        if (ReactII[2, Ncat9] < XK9) { TU = ReactII[3, 1] } else { TD = ReactII[3, 1] }

    } while (Math.abs(ReactII[1, Ncat9] - XK9) >= 0.0001 || Math.abs(TU - TD) >= 0.01)
}

function Equlibrim() {
    // Равновесие Хр
    // List1.Clear
    T = TH1;
    NXp = 0
    while (T <= TK1) {
        NXp = NXp + 1;
        AA = ""
        Kp = Math.pow(10, (4905 / T - 4.6455));
        XD = 0;
        XU = 1
        if (CSO2 / CO2 / 2 > 1) { XU = CSO2 / CO2 / 2 }
        X = (XU + XD) / 2;
        while (Math.abs(XU - XD) > 0.00005) {
            FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
            FI = Math.pow((X / (1 - X) / Kp), 2);
            if (FU < FI) { XU = X } else { XD = X }
            X = (XU + XD) / 2;
        }
        TXpKp[0, NXp] = T;
        TXpKp[1, NXp] = X;
        TXpKp[2, NXp] = Kp;
        /*
      AA = AA & Format(T, "000.0") & "   " & Format(X, "0.0000")
      AA = AA & "   " & Format(Kp, "0.00")
    List1.AddItem (AA)
    */
        console.log(T, X, Kp);
        // Закинуть в табличку T, X, Kp
        // Построить график
        T = T + dT1;

    }

}

function Rate_T() {
    // Скорость реакции W(T)
    // List2.Clear
    X = XH2;
    T = TH2;
    NW = 0;
    while (T <= TK2) {
        NW = NW + 1;
        Reaction();
        WT[0, NW] = T;
        WT[1, NW] = W;
        //List2.AddItem (Format(T, "000.0") & "   " & Format(W, "0.0000"))
        console.log(T, W);
        // В табличку T, W
        // Построить график

        if (W < 0) {
            break;
        }
        T = T + dT2
    }
}

function T_optimum() {
    // Оптимальные температуры Topt
    // List3.Clear
    X = XH3;
    NTopt = 0;

    Xa = 2 * Math.log(10) * 4905;
    Xb = 2 * Math.log(10) * 4.6455;
    while (X <= XK3 + 1E-6) {
        NTopt = NTopt + 1;
        AA = "";
        FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X);
        FI = Math.pow((X / (1 - X)), 2)
        T = Xa / (Xb + Math.log((Xa / E1 * Rgas + 1) * FI / FU));
        if (T < T12) {
            m911();
            continue;
        }
        T = Xa / (Xb + Math.log((Xa / E2 * Rgas + 1) * FI / FU));
        if (T < T12) {
            T = T12;
            m911();
            continue;
        }
        if (T < T23) {
            m911();
            continue;
        }
        if (E3 == 0) {
            T = T23;
            m911();
            continue;
        }
        T = Xa / (Xb + Math.log((Xa / E3 * Rgas + 1) * FI / FU));
        if (T < T23) { T = T23 }
    }

}

function m911() {
    Reaction();
    XTopt[0, NTopt] = X;
    XTopt[1, NTopt] = T;
    XTopt[2, NTopt] = W;
    console.log(X, T, W);
    // Закинуть в табличку X, T, W
    // Построить график
    X = X + dX3;
}

function Bed_Tay_X() {
    //Время контакта при заданном Х
    //List4.Clear
    X = XH4;
    T = TH4;
    Tay = 0;
    NtX = 1;
    TayX[0, NtX] = Tay;
    TayX[1, NtX] = X;
    TayX[2, NtX] = T;
    Reaction();
    AA = "";
    //AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
    //AA = AA & "   " & Format(T, "000.0")
    //List4.AddItem (AA)
    console.log(Tay, X, T)
        // Закинуть в табличку Tay, X, T
        // Построить график
    switch (Flow) {
        //ИС
        case "FM":
            X = XK4;
            T = TH4 + Tad4 * (XK4 - XH4);
            Reaction();
            Tay = (XK4 - XH4) / W;
            NtX = NtX + 1;
            TayX[0, NtX] = Tay;
            TayX[1, NtX] = X;
            TayX[2, NtX] = T;
            //AA = ""
            //AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
            //AA = AA & "   " & Format(T, "000.0")
            //List4.AddItem(AA)
            console.log(Tay, X, T)
                // Закинуть в табличку Tay, X, T
                // Построить график
            break;

            //'ИВ    
        case "IF":
            diX = (XK4 - XH4) / 50;
            X = XH4;
            T = TH4;
            Reaction();

            for (let I = 1; I < 11; I++) {
                for (let J = 1; J < 6; J++) {
                    F = 1 / W
                    X = X + diX / 2;
                    T = TH4 + Tad4 * (X - XH4);
                    Reaction();

                    F = F + 4 / W
                    X = X + diX / 2;
                    T = TH4 + Tad4 * (X - XH4);
                    Reaction();

                    Tay = Tay + (F + 1 / W) * diX / 6
                    NtX = NtX + 1
                    TayX[0, NtX] = Tay;
                    TayX[1, NtX] = X;
                    TayX[2, NtX] = T
                }
                AA = "";
                //AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
                //AA = AA & "   " & Format(T, "000.0")
                //List4.AddItem(AA)
                console.log(Tay, X, T);
                // Закинуть в табличку Tay, X, T
                // Построить график
            }
            break;
    }
    Taymax = Tay;
}

function Bed_X_Tay() {
    //Степень превращения при заданном tay
    //List5.Clear
    XTay[0, 1] = 0;
    XTay[1, 1] = XH5;
    XTay[2, 1] = TH5;
    AA = "";
    //AA = AA & "0.000" & "   " & Format(XH5, "0.0000")
    //AA = AA & "   " & Format(TH5, "000.0")
    //List5.AddItem (AA)
    console.log("0.000", XH5, TH5)
        // Закинуть в табличку "0.000", XH5, TH5
        // Построить график
    switch (Flow) {
        case "FM":
            //ИС
            XD = XH5;
            XU = 1;
            while (Math.abs(XU - XD) >= 0.0001) {
                X = (XU + XD) / 2;
                T = TH5 + Tad5 * X;
                Reaction();
                if (TayK5 * W + XH5 - X > 0) { XD = X } else { XU = X }
            }

            XTay[0, 2] = TayK5;
            XTay[1, 2] = X;
            XTay[2, 2] = T;
            AA = "";
            //AA = AA & Format(TayK5, "0.000") & "   " & Format(X, "0.0000")
            //AA = AA & "   " & Format(T, "000.0")
            //List5.AddItem(AA)
            console.log(TayK5, X, T)
                // Закинуть в табличку TayK5, X, T
                // Построить график
            break;
        case "IF":
            //'ИВ
            dTay = TayK5 / 100;
            Tay = 0;
            NXt = 0;
            X = XH5;
            T = TH5;
            Reaction();
            for (let I = 1; I < 11; I++) {
                for (let J = 1; J < 11; J++) {
                    W1 = W;
                    X1 = X
                    X = X + W * dTay;
                    T = TH5 + Tad5 * X;
                    Reaction();
                    X = X1 + (W + W1) / 2 * dTay
                    Tay = Tay + dTay
                    NXt = NXt + 1
                    XTay[0, NXt] = Tay;
                    XTay[1, NXt] = X;
                    XTay[2, NXt] = T
                }
                //AA = ""
                //AA = AA & Format(Tay, "0.000") & "   " & Format(X, "0.0000")
                //AA = AA & "   " & Format(T, "000.0")
                //List5.AddItem(AA)
                console.log(Tay, X, T)
                    // Закинуть в табличку Tay, X, T
                    // Построить график
            }

    }
    Taymax = TayK5


}

function ReactorTO() {
    //Реактор с ТО
    //  'Определение макс. х1н
    XD = 0;
    if (2 * CSO2 / CO2 < 1) { XU = 2 * CSO2 / CO2 } else { XU = 1 }
    W1 = -1;
    W2 = 1;
    while (Math.abs(XU - XD) >= 0.00005) {
        X = (XU + XD) / 2;
        T = TH6 + Tad6 * (X - XH6)
        Reaction();
        if (W < 0) {
            XU = X;
            W1 = W
        } else {
            XD = X;
            W2 = W
        }
    }
    X = XD + (XU - XD) * W1 / (W2 - W1);
    ReactTO[0, 1] = 1;
    ReactTO[1, 1] = XH6;
    ReactTO[3, 1] = TH6; // Условия в конце 1-го слоя
    X1D = X;
    DX0 = -0.02
    m250();
}

function m250() {
    X1D = X1D + DX0;
    X = X1D;
    T = TH6 + Tad6 * (X - XH6)
    Reaction_T();
    if (FT <= 0 || W <= 0) {
        DX0 = DX0 / 2;
        m250()
    } //'Расчет 1-го слоя


    diX = (X1D - XH6) / 50;
    X = XH6;
    T = TH6;
    Tay = 0
    Reaction();
    F = 1 / W;
    DXS = diX / 6;
    for (let I = 1; I < 51; I++) {

        Tay = Tay + DXS / W;
        X = X + diX / 2;
        T = TH6 + Tad6 * (X - XH6);
        Reaction();
        Tay = Tay + 4 * DXS / W;
        X = X + diX / 2;
        T = TH6 + Tad6 * (X - XH6);
        Reaction();
        Tay = Tay + DXS / W
    }
    ReactTO[2, 1] = X;
    ReactTO[4, 1] = T;
    ReactTO[5, 1] = Tay
        //AA = "    1" & "      " & Format(ReactTO(1, 1), "0.000") & "     "
        //   &
        //   Format(X, "0.000") & "     " & Format(ReactTO(3, 1), "000.0") _ &
        //   "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000")
    console.log(1, ReactTO[1, 1], X, ReactTO[3, 1], T, Tay)
        //Расчет всех слоев
    for (let J = 2; J < Ncat6 + 1; J++) {
        //Определение Tiн опт
        XiH = ReactTO[2, J - 1];
        TiK = ReactTO[4, J - 1]
        X = XiH;
        T = TiK;
        Reaction();
        WiK = W
        dTiH = -20;
        T = T - 0.001;
        while (Math.abs(dTiH) >= 0.01) {
            T = T + dTiH;
            Reaction();
            if (Math.Math.sgn(W - WiK) * Math.Math.sgn(dTiH) > 0) { dTiH = -dTiH / 2 }
        }


        Loop
        ReactTO[0, J] = J;
        ReactTO[1, J] = X;
        ReactTO[3, J] = T //Определение Хiк опт
        XiH = X;
        TiH = T;
        diX = (1 - X) / 50;
        Tay = 0;
        SFT = 0
        diX = (1 - X) / 100;
        DXS = diX / 6
        Reaction_T();
        while (SFT < 0) {
            Tay1 = Tay;
            SFT1 = SFT;
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * FT;
            X = X + diX / 2;
            T = TiH + Tad6 * (X - XiH);
            Reaction_T();
            Tay = Tay + 4 * DXS / W;
            SFT = SFT + 4 * DXS * FT
            X = X + diX / 2;
            T = TiH + Tad6 * (X - XiH)
            Reaction_T()
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * FT
        }

        BB = SFT / (SFT - SFT1)
        X = X - BB * diX;
        T = TiH + Tad6 * (X - XiH)
        Reaction();
        Tay = Tay - BB * (Tay - Tay1);
        ReactTO[2, J] = X;
        ReactTO[4, J] = T;
        ReactTO[5, J] = Tay;
        //AA = "    " & Format(J, "0") & "      " & Format(ReactTO(1, J), "0.000") _ &
        //    "     " & Format(X, "0.000") & "     " & Format(ReactTO(3, J), "000.0") _ &
        //    "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000")
        //List6.AddItem(AA)
        console.log(J, ReactTO[1, J], X, ReactTO[3, J], T, Tay)
        if (J < Ncat6 && X > XK6) { m250(); }
    }
    // Подобрались к XnK?
    if (Math.Math.sgn(X - XK6) * Math.Math.sgn(DX0) > 0) { DX0 = -DX0 / 2 }
    if (Math.abs(X - XK6) > 0.0001 && Math.abs(DX0) > 0.0001) { m250(); }
}

function ReactorTO_FM() {

    ReactTO[0, 0] = 0;
    ReactTO[1, 0] = XH6;
    DX0 = 0.05
    X = (XK6 - XH6) / 2;
    ReactTO[1, 1] = X;
    Xa = 2 * Math.log(10) * 4905;
    Xb = 2 * Math.log(10) * 4.6455;
    m270();
}

function m270() {
    console.log("Вход    " + ReactTO[1, 0])

    X = ReactTO[1, 1];
    X = X + DX0;
    ReactTO[1, 1] = X;
    ReactTO[0, 1] = 1 //Температура в 1-м слое - Топт
    FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
    FI = (X / (1 - X)) ^ 2
    T = Xa / (Xb + Math.log((Xa / E1 * Rgas + 1) * FI / FU))
    if (T < T12) { m275() }
    T = Xa / (Xb + Math.log((Xa / E2 * Rgas + 1) * FI / FU))
    if (T < T12) {
        T = T12;
        m275()
    }
    if (T < T23) { m275() }
    if (E3 = 0) {
        T = T23;
        m275()
    }
    T = Xa / (Xb + Math.log((Xa / E3 * Rgas + 1) * FI / FU))
    if (T < T23) { T = T23 }

}

function m275() {
    ReactTO[2, 1] = T;
    Reaction();
    ReactTO[4, 1] = W;
    ReactTO[3, 1] = (X - ReactTO[1, 0]) / W;
    console.log("    " + ReactTO[0, 1] + "     " + ReactTO[1, 1] + "     " + ReactTO[2, 1] + "     " + ReactTO[2, 1] + "     " + ReactTO[3, 1])

    //Последующие слои
    for (let J = 2; J < Ncat6 + 1; J++) {
        ReactTO[0, J] = J //Производная f=1/W по Х для (i-1) слоя
        X = ReactTO[1, J - 1];
        X = X + 0.005;
        Reaction();
        W1 = W;
        X = X - 0.01;
        Reaction();
        Fx = 100 * (1 / W1 - 1 / W);
        FF = 1 / ReactTO[4, J - 1] + (ReactTO[1, J - 1] - ReactTO[1, J - 2]) * Fx //Находим  Х и Т опт. для слоя
        X = ReactTO[1, J - 1]
        do {
            X = X + 0.0005
            FU = P * (CO2 - 0.5 * CSO2 * X) / (1 - 0.5 * CSO2 * X)
            FI = (X / (1 - X)) ^ 2
            T = Xa / (Xb + Math.log((Xa / E1 * Rgas + 1) * FI / FU))
            if (T < T12) { m276(); }
            T = Xa / (Xb + Math.log((Xa / E2 * Rgas + 1) * FI / FU))
            if (T < T12) {
                T = T12;
                m276();
            }
            if (T < T23) { m276(); }
            if (E3 = 0) {
                T = T23;
                m276();
            }
            T = Xa / (Xb + Math.log((Xa / E3 * Rgas + 1) * FI / FU))
            if (T < T23) { T = T23 }
            276
            Reaction();
            FD = 1 / W
        }
        while (FD <= FF)
        ReactTO[1, J] = X;
        ReactTO[2, J] = T;
        ReactTO[4, J] = W
        ReactTO[3, J] = (X - ReactTO[1, 0]) / W
        console.log(ReactTO[0, J] + "      " + ReactTO[1, J] + "      " + ReactTO[2, J] + "      " + ReactTO[3, J])

    }
    // Подобрались к XnK?
    if (Math.sgn(X - XK6) * Math.sgn(DX0) > 0) { DX0 = -DX0 / 2 }
    if (Math.abs(X - XK6) > 0.0001 && Math.abs(DX0) > 0.0001) { m270(); }
}

function m276() {
    do {
        Reaction();
        FD = 1 / W
    }
    while (FD <= FF)
}

function ReactorCG() {
    //Реактор с ХГ после первого слоя
    //Определение макс. х1н
    XD = 0
    if (2 * CSO2 / CO2 < 1) { XU = 2 * CSO2 / CO2 } else { XU = 1 }
    W1 = -1;
    W2 = 1
    while (Math.abs(XU - XD) >= 0.00005) {
        X = (XU + XD) / 2;
        T = TH7 + Tad7 * (X - XH7)
        Reaction();
        if (W < 0) {
            XU = X;
            W1 = W
        } else {
            XD = X;
            W2 = W
        }
        T = T
    }
    X = XD + (XU - XD) * W1 / (W2 - W1)
    ReactCG[0, 1] = 1;
    ReactCG[1, 1] = XH7;
    ReactCG[3, 1] = TH7 // Условия в конце 1-го слоя
    X1D = X;
    DX0 = -0.02
    m260();
}

function m260() {
    // 260 List7.Clear
    X1D = X1D + DX0;
    X = X1D;
    T = TH7 + Tad7 * (X - XH7);
    Reaction_T();
    if (FT <= 0 || W <= 0) {
        DX0 = DX0 / 2;
        m260();
    }
    diX = (X1D - XH7) / 50;
    X = XH7;
    T = TH7;
    Tay = 0
    Reaction();
    F = 1 / W;
    DXS = diX / 6
    for (let I = 1; I < 51; I++) {
        Tay = Tay + DXS / W;
        X = X + diX / 2;
        T = TH7 + Tad7 * (X - XH7)
        Reaction()
        Tay = Tay + 4 * DXS / W;
        X = X + diX / 2;
        T = TH7 + Tad7 * (X - XH6)
        Reaction()
        Tay = Tay + DXS / W
    }
    ReactCG[2, 1] = X;
    ReactCG[4, 1] = T;
    ReactCG[5, 1] = Tay //Расчет всех слоев
    for (let J = 2; J < Ncat7 + 1; J++) {
        //Определение Tiн опт
        XiH = ReactCG[2, J - 1];
        TiK = ReactCG[4, J - 1]
        X = XiH;
        T = TiK;
        Reaction();
        WiK = W;
        dTiH = -20;
        T = T - 0.001;
        if (J == 2) {
            while (Math.abs(dTiH) >= 0.01) {
                T = T + dTiH;
                Vg1 = (T - Tcg7) / (TiK - Tcg7)
                X = XiH * Vg1;
                Reaction();
                if (Math.sgn(W - WiK) * Math.sgn(dTiH) > 0) { dTiH = -dTiH / 2 }
            }

            ReactCG[6, 1] = Vg1
                /*
                AA = "    1" & "      " & Format(ReactCG(1, 1), "0.000") & "     "
                _
                    &
                    Format(ReactCG(2, 1), "0.000") & "     "
                _
                    &
                    Format(ReactCG(3, 1), "000.0") & "     "
                _
                    &
                    Format(ReactCG(4, 1), "000.0") & "      "
                _
                    &
                    Format(ReactCG(5, 1), "0.000") & "      "
                _
                    &
                    Format(ReactCG(6, 1), "0.000")
                List7.AddItem(AA)
                */
        } else {
            while (Math.abs(dTiH) >= 0.01) {
                T = T + dTiH;
                Reaction();
                if (Math.sgn(W - WiK) * Math.sgn(dTiH) > 0) { dTiH = -dTiH / 2 }
            }

        }

        ReactCG[0, J] = J;
        ReactCG[1, J] = X;
        ReactCG[3, J] = T
        ReactCG[6, J] = 1 //Определение Хiк опт

        XiH = X;
        TiH = T;
        diX = (1 - X) / 50;
        Tay = 0;
        SFT = 0
        if (J == 2) { F12cg = (X / W - ReactCG[5, 1]) / (TH7 - Tcg7) } else { F12cg = 0 }
        diX = (1 - X) / 100;
        DXS = diX / 6
        Reaction_T();

        while (SFT - F12cg <= 0) {
            Tay1 = Tay;
            SFT1 = SFT - F12cg
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * FT
            X = X + diX / 2;
            T = TiH + Tad7 * (X - XiH)
            Reaction_T();
            Tay = Tay + 4 * DXS / W;
            SFT = SFT + 4 * DXS * FT
            X = X + diX / 2;
            T = TiH + Tad7 * (X - XiH)
            Reaction_T();
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * FT
        }
        BB = (SFT - F12cg) / (SFT - F12cg - SFT1)
        X = X - BB * diX;
        T = TiH + Tad7 * (X - XiH)
        Reaction();
        Tay = Tay - BB * (Tay - Tay1)
        ReactCG[2, J] = X;
        ReactCG[4, J] = T;
        ReactCG[5, J] = Tay
            /*
            AA = "    " & Format(J, "0") & "      " & Format(ReactCG(1, J), "0.000") _ &
                "     " & Format(X, "0.000") & "     " & Format(ReactCG(3, J), "000.0") _ &
                "     " & Format(T, "000.0") & "      " & Format(Tay, "0.000") _ &
                "      " & Format(ReactCG(6, J), "0.000")
            List7.AddItem(AA)
            */
        if (J < Ncat7 && X > XK7) { m260(); }
    }
    // Подобрались к XnK?
    if (Math.sgn(X - XK7) * Math.sgn(DX0) > 0) { DX0 = -DX0 / 2 }
    if (Math.abs(X - XK7) > 0.0001 && Math.abs(DX0) > 0.0001) { m260(); }
}

function ReactorCA() {
    //Реактор с ХB после всех слоев
    //Определение макс. х1н
    XD = 0
    if (2 * CSO20 / CO20 < 1) { XU = 2 * CSO20 / CO20 } else { XU = 1 }
    W1 = -1;
    W2 = 1
    while (Math.abs(XU - XD) >= 0.00005) {
        X = (XU + XD) / 2;
        T = TH8 + Tad8 * (X - XH8)
        Reaction();
        if (W < 0) {
            XU = X;
            W1 = W
        } else {
            XD = X;
            W2 = W
        }
        T = T
    }
    X = XD + (XU - XD) * W1 / (W2 - W1)
    T = TH8 + Tad8 * (X - XH8)
    ReactCA[0, 1] = 1;
    ReactCA[1, 1] = XH8
    ReactCA[3, 1] = TH8;
    ReactCA[6, 1] = 1 //Условия в конце 1-го слоя
    X1D = X;
    DX0 = -0.02
    m280();
}

function m280() {
    //280 List8.Clear
    X1D = X1D + DX0;
    X = X1D;
    T = TH8 + Tad8 * (X - XH8)
    CSO2 = CSO20;
    CO2 = CO20
    Reaction_T();
    if (FT <= 0 || W <= 0) {
        DX0 = DX0 / 2;
        m280();
    }
    // Расчет 1-го слоя
    diX = (X1D - XH8) / 50;
    X = XH8;
    T = TH8;
    Tay = 0
    Reaction();
    F = 1 / W;
    DXS = diX / 6
    for (let I = 1; I < 51; I++) {
        Tay = Tay + DXS / W;
        X = X + diX / 2;
        T = TH8 + Tad8 * (X - XH8)
        Reaction
        Tay = Tay + 4 * DXS / W;
        X = X + diX / 2;
        T = TH8 + Tad8 * (X - XH8)
        Reaction
        Tay = Tay + DXS / W
    }
    ReactCA[2, 1] = X;
    ReactCA[4, 1] = T;
    ReactCA[5, 1] = Tay
    ReactCA[7, 1] = Tay;
    ReactCA[8, 1] = CSO2;
    ReactCA[9, 1] = CO2
        /*
        AA = "    " & Format(ReactCA(0, 1), "0") & "     "
        _
            &
            Format(ReactCA(1, 1), "0.000") & "     "
        _
            &
            Format(ReactCA(2, 1), "0.000") & "     "
        _
            &
            Format(ReactCA(3, 1), "000.0") & "     "
        _
            &
            Format(ReactCA(4, 1), "000.0") & "      "
        _
            &
            Format(ReactCA(5, 1), "0.000") & "      "
        _
            &
            Format(ReactCA(6, 1), "0.000")
        List8.AddItem(AA)
        */
        //Расчет всех слоев
    for (let J = 2; J < Ncat8 + 1; J++) { //Определение Tiн опт
        XiH = ReactCA[2, J - 1];
        TiK = ReactCA[4, J - 1];
        Va8 = ReactCA[6, J - 1];
        X = XiH;
        T = TiK
        CSO2 = CSO20 / Va8;
        CO2 = 0.21 - (0.21 - CO20) / Va8
        Reaction();
        WiK = W;
        Va8i = Va8
        dTiH = -20;
        T = T - 0.001
        while (Math.abs(dTiH) >= 0.01) {
            T = T + dTiH;
            Va8 = Va8i * (TiK - Tca8) / (T - Tca8)
            CSO2 = CSO20 / Va8;
            CO2 = 0.21 - (0.21 - CO20) / Va8
            Reaction();
            if (Math.sgn(W - WiK) * Math.sgn(dTiH) > 0) { dTiH = -dTiH / 2 }
        }
        ReactCA[0, J] = J;
        ReactCA[1, J] = X;
        ReactCA[3, J] = T;
        ReactCA[6, J] = Va8 //Определение Хiк опт
        XiH = X;
        TiH = T;
        diX = (1 - X) / 50;
        Tay = 0;
        SFT = 0
        diX = (1 - X) / 100;
        DXS = diX / 6
        Reaction_T_V();
        while (SFT < 0) {
            Tay1 = Tay;
            SFT1 = SFT
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * F12ca
            X = X + diX / 2;
            T = TiH + Tad8 / Va8 * (X - XiH)
            Reaction_T_V();
            Tay = Tay + 4 * DXS / W;
            SFT = SFT + 4 * DXS * F12ca
            X = X + diX / 2;
            T = TiH + Tad8 / Va8 * (X - XiH)
            Reaction_T_V();
            Tay = Tay + DXS / W;
            SFT = SFT + DXS * F12ca
            FT = FT;
            FV = FV;
            T = T
        }
        BB = SFT / (SFT - SFT1)
        X = X - BB * diX;
        T = TiH + Tad8 / Va8 * (X - XiH)
        Reaction();
        Tay = Tay - BB * (Tay - Tay1)
        ReactCA[2, J] = X;
        ReactCA[4, J] = T;
        ReactCA[5, J] = Tay / Va8
        ReactCA[7, J] = Tay;
        ReactCA[8, J] = CSO2;
        ReactCA[9, J] = CO2
            /*
            AA = "    " & Format(ReactCA(0, J), "0") & "     "
            _
                &
                Format(ReactCA(1, J), "0.000") & "     "
            _
                &
                Format(ReactCA(2, J), "0.000") & "     "
            _
                &
                Format(ReactCA(3, J), "000.0") & "     "
            _
                &
                Format(ReactCA(4, J), "000.0") & "      "
            _
                &
                Format(ReactCA(5, J), "0.000") & "      "
            _
                &
                Format(ReactCA(6, J), "0.000")
            List8.AddItem(AA)
            */
        if (J < Ncat8 && X > XK8) { m280(); }
    }
    //Exit Sub
    //Подобрались к XnK?
    if (Math.sgn(X - XK8) * Math.sgn(DX0) > 0) { DX0 = -DX0 / 2 }
    if (Math.abs(X - XK8) > 0.0001 && Math.abs(DX0) > 0.0001) { m280(); }
}

function Reaction_T_V() {
    //dF/dV, df/dT и cкорость реакции W
    Reaction_T()
    FV = (FU - 0.21 * P) / W / (FU - FI) / (1 - 0.5 * CSO2 * X)
    F12ca = FT * (T - Tca8) - FV
}

function Inspection() {
    // Контроль всех данных
    //  Проверка ввода данных реакц. смеси

    var cat_texts = document.getElementsByClassName('form-control');
    tmp_cso2 = new Array();
    tmp_co2 = new Array();
    tmp_p = new Array();

    tmp_t = new Array();
    tmp_k = new Array();
    tmp_e1 = new Array();
    tmp_e2 = new Array();
    tmp_e3 = new Array();
    tmp_t12 = new Array();
    tmp_t21 = new Array();

    tmp_tn = new Array();
    tmp_tk = new Array();
    tmp_st_t = new Array();
    tmp_st_x = new Array();
    tmp_x = new Array();
    tmp_tad = new Array();

    for (var i = 0; i < cat_texts.length; i++) {
        switch (cat_texts[i].id) {
            case "so2":
                tmp_cso2.push(i);
                break;
            case "o2":
                tmp_co2.push(i);
                break;
            case "p":
                tmp_p.push(i);
                break;
            case "t":
                tmp_t.push(i);
                break;
            case "k":
                tmp_k.push(i);
                break;
            case "e1":
                tmp_e1.push(i);
                break;
            case "e2":
                tmp_e2.push(i);
                break;
            case "e3":
                tmp_e3.push(i);
                break;
            case "t12":
                tmp_t12.push(i);
                break;
            case "t23":
                tmp_t21.push(i);
                break;
            case "tn":
                tmp_tn.push(i);
                break;
            case "tk":
                tmp_tk.push(i);
                break;
            case "step-t":
                tmp_st_t.push(i);
                break;
            case "step-x":
                tmp_st_x.push(i);
                break;
            case "xvalue":
                tmp_x.push(i);
                break;
            case "tad":
                tmp_tad.push(i);
        }
    }

    cso2 = cat_texts[tmp_cso2[parseInt(Variable1) - 1]].value.replace(",", ".");
    co2 = cat_texts[tmp_co2[parseInt(Variable1) - 1]].value.replace(",", ".");
    p = cat_texts[tmp_p[parseInt(Variable1) - 1]].value.replace(",", ".");

    if (parseInt(Variable1) > 1) {
        t = cat_texts[tmp_t[parseInt(Variable1) - 2]].value.replace(",", ".");
        k = cat_texts[tmp_k[parseInt(Variable1) - 2]].value.replace(",", ".");
        e1 = cat_texts[tmp_e1[parseInt(Variable1) - 2]].value.replace(",", ".");
        e2 = cat_texts[tmp_e2[parseInt(Variable1) - 2]].value.replace(",", ".");
        e3 = cat_texts[tmp_e3[parseInt(Variable1) - 2]].value.replace(",", ".");
        t12 = cat_texts[tmp_t12[parseInt(Variable1) - 2]].value.replace(",", ".");
        t21 = cat_texts[tmp_t21[parseInt(Variable1) - 2]].value.replace(",", ".");
        x = cat_texts[tmp_x[0]].value.replace(",", ".");
        st_x = cat_texts[tmp_st_x[0]].value.replace(",", ".");
    }
    if (parseInt(Variable1) < 3) {
        tn = cat_texts[tmp_tn[parseInt(Variable1) - 1]].value.replace(",", ".");
        tk = cat_texts[tmp_tk[parseInt(Variable1) - 1]].value.replace(",", ".");
        st_t = cat_texts[tmp_st_t[parseInt(Variable1) - 1]].value.replace(",", ".");
    }

    if (parseInt(Variable1) > 3) {
        tad = cat_texts[tmp_tad[parseInt(Variable1) - 4]].value.replace(",", ".");
    }

    Variable1 = parseInt(Variable1);

    switch (Variable1) {
        case 3:
            xn = document.getElementById("xn_3").value.replace(",", ".");
            xk = document.getElementById("xk_3").value.replace(",", ".");
            break;
        case 4:
            xn = document.getElementById("xn_4").value.replace(",", ".");
            xk = document.getElementById("xk_4").value.replace(",", ".");
            tn = document.getElementById("t_n_4").value.replace(",", ".");
            break;
        case 5:
            xn = document.getElementById("xn_5").value.replace(",", ".");
            tn = document.getElementById("t_n_5").value.replace(",", ".");
            t_au = document.getElementById("t_au_5").value.replace(",", ".");
            break;
        case 6:
            xk = document.getElementById("xk_6").value.replace(",", ".");
            n = document.getElementById("n_6").value.replace(",", ".");
            x1n = document.getElementById("x1n_6").value.replace(",", ".");
            t1n = document.getElementById("t1n_6").value.replace(",", ".");
            break;
        case 7:
            xk = document.getElementById("xk_7").value.replace(",", ".");
            n = document.getElementById("n_7").value.replace(",", ".");
            x1n = document.getElementById("x1n_7").value.replace(",", ".");
            t1n = document.getElementById("t1n_7").value.replace(",", ".");
            txr = document.getElementById("thg_7").value.replace(",", ".");
            break;
        case 8:
            xk = document.getElementById("xk_8").value.replace(",", ".");
            n = document.getElementById("n_8").value.replace(",", ".");
            x1n = document.getElementById("x1n_8").value.replace(",", ".");
            t1n = document.getElementById("t1n_8").value.replace(",", ".");
            txr = document.getElementById("thg_8").value.replace(",", ".");
            break;
        case 9:
            n = document.getElementById("n_9").value.replace(",", ".");
            x1n = document.getElementById("x1n_9").value.replace(",", ".");
            xk = document.getElementById("xk_9").value.replace(",", ".");
            break;
    }


    if (IsNumeric(cso2)) { CSO2 = parseFloat(cso2); } else {
        alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
        return
    }
    CSO20 = CSO2;

    if (IsNumeric(co2)) { CO2 = parseFloat(co2); } else {
        alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
        return
    }
    CO20 = CO2;

    if (IsNumeric(p)) { P = parseFloat(p); } else {
        alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
        return
    }
    if ((parseInt(Variable1) > 1) && (Cat == 0)) {
        alert("Реакция без катализатора?");
        return
    }
    //Корректность данных
    if ((CSO2 <= 0) || (CSO2 >= 1) || (CO2 <= 0) || (CO2 >= 1) || (P <= 0)) {
        alert("Проверьте корректность данных!");
        return

    }

    //Параметры кат-ра

    if (parseInt(Variable1) > 1) {
        if (Cat = 4) {
            // Проверка для нового кат-ра
            if (IsNumeric(t)) { CatDatN[Variable1, 0] = t } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(k)) { CatDatN[Variable1, 1] = k } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(e1)) { CatDatN[Variable1, 2] = e1 } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(e2)) { CatDatN[Variable1, 3] = e2 } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(e3)) { CatDatN[Variable1, 4] = e3 } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(t12)) { CatDatN[Variable1, 5] = t12 } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
            if (IsNumeric(t21)) { CatDatN[Variable1, 6] = t21 } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return }
        }
        Tz = parseFloat(t);
        Kz = parseFloat(k);
        E1 = parseFloat(e1);
        E2 = parseFloat(e2);
        E3 = parseFloat(e3);
        T12 = parseFloat(t12);
        T23 = parseFloat(t21);
        K12 = Kz * Math.exp(E2 / Rgas * (1 / Tz - 1 / T12));
        K23 = Kz * Math.exp(E2 / Rgas * (1 / Tz - 1 / T23));
    }

    // Проверка выбора режима потока
    switch (Variable1) {
        case 4, 5, 6:
            if (Flow == "") {
                alert("Режим движения потока???");
                break;
            }
    }
    switch (Variable1) {
        case 1:
            if (DataVar[1] == "b") {
                A1 = 0.1;
                B1 = 0.1;
                P1 = 1;
                TH1 = 700;
                dT1 = 10;
                TK1 = 900;
                DataVar[1] = "c";
            }
            break;
        case 2:
            if (DataVar[2] == "b") {
                A2 = 0.1;
                B2 = 0.1;
                P2 = 1;
                XH2 = 0.7;
                TH2 = 700;
                dT2 = 10;
                TK2 = 900
                DataVar[2] = "c";
            }
            break;
        case 3:
            if (DataVar[3] == "b") {
                A3 = 0.1;
                B3 = 0.1;
                P3 = 1
                XH3 = 0.5;
                XK3 = 0.99;
                dX3 = 0.01;
                DataVar[3] = "c";
            }
            break;
        case 4:
            if (DataVar[4] == "b") {
                A4 = 0.1;
                B4 = 0.1;
                P4 = 1;
                Tad4 = 200;
                XH4 = 0;
                XK4 = 0.6;
                TH4 = 720;
                Flow4 = "IF";
                DataVar[4] = "c";
            }
            break;
        case 5:
            if (DataVar[5] == "b") {
                A5 = 0.1;
                B5 = 0.1;
                P5 = 1;
                Tad5 = 200;
                XH5 = 0;
                TH5 = 720;
                TayK5 = 0.6;
                Flow5 = "IF";
                DataVar[5] = "c";
            }
            break;
        case 6:
            if (DataVar[6] == "b") {
                A6 = 0.075;
                B6 = 0.11;
                P6 = 1;
                Tad6 = 214;
                Ncat6 = 4;
                XH6 = 0;
                TH6 = 713;
                XK6 = 0.97;
                Flow6 = "FM";
                Cat6 = 1;
                DataVar[6] = "c";
            }
            break;
        case 7:
            if (DataVar[7] == "b") {
                A7 = 0.075;
                B7 = 0.11;
                P7 = 1;
                Tad7 = 214;
                Ncat7 = 5;
                XH7 = 0;
                TH7 = 713;
                XK7 = 0.97;
                Tcg7 = 490;
                Cat7 = 1;
                DataVar[7] = "c";
            }
            break;
        case 8:
            if (DataVar[8] == "b") {
                A8 = 0.085;
                B8 = 0.11;
                P8 = 1;
                Tad8 = 243;
                Ncat8 = 4
                XH8 = 0;
                TH8 = 693;
                XK8 = 0.97;
                Tca8 = 490;
                Cat8 = 2
                DataVar[8] = "c";
            }
            break;
        case 9:
            if (DataVar[9] == "b") {
                A9 = 0.015;
                B9 = 0.06;
                P9 = 1;
                Tad9 = 43;
                Ncat9 = 2;
                XH9 = 0;
                XK9 = 0.9;
                Cat9 = 2;
                DataVar[9] = "c";
            }
            break;
    }
    // Проверка данных по вариантам
    switch (parseInt(Variable1)) {
        case 1: // Xp
            if (IsNumeric(tn)) { TH1 = parseFloat(tn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(st_t)) { dT1 = parseFloat(st_t) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(tk)) { TK1 = parseFloat(tk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((TK1 <= TH1) || (dT1 <= 0)) {
                alert("Проверьте корректность данных!");
                return
            }
            break;

        case 2: // W(T)
            if (IsNumeric(x)) { XH2 = parseFloat(x) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(tn)) { TH2 = parseFloat(tn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(st_t)) { dT2 = parseFloat(st_t) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(tk)) { TK2 = parseFloat(tk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((TK2 <= TH2) || (dT2 <= 0)) {
                alert("Проверьте корректность данных!");
                return
            }
            if ((XH2 <= 0) || (XH2 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            break;

        case 3: // Topt
            if (IsNumeric(x)) { XH3 = parseFloat(xn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xk)) { XK3 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(st_x)) { dX3 = parseFloat(st_x) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XK3 <= XH3) || (dX3 <= 0)) {
                alert("Проверьте корректность данных!");
                return
            }
            if ((XH3 <= 0) || (XH3 >= 1) || (XK3 <= 0) || (XK3 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            break;

        case 4: //  X(tay)
            if (IsNumeric(tad)) { Tad4 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xn)) { XH4 = parseFloat(xn) } else { alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!"); return };

            if (IsNumeric(tn)) { TH4 = parseFloat(tn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xk)) { XK4 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH4 < 0) || (XH4 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((XK4 < 0) || (XK4 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if (XK4 <= XH4) {
                alert("Проверьте корректность данных!");
                return
            }
            X = XH4;
            T = TH4;

            Reaction();
            if (W <= 0) {
                alert("Х > Хравн ?!?");
                return
            }
            X = XK4;
            T = TH4 + Tad4 * (XK4 - XH4);

            Reaction();
            if (W <= 0) {
                alert("Х > Хравн ?!?");
                return
            }
            Flow4 = Flow;
            break;

        case 5: // tay(X)
            if (IsNumeric(tad)) { Tad5 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(x)) { XH5 = parseFloat(xn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(tn)) { TH5 = parseFloat(tn) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(t_au)) { TayK5 = parseFloat(t_au) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH5 < 0) || (XH5 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            X = XH5;
            T = TH5;
            Reaction();

            if (W <= 0) {
                alert("Х > Хравн ?!?");
                return
            }
            if (Flow == "IF") {
                X = XH5;
                T = TH5 + Tad5 / 3;
                Reaction();
                if (W * TayK5 / 100 > 0.05) {
                    alert("О-о-очень большой градиент!");
                    return
                }
            }
            Flow5 = Flow;
            break;

        case 6: // Реактор с ТО
            if (IsNumeric(tad)) { Tad6 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(n)) { Ncat6 = parseFloat(n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(x1n)) { XH6 = parseFloat(x1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (Flow == "IF") {
                if (IsNumeric(t1n)) { TH6 = parseFloat(t1n) } else {
                    alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                    return
                }
            }
            if (IsNumeric(xk)) { XK6 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH6 < 0) || (XH6 >= 1) || (XK6 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if (XK6 <= XH6) {
                alert("Проверьте корректность данных!");
                return
            }
            switch (Flow) {
                case "IF":
                    if ((Ncat6 < 2) || (Ncat6 > 6) || (TH6 < 670) || (TH6 > 770)) {
                        alert("Данные вне допустимого интервала!");
                        return
                    }
                case "FM":
                    if ((Ncat6 < 2) || (Ncat6 > 6)) {
                        alert("Данные вне допустимого интервала!");
                        return
                    }
            }
            Flow6 = Flow;
            break;

        case 7: // Реактор с ХГ
            if (IsNumeric(tad)) { Tad7 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(n)) { Ncat7 = parseFloat(n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(x1n)) { XH7 = parseFloat(x1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(t1n)) { TH7 = parseFloat(t1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(txr)) { Tcg7 = parseFloat(txr) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xk)) { XK7 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH7 < 0) || (XH7 >= 1) || (XK7 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((Ncat7 < 2) || (Ncat7 > 6) || (TH7 < 670) || (TH7 > 770)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((Tcg7 < 350) || (Tcg7 > 670)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if (XK7 <= XH7) {
                alert("Проверьте корректность данных!");
                return
            }
            break;

        case 8: // Реактор с ХВ
            if (IsNumeric(tad)) { Tad8 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(n)) { Ncat8 = parseFloat(n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(x1n)) { XH8 = parseFloat(x1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(t1n)) { TH8 = parseFloat(t1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(txr)) { Tca8 = parseFloat(txr) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xk)) { XK8 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH8 < 0) || (XH8 >= 1) || (XK8 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((Ncat8 < 2) || (Ncat8 > 6) || (TH8 < 670) || (TH8 > 770)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((Tca8 < 350) || (Tca8 > 670)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((XK8 <= XH8)) {
                alert("Проверьте корректность данных!");
                return
            }
            break;

        case 9: // Реактор второй ступени ДК/ДА
            if (IsNumeric(tad)) { Tad9 = parseFloat(tad) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(n)) { Ncat9 = parseFloat(n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(x1n)) { XH9 = parseFloat(x1n) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if (IsNumeric(xk)) { XK9 = parseFloat(xk) } else {
                alert("Вводите цифры! Десятичное число через запятую! Пример: 12,3!");
                return
            }
            if ((XH9 < 0) || (XH9 >= 1) || (XK9 >= 1)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            if ((XK9 <= XH9)) {
                alert("Проверьте корректность данных!");
                return
            }
            if ((Ncat9 < 1) || (Ncat9 > 3)) {
                alert("Данные вне допустимого интервала!");
                return
            }
            break;
    }

}

function Command4_Click() {
    // Расчет - Пуск!
    //  'Выбор варианта расчета
    switch (Variable1) {
        case "1":
            // Xp
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A1 = CSO2;
            B1 = CO2;
            P1 = P;

            Equlibrim();
            break;

        case "2":
            // W(T)
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A2 = CSO2;
            B2 = CO2;
            P2 = P;
            Cat2 = Cat;
            Rate_T();
            break;

        case "3":
            // Topt
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }
            A3 = CSO2;
            B3 = CO2;
            P3 = P;
            Cat3 = Cat;

            T_optimum();
            break;

        case "4":
            // tay(X)
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A4 = CSO2;
            B4 = CO2;
            P4 = P;
            Cat4 = Cat;
            Flow = Flow4;

            Bed_Tay_X();
            break;

        case "5":
            // X(tay)
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A5 = CSO2;
            B5 = CO2;
            P5 = P;
            Cat5 = Cat;
            Flow = Flow5

            Bed_X_Tay();
            break;

        case "6":
            // Реактор с ТО
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A6 = CSO2;
            B6 = CO2;
            P6 = P;
            Cat6 = Cat;
            Flow = Flow6;

            switch (Flow) {
                case "IF":
                    ReactorTO();
                    break;
                case "FM":
                    ReactorTO_FM();
                    break;
            }
            break;

        case "7":
            // Реактор с ХГ
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A7 = CSO2;
            B7 = CO2;
            P7 = P;
            Cat7 = Cat;

            ReactorCG();
            break;

        case "8":
            // Реактор с ХВ
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }

            A8 = CSO20;
            B8 = CO20;
            P8 = P;
            Cat8 = Cat;

            ReactorCA();
            break;

        case "9":
            // Реактор второй ступени ДК/ДА
            Inspection();
            if (Oo == 1) {
                Oo = 0;
                break;
            }
            A9 = CSO20;
            B9 = CO20;
            P9 = P;
            Cat9 = Cat;

            ReactorII_DK();
            break;
    }

    // Command5.Visible = True
}

function Option10_Click() {
    // ИВ
    Flow = "IF"
}

function Option11_Click() {
    // ИС
    Flow = "FM"
}

var flowopt = document.getElementsByClassName('form-check-input');
for (var i = 0; i < flowopt.length; i++) {
    if (flowopt[i].id == "perfect_extrusion") {
        flowopt[i].addEventListener('click', Option10_Click, false);
    }
    if (flowopt[i].id == "perfect_mixing") {
        flowopt[i].addEventListener('click', Option11_Click, false);
    }
}

var start_btns = document.getElementsByClassName('row mx-5 mb-3');
for (var i = 0; i < start_btns.length; i++) {
    start_btns[i].addEventListener('click', Command4_Click, false);
}

// Функция переключения между картинками на главной странице:
// Сначала создается массив значений value и после происходит навигация на событие onchange для checkBox
var checkBoxProgramm = document.getElementsByName('programm');
for (var i = 0; i < checkBoxProgramm.length; i++) {
    checkBoxProgramm[i].addEventListener('change', function() {
        document.querySelector('#so2_img_new').src = './img/so2/' + this.value + '.svg';
    });
}

// Определение текущего положения селектора 
function getSelectedCheckboxValues(name) {
    if (name) {
        const checkboxes = document.querySelectorAll(`input[name="${name}"]:checked`);
        let values = [];
        checkboxes.forEach((checkbox) => {
            values.push(checkbox.value);
        });
        return values;
    }
}

// Обработчик события нажатия на кнопку "Начнем.."
const btnStart = document.querySelector('#btn_start');
btnStart.addEventListener('click', (event) => {
    Variable1 = getSelectedCheckboxValues('programm')[0];
    let pageName = '#Page_' + getSelectedCheckboxValues('programm');
    document.querySelector('#startPage').classList.remove('active');
    document.querySelector(pageName).classList.add('active');
});

// Обработчик события нажатия на кнопку "В начало"
const btnBack = document.querySelector('#btn_back');
btnBack.addEventListener('click', (event) => {
    let pageName = '#Page_' + getSelectedCheckboxValues('programm');
    document.querySelector('#startPage').classList.add('active');
    document.querySelector(pageName).classList.remove('active');
});

// Обработчик события нажатия на кнопку "СОС!"
const btnSOS = document.querySelector('#btn_sos');
btnSOS.addEventListener('click', (event) => {
    window.open('./help-pdf/help_so2.pdf');
    // window.open('https://yandex.ru/');
});