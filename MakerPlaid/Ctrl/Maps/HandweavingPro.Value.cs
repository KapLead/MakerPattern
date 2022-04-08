using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using MakerPlaid.Annotations;
using System.Runtime.CompilerServices;

namespace MakerPlaid.Ctrl.Maps
{
    public partial class HandweavingPro : INotifyPropertyChanged
    {
        /// <summary> Цвет обрдюра не выделенного </summary>
        public Color BorderSilver { get; set; } = Color.Silver;

        /// <summary> Цвет активного бордюра </summary>
        public Color BorderSelect { get; set; } = Color.Black;

        /// <summary> Масштаб сетки </summary>
        public int Scale 
        {
            get => _scale;
            set
            {
                if (value == _scale) return;
                _scale = value;
                OnPropertyChanged();
            }
        } private int _scale = 4;

        /// <summary> Кол-во копий боксов, для визуального наглядного </summary>
        public int CountBox 
        {
            get => _countBox;
            set
            {
                if (value == _countBox) return;
                _countBox = value;
                OnPropertyChanged();
            }
        } private int _countBox = 3;

        /// <summary> Величина матрицы по диагонали </summary>
        public int RoundWidth {
            get => _roundWidth;
            set
            {
                if (value == _roundWidth) return;
                _roundWidth = value;
                OnPropertyChanged();
            }
        } private int _roundWidth = 8;

        /// <summary> Величина матрицы по вертикали </summary>
        public int RoundHeight {
            get => _roundHeight;
            set
            {
                if (value == _roundHeight) return;
                _roundHeight = value;
                OnPropertyChanged();
            }
        } private int _roundHeight = 8;

        /// <summary> Размер одного квадратика (индекс) </summary>
        public int CurBoxScale => 2 + Scale * 2;

        /// <summary> Цветовая сетка </summary>
        //public BindingList<Color> ColorGrid = new BindingList<Color>(new []{Color.White});

        /// <summary> Кол-во квадратов по горизонтали </summary>
        public int DX => CountBox * RoundWidth + RoundWidth + 3;

        /// <summary> Кол-во квадратов по вертикали </summary>
        public int DY => CountBox * RoundHeight + RoundHeight + 3;

        /// <summary> Координаты указанного квадратика </summary>
        public Rectangle this[int x, int y] => new Rectangle(x * CurBoxScale, y * CurBoxScale, CurBoxScale, CurBoxScale);

        public bool MiniMapCheck {
            get => _miniMapCheck;
            set
            {
                if (value == _miniMapCheck) return;
                _miniMapCheck = value;
                OnPropertyChanged();
            }
        } private bool _miniMapCheck = false;

        private int[] _hColor = new int[24];
        private int[] _vColor = new int[24];
        private bool[,] _hMap = new bool[24, 9];
        private bool[,] _vMap = new bool[9, 24];
        private bool[,] _miniMap = new bool[24, 24];
        private int[,] _Map = new int[25, 25];


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool[,] MiniMap
       {
           get => _miniMap;
           set => _miniMap = value;
       }


       public void Calculate()
        {
            if (_Map.Length != RoundWidth * CountBox * RoundHeight * CountBox)
            {
                var tmp = _hColor;
                _hColor = new int[RoundWidth * CountBox];
                if (tmp.Length != _hColor.Length)
                {
                    for (int i = 0,k=0; i < _hColor.Length; i++,k++)
                    {
                        if (k >= tmp.Length) k = 0;
                        _hColor[i] = tmp[k];
                    }
                }
                else _hColor = tmp;
                
                tmp = _vColor;
                _vColor = new int[RoundHeight * CountBox];
                if (tmp.Length != _vColor.Length)
                {
                    for (int i = 0, k = 0; i < _vColor.Length; i++, k++)
                    {
                        if (k >= tmp.Length) k = 0;
                        _vColor[i] = tmp[k];
                    }
                }
                else _vColor = tmp;

                var tmap = _hMap;
                _hMap = new bool[RoundWidth*CountBox,RoundHeight];
                var r = tmap.GetSize();
                var t = _hMap.GetSize();
                if (tmap.Length == _hMap.Length) _hMap = tmap;
                else
                {
                    for (int y = 0,k=0; y < t.Height; y++,k++)
                    {
                        if (k >= r.Height) k = 0;
                        for (int x = 0,g=0; x < t.Width; x++,g++)
                        {
                            if (g >= r.Width) g = 0;
                            _hMap[x, y] = tmap[g, k];
                        }
                    }
                }

                tmap = _vMap;
                _vMap = new bool[RoundWidth,RoundHeight*CountBox];
                r = tmap.GetSize();
                t = _vMap.GetSize();
                if (tmap.Length == _vMap.Length) _vMap = tmap;
                else
                {
                    for (int y = 0, k = 0; y < t.Height; y++, k++)
                    {
                        if (k >= r.Height) k = 0;
                        for (int x = 0, g = 0; x < t.Width; x++, g++)
                        {
                            if (g >= r.Width) g = 0;
                            _vMap[x, y] = tmap[g, k];
                        }
                    }
                }

                tmap = _miniMap;
                _miniMap = new bool[RoundWidth, RoundHeight];
                if (tmap.Length == _miniMap.Length) _miniMap = tmap;
                else
                {
                    r = tmap.GetSize();
                    t = _miniMap.GetSize();
                    if (tmap.Length == _miniMap.Length) _vMap = tmap;
                    else
                    {
                        for (int y = 0, k = 0; y < t.Height; y++, k++)
                        {
                            if (k >= r.Height) k = 0;
                            for (int x = 0, g = 0; x < t.Width; x++, g++)
                            {
                                if (g >= r.Width) g = 0;
                                _miniMap[x, y] = tmap[g, k];
                            }
                        }
                    }
                }

                _Map = new int[RoundWidth * CountBox, RoundHeight * CountBox];
            }
            Size = new Size(DX*CurBoxScale+1, DY*CurBoxScale+1);
            DrawMap();
            Invalidate();
        }

        #region event

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator] 
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Calculate();
        }

        #endregion
    }
}
