using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Enrica;

namespace Test_
{
    /// <summary>
    /// This class tests the different color between baby and adult, 
    /// tests that baby and pass have a different x, a different y and  a different radius.
    /// </summary>
    [TestClass]
    public class TestPerson
    {
        public PersonImpl Baby = new PersonImpl(50, System.ConsoleColor.Green, 5, 7);
        public PersonImpl Adult = new PersonImpl(70, System.ConsoleColor.Yellow, 8, 9);
        public PersonImpl Pass = new PersonImpl(60, System.ConsoleColor.Gray, 15, 25);

        [TestMethod]
        public void DifferentColor()
        {
            Assert.AreNotEqual(Baby.GetColor(), Adult.GetColor());
        }

        [TestMethod]
        public void X()
        {
            Assert.AreNotEqual(Baby.Getx(), Pass.Getx());
        }

        [TestMethod]
        public void Y()
        {
            Assert.AreNotEqual(Adult.Gety(), Pass.Gety());
        }

        [TestMethod]
        public void radius()
        {
            Assert.AreNotEqual(Baby.GetRadius(), Adult.GetRadius());
        }

    }
}
