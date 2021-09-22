using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pract1
{
    [Serializable]
    public class ParkingLot
    {
        
        /*[XmlAttribute] private String startDate;
        [XmlAttribute] private int hours;*/
        
        public ParkingLot()
        {
            
        }
        public ParkingLot(int id, Owner own, Car c)/*, String date, int h)*/
        {
            LotID = id;
            Owner = own;
            Car = c;
            /*StartDate = date;
            Hours = h;*/
        }

        public int LotID { get ; set; }
        public Owner Owner { get; set; }
        public Car Car { get; set; }
        /*public string StartDate { get => startDate; set => startDate = value; }
        public int Hours { get => hours; set => hours = value; }*/
    }
}
