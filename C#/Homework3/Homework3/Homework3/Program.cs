Console.WriteLine("Input a number: ");
int value = Convert.ToInt32(Console.ReadLine());
String value_to_string = Convert.ToString(value);
int answer = 0;
for (int i = 0; i < value_to_string.Length; i++)
{
    answer += value_to_string[i] - 48;
}
Console.WriteLine($"The sum is: {answer}");
