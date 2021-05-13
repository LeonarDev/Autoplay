let pacientes = document.querySelectorAll(".paciente");

pacientes.forEach((paciente) => {
    let tdPeso = paciente.querySelector(".info-peso");
    let tdAltura = paciente.querySelector(".info-altura");
    let tdImc = paciente.querySelector(".info-imc");
    let peso = tdPeso.textContent;
    let altura = tdAltura.textContent;

    let pesoEhValido = validaPeso(peso);
    let alturaEhValida = validaAltura(altura);

    if (!pesoEhValido) {
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido";
        paciente.classList.add("paciente-invalido");
    }

    if (!alturaEhValida) {
        alturaEhValida = false;
        tdImc.textContent = "Altura inválida";
        paciente.classList.add("paciente-invalido");
    }

    if (pesoEhValido && alturaEhValida) {
        let imc = calculaImc(peso, altura);
        tdImc.textContent = imc;
    }
});

let calculaImc = (peso, altura) => {
    let imc = 0;
    imc = peso / (altura * altura);
    return imc.toFixed(2);
}

let validaPeso = (peso) => {
    (peso >= 0 && peso <= 1000) ?  true :  false;
}

let validaAltura = (altura) => {
    (altura >= 0 && altura <= 3.00) ? true : false;
}
