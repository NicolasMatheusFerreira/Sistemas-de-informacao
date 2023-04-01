class Livro {

	// Atributos
	
	private string titulo, autor, genero;
	private int ano;

	// Construtor padrão
	public Livro() {

		autor = "N/A";
		titulo = "N/A";
		genero = "N/A";
		ano = 0;
	}

	public Livro(string titulo, string autor, string genero, int ano) {
		
		this.titulo = titulo;
		this.autor = autor;
		this.genero = genero;
		this.ano = ano;
	}

	// Métodos getters e setters

	public string Titulo {get {return this.titulo;} set {this.titulo = value;}}
	public string Autor {get{return this.autor;} set{this.autor = value;}}
	public string Genero {get {return this.genero;} set {this.genero = value;}}
	public int Ano {get {return this.ano;} set {this.ano = value;}}
}
