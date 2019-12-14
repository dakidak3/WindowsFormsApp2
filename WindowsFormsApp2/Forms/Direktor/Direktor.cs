using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class Direktor : Form
    {
        public RegistrOsn RegistrOsn;
        public Direktor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrOsn.Show();
            this.Close();
            
        }

        private void Direktor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medjer.SPizdeliy sPizdeliy = new Medjer.SPizdeliy();

            sPizdeliy.form = this;
            sPizdeliy.form1 = RegistrOsn;
            sPizdeliy.Show();
            this.Hide();

        }
    }
}
