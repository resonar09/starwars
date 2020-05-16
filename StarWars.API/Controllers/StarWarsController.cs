using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StarWars.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarWarsController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Character {Name = "Finn", Phrase = "I'm a big deal", Quote = "Listen, I've had a pretty messed up day..."});
            characters.Add(new Character {Name = "Han", Phrase = "Look, kid...", Quote = "I've got enough on my plate as it is, and I..."});
            characters.Add(new Character {Name = "Rey", Phrase = "I can handle myself", Quote = "You will remove these restraints and leave..."});
            characters.Add(new Character {Name = "Luke", Phrase = "Your thoughts betray you", Quote = "I feel the good in you, the conflict..."});
            characters.Add(new Character {Name = "Poe", Phrase = "New Ride", Quote = "I just upgraded my X-Wing. Next time..."});
            characters.Add(new Character {Name = "Ben", Phrase = "Move Along", Quote = "These aren't the droids you're looking for..."});
            characters.Add(new Character {Name = "Leia", Phrase = "You're My Only Hope", Quote = "I've placed information vital to the survival..."});
            characters.Add(new Character {Name = "Yoda", Phrase = "Size matters not", Quote = "Do or do not. There is no try..."});
                                               
            return characters;
        }
    }
}
