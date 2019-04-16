using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringReplaceCheckerSolution.Tests
{
    [TestClass()]
    public class StringReplaceCheckerTests
    {
        StringReplaceChecker solution;

        [TestInitialize]
        public void Setup()
        {
            solution = new StringReplaceChecker();
        }

        [TestMethod()]
        public void EqualTest()
        {
            var actual = solution.Solution("equal", "equal");
            var expected = "EQUAL";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertTest()
        {
            var actual = solution.Solution("nice", "niece");
            var expected = "INSERT e";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("form", "from", "SWAP o r")]
        [DataRow("for", "fro", "SWAP o r")]
        public void SWAPTest(string s, string t, string expected)
        {
            var actual = solution.Solution(s, t);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceTest()
        {
            var actual = solution.Solution("test", "tent");
            var expected = "REPLACE s n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ImpossibleTest()
        {
            var actual = solution.Solution("o", "odd");
            var expected = "IMPOSSIBLE";
            Assert.AreEqual(expected, actual);
        }
    }
}