using System;
using System.Collections.Generic;

namespace CSharp_Livia
{
    public class ActivityEnvironmentImpl : ActivityEnvironment
    {
        private List<ViewActivityImpl> activityList;
        private List<ViewActivityImpl> fairList;
        private List<ViewActivityImpl> profitList;
        private ActType.ActivityType actType;

       public ActivityEnvironmentImpl()
       {
           this.fairList = new List<ViewActivityImpl>();
           this.profitList = new List<ViewActivityImpl>();
           this.activityList = new List<ViewActivityImpl>();
       }

        /// <inheritdoc/>
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
            this.activityList.Add(newActivity);
            this.actType = activity.GetActivityType();

            switch (actType)
            {
                case ActType.ActivityType.BABYFAIR:
                    this.fairList.Add(newActivity);
                    break;
                
                case ActType.ActivityType.FAIR:
                    this.fairList.Add(newActivity);
                    break;

                case ActType.ActivityType.SHOP:
                    this.profitList.Add(newActivity);
                    break;

                case ActType.ActivityType.REST:
                    this.profitList.Add(newActivity);
                    break;

                default:
                    break;
            }
        }

        /// <inheritdoc/>
        public void ResetActivity()
        {
            this.profitList.Clear();
            this.fairList.Clear();
            this.activityList.Clear();
        }

        /// <inheritdoc/>
        public List<ViewActivityImpl> GetActivityList()
        {
            return this.activityList;
        }

        /// <inheritdoc/>
        public List<ViewActivityImpl> GetFairList()
        {
            return this.fairList;
        }

        /// <inheritdoc/>
        public List<ViewActivityImpl> GetProfitList()
        {
            return this.profitList;
        }
    }
}