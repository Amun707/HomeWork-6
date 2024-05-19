using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //класс бригадир - интерфейс рабочий
    public class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public TeamLeader(string sum) {  Name = sum; }
    }
}
