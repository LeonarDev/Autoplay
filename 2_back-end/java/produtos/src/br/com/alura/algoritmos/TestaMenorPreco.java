package br.com.alura.algoritmos;

public class TestaMenorPreco {
	
	public static void main(String[] args) {
		double precos[] = new double[5];
		precos[0] = 1000000;
		precos[1] = 46000;
		precos[2] = 16000;
		precos[3] = 46000;
		precos[4] = 17000;
		
		int indiceDoMaisBarato = 0;
		
		for (int indiceAtual = 0; indiceAtual < precos.length; indiceAtual++) {
			
			if (precos[indiceAtual] < precos[indiceDoMaisBarato]) {
				indiceDoMaisBarato = indiceAtual;				
			}
			
			System.out.println(indiceDoMaisBarato);
			System.out.println(precos[indiceDoMaisBarato]);
		}
	}
}
