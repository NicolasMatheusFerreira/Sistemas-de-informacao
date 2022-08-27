using System;

class BuscaBinaria {
	
	static int PesqBinIte(int target, int[] Vetor) {
		
		int inicio = 0, fim = Vetor.Length-1, meio = (inicio+fim)/2;

		while(meio!=fim) {
			meio = (inicio+fim)/2;
			if (target==Vetor[meio]) {
				return meio;
			} else if (target<Vetor[meio]) {
					fim = meio-1;
					inicio = 0;
			} else if (target>Vetor[meio]) {
					fim = Vetor.Length-1;
					inicio = meio+1;
			}
		}
		return -1;
	}

	static int PesqBinRec(int target, int[] Vetor, int inicio, int fim) {
		
		int meio, result = 0;

		meio = (inicio+fim)/2;
		if (inicio==fim) {
			if (target==Vetor[meio]) {
				result = meio;				
			} else result = -10;
		} else {
			if (target<Vetor[meio-1]) {
				inicio = 0;
				fim = meio-1;
				result = PesqBinRec(target, Vetor, inicio, fim);
			} else if (target>Vetor[meio+1]) {
				inicio = meio+1;
				fim = Vetor.Length-1;
				result = PesqBinRec(target, Vetor, inicio, fim);
			}
		}
		return result;
	}

	static void Main(string[] args) {

		int[] Vetor = new int[] {1,2,3,4,5};
		Console.WriteLine(PesqBinRec(4, Vetor, 0, Vetor.Length-1));
	}
}
