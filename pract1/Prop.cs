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
        private static String jsonFileName;
        private static String xmlFileName;
        private static String binFileName;
        private static int period;
        private static String format;
        private static String loggingLevel;
        private static String currentCulture;

        public Prop(string xml, string json,string bin, int period, String format, string level,String culture)
        {
            XmlFileName = xml;
            JsonFileName = json;
            BinFileName = bin;
            Period = period;
            Format = format;
            LoggingLevel = level;
            CurrentCulture = culture;
        }
        public Prop()
        {

        }

        public  string JsonFileName { get => jsonFileName; set => jsonFileName = value; }

        public string BinFileName { get => binFileName; set => binFileName = value; }
        public string XmlFileName { get => xmlFileName; set => xmlFileName = value; }
        public  int Period { get => period; set => period = value; }
        public  string Format { get => format; set => format = value; }
        public string CurrentCulture { get => currentCulture; set => currentCulture = value; }
        public string LoggingLevel { get => loggingLevel; set => loggingLevel = value; }
    }
}
