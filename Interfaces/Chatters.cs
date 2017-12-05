using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Chatter
    {
        private static Chatter instance;

        private Chatter() { }


        public static Chatter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Chatter();
                }
                return instance;
            }
        }


    }
}
