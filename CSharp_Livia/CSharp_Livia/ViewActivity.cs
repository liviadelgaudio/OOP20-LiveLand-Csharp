using System;

namespace CSharp_Livia
{
    public interface ViewActivity
    {
       ActivityType getActivityType();

        Optional<int> getCapacity();

        Optional<int> getMinPrice();

        Optional<int> getMaxPrice();

        String getName();
    }
}