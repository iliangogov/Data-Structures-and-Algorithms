namespace Pattern
{
    using System;
    using System.Text;

    public class Program
    {
        private static string pattern = "urd";

        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            PrintPattern(input - 1);
        }

        private static void PrintPattern(int iterations)
        {
            if (iterations == 0)
            {
                Console.WriteLine(pattern);
                return;
            }

            var upgradedPattern = new StringBuilder();

            for (int i = pattern.Length - 1; i >= 0; i--)
            {
                var letter = pattern[i];
                upgradedPattern.Append(RotateRight(letter.ToString()));
            }

            upgradedPattern.Append("u");

            upgradedPattern.Append(pattern);

            upgradedPattern.Append("r");

            upgradedPattern.Append(pattern);

            upgradedPattern.Append("d");

            for (int i = pattern.Length - 1; i >= 0; i--)
            {
                var letter = pattern[i];
                upgradedPattern.Append(RotateLeft(letter.ToString()));
            }

            pattern = upgradedPattern.ToString();

            PrintPattern(iterations - 1);
        }

        private static string RotateLeft(string letter)
        {
            switch (letter)
            {
                case "u":
                    return "r";
                case "r":
                    return "d";
                case "d":
                    return "l";
                case "l":
                    return "u";
                default:
                    throw new ArgumentException("Not a valid move");
            }
        }

        private static string RotateRight(string letter)
        {
            switch (letter)
            {
                case "u":
                    return "l";
                case "r":
                    return "u";
                case "d":
                    return "r";
                case "l":
                    return "d";
                default:
                    throw new ArgumentException("Not a valid move");
            }
        }
    }
}
