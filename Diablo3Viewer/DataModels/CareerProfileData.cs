using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class CareerProfileData
    {
        public string battleTag { get; set; }
        public int paragonLevel { get; set; }
        public int paragonLevelHardcore { get; set; }
        public int paragonLevelSeason { get; set; }
        public int paragonLevelSeasonHardcore { get; set; }
        public string guildName { get; set; }
        public List<HeroData> heroes { get; set; }
        public int lastHeroPlayed { get; set; }
        public int lastUpdated { get; set; }
        public KillData kills { get; set; }
        public int highestHardcoreLevel { get; set; }
        public PlayTime timePlayed { get; set; }
        //fallenHeroes
        public Dictionary<string, ArtisanData> artisans { get; set; }
        //seasonalProfiles

    }
}
