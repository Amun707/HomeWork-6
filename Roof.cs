using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //Класс крыша - интерфейс часть дома IPart
    public class Roof : IPart
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }

        public Roof(int H, int W, int L) { Height = H; Width = W; Lenght = L; }
    }
}
