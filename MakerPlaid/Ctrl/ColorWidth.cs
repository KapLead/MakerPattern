using MakerPlaid.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MakerPlaid.Ctrl
{
    public partial class ColorWidth : UserControl
    {
        public decimal CountPixel
        {
            get => numericUpDown1.Value;
            set => numericUpDown1.Value = value;
        }

        public Color Color
        {
            get => label2.BackColor;
            set => label2.BackColor = value;
        }

        public ColorWidth()
        {
            InitializeComponent();
            numericUpDown1.MouseMove += label2_MouseMove;
            numericUpDown1.MouseLeave += label2_MouseLeave;
        }

        private void ColorWidth_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Image = null;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "▼";
            label3.Image = Resources.minus;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Image = null;
        }

        private void label1_Move(object sender, EventArgs e)
        {
            label2.Text = "▼";
            label3.Image = Resources.minus;
        }

        private Label l;
        private void label2_Click(object sender, EventArgs e)
        {
            l = (Label) sender;
            if(l==null) return;
            PlaidMakerControl.Instance.selectColors1.Location = new Point(l.Left+l.Width+l.Parent.Parent.Left,l.Top+l.Height+l.Parent.Parent.Top);
            PlaidMakerControl.Instance.selectColors1.Visible = !PlaidMakerControl.Instance.selectColors1.Visible;
            PlaidMakerControl.Instance.selectColors1.SelectedIndexChanged+= SelectColors1OnSelectedIndexChanged;
        }

        private void SelectColors1OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PlaidMakerControl.Instance.selectColors1.SelectedIndexChanged -= SelectColors1OnSelectedIndexChanged;
            PlaidMakerControl.Instance.selectColors1.Visible = false;
            if (l != null)
            {
                l.BackColor = PlaidMakerControl.Instance.selectColors1.Color;
                PlaidMakerControl.Instance.Calculate(); // пересчитать
            }
            l = null;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PlaidMakerControl.Instance.Calculate(); // пересчитать
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Dispose();
        }
    }
}
