using System;

class Buscas {
	static void Imprimir(int[] Vetor) {
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write($"{Vetor[i]}, ");			
		Console.WriteLine();		
	}
	

	static int BuscaSequencialRec(int alvo, int[] Vetor, int i) {
	
		if (i>=0) {
			if (alvo==Vetor[i]) {
				return i;
			} else return BuscaSequencialRec(alvo, Vetor, --i);
		} 
		return -1;
	}

	static int BuscaSequencialIte(int alvo, int[] Vetor) {
	
		for(int i = 0; i<Vetor.Length-1; i++)
			if (alvo==Vetor[i])
				return i;
		return -1;	
	}

	static int BuscaBinariaIte(int alvo, int[] Vetor) {
		
		int inicio = 0, fim = Vetor.Length-1, meio;

		while(inicio<=fim) {
			meio = (inicio+fim)/2;
			if (alvo==Vetor[meio])
				return meio;
			else if (alvo<Vetor[meio]) {
				fim = meio-1;
				inicio = 0;
			} else if (alvo>Vetor[meio]) {
				inicio = meio+1;
				fim = Vetor.Length-1;
			}			
		}
		return -1;
	}

	static int BuscaBinariaRec(int alvo, int[] Vetor, int inicio, int fim) {
	
		int meio = (inicio+fim)/2;
		if (inicio<=fim) {
			if (alvo==Vetor[meio]) {
				return meio;
			} else if (alvo<Vetor[meio]) {							
				return BuscaBinariaRec(alvo, Vetor, inicio, meio-1);
			} else if (alvo>Vetor[meio]) {						
				return BuscaBinariaRec(alvo, Vetor, meio+1, fim);
			}
		}
		return -1;
	}

	static void Main(string[] args) {
		
//		Console.WriteLine(BuscaSequencialRec(int.Parse(Console.ReadLine()), new int[] {2,2,4,7,11,21,23,30,41},8));

		int[] Valores = new int[] {25, 78, 101, 3, 65, 45, 2};

		Imprimir(Valores);
		SelectSort(Valores);
		Imprimir(Valores);
	}
}
