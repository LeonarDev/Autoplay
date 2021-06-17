public class Cliente {
	private String nome;
	private String cpf;
	
	public String getNome() {
		return nome;
	}
	
	public void setNome(String nome) {
		if (!nome.contains(" ")) this.nome = nome;
	}
	
	public String getCpf() {
		return cpf;
	}
	
	public void setCpf(String cpf) {
		if (cpf.length() == 11) this.cpf = cpf;
	}
}
