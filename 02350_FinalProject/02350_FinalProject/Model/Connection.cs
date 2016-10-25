using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_FinalProject.Model
{
    public class Connection: IConnection
    {
        public int FromNumber { get; set; }
        public string FromMultiplicity { get; set; }
        public int ToNumber { get; set; }
        public string ToMultiplicity { get; set; }
        public string Label { get; set; }
        public EConnection Type { get; set; }
    }
}
