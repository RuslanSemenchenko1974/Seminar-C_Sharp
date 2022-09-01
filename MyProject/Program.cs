Console.WriteLine("Ведите число");
int namber = int.Parse(Console.ReadLine());
// Получение квадрата числа
int result = namber*namber;
Console.WriteLine($"Квадратчисла {namber} = {result}");
int result2=Convert.ToInt32(Math.Pow(namber,2));
Console.WriteLine($"Квадратчисла {namber} = {result}");