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
        private List<CharacterData> cd = new List<CharacterData>();

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
            ch.className = json["class"];
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
            skillData.active = activeSkillGenerator(json);
            skillData.passive = passiveSkillGenerator(json);
            ch.skills = skillData;

            ItemsData itemData = new ItemsData();
            itemData.items = itemDataGenerator(json);
            ch.items = itemData;

            cd.Add(ch);
        }

        private Dictionary<string, ArmorPieceData> itemDataGenerator(dynamic json)
        {
            Dictionary<string, ArmorPieceData> armorData = new Dictionary<string, ArmorPieceData>();

            foreach (var itemData in json.items)
            {
                dynamic entry = json.items[itemData.Name];
                ArmorPieceData armorpiece = new ArmorPieceData();

                armorpiece.id = entry["id"];
                armorpiece.name = entry.name;
                armorpiece.icon = entry.icon;
                armorpiece.displayColor = entry.displayColor;
                armorpiece.tooltipParams = entry.tooltipParams;

                ItemData itemdata = new ItemData();
                try
                {
                    itemdata.id = entry.dyeColor.item.id;
                    itemdata.name = entry.dyeColor.item.name;
                    itemdata.icon = entry.dyeColor.item.icon;
                    itemdata.displayColor = entry.dyeColor.item.displayColor;
                    itemdata.tooltipParams = entry.dyeColor.item.tooltipParams;
                    armorpiece.dyeColor = itemdata;
                }
                catch (Exception e)
                {
                    armorpiece.dyeColor = null;
                }

                try
                {
                    itemdata = new ItemData();
                    itemdata.id = entry.transmogItem.id;
                    itemdata.name = entry.transmogItem.name;
                    itemdata.icon = entry.transmogItem.icon;
                    itemdata.displayColor = entry.transmogItem.displayColor;
                    itemdata.tooltipParams = entry.transmogItem.tooltipParams;
                    armorpiece.transmogItem = itemdata;
                }
                catch (Exception e)
                {
                    armorpiece.transmogItem = null;
                }

                try
                {
                    List<String> setItems = new List<String>();
                    foreach (var item in entry.setItemsEquipped)
                    {
                        setItems.Add(item.ToString());
                    }
                    armorpiece.setItemsEquipped = setItems;
                }
                catch (Exception e)
                {
                    armorpiece.setItemsEquipped = null;
                }

                armorData.Add(itemData.Name, armorpiece);
            }

            return armorData;
        }

        private List<ActiveSkillData> activeSkillGenerator(dynamic json)
        {
            List<ActiveSkillData> activeSkills = new List<ActiveSkillData>();
            foreach (var entry in json.skills.active)
            {
                try
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

                    activeSkills.Add(active);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return activeSkills;
        }

        private List<PassiveSkillData> passiveSkillGenerator(dynamic json)
        {
            List<PassiveSkillData> passiveSkills = new List<PassiveSkillData>();

            foreach (var entry in json.skills.passive)
            {
                PassiveSkillData passive = new PassiveSkillData();

                try
                {
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

                    passiveSkills.Add(passive);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return passiveSkills;
        }

        public List<CharacterData> getModel()
        {
            return cd;
        }
    }
}
