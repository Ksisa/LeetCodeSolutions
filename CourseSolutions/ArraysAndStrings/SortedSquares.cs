namespace Solutions.CourseSolutions;

public partial class Solution
{
    // Very fast and memory efficient, but hard to read
    private static int[] SortedSquares(int[] nums)
    {
        int LPoint = 0;
        int RPoint = nums.Length - 1;

        var result = new int[nums.Length];

        int LSquare = nums[LPoint] * nums[LPoint];
        int RSquare = nums[RPoint] * nums[RPoint];

        for (int i = nums.Length - 1; i >= 0 ; i--)
        {
            if (LSquare > RSquare)
            {
                result[i] = LSquare;
                LPoint++;
                if(LPoint >= 0)
                {
                    LSquare = nums[LPoint] * nums[LPoint];
                }
                
            }
            else
            {
                result[i] = RSquare;
                RPoint--;
                if(RPoint >= 0)
                {
                    RSquare = nums[RPoint] * nums[RPoint];
                }
            }
        }

        return result;
    }

    public int[] SortedSquares()
    {
        int[] test = [0,2];
        return SortedSquares(test);
    }
}
