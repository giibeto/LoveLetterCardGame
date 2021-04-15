using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class King : Card
    {
        Game G = new Game();
        private int total;
        public King()
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

            Console.WriteLine("King (6)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Player trades hands with any other player.");
            Console.WriteLine("------------------------------------");
            total--;
        }
        public void playKing()
        {

            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 2)
            {
                int temp = G.Card1;
                G.Card1 = G.Card2;
                G.Card2 = temp;
            }
            else
            {
                int temp = G.Card1;
                G.Card1 = G.Card2;
                G.Card2 = temp;
            }
            Console.WriteLine("Cards Exchanged");
        }

        public void playKing3(int players)
        {

            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players == 2)
            {
                int temp = G.Card3;
                G.Card3 = G.Card1;
                G.Card1 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 3 && players == 2)
            {
                int temp = G.Card3;
                G.Card3 = G.Card5;
                G.Card5 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 2 && players == 1)
            {
                int temp = G.Card1;
                G.Card1 = G.Card3;
                G.Card3 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 3 && players == 1)
            {
                int temp = G.Card1;
                G.Card1 = G.Card5;
                G.Card5 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 1 && players == 3)
            {
                int temp = G.Card5;
                G.Card5 = G.Card1;
                G.Card1 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 2 && players == 3)
            {
                int temp = G.Card5;
                G.Card5 = G.Card3;
                G.Card3 = temp;
                Console.WriteLine("Cards Exchanged");
            }
        }
        public void playKing4(int players)
        {

            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            Console.WriteLine("(4) Player 4 " + G.P.Player4);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players == 2)
            {
                int temp = G.Card3;
                G.Card3 = G.Card1;
                G.Card1 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 3 && players == 2)
            {
                int temp = G.Card3;
                G.Card3 = G.Card5;
                G.Card5 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 4 && players == 2)
            {
                int temp = G.Card3;
                G.Card3 = G.Card7;
                G.Card7 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 2 && players == 1)
            {
                int temp = G.Card1;
                G.Card1 = G.Card3;
                G.Card3 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 3 && players == 1)
            {
                int temp = G.Card1;
                G.Card1 = G.Card5;
                G.Card5 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 4 && players == 1)
            {
                int temp = G.Card1;
                G.Card1 = G.Card7;
                G.Card7 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 1 && players == 3)
            {
                int temp = G.Card5;
                G.Card5 = G.Card1;
                G.Card1 = temp;
                Console.WriteLine("Cards Exchanged");
            }

            else if (selectPlayer == 2 && players == 3)
            {
                int temp = G.Card5;
                G.Card5 = G.Card3;
                G.Card3 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 4 && players == 3)
            {
                int temp = G.Card5;
                G.Card5 = G.Card7;
                G.Card7 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 1 && players == 4)
            {
                int temp = G.Card7;
                G.Card7 = G.Card1;
                G.Card1 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 2 && players == 4)
            {
                int temp = G.Card7;
                G.Card7 = G.Card3;
                G.Card3 = temp;
                Console.WriteLine("Cards Exchanged");
            }
            else if (selectPlayer == 3 && players == 4)
            {
                int temp = G.Card7;
                G.Card7 = G.Card5;
                G.Card5 = temp;
                Console.WriteLine("Cards Exchanged");
            }
        }

    }
}