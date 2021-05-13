let pacientes = document.querySelectorAll(".paciente");

for (let index = 0; index < pacientes.length; index++) {
  let paciente = pacientes[index];

  let tdAltura = paciente.querySelector(".info-altura");
  let altura = tdAltura.textContent;

  let tdPeso = paciente.querySelector(".info-peso");
  let peso = tdPeso.textContent;

  let tdImc = paciente.querySelector(".info-imc");

  let alturaEhValida = true;
  let pesoEhValido = true;

  if (peso <= 0 || peso > 1000) {
    pesoEhValido = false;
    tdPeso.textContent = "Peso inválido!";
    paciente.classList.add('paciente-invalido');
  }

  if (altura <= 0 || altura >= 3) {
    alturaEhValida = false;
    tdAltura.textContent = "Altura inválida!";
    paciente.classList.add('paciente-invalido');
  }

  if (alturaEhValida && pesoEhValido) {
    let imc = peso / (altura * altura);
    tdImc.textContent = imc.toFixed(2);
  }
}
