using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Você também pode encontrar a posição do índice de um caractere específico em uma string, usando o IndexOf()método:

namespace AccessStringsCsharp
{
    internal class Exemplo03
    {
        public static void Main(string[] args)
        {
            string texto = "Gato";

            Console.WriteLine(texto.IndexOf("t"));
        }
    }
}
