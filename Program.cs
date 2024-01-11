/*Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de crescimento de 3%
 * e que a população de B seja 200000 habitantes com uma taxa de crescimento de 1.5%. 
 * Faça um programa que calcule e escreva o número de anos necessários para que a 
 * população do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento.*/

namespace resolucaoExercicios
{
    public class resolucaoNota
    {
        static void Main()
        {
            double paisA = double.Parse(Console.ReadLine());
            double paisB = double.Parse(Console.ReadLine());
            int anos = 0;

            while(paisA < paisB)
            {
                anos++;
                paisA = paisA * 1.03;
                paisB = paisB * 1.015;
            }
            Console.WriteLine("Anos necessário para ultrapassar:" + anos);
            Console.ReadLine();
        }
    }
}






























/*Faça um programa que peça uma nota, entre zero e dez. 
 * Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.*/

//static void Main()
//{
//    VerificarNota();
//}

//static void VerificarNota()
//{
//    while (true)
//    {
//        Console.WriteLine("Digite uma nota entre 0 e 10");
//        decimal verificarValor = Convert.ToDecimal(Console.ReadLine());

//        if (verificarValor < 0 || verificarValor > 10)
//        {
//            Console.WriteLine("Valor inválido!");
//            VerificarNota();
//        }
//        else
//        {
//            Console.WriteLine($"Nota válida: {verificarValor}");
//            break;
//        }
//    }
//    Environment.Exit(0);
//}