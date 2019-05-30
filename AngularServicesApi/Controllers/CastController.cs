using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularServicesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        static List<Character> _cast = new List<Character>();

        static CastController()
        {
            InitDb();
        }

        [HttpGet]
        public ActionResult Get()
        {
            var trimmed = _cast
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Img,
                    c.Dead
                });

            return Ok(trimmed);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var character = _cast.SingleOrDefault(c => c.Id == id);
            return Ok(character);
        }

        [HttpPost("{id}")]
        public ActionResult KillCharacter(int id)
        {
            var character = _cast.SingleOrDefault(c => c.Id == id);
            character.Dead = true;
            return Ok();
        }

        static void InitDb()
        {
            AddChar("Eddard “Ned” Stark", "ned-stark");
            AddChar("Robert Baratheon");
            AddChar("Tyrion Lannister");
            AddChar("Cersei Lannister");
            AddChar("Catelyn Stark");
            AddChar("Jaime Lannister");
            AddChar("Daenerys Targaryen");
            AddChar("Viserys Targaryen");
            AddChar("Jon Snow");
            AddChar("Robb Stark");
            AddChar("Sansa Stark");
            AddChar("Arya Stark");
            AddChar("Bran Stark");
            AddChar("Rickon Stark");
            AddChar("Joffrey Baratheon");
            AddChar("Jorah Mormont");
            AddChar("Theon Greyjoy");
            AddChar("Petyr Baelish(“Littlefinger”)");
            AddChar("Sandor Clegane(“The Hound”)");
            AddChar("Samwell Tarly");
            AddChar("Renly Baratheon");
            AddChar("Ros");
            AddChar("Jeor Mormont");
            AddChar("Gendry");
            AddChar("Lysa Arryn");
            AddChar("Robin Arryn");
            AddChar("Bronn");
            AddChar("Grand Maester Pycelle");
            AddChar("Varys");
            AddChar("Loras Tyrell");
            AddChar("Shae");
            AddChar("Benjen Stark");
            AddChar("Barristan Selmy");
            AddChar("Khal Drogo");
            AddChar("Hodor");
            AddChar("Lancel Lannister");
            AddChar("Maester Luwin");
            AddChar("Alliser Thorne");
            AddChar("Osha");
            AddChar("Maester Aemon");
            AddChar("Talisa Stark");
            AddChar("Brienne of Tarth");
            AddChar("Davos Seaworth");
            AddChar("Tywin Lannister");
            AddChar("Stannis Baratheon");
            AddChar("Margaery Tyrell");
            AddChar("Ygritte");
            AddChar("Balon Greyjoy");
            AddChar("Roose Bolton");
            AddChar("Gilly");
            AddChar("Podrick Payne");
            AddChar("Melisandre");
            AddChar("Yara Greyjoy");
            AddChar("Jaqen H’ghar");
            AddChar("Grey Worm");
            AddChar("Beric Dondarrion");
            AddChar("Missandei");
            AddChar("Mance Rayder");
            AddChar("Tormund");
            AddChar("Ramsay Snow");
            AddChar("Olenna Tyrell");
            AddChar("Thoros of Myr");
            AddChar("Orell");
            AddChar("Qyburn");
            AddChar("Brynden Tully(“The Blackfish”)");
            AddChar("Tommen Baratheon");
            AddChar("Daario Naharis");
            AddChar("Oberyn Martell");
            AddChar("Ellaria Sand");
            AddChar("Myrcella Baratheon");
            AddChar("Obara Sand");
            AddChar("Nym Sand");
            AddChar("Tyene Sand");
            AddChar("High Sparrow");
            AddChar("Trystane Martell");
            AddChar("Doran Martell");
            AddChar("Euron Greyjoy");
            AddChar("Lady Crane");
            AddChar("High Priestess");
            AddChar("Randyll Tarly");
            AddChar("Izembaro");
            AddChar("Brother Ray");
            AddChar("Archmaester Ebrose");
        }
        static void AddChar(string name, string img = "")
        {
            if (img.Length == 0)
                img = name.ToLower().Replace(' ', '-');

            _cast.Add(new Character
            {
                Id = _cast.Count + 1,
                Name = name,
                Img = img,
                Dead = false
            });
        }
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public bool Dead { get; set; }
        public string Description { get; set; }
    }
}