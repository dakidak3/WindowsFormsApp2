﻿using System;
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
    public partial class FurnituraF : Form
    {
        public Klad Klad;
        public FurnituraF()
        {
            InitializeComponent();
            Model1 model1 = new Model1();
            фурнитураBindingSource.DataSource = model1.Фурнитура.ToList();
        }

        private void Furnitura_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klad.Show();
            this.Close();
        }

        private void фурнитураBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
