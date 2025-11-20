namespace Solutions.CourseSolutions;

public partial class Solution
{
    // Very fast and memory efficient, but hard to read
    private int LongestOnes(int[] nums, int k)
    {
        int LPointer = 0;
        int RPointer = 0;

        int maxLength = 0;
        int currLength = 0;
        int flips = 0;

        while(RPointer < nums.Length)
        {
            if(nums[RPointer] == 1)
            {
                currLength++;
                RPointer++;
            }
            else {
                if (flips < k)
                {
                    flips++;
                    currLength++;
                    RPointer++;
                }
                else
                {
                    if (nums[LPointer] == 0)
                    {
                        flips--;
                    }
                    currLength--;
                    LPointer++;
                }
            }

        maxLength = Math.Max(currLength, maxLength);
        }

        return maxLength;
    }

    public void LongestOnes()
    {
        //int[] testNums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
        //int testK = 3;

        int[] testNums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
        int testK = 3;
        Console.WriteLine(LongestOnes(testNums, testK));
    }
}