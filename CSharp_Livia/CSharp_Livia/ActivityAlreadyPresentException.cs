using System;

namespace CSharp_Livia
{
    public class ActivityAlreadyPresentException : Exception
    {
        public new string ToString()
        {
            return "Activity already present in the simulation! Please, try again.";
        }

        public string GetMessage()
        {
            return this.ToString();
        }
    }
}