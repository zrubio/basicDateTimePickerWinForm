using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicDateTimePickerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime input = dateTimePicker1.Value;
            String day = input.Day.ToString();
            String month = input.Month.ToString();
            String year = input.Year.ToString();

            label3.Text = year +" "+ month +" "+ day;
        }
    }
}
