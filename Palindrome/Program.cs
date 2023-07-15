public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string reversedWord = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        Console.WriteLine(reversedWord);
        string outputText = (word == reversedWord)
                       ? "Это слово палиндром"
                       : "Это слово не палиндром";
        Console.WriteLine(outputText);

        //if (word == reversedWord)
        //{
        //    Console.WriteLine("Это слово палиндром");
        //}
        //else
        //{
        //    Console.WriteLine("Это слово не палиндром");
        //}
    }


}