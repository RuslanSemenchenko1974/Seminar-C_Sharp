Console.WriteLine("Ведите число");
int namber = int.Parse(Console.ReadLine());
int count=Math.Abs(namber)*(-1);
while(count<namber+1)
    {
        Console.Write($"{count}  ");
        count++;
    }