namespace Data_Structures.ArraysAndHashings
{
    public class ContainsDuplicateTest
    {
        [Fact]
        public void Test1()
        {
            int[] nums = [ 1, 2, 3, 1 ];

            ContainsDuplicate contains = new();

            bool result = contains.Contains(nums);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = [1, 2, 3, 4];

            ContainsDuplicate contains = new();

            bool result = contains.Contains(nums);

            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

            ContainsDuplicate contains = new();

            bool result = contains.Contains(nums);

            Assert.True(result);
        }
    }
}