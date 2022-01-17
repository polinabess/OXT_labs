let perfect_extrusion;
let izoterm;
let perfect_mixing;
let adiabat;
let polythrop;
let xtay;
let tayx;
let prostaya_neobratimaya;
let prostaya_obratimaya;
let slozhnaya;

let perfect_extrusion_izoterm_img;
let perfect_extrusion_adiabat_img;
let perfect_extrusion_polythrop_img;
let perfect_mixing_izoterm_img;
let perfect_mixing_adiabat_img;
let perfect_mixing_polythrop_img;

let mm_perfect_extrusion_izoterm;
let mm_perfect_extrusion_adiabat;
let mm_perfect_extrusion_polythrop;
let mm_perfect_extrusion_difficult_reaction_izoterm;
let mm_perfect_extrusion_difficult_reaction_adiabat;
let mm_perfect_extrusion_difficult_reaction_polythrop;
let mm_perfect_simple_mixing_izoterm;
let mm_perfect_mixing_adiabat;
let mm_perfect_mixing_izoterm_difficult;
let mm_perfect_mixing_polythrop;
let mm_perfect_mixing_difficult_reaction_adiabat;
let mm_perfect_mixing_difficult_reaction_polythrop;


let kinetic_equation_simple_unalterable_reaction;
let kinetic_equation_simple_alterable_reaction;
let kinetic_equation_difficult_reaction;

let T;
let tay;
let Tn;
let Xk;
let Xn;
let Yn;

let Tad;
let Tad_one;
let Tad_two;
let B;
let Tx;

let table_for_alterable_reaction;
let table_thermal_parameters;

let K;
let E;
let param_kinetic_models_a;
let param_kinetic_models_b;
let K1;
let E1;
let K2;
let E2;
let K3;
let E3;

//изотремический
let arr_perfect_extrusion_izoterm_xtay_simple_unalterabl_elems; //идеальное вытеснение изотермический xtay простая
// необратимая
let arr_perfect_extrusion_izoterm_tayx_simple_unalterabl_elems; //идеальное вытеснение изотермический tayx простая
// необратимая
let arr_perfect_extrusion_izoterm_xtay_simple_alterabl_elems;  //идеальное вытеснение изотермический xtay простая
// обратимая
let arr_perfect_extrusion_izoterm_tayx_simple_alterabl_elems;   //идеальное вытеснение изотермический tayx простая
// обратимая
let arr_perfect_extrusion_izoterm_xtay_difficult_elems;     //идеальное вытеснение изотермический xtay сложная
let arr_perfect_extrusion_izoterm_tayx_difficult_elems;     //идеальное вытеснение изотермический tayx сложная
let arr_perfect_mixing_izoterm_xtay_simple_unalterabl_elems;    //идеальное смешение изотермический xtay простая
// необратимая DONE
let arr_perfect_mixing_izoterm_tayx_simple_unalterabl_elems;    //идеальное смешение изотермический tayx простая
// необратимая DONE
let arr_perfect_mixing_izoterm_xtay_simple_alterabl_elems;  //идеальное смешение изотермический xtay простая
// обратимая DONE
let arr_perfect_mixing_izoterm_tayx_simple_alterabl_elems;  //идеальное смешение изотермический tayx простая
//  обратимая DONE
let arr_perfect_mixing_izoterm_xtay_difficult_elems;    //идеальное смешение изотермический xtay сложная DONE
let arr_perfect_mixing_izoterm_tayx_difficult_elems;    //идеальное смешение изотермический tayx сложная DONE 


