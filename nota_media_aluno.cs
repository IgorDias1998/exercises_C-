using System;
using System.Collections.Generic;

/*Criar um dicionário, que possua um vetor que receba 4 notas de um aluno e exiba a média
-Adicionar o aluno e suas notas(input)
-Consultar o aluno e exibir suas notas e média*/
public class Program
{
    static void Main()
    {
        Dictionary<string, double[]> notaAlunos = new Dictionary<string, double[]>();

        AdicionarAluno(notaAlunos);

        // Acessar as notas de um aluno específico
        Console.Write("Digite o nome do aluno para consultar as notas: ");
        string nomeAlunoConsulta = Console.ReadLine();
        
        if (notaAlunos.ContainsKey(nomeAlunoConsulta))
        {
            double[] notas = notaAlunos[nomeAlunoConsulta];
            Console.WriteLine($"Notas de {nomeAlunoConsulta}: {string.Join(", ", notas)}");

            foreach (var parChaveValor in notaAlunos)
            {
                Console.WriteLine($"Média final: {parChaveValor.Value.Sum()/4.0}");
            }
        }
        else
        {
            Console.WriteLine($"Não foram encontradas notas para o aluno {nomeAlunoConsulta}.");
        }
    }

    static void AdicionarAluno(Dictionary<string, double[]> dicionarioAlunos)
    {
        Console.WriteLine("Digite o nome do aluno");
        string? nomeAluno = Console.ReadLine();

        Console.WriteLine($"Digite as 4 notas de {nomeAluno} separadas por espaço");
        string[] notasString = Console.ReadLine().Split(" ");

        double[] notas = new double[4];
        for(int i=0; i<4; i++)
        {
            if(double.TryParse(notasString[i], out double nota))
            {
                notas[i] = nota;
            }
            else
            {
                Console.WriteLine("Entrada de notas inválida, utilize apenas números");
            }
        }
        dicionarioAlunos[nomeAluno] = notas;
    }
}
