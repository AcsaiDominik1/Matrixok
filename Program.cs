using System.Xml.Serialization;

namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopkSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopkSzama];
        static int[,] negyzetesMatrix = new int[4, 4];
        static Random r = new Random();

        static void F01(int[,] matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
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
                    Console.Write($"{matrix[i, j],5}");
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

        static void BalAtloOsszeg(int[,] matrix)
        {
            int osszeg = 0;
            Console.Write("A bal átló: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, i],5}");
                osszeg += matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"A bal átló összege: {osszeg}");
        }

        static void JobbAtloOsszeg(int[,] matrix)
        {
            int osszeg = 0;
            Console.Write("A jobb átló: ");
            int j = matrix.GetLength(1) -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, j],5}");
                osszeg += matrix[i, j];
                j--;
            }
            Console.WriteLine();
            Console.WriteLine($"A jobb átló összege: {osszeg}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            F01(szamokMatrix, 10, 99);
            F02(szamokMatrix);
            F03();
            F04();
            F05();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            F01(negyzetesMatrix, 1, 9);
            F02(negyzetesMatrix);
            BalAtloOsszeg(negyzetesMatrix);
            JobbAtloOsszeg(negyzetesMatrix);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            int[,] masolat = negyzetesMatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("A másolat elemei: ");
            F02(masolat);
            Console.WriteLine("A négyzetesmátrix: ");
            F02(negyzetesMatrix);
        }
    }
}
