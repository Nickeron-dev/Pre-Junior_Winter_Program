Console.WriteLine("Input name of the first car: ");
string first_name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Input max speed of the first car: ");
int first_max_speed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input name of the second car: ");
string second_name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Input max speed of the second car: ");
int second_max_speed = Convert.ToInt32(Console.ReadLine());

Car first_car = new Car(first_name, first_max_speed);
Car second_car = new Car(second_name, second_max_speed);

if (first_car.get_max_speed() > second_car.get_max_speed())
{
    Console.WriteLine($"The car: {first_car.get_name()} is faster");
}
else
{
    Console.WriteLine($"The car: {second_car.get_name()} is faster");
}


class Car
{
    string name;
    int max_speed;

    public Car (string name, int max_speed)
    {
        this.name = name;
        this.max_speed = max_speed;
    }

    public Car (int max_speed)
    {
        name = "Unknown";
        this.max_speed = max_speed;
    }

    public int get_max_speed()
    {
        return max_speed;
    }

    public string get_name()
    {
        return name;
    }

    public void set_max_speed(int max_speed)
    {
        this.max_speed = max_speed;
    }

    public void set_name(string name)
    {
        this.name = name;
    }

    public void to_string()
    {
        Console.WriteLine($"Name: {name}\n max speed: {max_speed}");
    }
}
