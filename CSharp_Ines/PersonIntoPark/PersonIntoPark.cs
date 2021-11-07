using CSharp_Ines;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PersonIntoPark
{
    [TestClass]
    public class PersonIntoPark
    {


		private EnvironmentImpl environment = new EnvironmentImpl();
		private PersonTicket per1 = new PersonTicket();
		private PersonTicket per2 = new PersonTicket();
		private PersonTicket per3 = new PersonTicket();
		private PersonTicket per4 = new PersonTicket();
		private PersonTicket per5 = new PersonTicket();
		private PersonTicket per6 = new PersonTicket();
		private PersonTicket per7 = new PersonTicket();
		private PersonTicket per8 = new PersonTicket();
		private PersonTicket per9 = new PersonTicket();
		private PersonTicket per10 = new PersonTicket();

		[TestMethod]

		public void PeopleEntrance()
		{
			environment.peopleEntrance(per1);
			environment.peopleEntrance(per2);
			environment.peopleEntrance(per3);
			environment.peopleEntrance(per4);
			environment.peopleEntrance(per5);
			environment.peopleEntrance(per6);
		}

		[TestMethod]
		public void TotalProfitTest()
		{
			int totalProfit = 0;
			totalProfit = +environment.getEntrance().getAdultProfit();
			totalProfit = +environment.getEntrance().getPassProfit();
			totalProfit = +environment.getEntrance().getReducedProfit();
			Assert.AreEqual(environment.getEntrance().getProfit(), totalProfit);
			Assert.AreEqual(environment.getEntrance().getNumTickets(), environment.getPersonList().Count);


		}

		[TestMethod]
		public void ProfitTest()
		{
			Assert.IsNotNull( environment.getEntrance().getProfit());
		}

	}


}
