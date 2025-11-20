namespace Solutions.CourseSolutions;

public partial class Solution
{
    // Very fast and memory efficient, but hard to read
    private static int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }

        return result;
    }

    public void RunningSum()
    {
        int[] test = [3, 1, 2, 10, 1];

        var results = RunningSum(test);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}
