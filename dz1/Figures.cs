using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1
{
    public class Figures
    {
        public string Name { get; set; }
        public int IndexStartCap = 0;
        public int IndexEndCap = 0;
        public int dashStyle = 0;
        public int IndexLinerGradient = 0;
        public int IndexHachstyle = 0;
        public Color Colf = Color.Black;
        public Color FirstColor = Color.Transparent;
        public Color SecondColor = Color.Transparent;
        public Point PointText { get; set; }
        public Point Pointf { get; set; }
        public Point Point1f { get; set; }
        public string Pathf { get; set; }
        public int WidthPenf { get; set; }
        public int IndexFigure = 0;
        public int IndexBrush = 0;
        public int IndexOrien=-1;
        public int Indextex=-1;
        public int IndexText = 0;
        public string TextImage = string.Empty;
        public Point[] pn;
        public Color ColorText;
        public Figures() { }
        public override string ToString()
        {
            return $"({Name})";
        }

        
    }
}
