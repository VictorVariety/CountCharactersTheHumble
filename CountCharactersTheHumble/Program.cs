namespace CountCharactersTheHumble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadTextAndShowCharacterCounts(255);
        }

        private static void ReadTextAndShowCharacterCounts(int range)
        {
            string text = "whatever";
            while (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Type anything");
                text = Console.ReadLine().ToLower();

                var counts = CharacterCounts(range, text);
                PrintCounts(range, counts, text);
            }
        }

        private static void PrintCounts(int range, int[] counts, string text)
        {
            for (int i = 0; i < range; i++)
            {
                if (counts[i] == 0) continue;
                var character = (char)i;
                //(char) tvinger det tilbake til en tegn.
                var percent = (counts[i] * 100) / text.Length;

                Console.WriteLine("\"" + character + "\" - " + counts[i] + " Which is " + percent + "% of total characters");
            }
        }

        private static int[] CharacterCounts(int range, string text)
        {
            var counts = new int[range];
            foreach (var character in text)
            //En string "er" en array av tegnene stringen
            {
                counts[(int)character]++;
                //(int)character tvinger character å bli tolket som en int, ASCII
            }
            return counts;
        }
    }
}