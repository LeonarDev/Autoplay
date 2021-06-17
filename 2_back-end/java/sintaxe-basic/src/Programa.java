
public class Programa {

	public static void main(String[] args) {
		System.out.println("Ol�, Java maldito");
		
		/* ATALHO PARA O print
		digitar "sysout" e apertar CTRL+SPACE */
		
		int idade = 30;
		System.out.println("idade = " + idade);
		
		double pi = 3.14;
		System.out.println("pi = " + pi);
		
		int divisaoDeInteiros = 5 / 2;
		System.out.println("Divis�o de inteiros: 5 / 2 = " + divisaoDeInteiros);
		
		double divisaoDeDoubles = 5.0 / 2;
		System.out.println("Divis�o com doubles: 5 / 2 = " + divisaoDeDoubles);
		
		double salario = 2650.5;
		int valor = (int) salario; //casting
		System.out.println("valor = " + valor);
		
		long numeroGrande = 2322323232L;
		System.out.println("numero grande = " + numeroGrande);
		
		char letra = 'a';
		System.out.println("caractere = " + letra);
		
		String palavra = "alura cursos online de tecnologia";
		System.out.println("frase = " + palavra);
		
		
		//CONDICIONAL
		int quantidadePessoas = 3;
		boolean acompanhado = quantidadePessoas >= 2;
		
		if (acompanhado) 
			System.out.println(acompanhado); //true
		
		//SWITCH CASE
        int mes = 10;

        switch (mes) {
            case 1:
                System.out.println("O m�s � Janeiro");
                break;
            case 2:
                System.out.println("O m�s � Fevereiro");
                break;
            case 3:
                System.out.println("O m�s � Mar�o");
                break;
            case 4:
                System.out.println("O m�s � Abril");
                break;
            case 5:
                System.out.println("O m�s � Maio");
                break;
            case 6:
                System.out.println("O m�s � Junho");
                break;
            case 7:
                System.out.println("O m�s � Julho");
                break;
            case 8:
                System.out.println("O m�s � Agosto");
                break;
            case 9:
                System.out.println("O m�s � Setembro");
                break;
            case 10:
                System.out.println("O m�s � Outubro");
                break;
            case 11:
                System.out.println("O m�s � Novembro");
                break;
            case 12:
                System.out.println("O m�s � Dezembro");
                break;
            default:
                System.out.println("M�s inv�lido");
                break;
        }
        
        //LA�OS ENCADEADOS
        for(int multiplicador = 1; multiplicador <= 10; multiplicador++) {
            for(int contador = 0; contador <= 10; contador++) {
                System.out.print(multiplicador * contador);
                System.out.print(" ");
            }
            System.out.println();
        }
        
        
        //
        for(int linha = 0; linha < 10; linha++) {
            for(int coluna = 0; coluna <= linha; coluna++) {
                System.out.print("*");
            }
            System.out.println();
        }
	}
}
