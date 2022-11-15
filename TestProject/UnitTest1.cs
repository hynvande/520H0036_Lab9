using StudentServiceLib;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Student s;
        [TestMethod]
        public void testCase1()
        {
            Student student = new Student();
            student.Score = 8;
            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter);
        }
    }
}