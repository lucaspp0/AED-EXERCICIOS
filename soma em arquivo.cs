//Exercício 2: Crie um programa em C# que receba do usuário 2 números inteiros e, em seguida, realize a soma dos dois números e grave esse valor em um arquivo.


using System;
using System.IO;
using System.Text;

class MainClass {

	static void Main(string[] args){

		Console.WriteLine("Insira 2 números");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int soma = num1+num2;
		File.WriteAllText("arquivos/dados.txt", soma.ToString());
	}
}
