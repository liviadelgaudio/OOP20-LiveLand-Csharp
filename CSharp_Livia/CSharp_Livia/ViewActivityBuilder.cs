using System;

namespace CSharp_Livia
{
    class ViewActivityBuilder
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

        public void Capacity(int capacity)
        {
            this.capacity = capacity;
        }

        public void MinPrice(int minPrice)
        {
            this.minPrice = minPrice;
        }

        public void MaxPrice(int maxPrice)
        {
            this.maxPrice = maxPrice;
        }

        public ViewActivityImpl Build()
        {
            return new ViewActivityImpl(this.name, this.capacity, 
                this.minPrice, this.maxPrice, this.activityType);
        }

    }
}