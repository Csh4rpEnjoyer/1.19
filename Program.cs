Console.WriteLine("Введите значение epsilon");
double eps = double.Parse(Console.ReadLine());
int m = 1;
double sltn1 = 10;
double sltn2 = 0;
static double fact(int a)
{
    double f;
    f = 1;
    for (int i = 1; i <= a; i++)
        f = f * i;
    return f;
}
double s = 0;
while ((Math.Abs(sltn1 - sltn2) > eps))
{
    sltn2 = sltn1;
    sltn1 = ((fact(m - 1)) * (fact(m - 1))) / fact(2 * m);
    s = s + sltn1;
    m++;
}
Console.WriteLine($"Количество шагов {m}");
Console.WriteLine($"Сумма {s}");

