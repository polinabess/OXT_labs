// Функция переключения между картинками на главной странице:
// Сначала создается массив значений value и после происходит навигация на событие onchange для checkBox
var checkBoxProgramm = document.getElementsByName('programm');
for ( var i = 0; i < checkBoxProgramm.length; i++) {
    checkBoxProgramm[i].addEventListener('change', function() {
        document.querySelector('#so2_img_new').src = './img/so2/' + this.value + '.svg';
    });   
}

// Определение текущего положения селектора 
function getSelectedCheckboxValues(name) {
    const checkboxes = document.querySelectorAll(`input[name="${name}"]:checked`);
    let values = [];
    checkboxes.forEach((checkbox) => {
        values.push(checkbox.value);
    });
    return values;
}

// Обработчик события нажатия на кнопку "Начнем.."
const btnStart = document.querySelector('#btn_start');
btnStart.addEventListener('click', (event) => {
    let pageName = '#Page_'+getSelectedCheckboxValues('programm');
    document.querySelector('#startPage').classList.remove('active');
    document.querySelector(pageName).classList.add('active');
});

// Обработчик события нажатия на кнопку "В начало"
const btnBack = document.querySelector('#btn_back');
btnBack.addEventListener('click', (event) => {
    let pageName = '#Page_'+getSelectedCheckboxValues('programm');
    document.querySelector('#startPage').classList.add('active');
    document.querySelector(pageName).classList.remove('active');
});