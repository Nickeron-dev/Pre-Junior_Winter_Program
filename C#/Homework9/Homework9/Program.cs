Automobile[] array = new Automobile[2];
array[0] = new Vehicle("Volvo", 180, 5900);
array[1] = new Car("BMW", 240, 5);

Automobile fastest = array[0];
foreach (var i in array)
{
    if (i.get_max_speed() > fastest.get_max_speed())
    {
        fastest = i;
    }
}
Console.WriteLine("The fastest car: ");
fastest.to_string();

class Automobile
{
    protected string name;
    protected int max_speed;

    public Automobile(string name, int max_speed)
    {
        this.name = name;
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

    public virtual void to_string()
    {
        Console.WriteLine($"Name: {name}\n max speed: {max_speed}");
    }
}

class Car : Automobile
{
    private int seats;

    public Car(string name, int max_speed, int seats)
        : base(name, max_speed)
    {
        this.seats = seats;
    }

    public int get_seats()
    {
        return seats;
    }

    public void set_seats(int seats)
    {
        this.seats = seats;
    }

    public override void to_string()
    {
        Console.WriteLine($"Name: {this.name}\n max speed: {max_speed}\n " +
            $"seats: {seats}\n");
    }
}

class Vehicle : Automobile
{
    private int max_weight;

    public Vehicle(string name, int max_speed, int max_weight)
        : base(name, max_speed)
    {
        this.max_weight = max_weight;
    }

    public int get_max_weight()
    {
        return max_weight;
    }

    public void set_max_weight(int max_weight)
    {
        this.max_weight = max_weight;
    }

    public override void to_string()
    {
        Console.WriteLine($"Name: {this.name}\n max speed: {max_speed}\n " +
            $"maximum weight: {max_weight}\n");
    }
}
