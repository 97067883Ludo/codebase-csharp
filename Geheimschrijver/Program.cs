using System.Text;

namespace geheimschrijver 
{
    class geheimschrijver 
    {
        static int Main(string[] args)
        {

            IDictionary<char, string> morseCode = new Dictionary<char, string>(){
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-..."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', "..."},
                {'j', ".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-.--"},
                {'z',"--.."},
            };

            Console.WriteLine("Voer uw text in.");
            string? input = Console.ReadLine();

            if(input == null) {
                Console.WriteLine("Uw moet tekst invoeren");
                return 1;
            }
            
            morseCodeEncode((Dictionary<char, string>)morseCode, input);

            return 0;
        }

        private static void morseCodeEncode(Dictionary<char, string> morseCode, string input) {
            StringBuilder sb = new StringBuilder();

            for(int index = 0; index < input.Length; index++) {
                if(morseCode.ContainsKey(input[index])){

                     sb.Append(morseCode[input[index]]);
                } else {
                    sb.Append(input[index]);
                }
            }
            Console.WriteLine(sb.ToString());
            
        }
    }
}