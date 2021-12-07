using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace pract1
{
    public static class ClassSer
    {
        static Logger logger = LogManager.GetCurrentClassLogger();
        public static void toXML<T>(ref T inObject, String inFileName)
        {
            StreamWriter file = new StreamWriter(inFileName);
            try
            {
                XmlSerializer writter = new XmlSerializer(typeof(T));
                writter.Serialize(file, inObject);
            }
            catch (Exception exc) { logger.Error("Serialization error"); }
            finally { file.Close(); }
        }
        public static void fromXML<T>(ref T inObject, String inFileName)
        {
            if (File.Exists(inFileName))
            {
                StreamReader file = new StreamReader(inFileName);
                try
                {
                    XmlSerializer reader = new XmlSerializer(typeof(T));
                    inObject = (T)reader.Deserialize(file);
                }
                catch (Exception ex)
                {
                    logger.Error("Serialization error");
                }
                finally { file.Close(); }
            }
            else MessageBox.Show("File doesn`t exist: "+inFileName);
        }
        public static void fromJson<T>(ref T inObject, String inFileName)
        {
            if (File.Exists(inFileName))
            {
                FileStream file = new FileStream(inFileName, FileMode.Open);
                try
                {
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                    inObject = (T)ser.ReadObject(file);
                }
                catch (Exception ex)
                {
                    logger.Error("Serialization error");
                }
                finally { file.Close(); }
            }
            else MessageBox.Show("File doesn`t exist: " + inFileName);
        }
        public static void toJson<T>(ref T inObject,String fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName,FileMode.Create);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                ser.WriteObject(fs,inObject);
                fs.Close();
            }
            catch (Exception ex) { logger.Error("Serialization error"); }
        }
        public static void toBin<T>(ref T inObject, String fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(fs, inObject);
                fs.Close();
            }
            catch (Exception ex) { logger.Error("Serialization error"); }
        }
        public static void fromBin<T>(ref T inObject, String fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                try
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    inObject = (T)ser.Deserialize(file);
                }
                catch (Exception ex)
                {
                    logger.Error("Serialization error");
                }
                finally { file.Close(); }
            }
            else MessageBox.Show("File doesn`t exist: " + fileName);
        }
    }
}
