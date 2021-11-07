using System;

namespace CSharp_Enrica
{
    public interface Person
    {
        /// <summary>
        /// Method that reads the assigned x value.
        /// </summary>
        void Setx(int x);
        /// <summary>
        /// Method that reads the assigned y value.
        /// </summary>
        void Sety(int y);
        /// <summary>
        /// Method that reads the assigned radius value.
        /// </summary>
        void SetRadius(double radius);
        /// <summary>
        /// Method that reads the assigned color.
        /// </summary>
        void SetColor(ConsoleColor color);
        /// <summary>
        /// Method that assigned the radius.
        /// </summary>
        double GetRadius();
        /// <summary>
        /// Method that assigned the color.
        /// </summary>
        int GetColor();
        /// <summary>
        /// Method that assigned the x value.
        /// </summary>
        int Getx();
        /// <summary>
        /// Method that assigned the y value.
        /// </summary>
        int Gety();

    }

}


