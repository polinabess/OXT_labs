var checkBoxProgramm = document.getElementsByName('programm');

for ( var i = 0; i < checkBoxProgramm.length; i++) {
    checkBoxProgramm[i].onchange = changeImage;
}

function changeImage() {
    document.querySelector('#so2_img_new').src = './img/so2/' + this.value + '.svg';
}

function getSelectedCheckboxValues(name) {
    const checkboxes = document.querySelectorAll(`input[name="${name}"]:checked`);
    let values = [];
    checkboxes.forEach((checkbox) => {
        values.push(checkbox.id);
    });
    return values;
}

const btn = document.querySelector('#btn_start');
btn.addEventListener('click', (event) => {
    if (getSelectedCheckboxValues('programm') == 'equilibrium') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#firstPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'reaction-spead') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#secondPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'optimal-temp') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#thirdPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'contact-time') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#fourthPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'degree-of-transformation') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#fifthPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'reactor-promtepl') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#sixthPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'reactor-vvodholgaz') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#seventhPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'reactor-promvvodholvoz') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#eighthPage').classList.add('active');
    }
    else if (getSelectedCheckboxValues('programm') == 'reactor-dkda') {
        document.querySelector('#startPage').classList.remove('active');
        document.querySelector('#ninthPage').classList.add('active');
    }
});


document.querySelector('#btn_back').addEventListener('click', (event) => {
    document.querySelector('#firstPage').classList.remove('active');
    document.querySelector('#secondPage').classList.remove('active');
    document.querySelector('#thirdPage').classList.remove('active');
    document.querySelector('#fourthPage').classList.remove('active');
    document.querySelector('#fifthPage').classList.remove('active');
    document.querySelector('#sixthPage').classList.remove('active');
    document.querySelector('#seventhPage').classList.remove('active');
    document.querySelector('#eighthPage').classList.remove('active');
    document.querySelector('#ninthPage').classList.remove('active');
    document.querySelector('#startPage').classList.add('active');
});