using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Interactive_Card

    ///Designed By: Charlie Kevill
    ///Date: Sept 2018
    ///Description: An Interactive Shape Day card with an animated joke inside

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SolidBrush blueBrush = new SolidBrush(Color.BlueViolet);
            SolidBrush yellowBrush = new SolidBrush(Color.YellowGreen);
            Pen drawPen = new Pen(Color.YellowGreen, 10);
            Pen mouthPen = new Pen(Color.Black,8);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("TimesNewRoman", 16, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush blueBrush = new SolidBrush(Color.BlueViolet);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.YellowGreen, 10);
            Pen mouthPen = new Pen(Color.Black, 2);

            this.BackgroundImage = null;
            this.startButton.Visible = false;
            Refresh();

            g.Clear(Color.Aquamarine);

            Thread.Sleep(500);

            //Initial Drawing of Shapes 
            g.DrawLine(drawPen, 0, 305, 550, 305);
            g.FillRectangle(blueBrush, 50, 200, 100, 100);
            g.FillEllipse(yellowBrush, 250, 200, 100, 100);
            g.FillEllipse(blackBrush, 300, 230, 12, 12);
            g.FillEllipse(blackBrush, 270, 230, 12, 12);
            g.FillEllipse(blackBrush, 110, 230, 12, 12);
            g.FillEllipse(blackBrush, 80, 230, 12, 12);
            g.DrawEllipse(mouthPen, 290, 260, 10, 20);
            g.DrawEllipse(mouthPen, 90, 260, 20, 10);

        }
    }
}
