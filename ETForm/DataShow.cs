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
    public partial class DataShow : Form
    {
        public DataShow()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            var contactData = new Contact();
            var list=contactData.Table.ToList();
            dataGridView1.DataSource = list;
        }
        
        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
