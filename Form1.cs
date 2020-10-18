using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitlu.Text, txtMesaj.Text);
            txtTitlu.Clear();
            txtMesaj.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitlu.Text = table.Rows[index].ItemArray[0].ToString();
                txtMesaj.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Titlu", typeof(String));
            table.Columns.Add("Mesaj", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Mesaj"].Visible = false;
            dataGridView1.Columns["Titlu"].Width = 140;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitlu.Clear();
            txtMesaj.Clear();
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}
