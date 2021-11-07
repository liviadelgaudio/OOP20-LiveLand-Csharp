using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Valentina;

namespace Test
{
    [TestClass]
    public class TestFair
    {
        private readonly Fair fair1 = new Fair("bruco", 12, ActivityType.BABYFAIR);
        private readonly Fair fair2 = new Fair("Katun", 13, ActivityType.FAIR);
        private readonly PersonTicket per1 = new PersonTicket(13);
        private readonly PersonTicket per2 = new PersonTicket(42);

        /// <summary>
        /// Control type of fair.
        /// </summary>
        [TestMethod]
        public void FairType()
        {
            Assert.AreNotEqual(fair1.GetActivityType(), fair2.GetActivityType());
        }

        /// <summary>
        /// Control entrance in the fair.
        /// </summary>
        [TestMethod]
        public void PeopleEntraceFair()
        {
            fair1.AddPerson(per1);
            fair1.AddPerson(per2);
            Assert.AreEqual(2, fair1.GetTotPeople());
        }

        /// <summary>
        /// Control exit in the fair.
        /// </summary>
        [TestMethod]
        public void ExitFair()
        {
            fair1.RemovePerson();
            Assert.AreEqual(0, fair1.GetTotPeople());
        }

        /// <summary>
        /// Control age.
        /// </summary>
        [TestMethod]
        public void ControlAgeTest()
        {
            Assert.IsTrue(fair2.ControlAge(46));
            Assert.IsFalse(fair2.ControlAge(11));
        }
    }
}