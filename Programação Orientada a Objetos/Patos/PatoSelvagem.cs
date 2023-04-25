using System;

public sealed class PatoSelvagem : Pato {
	
	public PatoSelvagem() {}

	public PatoSelvagem(string nome, bool nadar) :base(nome, nadar) {
	}

	override public void Imprimir() {
		Console.WriteLine(getNome());
		Console.WriteLine(getNadar());
	}
}
