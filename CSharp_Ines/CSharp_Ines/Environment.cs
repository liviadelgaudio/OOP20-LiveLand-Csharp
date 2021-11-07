using System;
using System.Collections.Generic;

namespace CSharp_Ines
{
    public interface Environment
    {
        List<PersonTicket> PersonList { get; }

        ///<summary> Adding a new person into the park.</summary>
        /// <param name="person"> personTicket </param>
        void peopleEntrance(PersonTicket person);

       /// <summary> deletes the first person of the list. </summary>
       void exitPeople();

       ///<returns> returns list of people into the park </returns>
       IList<PersonTicket> getPersonList();

       ///<returns> returns list with all the profits </returns>
       IList<int> getEntranceProfit();

       ///<returns> returns the class entrance </returns>
       EntranceImpl getEntrance();
    
    }
}