using Diablo3Viewer.DataModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diablo3Viewer.TabPageCreators
{
    class EquipmentTabPageCreator
    {
        private TabControl tabControl;
        private List<CharacterData> chdata;

        public EquipmentTabPageCreator(TabControl tabControl, List<CharacterData> chdata)
        {
            this.tabControl = tabControl;
            this.chdata = chdata;
        }

        public void startCreating()
        {
            foreach(CharacterData ch in chdata){

                TabPage characterTab = new TabPage();

                characterTab.Text = ch.name;

                characterTab.BackgroundImageLayout = ImageLayout.None;
                characterTab.BackgroundImage = Image.FromFile(getPictureURL(ch.className, ch.gender));

                addItemIcons(ch, characterTab);




                tabControl.TabPages.Add(characterTab);
            }

            tabControl.Visible = true;
        }

        private void addItemIcons(CharacterData ch, TabPage page)
        {
            foreach (KeyValuePair<string, ArmorPieceData> item in ch.items.items)
            {
                Image itemIcon;
                string url = "http://media.blizzard.com/d3/icons/"
                           + "items"
                           + "/"
                           + "large"
                           + "/"
                           + item.Value.icon
                           + ".png";

                try
                {
                    HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    Stream stream = httpWebReponse.GetResponseStream();
                    itemIcon = Image.FromStream(stream);
                }
                catch (WebException) { }

                switch (item.Key)
                {
                    case "head":

                        break;
                    case "torso":

                        break;
                    case "feet":

                        break;
                    case "hands":

                        break;
                    case "shoulders":

                        break;
                    case "legs":

                        break;
                    case "bracers":

                        break;
                    case "mainHand":

                        break;
                    case "waist":

                        break;
                    case "rightFinger":

                        break;
                    case "leftFinger":

                        break;
                    case "offHand":

                        break;
                    case "neck":

                        break;
                }

                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox"+item.Key,
                    Size = new Size(316, 320),
                    Location = new Point(1, iCtr * 1100 + 1),
                    Visible = true
                };
            }
        }

        private string getPictureURL(string className, int gender)
        {
            string path = @"Pictures";
            string genderString = "";

            if (gender == 1)
            {
                genderString = "_female.jpg";
            }
            else if (gender == 0)
            {
                genderString = "_male.jpg";
            }

            return Path.Combine(path, className+genderString);
        }

    }
}
