using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MakerPlaid.Ctrl.Maps;

namespace MakerPlaid.Ctrl
{
    public partial class PatternEditorControl : UserControl
    {
        public string patterns = "Pattern";
        public PatternEditorControl()
        {
            InitializeComponent();
            handweavingPro1.Load("123456.wif");
            scale.Value = handweavingPro1.Scale;
            sizeSegmentX.Value = handweavingPro1.RoundWidth;
            sizeSegmentY.Value = handweavingPro1.RoundHeight;
            countSegment.Value = handweavingPro1.CountBox;
        }

        private void PatternEditorControl_Load(object sender, EventArgs e)
        {
            scale.Value=handweavingPro1.Scale;
            sizeSegmentX.Value = handweavingPro1.RoundWidth;
            sizeSegmentY.Value = handweavingPro1.RoundHeight;
            countSegment.Value = handweavingPro1.CountBox;

        }
        private void materialFloatingActionButton1_Click(object sender, EventArgs e) => Visible = false;
        private void reScale(object sender, int newValue) => handweavingPro1.Scale = newValue;
        private void reSizeSegment(object sender, int newValue) => handweavingPro1.RoundWidth = newValue;
        private void reCountSegment(object sender, int newValue) => handweavingPro1.CountBox = newValue;
        private void sizeSegmentY_onValueChanged(object sender, int newValue) => handweavingPro1.RoundHeight = newValue;

        private void myColorGrid1_Selected(object sender, EventArgs e)
        {
            colorWheel1.Color = MyColorGrid.SelectedColor;
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            if (MyColorGrid.Items.Length > MyColorGrid.SelectedIndex)
            {
                MyColorGrid.Items[MyColorGrid.SelectedIndex]=colorWheel1.Color;
                myColorGrid1.Invalidate();
            }
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()!= DialogResult.OK) return;
            handweavingPro1.Load(openFileDialog1.FileName);
            scale.Value = handweavingPro1.Scale;
            sizeSegmentX.Value = handweavingPro1.RoundWidth;
            sizeSegmentY.Value = handweavingPro1.RoundHeight;
            countSegment.Value = handweavingPro1.CountBox;
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()!= DialogResult.OK) return;
            handweavingPro1.SaveAs(saveFileDialog1.FileName);
            MessageBox.Show($"Узор сохранён в файл '{Path.GetFileName(saveFileDialog1.FileName)}'");
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var items = Directory.GetFiles($"{Application.StartupPath}\\{patterns}\\{materialComboBox1.SelectedItem}\\")
                .Select(s => new PatternItem(s)).ToArray();
            listBox1.Items.AddRange(items);
        }

        class PatternItem
        {
            public string Filename { get; private set; }
            public Bitmap Image { get; private set; }

            public PatternItem(string fname)
            {
                Image = new Bitmap(Filename=fname);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.Index<0) return;
            PatternItem pi = (PatternItem) listBox1.Items[e.Index];
            if (pi==null) return;
            var d = (e.Bounds.Width - 10f) / pi.Image.Width;
            for (int y = 0; y < pi.Image.Height; y++)
                for (int x = 0; x < pi.Image.Width; x++)
                    e.Graphics.FillRectangle(new SolidBrush(pi.Image.GetPixel(x,y)),e.Bounds.X+5+x*d,e.Bounds.Y+4+y*d,d,d);
            e.Graphics.DrawString(Path.GetFileNameWithoutExtension(pi.Filename), 
                e.Font,new SolidBrush(e.ForeColor),
                new Rectangle(e.Bounds.X, e.Bounds.Bottom-10, e.Bounds.Width,10), 
                new StringFormat{LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center});
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatternItem pi = (PatternItem)listBox1.SelectedItem;
            if(pi==null) return;
            var r = handweavingPro1.MiniMap.GetSize();
            for (int y = 0; y < r.Height && y< pi.Image.Height; y++)
            for (int x = 0; x < r.Width && x< pi.Image.Width; x++)
                handweavingPro1.MiniMap[x, y] = pi.Image.GetPixel(x, y).R != 255;
            handweavingPro1.Calculate();
        }

        private void materialFloatingActionButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Файл результата изображения (.BMP)|*.bmp";
            f.InitialDirectory = Application.StartupPath;
            if(f.ShowDialog()!= DialogResult.OK) return;
            handweavingPro1.GetMap().Save(f.FileName,ImageFormat.Bmp);
        }

        private void PatternEditorControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Directory.CreateDirectory(patterns);
                var folders = Directory.EnumerateDirectories(Application.StartupPath + "\\" + patterns, "*", SearchOption.AllDirectories).Select(s => s.Substring(s.LastIndexOf("\\", StringComparison.Ordinal) + 1)).ToArray();
                materialComboBox1.Items.AddRange(folders);
                if(materialComboBox1.SelectedIndex<0)
                    materialComboBox1.SelectedItem = "8x8";
            }
        }
    }


}
