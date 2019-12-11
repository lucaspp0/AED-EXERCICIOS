using System;
using System.Collections.Generic;
using System.Collections;

namespace macaco
{
    public class Macaco{

        public string Nome { get; set; }
        List<string> Bucho {get; set; }

        public macaco(string nome){
            this.Nome = nome;
            Bucho = new List<string>();
        }

        public void comer(string comida){
            Bucho.Add(comida);
        }

        public void verBucho(){
            foreach (strign item in Bucho)
            {
                Console.WriteLine(item);
            }
        }
        public void digerir(){
            Console.WriteLine("digerindo ..");
            Bucho.Clear();
            Console.WriteLine("digerido ..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
