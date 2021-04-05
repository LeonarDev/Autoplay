var pacientes = document.querySelectorAll(".paciente");

for (let index = 0; index < pacientes.length; index++) {
  var paciente = pacientes[index];

  var tdAltura = paciente.querySelector(".info-altura");
  var altura = tdAltura.textContent;

  var tdPeso = paciente.querySelector(".info-peso");
  var peso = tdPeso.textContent;

  var tdImc = paciente.querySelector(".info-imc");

  var alturaEhValida = true;
  var pesoEhValido = true;

  if (peso <= 0 || peso > 1000) {
    console.log("Peso inválido!");
    pesoEhValido = false;
    tdPeso.textContent = "Peso inválido!";
    paciente.classList.add('paciente-invalido');
  }

  if (altura <= 0 || altura >= 3) {
    console.log("Altura inválida!");
    alturaEhValida = false;
    tdAltura.textContent = "Altura inválida!";
    paciente.classList.add('paciente-invalido');
  }

  if (alturaEhValida && pesoEhValido) {
    var imc = peso / (altura * altura);
    tdImc.textContent = imc.toFixed(2);
  }
}

