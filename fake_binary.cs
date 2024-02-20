//Receber uma string de números, onde os números forem menores que 5 adicionar "0" e os maiores ou iguais adicionar "1"

using System.Linq;
namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequencia = "1235658423";
            string frase = "";

            foreach(char letra in sequencia)
            {
                int letras = int.Parse(letra.ToString());

                if(letras < 5)
                {
                    frase += "0";
                }
                else
                {
                    frase += "1";
                }
            }
            Console.WriteLine(frase);
        }
    }
}
