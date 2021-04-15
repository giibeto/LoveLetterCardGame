using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Game
    {
        int flag;
        public int card1;
        public int card2;
        public int card3;
        public int card4;
        public int card5;
        public int card6;
        public int card7;
        public int card8;
        public Players P = new Players();
        Card card;
        Guard G;
        Priest Priest;
        Baron B;
        Handmaid H;
        Prince Prince;
        King K;
        Countess C;
        Princess Princess;
        public Game()
        {
            flag = 0;
            card1 = 0;
            card2 = 0;
            card3 = 0;
            card4 = 0;
        }
        public int Card1
        {
            get
            {
                return card1;
            }
            set
            {
                card1 = value;
            }
        }
        public int Card2
        {
            get
            {
                return card2;
            }
            set
            {
                card2 = value;
            }
        }
        public int Card3
        {
            get
            {
                return card3;
            }
            set
            {
                card3 = value;
            }
        }
        public int Card4
        {
            get
            {
                return card4;
            }
            set
            {
                card4 = value;
            }
        }
        public int Card5
        {
            get
            {
                return card5;
            }
            set
            {
                card5 = value;
            }
        }
        public int Card6
        {
            get
            {
                return card6;
            }
            set
            {
                card6 = value;
            }
        }
        public int Card7
        {
            get
            {
                return card7;
            }
            set
            {
                card7 = value;
            }
        }
        public int Card8
        {
            get
            {
                return card8;
            }
            set
            {
                card8 = value;
            }
        }
        public void startGame()
        {
            int round1 = 0;
            int round2 = 0;
            int round3 = 0;
            int round4 = 0;
            Console.WriteLine("Welcome to Love Letter: ");
            Console.WriteLine("\n Start New Game");
            Console.WriteLine("How Many Players for this Game (2-4)");
            int players = Convert.ToInt32(Console.ReadLine());
            if (players == 2)
            {
                P.TwoPlayer();

                while (round1 != 7 || round2 != 7)
                {

                    card = new Card();
                    G = new Guard();
                    Priest = new Priest();
                    B = new Baron();
                    H = new Handmaid();
                    Prince = new Prince();
                    K = new King();
                    C = new Countess();
                    Princess = new Princess();
                    card1 = card.giveCard();
                    card2 = card.giveCard();
                    card3 = card.giveCard();
                    card4 = card.giveCard();
                    Console.WriteLine("NEXT ROUND");
                    for (int i = 0; i < 8; i++)
                    {

                        Console.WriteLine("----------Discard Pile-----------");
                        Console.WriteLine("\n Hi " + P.Player1 + " this is your turn \n");
                        Console.WriteLine("Your Cards Are: ");
                        card1 = gameCard1(card1);
                        card2 = gameCard1(card2);
                        Console.WriteLine("Please choose one card you want to play");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        if (choose == 1)
                        {

                            flag = G.playGuard(card3, card1);
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round2++;
                                break;
                            }

                        }
                        else if (choose == 2)
                        {
                            Priest.playPriest(card3, card1);
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                        }
                        else if (choose == 3)
                        {
                            flag = B.playBaron(card3, card1);
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round2++;
                                break;
                            }

                        }
                        else if (choose == 4)
                        {
                            H.playHandMaid();
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                        }
                        else if (choose == 5)
                        {
                            flag = Prince.playPrince();
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round2++;
                                break;
                            }

                        }
                        else if (choose == 6)
                        {
                            K.playKing();
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                        }
                        else if (choose == 7)
                        {
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                        }
                        else if (choose == 8)
                        {
                            if (choose == card1)
                            {
                                card1 = card.giveCard();
                            }
                            if (choose == card2)
                            {
                                card2 = card.giveCard();
                            }
                            Console.WriteLine("Player 2 Won the Round");
                            round2++;
                            break;

                        }


                        Console.WriteLine("----------Discard Pile-----------");
                        Console.WriteLine("\n Hi " + P.Player2 + " this is your turn \n");
                        Console.WriteLine("Your Cards Are: ");
                        card3 = gameCard1(card3);
                        card4 = gameCard1(card4);
                        Console.WriteLine("Please choose one card you want to play");
                        int choose1 = Convert.ToInt32(Console.ReadLine());
                        if (choose1 == 1)
                        {
                            flag = G.playGuard(card3, card1);
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round2++;
                                break;
                            }

                        }
                        else if (choose1 == 2)
                        {
                            Priest.playPriest(card3, card1);
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                        }
                        else if (choose1 == 3)
                        {
                            flag = B.playBaron(card3, card1);
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round2++;
                                break;
                            }

                        }
                        else if (choose1 == 4)
                        {
                            H.playHandMaid();
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                        }
                        else if (choose1 == 5)
                        {
                            flag = Prince.playPrince();
                            if (flag == 1)
                            {
                                Console.WriteLine("Player 1 Won the Round");
                                round1++;
                                break;
                            }
                            else if (flag == 2)
                            {
                                Console.WriteLine("Player 2 Won the Round");
                                round1++;
                                break;
                            }
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                        }
                        else if (choose1 == 6)
                        {
                            K.playKing();
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                        }
                        else if (choose1 == 7)
                        {
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                        }
                        else if (choose1 == 8)
                        {
                            if (choose1 == card3)
                            {
                                card3 = card.giveCard();
                            }
                            if (choose1 == card4)
                            {
                                card4 = card.giveCard();
                            }
                            Console.WriteLine("Player 1 Won the Game");
                            round1++;
                            break;

                        }

                        if (G.Total == 0 && Priest.Total == 0 && B.Total == 0 && H.Total == 0 && Prince.Total == 0 && K.Total == 0 && C.Total == 0 && Princess.Total == 0)
                        {
                            if (card1 > card3)
                            {
                                round1++;
                                Console.WriteLine("Player 1 Won the Game");
                            }
                            else
                            {
                                round2++;
                                Console.WriteLine("Player 1 Won the Game");
                            }
                            break;
                        }
                    }

                    if (round1 == 7)
                    {
                        Console.WriteLine("Player 1 Wins");
                        break;
                    }
                    else if (round2 == 7)
                    {
                        Console.WriteLine("Player 2 Wins");
                        break;
                    }
                }

            }
            else if (players == 3)
            {
                P.ThreePlayer();

                while (round1 != 5 || round2 != 5 || round3 != 5)
                {
                    bool p1out = false;
                    bool p2out = false;
                    bool p3out = false;
                    int p1wins = 0;
                    int p2wins = 0;
                    int p3wins = 0;
                    card = new Card();
                    G = new Guard();
                    Priest = new Priest();
                    B = new Baron();
                    H = new Handmaid();
                    Prince = new Prince();
                    K = new King();
                    C = new Countess();
                    Princess = new Princess();
                    card1 = card.giveCard();
                    card2 = card.giveCard();
                    card3 = card.giveCard();
                    card4 = card.giveCard();
                    card5 = card.giveCard();
                    card6 = card.giveCard();
                    int choose = 0;
                    Console.WriteLine("NEXT ROUND");
                    for (int i = 0; i < 4; i++)
                    {
                        if (p1out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player1 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card1 = gameCard1(card1);
                            card2 = gameCard1(card2);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {

                                flag = G.playGuard3(card5, card3, card1, 1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest3(card5, card3, card1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron3(card5, card3, card1, 1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince3(1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }

                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing3(1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                Console.WriteLine("Player 1 is out of Round");
                                p2wins++;
                                p3wins++;
                                p1out = true;
                            }
                        }
                        if (p2out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player2 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card3 = gameCard1(card3);
                            card4 = gameCard1(card4);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {

                                flag = G.playGuard3(card5, card3, card1, 2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest3(card5, card3, card1);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron3(card5, card3, card1, 2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card3)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince3(2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }

                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing3(2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                Console.WriteLine("Player 2 is out of Round");
                                p1wins++;
                                p3wins++;
                                p2out = true;

                            }
                        }
                        else if (p3out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player3 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card5 = gameCard1(card5);
                            card6 = gameCard1(card6);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {

                                flag = G.playGuard3(card5, card3, card1, 3);
                                if (choose == card1)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card6 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest3(card5, card3, card1);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron3(card5, card3, card1, 3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince3(3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }

                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p1out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p1out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing3(3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                Console.WriteLine("Player 3 is out of Round");
                                p1wins++;
                                p2wins++;
                                p3out = true;

                            }
                        }
                        if (p1wins == 2)
                        {
                            Console.WriteLine("Player 1 Won the Round");
                            round1++;
                            break;
                        }
                        else if (p2wins == 2)
                        {
                            Console.WriteLine("Player 2 Won the Round");
                            round2++;
                            break;
                        }
                        else if (p3wins == 2)
                        {
                            Console.WriteLine("Player 3 Won the Round");
                            round3++;
                            break;
                        }

                        if (G.Total == 0 && Priest.Total == 0 && B.Total == 0 && H.Total == 0 && Prince.Total == 0 && K.Total == 0 && C.Total == 0 && Princess.Total == 0)
                        {
                            if (card1 > card3 && card1 > card5)
                            {
                                round1++;
                                Console.WriteLine("Player 1 Won the Round");
                            }
                            else if (card3 > card1 && card3 > card5)
                            {
                                round2++;
                                Console.WriteLine("Player 2 Won the Round");
                            }
                            else if (card5 > card1 && card5 > card3)
                            {
                                round3++;
                                Console.WriteLine("Player 3 Won the Round");
                            }
                            break;
                        }
                    }

                    if (round1 == 5)
                    {
                        Console.WriteLine("Player 1 Wins");
                        break;
                    }
                    else if (round2 == 5)
                    {
                        Console.WriteLine("Player 2 Wins");
                        break;
                    }

                    else if (round3 == 5)
                    {
                        Console.WriteLine("Player 3 Wins");
                        break;
                    }
                }
            }
            else if (players == 4)
            {

                P.FourPlayer();

                while (round1 != 4 || round2 != 4 || round3 != 4 || round4 != 4)
                {
                    bool p1out = false;
                    bool p2out = false;
                    bool p3out = false;
                    bool p4out = false;
                    int p1wins = 0;
                    int p2wins = 0;
                    int p3wins = 0;
                    int p4wins = 0;
                    card = new Card();
                    G = new Guard();
                    Priest = new Priest();
                    B = new Baron();
                    H = new Handmaid();
                    Prince = new Prince();
                    K = new King();
                    C = new Countess();
                    Princess = new Princess();
                    card1 = card.giveCard();
                    card2 = card.giveCard();
                    card3 = card.giveCard();
                    card4 = card.giveCard();
                    card5 = card.giveCard();
                    card6 = card.giveCard();
                    card7 = card.giveCard();
                    card8 = card.giveCard();
                    int choose = 0;
                    Console.WriteLine("NEXT ROUND");
                    for (int i = 0; i < 4; i++)
                    {
                        if (p1out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player1 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card1 = gameCard1(card1);
                            card2 = gameCard1(card2);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {

                                flag = G.playGuard4(card7,card5, card3, card1, 1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest4(card7,card5, card3, card1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron4(card7,card5, card3, card1, 1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince4(1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing4(1);
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card1)
                                {
                                    card1 = card.giveCard();
                                }
                                if (choose == card2)
                                {
                                    card2 = card.giveCard();
                                }
                                Console.WriteLine("Player 1 is out of Round");
                                p2wins++;
                                p3wins++;
                                p4wins++;
                                p1out = true;
                            }
                        }
                        else if (p2out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player2 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card3 = gameCard1(card3);
                            card4 = gameCard1(card4);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {

                                flag = G.playGuard4(card7, card5, card3, card1, 2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest4(card7, card5, card3, card1);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron4(card7, card5, card3, card1, 2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if(choose==card4)
                                {
                                    card4 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince4(2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing4(2);
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card3)
                                {
                                    card3 = card.giveCard();
                                }
                                if (choose == card4)
                                {
                                    card4 = card.giveCard();
                                }
                                Console.WriteLine("Player 2 is out of Round");
                                p1wins++;
                                p3wins++;
                                p4wins++;
                                p2out = true;
                            }
                        }
                        else if (p3out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player3 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card5 = gameCard1(card5);
                            card6 = gameCard1(card6);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {
                                flag = G.playGuard4(card7, card5, card3, card1, 3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest4(card7, card5, card3, card1);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron4(card7, card5, card3, card1, 3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince4(3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing4(3);
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card5)
                                {
                                    card5 = card.giveCard();
                                }
                                if (choose == card6)
                                {
                                    card6 = card.giveCard();
                                }
                                Console.WriteLine("Player 3 is out of Round");
                                p2wins++;
                                p1wins++;
                                p4wins++;
                                p3out = true;
                            }
                        }
                        else if (p4out == false)
                        {
                            Console.WriteLine("----------Discard Pile-----------");
                            Console.WriteLine("\n Hi " + P.Player4 + " this is your turn \n");
                            Console.WriteLine("Your Cards Are: ");
                            card7 = gameCard1(card7);
                            card8 = gameCard1(card8);
                            Console.WriteLine("Please choose one card you want to play");
                            choose = Convert.ToInt32(Console.ReadLine());
                            if (choose == 1)
                            {
                                flag = G.playGuard4(card7, card5, card3, card1, 4);
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 2)
                            {
                                Priest.playPriest4(card7, card5, card3, card1);
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                            }
                            else if (choose == 3)
                            {
                                flag = B.playBaron4(card7, card5, card3, card1, 4);
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }

                            }
                            else if (choose == 4)
                            {
                                H.playHandMaid();
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                            }
                            else if (choose == 5)
                            {
                                flag = Prince.playPrince4(4);
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                                if (flag == 1)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p1wins++;
                                    p3wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 2)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 3)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p1wins++;
                                    p2wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 4)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p2wins++;
                                    p3wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 5)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                                else if (flag == 6)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p3wins++;
                                    p4out = true;
                                }
                                else if (flag == 7)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 8)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 9)
                                {
                                    Console.WriteLine("Player 4 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p2wins++;
                                    p4out = true;
                                }
                                else if (flag == 10)
                                {
                                    Console.WriteLine("Player 1 is out of Round");
                                    p3wins++;
                                    p2wins++;
                                    p4wins++;
                                    p1out = true;
                                }
                                else if (flag == 11)
                                {
                                    Console.WriteLine("Player 2 is out of Round");
                                    p3wins++;
                                    p1wins++;
                                    p4wins++;
                                    p2out = true;
                                }
                                else if (flag == 12)
                                {
                                    Console.WriteLine("Player 3 is out of Round");
                                    p2wins++;
                                    p1wins++;
                                    p4wins++;
                                    p3out = true;
                                }
                            }
                            else if (choose == 6)
                            {
                                K.playKing4(4);
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                            }
                            else if (choose == 7)
                            {
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                            }
                            else if (choose == 8)
                            {
                                if (choose == card7)
                                {
                                    card7 = card.giveCard();
                                }
                                if (choose == card8)
                                {
                                    card8 = card.giveCard();
                                }
                                Console.WriteLine("Player 4 is out of Round");
                                p2wins++;
                                p1wins++;
                                p3wins++;
                                p4out = true;
                            }
                        }
                        if (p1wins == 3)
                        {
                            Console.WriteLine("Player 1 Won the Round");
                            round1++;
                            break;
                        }
                        else if (p2wins == 3)
                        {
                            Console.WriteLine("Player 2 Won the Round");
                            round2++;
                            break;
                        }
                        else if (p3wins == 3)
                        {
                            Console.WriteLine("Player 3 Won the Round");
                            round3++;
                            break;
                        }
                        else if (p4wins == 3)
                        {
                            Console.WriteLine("Player 4 Won the Round");
                            round4++;
                            break;
                        }
                        if (G.Total == 0 && Priest.Total == 0 && B.Total == 0 && H.Total == 0 && Prince.Total == 0 && K.Total == 0 && C.Total == 0 && Princess.Total == 0)
                        {
                            if (card1 > card3 && card1 > card5 && card1>card7)
                            {
                                round1++;
                                Console.WriteLine("Player 1 Won the Round");
                            }
                            else if (card3 > card1 && card3 > card5 && card3>card7)
                            {
                                round2++;
                                Console.WriteLine("Player 2 Won the Round");
                            }
                            else if (card5 > card1 && card5 > card3 && card5>card7)
                            {
                                round3++;
                                Console.WriteLine("Player 3 Won the Round");
                            }
                            else if (card7 > card1 && card7 > card3 && card7 > card5)
                            {
                                round4++;
                                Console.WriteLine("Player 4 Won the Round");
                            }
                            break;
                        }
                    }

                    if (round1 == 4)
                    {
                        Console.WriteLine("Player 1 Wins");
                        break;
                    }
                    else if (round2 == 4)
                    {
                        Console.WriteLine("Player 2 Wins");
                        break;
                    }

                    else if (round3 == 4)
                    {
                        Console.WriteLine("Player 3 Wins");
                        break;
                    }
                    else if (round4 == 4)
                    {
                        Console.WriteLine("Player 4 Wins");
                        break;
                    }
                }
            }
        }
        
        public int gameCard1(int card1)
        {
            if (card1 == 1)
            {
                if (G.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    G.functionality();
                }

            }
            else if (card1 == 2)
            {
                if (Priest.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    Priest.functionality();
                }
            }
            else if (card1 == 3)
            {
                if (B.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    B.functionality();
                }

            }
            else if (card1 == 4)
            {

                if (H.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    H.functionality();
                }
            }
            else if (card1 == 5)
            {
                if (Prince.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    Prince.functionality();
                }

            }
            else if (card1 == 6)
            {
                if (K.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    K.functionality();
                }
            }
            else if (card1 == 7)
            {

                if (C.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    C.functionality();
                }

            }
            else if (card1 == 8)
            {

                if (Princess.Total == 0)
                {
                    gameCard1(card.giveCard());
                }
                else
                {
                    Princess.functionality();
                }

            }
            
            return card1;
        }
    }
}
