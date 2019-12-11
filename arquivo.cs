using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    int[] arr = new int[] { 0,0,0,
														0,0,0,
														0,0,0,
														0,0,0 };
		for(int x = 0; x<10; x++){
			adicionarNoVetor( ref arr );
			mostrarVetor(arr);
		}
  }

	public static void mostrarVetor(int[] arr){
		for( int x = 0; x<arr.Length; x++ ){
			Console.Write(arr[x]);
		}
		Console.WriteLine("");
	}

	public static void adicionarNoVetor( ref int[] valor ){
		bool conti = true;
		int contador = 0;
		while(conti){
			if(contador == valor.Length){
				for(int x = 0; x<valor.Length; x++){
					valor[x] = 0;
				}
				break;
			}
			conti = valor[contador] == 9;
			if(!conti){
				valor[contador]++;
			}else{
				valor[contador] = 0;
			}
			contador++;
		}
	}

}
