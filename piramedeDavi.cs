/*
Faça um programa que leia um valor inteiro e desenhe na tela um triângulo, como mostrado na figura abaixo:

               0 
             000 
           00000 
         0000000 
       000000000 
     00000000000 
   0000000000000 
 000000000000000 

No exemplo teria sido digitado o valor 8.
*/

using System;
class MainClass {
  public static void Main (string[] args) {
		int _ = int.Parse( input("insira a quantidade da piramede bro: ") );
		int comeco = 0;
		int total = (_*2)-1;
		int final = total-1;
		string[] tudo = new string[total];
		string linha = "";
		for(int i=0; i<_; i++){
			linha = "";
			for(int x=0; x<total; x++){
				if(comeco > x || final < x){
					linha	+= " ";
				}else{
					linha += "0";
				}
			}
			tudo[i] = linha;
			comeco++;
			final--;
		}
		for(int i=_-1; i>0; i--){
			print( tudo[i] );
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

