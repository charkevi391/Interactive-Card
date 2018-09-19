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
            SolidBrush darkBlueBrush = new SolidBrush(Color.BlueViolet);

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.startButton.Visible = false;
            Refresh();

            Graphics g = this.CreateGraphics();

            g.Clear(Color.Aquamarine);

            Thread.Sleep(500);

            g.FillRectangle(darkBlueBrush, 30, 30, 100, 200);

        }
    }
}
