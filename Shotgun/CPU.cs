using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun
{
    public class Cpu
    {

        public int Ammo{ get; set; }
        public bool Shoot { get; set; }
        public bool Block { get; set; }



        public Cpu(int ammo)
        {
            Ammo = ammo;
     
        }
}
}