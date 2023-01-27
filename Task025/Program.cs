//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int c = 1;
int Num(int num, int deg)
{
    for (int i = 1; i <= deg; i++)
    {
        c = c*num; 
    }
    return c;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int d = Convert.ToInt32(Console.ReadLine());
Num(n, d);
Console.WriteLine($"Число {n} в степени {d} = {c}");