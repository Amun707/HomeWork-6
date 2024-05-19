using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //класс бригада
    public class Team
    {
        TeamLeader TeamLeader {  get; set; }
        List<Worker> WorkerList { get; set; }
        public Team() { 
            TeamLeader = new TeamLeader("Abramovich");
            WorkerList = new List<Worker>() { 
            new Worker("Susanin "),
            new Worker("Mazay"),
            new Worker("Kvazimodo"),
            };
        }
    }
}
