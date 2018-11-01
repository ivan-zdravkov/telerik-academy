using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AcademyPopcorn
{
    public class EngineMkII : Engine
    {
        public EngineMkII (IRenderer renderer, IUserInterface userInterface) : base(renderer, userInterface)
        {

        }

        public EngineMkII (IRenderer renderer, IUserInterface userInterface, int sleepTimeMicroSeconds) : base(renderer, userInterface, sleepTimeMicroSeconds)
        {
            
        }

        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).Shoot();
            }
        }
    }
}
