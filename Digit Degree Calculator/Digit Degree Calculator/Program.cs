namespace Digit_Degree_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BadDigitDegree(91));
            Console.WriteLine(RecursiveDigitDegree(91));
        }

        public static int BadDigitDegree(int n)
        {
            int result = 0;
            var digit = n.ToString().ToCharArray();
            int sum = 0;

            if(digit.Length > 1)
            {
                do
                {
                    sum = digit.Sum(x => int.Parse(x.ToString()));
                    result++;
                    digit = digit.Sum(x => Convert.ToUInt32(x.ToString()))
                        .ToString()
                        .ToCharArray();
                } while (sum >= 10);
            }

            return result;
        }

        public static int RecursiveDigitDegree(int n)
        {
            return n < 10
                ? 0
                : 1 + RecursiveDigitDegree((int)n.ToString().Sum(Char.GetNumericValue));
        }
    }
}
