Console.WriteLine("Доброго дня, введіть число грошей Петрика: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть к-сть зошитів, які він придбав: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть к-сть ручок, які він придбав: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть вартість одного зошита: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть вартість однієї ручки: ");
int y = Convert.ToInt32(Console.ReadLine());

if (s >= (n * x + m * y))
{
    Console.WriteLine($"Так, Петрику вистачить грошей. Залишок: {(s - (n * x + m * y))}");
}
else
{
    Console.WriteLine("На жаль, у Петрика недостатньо коштів для покупки.");
}
