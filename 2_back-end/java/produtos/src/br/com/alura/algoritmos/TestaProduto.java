package br.com.alura.algoritmos;
public class TestaProduto {
	public static void main(String[] args) {
		
		Produto[] produtos = {
			new Produto("Lamborghini", 1000000),
			new Produto("Jipe", 46000),
			new Produto("Brasília", 16000),
			new Produto("Smart", 46000),
			new Produto("Fusca", 17000)
		};
		
		int indiceMenorPreco = 0;
		int indiceMaiorPreco = 0;
		
		for (int indice = 0; indice < produtos.length; indice++) {
			System.out.println("Indice " + indice + ", preço: " + produtos[indice].getPreco());

			if (produtos[indice].getPreco() < produtos[indiceMenorPreco].getPreco()) {
				indiceMenorPreco = indice;
				System.out.println("O carro com MENOR preço é " + produtos[indiceMenorPreco].getNome() + " custando " + produtos[indiceMenorPreco].getPreco());
			};
			
			if (produtos[indice].getPreco() >= produtos[indiceMaiorPreco].getPreco()) {
				indiceMaiorPreco = indice;
				System.out.println("O carro com MAIOR preço é " + produtos[indiceMaiorPreco].getNome() + " custando " + produtos[indiceMaiorPreco].getPreco());
			};
		}
	}
}
