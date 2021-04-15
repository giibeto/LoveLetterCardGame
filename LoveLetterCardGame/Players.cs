using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Players
    {
        private string player1;
        private string player2;
        private string player3;
        private string player4;
        public Players()
        {
            player1 = "";
            player2 = "";
            player3 = "";
            player4 = "";
        }
       
        public string Player1
        {
            get
            {
                return player1;
            }
            set
            {
                player1 = value;
            }
        }
        public string Player2
        {
            get
            {
                return player2;
            }
            set
            {
                player2 = value;
            }
        }
        public string Player3
        {
            get
            {
                return player3;
            }
            set
            {
                player3 = value;
            }
        }
        public string Player4
        {
            get
            {
                return player4;
            }
            set
            {
                player4 = value;
            }
        }
        public void TwoPlayer()
        {
                Console.WriteLine("Hi Player 1, What is Your Name?");
                player1 = Console.ReadLine();
                Console.WriteLine("Hi Player 2, What is Your Name?");
                player2 = Console.ReadLine();
        }
        public void ThreePlayer()
        {
            Console.WriteLine("Hi Player 1, What is Your Name?");
            player1 = Console.ReadLine();
            Console.WriteLine("Hi Player 2, What is Your Name?");
            player2 = Console.ReadLine();
            Console.WriteLine("Hi Player 3, What is Your Name?");
            player3 = Console.ReadLine();
        }
        public void FourPlayer()
        {
            Console.WriteLine("Hi Player 1, What is Your Name?");
            player1 = Console.ReadLine();
            Console.WriteLine("Hi Player 2, What is Your Name?");
            player2 = Console.ReadLine();
            Console.WriteLine("Hi Player 3, What is Your Name?");
            player3 = Console.ReadLine();
            Console.WriteLine("Hi Player 4, What is Your Name?");
            player4 = Console.ReadLine();
        }

    }
}
