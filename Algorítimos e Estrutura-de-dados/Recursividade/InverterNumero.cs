using System;

class InverterNumero {

	static int InverterRec(int num) {
	
		int resto;
		string result;

		resto = num%10;

		if (resto==0) {
			return 0;
		} else result = resto+InverterRec(num/10);
		return int.Parse(result);
	}

	static int InverterIte(int num) {
	
		int resto = num%10;
		string result = "";
		while(resto!=0) {
			result+=resto;		
			num/=10;
			resto = num%10;
		}
		return int.Parse(result);
	}

	static void Main(string[] args) {
		
		Console.WriteLine(InverterRec(int.Parse(Console.ReadLine())));
	}
}
