using System;
class Game
{
    public static Random rand = new Random();
    public static void Main(string[] args)
    {
        int[,] mas = new int[10, 10];
        int[,] mas1 = new int[10, 10];
        int[,] mas2 = new int[10, 10];
        int x, y;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if ((i % 2) == 0)
                {
                    mas[i, j] = rand.Next(0, 2);
                }
                else { mas[i, j] = 0; }

            }
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas1[i, j] = 0;
                    mas2[i, j] = 0;
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 0; j++)
                {
                    Console.WriteLine(Convert.ToString(mas1[i, j]), "");
                    if (j == 9)
                    {
                        Console.Write('\n'); }
                    }
                }
            for (int t = 0; t < 10; t++)
            {
                Console.WriteLine("Введите координаты коробля через Enter", '\n');
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                y--;
                x--;
                mas1[x, y] = 1;
                Console.Clear();
                if (mas1[x, y] == mas[x, y] && mas[x, y] == 1)
                {
                    mas2[x, y] = 1;
                } else
                {
                    mas2[x, y] = 2;
                }
                for (i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (mas2[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                        if (mas2[i, j] == 1)
                        {
                            Console.Write("x");
                        }
                        if (mas2[i, j] == 2)
                        {
                            Console.Write("o");
                        }
                        if (j == 9)
                        {
                            Console.Write('\n');
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}