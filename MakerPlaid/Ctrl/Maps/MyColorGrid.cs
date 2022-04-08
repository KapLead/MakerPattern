using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MakerPlaid.Ctrl.Maps
{
    public partial class MyColorGrid : UserControl
    {
        public event EventHandler Selected;
        public static Color[] Items = null;

        public static Color SelectedColor
        {
            get
            {
                if (SelectedIndex >= 0 && SelectedIndex < Items.Length)
                    return Items[SelectedIndex];
                return Items[0];
            }
        }

        public static int SelectedIndex { get; private set; } = -1;
  
        public MyColorGrid()
        {
            InitializeComponent();

            if (Items == null)
            {
                Items = new Color[20];
                Clear();
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Items.Length; i++)
                Items[i] = Color.White;
            Invalidate();
        }

        private Color Inverse(Color c) => Color.FromArgb(c.A, 255 - c.R, 255-c.G,255-c.B);
        private Font f = new Font("Arial", 8.25f);
        private void MyColorGrid_Paint(object sender, PaintEventArgs e)
        {
            SuspendLayout();
            for (int y = 0,i=0; y < 2; y++)
            {
                for (int x = 0; x < 10; x++,i++)
                {
                    var r = new Rectangle(2 + x * 19, 2 + y * 19, 17, 17);
                    e.Graphics.FillRectangle(new SolidBrush(Items[i]), r);
                    e.Graphics.DrawString((i+1).ToString(),f, new SolidBrush(Inverse(Items[i])),r,new StringFormat{Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center} );
                    e.Graphics.DrawRectangle(new Pen(i==SelectedIndex?Color.CornflowerBlue:Color.Black), r);
                }
            }
            PerformLayout();
        }

        private void MyColorGrid_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - 2) / 19, y = (e.Y - 2) / 19;
            SelectedIndex = (y==1?10:0)+(x);
            Selected?.Invoke(this, e);
            Invalidate();
        }
    }
}
