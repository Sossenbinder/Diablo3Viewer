using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class SkillsData
    {
        public List<ActiveSkillData> active { get; set; }
        public List<PassiveSkillData> passive { get; set; }
    }
}
