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
    public partial class Registr : Form
    {

        public RegistrOsn RegistrOsn;
        public Model1 BD;
        public Registr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool c = false;
            bool s = false;
            string A = textBox2.Text;

            if (A.Length >= 6)
            {

                for (int i = 0; i < textBox2.TextLength; i++)
                {
                    if (A[i] >= '0' && A[i] <= '9')
                    {
                        s = true;
                        break;
                    }
                    else
                    {
                        
                    }
                }
                if (!s)
                {
                    MessageBox.Show("Пароль должен содержать хотя-бы одну цифру");
                    textBox2.Clear();
                    textBox3.Clear();
                    c = false;
                    s = false;
                }
                    
                for (int i = 0; i < textBox2.TextLength; i++)
                {
                    if (A[i] == '!' || A[i] == '@' || A[i] == '#' || A[i] == '$' || A[i] == '%' || A[i] == '^')
                    {
                        c = true;
                        break;
                    }
                    
                }
                if (!c)
                {
                    MessageBox.Show("Пароль должен содержать один из специальных символов=>( ! @ # $ % ^)");
                    textBox2.Clear();
                    textBox3.Clear();
                    c = false;
                    s = false;
                }

            }
            else
            {
                MessageBox.Show("Длина пароля должна быть не менее 6 символов!");
                textBox2.Clear();
                textBox3.Clear();
                c = false;
                s = false;
            }



            if (c && s)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    try
                    {
                        Пользователь users = new Пользователь() { Логин = textBox1.Text, Пароль = textBox2.Text, Роль = "zakaz", Наименование = textBox4.Text };
                        BD.Пользователь.Add(users);
                        BD.SaveChanges();
                        MessageBox.Show("Успешно!");
                        RegistrOsn.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                        c = false;
                        s = false;
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                    c = false;
                    s = false;
                }
            }




        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrOsn.Show();
            this.Close();
        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }
    }
       

        
    
}
