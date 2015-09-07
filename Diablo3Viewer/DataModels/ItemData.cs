using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class ItemData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public ItemData dyeColor { get; set; }
        public ItemData transmogItem { get; set; }
        public List<string> setItemsEquipped { get; set; }
    }
}
