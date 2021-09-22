using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    [Serializable]
    public class Prop
    {
        private static String fileName;
        private static int period;

        public Prop(string fileName, int period)
        {
            FileName = fileName;
            Period = period;
        }
        public Prop()
        {

        }
        public string FileName { get => fileName; set => fileName = value; }
        public int Period { get => period; set => period = value; }
    }
}
