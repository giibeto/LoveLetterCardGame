using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Handmaid : Card
    {
        private int total;
        Game G = new Game();
        public Handmaid()
        {
            Total = 2;
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
                Console.WriteLine("Handmaid (4)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player cannot be affected by any other player's card until the next turn.");
                Console.WriteLine("------------------------------------");
                total--;
        }
        public void playHandMaid()
        {
            Console.WriteLine("You are safe in next turn");
        }
        
    }
}
