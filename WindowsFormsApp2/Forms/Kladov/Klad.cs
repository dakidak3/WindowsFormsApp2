using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms.Kladov;

namespace WindowsFormsApp2.Forms
{
    public partial class Klad : Form
    {
        public RegistrOsn RegistrOsn;
        public Klad()
        {
            InitializeComponent();
        }

        private void Klad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrOsn.Show();
            this.Close();
        }

        private void Klad_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrOsn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tkanisp tkani = new Tkanisp();
            tkani.BD = RegistrOsn.BD;
            tkani.Klad = this;
            tkani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FurnituraF fur = new FurnituraF();
            fur.Klad = this;
            fur.Show();
            this.Hide();
        }
    }
}
