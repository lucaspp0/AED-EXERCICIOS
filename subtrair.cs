using System;

class MainClass {
  public static void Main (string[] args) {
		string[] vogais = new string[] { "a","e","i","o","u" };

		string res = input("Entre uma vogal: ").ToLower();

		while( Array.IndexOf(vogais,res) == -1 ){
			print("Eu falei uma vogal cara, acreta na próxima pf");
			res = input("Entre uma vogal: ").ToLower();
		}
		print("Ae sim ein man");

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