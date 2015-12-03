using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starwars_Project
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Explosion(100, 100, 100);
        }
        private void Explosion(float x, float y, float pixels)
        {
            // create pen and brush
            SolidBrush Drawbrush = new SolidBrush(Color.Yellow);
           Pen expen = new Pen(Color.Red,7);
            
           
            
           // Scale the explosion
            float sizemultiplier = pixels / 100;
            //fill elipse to change colour
            g.FillEllipse(Drawbrush, 0 * sizemultiplier + x, 0 * sizemultiplier + y, 100 * sizemultiplier, 100 * sizemultiplier);
            // Draw lines for star
            g.DrawLine(expen, sizemultiplier * 0 + x, sizemultiplier * 47 + y, sizemultiplier * 36 + x, sizemultiplier * 38 + y);
            g.DrawLine(expen, sizemultiplier * 36 + x, sizemultiplier * 38 + y, sizemultiplier * 48 + x, sizemultiplier * 0 + y);
            g.DrawLine(expen, sizemultiplier * 48 + x, sizemultiplier * 0 + y, sizemultiplier * 58 + x, sizemultiplier * 38 + y);
            g.DrawLine(expen, sizemultiplier * 58 + x, sizemultiplier * 38 + y, sizemultiplier * 98 + x, sizemultiplier * 50 + y);
            g.DrawLine(expen, sizemultiplier * 98 + x, sizemultiplier * 50 + y, sizemultiplier * 59 + x, sizemultiplier * 61 + y);
            g.DrawLine(expen, sizemultiplier * 59 + x, sizemultiplier * 61 + y, sizemultiplier * 48 + x, sizemultiplier * 99 + y);
            g.DrawLine(expen, sizemultiplier * 48 + x, sizemultiplier * 99 + y, sizemultiplier * 36 + x, sizemultiplier * 61 + y);
            g.DrawLine(expen, sizemultiplier * 36 + x, sizemultiplier * 61 + y, sizemultiplier * 0 + x, sizemultiplier * 47 + y);
          
        }


    }


}
