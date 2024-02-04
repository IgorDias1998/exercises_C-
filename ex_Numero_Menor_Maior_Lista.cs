//Faça um programa que, dado um conjunto de N números, determine o menor valor, o maior valor e a soma dos valores.

List<int> lista = new List<int>();
lista = [111, 10, 13, 15, 30, 5, 12, 30];

int maior = lista[0];
int menor = lista[0];

for (int i = 0; i < lista.Count(); i++)
{
    if (lista[i] < menor)
    {
        menor = lista[i];
    }

    if (lista[i] > maior)
    {
        maior = lista[i];
    }
}
Console.WriteLine($"Maior {maior} Menor {menor}");
Console.ReadLine();

//Pode-se usar propriedades do próprio C#
//lista.Max() -> Maior numero
//lista.Min() -> Menor numero
//lista.Sum() -> Soma
