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
