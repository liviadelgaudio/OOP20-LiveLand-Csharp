using System.Collections.Generic;

namespace CSharp_Livia
{
    public interface ActivityEnvironment
    {
        void ActivityInsertion(ViewActivityImpl activity);

        void ResetActivity();

        List<ViewActivityImpl> GetActivityList();
        
        List<ViewActivityImpl> GetFairList();

        List<ViewActivityImpl> GetProfitList();
    }
}