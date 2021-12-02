using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_1_1204017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vbButton_MouseMove(object sender, MouseEventArgs e)
        {
            vbButton.Top -= e.Y;
            vbButton.Left += e.X;
            if (vbButton.Top < -16 || vbButton.Top > 16)
            {
                vbButton.Top = 73;
            }

            if (vbButton.Left < -64 || vbButton.Left > 160)
            {
                vbButton.Left = 160;
            }
        }

        private void csButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

