namespace Data_Structures.ArraysAndHashings
{
    public class ValidAnagramTest
    {
        [Fact]
        public void Test01()
        {
            string s = "anagram";
            string t = "nagaram";

            ValidAnagram valid = new();

            bool result = valid.IsAnagram(s, t);

            Assert.True(result);
        }

        [Fact]
        public void Test02()
        {
            string s = "rat";
            string t = "car";

            ValidAnagram valid = new();

            bool result = valid.IsAnagram(s, t);

            Assert.False(result);
        }

        [Fact]
        public void Test03()
        {
            string s = "banana";
            string t = "bbnana";

            ValidAnagram valid = new();

            bool result = valid.IsAnagram(s, t);

            Assert.False(result);
        }
    }
}
