using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diablo3Viewer.DataModels
{
    class ArmorPieceData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string displayColor { get; set; }
        public string tooltipParams { get; set; }
        public ItemData dyeColor { get; set; }
        public ItemData transmogItem { get; set; }
        public List<String> setItemsEquipped { get; set; }
    }
}
