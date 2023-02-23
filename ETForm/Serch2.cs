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
    public partial class Serch2 : Form
    {

        public Serch2(string number)
        {
            InitializeComponent();
            var contact= new Contact();
            var list = contact.Table.Where(x=>x.Number==number).ToList();
            label1.Text = number;
            foreach(var x in list)
            {
                label6.Text = x.Name;
                label7.Text = x.Quantity;
                label8.Text = x.Price;
                label9.Text = x.Category;
            }

        }

        private void Serch2_Load(object sender, EventArgs e)
        {

        }
    }
}
