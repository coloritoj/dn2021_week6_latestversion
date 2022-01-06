using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class Deck
    {
        public string deck_id { get; set; } // These are case sensitive. Syntax/casing/etc. has to match exactly.
        public int remaining { get; set; }
    }

    public class Card
    {
        public string code { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string image { get; set; }
    }

    public class Cards
    {
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public List<Card> cards { get; set; }
    }
}
