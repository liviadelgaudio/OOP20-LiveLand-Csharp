using System;

namespace CSharp_Livia
{
    class EnvironmentControllerImpl : EnvironmentController
    {
        private ActivityEnvironmentImpl model;

        public EnvironmentControllerImpl()
        {
            this.model = new ActivityEnvironmentImpl();
        }
        public void AddNewActivity(ViewActivityImpl activity)
        {
            ViewActivityImpl activity = activity;
            this.model.ActivityInsertion(activity);
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
            this.model.ResetActivityLists();
        }
    }
}