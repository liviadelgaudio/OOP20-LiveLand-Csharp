using System;

namespace CSharp_Ines
{
    public class EnvironmentImpl : Environment
    {
        private const IList<PersonTicket> personList = new IList<PersonTicket>();
        
        private const EntranceImpl entrance = new EntranceImpl();

        public void peopleEntrance(PersonTicket person)
        {
            personList.Add(person);
            entrance.addPerson(person);
        }

        public void exitPeople()
        {
            personList.Remove(0);
        }

        public IList<PersonTicket> getPersonList()
        {
            return personList;
        }

        public IList<int> getEntranceProfit()
        {
            IList<int> profit = new IList<int>();
            profit.Add(this.entrance.getAdultProfit());
            profit.Add(this.entrance.getReducedProfit());
            profit.Add(this.entrance.getPassProfit());
            profit.Add(this.entrance.getNumTickets());
            return profit;
        }
    }
}