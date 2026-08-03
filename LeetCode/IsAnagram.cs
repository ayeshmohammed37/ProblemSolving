namespace LeetCode;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        // Hash Map
        Dictionary<char, int> sCount = new Dictionary<char, int>();
        Dictionary<char, int> tCount = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sCount[s[i]] = sCount.ContainsKey(s[i]) ? sCount[s[i]] + 1 : 1;
            tCount[t[i]] = tCount.ContainsKey(t[i]) ? sCount[t[i]] + 1 : 1;
        }

        return sCount.Count == tCount.Count && !sCount.Except(tCount).Any();
    }
}