using System;

namespace CSharp_Livia
{
    public class ActivityEnvironmentImpl : ActivityEnvironment
    {
        private List<ViewActivityImpl> activityList;
        private List<ViewActivityImpl> fairList;
        private List<ViewActivityImpl> profitList;
        private ActivityType actType;

       public ActivityEnvironmentImpl()
       {
           this.fairList = new ArrayList();
           this.profitList = new ArrayList();
           this.activityList = new ArrayList();
       }

        public void ActivityInsertion(ViewActivityImpl activity)
        {
            ViewActivityImpl newActivity = activity;
            foreach (ViewActivityImpl act in this.activityList)
            {
                if (newActivity.GetName().Equals(act.GetName()) && newActivity.GetActivityType().Equals(act.GetActivityType()))
                {
                    throw new ActivityAlreadyPresentException();
                }
            }
            this.activityList.add(newActivity);
            this.actType = activity.GetActivityType();

            switch (actType)
            {
                case BABYFAIR:
                    this.fairList.add(newActivity);
                    break;
                
                case FAIR:
                    this.fairList.add(newActivity);
                    break;

                case SHOP:
                    this.profitList.add(newActivity);
                    break;

                case REST:
                    this.profitList.add(newActivity);
                    break;

                default:
                    break;
            }
        }

        public void ResetActivity()
        {
            this.profitList.clear();
            this.fairList.clear();
            this.activityList.clear();
        }

        public List<ViewActivityImpl> GetActivityList()
        {
            return this.activityList;
        }
        
        List<ViewActivityImpl> GetFairList()
        {
            return this.fairList;
        }

        List<ViewActivityImpl> GetProfitList()
        {
            return this.profitList;
        }
    }
}