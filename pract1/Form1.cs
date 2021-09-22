using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ParkingLot> listLots = new List<ParkingLot>();
        Prop p = new Prop();
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassSer.fromXML<Prop>(ref p, "property.xml");
            if (!File.Exists(p.FileName)) { p.FileName = "data.xml"; }

            ClassSer.fromXML<List<ParkingLot>>(ref listLots, p.FileName);
            for (int i = 0; i < listLots.Count; i++)
            {
                dgv.Rows.Add(listLots[i].LotID, listLots[i].Car.CarNumber, listLots[i].Car.CarName, listLots[i].Owner.OwnerName);
            }
            timer1.Interval=p.Period * 60000;
            timer1.Start();
            

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            button2_Click(this,EventArgs.Empty);
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOwner.Text != "" && tbLotID.Text != "" && tbCarNum.Text != "" && tbCarName.Text != "")
                {
                    listLots.Add(new ParkingLot(Convert.ToInt32(tbLotID.Text), new Owner(tbOwner.Text), new Car(tbCarName.Text, Convert.ToInt32(tbCarNum.Text))));
                    dgv.Rows.Add(tbLotID.Text, tbCarNum.Text, tbCarName.Text, tbOwner.Text);
                    
                }
            }
            catch (Exception ex) { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassSer.toXML<List<ParkingLot>>(ref listLots, p.FileName);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2_Click(this, EventArgs.Empty);
            Console.WriteLine("auto-serialize");
        }
    }
}
