/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetCoordinate(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else Console.WriteLine("введите корректное значение");
    }
    return result;
}

void DistanceBetweenAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    Console.WriteLine($"A ({xa}, {ya}, {za}; B ({xb}, {yb}, {zb} -> {Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2)}");
}

int xa = GetCoordinate("Введите координаты точки A по оси X");
int ya = GetCoordinate("Введите координаты точки A по оси Y");
int za = GetCoordinate("Введите координаты точки A по оси Z");
int xb = GetCoordinate("Введите координаты точки B по оси X");
int yb = GetCoordinate("Введите координаты точки B по оси Y");
int zb = GetCoordinate("Введите координаты точки B по оси Z");
DistanceBetweenAB(xa, ya, za, xb, yb, zb);