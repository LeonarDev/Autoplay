
public class CriaConta {
	public static void main(String[] args) {
		Conta primeiraConta = new Conta(01, 1234);
		Conta segundaConta = new Conta(02, 4321);
		
		System.out.println("-----------------------------");
		
		primeiraConta.deposita(200);
		System.out.println("Dep�sito realizado. Saldo da primeiraConta atualizado: " + primeiraConta.getSaldo());
		
		segundaConta.deposita(50);
		System.out.println("Dep�sito realizado. Saldo da segundaConta atualizado: " + segundaConta.getSaldo());
	
		System.out.println("-----------------------------");
		
		primeiraConta.saca(10);
		System.out.println("Primeira conta ap�s SAQUE(10) = " + primeiraConta.getSaldo());
		
		System.out.println("-----------------------------");
		
		if (primeiraConta.transfere(50, segundaConta)) {
			System.out.println("Transfer�ncia realizada com sucesso");
		} else {
			System.out.println("Saldo insuficiente para realizar a transfer�ncia");
		}
		
		System.out.println("Primeira conta ap�s TRANSFER�NCIA(50) = " + primeiraConta.getSaldo());
		System.out.println("Segunda conta ap�s TRANSFER�NCIA(50) = " + segundaConta.getSaldo());
	}
}
