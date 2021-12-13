using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Logger logger;
        static List<ParkingLot> listLots = new List<ParkingLot>();
        Prop p = new Prop();
        MyLogger mylogger;
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassSer.fromXML<Prop>(ref p, "property.xml");
            logger = LogManager.GetCurrentClassLogger();
            changeLanguage(p.CurrentCulture);
            mylogger = new MyLogger("mylogs/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".xml");
            mylogger.setLevel(p.LoggingLevel);
            mylogger.myLog(MyLogger.Levels.trace,"Встановлений рівень логування: "+p.LoggingLevel);
            LoggingConfiguration config = LogManager.Configuration;
            config.LoggingRules[0].EnableLoggingForLevels(LogLevel.FromString(p.LoggingLevel),LogLevel.Off);
            LogManager.Configuration = config;
            logger.Trace("Початок завантаження форми");
            mylogger.myLog(MyLogger.Levels.debug,"Початок завантаження форми");
            if (p.Format=="xml") {
                rbXml.Checked = true;
                if (!File.Exists(p.XmlFileName)) { p.XmlFileName = "data.xml"; }
                ClassSer.fromXML<List<ParkingLot>>(ref listLots, p.XmlFileName);
                for (int i = 0; i < listLots.Count; i++)
                {
                    dgv.Rows.Add(listLots[i].LotID, listLots[i].Car.CarNumber, listLots[i].Car.CarName, listLots[i].Owner.OwnerName);
                }
                logger.Info("Відбулась десеріалізація з XML-файлу");
                mylogger.myLog(MyLogger.Levels.info, "Відбулась десеріалізація з XML-файлу");

            }
            else if (p.Format == "json")
            {
                rbJson.Checked = true;
                if (!File.Exists(p.JsonFileName)) { p.JsonFileName = "data.json"; }
                ClassSer.fromJson<List<ParkingLot>>(ref listLots, p.JsonFileName);
                for (int i = 0; i < listLots.Count; i++)
                {
                    dgv.Rows.Add(listLots[i].LotID, listLots[i].Car.CarNumber, listLots[i].Car.CarName, listLots[i].Owner.OwnerName);
                }
                mylogger.myLog(MyLogger.Levels.info, "Відбулась десеріалізація з JSON-файлу");
                logger.Info("Відбулась десеріалізація з JSON-файлу");
            }
            else
            {
                rbBin.Checked = true;
                if (!File.Exists(p.BinFileName)) { p.BinFileName = "data.dat"; }
                ClassSer.fromBin<List<ParkingLot>>(ref listLots, p.BinFileName);
                for (int i = 0; i < listLots.Count; i++)
                {
                    dgv.Rows.Add(listLots[i].LotID, listLots[i].Car.CarNumber, listLots[i].Car.CarName, listLots[i].Owner.OwnerName);
                }
                mylogger.myLog(MyLogger.Levels.info, "Відбулась десеріалізація з dat-файлу");
                logger.Info("Відбулась десеріалізація з dat-файлу");
            }
            if (p.Period == 0) p.Period = 1;
            cbLevel.SelectedItem = p.LoggingLevel;
            mylogger.myLog(MyLogger.Levels.debug, "Початок таймеру");
            logger.Trace("Початок таймеру");
            timer1.Interval = p.Period * 60000;
            timer1.Start();
            
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }
        private Boolean validCarNumber(string num)
        {
            string pattern = "^\\d{4}$";
            foreach (Match m in Regex.Matches(num, pattern))
            {
                return true;
            }
            return false;
        }
        private Boolean validLot(string num)
        {
            string pattern = "^\\d{0,4}$";
            foreach (Match m in Regex.Matches(num, pattern))
            {
                return true;
            }
            return false;
        }
        private Boolean validString(string num)
        {
            string pattern = "^(\\w[ `'-]?){0,40}$";
            foreach (Match m in Regex.Matches(num, pattern))
            {
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validCarNumber(tbCarNum.Text) && validLot(tbLotID.Text) && validString(tbCarName.Text) && validString(tbOwner.Text))
                {
                    listLots.Add(new ParkingLot(Convert.ToInt32(tbLotID.Text), new Owner(tbOwner.Text), new Car(tbCarName.Text, Convert.ToInt32(tbCarNum.Text))));
                    dgv.Rows.Add(tbLotID.Text, tbCarNum.Text, tbCarName.Text, tbOwner.Text);
                    logger.Info("Доданий новий запис: [" + "lotID=" + tbLotID.Text + ", carNumber=" + tbCarNum.Text + ", carName=" + tbCarName.Text + ", carOwner=" + tbOwner.Text + "]");
                    mylogger.myLog(MyLogger.Levels.info, "Доданий новий запис: [" + "lotID=" + tbLotID.Text + ", carNumber=" + tbCarNum.Text + ", carName=" + tbCarName.Text + ", carOwner=" + tbOwner.Text + "]");
                }
                else {
                    if (currLang.Text == "Українська")
                        MessageBox.Show("Невалідні дані!");
                    else
                        MessageBox.Show("Invalid input!");
                    logger.Error("Помилка при введенні даних до нового запису");
                    mylogger.myLog(MyLogger.Levels.error, "Помилка при введенні даних до нового запису");
                }
            }
            catch (Exception ex) {
                if(currLang.Text=="Українська")
                    MessageBox.Show("Невалідні дані!");
                else
                    MessageBox.Show("Invalid input!"+currLang.Text);
                logger.Error("Помилка при введенні даних до нового запису");
                mylogger.myLog(MyLogger.Levels.error, "Помилка при введенні даних до нового запису");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                ClassSer.toXML<List<ParkingLot>>(ref listLots, p.XmlFileName);
            
                ClassSer.toJson<List<ParkingLot>>(ref listLots, p.JsonFileName);
            
                ClassSer.toBin<List<ParkingLot>>(ref listLots, p.BinFileName);
                logger.Trace("Відбулась серіалізація");
                mylogger.myLog(MyLogger.Levels.debug, "Відбулась серіалізація");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logger.Trace("Таймер!");
            mylogger.myLog(MyLogger.Levels.debug, "Таймер!");
            button2_Click(this, EventArgs.Empty);
            
        }

        private void rbJson_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJson.Checked) {
                logger.Info("Формат десеріалізації: json");
                mylogger.myLog(MyLogger.Levels.info, "Формат десеріалізації: json");
                p.Format = "json";
            }
            
        }

        private void rbXml_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXml.Checked) {
                logger.Info("Формат десеріалізації: xml");
                mylogger.myLog(MyLogger.Levels.info, "Формат десеріалізації: xml");
                p.Format = "xml"; 
            }

            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.Trace("Завершення роботи");
            mylogger.myLog(MyLogger.Levels.debug,"Завершення роботи");
            button2_Click(this, EventArgs.Empty);
            timer1.Stop();
            ClassSer.toXML<Prop>(ref p, "property.xml");
            mylogger.closeWriter();
        }

        private void rbBin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBin.Checked) {
                logger.Info("Формат десеріалізації: bin");
                mylogger.myLog(MyLogger.Levels.info,"Формат десеріалізації: bin");
                p.Format = "bin"; 
            }
            
        }

        private void cbLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            p.LoggingLevel = cbLevel.Text;
            logger.Info("Рівень логування змінений на "+cbLevel.Text);
            mylogger.myLog(MyLogger.Levels.info, "Рівень логування змінений на " + cbLevel.Text);
        }
        private void changeLanguage(string lang)
        {

            var resources = new ComponentResourceManager(typeof(Form1));
            CultureInfo cultureInfo = new CultureInfo(lang);
            foreach(Control c in this.Controls)
            {

                if(c.GetType()== typeof(DataGridView))
                {
                    var myDgv = (DataGridView)c;
                    foreach(DataGridViewColumn col in myDgv.Columns)
                    {
                        resources.ApplyResources(col, col.Name, cultureInfo);
                    }
                }
                if (c.GetType() == typeof(StatusStrip))
                {
                    var ss = (StatusStrip)c;
                    foreach (var item in ss.Items.Cast<ToolStripItem>())
                    {
                        
                        resources.ApplyResources(item, item.Name, cultureInfo);
                    }
                }
                resources.ApplyResources(c, c.Name, cultureInfo);
            }
            resources.ApplyResources(this, "$this", cultureInfo);
        }
       

        private void engLang_Click(object sender, EventArgs e)
        {
            changeLanguage("en-US");
      
            p.CurrentCulture = "en-US";
        }

        private void ukrLang_Click(object sender, EventArgs e)
        {
            changeLanguage("uk-UA");
            p.CurrentCulture = "uk-UA";
        }

        private void tbLotID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Thread t1 = new Thread(serReportData);
            t1.Start();
            t1.Join();
            logger.Info("Звіт відкривається");
            mylogger.myLog(MyLogger.Levels.info, "Звіт відкривається");
            FormFR frmReport = new FormFR();
            frmReport.ShowDialog();
        }
        private static void serReportData()
        {
            Console.WriteLine("serReportData початаок");
            List<FRData> fRData = new List<FRData>();
           
            foreach (ParkingLot pl in listLots)
            {
                fRData.Add(new FRData(pl.LotID, pl.Car.CarNumber, pl.Car.CarName, pl.Owner.OwnerName));
            }
            ClassSer.toXML<List<FRData>>(ref fRData, "frData.xml");
            Console.WriteLine("serReportData кінець");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RepExcel re = new RepExcel();
            String path = "D:\\c#\\pract1\\pract1\\bin\\Debug\\myExcel1.xls";
            if (!File.Exists(path))
            {
                re.CreateNewBook(path);
            }
            re.OpenBook(path);
            re.SetValue("LotsList", "A1", "Номер лоту", " string");
            re.SetValue("LotsList", "B1", "Номер авто", " string");
            re.SetValue("LotsList", "C1", "Назва авто", " string");
            re.SetValue("LotsList", "D1", "Власник авто", " string");
            for(int i = 0; i<listLots.Count;i++)
            {
                re.SetValue("LotsList", "A"+(i+2), listLots[i].LotID.ToString(), " string");
                re.SetValue("LotsList", "B"+(i+2), listLots[i].Car.CarNumber.ToString(), " string");
                re.SetValue("LotsList", "C"+(i+2), listLots[i].Car.CarName.ToString(), " string");
                re.SetValue("LotsList", "D"+(i+2), listLots[i].Owner.OwnerName.ToString(), " string");
            }
            re.Save(path);
            re.CloseBook();
            re.Dispose();
        }
    }
}
