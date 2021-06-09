namespace deck_of_cards
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string SV, string Suit, int Val)
        {
            stringVal=SV;
            suit=Suit;
            val=Val;
        }
    }
}