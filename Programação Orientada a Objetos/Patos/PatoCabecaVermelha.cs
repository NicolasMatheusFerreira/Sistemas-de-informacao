using System;

public sealed class PatoCabecaVermelha : Pato, ICabecaVermelha {
	
	public PatoCabecaVermelha() {}
	
	public PatoCabecaVermelha(string nome, bool nadar) :base(nome, nadar) {
	
	}

	override public void Imprimir() {
		Console.WriteLine(getNome());
		Console.WriteLine(getNadar());
		Voar();
	}

	public bool Voar() {
		Console.WriteLine("Ao infinito e alem!!!");
		return true;
	} 
}
