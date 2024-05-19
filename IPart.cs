using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //Интерфейс IPart - часть дома
    public interface IPart
    {
       public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
    }
}
