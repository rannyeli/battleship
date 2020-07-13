using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    class Find
    {
        private int shura;
        private int amuda;
        public Find()
        {
            this.shura = 0;
            this.amuda = 0;
        }
        public void SetShura(int i)
        {
            this.shura = i;
        }
        public int GetShura()
        {
            return this.shura;
        }

        public void SetAmuda(int j)
        {
            this.amuda = j;
        }
        public int GetAmuda()
        {
            return this.amuda;
        }
    }
}
