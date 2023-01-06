    class arrays {

        static void Main(string[] args) 
        {
            string[] pgLanguages = {"PHP", "C#", "HTML", "JavaScript", "Java", "c++", "C"};
            string[] addPgLanguages = {"Pyhon", "Swift"};

            var tests = new List<string>();

            tests.AddRange(pgLanguages);

            tests.AddRange(addPgLanguages);

            tests.Sort();
        }
    }