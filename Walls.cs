using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //класс стены - интерфейс IPart - часть дома
    public class Wall : IPart
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
        public Wall (int H, int W, int L){ Height = H; Width = W; Lenght = L; }
    }
}
