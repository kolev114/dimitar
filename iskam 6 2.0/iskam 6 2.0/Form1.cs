using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iskam_6_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Azis")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=UM5VuSIJw1w");
            }
            if (comboBox1.Text == "Emanuela")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yIaJ6vLmfZo");
            }
            if (comboBox1.Text == "presvala")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dOGSwl8Haxg");
            }
            if (comboBox1.Text == "Toni Storaro")
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=7-A6WLQqSCE");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=nVu2sb_Nkhs");
        }
        
    }
}
