using System.Collections.Generic;
using CTCI.Ch_02_Linked_Lists.Task_08_Detect_Loop;
using Xunit;

namespace CTCI.Tests.Ch_02_Linked_Lists.Task_08_Detect_Loop
{
    public class DetectLoopTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void GetLoopStart1(
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> head,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> expected)
        {
            var solution = new DetectLoop();

            var actual = solution.GetLoopStart1(head);

            Assert.Same(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void GetLoopStart2(
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> head,
            CTCI.Ch_02_Linked_Lists.LinkedListNode<int> expected)
        {
            var solution = new DetectLoop();

            var actual = solution.GetLoopStart2(head);

            Assert.Same(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var head1 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2,
                    new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                        new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4,
                            new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(5,
                                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(6))))));
            var loopEnd1 = head1.Next.Next.Next.Next.Next;
            var expected1 = head1.Next.Next;
            loopEnd1.Next = expected1;

            var head2 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2,
                    new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                        new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4,
                            new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(5,
                                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(6))))));
            var expected2 = (CTCI.Ch_02_Linked_Lists.LinkedListNode<int>) null;

            var head3 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1);
            var expected3 = head3;
            expected3.Next = head3;

            var head4 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1,
                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(2,
                    new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(3,
                        new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(4,
                            new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(5,
                                new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(6))))));
            var loopEnd4 = head4.Next.Next.Next.Next.Next;
            var expected4 = head4;
            loopEnd4.Next = expected4;

            var head5 = new CTCI.Ch_02_Linked_Lists.LinkedListNode<int>(1);
            var expected5 = (CTCI.Ch_02_Linked_Lists.LinkedListNode<int>) null;

            yield return new object[] { head1, expected1 };
            yield return new object[] { head2, expected2 };
            yield return new object[] { head3, expected3 };
            yield return new object[] { head4, expected4 };
            yield return new object[] { head5, expected5 };
        }
    }
}