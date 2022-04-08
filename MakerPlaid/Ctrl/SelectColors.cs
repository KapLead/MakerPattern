using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MakerPlaid.Ctrl
{
    public class SelectColors : MaterialCard
    {
        private ListBox lb = null;
        public event EventHandler SelectedIndexChanged;
        public Color Color { get; private set; }
        public SelectColors()
        {
            lb = new ListBox
            {
                BorderStyle = BorderStyle.None,
                DrawMode = DrawMode.OwnerDrawFixed,
                ItemHeight = 22,
                IntegralHeight = false,
                Dock = DockStyle.Fill,
            };
            lb.SelectedIndexChanged += LbOnSelectedIndexChanged;
            lb.DrawItem += LbOnDrawItem;
            Controls.Add(lb);
            Width = 200;
            BorderStyle = BorderStyle.Fixed3D;
        }

        private void LbOnSelectedIndexChanged(object sender, EventArgs e)
        {
            Color = (Color)lb.SelectedItem;
            SelectedIndexChanged?.Invoke(this,e);
            Visible = false;
        }

        private int border = 2;
        private void LbOnDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index<0) return;
            int db = border + border + 1;
            e.Graphics.FillRectangle(new SolidBrush((Color)lb.Items[e.Index]), border, e.Bounds.Y+border, e.Bounds.Right-db,e.Bounds.Height-db);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                lb?.Items?.Clear();
                if (PlaidMakerControl.Instance != null)
                {
                    foreach (Color color in PlaidMakerControl.Instance.Colors.Reverse())
                        lb?.Items.Add(color);
                    Height = PlaidMakerControl.Instance.Colors.Length * 22 + Padding.Vertical + border + border;
                }
            }
        }
    }
}
