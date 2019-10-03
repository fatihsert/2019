using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPrinciples.Encapsulation
{
    public class Rectangle
    {
        private int width;
        private int height;

        public bool SetHeigth(int height)
        {
            if (height < 0)
            {
                return false;
            }

            this.height = height;

            return true;
        }

        public bool SetWidth(int width)
        {
            if (width<0)
            {
                return false;
            }

            this.width = width;

            return true;
        }

    }
}
