namespace CSharp_Practice
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPref(string[] strs) {
        string pref = "";
        if (strs == null || strs.Length == 0)
        {
            return pref;
        }
        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            { 
                if (i == strs[j].Length || strs[j][i] != c )
                {
                    return strs[0].Substring(0, i);

                }

            }

        }
        return strs[0];
    }
    }
}