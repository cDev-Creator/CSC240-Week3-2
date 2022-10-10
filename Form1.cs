using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_03_03_AdmissionGUI_NGM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            decimal score = numericUpDown1.Value;
            decimal gpa = numericUpDown2.Value;

            if(score >= 60 && gpa >= 3 || score >= 80 && gpa < 3)
            {
                label3.Visible = true;
                string message = "Accepted!";
                label3.Text = message;
            }
            else
            {
                label3.Visible = true;
                string message = "Rejected!";
                label3.Text = message;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {}
    }
}
