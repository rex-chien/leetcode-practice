using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class ContainsDuplicateIIITests
    {
        [TestMethod]
        public void ReconstructQueueTest_nums_1_2_3_1_k_3_t_0_Expected_true()
        {
            GivenNumsAndKAndTShouldEqual(
                new[] {1, 2, 3, 1},
                3,
                0,
                true);
        }

        [TestMethod]
        public void ReconstructQueueTest_nums_1_5_9_k_1_t_3_Expected_false()
        {
            GivenNumsAndKAndTShouldEqual(
                new[] {1, 5, 9},
                1,
                3,
                false);
        }

        private static void GivenNumsAndKAndTShouldEqual(int[] nums, int k, int t, bool expected)
        {
            // arrange
            var sut = new ContainsDuplicateIII();

            // act
            var actual = sut.ContainsNearbyAlmostDuplicate(nums, k, t);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}