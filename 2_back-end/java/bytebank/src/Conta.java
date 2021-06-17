public class Conta {
	private double saldo;
	private int agencia;
	private int numero;
	private Cliente titular;
	private static int totalContas;
	
	public Conta(int agencia, int numero) {
		if (agencia > 0 || numero > 0) {
			totalContas++;
			this.agencia = agencia;
			this.numero = numero;		
			System.out.println("Conta criada com sucesso, agência: " + 
					this.agencia + ", conta: " + this.numero + ", saldo: " + this.saldo);
			System.out.println("Foram criadas " + totalContas + " contas no total.");
		}
	}
	
	public void deposita(double valor) {
		this.saldo += valor;
	}
	
	public boolean saca(double valor) {
		if (this.saldo >= valor) {
			this.saldo -= valor;
			return true;
		} else {
			return false;
		}
	}
		
	public boolean transfere(double valor, Conta destino) {
		saca(valor);
		destino.deposita(valor);
		return true;
	}
	
	public double getSaldo() {
		return this.saldo;
	}
	
	public int getAgencia() {
		return this.agencia;
	}
	
	/* Uma conta é criada já com um número de agência e conta (no constructor), não podendo ser alterarada após criada
	
	public void setAgencia(int agencia) {
		if (agencia > 0) this.agencia = agencia;
	}
	*/
	
	public int getNumero() {
		return this.numero;
	}
	
	/* Uma conta é criada já com um número de agência e conta (no constructor), não podendo ser alterarada após criada
	
	public void setNumero(int numero) {
		if (numero > 0) this.numero = numero;
	}
	*/
	
	public Cliente getTitular() {
		return this.titular;
	}
	
	public void setTitular(Cliente titular) {
		this.titular = titular;
	}
}