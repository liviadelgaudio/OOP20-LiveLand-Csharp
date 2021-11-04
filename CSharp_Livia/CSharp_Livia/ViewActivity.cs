using System;

namespace CSharp_Livia
{
    public interface ViewActivity
    {
        ActType.ActivityType GetActivityType();

        Nullable<int> GetCapacity();

        Nullable<int> GetMinPrice();

        Nullable<int> GetMaxPrice();

        string GetName();
    }
}