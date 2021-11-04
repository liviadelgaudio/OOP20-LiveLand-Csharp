using System;

namespace CSharp_Livia
{
    class ViewActivityBuilder
    {
        private string name;
        private Optional<int> capacity = Optional.Empty;
        private Optional<int> minPrice = Optional.Empty;
        private Optional<int> maxPrice = Optional.Empty;
        private ActivityType activityType;

        public ViewActivityBuilder(string name, ActivityType type)
        {
            this.name = name;
            this.type = type;
        }

        public ViewActivityBuilder Capacity(int capacity = null)
        {
            this.capacity = capacity;
        }

        public ViewActivityBuilder MinPrice(int minPrice = null)
        {
            this.minPrice = minPrice;
        }

        public ViewActivityBuilder MaxPrice(int maxPrice = null)
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