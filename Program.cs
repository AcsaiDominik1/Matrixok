using System.Xml.Serialization;

namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopkSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopkSzama];
        static int[,] negyzetesMatrix = new int[10, 10];
        static Random r = new Random();

        static void F01(int[,] matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;  j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max + 1);
                }
            }
        }

        static void F02(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void F03()
        {
            int osszeg = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopkSzama; j++)
                {
                    osszeg += szamokMatrix[i, j];
                }
            }
            Console.WriteLine($"A mátrixban lévő elemek összege: {osszeg}");
            Console.WriteLine();
        }

        static void F04()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < oszlopkSzama; j++)
                {
                    osszeg += szamokMatrix[i, j];
                }
                Console.WriteLine($"{i + 1}. sor összege: {osszeg}");
            }
            Console.WriteLine();
        }

        static void F05()
        {
            for (int j = 0; j < oszlopkSzama; j++)
            {
                int osszeg = 0;
                for (int i = 0; i < sorokSzama; i++)
                {
                    osszeg += szamokMatrix[i, j];
                }
                Console.WriteLine($"{j + 1}. oszlop összege: {osszeg}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            F04();
            F05();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            F01(negyzetesMatrix, -100, 100);
            F02(negyzetesMatrix);
        }
    }
}
