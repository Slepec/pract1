using FastReport;
using FastReport.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1
{
    public partial class FormFR : Form
    {
        public FormFR()
        {
            InitializeComponent();
        }
        PreviewControl pc = new PreviewControl();
        private void FormFR_Load(object sender, EventArgs e)
        {
            pc.Size = new Size(this.Size.Width, this.Size.Height);
            this.Controls.Add(pc);
            Report report = new Report();
               report.Load("myfastreport.frx");
            report.Preview = pc;
            report.Show();
        }
    }
}
