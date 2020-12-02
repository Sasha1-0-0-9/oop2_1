using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_1
{
    class EquationOfTheLine
    {
        private int[] ABC;

        public EquationOfTheLine(int[] param)
        {
            this.ABC = new int[3];
            for (int i = 0; i < 3; i++)
            {
                this.ABC[i] = param[i];
            }
        }

        public EquationOfTheLine()
        {
            this.ABC = new int[3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                this.ABC[i] = rand.Next(0, 20);
            }

        }

        public int this[int i] //indexator
        {
            get
            {
                return ABC[i];
            }       
        }

        public override string ToString()
        {
            return $"{ABC[0]}x + {ABC[1]}y + {ABC[2]} = 0";
        }

        public Point CrossingPoint(EquationOfTheLine equationOfTheLine)
        {
            double pCrossX = 0;
            double pCrossY = 0;
            double det = this.ABC[0] * equationOfTheLine[1] - this.ABC[1] * equationOfTheLine[0];
            pCrossX = (this.ABC[1] * equationOfTheLine[2] - equationOfTheLine[1] * this.ABC[2]) / det; //x:=(b1*c2-b2*c1)/(a1*b2-b1*a2);
            pCrossY = (equationOfTheLine[0] * this.ABC[2] - this.ABC[0] * equationOfTheLine[2]) / det; // y:=(a2*c1-a1*c2)/(a1*b2-b1*a2);
            return new Point(pCrossX, pCrossY);
        }

        public bool IsPointBelongLine(Point point)
        {
            if (this.ABC[0]*point.X + this.ABC[1]*point.Y + this.ABC[2] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
