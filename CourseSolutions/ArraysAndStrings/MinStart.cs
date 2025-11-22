namespace Solutions.CourseSolutions;

public partial class Solution
{
    private int MinStartValue(int[] nums)
    {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        int min = prefixSum.Min();

        if(min < 0)
        {
            return Math.Abs(min) + 1;
        }
        else
        {
            return 1;
        }
    }

    public void MinStartValue()
    {
        int[] nums = [2, 3, 5, -5, -1];
        Console.WriteLine(MinStartValue(nums));
    }
}
