// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Program
{
    static void Main(string[] array)
    {
        Console.Write("Введите длину массива: ");
        int count = int.Parse(Console.ReadLine());
        int[] myArray = new int[count];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Вывод массива: ");
        System.Console.Write("[");
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            Console.Write($"{myArray[i]}, ");
        }
        System.Console.Write($"{myArray[myArray.Length - 1]}");
        System.Console.Write("]");
    }
}
