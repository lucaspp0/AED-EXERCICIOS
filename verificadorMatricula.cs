using System;

class MainClass {
  public static void Main (string[] args) {
		bool continuar = true;
		while(continuar){
			string matricula = input("Informe a sua matriculo seu puto: ");
			if(matricula.Length != 8){
				print("Tem que ter 8 dígitos seu arrombed. ");
				return;
			}
			int total = (int.Parse(matricula[0].ToString()) * 2) +
									(int.Parse(matricula[1].ToString()) * 3) +
									(int.Parse(matricula[2].ToString()) * 4) +
									(int.Parse(matricula[3].ToString()) * 3) +
									(int.Parse(matricula[4].ToString()) * 2) +
									(int.Parse(matricula[5].ToString())) +
									(int.Parse(matricula[6].ToString())) +
									(int.Parse(matricula[7].ToString()));
					decimal resto = total%10;

			print("toma ae sua matricula: "+ matricula + "-" + resto );

			continuar = input("Se quer continuar ? (S/N): ") != "N";
		}
								
  }




































/* Métodos auxiliares só pra caso o repl.it der pau no intelligence ou coisa do tipo */
	public static void print(string msg, bool pularLinha = true){
		if(pularLinha)
			Console.WriteLine(msg);
		else
			Console.Write(msg);
	}
	public static string input(string msg = null, bool pularLinha = false){
		if( msg != null || msg != "" ){
			if(pularLinha)
				Console.WriteLine(msg);
			else
				Console.Write(msg);
		}
		return Console.ReadLine();
	}

}