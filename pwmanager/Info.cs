using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwmanager {
    [Serializable]
    public class Info {
        public Info() { }
        public string label { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string date { get; set; }
    }
}
