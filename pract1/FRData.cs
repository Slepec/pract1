using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    [Serializable]
    public class FRData
    {
        private int lotNumber;
        private int carNumber;
        private string carName;
        private string owner;

        public FRData()
        {
        }

        public FRData(int lotNumber, int carNumber, string carName, string owner)
        {
            this.LotNumber = lotNumber;
            this.CarNumber = carNumber;
            this.CarName = carName;
            this.Owner = owner;
        }

        public int LotNumber { get => lotNumber; set => lotNumber = value; }
        public int CarNumber { get => carNumber; set => carNumber = value; }
        public string CarName { get => carName; set => carName = value; }
        public string Owner { get => owner; set => owner = value; }
    }
}
