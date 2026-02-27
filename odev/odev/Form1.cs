using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Büyük");
            comboBox1.Items.Add("Orta");
            comboBox1.Items.Add("Küçük");


            listBox1.Items.Add("Americano Hot");
            listBox1.Items.Add("Callypso");
            listBox1.Items.Add("Turkish");
            listBox1.Items.Add("Pizza Italiano");
            listBox1.Items.Add("Etravaganzza");
        }
    }
}
