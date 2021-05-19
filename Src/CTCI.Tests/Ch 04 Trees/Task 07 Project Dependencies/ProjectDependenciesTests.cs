using System.Collections.Generic;
using CTCI.Ch_04_Trees.Task_07_Project_Dependencies;
using Xunit;

namespace CTCI.Tests.Ch_04_Trees.Task_07_Project_Dependencies
{
    public class ProjectDependenciesTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void GetBuildOrder(string[] projects, (string, string)[] dependencies, string[] expected)
        {
            var solution = new ProjectDependencies();

            var actual = solution.GetBuildOrder(projects, dependencies);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            var projects1 = new[] { "a", "b", "c", "d", "e", "f" };
            var dependencies1 = new[] { ("d", "a"), ("b", "f"), ("d", "b"), ("a", "f"), ("c", "d") };
            var order1 = new[] { "f", "a", "b", "d", "c", "e" };

            var projects2 = new[] { "a", "b", "c", "d", "e", "f" };
            var dependencies2 = new[] { ("d", "a"), ("b", "f"), ("d", "b"), ("a", "f"), ("c", "d"), ("f", "d") };
            string[] order2 = null;

            var projects3 = new[] { "a", "b", "c", "d", "e", "f" };
            var dependencies3 = new[] { ("a", "b"), ("b", "c"), ("c", "d"), ("d", "e"), ("e", "f") };
            var order3 = new[] { "f", "e", "d", "c", "b", "a" };

            yield return new object[] { projects1, dependencies1, order1 };
            yield return new object[] { projects2, dependencies2, order2 };
            yield return new object[] { projects3, dependencies3, order3 };
        }
    }
}