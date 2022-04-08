using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using MakerPlaid.Properties;
using MakerPlaid.Annotations;
using System.Runtime.CompilerServices;
using Cyotek.Windows.Forms;

namespace MakerPlaid.Ctrl
{
    public partial class VerticalColorGrid : UserControl, INotifyPropertyChanged
    {
        public Color SelectColor { get; set; } = Color.CornflowerBlue;

        /// <summary> Индекс выбранного элемента </summary>
        public int SelectedItem {
            get => _selectedItem;
            set
            {
                if (value == _selectedItem) return;
                _selectedItem = value;
                OnPropertyChanged();
            }
        } private int _selectedItem = -1;

        public ColorEditor Editor { get; set; }

        public event EventHandler Select;
        /// <summary> Размер кубика с цветом </summary>
        public Size BoxSize {
            get => _boxSize;
            set
            {
                if (value.Equals(_boxSize)) return;
                _boxSize = value;
                OnPropertyChanged();
            }
        } private Size _boxSize = new Size(20,20);
       

        public BindingList<Color> Items { get; set; } = new BindingList<Color>();
        public VerticalColorGrid()
        {
            InitializeComponent();
            VisibleChanged += OnVisibleChanged;
            Paint += OnPaint;
            MouseMove += OnMouseMove;
            MouseDown += OnMouseDown;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > Items.Count * BoxSize.Height + 1)
            {
                if(Editor==null) return;
                Editor.BringToFront();
                Editor.Location = new Point(Left+e.Location.X,Top+e.Location.Y);
                Editor.Visible = true;
                return;
            }
            Select?.Invoke(this, EventArgs.Empty);
            Visible = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            int i = (2 + e.Y) / BoxSize.Height;
            if (i != SelectedItem)
            {
                SelectedItem = i;
                Invalidate();
            }
        }

        private void OnVisibleChanged(object sender, EventArgs e)
        {
            Size = new Size((Items?.Count??0)*_boxSize.Width+5,(Items?.Count??0)*_boxSize.Height+5);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            SuspendLayout();
            for (var i = 0; i < Items.Count; i++)
            {
                var r = new Rectangle(2, 2, BoxSize.Width, BoxSize.Height);
                e.Graphics.FillRectangle(new SolidBrush(Items[i]), r);
                if (i == SelectedItem)
                {
                    r.Inflate(1,1);
                    e.Graphics.DrawRectangle(new Pen(SelectColor,2),r);
                }
            }
            //e.Graphics.DrawImage(Resources.plus,new Point((Width-Resources.plus.Width)/2,Items.Count* BoxSize.Height + (BoxSize.Height-Resources.plus.Height)/2));
            ResumeLayout();
        }

        #region event

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}
