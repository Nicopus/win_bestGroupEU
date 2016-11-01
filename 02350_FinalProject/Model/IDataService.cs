using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02350_FinalProject.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}
