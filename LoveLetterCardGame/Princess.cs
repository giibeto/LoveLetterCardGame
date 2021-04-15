using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Princess : Card
    {
        Game G = new Game();
        private int total;
        public Princess()
        {
            Total = 1;
        }
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public void functionality()
        {
           
                Console.WriteLine("Princess (8)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("If a player plays this card for any reason, they are eliminated from the round.");
                Console.WriteLine("------------------------------------");
                total--;
            
        }
    }
}
