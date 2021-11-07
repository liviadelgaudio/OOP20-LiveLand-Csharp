using System;

namespace CSharp_Livia
{
    /// <summary>
    /// Eception to be thrown when an activity already present in the simulation environment is trying to be added.
    /// </summary>
    public class ActivityAlreadyPresentException : Exception
    {
        /// <summary>
        /// Method returning string representation of the exception
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return "Activity already present in the simulation! Please, try again.";
        }

        /// <summary>
        /// Method returning the message containing the string representation of the exception
        /// </summary>
        /// <returns>the message</returns>
        public string GetMessage()
        {
            return this.ToString();
        }
    }
}