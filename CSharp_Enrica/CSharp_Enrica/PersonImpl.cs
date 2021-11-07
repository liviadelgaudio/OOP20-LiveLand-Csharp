using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Enrica
{
    public class PersonImpl : Person 
    {
        private double radius;
        private ConsoleColor color;
        private int x;
        private int y;

        public PersonImpl(double radius, ConsoleColor color, int x, int y)
        {
            this.radius = radius;
            this.color = color;
            this.x = x;
            this.y = y;
            
        }
        /// <inheritdoc/>
        public int GetColor()
        {
            return (int)color;
        }
        /// <inheritdoc/>
        public double GetRadius()
        {
            return radius;
        }
        /// <inheritdoc/>
        public int Getx()
        {
            return x;
        }
        /// <inheritdoc/>
        public int Gety()
        {
            return y;
        }
        /// <inheritdoc/>
        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }
        /// <inheritdoc/>
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        /// <inheritdoc/>
        public void Setx(int x)
        {
            this.x = x;
        }
        /// <inheritdoc/>
        public void Sety(int y)
        {
            this.y = y;
        }
    }
}
