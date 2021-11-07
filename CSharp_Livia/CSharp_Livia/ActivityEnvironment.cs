using System.Collections.Generic;

namespace CSharp_Livia
{

    public interface ActivityEnvironment
    {    
        /// <summary>
        /// It adds the new activity to the corresponding activity list, either Fair list or Profit list
        /// </summary>
        /// <param name="activity">the activity to be added</param>
        void ActivityInsertion(ViewActivityImpl activity);

        /// <summary>
        /// Method which resets all the activity lists
        /// </summary>
        void ResetActivity();

        /// <summary>
        /// Method returning the Activity list
        /// </summary>
        /// <returns>the activity list</returns>
        List<ViewActivityImpl> GetActivityList();
        
        /// <summary>
        /// Method returning the Fair list
        /// </summary>
        /// <returns>the fair list</returns>
        List<ViewActivityImpl> GetFairList();

        /// <summary>
        /// Method returning the Profit list
        /// </summary>
        /// <returns>the profit list</returns>
        List<ViewActivityImpl> GetProfitList();
    }
}