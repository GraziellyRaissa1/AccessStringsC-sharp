using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Outro método útil é Substring(), que extrai os caracteres de uma string, começando na posição/índice do caractere especificado,
//e retorna uma nova string. Este método é frequentemente usado em conjunto IndexOf()para obter a posição específica do personagem:

namespace AccessStringsCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args)
        {
            // criando uma variável com o nome e sobrenome
            string nomeSobrenome = "Grazielly Raissa";

            //localizando a primiera letra do sobre nome
            int contadora = nomeSobrenome.IndexOf("R");

            //pegando o sobrenome através da letra exibida na contadora
            string Sobrenome = nomeSobrenome.Substring(contadora);

            //Exibindo o sonbrenome
            Console.WriteLine(Sobrenome);

        }
    }
}
