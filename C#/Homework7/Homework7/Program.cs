int gcd_for_two(int a, int b)
{
    if(b == 0)
    {
        return Math.Abs(a);
    }
    else
    {
        return gcd_for_two(b, a % b);
    }
}

int gcd_for_three(int a, int b, int c)
{
    int a_and_b_result;
    if (b == 0)
    {
        a_and_b_result = Math.Abs(a);
    }
    else
    {
        a_and_b_result = gcd_for_two(b, a % b);
    }

    if (c == 0)
    {
        return Math.Abs(a_and_b_result);
    }
    else
    {
        return gcd_for_two(c, a_and_b_result);
    }
}

Console.WriteLine("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The GCD for {first}, {second} and {third} is: " +
    $"{gcd_for_three(first, second, third)}");
