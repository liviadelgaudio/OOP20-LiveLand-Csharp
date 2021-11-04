using System;
namespace CSharp_Ines
{
    public class PersonTicket
    {
       private static const int AGE_MIN = 2;
       private static const int AGE_MAX = 95;
       private static const int AGE_MAX_REDUCED = 65;
       private static const int AGE_MIN_REDUCED = 12;
       private int age;

        private enum Ticket{SEASON_PASS, ADULT, REDUCED};

       public PersonTicket()
       {
           this.age = this.randAge();
           this.ticket = this.randTicket();
       }  

        ///<returns> returns random age of the person </returns>
        public int randAge()
        {
            var rand = new Random();
            return rand.Next(AGE_MIN,AGE_MAX);
        }

        ///<returns> returns the age of the person </returns>
        public int getAge()
        {
            return age;
        }

        ///<returns> returns the ticket of the person </returns>
        public Enum getTicket()
        {
            return ticket;
        }

        ///<returns> returns random ticket of the person </returns>
        public string randTicket()
        {
            const var rand = new Random();
            int randomTicket = rand.Next(4);
            if (randomTicket == 3)
            {
                return Ticket.SEASON_PASS;
            } else if (this.getAge() < AGE_MIN_REDUCED || this.getAge() > AGE_MAX_REDUCED1)
            {
               return Ticket.REDUCED; 
            } else
            {
                return Ticket.ADULT;
            }
        }

    }
}