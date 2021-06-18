package br.com.alura.algoritmos;

public class TestaSalarios {
	public static void main(String[] args) {
		double salarios[] = new double[4];
		salarios[0] = 3200;
		salarios[1] = 6000;
		salarios[2] = 5000;
		salarios[3] = 2200;
		
		int indiceMenorSalario= 0;
		int indiceMaiorSalario = 0;
		
		for (int i = 0; i < salarios.length; i++) {
			if (salarios[i] < salarios[indiceMenorSalario]) {
				indiceMenorSalario = i;
				System.out.println("O MENOR salário está no índice " + indiceMenorSalario + " e é de R$ " + salarios[indiceMenorSalario]);
			}
			
			if (salarios[i] > salarios[indiceMaiorSalario]) {
				indiceMaiorSalario = i;
				System.out.println("O MAIOR salário está no índice " + indiceMaiorSalario + " e é de R$ " + salarios[indiceMaiorSalario]);
			}
		}
	}
}
