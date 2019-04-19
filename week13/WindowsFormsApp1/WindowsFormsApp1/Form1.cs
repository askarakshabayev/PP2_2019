using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GraphicsPath gp = new GraphicsPath();

        int x = 200, y = 200, r = 100;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(pen.Brush, gp);
            e.Graphics.FillPolygon(new Pen(Color.Black).Brush, new Point[]
            {
                new Point(100, 100),
                new Point(100, 200),
                new Point(200, 100)
            });
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point currPoint = e.Location;
            if (gp.IsVisible(currPoint))
            {
                pen = new Pen(Color.Blue);
            } else
            {
                pen = new Pen(Color.Red);
            }
            Refresh();
        }

        Pen pen = new Pen(Color.Red);


        private void Form1_Load(object sender, EventArgs e)
        {
            gp.AddEllipse(new Rectangle(x - r, y - r, 2 * r, 2 * r));
            gp.AddRectangle(new Rectangle(x + r , y + r, 3 * r, 3 * r));
        }
    }
}
