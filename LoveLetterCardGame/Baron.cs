using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Baron : Card
    {
        private int total;
        Game G = new Game();
        public Baron()
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
                Console.WriteLine("Baron (3)");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Player will choose another player and privately compare hands. The player with the lower-strength hand is eliminated from the round.");
                Console.WriteLine("------------------------------------");
                total--;
        }
        public int playBaron(int card3,int card1)
        {
            int flag=0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1)
            {
                if (card3 > card1)
                {
                    flag = 2;
                }
                else if(card3==card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if(card3<card1)
                {
                    flag = 1;
                }
            }
            else if(selectPlayer==2)
            {
                if (card1 > card3)
                {
                    flag = 1;
                }
                else if(card1<card3)
                {
                    flag = 2;
                }
                else if(card3==card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            return flag;
        }
        public int playBaron3(int card5,int card3,int card1,int players)
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players==2)
            {
                if (card3 > card1)
                {
                    flag = 3;
                }
                else if (card3 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if (card3 < card1)
                {
                    flag = 1;
                }
            }
            else if (selectPlayer == 1 && players == 3)
            {
                if (card5 > card1)
                {
                    flag = 5;
                }
                else if (card5 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if (card5 < card1)
                {
                    flag = 2;
                }
            }
            else if (selectPlayer == 2 && players==1)
            {
                if (card1 > card3)
                {
                    flag = 1;
                }
                else if (card1 < card3)
                {
                    flag = 3;
                }
                else if (card3 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 2 && players == 3)
            {
                if (card5 > card3)
                {
                    flag = 6;
                }
                else if (card5 < card3)
                {
                    flag = 4;
                }
                else if (card3 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 3 && players == 1)
            {
                if (card1 > card5)
                {
                    flag = 2;
                }
                else if (card1 < card5)
                {
                    flag = 5;
                }
                else if (card1 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 3 && players == 2)
            {
                if (card3 > card5)
                {
                    flag = 4;
                }
                else if (card3 < card5)
                {
                    flag = 6;
                }
                else if (card3 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }

            return flag;
        }
        public int playBaron4(int card7,int card5, int card3, int card1, int players)
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            Console.WriteLine("(4) Player 4 " + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players == 2)
            {
                if (card3 > card1)
                {
                    flag = 4;
                }
                else if (card3 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if (card3 < card1)
                {
                    flag = 1;
                }
            }
            else if (selectPlayer == 1 && players == 3)
            {
                if (card5 > card1)
                {
                    flag = 7;
                }
                else if (card5 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if (card5 < card1)
                {
                    flag = 2;
                }
            }
            else if (selectPlayer == 1 && players == 4)
            {
                if (card7 > card1)
                {
                    flag = 10;
                }
                else if (card7 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
                else if (card7 < card1)
                {
                    flag = 3;
                }
            }
            else if (selectPlayer == 2 && players == 1)
            {
                if (card1 > card3)
                {
                    flag = 1;
                }
                else if (card1 < card3)
                {
                    flag = 4;
                }
                else if (card3 == card1)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 2 && players == 3)
            {
                if (card5 > card3)
                {
                    flag = 8;
                }
                else if (card5 < card3)
                {
                    flag = 5;
                }
                else if (card3 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 2 && players == 4)
            {
                if (card7 > card3)
                {
                    flag = 11;
                }
                else if (card7 < card3)
                {
                    flag = 6;
                }
                else if (card3 == card7)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 3 && players == 1)
            {
                if (card1 > card5)
                {
                    flag = 2;
                }
                else if (card1 < card5)
                {
                    flag = 7;
                }
                else if (card1 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 3 && players == 2)
            {
                if (card3 > card5)
                {
                    flag = 5;
                }
                else if (card3 < card5)
                {
                    flag = 8;
                }
                else if (card3 == card5)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 3 && players == 4)
            {
                if (card5 > card7)
                {
                    flag = 12;
                }
                else if (card5 < card7)
                {
                    flag = 9;
                }
                else if (card5 == card7)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 4 && players == 1)
            {
                if (card1 > card7)
                {
                    flag = 3;
                }
                else if (card1 < card7)
                {
                    flag = 10;
                }
                else if (card1 == card7)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 4 && players == 2)
            {
                if (card3 > card7)
                {
                    flag = 6;
                }
                else if (card3 < card7)
                {
                    flag = 11;
                }
                else if (card3 == card7)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            else if (selectPlayer == 4 && players == 3)
            {
                if (card5 > card7)
                {
                    flag = 9;
                }
                else if (card5 < card7)
                {
                    flag = 12;
                }
                else if (card5 == card7)
                {
                    Console.WriteLine("Both Cards Are Equal");
                }
            }
            return flag;
        }
    }
}
