namespace Data_Structures.ArraysAndHashings
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> dic = new();

            foreach(char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c] += 1;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            foreach(char c in t)
            {
                if (!dic.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dic[c] -= 1;
                }
            }

            foreach(KeyValuePair<char, int> myDict in dic)
            {
                if (dic[myDict.Key] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
