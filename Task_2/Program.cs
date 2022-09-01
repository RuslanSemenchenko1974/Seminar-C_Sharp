Console.WriteLine("Ведите число 1");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число 1");
int namber2 = int.Parse(Console.ReadLine());
if (namber1==Convert.ToInt32(Math.Pow(namber2,2)))
{
    Console.WriteLine($"Число {namber1} квадрат {namber2}");
}
else
{
    Console.WriteLine("Нет");
}