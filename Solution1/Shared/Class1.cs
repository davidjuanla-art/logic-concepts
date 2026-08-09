namespace Shared;

public static class ConsoleExtension
{
            public static int GetInt(string message)
            {

                Console.Write(message);
                var numberString = Console.ReadLine();
                if (int.TryParse(numberString, out int numberInt))
                {
                    return numberInt;
                }
                return 0;
            }


        public static string? GetValidOptions(string massage, List<string> options)
        {

            Console.Write(massage);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;

            }   
            return null;
        }
}