using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MakerPlaid.Properties;
using MaterialSkin;

namespace MakerPlaid.Ctrl
{
    public partial class PlaidMakerControl : UserControl
    {
        public static PlaidMakerControl Instance = null;
        public Color[] Colors {
            get
            {
                List<Color> ret = new List<Color>();
                if (colorCard != null)
                    foreach (Control c in colorCard.Controls)
                    {
                        if (c is ColorComboPicer cc)
                            ret.Add(cc.Color);
                    }
                return ret.ToArray();
            }
        }
        public ColorWidth[] HorizontalColors => horCard?.Controls?.Cast<ColorWidth>()?.ToArray();
        public ColorWidth[] VerticalColors => verCard?.Controls?.Cast<ColorWidth>()?.ToArray();

        public PlaidMakerControl()
        {
            Instance = this;
            InitializeComponent();
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            var c = new ColorComboPicer { Dock = DockStyle.Top, Title = "Цвет #" + (colorCard.Controls.Count + 1) };
            colorCard.Controls.Add(c);
            c.BringToFront();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void materialCard2_ControlAdded(object sender, ControlEventArgs e)
        {
            materialLabel7.Text = $@"  Итого : {HorizontalColors?.Sum(c=>c?.CountPixel)} px";
            Calculate();
        }

        private void verCard_ControlAdded(object sender, ControlEventArgs e)
        {
            materialLabel6.Text = $@"  Итого : {VerticalColors?.Sum(c => c?.CountPixel)} px";
            Calculate();
        }

        private void HideAllOpen(object sender, EventArgs e)
        {
            if (selectColors1 != null)
                selectColors1.Visible = false;
            if (colorCard != null)
                foreach (Control c in colorCard.Controls)
                {
                    if (c is ColorComboPicer cc)
                        cc.VisibleCombo = false;
                }
        }

        private Color[] GetHor()
        {
            Color[] hor = HorizontalColors?.Select(c => c.Color)?.ToArray();
            if (hor?.Length == 0) return hor;
            int[] horlen = HorizontalColors?.Select(c => (int)c.CountPixel)?.ToArray();
            if (horlen?.Length == 0) return hor;
            bool h = materialCheckbox1.Checked;
            Color[] hh = new Color[horlen?.Sum()??0 * (h ? 2 : 1)];
            int index = 0,count=0;
            Color cur=hor[index];
            for (int x = 0; x < hh.Length; x++,count++)
            {
                if (count >= horlen[index])
                {
                    index++;
                    cur = hor[index];
                    count = 0;
                }
                hh[x] = cur;
            }
            return hh;
        }
        private Color[] GetVer()
        {
            Color[] hor = VerticalColors?.Select(c => c.Color)?.ToArray();
            if (hor?.Length == 0) return hor;
            int[] horlen = VerticalColors?.Select(c => (int)c.CountPixel)?.ToArray();
            if (horlen?.Length == 0) return hor;
            bool h = materialCheckbox2.Checked;
            bool b = false;
            Color[] hh = new Color[horlen?.Sum()??0 * (h ? 2 : 1)];
            int index = 0, count = 0;
            Color cur = hor[index];
            for (int x = 0; x < hh.Length; x++, count++)
            {
                if (count >= horlen[index])
                {
                    if (index == hor.Length) b=!b;
                    index+=b?1:-1;
                    if (index >= hor.Length) index = hor.Length - 1;
                    if (index < 0) index = 0;
                    cur = hor[index];
                    count = 0;
                }
                hh[x] = cur;
            }
            return hh;
        }

        private bool currCalculate = false;

        private Bitmap bmp;
        // расчёт картинки 
        public void Calculate()
        {
            //https://www.plaidmaker.com/plaid/img/?colors=1AF40A,0461FA&twill=1x1&x_mirror=0&x_str=1x10,2x10&y_mirror=0&y_str=2x10,1x10
            //https://www.plaidmaker.com/plaid/img/?colors=#00FF25      &twill=1x1&x_mirror=0&&x_str=2_10&y_mirror=0&y_str=1_10
            if (currCalculate || OsLoading) return;
            if (materialComboBox1.SelectedItem == null)
            {
                if(materialComboBox1.Items.Count>0)
                    materialComboBox1.SelectedIndex = 0;
                return;
            }
            currCalculate = true;
            string url = "https://www.plaidmaker.com/plaid/img/?colors=";
            url += string.Join(",", Colors?.Select(c => ColorTranslator.ToHtml(c).Substring(1)))+"&";
            url += $"twill=1x1&x_mirror={(materialCheckbox1.Checked ? "1" : "0")}&";
            url += $"x_str=";
            var h = HorizontalColors?.Select(c => c.CountPixel).ToArray();
            if(h.Length==0 || h.Sum()==0) {currCalculate = false;return; }
            for (int i = 0; i < h.Length; i++)
            {
                url += $"{(i>0?",":"")}{(Colors.ToList().IndexOf(HorizontalColors[i].Color)+1)}x{h[i]}";
            }
            url += $"&y_mirror={(materialCheckbox2.Checked?"1":"0")}&y_str=";
            var v = VerticalColors?.Select(c => c.CountPixel).ToArray();
            if (v.Length == 0 || v.Sum()==0) { currCalculate = false; return;}
            for (int i = 0; i < v.Length; i++)
            {
                url += $"{(i>0?",":"")}{(Colors.ToList().IndexOf(VerticalColors[i].Color) + 1)}x{v[i]}";
            }
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            try
            {
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                bmp = new Bitmap(responseStream);
            }
            catch (Exception e)
            {
                bmp = null;
            }
            //Color[] hh = GetHor(),vv=GetVer();
            //if (hh?.Length == 0 || vv.Length == 0)
            //{
            //    var b=new Bitmap(1,1, PixelFormat.Format24bppRgb);
            //    using (var g = Graphics.FromImage(b))
            //        g.Clear(Color.White);
            //    pictureBox1.BackgroundImage = b; 
            //    currCalculate = false;
            //    return;
            //}
            //bmp = new Bitmap(hh.Length,vv.Length,PixelFormat.Format24bppRgb);
            //for (int y=0;y<bmp.Height;y++)
            //{
            //    for (int x = 0; x < bmp.Width; x++)
            //    {
            //        bmp.SetPixel(x, y, (y % 2 == 0 ? (x % 2 == 0) : (x % 2 != 0)) ? hh[x] : vv[y]);
            //    }
            //}
            pictureBox1.BackgroundImage = bmp;
            materialSlider1_onValueChanged(null, materialSlider1.Value);
            currCalculate = false;
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            if (newValue == 1) return;
            if (bmp == null) return;
            if (newValue < 1) newValue = 1;
            Bitmap bnew = new Bitmap(bmp.Width * newValue, bmp.Height * newValue, PixelFormat.Format24bppRgb);
            using (var g = Graphics.FromImage(bnew))
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        g.FillRectangle(new SolidBrush(bmp.GetPixel(x,y)),x*newValue,y*newValue,newValue,newValue);
                    }
                }
                //g.DrawImage(bmp, new Rectangle(0, 0, bnew.Width, bnew.Height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
            }
            pictureBox1.BackgroundImage = bnew;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ColorWidth c = new ColorWidth{Dock=DockStyle.Top};
            horCard.Controls.Add(c);
            c.BringToFront();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            ColorWidth c = new ColorWidth { Dock = DockStyle.Top };
            verCard.Controls.Add(c);
            c.BringToFront();
        }
        public void ReCalculate(object sender, EventArgs e) => Calculate();

        private void UpdateOldFiles()
        {
            if (Settings.Default.OldFiles == null)
            {
                Settings.Default.OldFiles = new StringCollection();
                Settings.Default.Save();
            }
            UpdateComboOldFile();
        }

        void UpdateComboOldFile()
        {
            materialComboBox2.Items.Clear();
            foreach (string s in Settings.Default.OldFiles)
                materialComboBox2.Items.Add(Path.GetFileName(s));
        }

        private void saveMaket(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()!= DialogResult.OK) return;
            List<string> file = new List<string>();
            file.Add(Colors.Reverse().Aggregate<Color, string>(null, (current, c) => current + ((current == null ? "" : "|") + ColorTranslator.ToHtml(c).Substring(1))));
            file.Add(materialComboBox1.SelectedItem.ToString());
            file.Add(materialCheckbox2.Checked ? "1" : "0");
            file.Add(HorizontalColors.Aggregate<ColorWidth, string>(null, (current, h) => current + ((current == null ? "" : "|") + Colors.ToList().IndexOf(h.Color) + "_" + h.CountPixel)));
            file.Add(materialCheckbox2.Checked ? "1" : "0");
            file.Add(VerticalColors.Aggregate<ColorWidth, string>(null, (current, h) => current + ((current == null ? "" : "|") + Colors.ToList().IndexOf(h.Color) + "_" + h.CountPixel)));
            File.WriteAllLines(saveFileDialog1.FileName,file,Encoding.UTF8);
            // удалить если файл уже есть
            for (var i = 0; i < Settings.Default.OldFiles.Count; i++)
                if (Settings.Default.OldFiles[i] == saveFileDialog1.FileName)
                    Settings.Default.OldFiles.RemoveAt(i);
            // добавить в начало
            Settings.Default.OldFiles.Insert(0,saveFileDialog1.FileName);
            // удалить файлы больше индекса 10
            if(Settings.Default.OldFiles.Count>10)
                Settings.Default.OldFiles.RemoveAt(Settings.Default.OldFiles.Count-1);
            Settings.Default.Save();
            // обновить список
            UpdateOldFiles();
        }

        private bool OsLoading = false;
        private void LoadUzor(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()!= DialogResult.OK) return;
            if(OsLoading) return;
            Load(openFileDialog1.FileName);
        }
        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string file in Settings.Default.OldFiles)
            {
                if (materialComboBox2.SelectedItem != null && file.EndsWith(materialComboBox2.SelectedItem.ToString()))
                {
                    Load(file);
                    return;
                }
            }
        }

        void Load(string openFileDialog1FileName)
        {
            var file = File.ReadAllLines(openFileDialog1FileName, Encoding.UTF8)
                .Where(s=>!string.IsNullOrWhiteSpace(s))
                .ToArray();
            OsLoading = true;
            if (file.Length != 6) {
                MessageBox.Show(@"Файл изменён и не доступен для загрузки");
                OsLoading = false;
                return; }

            try
            {
                colorCard.Controls.Clear();
                for (var i = 0; i < file[0].Split('|').Length; i++)
                {
                    string s = file[0].Split('|')[i];
                    ColorComboPicer c = new ColorComboPicer
                    {
                        Title = "Цвет №" + (i + 1),
                        Color = ColorTranslator.FromHtml($"#{s}"),
                        Dock = DockStyle.Top
                    };
                    colorCard.Controls.Add(c);
                    c.BringToFront();
                }

                materialComboBox1.SelectedItem = file[1].Trim();
                materialCheckbox1.Checked = int.Parse(file[2])==1;
                horCard.Controls.Clear();
                foreach (string s in file[3].Split('|'))
                {
                    string[] tmp = s.Split('_')
                        .Where(_s => !string.IsNullOrWhiteSpace(_s))
                        .ToArray();
                    if (int.TryParse(tmp[0], out int num) && int.TryParse(tmp[1], out int count))
                    {
                        ColorWidth c = new ColorWidth{Color=Colors[num],CountPixel=count,Dock = DockStyle.Top};
                        horCard.Controls.Add(c);
                        c.BringToFront();
                    }
                }
                materialCheckbox2.Checked = int.Parse(file[4]) == 1;
                verCard.Controls.Clear();
                foreach (string s in file[5].Split('|'))
                {
                    string[] tmp = s.Split('_')
                        .Where(_s => !string.IsNullOrWhiteSpace(_s))
                        .ToArray();
                    if (int.TryParse(tmp[0], out int num) && int.TryParse(tmp[1], out int count))
                    {
                        ColorWidth c = new ColorWidth { Color = Colors[num], CountPixel = count,Dock = DockStyle.Top };
                        verCard.Controls.Add(c);
                        c.BringToFront();
                    }
                }
                OsLoading = false;
                Calculate();
                for (var i = 0; i < Settings.Default.OldFiles.Count; i++)
                {
                    if (Settings.Default.OldFiles[i] == openFileDialog1FileName)
                    {
                        Settings.Default.OldFiles.RemoveAt(i);
                    }
                }
                Settings.Default.OldFiles.Insert(0,openFileDialog1FileName);
                Settings.Default.Save();
                UpdateComboOldFile();
            }
            catch (Exception e)
            {
                colorCard.Controls.Clear();
                horCard.Controls.Clear();
                verCard.Controls.Clear();
                MessageBox.Show(e.Message);
            }
        }

        private void PlaidMakerControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                materialComboBox1.SelectedIndex = 0;
                saveFileDialog1.InitialDirectory = Application.StartupPath;
                UpdateOldFiles();
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Файл результата изображения (.BMP)|*.bmp";
            f.InitialDirectory = Application.StartupPath;
            if (f.ShowDialog() != DialogResult.OK) return;
            bmp.Save(f.FileName, ImageFormat.Bmp);
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
