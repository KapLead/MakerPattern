using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace MakerPlaid.Ctrl
{
    public partial class ColorComboPicer : UserControl
    {
        public static event EventHandler ShowColorPicker;
        public string Title
        {
            get => materialLabel1.Text;
            set => materialLabel1.Text = value;
        }

        public Color Color
        {
            get => color?.Color ?? Color.White;
            set
            {
                pictureBox1.BackColor = color.Color = value;
                materialTextBox21.Text = ColorTranslator.ToHtml(value);
                PlaidMakerControl.Instance?.Calculate(); // пересчитать
            }
        }

        public string HtmlColor => materialTextBox21.Text;

        public bool VisibleCombo
        {
            get => color?.Visible??false;
            set
            {
                if (color != null) 
                    color.Visible = value;
            }
        }

        ColorWheel color = null;

        public ColorComboPicer()
        {
            color = new ColorWheel { BackColor = Color.White, Location = new Point(Left,Top+Height), Size = new Size(Width, Width), Visible = false };
            InitializeComponent();
            Color = BackColor;
            color.ColorChanged += (sender, args) =>{Color = color.Color;};
            materialLabel1.Click += MaterialLabel1OnClick;
            materialLabel1.FontChanged += (sender, args) => { color.Visible = materialLabel1.Focused; };
           // materialTextBox21.TextChanged += (sender, args) => { HtmlColor = materialTextBox21.Text; };
            pictureBox1.Click += MaterialLabel1OnClick;
            ShowColorPicker+= OnShowColorPicker;
            LocationChanged += (sender, args) => color.Location = new Point(Left, Top + Height);
        }

        private void OnShowColorPicker(object sender, EventArgs e)
        {
            if(sender!=this && color!=null) color.Visible = false;
        }

        private void MaterialLabel1OnClick(object sender, EventArgs e)
        {
            if (color != null)
            {
                color.Visible = !color.Visible;
                if (color.Visible)
                {
                    ShowColorPicker?.Invoke(this, e);
                    color.BringToFront();
                }
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (this.Parent != null)
            {
                color.Parent = this.Parent;
                color.Location = new Point(this.Left,this.Bottom-1);
                color.BringToFront();
            }
        }

        private void ColorComboPicer_ParentChanged(object sender, EventArgs e)
        {
            if(Parent==null) return;
            Parent.Click+= ParentOnClick;
        }

        private void ParentOnClick(object sender, EventArgs e)
        {
            color.Visible = false;
        }

        private void добавитьЕщёЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new ColorComboPicer{Dock=DockStyle.Top,Title = "Цвет #"+(Parent.Controls.Count+1)};
            Parent?.Controls.Add(c);
            c.BringToFront();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color.Dispose();
            this.Dispose();
        }
    }
}
