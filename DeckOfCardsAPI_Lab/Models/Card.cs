using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCardsAPI_Lab.Models
{
    public class Card
    {
        public string deck_id { get; set; }
        public string code { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
        public string image { get; set; }

        public override string ToString()
        {
            return $"{value} of {suit}";
        }
    }
}
