IFlyable[] everything_that_can_fly = new IFlyable[2];
everything_that_can_fly[0] = new Sparrow();
everything_that_can_fly[1] = new Plane();

everything_that_can_fly[0].ActionFly();
everything_that_can_fly[0].ActionLand();
everything_that_can_fly[1].ActionFly();
everything_that_can_fly[1].ActionLand();
Sparrow s = (Sparrow) everything_that_can_fly[0];
s.SayName();
Plane p = (Plane) everything_that_can_fly[1];
p.PrintModel();

interface IFlyable
{
    public void ActionFly();
    public void ActionLand();
}

abstract class Bird : IFlyable
{
    public void ActionFly()
    {
        Console.WriteLine("Bird is flying");
    }
    public void ActionLand()
    {
        Console.WriteLine("Bird is landing");
    }

    public abstract void SayName();
}

class Sparrow : Bird
{
    public override void SayName()
    {
        Console.WriteLine("I'm Sparrow");
    }
}

class Plane : IFlyable
{
    public void ActionFly()
    {
        Console.WriteLine("Plane is flying");
    }
    public void ActionLand()
    {
        Console.WriteLine("Plane is landing");
    }

    public void PrintModel()
    {
        Console.WriteLine("Model: Cirrus Vision Jet");
    }
}
