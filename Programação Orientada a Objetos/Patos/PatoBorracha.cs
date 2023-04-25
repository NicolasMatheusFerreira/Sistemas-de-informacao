using System;

public sealed class PatoBorracha : Pato {
	
	public PatoBorracha() {}
	
	public PatoBorracha(string nome, bool nadar) :base(nome, nadar) {
	
	}

	override public void Imprimir() {
		Console.WriteLine(getNome());
		Console.WriteLine(getNadar());
	}
}
