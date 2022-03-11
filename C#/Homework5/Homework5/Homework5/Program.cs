static double average(int a, int b)
{
    return (double) (a + b) / 2;
}

static int max_element(int []arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++) {
        max = max > arr[i] ? max : arr[i];
    }
    return max;
}

static void main(String []args)
{
    Console.WriteLine("Input 2 integer values: ");
    int input_a = Convert.ToInt32(Console.ReadLine());
    int input_b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The average value is: {average(input_a, input_b)}");

    Console.WriteLine("Input size of an array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Input {size} elements: ");
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Input {i}th element: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"The maximum value is: {max_element(arr)}");
}

main(args);
