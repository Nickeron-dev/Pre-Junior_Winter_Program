Console.WriteLine("HI!");

Console.WriteLine("Input price of 1 copybook: ");
int PriceOfOneCopybook = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input amount of copybooks: ");
int AmountOfCopybooks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input price of 1 pen: ");
int PriceOfOnePen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input amount of pens: ");
int AmountOfPens = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total: " + (PriceOfOneCopybook * AmountOfCopybooks
    + PriceOfOnePen * AmountOfPens) + " hryvnias.");
