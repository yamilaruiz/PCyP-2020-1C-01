
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicaciónMatrices
{
    class Program
    {

        static void Main(string[] args)
        {
            int respuesta = 0;

            int r1 = 6; //fila
            int c1 = 5; //columa
            int[,] matrix1 = generateMatrix(r1, c1); //Creo la Matriz 1

            int r2 = 5; //fila
            int c2 = 2; //columa
            int[,] matrix2 = generateMatrix(r2, c2); //Creo la Matriz 2

            if (c1 == r2) //Si el numero de columnas de la 1 es igual al numero de filas de la 2
                //Verifico que sean multiplicables
            {


                int[,] matrizResponse = new int[r1, c2];

                //Para calcular de manera paralela
                /*         
                Parallel.For(0, r1, i =>  //Calculo la nueva matriz
                {
                    for (int j = 0; j < c2; j++)
                    {
                        for (int k = 0; k < c1; k++)
                        {
                            respuesta += matrix1[i, k] * matrix2[k, j];
                        }
                        matrizResponse[i, j] = respuesta;
                        respuesta = 0;
                    }
                });
                */
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        for (int k = 0; k < c1; k++)
                        {
                            respuesta += matrix1[i, k] * matrix2[k, j];
                        }
                        matrizResponse[i, j] = respuesta;
                        respuesta = 0;
                    }
                }
                Console.WriteLine("Matriz 1: ");
                mostrar(matrix1);

                Console.WriteLine("Matriz B: ");
                mostrar(matrix2);

                Console.WriteLine("Resultado de la multiplicación de la Matriz A y Matriz B: ");
                mostrar(matrizResponse);

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("No se puede multiplicar estas matrices");
                Console.Read();
            }

        }

        static void mostrar(int[,] matriz) //MOSTRAR APUESTAS
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.Write(matriz[fila, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] generateMatrix(int rows, int columns)
        {
            //Random random = new Random();
            Random random = new Random(DateTime.Now.Millisecond);
            int[,] matrix = new int[rows, columns]; 
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = random.Next(1, 10); ;
                }
            }

            return matrix;
        }
    }
}