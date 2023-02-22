using System; 
using System.Diagnostics;

class Ordenacao {

	static void Imprimir(int[] Vetor) {
		
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write($"{Vetor[i]} ");
		Console.WriteLine();
	}
	
	static void Troca(int[] Vetor, int x, int y) {
		
		int aux = Vetor[x];
		Vetor[x] = Vetor[y];
		Vetor[y] = aux;
	}

	static void InsertionSort(int[] Vetor) {
			
		int chave, j;
		for(int i = 1; i<Vetor.Length; i++) {
			chave = Vetor[i];
			j = i - 1;
			while(j>=0 && Vetor[j]>chave) {
				Vetor[j+1] = Vetor[j];
				j--;
			
				Vetor[j+1] = chave;
			}
		}
			
		Console.WriteLine("Ordenado...!");
		Imprimir(Vetor);
	}

	static void SelectSort(int[] Vetor) {

	    int menor, posicMenor = 0;
	    for(int i = 0; i<Vetor.Length; i++) {
	        menor = Vetor[i];
	        for(int j = i; j<Vetor.Length-1; j++) {
	            if (Vetor[j]<menor) {
	                menor = Vetor[j];
	                posicMenor = j;
	            }
	        }
	        Troca(Vetor, i, posicMenor);
	    }
	}

	static void BubbleSort(int[] Vetor) {

	    for(int i = 0; i<Vetor.Length; i++) {
	        for(int j = 0; j<Vetor.Length-1; j++) {
	            if (Vetor[j]>Vetor[j+1])
	                Troca(Vetor, j, j+1);
	        }
	    }
	}


	static void Main(string[] args) {
		
		Random aleatorio = new Random();
		int[] Valores = new int[10];
		var stopwatch = new Stopwatch();
		stopwatch.Start();

		for(int z = 0; z<Valores.Length; z++)
		    Valores[z] = aleatorio.Next(0,1000);

		Imprimir(Valores);
		//SelectSort(Valores);
		//BubbleSort(Valores);
		Imprimir(Valores);
		stopwatch.Stop();
		Console.WriteLine("Quant. MiliSeg.: {0}", stopwatch.ElapsedMilliseconds);	}
	}
