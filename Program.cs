namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }

    public class Solution
    {
        public int NumberOfBeams(string[] bank)
        {
            if (bank.Length == 0) return 0;

            var sum = 0;
            var prevRowSecurityDeviceCount = 0;

            // If the string is all 0's, can ignore
            foreach(string floor in bank)
            {
                var securityDevices = CountSecurityDevices(floor);
                if (securityDevices != 0)
                {
                    sum += prevRowSecurityDeviceCount * securityDevices;
                    prevRowSecurityDeviceCount = securityDevices;
                }
            }

            return sum;
        }

        private int CountSecurityDevices(string row) => row.Count(i => i == '1');
    }
}
