using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MakerPlaid.Ctrl.Maps
{
    public partial class HandweavingPro : UserControl
    {
        public HandweavingPro()
        {
            InitializeComponent();
            Calculate();
        }

        private void HandweavingPro_VisibleChanged(object sender, System.EventArgs e)
        {
            Calculate();
        }

        private Rectangle oldRect;
        private void HandweavingPro_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MiniMapCheck) return;

            int oldx = oldRect.X / CurBoxScale, oldy = oldRect.Y / CurBoxScale;
            int x = e.X / CurBoxScale, y = e.Y / CurBoxScale;
            var r = this[x, y];
            Graphics g = CreateGraphics();
            // hor color grid
            if (oldy == 0 && oldx < CountBox * RoundWidth)
                Draw(new PaintEventArgs(g, oldRect), oldRect, MyColorGrid.Items[_hColor[oldx]], BorderSilver);
            if (y == 0 && x < CountBox * RoundWidth)
            {
                Draw(new PaintEventArgs(g, r), r, MyColorGrid.Items[_hColor[x]], BorderSelect);
                oldRect = r;
                return;
            }

            // ver color grin
            if (oldx == DX - 1 && oldy > RoundHeight + 2)
                Draw(new PaintEventArgs(g, oldRect), oldRect, MyColorGrid.Items[_vColor[oldy - RoundHeight - 3]], BorderSilver);
            // HMAP
            if (oldy > 1 && oldy < RoundHeight + 2 && oldx < CountBox * RoundWidth)
                Draw(new PaintEventArgs(g, oldRect), oldRect, _hMap[oldx, oldy - 2] ? Color.Black : BackColor, BorderSilver);
            // MINI MAP
            if (oldx > CountBox * RoundWidth && oldx < (CountBox + 1) * RoundWidth + 1 && oldy > 1 && oldy < RoundHeight + 2)
                Draw(new PaintEventArgs(g, oldRect), oldRect, _miniMap[oldx - CountBox * RoundWidth - 1, oldy - 2] ? Color.Black : BackColor, BorderSilver);
            // VMAP
            if (oldx > CountBox * RoundWidth && oldx < (CountBox + 1) * RoundWidth + 1 && oldy > RoundHeight + 2 && oldy < DY)
                Draw(new PaintEventArgs(g, oldRect), oldRect, _vMap[oldx - CountBox * RoundWidth - 1, oldy - RoundHeight - 3] ? Color.Black : BackColor, BorderSilver);

            if (x == DX - 1 && y > RoundHeight + 2)
                Draw(new PaintEventArgs(g, oldRect), r, MyColorGrid.Items[_vColor[y - RoundHeight - 3]], BorderSelect);
            else
            // HMAP
            if (y > 1 && y < RoundHeight + 2 && x < CountBox * RoundWidth)
                Draw(new PaintEventArgs(g, r), r, _hMap[x, y - 2] ? Color.Black : BackColor, BorderSelect);
            else
            // MINI MAP
            if (x > CountBox * RoundWidth && x < (CountBox + 1) * RoundWidth + 1 && y > 1 && y < RoundHeight + 2)
                Draw(new PaintEventArgs(g, r), r, _miniMap[x - CountBox * RoundWidth - 1, y - 2] ? Color.Black : BackColor, BorderSelect);
            else
            // VMAP
            if (x > CountBox * RoundWidth && x < (CountBox + 1) * RoundWidth + 1 && y > RoundHeight + 2 && y < DY)
                Draw(new PaintEventArgs(g, r), r, _vMap[x - CountBox * RoundWidth - 1, y - RoundHeight - 3] ? Color.Black : BackColor, BorderSelect);

            oldRect = r;
        }

        private void HandweavingPro_MouseDown(object sender, MouseEventArgs e)
        {
            //}
            Graphics g = CreateGraphics();
            int x = e.X / CurBoxScale, y = e.Y / CurBoxScale;
            var r = this[x, y];
            if (y == 0 && x < CountBox * RoundWidth)
            {
                _hColor[x] = MyColorGrid.SelectedIndex;
            }
            else
            if (x == DX-1 && y > 2 + RoundHeight)
            {
                _vColor[y - 3 - RoundHeight] = MyColorGrid.SelectedIndex;
            }
            else if (y > 1 && y < RoundHeight + 2 && x < CountBox * RoundWidth)
                // hor mask
            {
                Draw(new PaintEventArgs(g, r), r, (_hMap[x, y - 2] = !_hMap[x, y - 2]) ? Color.Black : BackColor, BorderSelect);
                for (int i = 0; i < RoundHeight; i++)
                {
                    if (i != y - 2)
                    {
                        var _r = this[x, 2 + i];
                        Draw(new PaintEventArgs(g, _r), _r, BackColor, BorderSilver);
                        _hMap[x, i] = false;
                    }
                }
            }
            else if ( x > CountBox * RoundWidth && x < (CountBox + 1) * RoundWidth + 1 && y > 1 && y < RoundHeight + 2)
                Draw(new PaintEventArgs(g, r), r, (_miniMap[x - CountBox * RoundWidth - 1, y - 2] = true) ? Color.Black : BackColor, BorderSelect);
            else if (x > CountBox * RoundWidth && x < (CountBox + 1) * RoundWidth + 1 && y > RoundHeight + 2 && y < DY)
            {
                Draw(new PaintEventArgs(g, r), r, (_vMap[x - CountBox * RoundWidth - 1, y - RoundHeight - 3] = true) ? Color.Black : BackColor, BorderSelect);
                for (int i = 0; i < RoundWidth; i++)
                {
                    if (x - CountBox * RoundWidth - 1 != i)
                    {
                        var _r = this[x - CountBox * RoundWidth - 1 + i, y - RoundHeight - 3];
                        Draw(new PaintEventArgs(g, _r), _r, BackColor, BorderSilver);
                        _vMap[i, y - RoundHeight - 3] = false;
                    }
                }
            }
            else if (x == DX - 2 && y == 1)
            {
                MiniMapCheck = !MiniMapCheck;
            }
            Calculate();
        }

        public void SaveAs(string file)
        {
            List<string> f = new List<string>();
            f.Add($"{Scale}|{RoundWidth}|{RoundHeight}|{CountBox}|{(MiniMapCheck ? 1 : 0)}"); //0
            f.Add(MyColorGrid.Items.Aggregate<Color, string>(null, (current, c) => current + ((current == null ? "" : "|") + ColorTranslator.ToHtml(c))));
            f.Add(_hColor.Aggregate<int, string>(null, (current, c) => current + (current == null ? "" : "|") + c)); //2
            f.Add(_vColor.Aggregate<int, string>(null, (current, c) => current + (current == null ? "" : "|") + c)); //3
            string tmp = null; //4
            for (int y = 0; y < RoundHeight; y++)
                for (int x = 0; x < _hColor.Length; x++)
                    tmp += (tmp == null ? "" : "|") + (_hMap[x, y] ? "1" : "0");
            f.Add(tmp);
            tmp = null; //5
            for (int y = 0; y < _vColor.Length; y++)
                for (int x = 0; x < RoundWidth; x++)
                    tmp += (tmp == null ? "" : "|") + (_vMap[x, y] ? "1" : "0");
            f.Add(tmp);
            tmp = null; //6
            for (int y = 0; y < RoundHeight; y++)
                for (int x = 0; x < RoundWidth; x++)
                    tmp += (tmp == null ? "" : "|") + (_miniMap[x, y] ? "1" : "0");
            f.Add(tmp);
            tmp = null; //7
            for (int y = 0; y < _vColor.Length; y++)
                for (int x = 0; x < _hColor.Length; x++)
                    tmp += (tmp == null ? "" : "|") + _Map[x, y];
            f.Add(tmp);
            File.WriteAllLines(file, f, Encoding.UTF8);
        }

        private bool IsLoading = false;
        public void Load(string file)
        {
            if (IsLoading || !File.Exists(file)) return;
            IsLoading = true;
            try
            {
                List<string> f = File.ReadAllLines(file, Encoding.UTF8).Where(s => !string.IsNullOrEmpty(s)).ToList();

                var vals1 = f[0].Split('|').Select(int.Parse).ToArray();
                if (vals1.Length == 5) { Scale = vals1[0]; RoundWidth = vals1[1]; RoundHeight = vals1[2]; CountBox = vals1[3]; MiniMapCheck = vals1[4] == 1; }

                var colors = f[1].Split('|').Where(s => !string.IsNullOrEmpty(s)).Select(s => s[0] == '#' ? ColorTranslator.FromHtml($"{s}") : Color.FromName(s)).ToArray();
                if (colors.Length == MyColorGrid.Items.Length)
                    for (int i = 0; i < colors.Length; i++) MyColorGrid.Items[i] = colors[i];

                _hColor = f[2].Split('|').Select(int.Parse).ToArray();

                _vColor = f[3].Split('|').Select(int.Parse).ToArray();


                var tmp = f[4].Split('|').Select(int.Parse).ToArray();
                _hMap = new bool[_hColor.Length, RoundHeight];
                for (int y = 0; y < RoundHeight; y++)
                    for (int x = 0; x < _hColor.Length; x++)
                        _hMap[x, y] = tmp[y * _hColor.Length + x] == 1;

                tmp = f[5].Split('|').Select(int.Parse).ToArray();
                _vMap = new bool[RoundWidth, _vColor.Length];
                for (int y = 0; y < _vColor.Length; y++)
                    for (int x = 0; x < RoundWidth; x++)
                        _vMap[x, y] = tmp[x + RoundWidth * y] == 1;

                tmp = f[6].Split('|').Select(int.Parse).ToArray();
                _miniMap = new bool[RoundWidth, RoundHeight];
                for (int y = 0; y < RoundHeight; y++)
                    for (int x = 0; x < RoundWidth; x++)
                        _miniMap[x, y] = tmp[y * RoundWidth + x] == 1;

                tmp = f[7].Split('|').Select(int.Parse).ToArray();
                _Map = new int[_hColor.Length, _vColor.Length];
                for (int y = 0; y < _vColor.Length; y++)
                    for (int x = 0; x < _hColor.Length; x++)
                        _Map[x, y] = tmp[y * _hColor.Length + x];

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Invalidate();
            IsLoading = false;
        }

        private void DrawMap()
        {
            // цикл по всем блокам результирующей катры
            for (int y = 0; y < _vColor.Length; y += RoundHeight)
                for (int x = 0; x < _hColor.Length; x += RoundWidth)
                {
                    // цикл по блоку
                    for (int dx = 0; dx < RoundWidth; dx++)
                    {
                        var col = _hMap.GetColumn(x+dx);
                        var any = col.Contains(true);
                        int index = col.ToList().IndexOf(true);
                        var column = index<0?new bool[col.Length]:_miniMap.GetRow(index);
                        bool[] vCol= new bool[RoundHeight];
                        for (int i = 0; i < column.Length; i++)
                        {
                            if (column[i])
                            {
                                for (int j = 0; j < RoundHeight; j++)
                                {
                                    if(_vMap[i, y + j])
                                        vCol[j] = _vMap[i, y + j];
                                }
                            }
                        }
                        for (int i = 0; i < vCol.Length; i++)
                        { 
                            _Map[x + dx, y + i] = vCol[i] ? _vColor[y + i] : _hColor[x + dx];
                        }
                    }
                }
        }

        private bool hAny(int x)
        {
            for (int i = 0; i < RoundHeight; i++)
            {
                if (_hMap[x, i]) return true;
            }
            return false;
        }
    }

    public static class ExArray
    {
        public static bool[] GetRow(this bool[,] arr, int rowIndex)
        {
            var size = arr.GetSize();
            bool[] ret = new bool[size.Width];
            for (int i = 0; i < size.Width; i++)
                ret[i] = arr[i, rowIndex];
            return ret;
        }

        public static bool[] GetColumn(this bool[,] arr, int columnIndex)
        {
            var size = arr.GetSize();
            bool[] ret = new bool[size.Height];
            for (int i = 0; i < size.Height; i++)
                ret[i] = arr[columnIndex, i];
            return ret;
        }

        public static Size GetSize(this Array a)
        {
            int w = a.GetLength(0);
            return new Size(w, a.Length / w);
        }
    }
}
