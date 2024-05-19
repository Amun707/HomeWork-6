using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //Класс строитель, наследует базовый интерфейс (IWorker), рабочий
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public Worker(string sum) {  Name = sum; }
    }
}
