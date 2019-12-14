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
    public partial class Menedj : Form
    {

        public RegistrOsn RegistrOsn;
        int x;
        int y = 0;
        Model1 bd = new Model1();
        public Menedj()
        {
            InitializeComponent();
        }

        private void Menedj_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            List<Заказ> zakazi = bd.Заказ.Where(z => z.Менеджер == null || z.Менеджер == RegistrOsn.log).ToList();
            заказBindingSource.DataSource = zakazi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrOsn.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medjer.SPizdeliy sPizdeliy = new Medjer.SPizdeliy();

            sPizdeliy.form = this;
            sPizdeliy.form1 = RegistrOsn;
            sPizdeliy.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string h =(string) dataGridView1[y, x].Value;
            
            bd.Заказ.Find(h).Менеджер = RegistrOsn.log;
            bd.Заказ.Find(h).ЭтапВыполнения = "В обработке";

            bd.SaveChanges();
            List<Заказ> zakazi = bd.Заказ.Where(z => z.Менеджер == null || z.Менеджер == RegistrOsn.log).ToList();
            заказBindingSource.DataSource = zakazi;
            dataGridView1.Refresh();
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                x = e.RowIndex;
                if (bd.Заказ.Find((string)dataGridView1[y, x].Value).ЭтапВыполнения == "В обработке")
                {
                    button4.Enabled = false;
                    button5.Enabled = true;
                    button6.Enabled = true;
                }
                else if (bd.Заказ.Find((string)dataGridView1[y, x].Value).ЭтапВыполнения == "К оплате"||
                    bd.Заказ.Find((string)dataGridView1[y, x].Value).ЭтапВыполнения == "Отклонен")
                {
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else if (bd.Заказ.Find((string)dataGridView1[y, x].Value).ЭтапВыполнения == "Новый")
                {
                    button4.Enabled = true;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else
                {
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }

            }
            catch
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string h = (string)dataGridView1[y, x].Value;

           
            bd.Заказ.Find(h).ЭтапВыполнения = "К оплате";

            bd.SaveChanges();
            List<Заказ> zakazi = bd.Заказ.Where(z => z.Менеджер == null || z.Менеджер == RegistrOsn.log).ToList();
            заказBindingSource.DataSource = zakazi;
            dataGridView1.Refresh();
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string h = (string)dataGridView1[y, x].Value;


            bd.Заказ.Find(h).ЭтапВыполнения = "Отклонен";

            bd.SaveChanges();
            List<Заказ> zakazi = bd.Заказ.Where(z => z.Менеджер == null || z.Менеджер == RegistrOsn.log).ToList();
            заказBindingSource.DataSource = zakazi;
            dataGridView1.Refresh();
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            zakaz zakaz = new zakaz();
            zakaz.Show();
        }
    }
}
