using System;

class MainClass {
  public static void Main (string[] args) {
    string nome = input("Seu nome: ");
		print("seu nome é: "+nome);
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