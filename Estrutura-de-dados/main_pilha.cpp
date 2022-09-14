#include <iostream>
#include "pilha.h"

using namespace std;

int main(void) {

	pilha pilha1;		
	tipoItem item;
	int opcao;

	do {
		cout << "Digite 0 para parar o programa!\n";
		cout << "Digite 1 para inserir um elemento!\n";
		cout << "Digite 2 para remover um elemento!\n";
		cout << "Digite 3 para imprimir a pilha!\n";
		
		cin >> opcao;

		if (opcao==1) {
			cout << "Digite o elemento a ser inserido";
			cin >> item;
			pilha1.Inserir(item);
			cout << "Elemento inserido!";
		} else if (opcao==2) {
			cout << "Digite o elemento a ser removido";
			cin >> item;
			pilha1.Remove();
			cout << item << "Esta removido!";
		} else if (opcao==3) {
			pilha1.Imprimir();
		}
	} while(opcao!=0);
	return 0;
}
