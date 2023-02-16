﻿using System;
using System.Collections.Generic;

namespace ExercicioFixacao {

	class Funcionario {

		protected string nome;
		protected int horas;
		protected double valorPorHora;

		public Funcionario() {
			nome = "N/A";
			horas = 0;
			valorPorHora = 0.0;
		}
		public Funcionario(string nome, int horas, double valorPorHora) {
			this.nome = nome;
			this.horas = horas;
			this.valorPorHora = valorPorHora;
		}

		public string Nome {
			get {
				return this.nome;
			} 
			set {
				this.nome = value;
			}
		}
		public int Horas {
			get {
				return this.horas;
			}
			set {
				this.horas = value;
			}
		}
		public double ValorPorHora {
			get {
				return this.valorPorHora;
			}
			set {
				this.valorPorHora = value;
			}
		}

		public virtual double Pagamento() {
			return horas*valorPorHora;
		}
	}

	class PagamentoTerceirizado : Funcionario {
		
		private double pagamentoAdicional;	

		public PagamentoTerceirizado() {
			pagamentoAdicional = 0.0;
		}
		public PagamentoTerceirizado(double pagamentoAdicional, string nome, int horas, double valorPorHora) : base(nome, horas, valorPorHora) {
			this.pagamentoAdicional = pagamentoAdicional;
		}

		public double PagamentoAdicional {get {return this.pagamentoAdicional;} set {this.pagamentoAdicional = value;}}

		public override double Pagamento() {
			pagamentoAdicional = horas*valorPorHora*0.10;
			return (horas*valorPorHora + pagamentoAdicional);
		}
	}

	class Program {
        	static void Main(string[] args) {
           		
			int qtdFuncionarios, horasTrabalhadas;
			string nomeCompleto;
			double valorPorHoras;			
			char op;

			List<Funcionario> func1 = new List<Funcionario>();		

			Console.Write("Informe a quantidade de funcionarios: ");
			qtdFuncionarios = int.Parse(Console.ReadLine());

			for(int i = 1; i<=qtdFuncionarios; i++) {

				Console.Write("Terceirizado? [S] Sim | [N] Nao: ");
				op = Console.ReadLine()[0];
				op = Char.ToLower(op);

				Console.Write("Informe nome completo: ");
				nomeCompleto = Console.ReadLine();

				Console.Write("Informe valor por hora trabalhada R$: ");
				valorPorHoras = double.Parse(Console.ReadLine());

				Console.Write("Informe quantidade de horas trabalhadas: ");
				horasTrabalhadas = int.Parse(Console.ReadLine());

				if (op=='s') {
					func1.Add(new Funcionario(nomeCompleto, horasTrabalhadas, valorPorHoras));				
				} else {
					func1.Add(new PagamentoTerceirizado(0.0, nomeCompleto, horasTrabalhadas, valorPorHoras));								
				}
			}	

			foreach(Funcionario aux in func1) {

				Console.WriteLine(aux.Nome+" "+aux.Pagamento());
			}
			Console.WriteLine("Fim!");
        	}
	}
}
