using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {
        private bool shot = false;
        public ShootingRacket (MatrixCoords topLeft, int width) : base (topLeft, width)
        {

        }

        public void Shoot()
        {
            this.shot = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> projectiles = new List<GameObject>();
            if (this.shot)
            {
                projectiles.Add(new Bullet(this.topLeft));
                MatrixCoords sedondBullet = new MatrixCoords(topLeft.Row, topLeft.Col + this.Width - 1);
                projectiles.Add(new Bullet(sedondBullet));
                this.shot = false;
                projectiles.Add(new Racket(this.topLeft, this.Width));
            }
            return projectiles;
        }
    }
}
