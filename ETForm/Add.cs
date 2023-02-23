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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var list = new Table()
            {
                Number = textBox1.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Quantity = textBox3.Text.Trim(),
                Price = textBox4.Text.Trim(),
                Category = textBox5.Text.Trim()
            };

            try
            {
                var contact = new Contact();
                contact.Table.Add(list);
                contact.SaveChanges();
                MessageBox.Show("存檔完成!");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.Message}");
            }
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
