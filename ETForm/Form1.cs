using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var DT = new DataShow();
            DT.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new Add();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var revise=new Revise();
            revise.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var delete = new Delete();
            delete.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var serch = new Serch();
            serch.ShowDialog();
        }
    }
}
