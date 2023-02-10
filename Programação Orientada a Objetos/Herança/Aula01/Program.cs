using System;

namespace Aula01
{
    class Pessoa {
    	
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

	    public string Nome {get; set;}
	    public string Cpf {get; set;}
	    public string Rg {get; set;}
	    public string Telefone {set; get;}
	    public string Endereco {set; get;}
	    public int Idade {set; get;}
    }

    class Funcionario : Pessoa {
    	
	    protected string empresa;
	    protected double salario;

	   public Funcionario() {
	   	empresa = "N/A";
		salario = 0.0;
	   }	    

	   public string Empresa {get; set;}
	   public double Salario {get; set;}
    }

    class Professor : Funcionario {
    	
	    protected string disciplina;
	    public Professor() {
	    	disciplina = "N/A";
	    }

	    public string Disciplina {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
           	Professor prof = new Professor();	  
		prof.Nome = "Nicolas M.";
		prof.Cpf = "084.145.976-29";
		prof.Rg = "MG-19.172-262";
		prof.Telefone = "31994792400";
		prof.Endereco = "R. Dona Herculina, 68 B. Nossa Senhora do Carmo";
		prof.Idade = 21;
		prof.Empresa = "Raia Drogasil S/A";
		prof.Salario = 1435.00;
		prof.Disciplina = "Guarda de próprios";

		Console.Write(prof.Nome+" "+prof.Cpf+" "+prof.Rg+" "+prof.Telefone+" "+prof.Endereco+" "+prof.Idade+" "+prof.Empresa+" "+prof.Salario+" "+prof.Disciplina);
        }
    }
}