// адиабатический
let arr_perfect_extrusion_adiabat_xtay_simple_unalterabl_elems; //деальное вытеснение адиабатический xtay простая
// необратимая done
let arr_perfect_extrusion_adiabat_tayx_simple_unalterabl_elems; //идеальное вытеснение адиабатический tayx простая
// необратимая done
let arr_perfect_extrusion_adiabat_xtay_simple_alterabl_elems;  //идеальное вытеснение адиабатический xtay простая
// обратимая done
let arr_perfect_extrusion_adiabat_tayx_simple_alterabl_elems;   //идеальное вытеснение адиабатический tayx простая
// обратимая done
let arr_perfect_extrusion_adiabat_xtay_difficult_elems;     //идеальное вытеснение адиабатический xtay сложная done
let arr_perfect_extrusion_adiabat_tayx_difficult_elems;     //идеальное вытеснение адиабатический tayx сложная done
let arr_perfect_mixing_adiabat_xtay_simple_unalterabl_elems;    //идеальное смешение адиабатический xtay простая done
// необратимая
let arr_perfect_mixing_adiabat_tayx_simple_unalterabl_elems;    //идеальное смешение адиабатический tayx простая
// необратимая
let arr_perfect_mixing_adiabat_xtay_simple_alterabl_elems;  //идеальное смешение адиабатический xtay простая
// обратимая
let arr_perfect_mixing_adiabat_tayx_simple_alterabl_elems;  //идеальное смешение адиабатический tayx простая
//  обратимая
let arr_perfect_mixing_adiabat_xtay_difficult_elems;    //идеальное смешение адиабатический xtay сложная
let arr_perfect_mixing_adiabat_tayx_difficult_elems;    //идеальное смешение адиабатический tayx сложная


// политропический
let arr_perfect_extrusion_polythrop_xtay_simple_unalterabl_elems;  //идеальное вытеснение политропический xtay простая
// необратимая
let arr_perfect_extrusion_polythrop_tayx_simple_unalterabl_elems;  //идеальное вытеснение политропический tayx простая
// необратимая
let arr_perfect_extrusion_polythrop_xtay_simple_alterabl_elems;  //идеальное вытеснение политропический xtay простая
// обратимая
let arr_perfect_extrusion_polythrop_tayx_simple_alterabl_elems;   //идеальное вытеснение политропический tayx простая
// обратимая
let arr_perfect_extrusion_polythrop_xtay_difficult_elems;     //идеальное вытеснение политропический xtay сложная
let arr_perfect_extrusion_polythrop_tayx_difficult_elems;     //идеальное вытеснение политропический tayx сложная
let arr_perfect_mixing_polythrop_xtay_simple_unalterabl_elems;    //идеальное смешение политропический xtay простая
// необратимая
let arr_perfect_mixing_polythrop_tayx_simple_unalterabl_elems;    //идеальное смешение политропический tayx простая
// необратимая
let arr_perfect_mixing_polythrop_xtay_simple_alterabl_elems;  //идеальное смешение политропический xtay простая
// обратимая
let arr_perfect_mixing_polythrop_tayx_simple_alterabl_elems;  //идеальное смешение политропический tayx простая
//  обратимая
let arr_perfect_mixing_polythrop_xtay_difficult_elems;    //идеальное смешение политропический xtay сложная
let arr_perfect_mixing_polythrop_tayx_difficult_elems;    //идеальное смешение политропический tayx сложная





let arrElementsToHide;

$(document).ready(function() {
    debugger;
    $(".toggle-accordion").on("click", function() {
        var accordionId = $(this).attr("accordion-id"),
            numPanelOpen = $(accordionId + ' .collapse.in').length;

        $(this).toggleClass("active");

        if (numPanelOpen == 0) {
            openAllPanels(accordionId);
        } else {
            closeAllPanels(accordionId);
        }
    })

    openAllPanels = function(aId) {
        console.log("setAllPanelOpen");
        $(aId + ' .panel-collapse:not(".in")').collapse('show');
    }
    closeAllPanels = function(aId) {
        console.log("setAllPanelclose");
        $(aId + ' .panel-collapse.in').collapse('hide');
    }

});

