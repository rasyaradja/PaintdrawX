using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintDrawX
{
    public partial class Form1 : Form
    {
        private int drawStep = 0; // 0: nothing, 1: outer, 2: inner, 3: text

        public Form1()
        {
            InitializeComponent();
        }

        // Comment this out to see the annoying affect when you resize the form.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        // Menu item click handlers for drawing steps
        private void menuDrawOuterRing_Click(object sender, EventArgs e)
        {
            drawStep = Math.Max(drawStep, 1);
            this.Invalidate();
        }

        private void menuDrawCenterDot_Click(object sender, EventArgs e)
        {
            if (drawStep >= 1)
            {
                drawStep = Math.Max(drawStep, 2);
                this.Invalidate();
            }
        }

        private void menuDrawText_Click(object sender, EventArgs e)
        {
            if (drawStep >= 2)
            {
                drawStep = 3;
                this.Invalidate();
            }
        }

        // Draw the Gojek logo centered in the form.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height - menuStrip1.Height;
            int size = Math.Min(width, height - 60) * 3 / 4; // leave space for text
            int centerX = width / 2;
            int centerY = menuStrip1.Height + (height - 60) / 2 + 10;

            // Outer green arc (ring with gap at the bottom)
            if (drawStep >= 1)
            {
                int outerRadius = size / 2;
                int ringThickness = (int)(outerRadius * 0.55); // much thicker, close to reference
                Rectangle outerCircle = new Rectangle(centerX - outerRadius, centerY - outerRadius, size, size);
                using (Pen greenPen = new Pen(Color.FromArgb(0, 184, 72), ringThickness))
                {
                    greenPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    greenPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    greenPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    // Draw arc from 135 to 405 degrees (270 deg, leaves a gap at the bottom)
                    e.Graphics.DrawArc(greenPen, outerCircle, 135, 270);
                }
            }

            // Center green dot
            if (drawStep >= 2)
            {
                int outerRadius = size / 2;
                int dotRadius = (int)(outerRadius * 0.38); // much thicker, close to reference
                int dotSize = dotRadius * 2;
                Rectangle dotCircle = new Rectangle(centerX - dotRadius, centerY - dotRadius, dotSize, dotSize);
                using (Brush greenBrush = new SolidBrush(Color.FromArgb(0, 184, 72)))
                {
                    e.Graphics.FillEllipse(greenBrush, dotCircle);
                }
            }

            // Draw 'gojek' text
            if (drawStep >= 3)
            {
                string text = "gojek";
                using (Font font = new Font("Arial Rounded MT Bold", 40, FontStyle.Bold))
                using (Brush blackBrush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = e.Graphics.MeasureString(text, font);
                    float textX = centerX - textSize.Width / 2;
                    float textY = centerY + size / 2 - 10 + 0.08f * size;
                    e.Graphics.DrawString(text, font, blackBrush, textX, textY);
                }
            }
        }
    }
}
