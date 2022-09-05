// ЗАДАЧА 40
// Даны три отрезка, можно ли из них составить треугольник?

int Read(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

bool Test(int a, int b, int c)
{
    if ((a <= b + c) && (b <= a + c) && (c <= a + b))
        return true;
    else
        return false;
}

void Print(bool res)
{
    if (res)
        Console.WriteLine("Можно составить треугольник!");
    else
        Console.WriteLine("Нельзя составить треугольник!");
}

int sideA = Read("Введите сторону A ");
int sideB = Read("Введите сторону B ");
int sideC = Read("Введите сторону C ");

bool resultTest = Test(sideA,sideB,sideC);

Print(resultTest);
