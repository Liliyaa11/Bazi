using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Table1' table. You can move, or remove it, as needed.
            //this.table1TableAdapter.Fill(this.database1DataSet2.Table1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table1BindingSource.DataSource = this.database1DataSet2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database1DataSet2.Table1.AddTable1Row(int.Parse(textBox2.Text), textBox1.Text, textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(database1DataSet2.Table1);
        }
    }
}
