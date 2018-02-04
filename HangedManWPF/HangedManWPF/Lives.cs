using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangedManWPF
{

    class Lives
    {
        private int lives;
        private int maxLifeCount;

        public Lives(int maxLifeCount = 6)
        {
            this.maxLifeCount = maxLifeCount;
            ResetLives();
        }

        public void LoseLive()
        {
            lives -= 1;
        }

        public void ResetLives()
        {
            lives = maxLifeCount;
        }

        public bool IsAlive()
        {
            if (lives <= 0)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return lives.ToString();
        }
    }
}
