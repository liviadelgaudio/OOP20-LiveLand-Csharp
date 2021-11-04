using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Livia;

namespace Test
{
    [TestClass]
    public class ActivityInsertionTest
    {

        private EnvironmentControllerImpl controller = new EnvironmentControllerImpl();
        private ViewActivityImpl act1 = new ViewActivityBuilder("katun", ActType.ActivityType.FAIR).Capacity(15).Build();
        private ViewActivityImpl act2 = new ViewActivityBuilder("bruco mela", ActType.ActivityType.BABYFAIR).Capacity(25).Build();
        private ViewActivityImpl act3 = new ViewActivityBuilder("burger king", ActType.ActivityType.REST).MinPrice(2).MaxPrice(30).Build();
        private ViewActivityImpl act4 = new ViewActivityBuilder("pizza pazza", ActType.ActivityType.REST).MinPrice(10).MaxPrice(25).Build();
        private ViewActivityImpl act5 = new ViewActivityBuilder("souvenirs", ActType.ActivityType.SHOP).MinPrice(1).MaxPrice(15).Build();

[TestMethod]
        public void TestActivityCreation()

        {
            Assert.AreNotEqual(act1, act2);
            Assert.AreNotEqual(this.act3, this.act5);
            Assert.AreEqual(this.act3.GetActivityType(),
                    this.act4.GetActivityType());
        }
    }
}
