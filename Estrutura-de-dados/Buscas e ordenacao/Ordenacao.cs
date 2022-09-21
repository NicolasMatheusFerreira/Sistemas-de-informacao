using System; 

class Ordenacao {

	static void Imprimir(int[] Vetor) {
		
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write($"{Vetor[i]} ");
		Console.WriteLine();
	}

	static void SelectionSort(int[] Vetor) {
		
		int menor, posicMenor, aux;

		menor = Vetor[0];
		posicMenor = 0;

		for(int i = 0; i<Vetor.Length; i++) {				
			menor = Vetor[i];
			for(int j = i; j<Vetor.Length; j++) {
				if (Vetor[j]<menor) {
					menor = Vetor[j];
					posicMenor = j;
				}
			}						
			aux = Vetor[i];
			Vetor[i] = menor;
			Vetor[posicMenor] = aux;						

			Imprimir(Vetor);
		}
	}

	static void Main(string[] args) {
		
		int[] Vetor = new int[] {110, 78, 43, 3, 2, 55, 98, 21, 30};

		Imprimir(Vetor);
		SelectionSort(Vetor);
		Imprimir(Vetor);
	}
}
