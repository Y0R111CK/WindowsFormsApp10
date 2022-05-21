using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();         
            g.DrawEllipse(Pens.Black, 110, 5, 75, 75);//Голова
            g.FillEllipse(Brushes.Black, 110, 5, 75, 75);

            SolidBrush a = new SolidBrush(Color.Black);// Л рука
            g.FillRectangle(a, 50, 80, 50, 120);

            SolidBrush b = new SolidBrush(Color.Black);// Тело
            g.FillRectangle(b, 110, 80, 80, 200);

            SolidBrush c = new SolidBrush(Color.Black);// П рука
            g.FillRectangle(c, 200, 80, 50, 120);

            SolidBrush d = new SolidBrush(Color.Black);// Л нога
            g.FillRectangle(d, 110, 290, 35, 200);

            SolidBrush r = new SolidBrush(Color.Black);// П нога
            g.FillRectangle(r, 155, 290, 35, 200); 
        }
    }
}