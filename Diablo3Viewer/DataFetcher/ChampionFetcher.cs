using Diablo3Viewer.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataFetcher
{
    class ChampionFetcher
    {
        private CareerProfileData cpd;
        private List<CharacterData> cd;

        public ChampionFetcher(CareerProfileData cpd)
        {
            this.cpd = cpd;
        }

        public void fetchData()
        {
            dynamic json;
            using (WebClient client = new WebClient())
            {
                foreach (HeroData hero in cpd.heroes)
                {
                    string url = "https://eu.api.battle.net/d3/profile/"
                                + Program.profile.name
                                + "-"
                                + Program.profile.battleTag
                                + "/hero/"
                                + hero.id
                                + "?locale=de_DE&apikey="
                                + Program.apiKey;

                    json = JsonConvert.DeserializeObject(client.DownloadString(url));
                    generateModel(json);
                }
            }
        }

        private void generateModel(dynamic json)
        {
            CharacterData ch = new CharacterData();

            ch.id = json.id;
            ch.name = json.name;
            ch.gender = json.gender;
            ch.level = json.level;

            KillData killData = new KillData();
            killData.elites = json.kills.elites;

            ch.kills = killData;
            ch.paragonLevel = json.paragonLevel;
            ch.hardcore = json.hardcore;
            ch.seasonal = json.seasonal;
            ch.seasonCreated = json.seasonCreated;

            SkillsData skillData = new SkillsData();
            skillData.active = new List<ActiveSkillData>();
            foreach (var entry in json.skills.active)
            {
                ActiveSkillData active = new ActiveSkillData();

                SkillData skill = new SkillData();
                skill.slug = entry.skill.slug;
                skill.name = entry.skill.name;
                skill.icon = entry.skill.icon;
                skill.level = entry.skill.level;
                skill.categorySlug = entry.skill.categorySlug;
                skill.tooltipUrl = entry.skill.tooltipUrl;
                skill.description = entry.skill.description;
                skill.simpleDescription = entry.skill.simpleDescription;
                skill.skillCalcId = entry.skill.skillCalcId;

                RuneData rune = new RuneData();
                rune.slug = entry.rune.slug;
                rune.type = entry.rune.type;
                rune.name = entry.rune.name;
                rune.level = entry.rune.level;
                rune.description = entry.rune.description;
                rune.simpleDescription = entry.rune.simpleDescription;
                rune.tooltipParams = entry.rune.tooltipParams;
                rune.skillCalcId = entry.rune.skillCalcId;
                rune.order = entry.rune.order;

                active.skill = skill;
                active.rune = rune;

                skillData.active.Add(active);
            }
            skillData.passive = new List<PassiveSkillData>();
            foreach (var entry in json.skills.passive)
            {
                PassiveSkillData passive = new PassiveSkillData();

                SkillData skill = new SkillData();
                skill.slug = entry.skill.slug;
                skill.name = entry.skill.name;
                skill.icon = entry.skill.icon;
                skill.level = entry.skill.level;
                skill.tooltipUrl = entry.skill.tooltipUrl;
                skill.description = entry.skill.description;
                skill.flavor = entry.skill.flavor;
                skill.skillCalcId = entry.skill.skillCalcId;

                passive.skill = skill;

                skillData.passive.Add(passive);
            }

        }

        public List<CharacterData> getModel()
        {
            return cd;
        }
    }
}
