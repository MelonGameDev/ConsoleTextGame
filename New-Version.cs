using System;

namespace NewConsoleTextGame
{
    sealed class Program
    {
        private static Money money = new Money(100);
        private static Power power = new Power(100);
        private static Energy energy = new Energy(100);

        private static void Main(string[] Args)
        {
            while ((money.Examination() == true) && (power.Examination() == true) && (energy.Examination() == true))
            {
                Console.Clear();

                Conclusion();

                Contorler();
            }

            Console.Clear();

            Console.WriteLine("Вы проиграли!!!");
        }

        private static void Conclusion() => Console.WriteLine($"{money.Print("[Q]Деньги")} {power.Print("[W]Сила")} {energy.Print("[E]Електричество")}");

        private static void Contorler()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Q:
                    money.Add(15);
                    power.TekeAway(7);
                    energy.TekeAway(4);
                    break;

                case ConsoleKey.W:
                    power.Add(5);
                    energy.TekeAway(2);
                    break;

                case ConsoleKey.E:
                    energy.Add(100);
                    money.TekeAway(100);
                    break;
                
                default:
                    Console.Clear();
                    break;
            }
        }
    }

    public class Essence
    {
        protected int _number;

        public string Print(string text)
        {
            return $"{text}: {_number}";
        }

        public int Add(int x)
        {
            return _number += x;
        }

        public int TekeAway(int x)
        {
            return _number -= x;
        }

        public bool Examination()
        {
            if (_number > 0) return true;

            return false;
        }
    }

    sealed class Money : Essence
    {
        private int _money;

        public Money(int x)
        {
            _money = x;
            _number = _money;
        }
    }

    sealed class Power : Essence
    {
        private int _power;

        public Power(int x)
        {
            _power = x;
            _number = _power;
        }
    }

    sealed class Energy : Essence
    {
        private int _energy;

        public Energy(int x)
        {
            _energy = x;
            _number = _energy;
        }
    }
}