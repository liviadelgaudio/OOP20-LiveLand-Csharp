using System;

namespace CSharp_Livia
{
    public class ViewActivityBuilder
    {
        private string name;
        private Nullable<int> capacity = null;
        private Nullable<int> minPrice = null;
        private Nullable<int> maxPrice = null;
        private ActType.ActivityType activityType;

        public ViewActivityBuilder(string name, ActType.ActivityType type)
        {
            this.name = name;
            this.activityType = type;
        }

        public ViewActivityBuilder Capacity(int capacity)
        {
            this.capacity = capacity;
            return this;
        }

        public ViewActivityBuilder MinPrice(int minPrice)
        {
            this.minPrice = minPrice;
            return this;
        }

        public ViewActivityBuilder MaxPrice(int maxPrice)
        {
            this.maxPrice = maxPrice;
            return this;
        }

        public ViewActivityImpl Build()
        {
            return new ViewActivityImpl(this.name, this.capacity, 
                this.minPrice, this.maxPrice, this.activityType);
        }

    }
}