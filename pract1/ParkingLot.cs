using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pract1
{
    [Serializable] [DataContract]
    public class ParkingLot
    { 
        public ParkingLot()
        {
            
        }
        public ParkingLot(int id, Owner own, Car c)
        {
            LotID = id;
            Owner = own;
            Car = c;
        }
        [DataMember]
        public int LotID { get ; set; }
        [DataMember]
        public Owner Owner { get; set; }
        [DataMember]
        public Car Car { get; set; }
    }
}
