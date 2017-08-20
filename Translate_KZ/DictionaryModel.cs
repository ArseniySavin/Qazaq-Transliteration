using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate_KZ
{
    internal class DictionaryModel
    {
        public string name { get; set; }
        public string title { get; set; }
        public string dict_type { get; set; }
        public Dictionary<string, string> dict { get; set; }
    }


}
