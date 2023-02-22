using System;

class InverterPalavra {
	
	static string InvertePalavraRec(string palavra, int x) {
	
		string resultado="";
		if (x==0) {
			return ""+palavra[x];
		} else {
//			Console.WriteLine(x);
			resultado = palavra[x] + InvertePalavraRec(palavra, x-1);
		}
		return resultado;
	}

	static string InvertePalavraIte(string x) {
		
		string inverso="";
		for(int i = x.Length-1; i>=0; i--)
			inverso += x[i];
		return inverso;
	}

	static void Main(string[] args) {
	
		string palavra;
		Console.WriteLine("Inverte Palavra.");
		Console.Write("Informe palavra: ");
		palavra = Console.ReadLine();
		Console.WriteLine(InvertePalavraRec(palavra, palavra.Length-1));
	}
}
