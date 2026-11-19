using System.Xml.Serialization;

namespace Matrixok
{
    internal class Program
    {
        static int sorokSzama = 10;
        static int oszlopkSzama = 6;
        static int[,] szamokMatrix = new int[sorokSzama, oszlopkSzama];
        static Random r = new Random();

        static void F01()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0;  j < oszlopkSzama; j++)
                {
                    szamokMatrix[i, j] = r.Next(10, 100);
                }
            }
        }

        static void F02()
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopkSzama; j++)
                {
                    Console.Write(szamokMatrix[i, j] + " ");
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
            F01();
            F02();
            F03();
            F04();
            F05();
        }
    }
}
