using System;

namespace DesafioMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas linhas e colunas terá a matriz?");
            string[] vs = Console.ReadLine().Split(' ');
            int Linhas = int.Parse(vs[0]);
            int Colunas = int.Parse(vs[1]);

            int[,] matriz = new int[Linhas, Colunas];

            for (int i = 0; i < Linhas; i++)
            {
                Console.WriteLine("Insira os valores da " + (i + 1) + "° linha");
                string[] vetor = Console.ReadLine().Split(' ');
                for(int j = 0; j < Colunas; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            Console.Write("\nDigite o número que será buscado por ocorrências: ");
            int N = int.Parse(Console.ReadLine());
            int cont = 0;
            for(int i = 0; i < Linhas; i++)
            {
                for(int j =0; j < Colunas; j++)
                {
                    if (matriz[i, j] == N)
                    { 
                        cont++;
                        Console.WriteLine("\nPosition " + i + "," + j + ":");
                        
                        if ((j-1) >= 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, (j - 1)]);
                        }
                        if((j + 2) <= Colunas)  //a variavel j vai de 0-3 e a coluna de 1-4, então é preciso adicionar + 1, além disso, estou contando com a verificação  de + 1 para ver o item à direita, por isso o +2
                        {
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        }
                        if((i - 1) >= 0)
                        {
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);
                        }
                        if ((i + 2) <= Linhas)
                        {
                            Console.WriteLine("Down: " + matriz[(i + 1), j]);
                        }
                    }                          
                    
                }
            }

        }
    }
}
