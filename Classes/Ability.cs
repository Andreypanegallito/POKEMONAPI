using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace POKEMONAPI.Classes
{
    public class Ability
    {
        public AbilityDetail ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class AbilityDetail
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stats
    {
        public int base_stat { get; set; }
        public int effort { get; set; }

        public Stat stat { get; set; }

    }

    public class Stat
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Sprite
    {
        public string back_default { get; set; }
        public string back_shiny { get; set; }
        public string front_default { get; set; }
        public string front_shiny { get; set; }
        public OtherSprite other { get; set; }

    }

    public class OtherSprite
    {
        public DreamWorld dream_world { get; set; }
        public Home home { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork official_artwork { get; set; }
        public Showdown showdown { get; set; }
    }

    public class DreamWorld
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
    }

    public class Home
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
        public string front_shiny { get; set; }
    }

    public class Showdown
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

}
