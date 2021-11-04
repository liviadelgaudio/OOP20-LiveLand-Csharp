using System;

namespace CSharp_Livia
{
    /// <summary>
    /// Interface showing EnvironmentControllerImpl's behaviour: it manages to add a new activity in the simulation 
    /// </summary>
    public interface EnvironmentController
    {
        /// <summary>
        /// Method that adds a new activity in the simulation environment
        /// </summary>
        /// <param name="activity">the new activity to be added</param>
        void AddNewActivity(ViewActivityImpl activity);

    }
}