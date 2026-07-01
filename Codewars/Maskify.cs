namespace Codewars;

public partial class Solution
{
    // return masked string
    public static string Maskify(string cc)
    {
        if (cc.Length <= 4)
        {
            return cc;
        }

        string ans = "";

        for (int i = 0; i < cc.Length - 4; i++)
        {
            ans += "#";
        }

        ans = ans + cc[^4..^0];

        return ans;

    }
}
