using System.Linq;
using ExpectedObjects;
using LeetCodePractice;
using LeetCodePractice.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePracticeTests.Medium
{
    [TestClass]
    public class AddTwoNumberTests
    {
        [TestMethod]
        public void SolutionTest_l1_2_4_3_l2_5_6_4_Output_7_0_8()
        {
            GivenTwoNumbersArrayShouldGet(new[] {2, 4, 3}, new[] {5, 6, 4}, new[] {7, 0, 8});
        }

        private void GivenTwoNumbersArrayShouldGet(int[] numbers1, int[] numbers2, int[] expectedNumbers)
        {
            // arrange
            var l1 = CreateListNodes(numbers1);
            var l2 = CreateListNodes(numbers2);
            var sut = new AddTwoNumbers();

            // act
            var actual = sut.Solution(l1, l2);
            var expected = CreateListNodes(expectedNumbers);

            // assert
            actual.ToExpectedObject().ShouldEqual(expected);
        }

        private ListNode CreateListNodes(int[] numbers)
        {
            var output = new ListNode(numbers[0]);
            var currentNode = output;

            foreach (var n in numbers.Skip(1))
            {
                currentNode.next = new ListNode(n);
                currentNode = currentNode.next;
            }

            return output;
        }
    }
}