function start() {

    //создем переменную, в которую возвращается ссылка на объект(элемент) со всеми его атрибутами
    //в документе через селектор ищем input с именами dvizh_potok, который является отмеченым
    let dvizh_potok_checked = document.querySelector('input[name=dvizh_potok]:checked');

    //вызываем функцию и передаем ей контекст элемента dvizh_potok_checked
    //onChangeRadioBtnProcessReactor.call(dvizh_potok_checked);
    // таблица 1 движение потока
    perfect_extrusion = document.querySelector('#perfect_extrusion');
    perfect_mixing = document.querySelector('#perfect_mixing');

    //таблица 2 тепловой режим(изотермический, адиабатический, политропический)
    izoterm = document.querySelector('#izoterm');
    adiabat = document.querySelector('#adiabat');
    polythrop = document.querySelector('#polythrop');

    //таблица 3 расчет (x(tay), tay(x))
    xtay = document.querySelector('#xtay');
    tayx = document.querySelector('#tayx');

    // таблица 4 реакция (простая необратимая, простая обратимая, сложная)
    prostaya_neobratimaya = document.querySelector('#prostaya_neobratimaya');
    prostaya_obratimaya = document.querySelector('#prostaya_obratimaya');
    slozhnaya = document.querySelector('#slozhnaya');

    // схема реактора (картинки)
    perfect_extrusion_izoterm_img = document.querySelector('#perfect_extrusion_izoterm_img');
    perfect_extrusion_adiabat_img = document.querySelector('#perfect_extrusion_adiabat_img');
    perfect_extrusion_polythrop_img = document.querySelector('#perfect_extrusion_polythrop_img');
    perfect_mixing_izoterm_img = document.querySelector('#perfect_mixing_izoterm_img');
    perfect_mixing_adiabat_img = document.querySelector('#perfect_mixing_adiabat_img');
    perfect_mixing_polythrop_img = document.querySelector('#perfect_mixing_polythrop_img');

    // математическая модель (уравнения)
    mm_perfect_extrusion_izoterm = document.querySelector('#mm_perfect_extrusion_izoterm');
    mm_perfect_extrusion_adiabat = document.querySelector('#mm_perfect_extrusion_adiabat');
    mm_perfect_extrusion_polythrop = document.querySelector('#mm_perfect_extrusion_polythrop');
    mm_perfect_extrusion_difficult_reaction_izoterm = document.querySelector('#mm_perfect_extrusion_difficult_reaction_izoterm');
    mm_perfect_extrusion_difficult_reaction_adiabat = document.querySelector('#mm_perfect_extrusion_difficult_reaction_adiabat');
    mm_perfect_extrusion_difficult_reaction_polythrop = document.querySelector('#mm_perfect_extrusion_difficult_reaction_polythrop');
    mm_perfect_simple_mixing_izoterm = document.querySelector('#mm_perfect_simple_mixing_izoterm');
    mm_perfect_mixing_izoterm_difficult = document.querySelector('#mm_perfect_extrusion_difficult_reaction_izoterm');
    mm_perfect_mixing_adiabat = document.querySelector('#mm_perfect_mixing_adiabat');
    mm_perfect_mixing_polythrop = document.querySelector('#mm_perfect_mixing_polythrop');
    mm_perfect_mixing_difficult_reaction_adiabat = document.querySelector('#mm_perfect_mixing_difficult_reaction_adiabat');
    mm_perfect_mixing_difficult_reaction_polythrop = document.querySelector('#mm_perfect_mixing_difficult_reaction_polythrop');

    // кинетическиское уравнение
    kinetic_equation_simple_unalterable_reaction = document.querySelector('#kinetic_equation_simple_unalterable_reaction');
    kinetic_equation_simple_alterable_reaction = document.querySelector('#kinetic_equation_simple_alterable_reaction');
    kinetic_equation_difficult_reaction = document.querySelector('#kinetic_equation_difficult_reaction');

    //таблица 5 условия процесса
    T = document.querySelector('#T');
    tay = document.querySelector('#tay');
    Tn = document.querySelector('#Tn');
    Xk = document.querySelector('#Xk');
    Xn = document.querySelector('#Xn');
    Yn = document.querySelector('#Yn');

    //таблица 6 параметры тепловые
    Tad = document.querySelector('#Tad');
    Tad_one = document.querySelector('#Tad1');
    Tad_two = document.querySelector('#Tad2');
    B = document.querySelector('#B');
    Tx = document.querySelector('#Tx');


    table_for_alterable_reaction = document.querySelector('#table_for_alterable_reaction');
    table_thermal_parameters = document.querySelector('#table_thermal_parameters');

    K = document.querySelector('#K');
    E = document.querySelector('#E');
    param_kinetic_models_a = document.querySelector('#param_kinetic_models_a');
    param_kinetic_models_b = document.querySelector('#param_kinetic_models_b');
    K1 = document.querySelector('#K1');
    E1 = document.querySelector('#E1');
    K2 = document.querySelector('#K2');
    E2 = document.querySelector('#E2');
    K3 = document.querySelector('#K3');
    E3 = document.querySelector('#E3');


    let arrRadioBtnProcessReactor = [
        perfect_extrusion,
        izoterm,
        perfect_mixing,
        adiabat,
        polythrop,
        xtay,
        tayx,
        prostaya_neobratimaya,
        prostaya_obratimaya,
        slozhnaya];

    arrElementsToHide = [
        perfect_extrusion_izoterm_img,
        perfect_extrusion_adiabat_img,
        perfect_extrusion_polythrop_img,
        perfect_mixing_izoterm_img,
        perfect_mixing_adiabat_img,
        perfect_mixing_polythrop_img,
        mm_perfect_extrusion_izoterm,
        mm_perfect_extrusion_adiabat,
        mm_perfect_extrusion_polythrop,
        mm_perfect_extrusion_difficult_reaction_izoterm,
        mm_perfect_extrusion_difficult_reaction_adiabat,
        mm_perfect_extrusion_difficult_reaction_polythrop,
        mm_perfect_simple_mixing_izoterm,
        mm_perfect_mixing_adiabat,
        mm_perfect_mixing_polythrop,
        mm_perfect_mixing_difficult_reaction_adiabat,
        mm_perfect_mixing_difficult_reaction_polythrop,
        mm_perfect_mixing_izoterm_difficult,
        kinetic_equation_simple_unalterable_reaction,
        kinetic_equation_simple_alterable_reaction,
        kinetic_equation_difficult_reaction,
        table_thermal_parameters,
        B,
        Tx,
        T,
        tay,
        Tn,
        Xk,
        Xn,
        Yn,
        Tad,
        Tad_one,
        Tad_two,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3];

    arr_perfect_extrusion_izoterm_xtay_simple_unalterabl_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_izoterm,
        kinetic_equation_simple_unalterable_reaction,
        T,
        Xn,
        tay,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    arr_perfect_extrusion_izoterm_tayx_simple_unalterabl_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_izoterm,
        kinetic_equation_simple_unalterable_reaction,
        T,
        Xn,
        Xk,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    arr_perfect_extrusion_izoterm_xtay_simple_alterabl_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_izoterm,
        kinetic_equation_simple_alterable_reaction,
        T,
        Xn,
        xtay,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    arr_perfect_extrusion_izoterm_tayx_simple_alterabl_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_izoterm,
        kinetic_equation_simple_alterable_reaction,
        T,
        Xn,
        Xk,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    arr_perfect_extrusion_izoterm_xtay_difficult_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_difficult_reaction_izoterm,
        kinetic_equation_difficult_reaction,
        T,
        Xn,
        xtay,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    arr_perfect_extrusion_izoterm_tayx_difficult_elems = [
        perfect_extrusion_izoterm_img,
        mm_perfect_extrusion_difficult_reaction_izoterm,
        kinetic_equation_difficult_reaction,
        T,
        Xn,
        Xk,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];



    arr_perfect_extrusion_adiabat_xtay_simple_unalterabl_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    
    arr_perfect_mixing_izoterm_xtay_simple_unalterabl_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_simple_mixing_izoterm,
        kinetic_equation_simple_unalterable_reaction,
        T,
        Xn,
        tay,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    arr_perfect_mixing_izoterm_tayx_simple_unalterabl_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_simple_mixing_izoterm,
        kinetic_equation_simple_unalterable_reaction,
        T,
        Xn,
        Xk,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    arr_perfect_mixing_izoterm_xtay_simple_alterabl_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_simple_mixing_izoterm,
        kinetic_equation_simple_alterable_reaction,
        T,
        Xn,
        tay,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_mixing_izoterm_tayx_simple_alterabl_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_simple_mixing_izoterm,
        kinetic_equation_simple_alterable_reaction,
        T,
        Xn,
        Xk,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_mixing_izoterm_xtay_difficult_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_mixing_izoterm_difficult,
        kinetic_equation_difficult_reaction,
        T,
        Xn,
        Yn,
        tay,
        K1,
        K2,
        K3,
        E1,
        E2,
        E3
    ];
    
    arr_perfect_mixing_izoterm_tayx_difficult_elems = [
        perfect_mixing_izoterm_img,
        mm_perfect_mixing_izoterm_difficult,
        kinetic_equation_difficult_reaction,
        T,
        Xn,
        Yn,
        Xk,
        K1,
        K2,
        K3,
        E1,
        E2,
        E3
    ];
    
    arr_perfect_extrusion_adiabat_tayx_simple_unalterabl_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    arr_perfect_extrusion_adiabat_xtay_simple_alterabl_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_extrusion_adiabat_tayx_simple_alterabl_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_extrusion_adiabat_xtay_difficult_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        tay,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];
    
    arr_perfect_extrusion_adiabat_tayx_difficult_elems = [
        perfect_extrusion_adiabat_img,
        mm_perfect_extrusion_adiabat,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        Xk,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ]; 
    
    arr_perfect_mixing_adiabat_xtay_simple_unalterabl_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    arr_perfect_mixing_adiabat_tayx_simple_unalterabl_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];
    
    arr_perfect_mixing_adiabat_xtay_simple_alterabl_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_mixing_adiabat_tayx_simple_alterabl_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];
    
    arr_perfect_mixing_adiabat_xtay_difficult_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        tay,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];
    
    arr_perfect_mixing_adiabat_tayx_difficult_elems = [
        perfect_mixing_adiabat_img,
        mm_perfect_mixing_adiabat,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        Xk,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];

    
    arr_perfect_extrusion_polythrop_xtay_simple_unalterabl_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_polythrop,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];  //идеальное вытеснение политропический xtay простая
