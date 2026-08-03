namespace LeetCode;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        // Sorting
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        return sArr.SequenceEqual(tArr);
    }
}