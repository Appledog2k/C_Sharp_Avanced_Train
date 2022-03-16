namespace Delegate
{
    class Delegate
    {
        public static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }
        public static int Sum(int a, int b) => a+b;
        public static int Diff(int a, int b) => a-b;


    }
}