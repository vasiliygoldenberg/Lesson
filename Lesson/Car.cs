using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Car
    {
        public  readonly int maxSpeed;
        private int currSpeed;

        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            currSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }

    }
}
