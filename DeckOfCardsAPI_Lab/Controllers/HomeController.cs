using DeckOfCardsAPI_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeckOfCardsAPI_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com/");
            var response = await client.GetAsync("api/deck/new/shuffle/?deck_count=1");
            Deck myDeck = await response.Content.ReadAsAsync<Deck>();
            string myDeckURL = myDeck.deck_id;

            response = await client.GetAsync($"/api/deck/{myDeckURL}/draw/?count=5");
            Cards myCardDeck = await response.Content.ReadAsAsync<Cards>();

            return View(myCardDeck);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
