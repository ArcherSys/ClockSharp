using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArcherSysOS;
namespace ClockSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e)
        {

            label1.Text = Timex.NowHours();
            label2.Text = Timex.NowMinutes();
            label3.Text = Timex.NowSeconds();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TimexTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 10)
            {

                label1.Text = "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                label1.Text = DateTime.Now.Hour.ToString();
            }

            if (DateTime.Now.Minute < 10)
            {

                label2.Text = "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                label2.Text = DateTime.Now.Minute.ToString();
            }
            if (DateTime.Now.Second < 10)
            {

                label3.Text = "0"  + DateTime.Now.Second.ToString();

            }
            else
            {
                label3.Text = DateTime.Now.Second.ToString();
            }

            
            
        }
    }
}
