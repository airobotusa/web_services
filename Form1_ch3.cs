using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            MessageBox.Show("Hello World!", "Hello World");
            label1.Text = "This button has been pressed " + i + " time(s)!";
            MessageBox.Show("Done. So click OK to close this window");
            int startingInt = 10;
            int returnedInt = DoCalculation(startingInt);
            label1.Text = returnedInt.ToString();

            DoCalculation(startingInt);
        }
        private int DoCalculation(int receivingInt)
        {
            int multiplyInt = receivingInt * 20;
            return multiplyInt;

        }
    }
}
