//Exercício 02: Crie um programa em C# que realize o preenchimento de um vetor com 10 números inteiros a partir da entrada padrão (teclado) e, em seguida, imprima esses dados na tela para o usuário na ordem inversa.

//Exemplo de Entrada...:   4  2   1   4   5   7   9   5   2   1   5 

//Exemplo de Saída......:  5  1   2   5   9   7   5   4   1   2   4


using System;

class MainClass {


	static void Main(string[] args){

		int[] vetor = new int[10];

		for(int i=0; i<10; i++){
			Console.Write("Digite um número inteiro: ");
			vetor[i] = int.Parse(Console.ReadLine());
		}

		for(int x=9; x>=0; x--){
			Console.Write(vetor[x] + " ");
		}

	}
}