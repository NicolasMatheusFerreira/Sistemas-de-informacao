public abstract class Pato {
	
	protected string nome;
	protected bool nadar;

	public Pato() {}

	public Pato(string nome, bool nadar) {
		this.nome = nome;
		this.nadar = nadar;
	}

	public void setNome(string nome) {
		this.nome = nome;
	}
	public string getNome() {
		return this.nome;
	}
	public void setNadar(bool nadar) {
		this.nadar = nadar;
	}
	public bool getNadar() {
		return this.nadar;
	}

	abstract public void Imprimir();
}
