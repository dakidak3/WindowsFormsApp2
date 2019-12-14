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
    public partial class zakaz : Form
    {
        Model1 BD = new Model1();
        public RegistrOsn RegistrOsn;
        static Random x = new Random();
        string n;
      
        public zakaz()      
        {
            InitializeComponent();
        }

        private void zakaz_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = BD.Изделие.ToList();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            DermoPhotoshop photoshop = new DermoPhotoshop();
            photoshop.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = BD.Изделие.ToList();
            comboBox1.Refresh();
            n = x.Next().ToString();
            label1.Text = "Номер заказа:" + n;
            Заказ zakaz1 = new Заказ();
            zakaz1.Дата = dateTimePicker1.Value.Date;
            zakaz1.Заказчик = "1";    //BD.Пользователь.Find(RegistrOsn.log).Наименование;
            zakaz1.Менеджер = null;

            zakaz1.Номер = n;
               
            zakaz1.Стоимость = 1;
            zakaz1.ЭтапВыполнения = "Новый";  

            BD.Заказ.Add(zakaz1);
            BD.SaveChanges();
            button4.Enabled = true;








        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value !=0)
            {
                string g = comboBox1.Text;
                ЗаказаныеИзделия izdz = new ЗаказаныеИзделия();
                izdz.АртикулИзделия = g;
                izdz.НомерЗаказа = n;
                izdz.Количество = (int)numericUpDown1.Value;
                listBox1.Items.Add(izdz.АртикулИзделия + " Кол-во:" + izdz.Количество);
                BD.ЗаказаныеИзделия.Add(izdz);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = "";
                BD.SaveChanges();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
