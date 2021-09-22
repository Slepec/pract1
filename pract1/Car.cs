using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public class Car
    {
        private String carName;
        private int carNumber;
        
        public Car()
        {
            CarName = null;
            CarNumber = -1;
        }
        public Car( String name, int num)
        {
            CarName = name;
            CarNumber = num;
        }

        public string CarName { get => carName; set => carName = value; }
        public int CarNumber { get => carNumber; set => carNumber = value; }
    }
}
