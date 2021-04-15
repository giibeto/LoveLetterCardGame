using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Countess : Card
    {
        Game G = new Game();
        private int total;
        public Countess()
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
            
                Console.WriteLine("Countess (7)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("If a player holds both this card and either the King or Prince card, this card must be played immediately.");
                Console.WriteLine("------------------------------------");
                total--;
            
            
        }
        
    }
}
