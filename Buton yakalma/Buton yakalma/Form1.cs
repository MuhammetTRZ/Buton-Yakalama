using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buton_yakalma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Text = ("Tebrikler Toplam Puanınız Şuan " + " " + Convert.ToInt16(i) + " " + ".");
            if (i<=20)
            {
                i++;
            }
            else if (i > 10)
            {
                label1.Text = "Oyun Bitti";
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //Random rastgele = new Random();
            //button1.Left=Convert.ToInt16(rastgele.Next(Size.Width-button1.Size.Width));
            //button1.Top = Convert.ToInt16(rastgele.Next(Size.Height-(label2.Height + label3.Height)) + label2.Height);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text= textBox1.Text;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            button1.Left = rastgele.Next(15, 378);
            button1.Top = rastgele.Next(35, 416);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
