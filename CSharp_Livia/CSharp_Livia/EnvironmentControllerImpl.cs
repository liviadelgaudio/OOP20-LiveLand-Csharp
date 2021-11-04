using System;
using System.Collections.Generic;

namespace CSharp_Livia
{
    public class EnvironmentControllerImpl : EnvironmentController
    {
        private ActivityEnvironmentImpl model;

        public EnvironmentControllerImpl()
        {
            this.model = new ActivityEnvironmentImpl();
        }
        
        /// <inheritdoc/>
        public void AddNewActivity(ViewActivityImpl activity)
        {
            ViewActivityImpl newActivity = activity;
            this.model.ActivityInsertion(newActivity);
        }

        /// <summary>
        /// Method returning tha Activity list
        /// </summary>
        /// <returns>the activity list</returns>
        public List<ViewActivityImpl> GetActivityList()
        {
            return this.model.GetActivityList();
        }

        /// <summary>
        /// Method returning the Fair list
        /// </summary>
        /// <returns>the fair list</returns>
        public List<ViewActivityImpl> GetFairList()
        {
            return this.model.GetFairList();
        }

        /// <summary>
        /// Method returning the Profit list
        /// </summary>
        /// <returns>the profit list</returns>
        public List<ViewActivityImpl> GetProfitList()
        {
            return this.model.GetProfitList();
        }

        /// <summary>
        /// This method resets the environment, deleting all the activities previously added
        /// </summary>
        public void ResetActivityLists()
        {
            model.ResetActivity();
        }
    }
}