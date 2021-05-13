let campoFiltro = document.querySelector("#filtrar-tabela");

campoFiltro.addEventListener("input", function() {
    let pacientes = document.querySelectorAll(".paciente");

    if (this.value.length > 0) {
        pacientes.forEach((paciente) => {
            let tdNome = paciente.querySelector(".info-nome");
            let nome = tdNome.textContent;
            let expressao = new RegExp(this.value, "i");
    
            expressao.test(nome) ? paciente.classList.remove("invisivel") : paciente.classList.add("invisivel");
        })
    } else {
        for (let i = 0; i < pacientes.length; i++) {
            let paciente = pacientes[i];
            paciente.classList.remove("invisivel");
        }
    }
});

// filtro sem regex:

// ... let nome = tdNome.textContent;

// nome.substr(0, this.value.length);

// let comparavel = nome.substr(0, this.value.length);
// let comparavelMinusculo = comparavel.toLowerCase();
// let valorDigitadoMinusculo = this.value.toLowerCase();

// if (!(valorDigitadoMinusculo == comparavelMinusculo)) {
//     paciente.classList.add("invisivel");
// } else{
//     paciente.classList.remove("invisivel");
// }
