using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Enrica
{
    public class ActivityImpl : Activity
    {
        private int width;
        private int height;
        private int x;
        private int y;
        private ConsoleColor color;

        public ActivityImpl(int width, int height, int x, int y, ConsoleColor color)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.color = color;
        }
        /// <inheritdoc/>
        public int GetColor()
        {
            return (int)color;
        }
        /// <inheritdoc/>
        public int GetHeight()
        {
            return height;
        }
        /// <inheritdoc/>
        public int GetWidth()
        {
            return width;
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
        public void SetHeight(int height)
        {
            this.height = height;
        }
        /// <inheritdoc/>
        public void SetWidth(int width)
        {
            this.width = width;
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

    
