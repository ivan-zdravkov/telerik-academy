using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        int lifetime;

        public TrailObject (MatrixCoords topLeft, char[,] body, int lifetime) : base(topLeft, body)
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {
            if (this.lifetime > 1)
            {
                this.lifetime--;
            }
            else
            {
                this.IsDestroyed = true;
            }
        }
    }
}
