using System.Collections.Generic;

namespace CSharp_Valentina
{
    public class Profit : Activity 
    {   
        private string name;
        private int totMoney;
        private int totPeople;
        private ActivityType activityType;
        private List<PersonTicket> personList = new List<PersonTicket>();

        public Profit(string name, ActivityType activityType) 
        {
            this.name = name;
            this.activityType = activityType;
        }

        /// <inheritdoc/>
        public void AddPerson(PersonTicket person)
        {
            personList.Add(person);
            totPeople++;
        }

        /// <inheritdoc/>
        public void RemovePerson() 
        {
            personList.Clear();
        }

        /// <summary>
        /// Return money earned in one race.
        /// </summary>
        public int GetProfit() 
        {
            totMoney = 10;
            return totMoney;
        }

        /// <inheritdoc/>
        public int GetTotPeople() 
        {
            return totPeople;
        }

        /// <inheritdoc/>
        public ActivityType GetActivityType() 
        {
            return this.activityType;
        }

        /// <summary>
        /// Return name.
        /// </summary>
        public string GetName() 
        {
            return this.name;
        }

        /// <inheritdoc/>
        public List<PersonTicket> GetPeopleList() 
        {
            return personList;
        }
    }
}