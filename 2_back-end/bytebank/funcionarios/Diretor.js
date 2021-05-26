import Funcionario from "./Funcionario.js";

export default class Diretor extends Funcionario {
  constructor(nome, cpf, salario) {
    super(nome, cpf, salario)
    this._bonificacao = 1.2;
  }
}