using Diablo3Viewer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataInterpreters
{
    class CareerProfileFetcher
    {
        public CareerProfileData data;

        public CareerProfileFetcher()
        {
            data = new CareerProfileData();
        }

        public bool fetchData()
        {
            dynamic json;
            using (WebClient client = new WebClient())
            {
                string url = "https://eu.api.battle.net/d3/profile/"
                            +Program.profile.name
                            +"-"
                            +Program.profile.battleTag
                            +"/?locale=de_DE&apikey="
                            +Program.apiKey;

                json = JsonConvert.DeserializeObject(client.DownloadString(url));
            }
            return generateModel(json);
        }

        private bool generateModel(dynamic json)
        {
            if (json.code==null)
            {
                data.battleTag = json.battleTag;
                data.paragonLevel = json.paragonLevel;
                data.paragonLevelHardcore = json.paragonLevelHardcore;
                data.paragonLevelSeason = json.paragonLevelSeason;
                data.paragonLevelSeasonHardcore = json.paragonLevelSeasonHardcore;
                data.guildName = json.guildName;

                List<HeroData> heroDatas = new List<HeroData>();
                foreach (var hero in json.heroes)
                {
                    HeroData hData = new HeroData();
                    hData.id = hero.id;
                    hData.name = hero.name;
                    hData.className = hero["class"];
                    hData.gender = hero.gender;
                    hData.level = hero.level;

                    KillData kill = new KillData();
                    kill.elites = hero.kills.elites;
                    hData.kills = kill;

                    hData.paragonLevel = hero.paragonLevel;
                    hData.hardcore = hero.hardcore;
                    hData.seasonal = hero.seasonal;
                    hData.lastUpdated = hero["last-updated"];
                    hData.dead = hero.dead;

                    heroDatas.Add(hData);
                }
                data.heroes = heroDatas;

                data.lastHeroPlayed = json.lastHeroPlayed;
                data.lastUpdated = json.lastUpdated;

                KillData killdata = new KillData();
                killdata.monsters = json.kills.monsters;
                killdata.elites = json.kills.elites;
                killdata.hardcoreMonsters = json.kills.hardcoreMonsters;

                data.kills = killdata;
                data.highestHardcoreLevel = json.highestHardcoreLevel;

                PlayTime ptime = new PlayTime();
                ptime.barbarian = json.timePlayed.barbarian;
                ptime.crusader = json.timePlayed.crusader;
                ptime.demonhunter = json.timePlayed["demon-hunter"];
                ptime.monk = json.timePlayed.monk;
                ptime.witchdoctor = json.timePlayed["witch-doctor"];
                ptime.wizard = json.timePlayed.wizard;

                Dictionary<string, ArtisanData> artisans = new Dictionary<string, ArtisanData>();
                List<string> artisanNames = new List<string> { "blacksmith", "jeweler", "mystic", 
                                                               "blacksmithHardcore", "jewelerHardcore", "mysticHardcore",
                                                               "blacksmithSeason", "jewelerSeason", "mysticSeason",
                                                               "blacksmithSeasonHardcore", "jewelerSeasonHardcore", "mysticSeasonHardcore"};
                foreach (string name in artisanNames)
                {
                    artisans.Add(name, generateArtisanObject((string)json[name].slug, (int)json[name].level, (int)json[name].stepCurrent, (int)json[name].stepMax));
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private ArtisanData generateArtisanObject(string slug, int level, int stepCurrent, int stepMax)
        {
            ArtisanData artisan = new ArtisanData();
            artisan.slug = slug;
            artisan.level = level;
            artisan.stepCurrent = stepCurrent;
            artisan.stepMax = stepMax;

            return artisan;
        }

        public CareerProfileData getModel()
        {
            return data;
        }
    }
}
