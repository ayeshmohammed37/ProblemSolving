namespace Codewars;

public partial class Solution
{
  public static int DuplicateCount(string str)
  {
    int cnt = 0;
    int[] alphaFreq = new int[26];
    int[] digitFreq = new int[10];
    int idx = default;

    foreach (char ch in str)
    {
      if (Char.IsDigit(ch))
      {
        idx = ch - '0';
        digitFreq[idx]++;
        if (digitFreq[idx] == 2)
        {
          cnt++;
        }
      }
      else
      {
        char c;
        c = Char.ToLower(ch);
        idx = c - 'a';
        alphaFreq[idx]++;
        if (alphaFreq[idx] == 2)
        {
          cnt++;
        }
      }
    }

    return cnt;
  }
}