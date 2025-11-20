namespace Solutions.CourseSolutions;

public partial class Solution
{
    private void ReverseString(char[] s)
    {
        int LPoint = 0;
        int RPoint = s.Length - 1;
        char temp;

        while (RPoint > LPoint)
        {
            temp = s[LPoint];
            s[LPoint] = s[RPoint];
            s[RPoint] = temp;
            LPoint++;
            RPoint--;
        }
    }

    public void ReverseString()
    {
        char[] test = ['C', 'h', 'a', 'r'];
        ReverseString(test);
    }
}
