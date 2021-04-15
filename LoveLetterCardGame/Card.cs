using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetterCardGame
{
    public class Card
    {
        Game G =new Game();
        Random R = new Random();
        int card1;
        public Card()
        {
            card1 = 0;
        }
        public int giveCard()
        {
            try
            {
                card1 = R.Next(1, 9);
            }catch(StackOverflowException e)
            {
            }
            return card1;
        }
   
       
    }
}
