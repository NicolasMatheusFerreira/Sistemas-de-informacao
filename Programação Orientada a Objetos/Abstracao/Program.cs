using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
          Boleto boleto = new Boleto("1246980","12345678", 120.00, new DateTime(2020, 05, 03, 07, 10, 0));
	    Console.WriteLine(boleto.getIdBoleto()+" "+boleto.getCodigBarras()+" "+boleto.getValor()+" "+boleto.getVencimento());
	    bool pago = boleto.Pagar(new DateTime(1998, 08, 07, 07, 0, 0), 120.0, "123456789");	 
	    Console.WriteLine(pago);	    
        }
    }
}
