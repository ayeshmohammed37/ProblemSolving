namespace Codewars;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        char ConvertToComplement(char ch) => ch switch
        {
            'A' => 'T',
            'T' => 'A',
            'G' => 'C',
            _ => 'G'
        };

        char[] complementStr = dna.ToCharArray();

        for (int i = 0; i < complementStr.Length; i++)
        {
            char ch = ConvertToComplement(complementStr[i]);
            complementStr[i] = ch;
        }


        return new string(complementStr);
    }
}