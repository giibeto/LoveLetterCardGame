using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Prince : Card
    {
        Game G = new Game();
        private int total;
        public Prince()
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
            
                Console.WriteLine("Prince (5)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player can choose any player (including themselves) to discard their hand and draw a new one. If the discarded card is the Princess, the discarding player is eliminated.");
                Console.WriteLine("------------------------------------");
                total--;
            
        }
        public int playPrince()
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if(selectPlayer==1)
            {
                if(G.card1==8)
                {
                    flag = 2;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if(selectPlayer==2)
            {
                if (G.card3 == 8)
                {
                    flag = 1;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            return flag;
        }
        public int playPrince3(int players)
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());

            if (selectPlayer == 1 && players == 1)
            {
                if (G.card1 == 8)
                {
                    flag = 4;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            if (selectPlayer == 1 && players==2)
            {
                if (G.card1 == 8)
                {
                    flag = 3;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if (selectPlayer == 1 && players == 3)
            {
                if (G.card1 == 8)
                {
                    flag = 5;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if (selectPlayer == 2 && players==1)
            {
                if (G.card3 == 8)
                {
                    flag = 1;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 2 && players == 2)
            {
                if (G.card3 == 8)
                {
                    flag = 1;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 2 && players == 3)
            {
                if (G.card3 == 8)
                {
                    flag = 6;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 3 && players == 1)
            {
                if (G.card5 == 8)
                {
                    flag = 2;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 3 && players == 2)
            {
                if (G.card5 == 8)
                {
                    flag = 4;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 3 && players == 3)
            {
                if (G.card5 == 8)
                {
                    flag = 4;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            return flag;
        }

        public int playPrince4(int players)
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            Console.WriteLine("(4) Player 4 " + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players == 1)
            {
                if (G.card1 == 8)
                {
                    flag = 4;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            if (selectPlayer == 1 && players == 2)
            {
                if (G.card1 == 8)
                {
                    flag = 4;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if (selectPlayer == 1 && players == 3)
            {
                if (G.card1 == 8)
                {
                    flag = 7;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if (selectPlayer == 1 && players == 4)
            {
                if (G.card1 == 8)
                {
                    flag = 10;
                }
                G.Card1 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 1");
            }
            else if (selectPlayer == 2 && players == 1)
            {
                if (G.card3 == 8)
                {
                    flag = 1;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 2 && players == 2)
            {
                if (G.card3 == 8)
                {
                    flag = 1;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 2 && players == 3)
            {
                if (G.card3 == 8)
                {
                    flag = 8;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 2 && players == 4)
            {
                if (G.card3 == 8)
                {
                    flag = 11;
                }
                G.Card3 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 2");
            }
            else if (selectPlayer == 3 && players == 1)
            {
                if (G.card5 == 8)
                {
                    flag = 2;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 3 && players == 2)
            {
                if (G.card5 == 8)
                {
                    flag = 5;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 3 && players == 3)
            {
                if (G.card5 == 8)
                {
                    flag = 5;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 3 && players == 4)
            {
                if (G.card5 == 8)
                {
                    flag = 12;
                }
                G.Card5 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 3");
            }
            else if (selectPlayer == 4 && players == 1)
            {
                if (G.card7 == 8)
                {
                    flag = 3;
                }
                G.Card7 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 4");
            }
            else if (selectPlayer == 4 && players == 2)
            {
                if (G.card7 == 8)
                {
                    flag = 6;
                }
                G.Card7 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 4");
            }
            else if (selectPlayer == 4 && players == 3)
            {
                if (G.card7 == 8)
                {
                    flag = 9;
                }
                G.Card7 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 4");
            }
            else if (selectPlayer == 4 && players == 4)
            {
                if (G.card7 == 8)
                {
                    flag = 9;
                }
                G.Card7 = base.giveCard();
                Console.WriteLine("Another Card Given to Player 4");
            }
            return flag;
        }
    }
}
