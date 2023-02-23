using ETForm.Models;
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
    public partial class Revise : Form
    {
        public Revise()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact();
                var list = contact.Table.ToList();
                if (list.Select(x=>x.Number).Any(x=>x==textBox1.Text)) 
                {
                    var show = new Revise2(Convert.ToString(textBox1.Text));
                    show.ShowDialog();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("錯誤編號");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Revise_Load(object sender, EventArgs e)
        {

        }
    }
}
