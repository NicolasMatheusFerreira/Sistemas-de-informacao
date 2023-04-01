using System;

namespace Aula01
{
    abstract class Pessoa {
    	
	    protected string nome;
	    protected string cpf;	    
	    protected string rg;
	    protected string telefone;
	    protected string endereco;
	    protected int idade; 

	    public Pessoa() {
	    	nome = "N/A";
		cpf = "N/A";
		rg = "N/A";
		telefone = "N/A";
		endereco = "N/A";
		idade = 0;
	    }	   
	    public Pessoa(string nome, string cpf, string rg, string telefone, string endereco, int idade) {
	    	this.nome = nome;
		this.cpf = cpf;
		this.rg = rg;
		this.telefone = telefone;
		this.endereco = endereco;
		this.idade = idade;
	    }

	    public string Nome {get {return this.nome;} set {this.nome = value;}}
	    public string Cpf {get {return this.cpf;} set {this.cpf = value;}}
	    public string Rg {get {return this.rg;} set {this.rg = value;}}
	    public string Telefone {get {return this.telefone;} set {this.telefone = value;}}
	    public string Endereco {get {return this.endereco;} set {this.endereco = value;}}
	    public int Idade {get {return this.idade;} set {this.idade = value;}}
    }

    class Funcionario : Pessoa {
    	
	    protected string empresa;
	    protected double salario;
	   
	   public Funcionario() {
	   	empresa = "N/A";
		salario = 0.0;
	   }
  	   public Funcionario(string empresa, double salario, string nome, string cpf, string rg, string telefone, string endereco, int idade) :base(nome, cpf, rg, telefone, endereco, idade) {

	   	this.empresa = empresa;
		this.salario = salario;
	   }	   

	   public string Empresa {get {return this.empresa;} set {this.empresa = value;}}
	   public double Salario {get {return this.salario;} set {this.salario = value;}}
    }

    class Professor : Funcionario {
    	
	    protected string disciplina;	  

	    public Professor() {
	    	disciplina = "N/A";
	    }

	    public Professor(string disciplina, string empresa, double salario, string nome, string cpf, string rg, string telefone, string endereco, int idade) :base(empresa, salario, nome, cpf, rg, telefone, endereco, idade) {
	    	this.disciplina = disciplina;
	    }

	    public string Disciplina {get {return this.disciplina;} set {this.disciplina = value;}}
    }

    class Program
    {
        static void Main(string[] args)
        {
		Professor p = new Professor("Guarda-de-próprios", "Raia Drogasil S/A", 1435.00, "Nicolas M.", "084.145.976-29", "MG-19.172.262", "5531994792400", "R. Dona Herculina, 68 B. Nossa Senhora do Carmo", 21);
		Pessoa a = new Pessoa();

		Console.WriteLine($"{p.Disciplina}, {p.Empresa}, {p.Salario}, {p.Nome}, {p.Cpf}, {p.Rg}, {p.Telefone}, {p.Endereco}, {p.Idade}");
        }
    }
}
