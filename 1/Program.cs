// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



class Program
{
    static bool Palindrome(int number)
    {
        string numberString = number.ToString();
        int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Введено некорректное число. Пожалуйста, введите пятизначное число.");
            return;
        }

        if (Palindrome(number))
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
}