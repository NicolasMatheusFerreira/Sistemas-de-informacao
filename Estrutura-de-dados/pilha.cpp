#include <iostream>
#include "pilha.h"

using namespace std;

		pilha::pilha() {
			tamanho = 0;
			estrutura = new tipoItem[max_itens];
		} // Construtor da classe

		pilha::~pilha() {
			delete [] estrutura;
		} // Destrutor da classe
		
		bool pilha::estaCheia() {

			return (tamanho == max_itens);

		} // Verifica se a pilha está cheia (empty)
		  
		bool pilha::estaVazia() {
			return (tamanho == 0);
		}

		void pilha::Inserir(tipoItem item) {
			if (estaCheia()) {
				cout << "A pilha esta cheia! \n";
				cout << "Nao e possivel inserir este elemento! \n";
			} else {
				estrutura[tamanho++] = item;
			}
		} // Inseri itens da pilha (push)

		void pilha::Remove() {
			
			if (estaVazia()) {
				cout << "Nao e possivel remover itens, a pilha esta vazia! \n";
				cout << "Nao a elemento para ser removido! \n";
				return 0;
			} else {
				tamanho--;
				return estrutura[tamanho];

			}
		} // Remove itens da pilha (pop)
					    
		void pilha::Imprimir() {
			cout << "Pilha: [ ";
			for(int i = 0; i<tamanho; i++) {
				cout << estrutura[i] << " ";
			}
			cout << "]\n";
		}

		int pilha::Tamanho() {
			return tamanho;
		} // Verifica o tamanho da pilha
