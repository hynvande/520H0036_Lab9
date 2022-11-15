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
        
         [TestMethod]
        public void testCase2()
        {
            Student student = new Student();
            student.Score = 7.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        
        [TestMethod]
        public void testCase3()
        {
            Student student = new Student();
            student.Score = 6.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void testCase4()
        {
            Student student = new Student();
            student.Score = 3.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void testCase5()
        {
            Student student = new Student();
            student.Score = 2.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('E', letter);
        }

    }
    
}
