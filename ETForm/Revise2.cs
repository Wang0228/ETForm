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
    public partial class Revise2 : Form
    {
        private string _number;
        public Revise2(string number)
        {
            InitializeComponent();
            label1.Text= number;
            _number = number;
        }

        private void Revise2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact();
                var list = contact.Table.Where(x => x.Number == _number).ToList();
                foreach(var x in list)
                {
                    x.Name = textBox2.Text;
                    x.Quantity = textBox3.Text;
                    x.Price = textBox4.Text;
                    x.Category = textBox5.Text;
                }

                contact.SaveChanges();
                MessageBox.Show("更改成功!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.Message}");
            }

            
        }
    }
}
