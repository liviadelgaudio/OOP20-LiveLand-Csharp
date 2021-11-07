using System;
using System.Collections.Generic;

namespace CSharp_Ines
{
    public class EnvironmentImpl : Environment
    {
        private List<PersonTicket> personList = new List<PersonTicket>();

        private EntranceImpl entrance = new EntranceImpl();

        List<PersonTicket> Environment.PersonList => throw new NotImplementedException();

        public void peopleEntrance(PersonTicket person)
        {
            personList.Add(person);
            entrance.addPerson(person);
        }

        public void exitPeople()
        {
            personList.RemoveAt(1);
        }

        public List<PersonTicket> getPersonList()
        {
            return personList;
        }

        public List<int> getEntranceProfit()
        {
            List<int> profit = new List<int>();
            profit.Add(this.entrance.getAdultProfit());
            profit.Add(this.entrance.getReducedProfit());
            profit.Add(this.entrance.getPassProfit());
            profit.Add(this.entrance.getNumTickets());
            return profit;
        }
        public EntranceImpl getEntrance()
        {
            return entrance;
        }

        IList<PersonTicket> Environment.getPersonList()
        {
            throw new NotImplementedException();
        }

        IList<int> Environment.getEntranceProfit()
        {
            throw new NotImplementedException();
        }
    }
}