using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pract1
{
    public class MyLogger
    {
        private string path;
        private XmlTextWriter writer;
        private int logLevel;
        public enum Levels
        {
            info=4,
            debug=5,
            error=2,
            fatal=1,
            warn=3,
            off=0,
            trace=6
        }
        public MyLogger(string path)
        {
            LogLevel = 5;
            this.Path = path;
            writer = new XmlTextWriter(path, null);
            writer.WriteStartDocument();
            writer.WriteWhitespace("\n");
            writer.WriteStartElement("LogInfo");
            writer.WriteWhitespace("\n");
        }
       
        public MyLogger(string path, string logLevel)
        {

            this.Path = path;
            writer = new XmlTextWriter(path, null);
            if (logLevel.Trim().ToLower() == "info") this.LogLevel = 4;
            if (logLevel.Trim().ToLower() == "debug") this.LogLevel = 5;
            if (logLevel.Trim().ToLower() == "warn") this.LogLevel = 3;
            if (logLevel.Trim().ToLower() == "error") this.LogLevel = 2;
            if (logLevel.Trim().ToLower() == "fatal") this.LogLevel = 1;
            if (logLevel.Trim().ToLower() == "trace") this.LogLevel = 6;
            if (logLevel.Trim().ToLower() == "off") this.LogLevel = 0;
            writer.WriteStartDocument();
            writer.WriteWhitespace("\n");
            writer.WriteStartElement("LogInfo");
            writer.WriteWhitespace("\n");
        }
        
        public string Path { get => path; set => path = value; }
        public int LogLevel { get => logLevel; set => logLevel = value; }
        
        
        public void myLog(Levels l, string message) 
        {
            if (LogLevel >= (int)l)
            {
                writer.WriteStartElement(l.ToString());
                writer.WriteWhitespace("\n");
                writer.WriteStartElement("Time");
                writer.WriteString(DateTime.Now.ToString());
                writer.WriteEndElement();
                writer.WriteWhitespace("\n");
                writer.WriteStartElement("Message");
                writer.WriteString(message);
                writer.WriteEndElement();
                writer.WriteWhitespace("\n");
                writer.WriteEndElement();
                writer.WriteWhitespace("\n");
            }
        }
        
        
        public void setLevel(string level)
        {
            if (level.Trim().ToLower() == "info") LogLevel = 4;
            if (level.Trim().ToLower() == "debug") LogLevel = 5;
            if (level.Trim().ToLower() == "warn") LogLevel = 3;
            if (level.Trim().ToLower() == "error") LogLevel = 2;
            if (level.Trim().ToLower() == "fatal") LogLevel = 1;
            if (level.Trim().ToLower() == "trace") LogLevel = 6;
            if (level.Trim().ToLower() == "off") LogLevel = 0;
        }
        public void closeWriter()
        {
            try
            {
                writer.WriteEndElement();
                writer.WriteWhitespace("\n");
                writer.WriteEndDocument();
                writer.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
