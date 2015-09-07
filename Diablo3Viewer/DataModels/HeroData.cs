using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class HeroData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string className { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public KillData kills { get; set; }
        public int paragonLevel { get; set; }
        public bool hardcore { get; set; }
        public bool seasonal { get; set; }
        public long lastUpdated { get; set; }
        public bool dead { get; set; }
    }
}
