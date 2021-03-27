using System;

namespace newproj
{
    public class Program
    {
        public delegate double pd(double x);
        public static pd[] delegates = new pd[]
        {
        new pd((double x)=>Math.Sqrt(Math.Abs(x))),
        new pd((double x)=>x*x*x),
        new pd((double x)=>x+3.5)
        };
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите в строку 2 числа через пробел(первое обозначает номер метода, второе обозначает число х) \n Введите 1 если хотите найти корень числа х \n Введите 2 если хотите найти куб от числа х \n Введите 3 если хотите прибавить к числу х 3.5");
                    string[] str = Console.ReadLine().Split(' ');
                    bool success_1=int.TryParse(str[0], out int n);
                    bool success_2= double.TryParse(str[1], out double x);
                    if (success_1 && success_2)
                    {
                        Console.WriteLine(delegates[n-1](x));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                        break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
                Console.WriteLine(".\n.\n.\n.\nНажмите на любую клавишу чтобы продолжить\n.\n.\n.");
                Console.ReadKey();
            }
            
        }
    }

}
