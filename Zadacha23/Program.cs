/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            isCorrect = true;
        else Console.WriteLine("введите корректное значение");
    }
    return result;
}

void CubesOfNumber(int number)
{
    Console.Write($"{number} -> ");
    for (int count = 1; count <= number; count++)
    {
        Console.Write($"{Math.Pow(count,3)}, ");
    }
}

int N = GetNumber("Введите число N");
CubesOfNumber(N);