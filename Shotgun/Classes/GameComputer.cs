using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.NewFolder
{


    public class GameComputer
    {
        public int ComputerShots { get; set; }
        private Random random = new Random();

        public GameComputer()
        {
            ComputerShots = 0;
        }

        public string ComputerChoise()
        {
            if (ComputerShots >= 3)
            {
                string[] choices = { "Shotgun", "Skjuta", "Ladda", "Blocka" };
                return choices[random.Next(choices.Length)];

            }

            if (ComputerShots == 0)
            {
                return "Ladda";
            }

            string[] actions = { "Skjuta", "Ladda", "Blocka" };
            return actions[random.Next(actions.Length)];



        }

        public bool CanShoot()
        {
            return ComputerShots > 0;
        }

    }
}
