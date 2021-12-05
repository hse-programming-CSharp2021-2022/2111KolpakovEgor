using System;

namespace _07_01
{
    class EqTriangle: Figure
    {
        public EqTriangle(Point point, double lenght)
        {
            if (lenght < 0)
                throw new ArgumentException("Длина стороны меньше нуля!");
            


        }
    }
}
