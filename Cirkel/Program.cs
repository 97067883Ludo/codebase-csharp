class main 
{
    static int Main(string[] args) 
    {
        while (true)
        {

        Console.WriteLine("Voer een diameter in. ");

        string? input = Console.ReadLine();

        if (!int.TryParse(input, out _)) {
            
            switch (input)
            {
                case "exit":
                    Console.WriteLine("Bye!");
                    return 0;
                default:
                    Console.WriteLine("You need to fill in a valid number...");
                    continue;
            }
        }
        
        double diameter = Convert.ToDouble(input);

        Circle circle = new Circle(diameter);

        Console.WriteLine(string.Format("de oppervlakte is: {0:0.00}", circle.surface));

        Console.WriteLine(string.Format("de omtrek is: {0:0.00}", circle.circumference));

        Console.WriteLine(" ");
        }
    }
}