using Solutions.CourseSolutions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.RunningSum();

            Console.WriteLine("Done, press enter to exit");
            Console.ReadLine();
        }
    }
}
