using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Enrica
{
    public interface Activity
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
        /// Method that reads the assigned color.
        /// </summary>
        void SetColor(ConsoleColor color);
        /// <summary>
        /// Method that reads the assigned height.
        /// </summary>
        void SetHeight(int height);
        /// <summary>
        /// Method that reads the assigned width.
        /// </summary>
        void SetWidth(int width);
        /// <summary>
        /// Method that assigned the x value.
        /// </summary>
        int Getx();
        /// <summary>
        /// Method that assigned the y value.
        /// </summary>
        int Gety();
        /// <summary>
        /// Method that assigned the color.
        /// </summary>
        int GetColor();
        /// <summary>
        /// Method that assigned the height.
        /// </summary>
        int GetHeight();
        /// <summary>
        /// Method that assigned the width.
        /// </summary>
        int GetWidth();


    }
}
