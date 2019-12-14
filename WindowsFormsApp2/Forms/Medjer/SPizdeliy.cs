using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms.Medjer
{
    public partial class SPizdeliy : Form
    {
        Model1 BD = new Model1();
        public Form form;
        public RegistrOsn form1;
        public SPizdeliy()
        {
            InitializeComponent();
            изделиеBindingSource.DataSource = BD.Изделие.ToList();
        }

        private void SPizdeliy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
