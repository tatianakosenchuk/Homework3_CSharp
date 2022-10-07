/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
            isCorrect = true;
        else Console.WriteLine("введите корректное значение");
    }
    return result;
}
void PalindromNumber(int number)
{
    if (number == int.Parse(Convert.ToString(number)[4].ToString() + Convert.ToString(number)[3].ToString() + Convert.ToString(number)[2].ToString() + Convert.ToString(number)[1].ToString() + Convert.ToString(number)[0].ToString()))
         
            Console.WriteLine($"{number} -> да");
        else
            Console.WriteLine($"{number} -> нет");
    
}

int num = GetNumber("Введите пятизначное число");
PalindromNumber(num);