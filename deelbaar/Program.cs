namespace app
{
    class deelbaar
    {
        public static int Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Voer een diameter in. ");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out _))
                {
                    Console.WriteLine(input);
                    switch (input)
                    {
                        case null:
                        case "exit":
                            Console.WriteLine("Bye!");
                            return 0;
                        default:
                            Console.WriteLine("You need to fill in a valid number...");
                            continue;
                    }
                }

                int divideNumber = int.Parse(input);

                if(divideNumber % 2 == 0) {
                    Console.WriteLine("Het getal is deelbaar.");
                } else {
                    Console.WriteLine("Sorry, het getal is niet deelbaar.");
                }
            }
        }
    }
}
