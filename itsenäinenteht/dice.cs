using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsenäinenteht
{
    class dice
    {

        public int Luku { get; set; }

        private static Random rng = new Random();

        public dice ()
        {
            roll();
        }

       
        
        
        public void roll()
        {
            Luku = rng.Next(1,7);
           
        }


    }
}
