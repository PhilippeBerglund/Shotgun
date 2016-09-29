using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun
{


    public class CpuActions
    {
       

        public Cpu CpuRandom(Cpu cpu)
        {

            Random random = new Random();

            var randomResult = random.Next(1, 4);

            switch (randomResult)
            {
                case 1: //Load

                    if (cpu.Ammo < 3)
                    {
                        cpu.Ammo++;
                    
                    }
                    break;

                case 2: // Shoot
                    if (cpu.Ammo != 0)
                    {
                        cpu.Ammo--;
                        cpu.Shoot = true;
                    }
                    else goto case 1;

                        break;

                case 3: // Block
                    if (cpu.Ammo != 0)
                    {
                        cpu.Block = true;
                    }
                    else goto case 1;
                    break;

                case 4: // Shotgun
                    if (cpu.Ammo == 3 )      // nytt !!!!!!!!!!!!!!!!
                    {

                    }
                   
                    break;
            }


            return cpu;





        }

    }
}

// load = 1
// Shoot = 2
// Block = 3
// Shotgun 4
