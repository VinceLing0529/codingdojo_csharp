using System;
using System.Collections.Generic;
using System.Linq;
namespace deck_of_cards
{
    class Player
    {
        public string name{get;set;}
        public List<Card> hand;
        public Player(string Name)
        {
            name=Name;
            hand = new List<Card>();
        }
        public Card draw()
        {
            Deck a= new Deck();
            a.shuffle();
            Card draw = a.deal();
            hand.Add(draw);
            return draw;
        }
        public Card discard(int index)
        {
         if(index< hand.Count)
         {
            Card x = hand[index];
            hand.RemoveAt(index);
            return x;
         }   
         else
         {
             return null;
         }
        }
    }
}