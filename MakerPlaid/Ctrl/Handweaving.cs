using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MakerPlaid.Ctrl
{
    public partial class Handweaving : UserControl
    {
        public Color BoxBorder {
            get => _boxBorder;
            set
            {
                _boxBorder = value;
                border = new Pen(_boxBorder);
            }
        } private Color _boxBorder = Color.DarkGray;
        private Pen border;
        public Color MapBorder {
            get => _boxBorder;
            set
            {
                _mapBorder = value;
                mapborder = new Pen(_mapBorder);
            }
        } private Color _mapBorder = Color.Black;
        private Pen mapborder;

        /// <summary> Кол-во групп квадратов </summary>
        public int CountBox 
        {
            get => _countBox;
            set
            {
                if(_countBox == value || value<2 || value>4) return;
                _countBox = value;
                Calculate();
            }
        }
        /// <summary> Размер квадрата куба (колв-о кубиков в грани) </summary>
        public int CubeLenght {
            get => _cubeLenght;
            set
            {
                if(_cubeLenght == value) return;
                _cubeLenght = value;
                Calculate();
            }
        }       
        /// <summary> Размер одного квадратика (индекс) </summary>
        public int CurBoxScale { get; private set; } = 3;

        #region SCALE
        /// <summary> Кол-во групп квадратов </summary>
        private int _countBox = 4;
        /// <summary> Размер квадрата куба (колв-о кубиков в грани) </summary>
         private int _cubeLenght = 8;
        /// <summary> Увеличение </summary>
        public new int Scale {
            get => _scale;
            set
            {
                if(_scale == value) return;
                _scale = NormalizeScale(value);
                Calculate();
            }
        }  private int _scale = 1;
        private int[] scaleLine = new[] {4, 6, 8, 10, 12, 14, 16, 18, 20, 22,24};
        private int NormalizeScale(int value)
        {
            if (value < 1) value = 1;
            if (value > 10) value = 10;
            CurBoxScale = scaleLine[value - 1];
            return value;
        }
        #endregion

        
        Color[] HColor = new Color[0];
        Color[] VColor = new Color[0];
        bool[,] mask = new bool[0, 0];
        bool[,] maskHor = new bool[0, 0];
        bool[,] maskVer = new bool[0, 0];
        Color[,] map = new Color[0,0];


        public Handweaving()
        {
            BorderStyle = BorderStyle.FixedSingle;
            border = new Pen(_boxBorder);
            mapborder = new Pen(_mapBorder);
            InitializeComponent();
            Calculate();
            RandomMask();
            for (int i = 0; i < HColor.Length; i++)
                VColor[i] = HColor[i] = Color.White;
        }

        public void RandomMask()
        {
            var rnd = new Random();
            for (int y = 0; y < _cubeLenght; y++)
                for (int x = 0; x < _cubeLenght; x++)
                    mask[x, y] = rnd.Next(0, 3) == 2;
        }

        private void Calculate()
        {
            int w = CountBox * CubeLenght;
            HColor = new Color[w];
            VColor = new Color[w];
            mask = new bool[CubeLenght, CubeLenght];
            maskHor = new bool[CubeLenght, w];
            maskVer = new bool[w, CubeLenght];
            map = new Color[w,w];
            Size = new Size(CurBoxScale * RectCount, CurBoxScale * RectCount);
            
            Invalidate();
      }

        #region Отрисовка

        public int RectCount { get=> (_countBox+1)*_cubeLenght+4; }

        public Rectangle this[int x,int y]=>new Rectangle(x* CurBoxScale, y* CurBoxScale, CurBoxScale, CurBoxScale);
        private void Draw(PaintEventArgs e, Rectangle r, Color back, Color borderColor)
        {
            e.Graphics.FillRectangle(new SolidBrush(back),r);
            e.Graphics.DrawRectangle(new Pen(borderColor),r);
        }
        /// <summary> Отрисовка горизонтальной линии цветов </summary>
        private void DrawHorColorLine(PaintEventArgs e)
        {
            for (var i = 0; i < HColor.Length; i++)
                Draw(e,this[i,0],HColor[i],_boxBorder);
        }
        /// <summary> Отрисовка вертикальной линии цветов </summary>
        private void DrawVerColorLine(PaintEventArgs e)
        {
            for (var i = 0; i < VColor.Length; i++)
            {
                Draw(e, this[RectCount-1, _cubeLenght + 4 + i], VColor[i], _boxBorder);
            }
        }
        /// <summary> Отрисовка маски </summary>
        private void DrawMask(PaintEventArgs e)
        {
            for (int y = 0; y < CubeLenght; y++)
            for (int x =0; x < CubeLenght; x++)
                Draw(e, this[RectCount - _cubeLenght-3+x, 3 + y], mask[x, y]?Color.Black:BackColor, _boxBorder);
        }

        /// <summary> Отрисовка горизонтальной маски </summary>
        private void DrawHorMask(PaintEventArgs e)
        {
            for (int y = 0; y < CubeLenght; y++)
            for (int x = 0; x < CountBox * CubeLenght; x++)
            {
                if (y == 0 && x % 4 == 0)
                {
                    var r = this[x, y + 1];
                    e.Graphics.DrawLine(Pens.IndianRed,r.X, r.Y,r.X, r.Y +r.Height*2);
                    e.Graphics.DrawString((HColor.Length-x).ToString(), new Font("Arial", scaleLine[Scale-1]),Brushes.IndianRed, r.X, r.Y);
                }
                Draw(e,this[x,y+3], maskHor[y, x]?Color.Black:BackColor,BoxBorder);
            }
        }

        /// <summary> Отрисовка вертикальной маски </summary>
        private void DrawVerMask(PaintEventArgs e)
        {
            for (int y=0; y<CountBox*CubeLenght; y++)
            for (int x = 0; x < CubeLenght; x++)
            {
                if (x==0 && y%4==0)
                {
                    var r = this[RectCount-3,_cubeLenght + 4 + y];
                    e.Graphics.DrawLine(Pens.IndianRed, r.X, r.Y, r.X+ r.Width * 2, r.Y );
                    e.Graphics.DrawString((HColor.Length - y).ToString(), new Font("Arial", scaleLine[Scale - 1]), Brushes.IndianRed, r.X, r.Y);
                }
                Draw(e,this[RectCount-CubeLenght-3+x, _cubeLenght + 4 +  y],maskVer[y, x] ? Color.Black : BackColor, BoxBorder);
            }
        }

        private void DrawMap(PaintEventArgs e)
        {
            for (int y = 0; y < CountBox * CubeLenght; y++)
            for (int x = 0; x < CountBox * CubeLenght; x++)
                Draw(e, this[x, y+ CubeLenght + 4], map[x,y], BoxBorder);
        }

        private void Handweaving_Paint(object sender, PaintEventArgs e)
        {
            SuspendLayout();
            e.Graphics.Clear(BackColor);

            DrawHorColorLine(e); DrawVerColorLine(e);
            DrawMask(e);
            DrawHorMask(e); DrawVerMask(e);
            DrawMap(e);

            ResumeLayout();
        }

        #endregion

        #region SetParams

        public void DefaultHorMask()
        {
            int w = CountBox * CubeLenght;
            for (int i = 0; i < CubeLenght; i++)
                for (int x = 0; x < CountBox; x++)
                {
                    
                }
        }

        #endregion
    }
}
