using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //класс Окна : интерфейс IPart часть дома
    public class Windows : IPart
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
        public Windows(int H, int W, int L) { Height = H; Width = W; Lenght = L; }
    }
}
