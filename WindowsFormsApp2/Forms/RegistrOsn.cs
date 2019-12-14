using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class RegistrOsn : Form
    {
        public Model1 BD = new Model1();
       
        public string log { get; set; }
        public RegistrOsn()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (BD.Пользователь.Find(textBox1.Text).Пароль == textBox2.Text)
                {
                    log = textBox1.Text;
                    switch (BD.Пользователь.Find(textBox1.Text).Роль)
                    {
                        
                        case "Direct":
                            Direktor dir = new Direktor();
                            dir.RegistrOsn = this;
                            textBox1.Clear();
                            textBox2.Clear();
                            dir.Show();
                            this.Hide();
                            
                            break;


                        case "Menedj":


                            Menedj Menedj1 = new Menedj();
                            Menedj1.RegistrOsn = this;
                            textBox1.Clear();
                            textBox2.Clear();
                            Menedj1.Show();
                            this.Hide();

                            break;


                        case "Kladov":
                            Klad Klad1 = new Klad();
                            Klad1.RegistrOsn = this;
                            textBox1.Clear();
                            textBox2.Clear();
                            Klad1.Show();
                            this.Hide();
                            break;



                        case "zakaz":
                            zakaz zakaz1 = new zakaz();
                            zakaz1.RegistrOsn = this;
                            textBox1.Clear();
                            textBox2.Clear();
                            zakaz1.Show();
                            this.Hide();

                            break;   
                            


                        default:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не верно!");
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Логин или пароль введены не верно!");
                textBox2.Clear();
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.RegistrOsn = this;
            registr.BD = BD;
            registr.Show();
            this.Hide();
            //kjuj
            
        }

        private void RegistrOsn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
