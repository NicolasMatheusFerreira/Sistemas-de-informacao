#include <stdio.h>
#include <stdlib.h>

void Imprime(int qtd[], float produtos[], float valorUnitario[], float valorTotal, float salario, int maisVendido, int TAM) {

	for(int q = 0; q<TAM; q++)
		printf("Quant.: %d - Valor Unit.: R$ %.2f - Valor Total: R$ %.2f\n", qtd[q], produtos[q], valorUnitario[q]);
	printf("Valor final: R$ %.2f\n", valorTotal);
	printf("Acressimo: R$ %.2f", salario);
	
	for(int j = 0; j<TAM; j++)
		if (qtd[j]==maisVendido)
			printf("Produto. %d Preco: R$ %.2f", 1+j, valorUnitario[j]);
}

int main(void) {

	const int TAM = 10;
	int qtd[TAM], maisVendido = 0;
	float produtos[TAM], valorUnitario[TAM];
	float salario = 1100, valorTotal, acressimo = 5;

	valorTotal = 0;
	for(int k = 0; k<TAM; k++) {
		
		printf("Produto %d. ", k+1);
		scanf("%f", &produtos[k]);
		printf("Quant.: ");
		scanf("%d", &qtd[k]);
		
		if (qtd[k]>maisVendido)
			maisVendido = qtd[k];

		valorUnitario[k] = produtos[k]*qtd[k];
		valorTotal = valorTotal + valorUnitario[k];
	}

	acressimo /= 100*valorTotal;
	salario += acressimo;
	Imprime(qtd, produtos, valorUnitario, valorTotal, salario, maisVendido, TAM);
	return 0;
}
