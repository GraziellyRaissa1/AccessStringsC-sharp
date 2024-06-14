using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Você pode acessar os caracteres em uma string consultando seu número de índice entre colchetes [].

Este exemplo imprime o primeiro caractere em myString :Você pode acessar os caracteres em uma string consultando seu número de índice entre colchetes [].

Este exemplo imprime o primeiro caractere na variável texto:*/


namespace AccessStringsCsharp
{
    internal class Exemplo01
    {
        public static void Main(string[] args)
        {
            string texto = "Cachorro";

            Console.WriteLine(texto[0]);
        }
    }
}
