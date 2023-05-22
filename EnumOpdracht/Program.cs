namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colors myMainColorTheme = Colors.blue;

            if (myMainColorTheme == Colors.red)
            {
                Console.WriteLine("it is red!");
            }
            else if (myMainColorTheme == Colors.green)
            {
                Console.WriteLine("it is green!");
            }
            else if (myMainColorTheme == Colors.blue)
            {
                Console.WriteLine("it is blue!");
            }
            else if (myMainColorTheme == Colors.yellow)
            {
                Console.WriteLine("it is yellow!");
            }
        }
    }
}