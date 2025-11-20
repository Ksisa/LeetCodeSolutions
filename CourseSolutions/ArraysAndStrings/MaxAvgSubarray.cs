namespace Solutions.CourseSolutions;

public partial class Solution
{
    private double FindMaxAverage(int[] nums, int k)
    {
        
        int LPointer = 0;
        int RPointer = 0;

        double currentSum = 0;
        double maxAverage = double.MinValue;

        while (RPointer < nums.Length)
        {
            currentSum += nums[RPointer];

            if(RPointer - LPointer + 1 < k)
            {
                RPointer++;
                continue;
            }

            maxAverage = Math.Max(maxAverage, currentSum / k);
            currentSum -= nums[LPointer];
            LPointer++;
            RPointer++;
        }

        return maxAverage;
    }

    public void FindMaxAverage()
    {
        //int[] testNums = [1, 12, -5, -6, 50, 3];
        //int testK = 4;

        //int[] testNums = [5];
        //int testK = 1;

        //int[] testNums = [0, 1, 1, 3, 3];
        //int testK = 4;

        int[] testNums = [-1];
        int testK = 1;

        Console.WriteLine(FindMaxAverage(testNums, testK));
    }
}
