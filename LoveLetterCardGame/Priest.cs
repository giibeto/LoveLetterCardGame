using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Priest : Card
    {
        private int total;
        Game G = new Game();
        public Priest()
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

                Console.WriteLine("Priest (2)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player is allowed to see another player's hand.");
                Console.WriteLine("------------------------------------");
                total--;
        }
        public void playPriest(int card3,int card1)
        {
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1)
            {
                Console.WriteLine("Player 1 have " + card1);
            }
            else if(selectPlayer==2)
            {
                Console.WriteLine("Player 2 have " + card3);
            }
        }
        public void playPriest3(int card5,int card3,int card1)
        {
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2" + G.P.Player2);
            Console.WriteLine("(3) Player 3" + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1)
            {
                Console.WriteLine("Player 1 have " + card1);
            }
            else if (selectPlayer == 2)
            {
                Console.WriteLine("Player 2 have " + card3);
            }
            else if (selectPlayer == 3)
            {
                Console.WriteLine("Player 3 have " + card5);
            }

        }
        public void playPriest4(int card7,int card5, int card3, int card1)
        {
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2" + G.P.Player2);
            Console.WriteLine("(3) Player 3" + G.P.Player3);
            Console.WriteLine("(4) Player 4" + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1)
            {
                Console.WriteLine("Player 1 have " + card1);
            }
            else if (selectPlayer == 2)
            {
                Console.WriteLine("Player 2 have " + card3);
            }
            else if (selectPlayer == 3)
            {
                Console.WriteLine("Player 3 have " + card5);
            }
            else if(selectPlayer==4)
            {
                Console.WriteLine("Player 4 have " + card7);
            }

        }
    }
}
