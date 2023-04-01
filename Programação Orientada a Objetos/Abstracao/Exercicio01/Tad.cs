using System;

class Tad {
	
	public static void Busca(Livro[] livros) {

	    Console.WriteLine("(P). Busca por ano de publicacao.\n(A). Busca por autor.");
	    Console.Write("Opcao: ");
	    char op = Char.ToLower(Console.ReadLine()[0]);
		
	    switch (op) {
		case 'p':
			Console.Write("Ano de publicacao: ");
			int x = int.Parse(Console.ReadLine());

			x = BuscaBinariaAnoPublicacao(livros, x, 0, livros.Length-1);

			if (x!=-1)
				Console.WriteLine($"{livros[x].Titulo} - {livros[x].Autor} - {livros[x].Genero} - {livros[x].Ano}");
			else Console.WriteLine("Titulo nao encontrado!");
		break;
	    	case 'a':
		    	Console.Write("Autor: ");
			string autor = Console.ReadLine();
			int x = BuscaSequencialAutor(livros, autor);

			if (x!=-1)
				Console.WriteLine($"{livros[x].Titulo} - {livros[x].Autor} - {livros[x].Genero} - {livros[x].Ano}");
			else Console.WriteLine("Titulo nao encontrado!");
	    	break;
	  }
	}

	public static int BuscaSequencialAutor(Livro[] livros, string autor) {
		for(int q = 0; q<livros.Length; q++)
			if (livros[q].Autor.Equals(autor))
				return q;
		return -1;
	}

	public static int BuscaBinariaAnoPublicacao(Livro[] livros, int anoPublicacao, int inic, int fim) {

		int meio, result;

		meio = (inic+fim)/2;
		if (inic!=fim) {		
			if (livros[meio].Ano==anoPublicacao)
				return meio;
			else if (livros[meio].Ano<anoPublicacao) {
				inic = meio + 1;
				result = BuscaBinariaAnoPublicacao(livros, anoPublicacao, inic, fim);
			} else {
				fim = meio - 1;
				result = BuscaBinariaAnoPublicacao(livros, anoPublicacao, inic, fim);
			}		
		} else return -1;
		return result;
	}

	public static void SelectionSortDataPublicacao(Livro[] livros) {
	
		for(int i = 0; i<livros.Length-1; i++) {
			for(int j = i+1; j<livros.Length; j++) {
				if (livros[j].Ano<livros[i].Ano) {
					Livro aux = livros[i];
					livros[i] = livros[j];
					livros[j] = aux;
				}
			}
		}
	}

	public static int Ocorrencia(Livro[] livros, string genero) {
		
		int qtdOcorrencias = 0;

		for(int y = 0; y<livros.Length; y++)
			if (livros[y].Genero.Equals(genero))
				qtdOcorrencias++;
		return qtdOcorrencias;
	}

	public static void Listar(Livro[] livros) {
		
		for(int w = 0; w<livros.Length; w++)
			Console.WriteLine($"{livros[w].Titulo} - {livros[w].Autor} - {livros[w].Genero} - {livros[w].Ano}");
	}

	public static void Executa() {
		
	    Livro[] livros = new Livro[5];
	 
	    livros[0] = new Livro("Harry Potter e a pedra filosofal", "J. K. Rowling", "fantasia", 1997);
	    livros[1] = new Livro("Eu robô", "Isaac Asimov", "ficção-ciêntifica", 1950);
	    livros[2] = new Livro("Guerra e paz","Liev Tolstói", "drama", 1869);
	    livros[3] = new Livro("Extraordinário", "R. J. Palacio", "fatos-reais", 2012);
	    livros[4] = new Livro("As crônicas de nárnia", "C. S. Lewis", "fantasia", 1949);

	    
	    // 	Ordena vetor de Livro
	    SelectionSortDataPublicacao(livros);

	    Console.WriteLine("Ordenado por ano de publicacao.");
	    Listar(livros);	 

	    Console.Write("\n\n");	    	
	    Busca(livros);	    
	}
}
