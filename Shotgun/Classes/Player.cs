using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.NewFolder
{
    public class Player
    {
        public int PlayerShots { get; set; }


        public Player()
        {
            PlayerShots = 0;
        }

        public bool CanShoot()
        {
            return PlayerShots > 0;
        }

    }
}
