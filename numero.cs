//Exercício 2: Faça um programa em C# que recebe 3 números e imprime na tela o número intermediário (aquele que não é nem o maior e nem o menor) .


using System;

class MainClass {
  static void Main (string[] args) {

		float num1 = float.Parse(input("Digite um número: "));
		float num2 = float.Parse(input("Digite outro número: "));
		float num3 = float.Parse(input("Digite outro número: "));

		if( ((num1>num2)&&(num1<num3)) || ((num1<num2)&&(num1>num3)) ) {
			Console.WriteLine(num1+" é o número intermediário!");
		}
		else if( ((num2<num1)&&(num2>num3)) || ((num2>num1)&&(num2<num3)) ) {
			Console.WriteLine(num2+" é o número intermediário!");
		}
		else if( ((num3>num1)&&(num3<num2))||((num3<num1)&&(num3>num2)) ) {
			Console.WriteLine(num3+" é o número intermediário!");
		}
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