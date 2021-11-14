// function Hide_Elements(id_el1, id_el2, id_el3, id_el4){
//    //обращение к таблицам по id
//     let dvizh_potok = document.getElementById(id_el1).onchange;
//     let tep_rezh = document.getElementById(id_el2);
//     let raschet = document.getElementById(id_el3);
//     let reaction = document.getElementById(id_el4);
//
//     //обращение к элементам по id
//     let
//
//querySelector
//
// }
//debugger;
//let elem = document.getElementById("para1");
//let checkbox = document.getElementById("perfect_extrusion");



function star() {

    //создем переменную, в которую возвращается ссылка на объект(элемент) со всеми его атрибутами
    //в документе через селектор ищем input с именами dvizh_potok, который является отмеченым
    let dvizh_potok_checked = document.querySelector('input[name=dvizh_potok]:checked');

    //вызываем функцию и передаем ей контекст элемента dvizh_potok_checked
    eventKek.call(dvizh_potok_checked);
    let perfect_extrusion = document.querySelector('#perfect_extrusion');
    let perfect_mixing = document.querySelector('#perfect_mixing');

    //подписываемся на событие клика для  элемента input с id = perfect_extrusion
    perfect_extrusion.onchange = function(){
        // вызываем функцию и передаем ей контекст вызова обрабатываемого элемента(из строки выше)
        eventKek.call(this);
    };
    //подписываемся на событие клика для  элемента input с id = perfect_mixing
    perfect_mixing.onchange = function(){
        // вызываем функцию и передаем ей контекст вызова обрабатываемого элемента(из строки выше)
        eventKek.call(this);
    };
}

function eventKek() {
    if (this.checked) {
        console.log("Checkbox is checked..", this.id);
    }
}

//document.querySelector('#perfect_extrusion').onchange = () => {
//// твой код тут
//    checkbox.addEventListener('change', eventKek());
//    console.log(checkbox, 'это мое болото')
//};
// 
//function eventKek() {
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
