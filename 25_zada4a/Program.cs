//  Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

class Program
{
    public static int Main()
    {
        //число, которое нужно возвести в степень
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        //степень числа
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        //число, возведенное в степень
        int a_b = 1;
        for (int i = 0; i < b; i++)
        {
            a_b *= a;
        }
        Console.WriteLine("{0} ^ {1} = {2}", a, b, a_b);
        Console.ReadKey();
        return 0;
    }
}