using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class SeasonalProfiles
    {
        public int seasonID { get; set; }
        public int paragonLevel { get; set; }
        public int paragonLevelHardcore { get; set; }
        public KillData kills { get; set; }
        public PlayTime timePlayed { get; set; }
        public int highestHardcoreLevel { get; set; }
        public Progression progression { get; set; }
    }
}
