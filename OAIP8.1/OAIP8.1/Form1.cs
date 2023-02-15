using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAIP8._1
{
    public partial class Form1 : Form
    {
         static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictureBox;
            public static Pen pen;
        }
        Bitmap bitmap;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            Init.pictureBox.Image = Init.bitmap;
            g.DrawLine(Init.pen,
            float.Parse(textBox1.Text),
            float.Parse(textBox2.Text),
            float.Parse(textBox1.Text) * 2,
            float.Parse(textBox2.Text));
            Init.pictureBox.Image = Init.bitmap;
        }
        public void DrawLinePoint(PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            Point point1 = new Point(100, 100);
            Point point2 = new Point(500, 100);
            g.DrawLine(Init.pen, point1, point2);
            pictureBox1.Image = Init.bitmap;
        }
       
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a;
            while (!(double.TryParse(textBox1.Text, out a)))
            {
                MessageBox.Show("Введите число");
                textBox1.Clear();
                return;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double a;
            while (!(double.TryParse(textBox2.Text, out a)))
            {
                MessageBox.Show("Введите число");
                textBox2.Clear();
                return;
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
     