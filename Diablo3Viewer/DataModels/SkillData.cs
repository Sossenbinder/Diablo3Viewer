using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class SkillData
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int level { get; set; }
        public string categorySlug { get; set; }
        public string tooltipUrl { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public char skillCalcId { get; set; }
        public string flavor { get; set; }
    }
}
