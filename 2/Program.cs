// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowDistance(double x1, double y1, double c1, double x2, double y2, double c2)
{
    double Distans = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(c2 - c1, 2));
    Console.WriteLine($"Расстояние между двух точек: {Distans}");

}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInput("Введите координату X точки A: ");
int y1 = GetInput("Введите координату Y точки A: ");
int c1 = GetInput("Введите координату C точки A: ");
int x2 = GetInput("Введите координату X точки B: ");
int y2 = GetInput("Введите координату Y точки B: ");
int c2 = GetInput("Введите координату C точки B: ");
ShowDistance(x1, y1, c1, x2, y2, c2);