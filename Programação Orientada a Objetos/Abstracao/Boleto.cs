using System;

public sealed class Boleto:Pagamento {
	
	protected string idBoleto;
	protected string codigBarras;

	public Boleto() {

		idBoleto = "N/A";
		codigBarras = "N/A";
	}

	public Boleto(string idBoleto, string codigBarras, double valor, DateTime vencimento) :base(valor, vencimento) {

		this.idBoleto = idBoleto;
		this.codigBarras = codigBarras;
	}

	public void setIdBoleto(string idBoleto) {
		this.idBoleto = idBoleto;
	}
	public string getIdBoleto() {
		return this.idBoleto;
	}

	public void setCodigBarras(string codigBarras) {
		this.codigBarras = codigBarras;
	}
	public string getCodigBarras() {
		return this.codigBarras;
	}

	public bool Pagar(DateTime dataAtual, double valor) {
		
		if (valor>=this.valor && DateTime.Compare(dataAtual, vencimento)<0)
			return true;
		
		return false;
	}

	public bool Pagar(DateTime dataAtual, double valor, string codigBarras) {
		
		if (codigBarras.Equals(this.codigBarras)) {
			if (valor>=base.valor && DateTime.Compare(dataAtual, base.vencimento)<0)
				return true;
		}
		return false;
	}



}
