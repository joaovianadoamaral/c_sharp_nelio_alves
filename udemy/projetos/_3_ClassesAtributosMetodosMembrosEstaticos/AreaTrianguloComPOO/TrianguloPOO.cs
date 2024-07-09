using System;

namespace AreaTrianguloComPOO
{
    internal class TrianguloPOO
    {
        public double Side1;
        public double Side2;
        public double Side3;

        public double High;
        public double Area;
        
        public double Perimeter;
        public double SemiPerimeter;

        public bool ConditionExistence;


        public void TrianglePerimeter()
        {
            Perimeter = (Side1 + Side2 + Side3);
        }

        public void TriangleSemiPerimeter()
        {
            TrianglePerimeter();
            SemiPerimeter = Perimeter / 2.0;
        }

        public void TriangleConditionExistence()
        {
            ConditionExistence = true;

            if (Math.Abs(Side1 + Side2) <=  Side3) { ConditionExistence = false; }
            if (Math.Abs(Side1 - Side2) >=  Side3) { ConditionExistence = false; }
            
            if (Math.Abs (Side2 + Side3) <= Side1) { ConditionExistence = false; }
            if (Math.Abs (Side2 - Side3) >= Side1) { ConditionExistence = false; }

            if (Math.Abs(Side1 + Side3) <= Side2) { ConditionExistence = false; }
            if (Math.Abs(Side1 - Side3) >= Side2) { ConditionExistence = false; }

        }
        public void TriangleAreaHeron()
        {
            // you just need 3 sides for calculating Area

            TriangleConditionExistence();
            TriangleSemiPerimeter();
            
            Area = 0;
            
            if (ConditionExistence)
            {
                Area = Math.Sqrt(SemiPerimeter * (SemiPerimeter - Side1) * (SemiPerimeter - Side2) * (SemiPerimeter - Side3));
            }

        }
    }
}
