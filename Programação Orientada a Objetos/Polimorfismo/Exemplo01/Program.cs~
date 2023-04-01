using System;

namespace Exemplo01 {

	class Funcionario {
		
		protected string matricula;
		protected string cargo;
		protected double salario;
		protected double descontos;	

		public Funcionario() {

			matricula = "N/A";
			cargo = "Aux. Logística";
			salario = 1000.0;
			descontos = 0.0;			
		}

		public string Matricula {get {return this.matricula;} set {this.matricula = value;}}
		public string Cargo {get {return this.cargo;} set{this.cargo = value;}}
		public double Salario {get{return this.salario;} set{this.salario = value;}}		
		public double Descontos {get{return this.descontos;} set{this.descontos = value;}}

		public virtual void DescontarRestaurante() {
			descontos+= salario*0.10;
		}

		public virtual void DescontarValeTransporte() {
			descontos+= salario*0.05;
		}

		public void Descontar() {
			DescontarRestaurante();
			DescontarValeTransporte();
			salario = salario - descontos;
		}
		
	}

	class Conferente : Funcionario {
		
		public override void DescontarRestaurante() {
			descontos += salario*0.15;			
		}
		public override void DescontarValeTransporte() {
			descontos+= salario*0.10;
		}
	}

	class Assistente : Funcionario {
		public override void DescontarRestaurante() {
			descontos += salario*0.15;			
		}
		public override void DescontarValeTransporte() {
			descontos += salario*0.10;
		}
	}


	class Supervisor : Funcionario {
		public override void DescontarRestaurante() {
			descontos += salario*0.20;			
		}
		public override void DescontarValeTransporte() {
			descontos += salario*0.15;
		}
	}

	class Cordenador : Funcionario {
		public override void DescontarRestaurante() {
			descontos += salario*0.25;			
		}
		public override void DescontarValeTransporte() {
			descontos += salario*0.20;
		}
	}

	class Gerente : Funcionario {
		public override void DescontarRestaurante() {
			descontos += salario*0.30;			
		}
		public override void DescontarValeTransporte() {
			descontos += salario*0.25;
		}
	}

	class Program {
		static void Main(string[] args) {

	            Funcionario f;
		    f = new Gerente();

		    Console.WriteLine(f.Matricula);
		    Console.WriteLine(f.Cargo);
		    Console.WriteLine(f.Salario);
		
		    f.Descontar();

		    Console.WriteLine(f.Salario);
        	}
	}
}
