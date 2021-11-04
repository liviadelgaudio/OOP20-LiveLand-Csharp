using System;

namespace CSharp_Livia
{
    public interface ViewActivity
    {
       ActivityType GetActivityType();

        Optional<int> GetCapacity();

        Optional<int> GetMinPrice();

        Optional<int> GetMaxPrice();

        string GetName();
    }
}