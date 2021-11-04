using System;

namespace CSharp_Livia
{
    /// <summary>
    /// This class, in the original version, works as a bridge between model and view: it is where activities are assembled.
    /// </summary>
    public interface ViewActivity
    {
        /// <summary>
        /// Method returning the activity type
        /// </summary>
        /// <returns>Activity Type</returns>
        ActType.ActivityType GetActivityType();

        /// <summary>
        /// Method returning the activity capacity, which is present if and only if the activity type is FAIR/BABYFAIR
        /// </summary>
        /// <returns>the capacity</returns>
        Nullable<int> GetCapacity();

        /// <summary>
        /// Method returning the minimum price chosen, which is present if and only if the activity type is Profit (SHOP/REST)
        /// </summary>
        /// <returns>the minimum price</returns>
        Nullable<int> GetMinPrice();

        /// <summary>
        /// Method returning the maximum price chosen, which is present if and only if the activity type is Profit (SHOP/REST)
        /// </summary>
        /// <returns>the maximum price</returns>
        Nullable<int> GetMaxPrice();

        /// <summary>
        /// Method returning the activity name
        /// </summary>
        /// <returns>activity name</returns>
        string GetName();
    }
}