using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Guard : Card
    {
        private int total;
        Game G = new Game();
        public Guard()
        {
            Total = 5;
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
            Console.WriteLine("Guard (1)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Player designates another player and names a type of card. If that player's hand matches the type of card specified, that player is eliminated from the round. However, Guard cannot be named as the type of card.");
            Console.WriteLine("------------------------------------");
            total--;
        }
        public int playGuard(int card3, int card1)
        {
            int flag = 0;
                Console.WriteLine("Select which player you want to target");
                Console.WriteLine("(1) Player 1" + G.P.Player1);
                Console.WriteLine("(2) Player 2 " + G.P.Player2);
                int selectPlayer = Convert.ToInt32(Console.ReadLine());
                if (selectPlayer == 1)
                {
                    Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card1)
                    {
                        flag = 2;
                    }
                    else if (target != card1)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 2)
                {
                    Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card3)
                    {
                        flag = 1;
                    }
                    else if (target != card3)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
            return flag;
            }
        public int playGuard3(int card5,int card3,int card1,int players)
        {
                int flag = 0;
                Console.WriteLine("Select which player you want to target");
                Console.WriteLine("(1) Player 1" + G.P.Player1);
                Console.WriteLine("(2) Player 2 " + G.P.Player2);
                Console.WriteLine("(3) Player 3 " + G.P.Player2);
                int selectPlayer = Convert.ToInt32(Console.ReadLine());
                if (selectPlayer == 1 && players == 2)
                {
                    Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card1)
                    {
                        flag = 3;
                    }
                    else if (target != card1)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 1 && players == 3)
                {
                    Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card1)
                    {
                        flag = 5;
                    }
                    else if (target != card1)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 2 && players == 1)
                {
                    Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card3)
                    {
                        flag = 1;
                    }
                    else if (target != card3)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 2 && players == 3)
                {
                    Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card3)
                    {
                        flag = 6;
                    }
                    else if (target != card3)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 3 && players == 1)
                {
                    Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card5)
                    {
                        flag = 2;
                    }
                    else if (target != card5)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
                else if (selectPlayer == 3 && players == 2)
                {
                    Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                    Console.WriteLine("(2) Priest");
                    Console.WriteLine("(3) Baron");
                    Console.WriteLine("(4) HandMaid");
                    Console.WriteLine("(5) Prince");
                    Console.WriteLine("(6) King");
                    Console.WriteLine("(7) Countess");
                    Console.WriteLine("(8) Princess");
                    int target = Convert.ToInt32(Console.ReadLine());
                    if (target == card5)
                    {
                        flag = 4;
                    }
                    else if (target != card5)
                    {
                        Console.WriteLine("You have Guessed Wrong Card");
                    }
                }
            return flag;
            }
        public int playGuard4(int card7,int card5, int card3, int card1, int players)
        {
            int flag = 0;
            Console.WriteLine("Select which player you want to target");
            Console.WriteLine("(1) Player 1" + G.P.Player1);
            Console.WriteLine("(2) Player 2 " + G.P.Player2);
            Console.WriteLine("(3) Player 3 " + G.P.Player3);
            Console.WriteLine("(4) Player 4 " + G.P.Player4);
            int selectPlayer = Convert.ToInt32(Console.ReadLine());
            if (selectPlayer == 1 && players == 2)
            {
                Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card1)
                {
                    flag = 4;
                }
                else if (target != card1)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 1 && players == 3)
            {
                Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card1)
                {
                    flag = 7;
                }
                else if (target != card1)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 1 && players == 4)
            {
                Console.WriteLine("You have chosen Player 1" + G.P.Player1);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card1)
                {
                    flag = 10;
                }
                else if (target != card1)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 2 && players == 1)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card3)
                {
                    flag = 1;
                }
                else if (target != card3)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 2 && players == 3)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card3)
                {
                    flag = 8;
                }
                else if (target != card3)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 2 && players == 4)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card3)
                {
                    flag = 11;
                }
                else if (target != card3)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 3 && players == 1)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card5)
                {
                    flag = 2;
                }
                else if (target != card5)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 3 && players == 2)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card5)
                {
                    flag = 5;
                }
                else if (target != card5)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 3 && players == 4)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card5)
                {
                    flag = 12;
                }
                else if (target != card5)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 4 && players == 1)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card7)
                {
                    flag = 3;
                }
                else if (target != card7)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 4 && players == 2)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card7)
                {
                    flag = 6;
                }
                else if (target != card7)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            else if (selectPlayer == 4 && players == 3)
            {
                Console.WriteLine("You have chosen Player 2" + G.P.Player2);
                Console.WriteLine("(2) Priest");
                Console.WriteLine("(3) Baron");
                Console.WriteLine("(4) HandMaid");
                Console.WriteLine("(5) Prince");
                Console.WriteLine("(6) King");
                Console.WriteLine("(7) Countess");
                Console.WriteLine("(8) Princess");
                int target = Convert.ToInt32(Console.ReadLine());
                if (target == card7)
                {
                    flag = 9;
                }
                else if (target != card7)
                {
                    Console.WriteLine("You have Guessed Wrong Card");
                }
            }
            return flag;
        }
        }
        
    }
