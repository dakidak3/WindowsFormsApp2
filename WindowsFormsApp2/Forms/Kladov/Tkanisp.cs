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
    public partial class Tkanisp : Form
    {
        public Model1 BD;
        public Klad Klad;
        public Tkanisp()
        {
            InitializeComponent();
            Model1 model1 = new Model1();
            тканьBindingSource.DataSource = model1.Ткань.ToList();
        }

        private void Tkanisp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Klad.Show();
            this.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
