using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Эмпр_мтд
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random z = new Random();
            for (int i=0;i<50;i++)
            {
                double g = z.Next(-525, 3230);
                g /= 100;
                listBox1.Items.Add(g);
            }
            for (int i = 0; i < 50; i++)
            {
                listBox2.Items.Add(z.Next(-21, 4));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
