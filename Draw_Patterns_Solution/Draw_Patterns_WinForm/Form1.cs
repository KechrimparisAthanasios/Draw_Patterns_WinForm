using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Patterns_WinForm
{
    public partial class Form1 : Form
    {
        Pen _pen = new Pen(Color.Aquamarine);
        Graphics _graphics = null;

         static int center_x, center_y;
         static int _startX, _startY;
         static int _endX, _endY;

         static int _angle = 0;
        static int _length = 0;
         static int _increment = 0;
         static int num_lines = 0;

        public Form1()
        {
            InitializeComponent();

            // Getting the center position of the Canvas
            _startX = CanvasPanel.Width / 2;
            _startY = CanvasPanel.Height / 2;

            //for (int i = 0; i < 5; i++)
            //{
            //    _length = i + 50;
            //    _increment = 1;
            //    _angle = 1 + 100;

            //    // Getting the center position of the Canvas
            //    _startX = CanvasPanel.Width / 2;
            //    _startY = CanvasPanel.Height / 2;

            //    lengthtxt.Text = i + 100.ToString();
            //    linestxt.Text = i + 200.ToString();

            //    CanvasPanel.Refresh();
            //}
        }

        private void Drawbtn_Click(object sender, EventArgs e)
        {
            _length = int.Parse(lengthtxt.Text);
            _increment = int.Parse(incrementtxt.Text);
            _angle = int.Parse(angletxt.Text);

            // Getting the center position of the Canvas
            _startX = CanvasPanel.Width / 2;
            _startY = CanvasPanel.Height / 2;

            CanvasPanel.Refresh();
        }

        private void Draw()
        {
            _angle = _angle + int.Parse(angletxt.Text);
            _length = _length + int.Parse(incrementtxt.Text);

            _endX = (int)(_startX + Math.Cos(_angle * .017453292519) * _length);
            _endY = (int)(_startY + Math.Sin(_angle * .017453292519) * _length);

            Point[] points =
            {
                new Point(_startX, _startY),
                new Point(_endX, _endY),
            };

            _startX = _endX;
            _startY = _endY;

            _graphics.DrawLines(_pen, points);
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            _pen.Width = 2;
            _length = int.Parse(lengthtxt.Text);
            _graphics = CanvasPanel.CreateGraphics();
            for (int i = 0; i < int.Parse(linestxt.Text); i++)
            Draw();

        }
    }
}
