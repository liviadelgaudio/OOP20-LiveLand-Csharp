using System;

namespace CSharp_Livia
{
    /// <summary>
    /// This class implements a strategy to build ViewActivityImpl objects step-by-step, regardless of the activity type.
    /// </summary>
    public class ViewActivityBuilder
    {
        private string name;
        private Nullable<int> capacity = null;
        private Nullable<int> minPrice = null;
        private Nullable<int> maxPrice = null;
        private ActType.ActivityType activityType;

        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="name">activity name</param>
        /// <param name="type">activity type</param>
        public ViewActivityBuilder(string name, ActType.ActivityType type)
        {
            this.name = name;
            this.activityType = type;
        }

        /// <summary>
        /// This method sets the activity capacity
        /// </summary>
        /// <param name="capacity">the capacity chosen</param>
        /// <returns>current ViewActivityBuilder</returns>
        public ViewActivityBuilder Capacity(int capacity)
        {
            this.capacity = capacity;
            return this;
        }

        /// <summary>
        /// This method sets the minimum price chosen for the activity
        /// </summary>
        /// <param name="minPrice">the minimum price</param>
        /// <returns>current ViewActivityBuilder</returns>
        public ViewActivityBuilder MinPrice(int minPrice)
        {
            this.minPrice = minPrice;
            return this;
        }

        /// <summary>
        /// This method sets the maximum price chosen for the activity
        /// </summary>
        /// <param name="maxPrice">the maximum price</param>
        /// <returns>current ViewActivityBuilder</returns>
        public ViewActivityBuilder MaxPrice(int maxPrice)
        {
            this.maxPrice = maxPrice;
            return this;
        }

        /// <summary>
        /// This method effectively builds up the ViewActivityImpl
        /// </summary>
        /// <returns>the ViewActivityImpl created</returns>
        public ViewActivityImpl Build()
        {
            return new ViewActivityImpl(this.name, this.capacity, 
                this.minPrice, this.maxPrice, this.activityType);
        }

    }
}