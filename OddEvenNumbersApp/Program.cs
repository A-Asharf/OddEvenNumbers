namespace CA01 {

    class Program
    {
        public static void Main()
        {
            int[] numList = new[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("Print All Numbers" , numList);
            PrintNumbers("Print All Even Numbers", numList.Where(x=>IsEven(x)));
            PrintNumbers("Print All Odd Numbers", numList.Where(x => IsOdd(x)));
        }

        public static void PrintNumbers(string title , IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title} [ ");
            foreach (var num in numbers)
            {
                Console.Write($" {num} ");

            }
            Console.Write(" ]");
            Console.WriteLine();
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
