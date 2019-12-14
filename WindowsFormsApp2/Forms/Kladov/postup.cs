using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms.Kladov
{
    public partial class postup : Form
    {
        public postup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null || numericUpDown1.Value == 0 || numericUpDown3.Value == 0)
            {
                return;
            }
            listBox1.Items.Add(comboBox1.Text + " Кол-во:" + numericUpDown1.Value + " Цена:" + numericUpDown1.Value * numericUpDown3.Value);
        }

        private void postup_Load(object sender, EventArgs e)
        {
            Model1 BD = new Model1();
            comboBox1.DataSource = BD.Ткань.ToList();
            comboBox2.DataSource = BD.Фурнитура.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == null || numericUpDown2.Value == 0 || numericUpDown4.Value ==0)
            {
                return;
            }
            listBox1.Items.Add(comboBox2.Text + " Кол-во:" + numericUpDown2.Value + " Цена:" + numericUpDown2.Value * numericUpDown4.Value);
        }
    }
}
