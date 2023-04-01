using System;

public abstract class Pagamento {
	
	protected DateTime vencimento;
	protected double valor;

	public Pagamento() {
		vencimento = new DateTime(2001, 03, 13, 7, 0, 0);
		valor = 0.0;
	}

	public Pagamento(double valor, DateTime vencimento) {
		this.vencimento = vencimento;
		this.valor = valor;
	}

	public void setVencimento(DateTime vencimento) {
		this.vencimento = vencimento;
	}
	public DateTime getVencimento() {
		return this.vencimento;
	}

	public void setValor(double valor) {
		this.valor = valor;
	}
	public double getValor() {
		return this.valor;
	}

	public virtual bool Pagar(DateTime dataAtual, double valor) {
		
		if (valor>=this.valor && DateTime.Compare(dataAtual, vencimento)<0)
			return true;
		return false;
	}
}
