using System;
class forBaskara {
    static void Main(){
    float a, b, c, delta, x1, x2;

		Console.WriteLine("\n Digite o Valor de A ");
		a = float.Parse(Console.ReadLine());
		
		// digitando valor 2
		Console.WriteLine("\n Digite o Valor de B ");
		b = float.Parse(Console.ReadLine());
		
		// sigitando valor3
		Console.WriteLine("\n Digite o Valor de C ");
		c = float.Parse(Console.ReadLine());
	

		// calculo de delta, baskara
		delta = b * b - 4 * a * c;// poderia estar usando Math.pow(b,2)ao inves de b*b,
		// delta recebe meu valor de (b*b),que e B ao
		// quadrado - 4* valor de A * valor de C
		if (delta > 0) {// se condicao for verdadeira executa
			x1 = (float) ((-b + Math.Sqrt(delta)) / (2 * a));// x'calculo
			// de
			// x= -b +/-
			// Raiz de delta
			// (div/) por 2 * a

			x2 = (float) ((-b + Math.Sqrt(delta)) / (2 * a));// x"
			// Math.sqrt
			// calcula a
			// raiz, raiz do
			// resultado de
			// delta

			Console.WriteLine("\n Valor de X' e = " + x1
					+ "\n Valor de X'' e = " + x2);

		} else {
			Console.WriteLine("Não e possivel calcular esta Raiz, não e um numero real ");
		}

	}

}