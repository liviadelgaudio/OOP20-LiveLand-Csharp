using System;
using System.Collections.Generic;

namespace CSharp_Valentina
{
    public interface Activity
    {
        /// <summary>
        /// Return type of activity.
        /// </summary>
        ActivityType GetActivityType();

        /// <summary>
        /// Add people to the people's list of every single Activity.
        /// </summary>
        /// <param name="person"></param>
        void AddPerson(PersonTicket person);

        /// <summary>
        /// Clear people's list.
        /// </summary>
        void RemovePerson();

        /// <summary>
        /// Return list of the people of every single race of every single Activity.
        /// </summary>
        List<PersonTicket> GetPeopleList();

        /// <summary>
        /// Return number of people who have been in each single Activity.
        /// </summary>
        int GetTotPeople();
    }
}
