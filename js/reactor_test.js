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
let mm_perfect_simple_and_difficult_mixing_izoterm;
let mm_perfect_mixing_adiabat;
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

let table_for_alterable_reaction;

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
    mm_perfect_simple_and_difficult_mixing_izoterm = document.querySelector('#mm_perfect_simple_and_difficult_mixing_izoterm');
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


    table_for_alterable_reaction = document.querySelector('#table_for_alterable_reaction');

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

    let arrElementsToHide = [
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
        mm_perfect_simple_and_difficult_mixing_izoterm,
        mm_perfect_mixing_adiabat,
        mm_perfect_mixing_polythrop,
        mm_perfect_mixing_difficult_reaction_adiabat,
        mm_perfect_mixing_difficult_reaction_polythrop,
        kinetic_equation_simple_unalterable_reaction,
        kinetic_equation_simple_alterable_reaction,
        kinetic_equation_difficult_reaction,
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

//     let arrImgsOfReactor = [
//         perfect_extrusion_izoterm_img,
//         perfect_extrusion_adiabat_img,
//         perfect_extrusion_polythrop_img,
//         perfect_mixing_izoterm_img,
//         perfect_mixing_adiabat_img,
//         perfect_mixing_polythrop_img];
//
//     let arrFormulsOfMathModel = [
//         mm_perfect_extrusion_izoterm,
//         mm_perfect_extrusion_adiabat,
//         mm_perfect_extrusion_polythrop,
//         mm_perfect_extrusion_difficult_reaction_izoterm,
//         mm_perfect_extrusion_difficult_reaction_adiabat,
//         mm_perfect_extrusion_difficult_reaction_polythrop,
//         mm_perfect_simple_and_difficult_mixing_izoterm,
//         mm_perfect_mixing_adiabat,
//         mm_perfect_mixing_polythrop,
//         mm_perfect_mixing_difficult_reaction_adiabat,
//         mm_perfect_mixing_difficult_reaction_polythrop];
//
//
//     let arrKineticEquation = [
//         kinetic_equation_simple_unalterable_reaction,
//         kinetic_equation_simple_alterable_reaction,
//         kinetic_equation_difficult_reaction];
//
//     let arrConditionsOfProcess = [
//         T,
//         tay,
//         Tn,
//         Xk,
//         Xn,
//         Yn];
//
//     let arrThermalParams = [
//         Tad,
// //B,
//         Tad1,
// //Tx,
//         Tad2];

    function closeElemsOfTable(arrOfElems){
        arrOfElems.forEach((element) => {
            element.hidden = true;
        });
    }
    closeElemsOfTable(arrElementsToHide);
    table_for_alterable_reaction.hidden = true;



    debugger;
    arrRadioBtnProcessReactor.forEach((element) => {
        element.addEventListener('change', onChangeRadioBtnProcessReactor);
    });

    // perfect_extrusion.onchange();
    // return;
    // //подписываемся на событие клика для  элемента input с id = perfect_extrusion
    // perfect_extrusion.onchange = function(){
    //     // вызываем функцию и передаем ей контекст вызова обрабатываемого элемента(из строки выше)
    //     onChangeRadioBtnProcessReactor.call(this);
    // };
    // //подписываемся на событие клика для  элемента input с id = perfect_mixing
    // perfect_mixing.onchange = function(){
    //     // вызываем функцию и передаем ей контекст вызова обрабатываемого элемента(из строки выше)
    //     onChangeRadioBtnProcessReactor.call(this);
    // };

    // Обработчик события нажатия на кнопку "СОС!"
    const btnSOS = document.querySelector('#btn_sos');
    btnSOS.addEventListener('click', (event) => {
        window.open('./help-pdf/Reactors_instruction_and_tasks.pdf');
    });

    // let exampleModal = document.getElementById('exampleModal')
    //
    // exampleModal.addEventListener('show.bs.modal', function (event) {
    //     console.log(event);
    // })
    // $('#exampleModal').on('show.bs.modal', function (event) {
    //     var button = $(event.relatedTarget) // Button that triggered the modal
    //     var recipient = button.data('whatever') // Extract info from data-* attributes
    //     // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    //     // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    //     var modal = $(this)
    //     modal.find('.modal-title').text('New message to ' + recipient)
    //     modal.find('.modal-body input').val(recipient)
    // });
    // $("#exampleModal").on("shown.bs.modal", function (event) {
    //     //alert('Hi');
    // });
    // $("#exampleModal").modal('show');
    //
    // const btnStart = document.querySelector('#btn_start');
    // btnStart.addEventListener('click', (event) => {
    //     let pageName = '#Page_'+getSelectedCheckboxValues('programm');
    //     document.querySelector('#startPage').classList.remove('active');
    //     document.querySelector(pageName).classList.add('active');
    // });
}

function onChangeRadioBtnProcessReactor() {
    if (this.checked) {
        console.log("Checkbox is checked..", this.id);
    }
    if(perfect_extrusion.checked && izoterm.checked && xtay.checked && prostaya_neobratimaya.checked){

    }
}

function buttonClick(){
    var button = document.querySelector("#button_Raschet");
    button.addEventListener("click", function() {
        console.log("Кнопка нажата.");
    });

    document.getElementById('#btn_raschet').onclick = function() {
        document.getElementById('#perfect_extrusion_izoterm_img').hidden = true;
    }
}
//document.querySelector('#perfect_extrusion').onchange = () => {
//// твой код тут
//    checkbox.addEventListener('change', onChangeRadioBtnProcessReactor());
//    console.log(checkbox, 'это мое болото')
//};
// 
//function onChangeRadioBtnProcessReactor() {
//    debugger;
//   if (this.checked) {
//     console.log("Checkbox is checked..");
//   } else {
//     console.log("Checkbox is not checked..");
//   }
// }

//class Reactors {
//
//
//}
