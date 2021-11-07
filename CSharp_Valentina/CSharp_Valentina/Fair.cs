using System.Collections.Generic;
using System;

namespace CSharp_Valentina
{
    public class Fair : Activity
    {
        private string name;
        private int totPeople;
        private int capacity;
        private const int MIN_AGE = 12;
        private ActivityType activityType;
        private List<PersonTicket> personList = new List<PersonTicket>();

        public Fair(string name, int capacity, ActivityType activityType)
        {
            this.name = name;
            this.capacity = capacity;
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

        /// <inheritdoc/>
        public int GetTotPeople()
        {
            return totPeople;
        }

        /// <summary>
        /// Return capacity.
        /// </summary>
        public int GetCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Control age.
        /// </summary>
        /// <param name="age"></param>
        public bool ControlAge(int age)
        {
            return age > MIN_AGE;
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