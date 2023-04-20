using System;

class code
{
    static void Main()
    {
        string[] name = new string[] { "[1]Деньги", "[2]Сила", "[3]Энергия" };
        int[] num = new int[] { 100, 100, 100 };
        string enter;

        do
        {
            do
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.Write(name[i] + num[i] + "; ");
                }

                Console.WriteLine();
                enter = Console.ReadLine();
                Console.Clear();

                switch(enter)
                {
                    case "1":
                        num[0] += 100;
                        num[1] -= 5;
                        num[2] -= 5;
                        break;
                    
                    case "2":
                        num[1] += 10;
                        num[2] -= 2;
                        break;
                    
                    case "3":
                        num[0] -= 100;
                        num[2] += 100;
                        break;
                }
            } while (num[0] > 0 ^ num[1] > 0 ^ num[2] > 0);
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("FOR EXIT PRESS 'ESC'");

        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}