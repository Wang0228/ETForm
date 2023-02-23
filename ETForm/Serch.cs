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
    public partial class Serch : Form
    {
        public Serch()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            var list = contact.Table.ToList();
            if (list.Select(x => x.Number).Any(x => x == textBox1.Text))
            {
                var show = new Serch2(Convert.ToString(textBox1.Text));
                show.ShowDialog();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("錯誤編號");
            }
        }
    }
}
