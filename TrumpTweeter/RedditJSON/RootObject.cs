using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpTweeter.RedditJSON
{
    public class RootObject
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }
}
