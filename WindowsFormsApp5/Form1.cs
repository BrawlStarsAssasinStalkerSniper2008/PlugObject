using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Web;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int updid;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void te
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updid = (int)dataGridView1.SelectedRows[0].Cells[0].Value - 1;
        }
    }
}
