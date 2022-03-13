Tuple<int, int> bubble_sort(int[] array)
{
    int swaps = 0, comparisons = 0;
    for (int i = 1; i < array.Length; i++)
    {
        comparisons++;
        for (int j = 0; j < array.Length - i; j++)
        {
            comparisons++;
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swaps++;
            }
            comparisons++;
        }
    }
    return new Tuple<int, int>(swaps, comparisons);
}

Tuple<int, int> selection_sort(int[] array)
{
    int swaps = 0, comparisons = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        comparisons++;
        int n_min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            comparisons++;
            if (array[j] < array[n_min])
            {
                n_min = j;
            }
            comparisons++;
        }
        int temp = array[i];
        array[i] = array[n_min];
        array[n_min] = temp;
        swaps++;
    }
    return new Tuple<int, int>(swaps, comparisons);
}

Tuple<int, int> insertion_sort(int [] array)
{
    int swaps = 0, comparisons = 0;
    int j;
    for (int i = 1; i < array.Length; i++)
    {
        comparisons++;
        int c = array[i];
        for (j = i - 1; j >= 0 && array[j] > c; j--)
        {
            array[j + 1] = array[j];
            comparisons++;
        }
        array[j + 1] = c;
        swaps++;
    }
    return new Tuple<int, int>(swaps, comparisons);
}

Console.WriteLine("Input amount of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array_for_bubble_sort = new int[size];
int[] array_for_selection_sort = new int[size];
int[] array_for_insertion_sort = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Input {i}th element: ");
    int element = Convert.ToInt32(Console.ReadLine());
    array_for_bubble_sort[i] = element;
    array_for_selection_sort[i] = element;
    array_for_insertion_sort[i] = element;
}

Tuple<int, int> result_bubble_sort = bubble_sort(array_for_bubble_sort);
Tuple<int, int> result_selection_sort = selection_sort(array_for_selection_sort);
Tuple<int, int> result_insertion_sort = insertion_sort(array_for_insertion_sort);

Console.WriteLine("Bubble sort: ");
for (int i = 0; i < array_for_bubble_sort.Length; i++)
{
    Console.Write(array_for_bubble_sort[i] + " ");
}

Console.WriteLine("\nSelection sort: ");
for (int i = 0; i < array_for_selection_sort.Length; i++)
{
    Console.Write(array_for_selection_sort[i] + " ");
}

Console.WriteLine("\nInsertion sort: ");
for (int i = 0; i < array_for_insertion_sort.Length; i++)
{
    Console.Write(array_for_insertion_sort[i] + " ");
}

Console.WriteLine($"\nBubble sort had: {result_bubble_sort.Item1} swaps " +
    $"and {result_bubble_sort.Item2} comparisons");
Console.WriteLine($"Selection sort had: {result_selection_sort.Item1} swaps " +
    $"and {result_selection_sort.Item2} comparisons");
Console.WriteLine($"Insertion sort had: {result_insertion_sort.Item1} swaps " +
    $"and {result_insertion_sort.Item2} comparisons");

if (result_bubble_sort.Item1 < result_selection_sort.Item1
        && result_bubble_sort.Item1 < result_insertion_sort.Item1)
{
    Console.WriteLine($"Bubble sort has the minimum amount of " +
        $"swaps({result_bubble_sort.Item1})");
}
else if (result_selection_sort.Item1 < result_bubble_sort.Item1
        && result_selection_sort.Item1 < result_insertion_sort.Item1)
{
    Console.WriteLine($"Selection sort has the minimum amount of " +
        $"swaps({result_selection_sort.Item1})");
}
else
{
    Console.WriteLine($"Insertion sort has the minimum amount of " +
        $"swaps({result_insertion_sort.Item1})");
}

if (result_bubble_sort.Item2 < result_selection_sort.Item2
        && result_bubble_sort.Item2 < result_insertion_sort.Item2)
{
    Console.WriteLine($"Bubble sort has the minimum amount of " +
        $"comparisons({result_bubble_sort.Item2})");
}
else if (result_selection_sort.Item2 < result_bubble_sort.Item2
        && result_selection_sort.Item2 < result_insertion_sort.Item2)
{
    Console.WriteLine($"Selection sort has the minimum amount of " +
        $"comparisons({result_selection_sort.Item2})");
}
else
{
    Console.WriteLine($"Insertion sort has the minimum amount of " +
        $"comparisons({result_insertion_sort.Item2})");
}
