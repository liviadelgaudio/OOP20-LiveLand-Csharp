using System;

namespace CSharp_Livia
{
    public class ViewActivityImpl : ViewActivity
    {
        private string name;
        private Nullable<int> capacity;
        private Nullable<int> minPrice;
        private Nullable<int> maxPrice;
        private ActType.ActivityType activityType;

        public ViewActivityImpl(string name, Nullable<int> capacity, Nullable<int> minPrice, Nullable<int> maxPrice, ActType.ActivityType type)
        {
            this.name = name;
            this.capacity = capacity;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.activityType = type;
        }

        /// <inheritdoc/>
        public Nullable<int> GetCapacity()
        {
            return this.capacity;
        }

        /// <inheritdoc/>
        public Nullable<int> GetMinPrice()
        {
            return this.minPrice;
        }

        /// <inheritdoc/>
        public Nullable<int> GetMaxPrice()
        {
            return this.maxPrice;
        }

        /// <inheritdoc/>
        public ActType.ActivityType GetActivityType()
        {
            return this.activityType;
        }

        /// <inheritdoc/>
        public string GetName()
        {
            return this.name;
        }


    }
}