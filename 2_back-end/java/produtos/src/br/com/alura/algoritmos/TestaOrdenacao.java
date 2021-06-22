package br.com.alura.algoritmos;

public class TestaOrdenacao {
	
	public static void main(String[] args) {
		Produto produtos[] = {
            new Produto("Lamborghini", 1000000),
            new Produto("Jipe", 46000),
            new Produto("Brasília", 16000),
            new Produto("Smart", 46000),
            new Produto("Fusca", 17000)
        };
		
		ordena(produtos, produtos.length);

        for (Produto produto : produtos) {
            System.out.println(produto.getNome() + " custa " + produto.getPreco());
        }
    }
	
	private static void ordena(Produto[] produtos, int qtdElementos) {
		for (int atual = 0; atual < qtdElementos - 1; atual++) {
            int menor = buscaMenor(produtos, atual, qtdElementos - 1);
            Produto produtoAtual = produtos[atual];
            Produto produtoMenor = produtos[menor];
            produtos[atual] = produtoMenor;
            produtos[menor] = produtoAtual;
        }
	}

    private static int buscaMenor(Produto[] produtos, int inicio, int termino) {
        int maisBarato = inicio;
        for (int atual = inicio; atual <= termino; atual++) {
            if (produtos[atual].getPreco() < produtos[maisBarato].getPreco()) {
                maisBarato = atual;
            }
        } 
        return maisBarato;
	}
}