// необратимая
    
    arr_perfect_extrusion_polythrop_tayx_simple_unalterabl_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_polythrop,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];  //идеальное вытеснение политропический tayx простая
// необратимая
    
    arr_perfect_extrusion_polythrop_xtay_simple_alterabl_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_polythrop,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];  //идеальное вытеснение политропический xtay простая
// обратимая
    
    arr_perfect_extrusion_polythrop_tayx_simple_alterabl_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_polythrop,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];   //идеальное вытеснение политропический tayx простая
// обратимая
    
    arr_perfect_extrusion_polythrop_xtay_difficult_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_difficult_reaction_polythrop,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        tay,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        B,
        Tx,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];     //идеальное вытеснение политропический xtay сложная
    
    arr_perfect_extrusion_polythrop_tayx_difficult_elems = [
        perfect_extrusion_polythrop_img,
        mm_perfect_extrusion_difficult_reaction_polythrop,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        Xk,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        B,
        Tx,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];
    
    arr_perfect_mixing_polythrop_xtay_simple_unalterabl_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_polythrop,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];    //идеальное смешение политропический xtay простая необратимая
    
    arr_perfect_mixing_polythrop_tayx_simple_unalterabl_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_polythrop,
        kinetic_equation_simple_unalterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b
    ];    //идеальное смешение политропический tayx простая необратимая
    
    arr_perfect_mixing_polythrop_xtay_simple_alterabl_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_polythrop,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        tay,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ]; //идеальное смешение политропический xtay простая обратимая
    
    arr_perfect_mixing_polythrop_tayx_simple_alterabl_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_polythrop,
        kinetic_equation_simple_alterable_reaction,
        Tn,
        Xn,
        Xk,
        table_thermal_parameters,
        Tad,
        B,
        Tx,
        K,
        E,
        param_kinetic_models_a,
        param_kinetic_models_b,
        table_for_alterable_reaction
    ];  //идеальное смешение политропический tayx простая обратимая
    
    arr_perfect_mixing_polythrop_xtay_difficult_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_difficult_reaction_polythrop,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        tay,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        B,
        Tx,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ]; //идеальное смешение политропический xtay сложная
    
    arr_perfect_mixing_polythrop_tayx_difficult_elems = [
        perfect_mixing_polythrop_img,
        mm_perfect_mixing_difficult_reaction_polythrop,
        kinetic_equation_difficult_reaction,
        Tn,
        Xn,
        Yn,
        Xk,
        table_thermal_parameters,
        Tad_one,
        Tad_two,
        B,
        Tx,
        K1,
        E1,
        K2,
        E2,
        K3,
        E3
    ];
    
    
    table_for_alterable_reaction.hidden = true;

    arrRadioBtnProcessReactor.forEach((element) => {
        element.addEventListener('change', onChangeRadioBtnProcessReactor);
    });
    onChangeRadioBtnProcessReactor();


    // Обработчик события нажатия на кнопку "СОС!"
    const btnSOS = document.querySelector('#btn_sos');
    btnSOS.addEventListener('click', (event) => {
        window.open('./help-pdf/Reactors_instruction_and_tasks.pdf');
    });


    function visibleElemsOfTable(arrOfElems, isHiden) {
        arrOfElems.forEach((element) => {
            element.hidden = isHiden;
        });
    }

    function onChangeRadioBtnProcessReactor() {
        if (this.checked) {
            console.log("Checkbox is checked..", this.id);
        }
        visibleElemsOfTable(arrElementsToHide, true);
        if (perfect_extrusion.checked && izoterm.checked && xtay.checked && prostaya_neobratimaya.checked) {
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_extrusion.checked && izoterm.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_extrusion.checked && izoterm.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && izoterm.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && izoterm.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_xtay_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && izoterm.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_izoterm_tayx_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && xtay.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && xtay.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_xtay_difficult_elems, false);
        }
        else if (perfect_mixing.checked && izoterm.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_izoterm_tayx_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_xtay_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && adiabat.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_adiabat_tayx_difficult_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && xtay.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_xtay_difficult_elems, false);
        }
        else if (perfect_mixing.checked && adiabat.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_adiabat_tayx_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && xtay.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_xtay_difficult_elems, false);
        }
        else if (perfect_extrusion.checked && polythrop.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_extrusion_polythrop_tayx_difficult_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && xtay.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_xtay_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && tayx.checked && prostaya_neobratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_tayx_simple_unalterabl_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && xtay.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_xtay_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && tayx.checked && prostaya_obratimaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_tayx_simple_alterabl_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && xtay.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_xtay_difficult_elems, false);
        }
        else if (perfect_mixing.checked && polythrop.checked && tayx.checked && slozhnaya.checked){
            visibleElemsOfTable(arr_perfect_mixing_polythrop_tayx_difficult_elems, false);
        }


    }

    function buttonClick() {
        var button = document.querySelector("#button_Raschet");
        button.addEventListener("click", function () {
            console.log("Кнопка нажата.");
        });

        document.getElementById('#btn_raschet').onclick = function () {
            document.getElementById('#perfect_extrusion_izoterm_img').hidden = true;
        }
    }
}
