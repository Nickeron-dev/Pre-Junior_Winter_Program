Console.WriteLine("Input size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input {size} elements: ");
int [] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Input {i}th element: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int positive_elements = 0, even_elements = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        positive_elements += arr[i];
    }
    if (arr[i] % 2 == 0)
    {
        even_elements++;
    }
}
Console.WriteLine($"Sum of positive elements: {positive_elements}, amount of even elements: {even_elements}");



Console.WriteLine("Input size of an array: ");
int size_double = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input {size_double * size_double} elements: ");
int[,] double_arr = new int[size_double, size_double];
for (int i = 0; i < size_double; i++)
{
    for (int j = 0; j < size_double; j++)
    {
        double_arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int min_el = double_arr[0, 0], max_el = double_arr[0, 0];
foreach (int e in double_arr)
{
    if (e > max_el)
    {
        max_el = e;
    }
    if (e < min_el)
    {
        min_el = e;
    }
}
Console.WriteLine($"Min element: {min_el}, max element: {max_el}, sum of them: {min_el + max_el}");
