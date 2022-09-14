#include <iostream>

using namespace std;

typedef int tipoItem; 
const int max_itens = 100; 

class pilha {
              
        private: 
                int tamanho; 
                int* estrutura; 
        public:

		pilha(); // Construtor da classe

		~pilha(); // Destrutor da classe
		
		bool estaCheia(); // Verifica se a pilha está cheia (empty)

		void Inserir(tipoItem item); // Inseri itens da pilha (push)

		void Remove(); // Remove itens da pilha (pop)
					    
		void Imprimir();

		int Tamanho(); // Verifica o tamanho da pilha			       
};

