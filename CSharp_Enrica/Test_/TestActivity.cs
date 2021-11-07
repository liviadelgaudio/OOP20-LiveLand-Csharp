using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Enrica;

namespace Test_
{
    /// <summary>
    /// This class tests the different color between activity1 and activity2, 
    ///tests that activity1 has the same height and width as the one assigned, 
    ///tests that activity1 and activity2 have a different x and a different y.
    /// </summary>
    [TestClass]
    public class TestActivity 
    {
        public ActivityImpl activity1 = new ActivityImpl(50, 60, 4, 5, System.ConsoleColor.Red);
        public ActivityImpl activity2 = new ActivityImpl(80, 40, 23, 8, System.ConsoleColor.Yellow);

        [TestMethod]
        public void DifferentColor()
        {
            Assert.AreNotEqual(activity1.GetColor(), activity2.GetColor());
        }
        [TestMethod]
        public void Width()
        {
            Assert.AreEqual(50, activity1.GetWidth());
        }
        [TestMethod]
        public void Height()
        {
            Assert.AreEqual(60, activity1.GetHeight());
        }
        [TestMethod]
        public void X()
        {
            Assert.AreNotEqual(activity1.Getx(), activity2.Getx());
        }

        [TestMethod]
        public void Y()
        {
            Assert.AreNotEqual(activity1.Gety(), activity2.Gety());

        }
     
    }
}

