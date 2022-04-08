using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MakerPlaid.Ctrl.Maps
{
    public partial class HandweavingPro
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            SuspendLayout();
            e.Graphics.FillRectangle(new SolidBrush(BackColor),e.ClipRectangle);
            PaintHorizontalColorGrid(e);
            pVerticalColorGrid(e);
            pMiniMask(e);
            pHorizontalMask(e);
            pVerticalMask(e);
            pMap(e);
            ResumeLayout();
        }

        private void Draw(PaintEventArgs e, Rectangle r, Color back, Color borderColor)
        {
            e.Graphics.FillRectangle(new SolidBrush(back), r);
            e.Graphics.DrawRectangle(new Pen(borderColor), r);
        }

        // горизонтальные цвета
        private void PaintHorizontalColorGrid(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            int count = RoundWidth * CountBox;
            for (int i = 0; i < _hColor.Length; i++)
            {
                Draw(e,this[i,0],MyColorGrid.Items[_hColor[i]],BorderSilver);
            }
        }
            
        // вертикальные цвета
        private void pVerticalColorGrid(PaintEventArgs e)
        {
            int count = RoundHeight * CountBox;
            for (int i = 0; i < count; i++)
            {
                if (_vColor.Length > i && MyColorGrid.Items.Length > _vColor[i])
                    Draw(e, this[RoundWidth * CountBox+ RoundWidth+2, i+ RoundHeight+3], MyColorGrid.Items[_vColor[i]], BorderSilver);
            }
        }

        public Bitmap GetMap()
        {
            var m = _Map.GetSize();
            Bitmap b = new Bitmap(m.Width,m.Height, PixelFormat.Format24bppRgb);
            for (int y = 0; y< m.Height; y++)
            for (int x = 0; x < m.Width; x++)
            {
                b.SetPixel(x,y,MyColorGrid.Items[_Map[x,y]]);
            }
            return b;
        }

        //мини карта
        private void pMiniMask(PaintEventArgs e)
        {
                for (int y = 0; y < RoundHeight; y++)
                for (int x = 0; x < RoundWidth; x++)
                    Draw(e,this[RoundWidth* CountBox + 1+x,y+2],_miniMap[x,y]?Color.Black : BackColor, BorderSilver);
        }

        //
        private void pHorizontalMask(PaintEventArgs e)
        {
            for (int y = 0; y < RoundHeight; y++)
            for (int x = 0; x < RoundWidth*CountBox; x++)
                Draw(e, this[x, y + 2], _hMap[x,y] ? Color.Black : BackColor, BorderSilver);
        }

        //
        private void pVerticalMask(PaintEventArgs e)
        {
            for (int y = 0; y < RoundHeight* CountBox; y++)
            for (int x = 0; x < RoundWidth; x++) 
                if(y<_vMap.Length/ RoundWidth)
                    Draw(e, this[RoundWidth * CountBox + 1+x, y+RoundHeight+ 3], _vMap[x, y] ? Color.Black : BackColor, BorderSilver);
        }
        private void pMap(PaintEventArgs e)
        {
            for (int y = 0; y < RoundHeight * CountBox; y++)
            for (int x = 0; x < RoundWidth * CountBox; x++)
                Draw(e, this[x, RoundHeight+3+y], MyColorGrid.Items[_Map[x, y]], BorderSelect);
        }
    }
}
