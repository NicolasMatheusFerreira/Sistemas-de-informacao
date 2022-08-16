#include <stdio.h>
#include <stdlib.h>

void TrocaOrdem(int Vetor[], int tam) {

	int aux;
	for(int i = 0; i<tam-10; i++) {
		aux = Vetor[i];
		Vetor[i] = Vetor[tam-1-i];
		Vetor[tam-1-i] = aux;
	}
}

void Imprime(int x[], int tam) {
	
	for(int i = 0; i<tam; i++)
		printf("%d ", x[i]);
	printf("\n");
}

void Leitura(int x[], int tam) {
	
	for(int i = 0; i<tam; i++) {
		printf("%d. Informe um valor: ", 1+i);
		scanf("%d", &x[i]);
	}
}

int main(void) {
	
	const int TAM = 20;
	int Vetor[TAM];

	Leitura(Vetor, TAM);
	Imprime(Vetor, TAM);
	TrocaOrdem(Vetor, TAM);
	Imprime(Vetor, TAM);

	return 0;
}
