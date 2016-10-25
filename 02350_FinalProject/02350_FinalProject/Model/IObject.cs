using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350_FinalProject.Model
{
    public interface IObject
    {
        List<string> Data { get; set; }
        int Number { get; }
        EObject Type { get; }
        double Width { get; }
        double Height { get; }
        double X { get; }
        double Y { get; }
    }
}
