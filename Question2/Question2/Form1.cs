using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {

        bool isDrawing = false;
        Point prevPoint;
        System.Drawing.Pen myPen;
        

        public Form1()
        {
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);

            InitializeComponent();

        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            prevPoint = e.Location;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (redRadioButton.Checked)
            {
                myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            }
            else if (blueRadioButton.Checked)
            {
                myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            }
            else if (greenRadioButton.Checked)
            {
                myPen = new System.Drawing.Pen(System.Drawing.Color.Green);
            }
            else if (blackRadioButton.Checked)
            {
                myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            }

            if (smallRadioButton.Checked)
            {
                myPen.Width = 5.0F;
            }
            else if (mediumRadioButton.Checked)
            {
                myPen.Width = 20.0F;
            }
            else if (largeRadioButton.Checked)
            {
                myPen.Width = 40.0F;
            }

            if (isDrawing)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(myPen, prevPoint, e.Location);
                prevPoint = e.Location;

                /* numOfMouseEvents = 0; */
            }
            myPen.Dispose();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
