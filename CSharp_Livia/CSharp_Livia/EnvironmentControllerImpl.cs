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
        public void AddNewActivity(ViewActivityImpl activity)
        {
            ViewActivityImpl newActivity = activity;
            this.model.ActivityInsertion(newActivity);
        }

        public List<ViewActivityImpl> GetActivityList()
        {
            return this.model.GetActivityList();
        }

        public List<ViewActivityImpl> GetFairList()
        {
            return this.model.GetFairList();
        }

        public List<ViewActivityImpl> GetProfitList()
        {
            return this.model.GetProfitList();
        }

        public void ResetActivityLists()
        {
            model.ResetActivity();
        }
    }
}