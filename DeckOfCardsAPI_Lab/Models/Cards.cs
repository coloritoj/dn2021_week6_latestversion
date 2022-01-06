using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCardsAPI_Lab.Models
{
    public class Cards
    {
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public List<Card> cards { get; set; }
    }
}
