using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient.BaseControls
{
    public class ExButton : Button
    {
        bool hovered;

        public ExButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            //BackColor = Color.DimGray;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Silver;
            FlatAppearance.BorderColor = Color.White;
            FlatAppearance.MouseDownBackColor = Color.Gray;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 50, 50, 50);
            Height = 40;
            Width = 110;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            hovered = true;
            ForeColor = Color.White;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hovered = false;
            ForeColor = Color.Black;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (hovered)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                var rect = ClientRectangle;
                rect = new Rectangle(rect.Right - 20, rect.Bottom - 13, 15, 7);
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, rect);
                e.Graphics.DrawRectangle(Pens.Black, rect);
            }
        }
    }
}
