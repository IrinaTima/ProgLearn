namespace StarSquare;

public class Program
{
    public static void Main()
    {
        // Ввод числа с клаваиатуры.
        string text = Console.ReadLine();

        try
        {
            // Конвертируем в число.
            int number = Convert.ToInt32(text);

            Validate(number);
            
            int center = number / 2;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    // Используем тернарный оператор вместо условного (строки 30-37).
                    string outputText = (i == center && j == center) 
                        ? " " 
                        : "*";

                    Console.Write(outputText);

                    //if (i == center && j == center)
                    //{
                    //    Console.Write(" ");
                    //}
                    //else
                    //{
                    //    Console.Write("*");
                    //}                 
                }
                Console.WriteLine();
            }
        }
        // Ловим ошибки, возникающие в Convert.ToInt32.
        catch (FormatException ex)
        {
            Console.WriteLine("Не удалось получить число. В введенном тексте присутствуют запрещенные символы.");
        }
        // Ловим оставльные ошибки.
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        } 
    }

    /// <summary>
    /// Функция, проверяющая введенное значение.
    /// </summary>
    /// <param name="text"></param>
    private static void Validate(int number)
    {
        if (number < 3)
        {
            throw new Exception("Число должно быть больше или равно 3");
        }

        int odd = number % 2;

        if (odd == 0)
        {
            throw new Exception("Введенно четное число");
        }
    }
}