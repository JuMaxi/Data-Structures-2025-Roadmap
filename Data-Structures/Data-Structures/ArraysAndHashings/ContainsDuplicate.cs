namespace Data_Structures.ArraysAndHashings
{
    public class ContainsDuplicate
    {
        public bool Contains(int[] nums)
        {
            Dictionary<int, int> dic = new();

            foreach(int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    dic.Add(num, 0);
                }
            }
            return false;
        }
    }
}
