using System;

namespace CSharp_Ines
{
    public class EntranceImpl
    {
       private int profit;
       private int numTickets;
       private int adultProfit;
       private int reducedProfit;
       private int passProfit;

       private enum Ticket{SEASON_PASS, ADULT, REDUCED};

       ///<summary> Increments the profit based on ticket type. </summary>
       ///<param name="person"> personTicket </param>
       public void addPerson(PersonTicket person)
       {
           switch (person.getTicket())
           {
            case Ticket.ADULT:
                adultProfit = adultProfit + 20;
                profit = profit + 20;
                break;
            case Ticket.REDUCED:
                reducedProfit = reducedProfit + 15;
                profit = profit + 15;
                break;
            case Ticket.SEASON_PASS:
                passProfit = passProfit + 35;
                profit = profit + 35;
                break;
            default:
                break;
           }
           numTickets++;
       }

       ///<returns> returns the total profit </returns>
       public int getProfit()
       {
           return profit;
       }

       ///<returns> returns the number of tickets </returns>
       public int getNumTickets()
       {
           return numTickets;
       }

       ///<returns> returns the profit of adult ticket </returns>
       public int getAdultProfit()
       {
           return adultProfit;
       }

       ///<returns> returns the profit of reduced ticket </returns>
        public int getReducedProfit()
        {
            return reducedProfit;
        }

        ///<returns> returns the profit of season pass ticket </returns>
        public int getPassProfit()
        {
            return passProfit;
        }
    
    }
}