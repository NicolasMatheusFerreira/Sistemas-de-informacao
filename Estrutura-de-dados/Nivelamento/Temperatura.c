#include <stdio.h>
#include <stdlib.h>

float MaiorTemperatura(float x[], int y) {
	
	float maior = x[0];

	y++;
	while(y!=12-1) {
		if (x[y]>maior)
			maior = x[y];
		y++;
	}
	return maior;
}

void Impressao(float x[], int y, char z[]) {
	
	for(int i = 0; i<y; i++)
		printf("Mes %d Temperatura registrada: %.1f\n", z[i], x[i]);
}

void Entrada(float x[], int y, char z[]) {

	int i = 0;
	while(i<y) {
		printf("Mes %s. Informe sua temperatura: ", z[i]);
		scanf("%f", &x[i++]);	
	}
}

int main(void) {
	
	const int qtdTemperaturas = 12;
	float temperaturas[qtdTemperaturas];

	char meses[][101] = {"Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

	Entrada(temperaturas, qtdTemperaturas);
	Impressao(temperaturas, qtdTemperaturas);
	printf("%f", MaiorTemperatura(temperaturas, 0));

	return 0;
}
