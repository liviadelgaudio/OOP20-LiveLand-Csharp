using System;

namespace CSharp_Livia
{
    class ViewActivityImpl : ViewActivity
    {
        private string name;
        private Optional<int> capacity;
        private Optional<int> minPrice;
        private Optional<int> maxPrice;
        private enum ActivityType{FAIR, BABYFAIR, REST, SHOP};
        private ActivityType activityType;

        public ViewActivityImpl(string name, Optional<int> capacity, Optional<int> minPrice, Optional<int> maxPrice, ActivityType type)
        {
            this.name = name;
            this.capacity = capacity;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.activityType = type;
        }

        public Optional<int> GetCapacity()
        {
            return this.capacity;
        }

        public Optional<int> GetMinPrice()
        {
            return this.minPrice;
        }

        public Optional<int> GetMaxPrice()
        {
            return this.maxPrice;
        }

        public ActivityType GetActivityType()
        {
            return this.activityType;
        }

        public string GetName()
        {
            return this.name;
        }


    }
}