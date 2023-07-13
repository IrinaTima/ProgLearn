namespace StarSquare;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(text);

            if (number >= 3)
            {
                Console.WriteLine("Введено правильное число");
            }
            else
            {
                Console.WriteLine("Число должно быть больше или равно 3");
                return;
            }

            int odd = number % 2;

            if (odd == 0)
            {
                Console.WriteLine("Введенно четное число");

                int center = number / 2;

                Console.WriteLine($"Середина квадрата: {center}; {center}");
            }
            else
            {
                Console.WriteLine("Введено нечетное число");

                int center = number / 2;

                Console.WriteLine($"Середина квадрата: {center}; {center}");
            }
        }
        catch
        {
            Console.WriteLine("Возникла ошибка  при вводе данных.");
        }
    }
}