using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DermoPhotoshop : Form
    {
        Bitmap Izdelie;
        bool status = false;
        Model1 BD = new Model1();
        public DermoPhotoshop()
        {
            InitializeComponent();
            фурнитураBindingSource.DataSource = BD.Фурнитура.ToList();
            //  comboBox1.DataSource = BD.Фурнитура.;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer2_Panel1_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = "Высота: "+splitContainer2.Panel1.Height.ToString();
            label2.Text = "Длина: " + splitContainer2.Panel1.Width.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            status = false;
        } 

        int offsetX = 0;
        int offsetY = 0;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            status = true;

            offsetX = e.Location.X;
            offsetY = e.Location.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (status)
            {
                int x = Cursor.Position.X - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2) - offsetX;

                int y = Cursor.Position.Y - (this.Top + (this.Size.Height - this.ClientSize.Height - 4)) - offsetY;

                if (x > 0 && x < this.splitContainer2.Panel1.Width - pictureBox1.Width)
                    pictureBox1.Left = x;
                else
                    pictureBox1.Left = x > 0 ? x = this.splitContainer2.Panel1.Width - pictureBox1.Width : 0;

                if (y > 0 && y < this.splitContainer2.Panel1.Height - pictureBox1.Height)
                    pictureBox1.Top = y;
                else
                    pictureBox1.Top = y > 0 ? y = this.splitContainer2.Panel1.Height - pictureBox1.Height : 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {    
        }

        private void повернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            int x = pictureBox1.Size.Height;
            int y = pictureBox1.Size.Width;
            pictureBox1.Size = new Size(x, y);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result== DialogResult.OK)
            {
                dialog.Filter = "*Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                Bitmap image = new Bitmap(dialog.FileName);
               // pictureBox1.Image = image;
                splitContainer2.Panel1.BackgroundImage = image;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                dialog.Filter = "*Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                Bitmap image = new Bitmap(dialog.FileName);
                 pictureBox1.Image = image;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int XX = 1;
            int width = splitContainer2.Panel1.Width;
            int height = splitContainer2.Panel1.Height;
            int locX = pictureBox1.Location.X;
            int HeightX = locX + pictureBox1.Width;
            int locY = pictureBox1.Location.Y;
            int HeightY = locY + pictureBox1.Height;
            Bitmap newImage = new Bitmap(splitContainer2.Panel1.BackgroundImage, splitContainer2.Panel1.Width, splitContainer2.Panel1.Height);
            Bitmap zadnee = new Bitmap(splitContainer2.Panel1.BackgroundImage);
            Bitmap pered = new Bitmap(pictureBox1.Image,pictureBox1.Width, pictureBox1.Height);
            try
            {
                pictureBox2.Image = newImage;
                for (int x = locX; x < HeightX-1; x++)
                {
                    int YY = 1;
                    XX++;
                    for (int y = locY; y < HeightY - 1; y++)
                    {
                        Color newcolor = pered.GetPixel(XX - 1, YY);
                        newImage.SetPixel(x, y, newcolor);
                        YY++;
                    }
                }
            }

            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            pictureBox2.Image = newImage;
            pictureBox2.Width = splitContainer2.Panel1.Width;
            pictureBox2.Height = splitContainer2.Panel1.Height;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image !=null)
            {
                Izdelie = (Bitmap)pictureBox2.Image;
                Izdelie.Save(@"image\" + label3.Text+"jpg");
                Изделие izdelie = new Изделие();
                Random x = new Random();
                int qwe = x.Next();
                        izdelie.Артикул = qwe.ToString();
                        izdelie.Длина = splitContainer2.Panel1.Height.ToString();
                        izdelie.Ширина = splitContainer2.Panel1.Width.ToString();
                        izdelie.Наименование = textBox1.Text;
                        izdelie.Изображение = @"image\" + textBox1.Text + ".jpg";
                        BD.Изделие.Add(izdelie);
                BD.SaveChanges();
    
                }
                
               
            }
           

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    string s = comboBox1.Text;
                    string s2 = s.Substring(s.Length - 1);

                    if (s2 == " ")
                    {
                        s = s.Remove(s.Length - 1);
                    }


                    if (s[0] == ' ')
                    {
                        s = s.Remove(0, 1);
                    }
                    string s1 = @"image\" + s + ".jpg";
                    
                    pictureBox1.ImageLocation = s1;
                   
                    if (pictureBox1.Image == null)
                    {
                        
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void Vibor(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
