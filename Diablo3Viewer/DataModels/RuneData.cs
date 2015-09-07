using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Viewer.DataModels
{
    class RuneData
    {
        public string slug { get; set; }
        public char type { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string description { get; set; }
        public string simpleDescription { get; set; }
        public string tooltipParams { get; set; }
        public char skillCalcId { get; set; }
        public int order { get; set; }
    }
}
