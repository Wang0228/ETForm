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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            var list = contact.Table.ToList();
            if (list.Select(x => x.Number).Any(x => x == textBox1.Text))
            {
                var dl = list.Where(x => x.Number == textBox1.Text);
                foreach(var x in dl)
                {
                    contact.Table.Remove(x);
                }
                contact.SaveChanges();
                MessageBox.Show("刪除完成!");
                Clear();
            }
            else
            {
                MessageBox.Show("錯誤編號");
            }
        }
        private void Clear()
        {
            textBox1.Clear();
        }
    }
}
