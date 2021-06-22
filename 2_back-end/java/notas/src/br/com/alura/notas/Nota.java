package br.com.alura.notas;

public class Nota {
	
	private String aluno;
    private double valor;
    
    public Nota(String aluno, double valor) {
        this.aluno = aluno;
        this.valor = valor;
    }

	public String getAluno() {
		return aluno;
	}
	
	public double getValor() {
		return valor;
	}
}
