using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Valentina;

[TestClass]
public class TestProfit
{
    private readonly Profit rest1 = new Profit("pizza",ActivityType.REST);
    private readonly Profit shop1 = new Profit("Gingilli", ActivityType.SHOP);
    private readonly PersonTicket per1 = new PersonTicket(13);
    private readonly PersonTicket per2 = new PersonTicket(42);

    /// <summary>
    /// Control type of profit.
    /// </summary>
    [TestMethod]
    public void ProfitType() 
    {
        Assert.AreNotEqual(shop1.GetActivityType(), rest1.GetActivityType());
    }

    /// <summary>
    /// Control entrance in the profit.
    /// </summary>
    [TestMethod]
    public void PeopleEntraceShop() 
    {
        shop1.AddPerson(per1);
        shop1.AddPerson(per2);
        Assert.AreEqual(2, shop1.GetTotPeople());
    }

    /// <summary>
    /// Control exit in the profit.
    /// </summary>
    [TestMethod]
    public void ExitShop()
    {
        shop1.RemovePerson();
        Assert.AreEqual(0, shop1.GetTotPeople());
    }

    /// <summary>
    /// Control money.
    /// </summary>
    [TestMethod]
    public void TotalProfit() 
    {
        shop1.GetProfit();
        Assert.AreNotEqual(0, shop1.GetProfit());
    }

}