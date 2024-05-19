using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    //класс дом (состав)
    public class House
    {
        Basement Basement { get; set; }
        Roof Roof { get; set; }
        List<Windows> Windows { get; set; }
        List<Wall> Walls { get; set; }
        List<Door> Doors { get; set; }
        public House() { 
        Basement = new Basement(1,1,1);
            Roof = new Roof(1,1,1);
            Walls = new List<Wall>()
            {
                new Wall(1,1,1),
                new Wall(1,1,1),
                new Wall(1,1,1),
                new Wall(1,1,1),
            };
            Windows = new List<Windows>()
            {
                new Windows(1,1,1),
                new Windows(1,1,1),
                new Windows(1,1,1),
                new Windows(1,1,1),
            };
            Doors = new List<Door>()
            {
                new Door(1,1,1),
            };
        }


    }
}
