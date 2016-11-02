// Muñoz, Liarte
using System;

class juego4Ks
{
    static void Draw(string[,] t)
    {
        for (int i = 11; i >= 0; i--)
        {
            for (int j = 0; j < 20; j++)
            {
                if (t[j, i] == " " && i != 0)
                {
                    t[j, i] = t[j, i - 1];
                    t[j, i - 1] = " ";
                }
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.Write(t[j, i]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Random r = new Random();
        string[] l = { "X", "Q", "M" };
        string[,] t = new string[20, 12];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 20; j++)
                t[j, i] = (l[r.Next(0, 3)]);
        }
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.Write(t[j, i]);
            }
            Console.WriteLine();
        }

        string c = Console.ReadLine();
        string[] o = c.Trim().Split(' ');
        int x = Convert.ToInt32(o[0]) - 1;
        int y = Convert.ToInt32(o[1]) - 1;
        string w = t[x, y];
        if ((x != 0 && y != 0) || (x < 21 && y < 13))
        {
            t[x, y] = " ";
            Draw(t);
        }

    }
}