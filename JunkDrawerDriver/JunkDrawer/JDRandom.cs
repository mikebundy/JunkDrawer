using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawer
{
    public class JDRandom
    {
        private Random _random;

        public JDRandom()
        {
            _random = new Random();
        }

        public int GetInteger()
        {
            return _random.Next();
        }

        public int GetInteger(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
